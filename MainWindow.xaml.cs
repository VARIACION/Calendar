using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PreAlpha
{
	
	public partial class MainWindow : Window
	{
		private Button[,] ListDays = new Button[5, 7];
		private int month, year;

		public void AddDaysToButton(int month, int year)
		{
			DateTime getDate = new DateTime(year, month, 1);
			int lastDayInMonth = 1;
			int j = (int)getDate.DayOfWeek;

			for (int i = 0; i < 5; ++i)
			{
				for (; j < 7; ++j)
				{
					if (lastDayInMonth > DateTime.DaysInMonth(year, month))
						break;

					ListDays[i, j].Content = lastDayInMonth;
					++lastDayInMonth;
				}
				j = 0;
			}

			lastDayInMonth = DateTime.DaysInMonth(year, month - 1);
			if ((int)getDate.DayOfWeek - 1 > 0)
			{
				for (int i = (int)getDate.DayOfWeek - 1; i >= 0; --i)
				{
					ListDays[0, i].Content = lastDayInMonth;
					ListDays[0, i].Background = Brushes.LightGray;
					--lastDayInMonth;
				}
			}

			getDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
			lastDayInMonth = 1;
			if ((int)getDate.DayOfWeek < 6)
			{
				for (int i = (int)getDate.DayOfWeek + 1; i < 7; ++i)
				{
					ListDays[4, i].Content = lastDayInMonth;
					ListDays[4, i].Background = Brushes.LightGray;
					++lastDayInMonth;
				}
			}
		}
		
		public MainWindow()
		{
			InitializeComponent();

			DateTime moment = DateTime.Today;
			CurrentMonthYearLabel.Content = moment.ToString("MM/yyyy");
			this.month = moment.Month;
			this.year = moment.Year;

			ListDays[0, 0] = Row0Col0Button;
			ListDays[0, 1] = Row0Col1Button;
			ListDays[0, 2] = Row0Col2Button;
			ListDays[0, 3] = Row0Col3Button;
			ListDays[0, 4] = Row0Col4Button;
			ListDays[0, 5] = Row0Col5Button;
			ListDays[0, 6] = Row0Col6Button;

			ListDays[1, 0] = Row1Col0Button;
			ListDays[1, 1] = Row1Col1Button;
			ListDays[1, 2] = Row1Col2Button;
			ListDays[1, 3] = Row1Col3Button;
			ListDays[1, 4] = Row1Col4Button;
			ListDays[1, 5] = Row1Col5Button;
			ListDays[1, 6] = Row1Col6Button;

			ListDays[2, 0] = Row2Col0Button;
			ListDays[2, 1] = Row2Col1Button;
			ListDays[2, 2] = Row2Col2Button;
			ListDays[2, 3] = Row2Col3Button;
			ListDays[2, 4] = Row2Col4Button;
			ListDays[2, 5] = Row2Col5Button;
			ListDays[2, 6] = Row2Col6Button;

			ListDays[3, 0] = Row3Col0Button;
			ListDays[3, 1] = Row3Col1Button;
			ListDays[3, 2] = Row3Col2Button;
			ListDays[3, 3] = Row3Col3Button;
			ListDays[3, 4] = Row3Col4Button;
			ListDays[3, 5] = Row3Col5Button;
			ListDays[3, 6] = Row3Col6Button;

			ListDays[4, 0] = Row4Col0Button;
			ListDays[4, 1] = Row4Col1Button;
			ListDays[4, 2] = Row4Col2Button;
			ListDays[4, 3] = Row4Col3Button;
			ListDays[4, 4] = Row4Col4Button;
			ListDays[4, 5] = Row4Col5Button;
			ListDays[4, 6] = Row4Col6Button;

			AddDaysToButton(moment.Month, moment.Year);
		}

		private void UpButton_Click(object sender, RoutedEventArgs e)
		{
			if (this.month > 1)
			{
				--this.month;
			}
			else
			{
				--this.year;
				this.month = 12;
			}

			DateTime getString = new DateTime(this.year, this.month, 1);
			CurrentMonthYearLabel.Content = getString.ToString("MM/yyyy");
			AddDaysToButton(this.month, this.year);
		}
	}
}
