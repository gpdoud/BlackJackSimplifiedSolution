using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSimplified {

	public class Hand : List<Card> {

		public string Display() {
			string card1 = this[0].Display();
			string card2 = this[1].Display();
			int value = this[0].Value + this[1].Value;
			return $"{card1}, {card2} : {value}";
		}
	}
}
