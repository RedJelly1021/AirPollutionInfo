using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace AirPollutionInfo
{
	public partial class AirPollutionInfo : RadForm
	{
		DialogInfo dig;
		string city = string.Empty;

		public AirPollutionInfo()
		{
			InitializeComponent();
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			Button button = sender as Button;
			dig = new DialogInfo(city);

			if (button != null)
			{
				switch (button.Name)
				{
					case "BtSeoul":
						city = "서울";
						dig.Text = "서울지역 오염지수";
						dig.Show();
						break;
					case "BtGyeonggi":
						city = "경기";
						dig.Text = "경기지역 오염지수";
						dig.Show();
						break;
					case "BtIncheon":
						city = "인천";
						dig.Text = "인천지역 오염지수";
						dig.Show();
						break;
					case "BtGangwon":
						city = "강원";
						dig.Text = "강원지역 오염지수";
						dig.Show();
						break;
					case "BtSejong":
						city = "세종";
						dig.Text = "세종지역 오염지수";
						dig.Show();
						break;
					case "BtChungbuk":
						city = "충북";
						dig.Text = "충북지역 오염지수";
						dig.Show();
						break;
					case "BtChungnam":
						city = "충남";
						dig.Text = "충남지역 오염지수";
						dig.Show();
						break;
					case "BtDaejeon":
						city = "대전";
						dig.Text = "대전지역 오염지수";
						dig.Show();
						break;
					case "BtGyeongbuk":
						city = "경북";
						dig.Text = "경북지역 오염지수";
						dig.Show();
						break;
					case "BtGyeongnam":
						city = "경남";
						dig.Text = "경남지역 오염지수";
						dig.Show();
						break;
					case "BtDaegu":
						city = "대구";
						dig.Text = "대구지역 오염지수";
						dig.Show();
						break;
					case "BtUlsan":
						city = "울산";
						dig.Text = "울산지역 오염지수";
						dig.Show();
						break;
					case "BtBusan":
						city = "부산";
						dig.Text = "부산지역 오염지수";
						dig.Show();
						break;
					case "BtJeonbuk":
						city = "전북";
						dig.Text = "전북지역 오염지수";
						dig.Show();
						break;
					case "BtJeonnam":
						city = "전남";
						dig.Text = "전남지역 오염지수";
						dig.Show();
						break;
					case "BtGwangju":
						city = "광주";
						dig.Text = "광주지역 오염지수";
						dig.Show();
						break;
					case "BtJeju":
						city = "제주";
						dig.Text = "제주지역 오염지수";
						dig.Show();
						break;
				}
			}
		}
	}
}
