using System;
using Cpp2ILInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000615 RID: 1557
	[global::Cpp2ILInjected.Token(Token = "0x2000925")]
	public interface IBestiaryEntryFilter : IEntryFilter<BestiaryEntry>
	{
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06003E51 RID: 15953
		[global::Cpp2ILInjected.Token(Token = "0x17000814")]
		bool? ForcedDisplay
		{
			[global::Cpp2ILInjected.Token(Token = "0x600470E")]
			get;
		}
	}
}
