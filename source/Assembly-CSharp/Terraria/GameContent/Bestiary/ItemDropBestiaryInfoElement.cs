using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200063D RID: 1597
	[global::Cpp2ILInjected.Token(Token = "0x2000960")]
	public class ItemDropBestiaryInfoElement : IItemBestiaryInfoElement, IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x06003EF1 RID: 16113 RVA: 0x0002D3C5 File Offset: 0x0002B5C5
		[global::Cpp2ILInjected.Token(Token = "0x6004805")]
		[global::Cpp2ILInjected.Address(RVA = "0x810130", Offset = "0x810130", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemDropBestiaryInfoElement(DropRateInfo info)
		{
			throw null;
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0002D3C8 File Offset: 0x0002B5C8
		[global::Cpp2ILInjected.Token(Token = "0x6004806")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DACC", Offset = "0x81DACC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "GetDropProviders", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(List<ItemDropBestiaryInfoElement>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool ShouldShowItem()
		{
			throw null;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0002D3CB File Offset: 0x0002B5CB
		[global::Cpp2ILInjected.Token(Token = "0x6004807")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DBE4", Offset = "0x81DBE4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropBestiaryInfoElement), Member = "ShouldShowItem", MemberParameters = new object[] { typeof(ref DropRateInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryInfoItemLine), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DropRateInfo),
			typeof(BestiaryUICollectionInfo),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0002D3CE File Offset: 0x0002B5CE
		[global::Cpp2ILInjected.Token(Token = "0x6004808")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DAD4", Offset = "0x81DAD4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropBestiaryInfoElement), Member = "GetSearchString", MemberParameters = new object[] { typeof(ref BestiaryUICollectionInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool ShouldShowItem(ref DropRateInfo dropRateInfo)
		{
			throw null;
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0002D3D1 File Offset: 0x0002B5D1
		[global::Cpp2ILInjected.Token(Token = "0x6004809")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DC90", Offset = "0x81DC90", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropBestiaryInfoElement), Member = "ShouldShowItem", MemberParameters = new object[] { typeof(ref DropRateInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C81 RID: 27777
		[global::Cpp2ILInjected.Token(Token = "0x40083A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public DropRateInfo _droprateInfo;
	}
}
