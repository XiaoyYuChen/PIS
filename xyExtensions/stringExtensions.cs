using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace xyExtensions
{
    public static class stringExtensions
    {
        public static Dictionary<string, Regex> regs = new Dictionary<string, Regex>();
        static stringExtensions()
        {
            regs.Add("大专院校", new Regex("(大学|学院|学校)"));
            regs.Add("工矿企业", new Regex("(公司|厂|会社|基地|集团|公旬)"));
            regs.Add("事业单位", new Regex("(医院|部队|解放军|局|政府)"));
            regs.Add("科研单位", new Regex("(科学院|工程院|研究|科研|研制|财团)"));
        }
        public static string Left(this string obj, int length)
        {
            if (obj.Length > length)
            {
                return obj.Substring(0, length);
            }
            else
            {
                return obj;
            }
        }
        /// <summary>
        /// 申请号8位转12位
        /// </summary>
        /// <param name="_strApNo">申请号为8位或12位</param>
        /// <returns></returns>
        public static string ApNo8To12(this string obj)
        {
            if (obj == null)
            {
                throw new Exception("申请号格式错误！");
            }
            string strRetu = "";
            strRetu = obj.Trim();
            switch (strRetu.Length)
            {
                case 8:
                case 9:
                    if (strRetu.Substring(0, 1) == "0")
                    {
                        strRetu = string.Format("20{0}00{1}", obj.Substring(0, 3), obj.Substring(3, 5));
                    }
                    else
                    {
                        strRetu = string.Format("19{0}00{1}", obj.Substring(0, 3), obj.Substring(3, 5));
                    }
                    break;
                case 12:
                    break;
                case 13:
                    strRetu = strRetu.Substring(0, 12);
                    break;
                default:
                    throw new Exception("申请号格式错误！");
            }

            return strRetu;
        }
        public static string FormatIPC(this string obj)
        {
            int index = obj.IndexOf("/");
            string left = "";
            string right = "";
            if (index > 0)
            {
                left = obj.Substring(0, index);
                right = obj.Substring(index+1);
                if (left.Length < 7)
                {
                    int def = 7 - left.Length;
                    left = left.Insert(4, " ".PadRight(def, ' ')) + "/";
                }
                else
                {
                    left = left.Substring(0, 7) + "/";
                }
            }
            else
            {
                left = obj;
            }
            return left + right;
        }
        public static string FormatDate(this string obj)
        {
            if (obj == null) return string.Empty;
            string date = obj.ToString().Trim();
            if (string.IsNullOrEmpty(date.Trim()))
            {
                return date;
            }
            else
            {
                if (obj.Length == 8) return obj;

                try
                {
                    DateTime dt = DateTime.Parse(date);
                    return dt.ToString("yyyyMMdd");
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        public static int GetYear(this string obj)
        {
            int year = 1800;
            if (obj == null) return year;
            if (obj == "") return year;
            if (obj.Length <4) return year;
            int.TryParse(obj.ToString().Trim().Substring(0, 4), out year);
            return year;
        }
        public static sbyte ToSbyte(this string obj)
        {
            sbyte year = 0;
            if (obj == null) return year;
            sbyte.TryParse(obj.ToString().Trim(), out year);
            return year;
        }
        public static int ToInt(this string obj)
        {
            int year = 0;
            if (obj == null) return year;
            int.TryParse(obj.ToString().Trim(), out year);
            return year;
        }
        public static string GetPaType(this string pa)
        {
            string type = "";
            bool isMatch = false;
            if (pa.Length <= 3)
            {
                type = "个人";
            }
            else
            {
                Dictionary<string, int> typeindex = new Dictionary<string, int>();
                foreach (var x in regs)
                {
                    Match mh = x.Value.Match(pa);
                    if (mh.Success)
                    {
                        type = x.Key;
                        isMatch = true;
                        typeindex.Add(x.Key, mh.Index);
                    }
                    else
                    {
                        typeindex.Add(x.Key, 0);
                    }
                }
                var RightIndex = (from y in typeindex
                                  orderby y.Value descending
                                  select y).First();
                type = RightIndex.Key;

                if (!isMatch)
                {
                    //带点儿的 英文名字 或者 4个字的人名，小日本名字
                    if (pa.IndexOf("·") > 0 || pa.Length == 4)
                    {
                        type = "个人";
                    }
                    else
                    {
                        type = "其它";
                    }
                }
            }
            return type;
        }
    }
}
