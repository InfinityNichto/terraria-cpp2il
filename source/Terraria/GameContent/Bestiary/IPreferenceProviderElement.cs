using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000635 RID: 1589
	[global::Cpp2ILInjected.Token(Token = "0x2000958")]
	public interface IPreferenceProviderElement : IBestiaryInfoElement
	{
		// Token: 0x06003ECE RID: 16078
		[global::Cpp2ILInjected.Token(Token = "0x60047E2")]
		IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider();

		// Token: 0x06003ECF RID: 16079
		[global::Cpp2ILInjected.Token(Token = "0x60047E3")]
		bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider);
	}
}
