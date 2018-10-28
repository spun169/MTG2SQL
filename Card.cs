using System;

namespace mtgToSQL
{
	class Card
	{
		public string name { get; private set; }
		public string manaCost { get; private set; }
		public double cmc { get; private set; }
		public string[] colors { get; private set; }
		public string[] colorIdentity { get; private set; }
		public string type { get; private set; }
		public string[] supertypes { get; private set; }
		public string[] types { get; private set; }
		public string[] subtypes { get; private set; }
		public string rarity { get; private set; }
		public string text { get; private set; }
		public string flavor { get; private set; }
		public string artist { get; private set; }
		public string number { get; private set; }
		public string power { get; private set; }
		public string toughness { get; private set; }
		public int? loyalty { get; private set; }
		public string layout { get; private set; }
		public int multiverseid { get; private set; }
		public string mciNumber { get; private set; }
		public int[] variations { get; private set; }
		public string imageName { get; private set; }
		public string watermark { get; private set; }
		public bool? timeshifted { get; private set; }
		public int? hand { get; private set; }
		public int? life { get; private set; }
		public bool? reserved { get; private set; }
		public bool? starter { get; private set; }
		public string releaseDate { get; private set; }
		public string id { get; private set; }

		public Card(
			string name,
			string manaCost,
			double cmc,
			string[] colors,
			string[] colorIdentity,
			string type,
			string[] supertypes,
			string[] types,
			string[] subtypes,
			string rarity,
			string text,
			string flavor,
			string artist,
			string number,
			string power,
			string toughness,
			int? loyalty,
			string layout,
			int multiverseid,
			string mciNumber,
			int[] variations,
			string imageName,
			string watermark,
			bool? timeshifted,
			int? hand,
			int? life,
			bool? reserved,
			bool? starter,
			string releaseDate,
			string id
		) {
			this.name = name;
			this.manaCost = manaCost;
			this.cmc = cmc;
			this.colors = colors;
			this.colorIdentity = colorIdentity;
			this.type = type;
			this.supertypes = supertypes;
			this.types = types;
			this.subtypes = subtypes;
			this.rarity = rarity;
			this.text = text;
			this.flavor = flavor;
			this.artist = artist;
			this.number = number;
			this.power = power;
			this.toughness = toughness;
			this.loyalty = loyalty;
			this.layout = layout;
			this.multiverseid = multiverseid;
			this.mciNumber = mciNumber;
			this.variations = variations;
			this.imageName = imageName;
			this.watermark = watermark;
			this.timeshifted = timeshifted;
			this.hand = hand;
			this.life = life;
			this.reserved = reserved;
			this.starter = starter;
			this.releaseDate = releaseDate;
			this.id = id;
		}
	}
}
