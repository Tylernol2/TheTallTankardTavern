using System;
using TTT.Enumerator;
using System.Collections.Generic;

namespace TheTallTankardTavern.Models
{
	public class CheckBoxListModel<TEnum> : BaseListModel<bool> where TEnum : Enum
	{
		public bool this[TEnum enumValue]
		{
			get
			{
				return InnerCollection[(int)((object)enumValue)];
			}
			set
			{
				InnerCollection[(int)((object)enumValue)] = value;
			}
		}

		public override string ToString()
		{
			return this.ToString(new TEnum[] { });
		}

		public string ToString(params TEnum[] ignoreValues)
		{
			List<TEnum> IgnoreValues = new List<TEnum>(ignoreValues);
			List<string> StringList = new List<string>(); 
			foreach (TEnum value in typeof(TEnum).EnumToEnumArray<TEnum>())
			{
				if (this[value] && !IgnoreValues.Contains(value))
				{
					StringList.Add(value.EnumToString());
				}
			}
			return string.Join(",", StringList);
		}

		public static CheckBoxListModel<TEnum> Empty()
		{
			TEnum[] AllValues = typeof(TEnum).EnumToEnumArray<TEnum>();
			CheckBoxListModel<TEnum> Empty = new CheckBoxListModel<TEnum>();
			foreach (TEnum value in AllValues)
			{
				Empty.Add(false);
			}
			return Empty;
		}
	}
}
