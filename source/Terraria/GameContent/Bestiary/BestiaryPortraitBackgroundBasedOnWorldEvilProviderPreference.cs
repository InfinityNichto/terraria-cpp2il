using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000637 RID: 1591
	[global::Cpp2ILInjected.Token(Token = "0x200095A")]
	public class BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement : IPreferenceProviderElement, IBestiaryInfoElement
	{
		// Token: 0x06003ED4 RID: 16084 RVA: 0x0002D377 File Offset: 0x0002B577
		[global::Cpp2ILInjected.Token(Token = "0x60047E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D400", Offset = "0x81D400", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProviderCorrupt, IBestiaryBackgroundImagePathAndColorProvider preferredProviderCrimson)
		{
			throw null;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0002D37A File Offset: 0x0002B57A
		[global::Cpp2ILInjected.Token(Token = "0x60047E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D42C", Offset = "0x81D42C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0002D37D File Offset: 0x0002B57D
		[global::Cpp2ILInjected.Token(Token = "0x60047EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D434", Offset = "0x81D434", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
		{
			throw null;
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x0002D380 File Offset: 0x0002B580
		[global::Cpp2ILInjected.Token(Token = "0x60047EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D4EC", Offset = "0x81D4EC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
		{
			throw null;
		}

		// Token: 0x04006C75 RID: 27765
		[global::Cpp2ILInjected.Token(Token = "0x4008394")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCorrupt;

		// Token: 0x04006C76 RID: 27766
		[global::Cpp2ILInjected.Token(Token = "0x4008395")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCrimson;
	}
}
