using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL.UIHelper;
using BLL.SQLHelper;
using MySql.Data.MySqlClient;
using BLL.Config;
using System.Windows.Forms.DataVisualization.Charting;

namespace PatSI
{
    public partial class frmstat : Form
    {
        public string dbtype;
        public string dbname;
        public int zid;
        public int index = 0;
        private DataTable dt;
        private stcfg stconfg = new stcfg();
        public frmstat()
        {
            InitializeComponent();
            //showLine(inidata());
        }
        public frmstat(string dbname, int zid, string dbtype)
        {
            InitializeComponent();
            this.dbname = dbname;
            this.dbtype = dbtype;
            this.zid = zid;
            this.tabRight.SelectedIndex = 1;
            groupBox3.Visible = false;
        }
        private DataTable inidata()
        {
            Random rm = new Random();
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("年代"));
            dt.Columns.Add(new DataColumn("申请量"));
            dt.Columns.Add(new DataColumn("授权量"));
            for (int i = 1998; i <= 2015; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = i.ToString();
                row[1] = rm.Next(100, 500);
                row[2] = rm.Next(50, 700);
                dt.Rows.Add(row);
            }

            return dt;


        }
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            int width = e.X;

            if (width > 350)
            {
                width = 350;
            }
            if (width < 150)
            {
                width = 23;

            }
            this.panLeft.Width = width;
            resizeMiddlePanel();
        }

        private void splZY_DoubleClick(object sender, EventArgs e)
        {

            if (splZY.Location.X > 23 && splZY.Location.X <= 220)
            {
                this.panLeft.Width = 23;
            }
            else if (splZY.Location.X > 220 && splZY.Location.X < 350)
            {
                this.panLeft.Width = 350;
            }
            else if (splZY.Location.X == 350 || splZY.Location.X == 23)
            {
                this.panLeft.Width = 220;
            }
            resizeMiddlePanel();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            STUIHelper.initLeftTree(this.twLeft, dbtype);
            //DataTable dt = inidata();
            //this.showdata.DataSource = dt;
            //showLine(dt);
        }
        private void showLine(DataTable dt)
        {
            this.chart1.Series.Clear();
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                this.chart1.Series.Add(dt.Columns[i].ColumnName);
            }
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                this.chart1.Series[dt.Columns[i].ColumnName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                this.chart1.Series[dt.Columns[i].ColumnName].IsValueShownAsLabel = true;
                chart1.Series[dt.Columns[i].ColumnName]["LabelStyle"] = "TopRight";
                chart1.Series[dt.Columns[i].ColumnName].MarkerStyle = MarkerStyle.Circle; //圆点

                chart1.Series[dt.Columns[i].ColumnName].BorderWidth = 3;
            }
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    this.chart1.Series[dt.Columns[i].ColumnName].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(Convert.ToDouble(row[0].ToString()), Convert.ToDouble(row[i].ToString())));
                }
            }

        }
        private void showLine1(DataTable dt)
        {
            this.chart1.Series.Clear();
            this.chart1.Series.Add("生命周期");
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                this.chart1.Series["生命周期"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series["生命周期"].MarkerStyle = MarkerStyle.Circle; //圆点
                chart1.Series["生命周期"].MarkerSize = 9; //圆点
                chart1.Series["生命周期"].Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
                chart1.Series["生命周期"].BorderWidth = 3;
                //this.chart1.Series["生命周期"].IsValueShownAsLabel = true;
            }
            index = 0;
            timer1.Enabled = true;



        }


        private void frmstat_Resize(object sender, EventArgs e)
        {
            resizeMiddlePanel();
        }

        private void panLeft_Resize(object sender, EventArgs e)
        {
            resizeMiddlePanel();
        }
        private void spRight_DoubleClick(object sender, EventArgs e)
        {
            this.spRight.Visible = false;
            resizeMiddlePanel();
        }

        private void tabRight_Click(object sender, EventArgs e)
        {
            spRight.Visible = true;
            resizeMiddlePanel();
        }

        private void resizeMiddlePanel()
        {
            int intspleft = 0;
            int intspright = 0;
            int intpanleft = panLeft.Width;
            int intpanlrigh = 250;
            if (splZY.Visible)
            {
                intspleft = 5;
            }
            if (spRight.Visible)
            {
                intspright = 5;
                this.btnCreate.Visible = true;
                this.btnExport.Visible = true;
            }
            else
            {
                intpanlrigh = 35;
                this.btnCreate.Visible = false;
                this.btnExport.Visible = false;
            }
            pnlMiddle.Width = this.Width - intspleft - intspright - intpanleft - intpanlrigh;
        }



        private void twLeft_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0) return;
            string itemname = e.Node.Text;
            this.lib_Name.Text = itemname;
            this.chart1.Titles.Clear();
            this.chart1.Series.Clear();
            this.showdata.Columns.Clear();
            this.chart1.Titles.Add(itemname);
            if (itemname == "专利趋势分析")
            {
                tabRight.TabPages.Remove(tabZhiBiao);
                //tabZhiBiao.Hide();
            }
            STUIHelper.initChartType(cmbChartType, itemname);
            STUIHelper.initCharColumn(cmbYear, dbtype, itemname);
            STUIHelper.initChartZhiBiao(cklist_zhibiao, dbtype, itemname);

        }

        private void tbLeft_Click(object sender, EventArgs e)
        {
            this.panLeft.Width = 220;
            resizeMiddlePanel();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //1.得到统计指标
            //2.得到统计根据
            //3.得到统计表
            //4.得到过滤条件
            string sql;
            switch (this.lib_Name.Text)
            {
                case "专利趋势分析":
                    //
                    sql = QSSTSQLHelper.GetStatSQL(zid.ToString(), cklist_zhibiao, cmbYear, dataGridView4, cmbStartYear, cmbEndYear);
                    dt = DBA.MySqlDbAccess.GetDataTable(CommandType.Text, sql);
                    dt = DataTableHelper.ReadDateTable(dt);
                    this.showdata.DataSource = dt;
                    showdata.Columns[showdata.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    showLine(dt);
                    break;
                case "技术生命周期分析":
                    sql = ST_QS_02.GetStatSQL(zid.ToString(), stconfg, cklist_zhibiao, cmbYear);
                    dt = DBA.MySqlDbAccess.GetDataTable(CommandType.Text, sql);
                    dt = DataTableHelper.ReadDateTable(dt);
                    this.showdata.DataSource = dt;
                    showdata.Columns[showdata.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    showLine1(dt);
                    break;
                case "发明人增速趋势分析":
                    //
                    sql = ST_QS_03.GetStatSQL(zid.ToString(), stconfg, cklist_zhibiao, cmbYear);
                    dt = DBA.MySqlDbAccess.GetDataTable(CommandType.Text, sql);
                    dt = DataTableHelper.ReadDateTable(dt);
                    showLine(dt);
                    dt = DataTableHelper.AddZengSu(dt, 1);
                    this.showdata.DataSource = dt;
                    showdata.Columns[showdata.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case "专利类型分布趋势分析":
                    //
                    sql = ST_QS_04.GetStatSQL(zid.ToString(), stconfg, cklist_zhibiao, cmbYear);
                    dt = DBA.MySqlDbAccess.GetDataTable(CommandType.Text, sql);
                    dt = DataTableHelper.ExchangeRowColumn(dt, new List<string>() { "发明专利", "外观专利", "使用新型" });
                    dt = DataTableHelper.ReadDateTable(dt);
                    showLine(dt);
                    dt = DataTableHelper.AddZengSu(dt, new List<int>() { 1, 2, 3 });
                    this.showdata.DataSource = dt;
                    showdata.Columns[showdata.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
            }
        }

        private void rbYearAll_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbStartYear.Enabled = false;
            this.cmbEndYear.Enabled = false;
            stconfg.EndYear = 0;
            stconfg.StartYear = 0;

        }

        private void rbNear20_CheckedChanged(object sender, EventArgs e)
        {
            nearNyear(20);
        }
        private void nearNyear(int yeardef)
        {
            int year = DateTime.Now.Year - 1;
            stconfg.EndYear = year;
            stconfg.StartYear = year - yeardef - 1;
            this.cmbStartYear.Enabled = true;
            this.cmbEndYear.Enabled = true;
            this.cmbStartYear.Items.Clear();
            this.cmbStartYear.Items.Add(stconfg.StartYear);
            this.cmbEndYear.Items.Clear();
            this.cmbEndYear.Items.Add(year);
            this.cmbStartYear.SelectedIndex = 0;
            this.cmbEndYear.SelectedIndex = 0;
        }

        private void rbNear15_CheckedChanged(object sender, EventArgs e)
        {
            nearNyear(15);
        }

        private void rbNear10_CheckedChanged(object sender, EventArgs e)
        {
            nearNyear(10);
        }

        private void rbYearCustom_CheckedChanged(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            this.cmbStartYear.Enabled = true;
            this.cmbEndYear.Enabled = true;
            this.cmbStartYear.Items.Clear();
            this.cmbEndYear.Items.Clear();
        }

        private void showdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ckbUseFML_CheckedChanged(object sender, EventArgs e)
        {
            stconfg.UseFMl = ckbUseFML.Checked;
        }

        private void chkUseCPY_CheckedChanged(object sender, EventArgs e)
        {
            stconfg.UseCPY = chkUseCPY.Checked;
        }

        private void chkFirstPA_CheckedChanged(object sender, EventArgs e)
        {
            //stconfg.UseFirstPA = chkFirstPA.Checked;
        }

        private void chkFirstIN_CheckedChanged(object sender, EventArgs e)
        {
            //stconfg.UseFirstIN = chkFirstIN.Checked;
        }

        private void cmbStartYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            stconfg.StartYear = Convert.ToInt32(cmbStartYear.Text);
        }

        private void cmbEndYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            stconfg.EndYear = Convert.ToInt32(this.cmbEndYear.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index >= dt.Rows.Count)
            {
                timer1.Enabled = false;
                return;
            }
            DataRow row = dt.Rows[index];
            this.chart1.Series["生命周期"].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(Convert.ToDouble(row[1].ToString()), Convert.ToDouble(row[2].ToString())) { Label = row[0].ToString() + "年" });
            index++;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbChartConfig_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.spRight.Visible = false;
            resizeMiddlePanel();
        }





    }
}
