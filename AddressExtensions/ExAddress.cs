using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;

namespace AddressExtensions
{
    public static class ExAddress
    {
        private static Regex regSheng = new Regex("^(中国)?(?<sheng>(河北|山西|辽宁|吉林|黑龙江|江苏|浙江|安徽|福建|江西|山东|河南|湖北|湖南|广东|四川|贵州|云南|西藏|陕西|甘肃|青海|海南|台湾))省?");
        private static Regex regShi = new Regex("(?<shi>^(广州|武汉|重庆|西安|沈阳|大连|哈尔滨|青岛|宁波|长春|南京|杭州|济南|成都|厦门|深圳|北京|天津|上海|重庆))市?");
        private static Regex regSheng1 = new Regex("(?<sheng>^(宁夏|新疆|广西|内蒙))(回族|维吾尔|古|维吾尔族)?自治区?");
        private static Regex regShi1 = new Regex("(?<shi>^[^市]{1,10}?市)");
        private static Regex regShi2 = new Regex("(?<shi>^[^市县小区路街]{1,10}?(市|县|区))");
        private static Dictionary<string, string> DicSheng = new Dictionary<string, string>();
        private static Dictionary<string, string> Diamas = new Dictionary<string, string>();
        private static Dictionary<string, string> Zips = new Dictionary<string, string>();
        private static Dictionary<string, string> Redirect = new Dictionary<string, string>();
        private static Dictionary<string, string> Merge = new Dictionary<string, string>();
        static ExAddress()
        {

            #region daima
            DicSheng.Add("13", "河北");
            DicSheng.Add("14", "山西");
            DicSheng.Add("15", "内蒙");
            DicSheng.Add("21", "辽宁");
            DicSheng.Add("22", "吉林");
            DicSheng.Add("23", "黑龙江");
            DicSheng.Add("32", "江苏");
            DicSheng.Add("33", "浙江");
            DicSheng.Add("34", "安徽");
            DicSheng.Add("35", "福建");
            DicSheng.Add("36", "江西");
            DicSheng.Add("37", "山东");
            DicSheng.Add("41", "河南");
            DicSheng.Add("42", "湖北");
            DicSheng.Add("43", "湖南");
            DicSheng.Add("44", "广东");
            DicSheng.Add("45", "广西");
            DicSheng.Add("51", "四川");
            DicSheng.Add("52", "贵州");
            DicSheng.Add("53", "云南");
            DicSheng.Add("54", "西藏");
            DicSheng.Add("61", "陕西");
            DicSheng.Add("62", "甘肃");
            DicSheng.Add("63", "青海");
            DicSheng.Add("64", "宁夏");
            DicSheng.Add("65", "新疆");
            DicSheng.Add("66", "海南");
            DicSheng.Add("71", "台湾");
            DicSheng.Add("81", "广东");
            DicSheng.Add("83", "湖北");
            DicSheng.Add("87", "陕西");
            DicSheng.Add("89", "辽宁");
            DicSheng.Add("91", "辽宁");
            DicSheng.Add("93", "黑龙江");
            DicSheng.Add("95", "山东");
            DicSheng.Add("97", "浙江");
            DicSheng.Add("82", "吉林");
            DicSheng.Add("84", "江苏");
            DicSheng.Add("86", "浙江");
            DicSheng.Add("88", "山东");
            DicSheng.Add("90", "四川");
            DicSheng.Add("92", "福建");
            DicSheng.Add("94", "广东");
            DicSheng.Add("TW", "台湾");

            Diamas.Add("北京", "11");
            Diamas.Add("天津", "12");
            Diamas.Add("河北", "13");
            Diamas.Add("山西", "14");
            Diamas.Add("内蒙", "15");
            Diamas.Add("辽宁", "21");
            Diamas.Add("吉林", "22");
            Diamas.Add("黑龙江", "23");
            Diamas.Add("上海", "31");
            Diamas.Add("江苏", "32");
            Diamas.Add("浙江", "33");
            Diamas.Add("安徽", "34");
            Diamas.Add("福建", "35");
            Diamas.Add("江西", "36");
            Diamas.Add("山东", "37");
            Diamas.Add("河南", "41");
            Diamas.Add("湖北", "42");
            Diamas.Add("湖南", "43");
            Diamas.Add("广东", "44");
            Diamas.Add("广西", "45");
            Diamas.Add("四川", "51");
            Diamas.Add("贵州", "52");
            Diamas.Add("云南", "53");
            Diamas.Add("西藏", "54");
            Diamas.Add("陕西", "61");
            Diamas.Add("甘肃", "62");
            Diamas.Add("青海", "63");
            Diamas.Add("宁夏", "64");
            Diamas.Add("新疆", "65");
            Diamas.Add("海南", "66");
            Diamas.Add("台湾", "71");
            Diamas.Add("广州", "81");
            Diamas.Add("武汉", "83");
            Diamas.Add("重庆", "85");
            Diamas.Add("西安", "87");
            Diamas.Add("沈阳", "89");
            Diamas.Add("大连", "91");
            Diamas.Add("哈尔滨", "93");
            Diamas.Add("青岛", "95");
            Diamas.Add("宁波", "97");
            Diamas.Add("长春", "82");
            Diamas.Add("南京", "84");
            Diamas.Add("杭州", "86");
            Diamas.Add("济南", "88");
            Diamas.Add("成都", "90");
            Diamas.Add("厦门", "92");
            Diamas.Add("深圳", "94");
            #endregion 

            #region 县级市 重定向
            Redirect.Clear();
            Redirect.Add("即墨市", "青岛");
            Redirect.Add("莱西市", "青岛");
            Redirect.Add("胶州市", "青岛");
            Redirect.Add("平度市", "青岛");
            Redirect.Add("胶南市", "青岛");
            Redirect.Add("即墨", "青岛");
            Redirect.Add("莱西", "青岛");            
            Redirect.Add("胶州", "青岛");            
            Redirect.Add("平度", "青岛");
            Redirect.Add("胶南", "青岛");
            Redirect.Add("青岛即墨", "青岛");
            Redirect.Add("青岛莱西", "青岛");
            Redirect.Add("青岛胶州", "青岛");
            Redirect.Add("青岛平度", "青岛");
            Redirect.Add("青岛胶南", "青岛");
            #endregion
            
            #region 市区 合并
            Merge.Add("四方区", "市北区");
            Merge.Add("黄岛区", "西海岸新区");
            Merge.Add("胶南区", "西海岸新区");
            Merge.Add("青岛开发区", "西海岸新区");
            Merge.Add("青岛经济开发区", "西海岸新区");
            Merge.Add("青岛经济技术开发区", "西海岸新区");
            Merge.Add("高新开发区", "西海岸新区");            
            Merge.Add("经济开发区", "西海岸新区");
            Merge.Add("经济技术开发区", "西海岸新区");
            Merge.Add("胶州经济开发区", "胶州市");
            Merge.Add("青岛胶南", "胶南市");
            Merge.Add("南区", "市南区");
            Merge.Add("北区", "市北区");
            
                
                
            
            

            #endregion

            #region 邮编
            using (StreamReader sr = new StreamReader("zip.txt",Encoding.GetEncoding("gb2312")))
            {
                while (!sr.EndOfStream)
                {
                    string rl = sr.ReadLine();
                    Zips.Add(rl.Substring(0, 6), rl.Substring(7));
                }
            }
            #endregion
        }
        public static string[] AddressToShengShiQuXianAddress(this string obj)
        {
            string sheng = "";
            string shi = "";
            string quxian = "";
            string NC = "";
            string address = obj.ToString();
            Match mt2 = regShi.Match(address);
            if (mt2.Success)
            {

                shi = mt2.Groups["shi"].Value;
                NC = Diamas[shi];
                if (shi == "北京" || shi == "天津" || shi == "上海" || shi == "重庆")
                {
                    sheng = shi;
                }
                else
                {
                    sheng = DicSheng[NC];
                }
                address = address.Substring(mt2.Index + mt2.Length);
                //匹配出二级市县
                Match mtshi1 = regShi2.Match(address);
                if (mtshi1.Success)
                {
                    quxian = mtshi1.Groups["shi"].Value.ToString();
                    //书写最规整的- **省**市**(市县）
                }
            }
            else
            {
                Match mtsheng = regSheng.Match(address);
                Match mtsheng1 = regSheng1.Match(address);
                //匹配省
                if (mtsheng.Success || mtsheng1.Success)
                {
                    sheng = (mtsheng.Success ? mtsheng.Groups["sheng"].Value : mtsheng1.Groups["sheng"].Value);
                    NC = Diamas[sheng];
                    int index = (mtsheng.Success ? mtsheng.Index : mtsheng1.Index);
                    int length = (mtsheng.Success ? mtsheng.Length : mtsheng1.Length);
                    address = address.Substring(index + length);

                    Match mtshi1 = regShi1.Match(address);
                    //匹配出第一个市
                    if (mtshi1.Success)
                    {
                        //**省**市****
                        shi = mtshi1.Groups["shi"].Value.ToString().Replace("市", "");
                        address = address.Substring(mtshi1.Index + mtshi1.Length);
                        //匹配出二级市县
                        mtshi1 = regShi2.Match(address);
                        if (mtshi1.Success)
                        {
                            quxian = mtshi1.Groups["shi"].Value.ToString();
                            //书写最规整的- **省**市**(市县）
                        }
                    }
                }
            }
            //如果配出来的市：县级市 == 重定向出 县级市所在的市
            if(Redirect.ContainsKey(shi))
            {
                quxian = shi+ "市";
                shi = Redirect[shi];
            }

            if (Merge.ContainsKey(quxian))
            {
                quxian = Merge[quxian];
            }

            return new string[] { NC, sheng,shi,quxian};
        }

        public static string[] ZipToShengShiQuXians(this string obj)
        {

            if (Zips.ContainsKey(obj))
            {
                string nssq = Zips[obj];
                string[] tmp = nssq.Split('|');
                if (Diamas.ContainsKey(tmp[0]))
                {
                    return new string[] { Diamas[tmp[0]], tmp[0], tmp[1], tmp[2] };
                }
                else
                {
                    return new string[] { "", "", "", "" };
                }
            }
            else
            {
                return new string[] { "", "", "", "" };
            }
            
        }
    }
}
