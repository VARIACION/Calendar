using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAlpha
{
    class Date
    {
		private int _day;
		private int _month;
		private int _year;

		public Date()
		{
			this._day = this._month = this._year = 1;
		}

		public Date(in int day, in int month, in int year)
		{
			this._day = day;
			this._month = month;
			this._year = year;
		}
    }
}
