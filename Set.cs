using System;

namespace mtgToSQL
{
	class Set
	{
		public string name { get; private set; }
		public string code { get; private set; }
		public string gathererCode { get; private set; }
		public string oldCode { get; private set; }
		public string magicCardsInfoCode { get; private set; }
		public string releaseDate { get; private set; }
		public string border { get; private set; }
		public string type { get; private set; }
		public string block { get; private set; }
		public bool onlineOnly { get; private set; }
		// public string[] booster { get; private set; }
		public Card[] cards { get; private set; }

		public Set(
			string name,
			string code,
			string gathererCode,
			string oldCode,
			string magicCardsInfoCode,
			string releaseDate,
			string border,
			string type,
			string block,
			bool onlineOnly,
			// string[] booster,
			Card[] cards
		) {
			this.name = name;
			this.code = code;
			this.gathererCode = gathererCode;
			this.oldCode = oldCode;
			this.magicCardsInfoCode = magicCardsInfoCode;
			this.releaseDate = releaseDate;
			this.border = border;
			this.type = type;
			this.block = block;
			this.onlineOnly = onlineOnly;
			// this.booster = booster;
			this.cards = cards;
		}
	}
}
