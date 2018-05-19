﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuleUnserializer.Files
{
	public class ModuleInfo
	{
		public F_Language F_Language;

		public F_Strings F_Strings;
		public F_Menus F_Menus;
		public F_Variables F_Variables;
		public F_QuickStrings F_QuickStrings;
		public F_Factions F_Factions;
		public F_Items F_Items;
		public F_SimpleTriggers F_SimpleTriggers;
		public F_Scripts F_Scripts;
		public F_Parties F_Parties;
		public F_Troops F_Troops;
		public F_Sounds F_Sounds;
		public F_Quests F_Quests;
		public F_Party_Templates F_Party_Templates;
		public F_Scenes F_Scenes;
		public F_Mission_Templates F_Mission_Templates;
		public F_Particle_Systems F_Particle_Systems;
		public F_Scene_Props F_Scene_Props;
		public F_Meshes F_Meshes;
		public F_Tableau_Mats F_Tableau_Mats;
		public F_Skills F_Skills;
		public F_Presentations F_Presentations;
		public ModuleInfo(string MnBPath, string module, string language)
		{
			F_Language = new F_Language(MnBPath, module, language);
			F_Presentations = F_Presentations.LoadFromFile(this, MnBPath, module);
			F_Tableau_Mats = F_Tableau_Mats.LoadFromFile(this, MnBPath, module);
			F_Skills = F_Skills.LoadFromFile(this, MnBPath, module);
			F_Meshes = F_Meshes.LoadFromFile(this, MnBPath, module);
			F_Strings = F_Strings.LoadFromFile(this, MnBPath, module);
			F_Variables = F_Variables.LoadFromFile(this, MnBPath, module);
			F_QuickStrings = F_QuickStrings.LoadFromFile(this, MnBPath, module);
			F_Factions = F_Factions.LoadFromFile(this, MnBPath, module);
			F_Scripts = F_Scripts.LoadFromFile(this, MnBPath, module);
			F_SimpleTriggers = F_SimpleTriggers.LoadFromFile(this, MnBPath, module);


			F_Items = F_Items.LoadFromFile(this, MnBPath, module);
			F_Menus = F_Menus.LoadFromFile(this, MnBPath, module);
			F_Parties = F_Parties.LoadFromFile(this, MnBPath, module);
			F_Troops = F_Troops.LoadFromFile(this, MnBPath, module);
			F_Sounds = F_Sounds.LoadFromFile(this, MnBPath, module);
			F_Quests = F_Quests.LoadFromFile(this, MnBPath, module);
			F_Party_Templates = F_Party_Templates.LoadFromFile(this, MnBPath, module);
			F_Scenes = F_Scenes.LoadFromFile(this, MnBPath, module);
			F_Mission_Templates = F_Mission_Templates.LoadFromFile(this, MnBPath, module);
			F_Particle_Systems = F_Particle_Systems.LoadFromFile(this, MnBPath, module);
			F_Scene_Props = F_Scene_Props.LoadFromFile(this, MnBPath, module);
		}
	}
}
