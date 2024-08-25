using System;
using Cpp2ILInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000925")]
	public interface IBestiaryEntryFilter : IEntryFilter<BestiaryEntry>
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000814")]
		bool? ForcedDisplay
		{
			[global::Cpp2ILInjected.Token(Token = "0x600470E")]
			get;
		}
	}
}
