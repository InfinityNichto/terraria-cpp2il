using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000617 RID: 1559
	[global::Cpp2ILInjected.Token(Token = "0x200092C")]
	public interface IBestiarySortStep : IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003E52 RID: 15954
		[global::Cpp2ILInjected.Token(Token = "0x1700081A")]
		bool HiddenFromSortOptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x600472E")]
			get;
		}
	}
}
