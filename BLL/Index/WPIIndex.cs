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
    public class WPIIndex
    {
        public static Dictionary<string, string> zhouguo = new Dictionary<string, string>();
        static WPIIndex()
        {
        }
        public static Regex regPr = new Regex("\\d{4}-\\d{1,2}-\\d{1,2}");
        public static Regex regap = new Regex("\\[[^\\]]*\\]");
        private static Regex regnoap = new Regex("(Cont of|Based on|Div Ex)");
        private static Regex regwogj = new Regex("(?<gj>[A-Za-z]{2})");
        private static Regex regPnsplit = new Regex("DW\\d{3,8}");
        private static Regex regspace = new Regex("\\s{2,}");

        public static STDT AutoIndex(ShowBase sb, out List<STPa> pa, out List<STIV> iv, out List<STIpc> ic, out List<STPR> pr, out List<STPNS> pn, out List<STAnS> an, out List<STDMc> dc)
        {
            STDT st = new STDT() { ZTID = sb.ZTID, SiD = sb.SiD, ImportDate = sb.ImportDate };
            pa = new List<STPa>();
            iv = new List<STIV>();
            ic = new List<STIpc>();
            pr = new List<STPR>();
            pn = new List<STPNS>();
            an = new List<STAnS>();
            dc = new List<STDMc>();
            int i = 0;

            if (sb.An != null)
            {
                string[] ans = sb.An.Split(';');


                List<string> gjs = new List<string>();
                foreach (var stran in ans)
                {
                    if (stran.Trim() == "") continue;
                    i++;
                    STAnS tmpan = new STAnS() { SiD = sb.SiD };
                    string tmpstran = "";
                    string tmpstrad = "";
                    //如果是Cont of|Based on 是优先权或者公开号 不记录
                    if (regnoap.Match(stran).Success) continue;
                    string[] arytmpstran = regspace.Replace(regap.Replace(stran, "").Trim(), " ").Trim().Split(' ');
                    if (arytmpstran.Length == 2)
                    {
                        tmpstran = arytmpstran[0].Trim();
                        tmpstrad = arytmpstran[1].Trim();
                    }
                    else
                    {
                        tmpstran = arytmpstran[0].Trim();
                    }

                    tmpan.An = tmpstran;
                    tmpan.Ad = tmpstrad;
                    tmpan.AdY = tmpstrad.GetYear().ToString();
                    tmpan.Sort = (SByte)i;
                    string gj = tmpstran.Left(2).ToUpper();
                    if (gj == "WO")
                    {
                        Match mh = regwogj.Match(tmpstran);
                        if (mh.Success)
                        {
                            gj = mh.Groups["gj"].Value;
                        }
                    }
                    if (!gjs.Contains(gj))
                    {
                        gjs.Add(gj);
                    }
                    tmpan.AnGJ = gj;
                    an.Add(tmpan);
                }
                if (an.Count > 0)
                {
                    st.An = an[0].An;
                    st.Ad = an[0].Ad.FormatDate();
                    st.AdY = Convert.ToInt32(st.Ad.GetYear());
                }
                if (gjs.Count > 3)
                {
                    if (gjs.Contains("US") && gjs.Contains("WO") && gjs.Contains("JP"))
                    {
                        st.IsSanJU = 1;
                    }
                }
                if (gjs.Count > 3)
                {
                    if (gjs.Contains("US") && gjs.Contains("WO") && gjs.Contains("JP") && gjs.Contains("CN") && gjs.Contains("KR"))
                    {
                        st.IsWuJU = 1;
                    }
                }
                st.FMLSum = an.Count;
                st.GJSum = (SByte)gjs.Count;
            }
            if (sb.PN != null)
            {
                //公开  
                string[] pns = regPnsplit.Split(sb.PN);
                i = 0;
                foreach (var strpn in pns)
                {
                    i++;
                    if (strpn.Trim() == "") continue;
                    string tmpns = strpn.Trim();
                    STPNS tmppn = new STPNS() { SiD = sb.SiD };
                    string tmpstrpn = "";
                    string tmpstrpd = "";
                    string[] arytmpns = regspace.Replace(tmpns, " ").Split(' ');
                    switch (arytmpns.Length)
                    {
                        case 3:
                            tmpstrpn = arytmpns[0] + arytmpns[1];
                            tmpstrpd = arytmpns[2];
                            break;
                        case 2:
                            tmpstrpn = arytmpns[0];
                            tmpstrpd = arytmpns[1];
                            break;
                        case 1:
                            tmpstrpn = arytmpns[0];
                            break;
                    }
                    tmppn.PN = tmpstrpn;
                    tmppn.PD = tmpstrpd.FormatDate();
                    tmppn.PDy = tmppn.PD.GetYear().ToString();
                    tmppn.Sort = (SByte)i;
                    tmppn.PNGJ = tmppn.PN.Left(2);
                    pn.Add(tmppn);

                }
                if (pn.Count > 0)
                {
                    st.PN = pn[0].PN;
                    st.PD = pn[0].PD;
                    st.PDy = pn[0].PD.GetYear();
                }
            }
            if (sb.Ipc != null)
            {

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

            if (sb.Pa != null)
            {
                //申请人
                string[] pas = sb.Pa.Split("(".ToArray());
                foreach (var strpa in pas)
                {
                    if (strpa.Trim() == "") continue;
                    i++;
                    string[] arystrpa = strpa.Split(')');
                    string tmppa = "";
                    string cpy = "";
                    if (arystrpa.Length == 2)
                    {
                        tmppa = arystrpa[1].Trim();
                        cpy = arystrpa[0].Trim();
                    }
                    else
                    {
                        tmppa = arystrpa[1].Trim();
                    }
                    pa.Add(new STPa() { SiD = sb.SiD, Pa = tmppa, CPY = cpy, Sort = (SByte)i });
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
            }
            if (sb.DMc != null)
            {
                //德温特分类
                string[] arydmc = sb.DMc.Split(" ".ToArray());
                i = 0;
                foreach (var strdc in arydmc)
                {
                    if (strdc.Trim() == "") continue;
                    i++;
                    dc.Add(new STDMc() { SiD = sb.SiD, DMc = strdc, Sort = (SByte)i });
                }
                if (dc.Count > 0)
                {
                    st.DMcSum = (SByte)dc.Count;
                }
                if (iv.Count > 0)
                {
                    st.FIn = iv[0].IV;
                    st.InSum = (SByte)iv.Count;
                }
            }
            if (sb.PR != null)
            {
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

