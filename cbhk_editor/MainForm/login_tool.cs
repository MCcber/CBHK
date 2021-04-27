using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace cbhk_editor.MainForm
{
    class login_tool
    {
		private static string getSubString(string text, string left, string right)
		{
            string result;
			int zLen;
			if (left == null || Equals(left,string.Empty))
			{
				zLen = 0;
			}
			else
			{
				zLen = text.IndexOf(left);
				if (zLen > -1)
				{
					zLen += left.Length;
				}
				else
				{
					zLen = 0;
				}
			}
			int yLen = text.IndexOf(right, zLen);
			if (yLen < 0 || Equals(right,string.Empty))
			{
				yLen = text.Length;
			}
			result = text.Substring(zLen, yLen);
			return result;
		}
		public static string SendDataByPost(string url, string postDataStr, ref CookieContainer cookie)
		{
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
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
			request.ContentType = "text/html; charset=utf-8";
			request.ContentLength = postDataStr.Length;
			Stream get_info = request.GetRequestStream();
			StreamWriter set_info = new StreamWriter(get_info, Encoding.GetEncoding("gb2312"));
			set_info.Write(postDataStr);
			set_info.Close();
			HttpWebResponse response = request.GetResponse() as HttpWebResponse;
			Stream result_stream = response.GetResponseStream();
			StreamReader result_reader = new StreamReader(result_stream, Encoding.GetEncoding("utf-8"));
			string result = result_reader.ReadToEnd();
			result_stream.Close();
			result_reader.Close();
			return result;
		}

		public static string SendDataByGet(string url, string postDatastr)
		{
			string result = "";
			try
			{
				ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
				ServicePointManager.DefaultConnectionLimit = 200;
				//ServicePointManager.ServerCertificateValidationCallback = (object < p0 >, X509Certificate<p1>, X509Chain<p2>, SslPolicyErrors<p3>) => true;
				HttpWebRequest request2 = WebRequest.Create(url + ((postDatastr == "") ? "" : "?") + postDatastr) as HttpWebRequest;
				request2.Method = "GET";
				request2.Timeout = 5000;
				request2.KeepAlive = false;
				request2.ContentType = "application/json; charset=utf-8";
				HttpWebResponse response2 = request2.GetResponse() as HttpWebResponse;
				Stream result_stream = response2.GetResponseStream();
				StreamReader result_reader = new StreamReader(result_stream, new UTF8Encoding(false));
				result = result_reader.ReadToEnd();
				result_stream.Close();
				result_reader.Close();
				response2.Close();
				response2 = null;
				request2.Abort();
				request2 = null;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			return result;
		}

		public static void DownLoadUserHead(string target_url,string target_file_path)
        {
			//建立一个请求
			HttpWebRequest Myrq = WebRequest.Create(target_url) as HttpWebRequest;
			Myrq.KeepAlive = false;//持续连接
			Myrq.Timeout = 30 * 1000;//30秒，*1000是因为基础单位为毫秒
			Myrq.Method = "GET";//请求方法
			Myrq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3";//自己去network里面找
			Myrq.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36";

			//接受返回
			HttpWebResponse Myrp = (HttpWebResponse)Myrq.GetResponse();
			if (Myrp.StatusCode != HttpStatusCode.OK)
			{ return; }

			using (FileStream fl = new FileStream(target_file_path, FileMode.Create))//展开一个流
			{
				Myrp.GetResponseStream().CopyTo(fl);//复制到当前文件夹
			}

		}

		public static string GetJarFile(string url, string target_path)
        {
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				request.Timeout = 30000;
				request.UserAgent = "User-Agent:Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705";
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
				request.AllowAutoRedirect = true;
				WebResponse response = request.GetResponse();
				Stream reader = response.GetResponseStream();
				FileStream writer = new FileStream(target_path, FileMode.OpenOrCreate, FileAccess.Write);
				byte[] buff = new byte[response.ContentLength];
				int c2 = 0;
				while ((c2 = reader.Read(buff, 0, buff.Length)) > 0)
				{
					writer.Write(buff, 0, c2);
				}
				writer.Close();
				writer.Dispose();
				reader.Close();
				reader.Dispose();
				response.Close();
			}
			catch (Exception e)
			{
				return e.Message;
			}
			return "success";
		}

		public static string GetFileProcess(string url, string target_path,ProgressBar bar)
		{
			//string HeaderUrl = "https://wwa.lanzous.com";
			//try
			//{
				XmlDocument source_page = new XmlDocument();
			//ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

			#region 获取referer值
			//HttpWebRequest source_request = (HttpWebRequest)WebRequest.Create(url);
			//source_request.MaximumResponseHeadersLength = int.MaxValue;
			//            //source_request.AllowAutoRedirect = true;
			//            source_request.Timeout = 3000;
			//            source_request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.30 Safari/537.36";
			//            HttpWebResponse response_page = source_request.GetResponse() as HttpWebResponse;
			//Stream result_stream = response_page.GetResponseStream();
			//StreamReader result_reader = new StreamReader(result_stream, new UTF8Encoding(false));
			//string page_result = result_reader.ReadToEnd();

			//source_page.Load(page_result);
			//string referer_part = source_page.SelectSingleNode("//iframe[@class='ifr2']").Attributes["src"].ToString();
			//string referer = HeaderUrl + referer_part;
			#endregion

			#region 获取data值
			//	HttpWebRequest referer_request = (HttpWebRequest)WebRequest.Create(referer);
			//referer_request.AllowAutoRedirect = true;
			//	referer_request.MaximumResponseHeadersLength = int.MaxValue;
			//             referer_request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.30 Safari/537.36";
			//             referer_request.Timeout = 20000;
			//	referer_request.Method = "GET";

			//	response_page = referer_request.GetResponse() as HttpWebResponse;
			//	result_stream = response_page.GetResponseStream();
			//	result_reader = new StreamReader(result_stream,new UTF8Encoding(false));
			//	string referer_page_result = result_reader.ReadToEnd();
			//	source_page.Load(referer_page_result);
			//	string sign_part = source_page.SelectSingleNode("//script[@type='text/javascript']").ToString();
			//	string sign = getSubString(sign_part, "pposturl = '", "'");
			//	string data = "action=downprocess&sign=" + sign + "&ves=1";
			#endregion

			//获取url
			//string target_url = HeaderUrl + getSubString(sign_part, "url : '", "'");

			#region 获取下载直链
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.30 Safari/537.36";
			request.Accept = "application/json, text/javascript, */*";
			request.Host = "wwa.lanzous.com";
			request.Connection = "Keep-Alive";

			WebResponse response = request.GetResponse();
			Stream reader = response.GetResponseStream();
            Stream result_stream = response.GetResponseStream();
            StreamReader result_reader = new StreamReader(result_stream, new UTF8Encoding(false));
            string page_result = result_reader.ReadToEnd();
            FileStream writer = new FileStream(target_path, FileMode.OpenOrCreate, FileAccess.Write);
			byte[] buff = new byte[response.ContentLength];
			int c2 = 0;
			while ((c2 = reader.Read(buff, 0, buff.Length)) > 0)
			{
				bar.Value = buff.Length - (c2 / buff.Length);
				writer.Write(buff, 0, c2);
			}
			writer.Close();
			writer.Dispose();
			reader.Close();
			reader.Dispose();
			response.Close();
			#endregion
			return "success";
		}
	}
}
