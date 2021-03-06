﻿using ModuleUnserializer.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuleUnserializer.Entities
{
	public class Faction
	{
		public ModuleInfo Module;
		public string Index;
		public string NameEn;
		public string Name;
		public int Flags;
		public int Color;
		public List<float> Relations;
		public List<string> Ranks;//在官方的module system中没发现这个有啥用，但是也写上以防出问题
		private Faction()
		{

		}
		public static Faction FromString(ModuleInfo mInfo, string[] s, ref int j, int numberOfFactions)
		{
			Faction faction = new Faction();
			faction.Module = mInfo;
			faction.Relations = new List<float>();
			faction.Ranks = new List<string>();
			faction.Index = s[j++];
			faction.Index = faction.Index.Substring(faction.Index.IndexOf("_") + 1);
			faction.NameEn = s[j++];
			faction.Name = faction.NameEn;
			if (mInfo.F_Language["factions"].ContainsKey(faction.Index))
				faction.Name = mInfo.F_Language["factions"][faction.Index];
			faction.Flags = Convert.ToInt32(s[j++]);
			faction.Color = Convert.ToInt32(s[j++]);
			for (int i = 0; i < numberOfFactions; i++)
				faction.Relations.Add(Convert.ToSingle(s[j++]));
			int ranks = Convert.ToInt32(s[j++]);
			for (int i = 0; i < ranks; i++)
				faction.Ranks.Add(s[j++]);
			return faction;
		}

		public string Compile(CompilationContext ctx)
		{
			throw new NotImplementedException();
		}
	}
}
