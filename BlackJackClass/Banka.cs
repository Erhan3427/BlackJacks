using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClass
{
    
    public class Banka
    {

		private decimal _bakiye=1000;

		public decimal Bakiye 
		{
			get { return _bakiye; }
			set
			{
				if (value <= 0)
				{

					throw new ArgumentException("");
				}
				else
				{
					_bakiye = value;
				}
			}
		}







	}

}
