using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL.SQLHelper
{
    public class DataTableHelper
    {
        public static DataTable ExchangeRowColumn(DataTable dt, List<string> columns)
        {
            DataTable dtnew = new DataTable();
            dtnew.Columns.Add(dt.Columns[0].ColumnName);
            foreach (var coluame in columns)
            {
                dtnew.Columns.Add(coluame);
            }

            var res = from y in dt.AsEnumerable()
                      group y by y[0].ToString() into g
                      select g;
            foreach (var x in res)
            {
                DataRow row = dtnew.NewRow();
                row[0] = x.Key;
                foreach (var subrou in x)
                {
                    if (columns.Contains(subrou[1]))
                    {
                        row[subrou[1].ToString()] = subrou[2];
                    }
                }
                for (int i = 1; i < dtnew.Columns.Count; i++)
                {
                    if (row[i].ToString() == "") row[i] = 0;
                }
                dtnew.Rows.Add(row);
            }
            return dtnew;
        }
        public static DataTable AddZengSu(DataTable dt, List<int> columnids)
        {
            foreach (var x in columnids)
            {
                dt = AddZengSu(dt, x);
            }
            return dt;
        }
        public static DataTable AddZengSu(DataTable dt, int columnid)
        {
            string colname = dt.Columns[columnid].ColumnName;
            if (!dt.Columns.Contains(colname + "-增长率"))
            {
                dt.Columns.Add(colname + "-增长率", typeof(string));
            }
            double pryearnum = Convert.ToDouble(dt.Rows[0][columnid].ToString());
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                double nowyearnum = Convert.ToDouble(dt.Rows[i][columnid].ToString());
                if (pryearnum == 0)
                {
                    dt.Rows[i][colname + "-增长率"] = "";
                    pryearnum = nowyearnum;
                    continue;
                }
                dt.Rows[i][colname + "-增长率"] = ((nowyearnum - pryearnum) / pryearnum).ToString("0.00%");
                pryearnum = nowyearnum;
            }
            return dt;
        }

        public static DataTable ReadDateTable(DataTable dt)
        {
            int pryear = 0;
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i][0].ToString().Trim() == string.Empty)
                {
                    dt.Rows.RemoveAt(i);
                }
                else
                {
                    int year = Convert.ToInt32(dt.Rows[i][0].ToString());
                    if (pryear == 0)
                    {
                        pryear = year;
                        continue;
                    }
                    for (int j = pryear - 1; j > year; j--)
                    {
                        DataRow tmprow = dt.NewRow();
                        tmprow[0] = j;
                        for (int m = 1; m < dt.Columns.Count; m++)
                        {
                            tmprow[m] = 0;
                        }
                        dt.Rows.InsertAt(tmprow, i + 1);
                    }
                    pryear = year;
                }
            }
            return dt;
        }

        public static DataTable AddSumRow(DataTable dt)
        {

            DataRow row1 = dt.NewRow();
            double count1 = 0;
            for (int j = 1; j < dt.Columns.Count; j++)
            {

                try
                {
                    foreach (DataRow tmp in dt.Rows)
                    {
                        count1 += Convert.ToDouble(tmp[j].ToString());
                    }
                    row1[j] = count1;
                }
                catch (Exception e)
                {
                    row1[j] = "";
                }

            }
            dt.Rows.Add(row1);
            return dt;
        }

        public static DataTable TopNumRow(DataTable dt, int TOPNum)
        {
            DataRow row = dt.NewRow();
            row[0] = "其它";
            double count = 0;
            for (int j = 1; j < dt.Columns.Count; j++)
            {
                try
                {
                    for (int i = dt.Rows.Count - 1; i >= TOPNum; i--)
                    {
                        count += Convert.ToDouble(dt.Rows[i][j].ToString());

                    }

                    row[j] = count;
                }
                catch (Exception e)
                {
                    row[j] = "";
                }
            }
            for (int i = dt.Rows.Count - 1; i >= TOPNum; i--)
            {

                dt.Rows.RemoveAt(i);
            }
            dt.Rows.Add(row);
            return dt;

        }
    }
}
