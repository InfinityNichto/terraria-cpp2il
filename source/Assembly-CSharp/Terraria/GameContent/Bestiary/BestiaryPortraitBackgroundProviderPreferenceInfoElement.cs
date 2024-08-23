using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000636 RID: 1590
	[global::Cpp2ILInjected.Token(Token = "0x2000959")]
	public class BestiaryPortraitBackgroundProviderPreferenceInfoElement : IPreferenceProviderElement, IBestiaryInfoElement
	{
		// Token: 0x06003ED0 RID: 16080 RVA: 0x0002D36B File Offset: 0x0002B56B
		[global::Cpp2ILInjected.Token(Token = "0x60047E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3B8", Offset = "0x81D3B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BestiaryPortraitBackgroundProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProvider)
		{
			throw null;
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0002D36E File Offset: 0x0002B56E
		[global::Cpp2ILInjected.Token(Token = "0x60047E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3E0", Offset = "0x81D3E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0002D371 File Offset: 0x0002B571
		[global::Cpp2ILInjected.Token(Token = "0x60047E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3E8", Offset = "0x81D3E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
		{
			throw null;
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0002D374 File Offset: 0x0002B574
		[global::Cpp2ILInjected.Token(Token = "0x60047E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D3F8", Offset = "0x81D3F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
		{
			throw null;
		}

		// Token: 0x04006C74 RID: 27764
		[global::Cpp2ILInjected.Token(Token = "0x4008393")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProvider;
	}
}
