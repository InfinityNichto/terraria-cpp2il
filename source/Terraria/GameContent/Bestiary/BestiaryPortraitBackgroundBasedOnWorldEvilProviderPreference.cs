using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x200095A")]
	public class BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement : IPreferenceProviderElement, IBestiaryInfoElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D400", Offset = "0x81D400", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProviderCorrupt, IBestiaryBackgroundImagePathAndColorProvider preferredProviderCrimson)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D42C", Offset = "0x81D42C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D434", Offset = "0x81D434", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D4EC", Offset = "0x81D4EC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008394")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCorrupt;

		[global::Cpp2ILInjected.Token(Token = "0x4008395")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCrimson;
	}
}
