using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200061A")]
public interface IBestiarySortStep : IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
{
	[Cpp2IlInjected.Token(Token = "0x17000767")]
	bool HiddenFromSortOptions
	{
		[Cpp2IlInjected.Token(Token = "0x6003E8E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
