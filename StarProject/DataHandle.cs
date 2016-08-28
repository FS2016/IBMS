using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Globalization;

namespace FireAlarm
{
    class DataHandle
    {
        public String dataBagParse(string dataStr)
        {   string[] strArray={"01","03","15","05","07","09"};
            //数据包解析
           string data = dataStr.Trim();
           Console.WriteLine("tempStr=============" + data);
           if (data.StartsWith("D"))
            {
                //目前只处理004状态的信息
                if (data.Substring(11, 3).Equals("004"))
                {
                    //获取状态值信息
                    string statusStr = data.Substring(16, 2);
                    if (((IList)strArray).Contains(statusStr))
                    {   
                        //发生火灾的地址
                        string addressStr=data.Substring(6, 4).Insert(1,"-");
                        string dateStr = data.Substring(18, 14);
                        DateTime dt = DateTime.ParseExact(dateStr, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
                        //火灾报警的时间
                        string fireDate = dt.ToString("yyyy-MM-dd HH:MM:ss");
                        //主机地址
                        String hostId = data.Substring(4, 2);
                        string resultStr = "主机地址"+hostId+"在" + addressStr + "地址发生报警，发生时间：" + fireDate;
                        Console.WriteLine(resultStr);
                        //保存数据到数据库中
                        SDataHepler.saveFirePointInfo(addressStr, hostId, fireDate);
                        return resultStr;
                    }
                }
            }
            Console.WriteLine( "无报警···");
            return null;
        }
        public string HexToAscii(String hexStr)
        {
            byte[] array = System.Text.Encoding.ASCII.GetBytes(hexStr);  //数组array为对应的ASCII数组     
            string ASCIIstr2 = null;
            for (int i = 0; i < array.Length; i++)
            {
                int asciicode = (int)(array[i]);
                ASCIIstr2 += Convert.ToString(asciicode);//字符串ASCIIstr2 为对应的ASCII字符串
            }
            return ASCIIstr2;
        }
    }
}
