using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200062E RID: 1582
	[global::Cpp2ILInjected.Token(Token = "0x2000951")]
	public class HighestOfMultipleUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		// Token: 0x06003EAC RID: 16044 RVA: 0x0002D308 File Offset: 0x0002B508
		[global::Cpp2ILInjected.Token(Token = "0x60047C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C0C0", Offset = "0x81C0C0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HighestOfMultipleUICollectionInfoProvider(params IBestiaryUICollectionInfoProvider[] providers)
		{
			throw null;
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x0002D30B File Offset: 0x0002B50B
		[global::Cpp2ILInjected.Token(Token = "0x60047C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C0EC", Offset = "0x81C0EC", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			throw null;
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x0002D30E File Offset: 0x0002B50E
		[global::Cpp2ILInjected.Token(Token = "0x60047C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C258", Offset = "0x81C258", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C67 RID: 27751
		[global::Cpp2ILInjected.Token(Token = "0x4008386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IBestiaryUICollectionInfoProvider[] _providers;

		// Token: 0x04006C68 RID: 27752
		[global::Cpp2ILInjected.Token(Token = "0x4008387")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _mainProviderIndex;
	}
}
