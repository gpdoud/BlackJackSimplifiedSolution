using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackSimplified;

namespace BlackJackGame {
	class Program {
		static void Main(string[] args) {

			Hand h1 = new Hand() { new Card(Card.RankType.Ace, Card.SuiteType.Spade), new Card(Card.RankType.Jack, Card.SuiteType.Spade) };
			Hand house = new Hand() { new Card(Card.RankType.Two, Card.SuiteType.Heart), new Card(Card.RankType.Two, Card.SuiteType.Diamond) };

			Debug.WriteLine($"Player: {h1.Display()}\nHouse: {house.Display()}");
		}
	}
}
