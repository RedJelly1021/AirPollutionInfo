using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Telerik.WinControls.UI;

namespace AirPollutionInfo
{
    public partial class DialogInfo : RadForm
    {
		string city = string.Empty;

        public DialogInfo(string city)
        {
			this.city = city;
            InitializeComponent();
        }

		private void DialogInfo_Load(object sender, EventArgs e)
		{
			GetData(city);

			//화면에서 보이는 컬럼 순서 수정
			GridViewInfo.Columns[0].DisplayIndex = 1;
			GridViewInfo.Columns[1].DisplayIndex = 0;
			GridViewInfo.Columns[2].DisplayIndex = 6;
			GridViewInfo.Columns[3].DisplayIndex = 7;
			GridViewInfo.Columns[4].DisplayIndex = 4;
			GridViewInfo.Columns[5].DisplayIndex = 5;
			GridViewInfo.Columns[6].DisplayIndex = 2;
			GridViewInfo.Columns[7].DisplayIndex = 3;
		}

		//데이터 가져온 후 그리드에 뿌리기
		private void GetData(string city)
		{
			//OPEN API 사용을 위한 URL
			string serviceUrl = "http://openapi.airkorea.or.kr/openapi/services/rest/ArpltnInforInqireSvc/getCtprvnMesureSidoLIst" +//End Point
				"?sidoName=" + city + "&searchCondition=HOUR&pageNo=1&numOfRows=31&" +
				"ServiceKey=TAhhr27%2F%2FCarG%2BSQH522QAsP%2FajxZGIdqfR6%2FM3sctkSkFWj3tUNFNcO6o58IoTLHmiV%2FC0xenoFPFtL2fwQHQ%3D%3D";//서비스키
			try
			{
				//호출
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serviceUrl);
				request.Method = "GET";
				request.ContentType = "text/xml;charset=utf-8";

				//응답
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				//스트림으로 읽기
				Stream receiveStream = response.GetResponseStream();
				StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

				//데이터 그리기
				DrawData(readStream);

				response.Close();
				readStream.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		//정규식패턴 xml태그 제거하는 함수
		private string GetPlainTextFromHtml(string text)
		{
			string htmlTagPattern = "<[^>]*>";
			var regexCss = new Regex("(\\<script(.+?)\\</script\\>)|(\\<style(.+?)\\</style\\>)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
			text = regexCss.Replace(text, string.Empty);
			text = Regex.Replace(text, htmlTagPattern, string.Empty);
			text = Regex.Replace(text, @"^\s*$\n", "", RegexOptions.Multiline);
			text = text.Replace("&nbsp;", string.Empty);

			return text.Trim();
		}

		private void DrawData(StreamReader readStream)
		{
			string readXml;
			string[] row = new string[8];
			int i = 0;
			while ((readXml = readStream.ReadLine()) != null)
			{
				string text = GetPlainTextFromHtml(readXml);
				if (!string.IsNullOrEmpty(text))
				{
					//제일 처음에 오는 result값 제외한 나머지 데이터
					if (text != "00" && text != "NORMAL SERVICE.")
					{
						row[i] = text;
						++i;
					}
				}
				if (i > 7)
				{
					i = 0;
					GridViewInfo.Rows.Add(row);
				}
			}
		}
	}
}
