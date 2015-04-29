using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Template
{
    public class TemplateHelper
    {
        public TemplateHelper(string tmpname)
        {

        }
        /// <summary>
        /// 模板名称
        /// </summary>
        /// <param name="tmpName"></param>
        /// <param name="colName"></param>
        /// <returns></returns>
        public string getMappingColumnName(string colName)
        {
            return colName;
        }
    }
}
