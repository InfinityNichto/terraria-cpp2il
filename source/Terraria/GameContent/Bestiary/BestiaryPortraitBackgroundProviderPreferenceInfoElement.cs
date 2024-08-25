using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000959")]
	public class BestiaryPortraitBackgroundProviderPreferenceInfoElement : IPreferenceProviderElement, IBestiaryInfoElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3B8", Offset = "0x81D3B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BestiaryPortraitBackgroundProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProvider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3E0", Offset = "0x81D3E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3E8", Offset = "0x81D3E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3F8", Offset = "0x81D3F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008393")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProvider;
	}
}
