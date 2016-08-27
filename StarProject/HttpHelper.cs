using System.Net;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Text;
using System.IO;
using System;
public class HttpHelper
{
    public static string SendDataByPost(string Url, string postDataStr, ref CookieContainer cookie)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
        if (cookie.Count == 0)
        {
            request.CookieContainer = new CookieContainer();
            cookie = request.CookieContainer;
        }
        else
        {
            request.CookieContainer = cookie;
        }

        request.Method = "POST";
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = postDataStr.Length;

        Stream myRequestStream = request.GetRequestStream();
        StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
        myStreamWriter.Write(postDataStr);
        myStreamWriter.Close();

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream myResponseStream = response.GetResponseStream();
        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
        string retString = myStreamReader.ReadToEnd();
        myStreamReader.Close();
        myResponseStream.Close();

        return retString;
    }

    public static string SendDataByGET(string Url, string postDataStr, ref CookieContainer cookie)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);

        if (cookie.Count == 0)
        {
            request.CookieContainer = new CookieContainer();
            cookie = request.CookieContainer;
        }
        else
        {
            request.CookieContainer = cookie;
        }

        request.Method = "GET";
        request.ContentType = "text/html;charset=UTF-8";

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream myResponseStream = response.GetResponseStream();
        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
        string retString = myStreamReader.ReadToEnd();
        myStreamReader.Close();
        myResponseStream.Close();

        return retString;
    }

}