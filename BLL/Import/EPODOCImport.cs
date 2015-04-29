using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IData;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using DAL;
using BLL.Index;
using BLL.Template;
using xyExtensions;

namespace BLL.Import
{
    public class EPODOCImport : IDataImport, IDisposable
    {

        private string filename;
        private DataType type;
        private StreamReader sr;
        private Dictionary<string, string> row;
        private Encoding encodeing;
        private int RowIndex;
        private string ztname;
        private int zid;
        private bool autoindex = true;
        public Thread thimport;


        private Regex regRowSplit = new Regex("\\d{1,10}/\\d{1,10} - \\(C\\) EPODOC / EPO");
        private Regex MarkReplece = new Regex("\\s{1,2}(AB|AN|AP|CCA|CCI|CT|CTNP|EC|FAMN|FI|FT|ICAI|IN|NPR|OPD|PA|PD|PN|PR|RF|RFAP|RFNP|RID|TI|UC)\\s{0,4}-\\s");
        private Regex regcharRNT = new Regex("(\\r|\\n|#[/]?CMT#)*");
        private Regex regspace = new Regex("\\s{4,}");
        private Regex rowRege = new Regex("【(?<colname>[^】]*)】(?<colval>[^【]*)");
        private string kunkaojin = Encoding.GetEncoding("utf-8").GetString(new byte[] { 0xEF, 0xBF, 0xBD, 0xEF, 0xBF, 0xBD });
        public event ValueChangedEventHandler ShowProcess;
        public event SetMaxValueEventHander SetMaxProcess;
        public EPODOCImport(string filename, string ztname, int zid)
        {
            this.type = DataType.CPRS;
            this.zid = zid;
            this.filename = filename;
            encodeing = Encoding.UTF8;
            sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read), encodeing);
        }



        public string FilePath
        {
            get
            {
                return filename;
            }
            set
            {
                this.filename = value;
            }
        }

        public DataType Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }

        public Dictionary<string, string> Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public string ztName
        {
            get
            {
                return ztname;
            }
            set
            {
                ztname = value;
            }
        }

        public int Zid
        {
            get
            {
                return zid;
            }
            set
            {
                zid = value;
            }
        }

        public bool Import()
        {
            string s = sr.ReadToEnd().Replace(kunkaojin, "");
            TemplateHelper tmph = new TemplateHelper("");
            string[] arys = regRowSplit.Split(s);
            List<ShowBase> sbs = new List<ShowBase>();
            List<STPa> pas = new List<STPa>();
            List<STIV> ivs = new List<STIV>();
            List<STIpc> ipcs = new List<STIpc>();
            List<STPR> prs = new List<STPR>();
            List<STDT> dts = new List<STDT>();
            List<STFML> fmls = new List<STFML>();
            int count = arys.Length - 1;
            SetMaxProcess(this, count);
            thimport = new Thread(() =>
            {
                //第一行为空
                for (int i = 1; i <= count; i++)
                {
                    string tmp = regspace.Replace(regcharRNT.Replace(arys[i], ""), " ");
                    tmp = MarkReplece.Replace(tmp, "【$1】").Trim();
                    MatchCollection mhs = rowRege.Matches(tmp);
                    ShowBase sb = new ShowBase() { An = "", SiD = "", Ipc = "", Pa = "", IV = "", PN = "" };
                    sb.ZTID = zid;
                    sb.ImportDate = DateTime.Now;

                    foreach (Match m in mhs)
                    {
                        string colname = m.Groups["colname"].Value;
                        string val = m.Groups["colval"].Value.Trim().Trim('\t');
                        string mappingcolname = tmph.getMappingColumnName(colname);
                        switch (mappingcolname)
                        {
                            case "AN":
                                sb.SiD = val;
                                break;
                            case "AP":
                                sb.An = val;
                                break;
                            case "TI":
                                sb.Title = val;
                                break;
                            case "CCA":
                            case "CCI":
                                if (sb.Ipc == null)
                                {
                                    sb.Ipc = val;
                                }
                                else
                                {
                                    sb.Ipc += ";" + val;
                                }

                                break;
                            case "PA":
                                sb.Pa = val;
                                break;
                            case "CPY":
                                sb.CPY = val;
                                break;
                            case "OPD":
                                sb.OpD = val;
                                break;
                            case "AB":
                                sb.ABs = val;
                                break;
                            case "IN":
                                sb.IV = val;
                                break;
                            case "PN":
                                sb.PN = val;
                                break;
                            case "PR":
                                sb.PR = val;
                                break;
                            case "PD":
                                sb.PD = val;
                                break;
                            case "DS":
                                sb.DS = val;
                                break;
                            case "FAMN":
                                sb.FaMN = val;
                                break;
                            case "CT":
                                sb.Ct = val;
                                break;
                            case "CTNP":
                                sb.CtNP = val;
                                break;
                            case "FI":
                                sb.FI = val;
                                break;
                            case "FT":
                                sb.FT = val;
                                break;
                            case "RF":
                                sb.RF = val;
                                break;
                            case "RFAP":
                                sb.RFaP = val;
                                break;
                            case "RFNP":
                                sb.RFNP = val;
                                break;

                        }
                    }
                    sbs.Add(sb);

                    List<STPa> pa = new List<STPa>();
                    List<STIV> iv = new List<STIV>();
                    List<STIpc> ipc = new List<STIpc>();
                    List<STPR> pr = new List<STPR>();
                    List<STFML> fml = new List<STFML>();
                    dts.Add(EPODOCIndex.AutoIndex(sb, out pa, out iv, out ipc, out pr, out fml));
                    pas.AddRange(pa);
                    ivs.AddRange(iv);
                    ipcs.AddRange(ipc);
                    prs.AddRange(pr);
                    if (i % 100 == 0)
                    {

                        //Thread.Sleep(1000);
                        //todo:标引
                        //todo:标引信息入库

                        //todo:基本信息入库
                        //BulkInsert(sbs);
                        BulkInsert(sbs, pas, ivs, ipcs, prs, fml, dts);
                        sbs.Clear();
                        pas.Clear();
                        ivs.Clear();
                        ipcs.Clear();
                        prs.Clear();
                        dts.Clear();
                        fml.Clear();
                        ShowProcess(this, i, "导入");
                    }

                }
                if (sbs.Count > 0)
                {
                    BulkInsert(sbs, pas, ivs, ipcs, prs, fmls, dts);
                    sbs.Clear();
                    pas.Clear();
                    ivs.Clear();
                    ipcs.Clear();
                    prs.Clear();
                    dts.Clear();
                    fmls.Clear();
                }

                ShowProcess(this, count, "导入完毕");

                sr.Close();
                sr.Dispose();

            });
            thimport.Start();
            return true;
        }
        private bool BulkInsert(List<ShowBase> sbs, List<STPa> pa, List<STIV> iv, List<STIpc> ic, List<STPR> pr, List<STFML> fml, List<STDT> dt)
        {


            using (MySqlDataContext db = new MySqlDataContext())
            {

                db.ShowBase.BulkInsertPageSize = 100;
                db.STDT.BulkInsertPageSize = 100;
                db.STPa.BulkInsertPageSize = 100;
                db.STIV.BulkInsertPageSize = 100;
                db.STPR.BulkInsertPageSize = 100;
                db.STIpc.BulkInsertPageSize = 100;
                db.STFML.BulkInsertPageSize = 100;

                db.ShowBase.BulkInsert(sbs);
                db.STDT.BulkInsert(dt);
                db.STPa.BulkInsert(pa);
                db.STIV.BulkInsert(iv);
                db.STPR.BulkInsert(pr);
                db.STIpc.BulkInsert(ic);
                db.STFML.BulkInsert(fml);

                db.SubmitChanges();
            }
            return true;
        }
        private bool BulkInsert(List<ShowBase> sbs)
        {
            MySqlDataContext db = new MySqlDataContext();
            db.ShowBase.BulkInsertPageSize = 100;
            db.ShowBase.BulkInsert(sbs);
            db.SubmitChanges();
            sbs.Clear();
            return true;
        }

        public Dictionary<string, string> GetRowData()
        {
            return row;
        }
        public bool CancelImport()
        {
            try
            {
                if (thimport.ThreadState != ThreadState.Aborted)
                {
                    thimport.Abort();
                }
            }
            catch (Exception ex)
            {
            }
            //using (MySql.Data.MySqlClient.MySqlConnection con = DBA.MySqlDbAccess.GetMySqlConnection())
            //{
            //    con.Open();
            //    using (MySql.Data.MySqlClient.MySqlTransaction trans = con.BeginTransaction())
            //    {
            //        DBA.MySqlDbAccess.ExecNoQuery(trans,System.Data.CommandType.Text,"delete from show_base where ztid="+this.Zid);
            //        DBA.MySqlDbAccess.ExecNoQuery(trans, System.Data.CommandType.Text, "delete from show_base where ztid=" + this.Zid);
            //        DBA.MySqlDbAccess.ExecNoQuery(trans, System.Data.CommandType.Text, "delete from st_dt where ztid=" + this.Zid);
            //        DBA.MySqlDbAccess.ExecNoQuery(trans, System.Data.CommandType.Text, "delete from st_dt where ztid=" + this.Zid);
            //        DBA.MySqlDbAccess.ExecNoQuery(trans, System.Data.CommandType.Text, "delete from st_dt where ztid=" + this.Zid);
            //        DBA.MySqlDbAccess.ExecNoQuery(trans, System.Data.CommandType.Text, "delete from st_dt where ztid=" + this.Zid);
            //    }
            //}

            return true;

        }
        public void Dispose()
        {
            sr.Close();
            sr.Dispose();
        }

    }
}
