using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000958")]
	public interface IPreferenceProviderElement : IBestiaryInfoElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047E2")]
		IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider();

		[global::Cpp2ILInjected.Token(Token = "0x60047E3")]
		bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider);
	}
}
