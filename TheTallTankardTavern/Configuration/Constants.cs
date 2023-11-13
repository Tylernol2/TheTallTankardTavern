using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TheTallTankardTavern.Models;
using TTT.Items;
using static TheTallTankardTavern.Configuration.ApplicationSettings;

namespace TheTallTankardTavern.Configuration
{
	public static class Constants
	{
        #region Enumerators

        public enum FOLDER
        {
            Backgrounds,
            Characters,
            Features,
            Imported_Features,
            Items,
            Party,
            Imported_Spells,
            Spells,
            Storage,
            User
        }
        public enum LANGUAGES
        {
            Common,
            Abyssal,
            Aquan,
            Auran,
            Celestial,
            Deep_Speech,
            Draconic,
            Druidic,
            Dwarven,
            Elven,
            Giant,
            Gnomish,
            Goblin,
            Gnoll,
            Halfling,
            Ignan,
            Infernal,
            Orcish,
            Primordial,
            Sylvan,
            Terran,
            Undercommon
        }
        public enum MAGIC_SCHOOLS
        {
            Abjuration,
            Conjuration,
            Divination,
            Enchantment,
            Evocation,
            Illusion,
            Necromancy,
            Transmutation,
        }
        public enum MODEL_TYPES
        {
            BACKGROUND,
            FEATURE,
            ITEM,
            SPELL
        }
		public enum ROLES
		{
			Administrator = 0xFF,
			Dungeon_Master = 3,
			Dungeon_Master_Readonly = 2,
			Player = 1
		}
		public enum SKILL_CATEGORY
		{
			Strength,
			Dexterity,
			Constitution,
			Intelligence,
			Wisdom,
			Charisma
		}
        public enum WEAPON_TRAIT
        {
            None,
            Defensive,
            Finesse,
            Large,
            Small,
            Ranged,
            Reach,
            Thrown,
            Two_Handed,
            Versitile
        }

        public enum ITEM_EQUIP_RESULT
        {
            EQUIPPED,
            REPLACED,
            NO_ACTION
        }
        #endregion

        public static readonly List<ItemType> MONK_WEAPONS = new List<ItemType>()
        {
            //Simple Melee Weapons
            ItemType.Club,
            ItemType.Dagger,
            ItemType.Halberd,
            ItemType.Javelin,
            ItemType.LightHammer,
            ItemType.Mace,
            ItemType.Quaterstaff,
            ItemType.Sickle,
            ItemType.Spear,

            //Simple Ranged Weapons
            ItemType.LightCrossbow,
            ItemType.Dart,
            ItemType.Sling,

            //Shortsword
            ItemType.Shortsword
        };

        public static class SpecialFeatures
        {
            private static IEnumerable<FeatureModel> UNARMOURED_DEFENSE_FEATURES => FeatureDataContext.Where(f => f.Name.Contains("Unarmored Defense"));
            public static FeatureModel UNARMOURED_DEFENSE_BARBARIAN => UNARMOURED_DEFENSE_FEATURES.First(f => f.Class.Contains("Barbarian"));
            public static FeatureModel UNARMOURED_DEFENSE_MONK => UNARMOURED_DEFENSE_FEATURES.First(f => f.Class.Contains("Monk"));
            public static FeatureModel DUAL_WIELDER => FeatureDataContext.SingleOrDefault(f => f.Name.Contains("Dual Wielder"));
            public static FeatureModel TOUGH => FeatureDataContext.SingleOrDefault(f => f.Name.Equals("Tough"));
        }
        public static class ITEM_TYPES
        {
            public const string ARMOUR = "Armour";
            public const string BRACERS = "Bracers";
            public const string FOOTWEAR = "Footwear";
            public const string GLOVES = "Gloves";
            public const string HEADGEAR = "Headgear";
            public const string NECKLACE = "Necklace";
            public const string RING = "Ring";
            public const string WEAPON = "Weapon";
            public const string MISC = "Miscellaneous";

            public static string[] ACCESSORIES { get { return new string[] { BRACERS, FOOTWEAR, GLOVES, HEADGEAR, NECKLACE, RING }; } }
        }
        public static class WEAPON_SIZE
        {
            public const string SMALL = "Small";
            public const string MEDIUM = "Medium";
            public const string LARGE = "Large";
        }
        public static class WEIGHT
		{
			public const string LIGHT = "Light";
			public const string MEDIUM = "Medium";
			public const string HEAVY = "Heavy";
		}
        public static class PROFICIENCY
        {
            public const string NOT_PROFICIENT = "Not Proficient";
            public const string PROFICIENT = "Proficient";
            public const string EXPERTISE = "Expertise";
        }

		public static readonly Dictionary<string, int> SKILL_LEVELS = new Dictionary<string, int>
		{
			{ PROFICIENCY.NOT_PROFICIENT, 0 },
			{ PROFICIENCY.PROFICIENT, 1 },
			{ PROFICIENCY.EXPERTISE, 2 }
		};
		public static readonly Dictionary<string, int> SAVE_PROFICIENCIES = new Dictionary<string, int>
		{
			{ PROFICIENCY.NOT_PROFICIENT, 0 },
			{ PROFICIENCY.PROFICIENT, 1 }
		};
		public static readonly Dictionary<string, int> WEAPON_WEIGHT_CLASS = new Dictionary<string, int>
		{
			{
				"Light",
				1
			},
			{
				"Medium",
				2
			},
			{
				"Heavy",
				3
			}
		};

        public static class SPELL_SLOTS
        {
            public static readonly int[,] FULL_CASTER = new int[30, 9]
            {
            {
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                2,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                2,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                1,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                1,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                1,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                1,
                1,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                1,
                1,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                1,
                1,
                1,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                1,
                1,
                1,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                1,
                1,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                1,
                1,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                1,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            },
            {
                4,
                3,
                3,
                3,
                3,
                2,
                2,
                1,
                1
            }
            };

            public static readonly int[,] HALF_CASTER = new int[30, 9]
            {
            {
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                2,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                2,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                2,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                2,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                1,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                1,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                3,
                2,
                0,
                0,
                0,
                0
            }
            };

            public static readonly int[,] THIRD_CASTER = new int[30, 9]
            {
            {
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                2,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                2,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                2,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            },
            {
                4,
                3,
                3,
                1,
                0,
                0,
                0,
                0,
                0
            }
            };

            public static readonly int[,] PACT_CASTER = new int[30, 9]
            {
            {
                1,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                0,
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                0,
                2,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                2,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                2,
                0,
                0,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                2,
                0,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                2,
                0,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                2,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                2,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                3,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                3,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                3,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                3,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                3,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                3,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            },
            {
                0,
                0,
                0,
                0,
                4,
                0,
                0,
                0,
                0
            }
            };
        }

        public static class TAGHELPER
        {
            public static class CSS_CLASSES
            {
                public const string BUTTON = "btn btn-outline-dark btn-sm";
            }

            public static class SUBMIT_TEXT
            {
                public const string SAVE_AND_FINISH = "Save & Finish";
                public const string SAVE_AND_CONTINUE = "Save & Continue";
            }
        }

        public static readonly string MAP_ROOT = ImagesFolder + "\\custom\\maps\\Esidar";
    }
}
