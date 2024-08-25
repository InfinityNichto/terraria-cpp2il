using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000955")]
	public class BossBestiaryInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CAF8", Offset = "0x81CAF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CB00", Offset = "0x81CB00", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x819BE0", Offset = "0x819BE0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BossBestiaryInfoElement()
		{
			throw null;
		}
	}
}
