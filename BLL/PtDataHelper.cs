#region Copyright (c) dev Soft All rights reserved
/*****************文件信息*****************************
* 创始信息:
*	Copyright(c) 2008-2015 @ CPIC Corp
*	CLR 版本: 4.0.30319.225
*	文 件 名: PtDataHelper.cs
*	创 建 人: xiwenlei(xiwenlei)
*	创建日期: 2015/4/14 22:02:32
*	版    本: V1.0
*	备注描述: $Myparameter1$           
*
* 修改历史: 
*   ****NO_1:
*	修 改 人: 
*	修改日期: 
*	描    述: $Myparameter1$           
******************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBA;
using BLL.Model;

/// <summary>
/// BLL 的摘要说明
/// </summary>
namespace BLL
{
    /// <summary>
    ///PtDataHelper 的摘要说明
    /// </summary>
    public class PtDataHelper
    {
        private static TbFiledList tbShow_base = new TbFiledList("show_base");

        public static TbFiledList TbShow_base
        {
            get { return PtDataHelper.tbShow_base; }
            set { PtDataHelper.tbShow_base = value; }
        }

       
        static PtDataHelper()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
           
        }

        public static int getPtDataCount(string strWhere)
        {
            int nRs = 0;
            try
            {
                if (!strWhere.Trim().Equals(""))
                {
                    strWhere = " where " + strWhere;
                }
                string strSql = string.Format("select count(*) from {0} {1}", tbShow_base.StrTbName, strWhere);
                nRs = Convert.ToInt32(MySqlDbAccess.ExecuteScalar(CommandType.Text, strSql));
            }
            catch (Exception ex)
            {
            }

            return nRs;
        }

        public static DataTable getPtData(string strWhere, int nPageIdx, int nPageSize)
        {
            DataTable dt = null;

            if (!strWhere.Trim().Equals(""))
            {
                strWhere = " where " + strWhere;
            }
            string strSql = string.Format("select {0} from {1} {2} limit {3},{4}", tbShow_base.ToShowString(), tbShow_base.StrTbName, strWhere, (nPageIdx - 1) * nPageSize, nPageSize);
            dt = MySqlDbAccess.GetDataTable(CommandType.Text, strSql);
            return dt;
        }
    }
}
