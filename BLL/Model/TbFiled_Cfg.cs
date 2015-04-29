using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Model
{
    /// <summary>
    /// 数据库字段描述配置
    /// </summary>
    public class TbFiled_Cfg
    {
        private TbFiled_Cfg()
        {
        }

        public TbFiled_Cfg(string strName, string strNameCn, bool isShow, bool isReadOnly)
        {
            strFiledNameCn = strNameCn;
            strFiledName = strName;
            this.isShow = isShow;
            this.readOnly = isReadOnly;
        }

        public TbFiled_Cfg(string strName, string strNameCn, string isShow, string isReadOnly)
            : this(strName, strNameCn, isShow == "0" ? false : true, isReadOnly == "0" ? false : true)
        {
           
        }

        private string strFiledName = "";

        /// <summary>
        /// 英文字段名称
        /// </summary>
        public string StrFiledName
        {
            get { return strFiledName; }
            set { strFiledName = value; }
        }
        private string strFiledNameCn = "";

        /// <summary>
        /// 中文字段名称
        /// </summary>
        public string StrFiledNameCn
        {
            get { return strFiledNameCn; }
            set { strFiledNameCn = value; }
        }

        private bool isShow = true;


        /// <summary>
        /// 是否显示
        /// </summary>
        public bool IsShow
        {
            get { return isShow; }
            set { isShow = value; }
        }

        public override string ToString()
        {
            return strFiledNameCn;
        }


        private bool readOnly = false;

        /// <summary>
        /// 只读项，不可编辑
        /// </summary>
        public bool ReadOnly
        {
            get { return readOnly; }
            set { readOnly = value; }
        }
    }
}
