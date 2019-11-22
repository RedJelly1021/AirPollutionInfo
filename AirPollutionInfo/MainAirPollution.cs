using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace AirPollutionInfo
{
	public partial class AirPollutionInfo : RadForm
	{
		string city = string.Empty;

		public AirPollutionInfo()
		{
			InitializeComponent();
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			Button button = sender as Button;
			if (button != null)
			{
				switch (button.Name)
				{
					case "BtSeoul":
						city = "서울";
						DialogInfo digSeoul = new DialogInfo(city);
						digSeoul.Text = city + "지역 오염지수";
						digSeoul.Show();
						break;
					case "BtGyeonggi":
						city = "경기";
						DialogInfo digGyeonggi = new DialogInfo(city);
						digGyeonggi.Text = city + "지역 오염지수";
						digGyeonggi.Show();
						break;
					case "BtIncheon":
						city = "인천";
						DialogInfo digIncheon = new DialogInfo(city);
						digIncheon.Text = city + "지역 오염지수";
						digIncheon.Show();
						break;
					case "BtGangwon":
						city = "강원";
						DialogInfo digGangwon = new DialogInfo(city);
						digGangwon.Text = city + "지역 오염지수";
						digGangwon.Show();
						break;
					case "BtSejong":
						city = "세종";
						DialogInfo digSejong = new DialogInfo(city);
						digSejong.Text = city + "지역 오염지수";
						digSejong.Show();
						break;
					case "BtChungbuk":
						city = "충북";
						DialogInfo digChungbuk = new DialogInfo(city);
						digChungbuk.Text = city + "지역 오염지수";
						digChungbuk.Show();
						break;
					case "BtChungnam":
						city = "충남";
						DialogInfo digChungnam = new DialogInfo(city);
						digChungnam.Text = city + "지역 오염지수";
						digChungnam.Show();
						break;
					case "BtDaejeon":
						city = "대전";
						DialogInfo digDaejeon = new DialogInfo(city);
						digDaejeon.Text = city + "지역 오염지수";
						digDaejeon.Show();
						break;
					case "BtGyeongbuk":
						city = "경북";
						DialogInfo digGyeongbuk = new DialogInfo(city);
						digGyeongbuk.Text = city + "지역 오염지수";
						digGyeongbuk.Show();
						break;
					case "BtGyeongnam":
						city = "경남";
						DialogInfo digGyeongnam = new DialogInfo(city);
						digGyeongnam.Text = city + "지역 오염지수";
						digGyeongnam.Show();
						break;
					case "BtDaegu":
						city = "대구";
						DialogInfo digDaegu = new DialogInfo(city);
						digDaegu.Text = city + "지역 오염지수";
						digDaegu.Show();
						break;
					case "BtUlsan":
						city = "울산";
						DialogInfo digUlsan = new DialogInfo(city);
						digUlsan.Text = city + "지역 오염지수";
						digUlsan.Show();
						break;
					case "BtBusan":
						city = "부산";
						DialogInfo digBusan = new DialogInfo(city);
						digBusan.Text = city + "지역 오염지수";
						digBusan.Show();
						break;
					case "BtJeonbuk":
						city = "전북";
						DialogInfo digJeonbuk = new DialogInfo(city);
						digJeonbuk.Text = city + "지역 오염지수";
						digJeonbuk.Show();
						break;
					case "BtJeonnam":
						city = "전남";
						DialogInfo digJeonnam = new DialogInfo(city);
						digJeonnam.Text = city + "지역 오염지수";
						digJeonnam.Show();
						break;
					case "BtGwangju":
						city = "광주";
						DialogInfo digGwangj = new DialogInfo(city);
						digGwangj.Text = city + "지역 오염지수";
						digGwangj.Show();
						break;
					case "BtJeju":
						city = "제주";
						DialogInfo digJeju = new DialogInfo(city);
						digJeju.Text = city + "지역 오염지수";
						digJeju.Show();
						break;
				}
			}
		}
	}
}
