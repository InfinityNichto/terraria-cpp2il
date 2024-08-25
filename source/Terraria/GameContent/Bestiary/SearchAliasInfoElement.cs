using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000970")]
	public class SearchAliasInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004840")]
		[global::Cpp2ILInjected.Address(RVA = "0x82211C", Offset = "0x82211C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SearchAliasInfoElement(string alias)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004841")]
		[global::Cpp2ILInjected.Address(RVA = "0x822144", Offset = "0x822144", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004842")]
		[global::Cpp2ILInjected.Address(RVA = "0x82215C", Offset = "0x82215C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40083BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _alias;
	}
}
