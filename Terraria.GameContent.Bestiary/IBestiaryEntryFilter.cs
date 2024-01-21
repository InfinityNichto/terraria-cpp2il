using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000618")]
public interface IBestiaryEntryFilter : IEntryFilter<BestiaryEntry>
{
	[Cpp2IlInjected.Token(Token = "0x17000766")]
	bool? ForcedDisplay
	{
		[Cpp2IlInjected.Token(Token = "0x6003E8D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
