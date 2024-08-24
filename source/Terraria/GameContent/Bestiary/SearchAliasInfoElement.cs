using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000647 RID: 1607
	[global::Cpp2ILInjected.Token(Token = "0x2000970")]
	public class SearchAliasInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x06003F1D RID: 16157 RVA: 0x0002D446 File Offset: 0x0002B646
		[global::Cpp2ILInjected.Token(Token = "0x6004840")]
		[global::Cpp2ILInjected.Address(RVA = "0x82211C", Offset = "0x82211C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SearchAliasInfoElement(string alias)
		{
			throw null;
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x0002D449 File Offset: 0x0002B649
		[global::Cpp2ILInjected.Token(Token = "0x6004841")]
		[global::Cpp2ILInjected.Address(RVA = "0x822144", Offset = "0x822144", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0002D44C File Offset: 0x0002B64C
		[global::Cpp2ILInjected.Token(Token = "0x6004842")]
		[global::Cpp2ILInjected.Address(RVA = "0x82215C", Offset = "0x82215C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C94 RID: 27796
		[global::Cpp2ILInjected.Token(Token = "0x40083BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _alias;
	}
}
