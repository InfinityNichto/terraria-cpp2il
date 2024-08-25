using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x200092C")]
	public interface IBestiarySortStep : IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700081A")]
		bool HiddenFromSortOptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x600472E")]
			get;
		}
	}
}
