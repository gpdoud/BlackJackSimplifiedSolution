using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSimplified {

	public class Card {

		public enum SuiteType { Heart, Diamond, Club, Spade };
		public enum RankType { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

		private Dictionary<SuiteType, string> SuiteTypeNames = new Dictionary<SuiteType, string> {
			[SuiteType.Heart] = "Hearts",
			[SuiteType.Diamond] = "Diamonds",
			[SuiteType.Club] = "Clubs",
			[SuiteType.Spade] = "Spades"
		};


		public SuiteType Suite { get; set; }
		public RankType Rank { get; set; }
		public int Value {
			get {
				int value = 0;
				switch(Rank) {
					case RankType.Ace: value =  11; break;
					case RankType.Two: value =  2; break;
					case RankType.Three: value =  3; break;
					case RankType.Four: value =  4; break;
					case RankType.Five: value =  5; break;
					case RankType.Six: value =  6; break;
					case RankType.Seven: value =  7; break;
					case RankType.Eight: value =  8; break;
					case RankType.Nine: value =  9; break;
					case RankType.Ten: value =  10; break;
					case RankType.Jack: value =  10; break;
					case RankType.Queen: value =  10; break;
					case RankType.King: value =  10; break;
				}
				return value;
			}
		}

		public string Display() {
			var suiteStr = SuiteTypeNames[Suite];
			var rankStr = Rank.ToString();
			return $"{rankStr} of {suiteStr}";
		}

		public Card(RankType rank, SuiteType suite) {
			Suite = suite;
			Rank = rank;
		}
		public Card() { }
	}
}
