using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000951")]
	public class HighestOfMultipleUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C0C0", Offset = "0x81C0C0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HighestOfMultipleUICollectionInfoProvider(params IBestiaryUICollectionInfoProvider[] providers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C0EC", Offset = "0x81C0EC", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C258", Offset = "0x81C258", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IBestiaryUICollectionInfoProvider[] _providers;

		[global::Cpp2ILInjected.Token(Token = "0x4008387")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _mainProviderIndex;
	}
}
