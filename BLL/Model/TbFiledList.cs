#region Copyright (c) dev Soft All rights reserved
/*****************文件信息*****************************
* 创始信息:
*	Copyright(c) 2008-2015 @ CPIC Corp
*	CLR 版本: 4.0.30319.225
*	文 件 名: TbFiledList.cs
*	创 建 人: xiwenlei(xiwenlei)
*	创建日期: 2015/4/15 12:25:40
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
using System.Xml.Linq;
using System.IO;

/// <summary>
/// BLL.Model 的摘要说明
/// </summary>
namespace BLL.Model
{
    /// <summary>
    ///TbFiledList 的摘要说明
    /// </summary>
    public class TbFiledList : Dictionary<string, TbFiled_Cfg>
    {
        public TbFiledList(string strTbName)
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
            this.strTbName = strTbName;
            InitCfg();
        }

        private void Add(string key, TbFiled_Cfg value)
        {
            base.Add(key, value);
        }

        public void Add(TbFiled_Cfg value)
        {
            Add(value.StrFiledName, value);



        }

        private void InitCfg()
        {
            string strCfgFile = string.Format(@"Cfg\{0}_cfg.xml", strTbName);

            if (File.Exists(strCfgFile))
            {
                XDocument xRoot = XDocument.Parse(File.ReadAllText(strCfgFile));

                var nodes =
                         from el in xRoot.Descendants("Filed")
                         select el;
                foreach (var node in nodes)
                {
                    this.Add(new TbFiled_Cfg(node.Attribute("name").Value, node.Attribute("nameCn").Value, node.Attribute("isShow").Value
                        , node.Attribute("ReadOnly").Value));
                }
            }
        }


        private string strTbName = "";

        public string StrTbName
        {
            get { return strTbName; }
            set { strTbName = value; }
        }

        public string ToString()
        {
            string strRs = "";
            foreach (TbFiled_Cfg item in this.Values)
            {
                strRs += string.Format(",{0} as {1}", item.StrFiledName, item.StrFiledNameCn);
            }
            strRs = strRs.TrimStart(',');
            return strRs;
        }

        public string ToShowString()
        {

            string strRs = "";
            foreach (TbFiled_Cfg item in this.Values)
            {
                if (item.IsShow)
                {
                    strRs += string.Format(",{0} as {1}", item.StrFiledName, item.StrFiledNameCn);
                }
            }
            strRs = strRs.TrimStart(',');
            return strRs;
        }


    }
}
