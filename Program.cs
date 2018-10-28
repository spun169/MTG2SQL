using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace mtgToSQL
{
	class Program
	{
		static void Main(string[] args)
		{
			string insertSetSql = File.ReadAllText("insertSet.sql", Encoding.UTF8);
			string insertCardSql = File.ReadAllText("insertCard.sql", Encoding.UTF8);
			string text = File.ReadAllText("AllSets-x.json", Encoding.UTF8);
			Dictionary<string, Set> allSets = JsonConvert.DeserializeObject<Dictionary<string, Set>>(text);
			string insertSql = string.Join(Environment.NewLine, allSets.Values.SelectMany(_set => {
				List<string> setSql = new List<string>();
				setSql.Add(string.Format(
					insertSetSql,
					_set.name,
					_set.code,
					_set.gathererCode,
					_set.oldCode,
					_set.magicCardsInfoCode,
					_set.releaseDate,
					_set.border,
					_set.type,
					_set.block,
					_set.onlineOnly,
					_set.cards));
				setSql.AddRange(_set.cards.Select(card => string.Format(
						insertCardSql,
						card.name,
						card.manaCost,
						card.cmc,
						card.colors == null ? null : string.Join(',', card.colors),
						card.colorIdentity == null ? null : string.Join(',', card.colorIdentity),
						card.type,
						card.supertypes == null ? null : string.Join(',', card.supertypes),
						card.types == null ? null : string.Join(',', card.types),
						card.subtypes == null ? null : string.Join(',', card.subtypes),
						card.rarity,
						card.text,
						card.flavor,
						card.artist,
						card.number,
						card.power,
						card.toughness,
						card.loyalty,
						card.layout,
						card.multiverseid,
						card.mciNumber,
						card.variations == null ? null : string.Join(',', card.variations),
						card.imageName,
						card.watermark,
						card.timeshifted,
						card.hand,
						card.life,
						card.reserved,
						card.starter,
						card.releaseDate,
						card.id)));
				return setSql;
			}));

			File.WriteAllText("data.sql", insertSql);
		}
	}
}
