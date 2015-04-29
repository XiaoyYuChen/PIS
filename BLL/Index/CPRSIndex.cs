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
    public class CPRSIndex
    {
        public static Dictionary<string, string> zhouguo = new Dictionary<string, string>();
        static CPRSIndex()
        {
            #region 洲国省市
            zhouguo.Add("北京(11)", "亚洲;中国;北京");
            zhouguo.Add("天津(12)", "亚洲;中国;天津");
            zhouguo.Add("河北(13)", "亚洲;中国;河北");
            zhouguo.Add("山西(14)", "亚洲;中国;山西");
            zhouguo.Add("内蒙(15)", "亚洲;中国;内蒙");
            zhouguo.Add("辽宁(21)", "亚洲;中国;辽宁");
            zhouguo.Add("吉林(22)", "亚洲;中国;吉林");
            zhouguo.Add("黑龙江(23)", "亚洲;中国;黑龙江");
            zhouguo.Add("上海(31)", "亚洲;中国;上海");
            zhouguo.Add("江苏(32)", "亚洲;中国;江苏");
            zhouguo.Add("浙江(33)", "亚洲;中国;浙江");
            zhouguo.Add("安徽(34)", "亚洲;中国;安徽");
            zhouguo.Add("福建(35)", "亚洲;中国;福建");
            zhouguo.Add("江西(36)", "亚洲;中国;江西");
            zhouguo.Add("山东(37)", "亚洲;中国;山东");
            zhouguo.Add("河南(41)", "亚洲;中国;河南");
            zhouguo.Add("湖北(42)", "亚洲;中国;湖北");
            zhouguo.Add("湖南(43)", "亚洲;中国;湖南");
            zhouguo.Add("广东(44)", "亚洲;中国;广东");
            zhouguo.Add("广西(45)", "亚洲;中国;广西");
            zhouguo.Add("四川(51)", "亚洲;中国;四川");
            zhouguo.Add("贵州(52)", "亚洲;中国;贵州");
            zhouguo.Add("云南(53)", "亚洲;中国;云南");
            zhouguo.Add("西藏(54)", "亚洲;中国;西藏");
            zhouguo.Add("陕西(61)", "亚洲;中国;陕西");
            zhouguo.Add("甘肃(62)", "亚洲;中国;甘肃");
            zhouguo.Add("青海(63)", "亚洲;中国;青海");
            zhouguo.Add("宁夏(64)", "亚洲;中国;宁夏");
            zhouguo.Add("新疆(65)", "亚洲;中国;新疆");
            zhouguo.Add("海南(66)", "亚洲;中国;海南");
            zhouguo.Add("台湾(71)", "亚洲;中国;台湾");
            zhouguo.Add("广州(81)", "亚洲;中国;广东");
            zhouguo.Add("武汉(83)", "亚洲;中国;湖北");
            zhouguo.Add("重庆(85)", "亚洲;中国;重庆");
            zhouguo.Add("西安(87)", "亚洲;中国;陕西");
            zhouguo.Add("沈阳(89)", "亚洲;中国;辽宁");
            zhouguo.Add("大连(91)", "亚洲;中国;辽宁");
            zhouguo.Add("哈尔滨(93)", "亚洲;中国;黑龙江");
            zhouguo.Add("青岛(95)", "亚洲;中国;山东");
            zhouguo.Add("安道尔(AD)", "欧洲;安道尔;安道尔");
            zhouguo.Add("阿拉伯联合酋长国(AE)", "亚洲;阿拉伯联合酋长国;阿拉伯联合酋长国");
            zhouguo.Add("阿富汗(AF)", "亚洲;阿富汗;阿富汗");
            zhouguo.Add("安提瓜和巴布达(AG)", "北美洲;安提瓜和巴布达;安提瓜和巴布达");
            zhouguo.Add("安圭拉(AI)", "北美洲;安圭拉;安圭拉");
            zhouguo.Add("阿尔巴尼亚(AL)", "欧洲;阿尔巴尼亚;阿尔巴尼亚");
            zhouguo.Add("亚美尼亚(AM)", "亚洲;亚美尼亚;亚美尼亚");
            zhouguo.Add("荷属安的列斯群岛(AN)", "北美洲;荷属安的列斯群岛;荷属安的列斯群岛");
            zhouguo.Add("安哥拉(AO)", "非洲;安哥拉;安哥拉");
            zhouguo.Add("阿根廷(AR)", "南美洲;阿根廷;阿根廷");
            zhouguo.Add("奥地利(AT)", "欧洲;奥地利;奥地利");
            zhouguo.Add("澳大利亚(AU)", "大洋洲;澳大利亚;澳大利亚");
            zhouguo.Add("阿鲁巴(AW)", "北美洲;阿鲁巴;阿鲁巴");
            zhouguo.Add("阿塞拜疆(AZ)", "亚洲;阿塞拜疆;阿塞拜疆");
            zhouguo.Add("巴巴多斯(BB)", "北美洲;巴巴多斯;巴巴多斯");
            zhouguo.Add("孟加拉国(BD)", "亚洲;孟加拉国;孟加拉国");
            zhouguo.Add("比利时(BE)", "欧洲;比利时;比利时");
            zhouguo.Add("布基纳法索(BF)", "非洲;布基纳法索;布基纳法索");
            zhouguo.Add("保加利亚(BG)", "欧洲;保加利亚;保加利亚");
            zhouguo.Add("巴林(BH)", "亚洲;巴林;巴林");
            zhouguo.Add("布隆迪(BI)", "非洲;布隆迪;布隆迪");
            zhouguo.Add("贝宁(BJ)", "非洲;贝宁;贝宁");
            zhouguo.Add("百慕大(BM)", "北美洲;百慕大;百慕大");
            zhouguo.Add("文莱(BN)", "亚洲;文莱;文莱");
            zhouguo.Add("玻利维亚(BO)", "南美洲;玻利维亚;玻利维亚");
            zhouguo.Add("巴西(BR)", "南美洲;巴西;巴西");
            zhouguo.Add("巴哈马(BS)", "北美洲;巴哈马;巴哈马");
            zhouguo.Add("不丹(BT)", "亚洲;不丹;不丹");
            zhouguo.Add("缅甸(BU)", "亚洲;缅甸;缅甸");
            zhouguo.Add("博茨瓦纳(BW)", "非洲;博茨瓦纳;博茨瓦纳");
            zhouguo.Add("白俄罗斯(BY)", "欧洲;白俄罗斯;白俄罗斯");
            zhouguo.Add("伯利兹(BZ)", "北美洲;伯利兹;伯利兹");
            zhouguo.Add("加拿大(CA)", "北美洲;加拿大;加拿大");
            zhouguo.Add("中非共和国(CF)", "非洲;中非共和国;中非共和国");
            zhouguo.Add("刚果(CG)", "非洲;刚果;刚果");
            zhouguo.Add("瑞士(CH)", "欧洲;瑞士;瑞士");
            zhouguo.Add("科特迪瓦(CI)", "非洲;科特迪瓦;科特迪瓦");
            zhouguo.Add("智利(CL)", "南美洲;智利;智利");
            zhouguo.Add("喀麦隆(CM)", "非洲;喀麦隆;喀麦隆");
            zhouguo.Add("中国(CN)", "亚洲;中国;中国");
            zhouguo.Add("哥伦比亚(CO)", "南美洲;哥伦比亚;哥伦比亚");
            zhouguo.Add("哥斯达黎加(CR)", "北美洲;哥斯达黎加;哥斯达黎加");
            zhouguo.Add("捷克斯洛伐克(CS)", "欧洲;捷克斯洛伐克;捷克斯洛伐克");
            zhouguo.Add("古巴(CU)", "北美洲;古巴;古巴");
            zhouguo.Add("怫得角(CV)", "非洲;怫得角;怫得角");
            zhouguo.Add("塞浦路斯(CY)", "亚洲;塞浦路斯;塞浦路斯");
            zhouguo.Add("德国(DE)", "欧洲;德国;德国");
            zhouguo.Add("吉布提(DJ)", "非洲;吉布提;吉布提");
            zhouguo.Add("丹麦(DK)", "欧洲;丹麦;丹麦");
            zhouguo.Add("多米尼加岛(DM)", "南美洲;多米尼加岛;多米尼加岛");
            zhouguo.Add("多米尼加共和国(DO)", "北美洲;多米尼加共和国;多米尼加共和国");
            zhouguo.Add("阿尔及利亚(DZ)", "非洲;阿尔及利亚;阿尔及利亚");
            zhouguo.Add("厄瓜多尔(EC)", "南美洲;厄瓜多尔;厄瓜多尔");
            zhouguo.Add("爱沙尼亚(EE)", "欧洲;爱沙尼亚;爱沙尼亚");
            zhouguo.Add("埃及(EG)", "非洲;埃及;埃及");
            zhouguo.Add("欧洲专利局(EP)", "欧洲;欧洲专利局;欧洲专利局");
            zhouguo.Add("西班牙(ES)", "欧洲;西班牙;西班牙");
            zhouguo.Add("埃塞俄比亚(ET)", "非洲;埃塞俄比亚;埃塞俄比亚");
            zhouguo.Add("芬兰(FI)", "欧洲;芬兰;芬兰");
            zhouguo.Add("斐济(FJ)", "大洋洲;斐济;斐济");
            zhouguo.Add("马尔维纳斯群岛(FK)", "南美洲;马尔维纳斯群岛;马尔维纳斯群岛");
            zhouguo.Add("法国(FR)", "欧洲;法国;法国");
            zhouguo.Add("加蓬(GA)", "非洲;加蓬;加蓬");
            zhouguo.Add("英国(GB)", "欧洲;英国;英国");
            zhouguo.Add("格林那达(GD)", "北美洲;格林那达;格林那达");
            zhouguo.Add("格鲁吉亚(GE)", "亚洲;格鲁吉亚;格鲁吉亚");
            zhouguo.Add("加纳(GH)", "非洲;加纳;加纳");
            zhouguo.Add("直布罗陀(GI)", "欧洲;直布罗陀;直布罗陀");
            zhouguo.Add("冈比亚(GM)", "非洲;冈比亚;冈比亚");
            zhouguo.Add("几内亚(GN)", "非洲;几内亚;几内亚");
            zhouguo.Add("赤道几内亚(GQ)", "非洲;赤道几内亚;赤道几内亚");
            zhouguo.Add("希腊(GR)", "欧洲;希腊;希腊");
            zhouguo.Add("危地马拉(GT)", "北美洲;危地马拉;危地马拉");
            zhouguo.Add("几内亚比绍(GW)", "非洲;几内亚比绍;几内亚比绍");
            zhouguo.Add("圭亚那(GY)", "南美洲;圭亚那;圭亚那");
            zhouguo.Add("香港(HK)", "亚洲;中国;香港");
            zhouguo.Add("洪都拉斯(HN)", "北美洲;洪都拉斯;洪都拉斯");
            zhouguo.Add("克罗地亚(HR)", "欧洲;克罗地亚;克罗地亚");
            zhouguo.Add("海地(HT)", "北美洲;海地;海地");
            zhouguo.Add("匈牙利(HU)", "欧洲;匈牙利;匈牙利");
            zhouguo.Add("上沃尔特(HV)", "非洲;上沃尔特;上沃尔特");
            zhouguo.Add("印度尼西亚(ID)", "亚洲;印度尼西亚;印度尼西亚");
            zhouguo.Add("爱尔兰(IE)", "欧洲;爱尔兰;爱尔兰");
            zhouguo.Add("以色列(IL)", "亚洲;以色列;以色列");
            zhouguo.Add("印度(IN)", "亚洲;印度;印度");
            zhouguo.Add("伊拉克(IQ)", "亚洲;伊拉克;伊拉克");
            zhouguo.Add("伊朗(IR)", "亚洲;伊朗;伊朗");
            zhouguo.Add("冰岛(IS)", "欧洲;冰岛;冰岛");
            zhouguo.Add("意大利(IT)", "欧洲;意大利;意大利");
            zhouguo.Add("泽西岛(JE)", "欧洲;泽西岛;泽西岛");
            zhouguo.Add("牙买加(JM)", "北美洲;牙买加;牙买加");
            zhouguo.Add("约旦(JO)", "亚洲;约旦;约旦");
            zhouguo.Add("日本(JP)", "亚洲;日本;日本");
            zhouguo.Add("肯尼亚(KE)", "非洲;肯尼亚;肯尼亚");
            zhouguo.Add("吉尔吉斯坦(KG)", "亚洲;吉尔吉斯坦;吉尔吉斯坦");
            zhouguo.Add("柬埔寨(KH)", "亚洲;柬埔寨;柬埔寨");
            zhouguo.Add("吉尔伯特群岛(KI)", "亚洲;吉尔伯特群岛;吉尔伯特群岛");
            zhouguo.Add("科摩罗(KM)", "非洲;科摩罗;科摩罗");
            zhouguo.Add("圣克里斯托夫岛(KN)", "非洲;圣克里斯托夫岛;圣克里斯托夫岛");
            zhouguo.Add("朝鲜(KP)", "亚洲;朝鲜;朝鲜");
            zhouguo.Add("韩国(KR)", "亚洲;韩国;韩国");
            zhouguo.Add("科威特(KW)", "亚洲;科威特;科威特");
            zhouguo.Add("开曼群岛(KY)", "北美洲;开曼群岛;开曼群岛");
            zhouguo.Add("哈萨克斯坦(KZ)", "亚洲;哈萨克斯坦;哈萨克斯坦");
            zhouguo.Add("老挝(LA)", "亚洲;老挝;老挝");
            zhouguo.Add("黎巴嫩(LB)", "亚洲;黎巴嫩;黎巴嫩");
            zhouguo.Add("圣卢西亚岛(LC)", "北美洲;圣卢西亚岛;圣卢西亚岛");
            zhouguo.Add("列支敦士登(LI)", "欧洲;列支敦士登;列支敦士登");
            zhouguo.Add("斯里兰卡(LK)", "亚洲;斯里兰卡;斯里兰卡");
            zhouguo.Add("利比里亚(LR)", "非洲;利比里亚;利比里亚");
            zhouguo.Add("莱索托(LS)", "非洲;莱索托;莱索托");
            zhouguo.Add("立陶宛(LT)", "欧洲;立陶宛;立陶宛");
            zhouguo.Add("卢森堡(LU)", "欧洲;卢森堡;卢森堡");
            zhouguo.Add("拉脱维亚(LV)", "欧洲;拉脱维亚;拉脱维亚");
            zhouguo.Add("利比亚(LY)", "非洲;利比亚;利比亚");
            zhouguo.Add("摩洛哥(MA)", "非洲;摩洛哥;摩洛哥");
            zhouguo.Add("摩纳哥(MC)", "欧洲;摩纳哥;摩纳哥");
            zhouguo.Add("莫尔多瓦(MD)", "欧洲;莫尔多瓦;莫尔多瓦");
            zhouguo.Add("马达加斯加(MG)", "非洲;马达加斯加;马达加斯加");
            zhouguo.Add("马里(ML)", "非洲;马里;马里");
            zhouguo.Add("蒙古(MN)", "亚洲;蒙古;蒙古");
            zhouguo.Add("中国澳门(MO)", "亚洲;中国;澳门");
            zhouguo.Add("毛里塔尼亚(MR)", "非洲;毛里塔尼亚;毛里塔尼亚");
            zhouguo.Add("蒙特塞拉特岛(MS)", "北美洲;蒙特塞拉特岛;蒙特塞拉特岛");
            zhouguo.Add("马耳他(MT)", "欧洲;马耳他;马耳他");
            zhouguo.Add("毛里求斯(MU)", "非洲;毛里求斯;毛里求斯");
            zhouguo.Add("马尔代夫(MV)", "亚洲;马尔代夫;马尔代夫");
            zhouguo.Add("马拉维(MW)", "非洲;马拉维;马拉维");
            zhouguo.Add("墨西哥(MX)", "北美洲;墨西哥;墨西哥");
            zhouguo.Add("马来西亚(MY)", "亚洲;马来西亚;马来西亚");
            zhouguo.Add("莫桑比克(MZ)", "非洲;莫桑比克;莫桑比克");
            zhouguo.Add("纳米比亚(NA)", "非洲;纳米比亚;纳米比亚");
            zhouguo.Add("尼日尔(NE)", "非洲;尼日尔;尼日尔");
            zhouguo.Add("尼日利亚(NG)", "非洲;尼日利亚;尼日利亚");
            zhouguo.Add("新赫布里底(NH)", "大洋洲;新赫布里底;新赫布里底");
            zhouguo.Add("尼加拉瓜(NI)", "北美洲;尼加拉瓜;尼加拉瓜");
            zhouguo.Add("荷兰(NL)", "欧洲;荷兰;荷兰");
            zhouguo.Add("挪威(NO)", "欧洲;挪威;挪威");
            zhouguo.Add("尼泊尔(NP)", "亚洲;尼泊尔;尼泊尔");
            zhouguo.Add("瑙鲁(NR)", "大洋洲;瑙鲁;瑙鲁");
            zhouguo.Add("新西兰(NZ)", "大洋洲;新西兰;新西兰");
            zhouguo.Add("非洲知识产权组织(OA)", "非洲;非洲知识产权组织;非洲知识产权组织");
            zhouguo.Add("阿曼(OM)", "亚洲;阿曼;阿曼");
            zhouguo.Add("巴拿马(PA)", "北美洲;巴拿马;巴拿马");
            zhouguo.Add("秘鲁(PE)", "南美洲;秘鲁;秘鲁");
            zhouguo.Add("巴布亚新几内亚(PG)", "大洋洲;巴布亚新几内亚;巴布亚新几内亚");
            zhouguo.Add("菲律宾(PH)", "亚洲;菲律宾;菲律宾");
            zhouguo.Add("巴基斯坦(PK)", "亚洲;巴基斯坦;巴基斯坦");
            zhouguo.Add("波兰(PL)", "欧洲;波兰;波兰");
            zhouguo.Add("葡萄牙(PT)", "欧洲;葡萄牙;葡萄牙");
            zhouguo.Add("巴拉圭(PY)", "南美洲;巴拉圭;巴拉圭");
            zhouguo.Add("卡塔尔(QA)", "亚洲;卡塔尔;卡塔尔");
            zhouguo.Add("罗马尼亚(RO)", "欧洲;罗马尼亚;罗马尼亚");
            zhouguo.Add("俄罗斯联邦(RU)", "欧洲;俄罗斯联邦;俄罗斯联邦");
            zhouguo.Add("卢旺达(RW)", "非洲;卢旺达;卢旺达");
            zhouguo.Add("沙特阿拉伯(SA)", "亚洲;沙特阿拉伯;沙特阿拉伯");
            zhouguo.Add("所罗门群岛(SB)", "大洋州;所罗门群岛;所罗门群岛");
            zhouguo.Add("塞舌尔(SC)", "非洲;塞舌尔;塞舌尔");
            zhouguo.Add("苏丹(SD)", "非洲;苏丹;苏丹");
            zhouguo.Add("瑞典(SE)", "欧洲;瑞典;瑞典");
            zhouguo.Add("新加坡(SG)", "亚洲;新加坡;新加坡");
            zhouguo.Add("圣赫勒拿岛(SH)", "非洲;圣赫勒拿岛;圣赫勒拿岛");
            zhouguo.Add("斯洛文尼亚(SI)", "欧洲;斯洛文尼亚;斯洛文尼亚");
            zhouguo.Add("塞拉利昂(SL)", "非洲;塞拉利昂;塞拉利昂");
            zhouguo.Add("圣马利诺(SM)", "欧洲;圣马利诺;圣马利诺");
            zhouguo.Add("塞内加尔(SN)", "非洲;塞内加尔;塞内加尔");
            zhouguo.Add("索马里(SO)", "非洲;索马里;索马里");
            zhouguo.Add("苏里南(SR)", "南美洲;苏里南;苏里南");
            zhouguo.Add("圣多美和普林西比岛(ST)", "非洲;圣多美和普林西比岛;圣多美和普林西比岛");
            zhouguo.Add("苏联(SU)", "欧洲;苏联;苏联");
            zhouguo.Add("萨尔瓦多(SV)", "北美洲;萨尔瓦多;萨尔瓦多");
            zhouguo.Add("叙利亚(SY)", "亚洲;叙利亚;叙利亚");
            zhouguo.Add("斯威士兰(SZ)", "非洲;斯威士兰;斯威士兰");
            zhouguo.Add("乍得(TD)", "非洲;乍得;乍得");
            zhouguo.Add("多哥(TG)", "非洲;多哥;多哥");
            zhouguo.Add("泰国(TH)", "亚洲;泰国;泰国");
            zhouguo.Add("塔吉克斯坦(TJ)", "亚洲;塔吉克斯坦;塔吉克斯坦");
            zhouguo.Add("土库曼斯坦(TM)", "亚洲;土库曼斯坦;土库曼斯坦");
            zhouguo.Add("突尼斯(TN)", "非洲;突尼斯;突尼斯");
            zhouguo.Add("汤加(TO)", "大洋洲;汤加;汤加");
            zhouguo.Add("土耳其(TR)", "亚洲;土耳其;土耳其");
            zhouguo.Add("特立尼达和多巴哥(TT)", "北美洲;特立尼达和多巴哥;特立尼达和多巴哥");
            zhouguo.Add("图瓦卢(TV)", "大洋洲 ;图瓦卢;图瓦卢");
            zhouguo.Add("坦桑尼亚(TZ)", "非洲;坦桑尼亚;坦桑尼亚");
            zhouguo.Add("乌克兰(UA)", "欧洲;乌克兰;乌克兰");
            zhouguo.Add("乌干达(UG)", "非洲;乌干达;乌干达");
            zhouguo.Add("美国(US)", "北美洲;美国;美国");
            zhouguo.Add("乌拉圭(UY)", "南美洲;乌拉圭;乌拉圭");
            zhouguo.Add("乌兹别克斯坦(UZ)", "亚洲;乌兹别克斯坦;乌兹别克斯坦");
            zhouguo.Add("梵蒂冈(VA)", "欧洲;梵蒂冈;梵蒂冈");
            zhouguo.Add("圣文森特岛和格林纳达(VC)", "北美洲;圣文森特岛和格林纳达;圣文森特岛和格林纳达");
            zhouguo.Add("委内瑞拉(VE)", "南美洲;委内瑞拉;委内瑞拉");
            zhouguo.Add("越南(VN)", "亚洲;越南;越南");
            zhouguo.Add("瓦努阿图(VU)", "大洋洲;瓦努阿图;瓦努阿图");
            zhouguo.Add("世界知识产权组织(WO)", "联合国;世界知识产权组织;世界知识产权组织");
            zhouguo.Add("萨摩亚(WS)", "大洋洲;萨摩亚;萨摩亚");
            zhouguo.Add("民主也门(YD)", "亚洲;民主也门;民主也门");
            zhouguo.Add("也门(YE)", "亚洲;也门;也门");
            zhouguo.Add("南斯拉夫(YU)", "欧洲;南斯拉夫;南斯拉夫");
            zhouguo.Add("南非(ZA)", "非洲;南非;南非");
            zhouguo.Add("赞比亚(ZM)", "非洲;赞比亚;赞比亚");
            zhouguo.Add("扎伊尔(ZR)", "非洲;扎伊尔;扎伊尔");
            zhouguo.Add("津巴布韦(ZW)", "非洲;津巴布韦;津巴布韦");
            zhouguo.Add("捷克共和国(CZ)", "欧洲;捷克共和国;捷克共和国");
            zhouguo.Add("斯洛伐克(SK)", "欧洲;斯洛伐克;斯洛伐克");
            zhouguo.Add("美属萨摩亚(AS)", "大洋洲;美属萨摩亚;美属萨摩亚");
            zhouguo.Add("波斯尼亚和黑塞哥维那(BA)", "欧洲;波斯尼亚和黑塞哥维那;波斯尼亚和黑塞哥维那");
            zhouguo.Add("西撒哈拉(EH)", "非洲;西撒哈拉;西撒哈拉");
            zhouguo.Add("厄立特里亚(ER)", "非洲;厄立特里亚;厄立特里亚");
            zhouguo.Add("费罗群岛(FO)", "欧洲;费罗群岛;费罗群岛");
            zhouguo.Add("格陵兰(GL)", "北美洲;格陵兰;格陵兰");
            zhouguo.Add("南乔智亚和南桑威奇群岛(GS)", "南极洲;南乔智亚和南桑威奇群岛;南乔智亚和南桑威奇群岛");
            zhouguo.Add("东帝汶(TP)", "亚洲;东帝汶;东帝汶");
            zhouguo.Add("特克斯和凯科斯群岛(TC)", "北美洲;特克斯和凯科斯群岛;特克斯和凯科斯群岛");
            zhouguo.Add("马其顿(MK)", "欧洲;马其顿;马其顿");
            zhouguo.Add("缅甸(MM)", "亚洲;缅甸;缅甸");
            zhouguo.Add("比荷卢(BX)", "欧洲;比荷卢;比荷卢");
            zhouguo.Add("欧亚专利局(EA)", "欧洲;欧亚专利局;欧亚专利局");
            zhouguo.Add("宁波(97)", "亚洲;中国;浙江");
            zhouguo.Add("长春(82)", "亚洲;中国;吉林");
            zhouguo.Add("南京(84)", "亚洲;中国;江苏");
            zhouguo.Add("杭州(86)", "亚洲;中国;浙江");
            zhouguo.Add("济南(88)", "亚洲;中国;山东");
            zhouguo.Add("成都(90)", "亚洲;中国;四川");
            zhouguo.Add("厦门(92)", "亚洲;中国;福建");
            zhouguo.Add("深圳(94)", "亚洲;中国;广东");
            zhouguo.Add("欧洲内部市场协调局(EM)", "欧洲;欧洲内部市场协调局;欧洲内部市场协调局");
            zhouguo.Add("库克群岛(CK)", "大洋洲;库克群岛;库克群岛");
            #endregion

        }
        public static Regex regPr = new Regex("\\d{4}年\\d{1,2}月\\d{1,2}日");
        public static STDT AutoIndex(ShowBase sb, out List<STPa> pa, out List<STIV> iv, out List<STIpc> ic, out List<STPR> pr)
        {
            STDT st = new STDT() { ZTID = sb.ZTID, SiD = sb.SiD, ImportDate = sb.ImportDate };
            pa = new List<STPa>();
            iv = new List<STIV>();
            ic = new List<STIpc>();
            pr = new List<STPR>();
            //申请号
            st.An = sb.An;
            st.Ad = sb.Ad.FormatDate();
            st.AdY = Convert.ToInt32(st.Ad.GetYear());
            //公开
            st.PN = sb.PN;
            st.PD = sb.PD.FormatDate();
            st.PDy = st.PD.GetYear();
            st.PDyDef = (sbyte)(st.PDy - st.AdY);
            //公告
            st.GN = sb.GN;
            st.Gd = sb.Gd.FormatDate();
            st.GdY = sb.Gd.GetYear();
            st.GdYDef = (sbyte)(st.PDy - st.AdY);
            //PCT
            st.PcTIn = sb.PcDIn.FormatDate();
            st.PcTAn = sb.PcTAn;
            st.PcTAd = sb.PcTAd.FormatDate();
            st.PcTPN = sb.PcTPN;
            st.PcTPD = sb.PcTPN.FormatDate();
            //母案
            st.MAd = sb.MAd;

            //页数字数
            st.DesPageSum = sb.DesPageSum.ToSbyte();
            st.PiCSum = sb.PiCSum.ToSbyte();
            st.ClMPageSum = sb.ClMSum.ToSbyte();
            st.ClSCharSum = sb.ClM.Length;

            //专利类型
            string type = "";
            string type1 = "";
            char ctype = '1';
            switch (st.An.Length)
            {
                case 8:
                case 9:
                    ctype = st.An[2];
                    break;
                case 12:
                case 13:
                    ctype = st.An[4];
                    break;

            }
            switch (ctype)
            {
                case '1':
                    type = "发明专利";
                    type1 = "发明专利";
                    break;
                case '2':
                    type = "实用新型";
                    break;
                case '3':
                    type = "外观专利";
                    type1 = "外观专利";
                    break;
                case '8':
                    type = "发明专利";
                    type = "发明专利PCT";
                    break;
                case '9':
                    type = "实用新型";
                    type1 = "实用新型PCT";
                    break;
            }

            st.Type = type;
            st.Type1 = type1;
            int i = 0;
            //申请人
            if (sb.Pa != null)
            {
                string[] pas = sb.Pa.Split("、;；".ToArray());

                foreach (var strpa in pas)
                {
                    if (strpa.Trim() == "") continue;
                    i++;
                    pa.Add(new STPa() { SiD = sb.SiD, Pa = strpa, PaType = strpa.GetPaType(), Sort = (SByte)i });
                }
                if (pa.Count > 0)
                {
                    st.FPa = pa[0].Pa;
                    st.FPaType = pa[0].PaType;
                    st.PaSum = (SByte)pa.Count;
                }
                if (pa.Count > 1)
                {
                    st.IsHeZUO = 1;
                }
            }

            //发明人
            if (sb.IV != null)
            {
                string[] ins = sb.IV.Split("、;；".ToArray());
                i = 0;
                foreach (var strin in ins)
                {
                    if (strin.Trim() == "") continue;
                    i++;
                    iv.Add(new STIV() { SiD = sb.SiD, IV = strin, Sort = (SByte)i });
                }
                if (iv.Count > 0)
                {
                    st.FIn = iv[0].IV;
                    st.InSum = (SByte)iv.Count;
                }
            }
            if (sb.Ipc != null)
            {
                //IPC
                string[] ipcs = sb.Ipc.Split("、;；".ToArray());
                i = 0;
                foreach (var ipc in ipcs)
                {
                    if (ipc.Trim() == "") continue;
                    string atripc = ipc.Replace("  ", " ");
                    STIpc tmpipc = new STIpc() { SiD = sb.SiD, Ipc = atripc };
                    if (type == "外观专利")
                    {
                        tmpipc.Ipc3 = atripc.Left(2);
                        tmpipc.Ipc4 = atripc.Left(5);
                        tmpipc.Ipc7 = atripc.Left(7);
                    }
                    else
                    {

                        tmpipc.Ipc1 = atripc.Left(1);
                        tmpipc.Ipc3 = atripc.Left(3);
                        tmpipc.Ipc4 = atripc.Left(4);
                        tmpipc.Ipc7 = atripc.Left(7);
                    }
                    ic.Add(tmpipc);
                }
                if (ic.Count > 0)
                {
                    st.FIpc = ic[0].Ipc;
                    st.IpcSum = (SByte)ic.Count;
                }
            }
            if (sb.AddR != null)
            {
                if (sb.AddR == "")
                {
                    int tmpindex = sb.ShEng.IndexOf("(");
                    if (tmpindex >= 0)
                    {
                        sb.ShEng.Substring(0, tmpindex);
                    }
                }
                else
                {
                    string[] diqu = sb.AddR.AddressToShengShiQuXianAddress();
                    st.ShEng = diqu[1];
                    st.ShI = diqu[2];
                    st.QUXian = diqu[3];
                }

                if (zhouguo.ContainsKey(sb.ShEng))
                {
                    string[] zhouguosheng = zhouguo[sb.ShEng].Split(';');
                    st.ZHoU = zhouguosheng[0];
                    st.GJ = zhouguosheng[1];
                    st.ShEng1 = zhouguosheng[2];
                    if (st.GJ == "中国")
                    {
                        st.IsGuOwAi = 1;
                    }
                    else
                    {
                        st.IsGuOwAi = 0;
                    }
                }
            }
            if (sb.PR != null)
            {
                string[] aryprs = sb.PR.Split("\t".ToArray());
                i = 0;
                int opd = 0;
                foreach (var strpr in aryprs)
                {
                    string tmpstrpr = strpr.Trim();
                    if (tmpstrpr == "") continue;
                    i++;
                    string[] itmes = regPr.Split(tmpstrpr);
                    string prcy = itmes[0];
                    string prno = itmes[1];
                    string prdt = tmpstrpr.Substring(prcy.Length, tmpstrpr.Length - prcy.Length - prno.Length).FormatDate();
                    int tmpopd = Convert.ToInt32(prdt);
                    if (i == 1)
                    {
                        opd = tmpopd;
                    }
                    else
                    {
                        if (opd > tmpopd) opd = tmpopd;
                    }

                    STPR tmpr = new STPR() { SiD = sb.SiD };
                    tmpr.An = prno;
                    tmpr.Ad = prdt;
                    tmpr.GJ = prcy;

                    pr.Add(tmpr);

                }
                if (pr.Count > 0)
                {
                    st.OpD = opd.ToString();
                    st.OpDy = opd.ToString().GetYear();
                }
            }
            return st;

        }
    }
}

