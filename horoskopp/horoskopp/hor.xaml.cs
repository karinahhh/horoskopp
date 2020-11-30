using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace horoskopp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class hor : ContentPage
	{
		DatePicker dateP;
		Editor edi, sign;
		Image img;
		public hor()
		{
			dateP = new DatePicker
			{
				Format = "D",
				MaximumDate = DateTime.Now.AddYears(30),
				MinimumDate = DateTime.Now.AddYears(-90)
			};



			edi = new Editor
			{
				IsReadOnly = true
			};
			dateP.DateSelected += DateP_DateSelected;
			StackLayout stack = new StackLayout { Children = { dateP, edi } };
			this.Content = stack;
		}

		private void DateP_DateSelected(object sender, DateChangedEventArgs e)
		{

			
            if (e.NewDate.Month >= 1 && e.NewDate.Day <= 20 && e.NewDate.Month <= 2 && e.NewDate.Day <= 18)
            {
				edi.Text = "Aquarius";
            }
			else if (e.NewDate.Month >= 2 && e.NewDate.Day <= 19 && e.NewDate.Month <= 3 && e.NewDate.Day <= 20)
			{
				edi.Text = "Pieces";
			}
			else if (e.NewDate.Month >= 3 && e.NewDate.Day <= 21 && e.NewDate.Month <= 4 && e.NewDate.Day <= 19)
			{
				edi.Text = "Aries";
			}
			else if (e.NewDate.Month >= 4 && e.NewDate.Day <= 20 && e.NewDate.Month <= 5 && e.NewDate.Day <= 20)
			{
				edi.Text = "Taurus";
			}
			else if (e.NewDate.Month >= 5 && e.NewDate.Day <= 21 && e.NewDate.Month <= 6 && e.NewDate.Day <= 20)
			{
				edi.Text = "Gemini";
			}
			else if (e.NewDate.Month >= 6 && e.NewDate.Day <= 21 && e.NewDate.Month <= 7 && e.NewDate.Day <= 22)
			{
				edi.Text = "Cancer";
			}
			else if (e.NewDate.Month >= 7 && e.NewDate.Day <= 23 && e.NewDate.Month <= 8 && e.NewDate.Day <= 22)
			{
				edi.Text = "Leo";
			}
			else if (e.NewDate.Month >= 8 && e.NewDate.Day <= 23 && e.NewDate.Month <= 9 && e.NewDate.Day <= 22)
			{
				edi.Text = "Virgo";
			}
			else if (e.NewDate.Month >= 9 && e.NewDate.Day <= 23 && e.NewDate.Month <= 10 && e.NewDate.Day <= 22)
			{
				edi.Text = "Libra";
			}
			else if (e.NewDate.Month >= 10 && e.NewDate.Day <= 23 && e.NewDate.Month <= 11 && e.NewDate.Day <= 21)
			{
				edi.Text = "Scorpio";
			}
			else if (e.NewDate.Month >= 11 && e.NewDate.Day <= 22 && e.NewDate.Month <= 12 && e.NewDate.Day <= 21)
			{
				edi.Text = "Sagittarius";
			}
			else if (e.NewDate.Month >= 12 && e.NewDate.Day <= 22 && e.NewDate.Month <= 1 && e.NewDate.Day <= 19)
			{
				edi.Text = "Capricorn";
			}
			//edi.Text = e.NewDate.ToString("dd/MM");

		}
	}
}