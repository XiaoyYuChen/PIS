using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using xyExtensions;
using AddressExtensions;
using System.Text.RegularExpressions;

namespace BLL.Index
{
    public class EPODOCIndex
    {
        public static Dictionary<string, string> zhouguo = new Dictionary<string, string>();
        static EPODOCIndex()
        {
        }
        public static Regex regPr = new Regex("\\d{4}-\\d{1,2}-\\d{1,2}");
        public static Regex regap = new Regex("\\[[^\\]]*\\]");
        private static Regex regnoap = new Regex("(Cont of|Based on|Div Ex)");
        private static Regex regwogj = new Regex("(?<gj>[A-Za-z]{2})");
        private static Regex regPnsplit = new Regex("DW\\d{3,8}");
        private static Regex regspace = new Regex("\\s{2,}");

        public static STDT AutoIndex(ShowBase sb, out List<STPa> pa, out List<STIV> iv, out List<STIpc> ic, out List<STPR> pr, out List<STFML> fml)
        {
            STDT st = new STDT() { ZTID = sb.ZTID, SiD = sb.SiD, ImportDate = sb.ImportDate };
            pa = new List<STPa>();
            iv = new List<STIV>();
            ic = new List<STIpc>();
            pr = new List<STPR>();
            fml = new List<STFML>();

            int i = 0;
            //申请号
            if (sb.An != null)
            {
                string[] ans = sb.An.Trim().Split(' ');
                switch (ans.Length)
                {
                    case 2:
                        st.An = ans[0];
                        st.Ad = ans[1].FormatDate();
                        st.AdY = st.Ad.GetYear();
                        break;
                    case 1:
                        st.An = ans[0];
                        break;
                }
            }
            if (sb.PN != null)
            {
                //公开 
                string[] pns = sb.PN.Trim().Split(' ');
                switch (pns.Length)
                {
                    case 3:
                        st.PN = pns[0] + pns[1];
                        st.PD = pns[2].FormatDate();
                        st.PDy = st.PD.GetYear();
                        break;
                    case 2:
                        st.PN = pns[0];
                        st.PD = pns[1].FormatDate();
                        st.PDy = st.PD.GetYear();
                        break;
                    case 1:
                        st.PN = pns[0];
                        break;
                }
            }
            if (sb.FaMN != null)
            {
                fml.Add(new STFML() { SiD = sb.SiD, FMLid = Convert.ToInt32(sb.FaMN) });
                if (sb.Ipc != null)
                {
                    //IPC           
                    string[] aryipcs = sb.Ipc.Split(';');
                    i = 0;
                    foreach (var stripc in aryipcs)
                    {
                        if (stripc == "") continue;
                        i++;
                        string strtmpipc = stripc.Trim().FormatIPC();
                        STIpc tmpipc = new STIpc() { SiD = sb.SiD };
                        tmpipc.Ipc = strtmpipc.Trim();
                        tmpipc.Ipc1 = strtmpipc.Left(1);
                        tmpipc.Ipc3 = strtmpipc.Left(3);
                        tmpipc.Ipc4 = strtmpipc.Left(4);
                        tmpipc.Ipc7 = strtmpipc.Left(7);
                        tmpipc.Sort = (SByte)i;
                        ic.Add(tmpipc);
                    }
                    if (ic.Count > 0)
                    {
                        st.FIpc = ic[0].Ipc;
                        st.IpcSum = (SByte)ic.Count;
                    }
                }
            }
            if (sb.Pa != null)
            {
                //申请人
                string[] pas = sb.Pa.Split(";".ToArray());
                foreach (var strpa in pas)
                {
                    if (strpa.Trim() == "") continue;
                    i++;
                    pa.Add(new STPa() { SiD = sb.SiD, Pa = strpa.Trim(), Sort = (SByte)i });
                }
                if (pa.Count > 0)
                {
                    st.FPa = pa[0].Pa;
                    st.PaSum = (SByte)pa.Count;
                }
                if (pa.Count > 1)
                {
                    st.IsHeZUO = 1;
                }
            }
            if (sb.IV != null)
            {
                //发明人
                string[] ins = sb.IV.Split("、;；".ToArray());
                i = 0;
                foreach (var strin in ins)
                {
                    if (strin.Trim() == "") continue;
                    i++;
                    iv.Add(new STIV() { SiD = sb.SiD, IV = strin.Trim(), Sort = (SByte)i });
                }
                if (iv.Count > 0)
                {
                    st.FIn = iv[0].IV;
                    st.InSum = (SByte)iv.Count;
                }
                //优先权
                string[] aryprs = sb.PR.Split(";".ToArray());
                i = 0;
                foreach (var strpr in aryprs)
                {
                    string tmpstrpr = strpr.Trim();
                    if (tmpstrpr == "") continue;
                    i++;
                    string[] items = tmpstrpr.Split(' ');
                    if (items.Length == 2)
                    {
                        string prcy = items[0].Substring(0, 2).ToUpper();
                        string prno = items[0];
                        string prdt = items[1];
                        STPR tmpr = new STPR() { SiD = sb.SiD };
                        tmpr.An = prno;
                        tmpr.Ad = prdt;
                        tmpr.GJ = prcy;
                        pr.Add(tmpr);
                    }
                }
            }
            if (sb.OpD != null)
            {
                st.OpD = sb.OpD.FormatDate();
                st.OpDy = st.OpD.ToString().GetYear();
            }



            return st;

        }
    }
}

