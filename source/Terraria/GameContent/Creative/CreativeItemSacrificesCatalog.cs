using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Reflection;
using UnityEngine;

namespace Terraria.GameContent.Creative
{
	// Token: 0x0200067D RID: 1661
	[global::Cpp2ILInjected.Token(Token = "0x2000A0D")]
	public class CreativeItemSacrificesCatalog
	{
		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x0002DB1E File Offset: 0x0002BD1E
		[global::Cpp2ILInjected.Token(Token = "0x17000873")]
		public Dictionary<int, int> SacrificeCountNeededByItemId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004BFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B45E0", Offset = "0x8B45E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x0002DB21 File Offset: 0x0002BD21
		[global::Cpp2ILInjected.Token(Token = "0x6004BFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B45E8", Offset = "0x8B45E8", Length = "0x6A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Split", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "TryGetId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x0002DB24 File Offset: 0x0002BD24
		[global::Cpp2ILInjected.Token(Token = "0x6004BFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B4C90", Offset = "0x8B4C90", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "CanBeResearched", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref int)
		}, ReturnType = typeof(GUIResearch.ResearchState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "ActionResearch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawItemProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip_GetLinesInfo", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(float),
			typeof(ref int),
			typeof(string[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "ShouldDrawSacrificeArea", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "TryGetSacrificeNumbers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemFilters.MiscFallback), Member = ".ctor", MemberParameters = new object[] { typeof(List<IItemEntryFilter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool TryGetSacrificeCountCapToUnlockInfiniteItems(int itemId, out int amountNeeded)
		{
			throw null;
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x0002DB27 File Offset: 0x0002BD27
		[global::Cpp2ILInjected.Token(Token = "0x6004BFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B4D50", Offset = "0x8B4D50", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeItemSacrificesCatalog), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CreativeItemSacrificesCatalog()
		{
			throw null;
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x0002DB2A File Offset: 0x0002BD2A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004C00")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B4DCC", Offset = "0x8B4DCC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeItemSacrificesCatalog), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static CreativeItemSacrificesCatalog()
		{
			throw null;
		}

		// Token: 0x04006DB6 RID: 28086
		[global::Cpp2ILInjected.Token(Token = "0x400861D")]
		public static CreativeItemSacrificesCatalog Instance;

		// Token: 0x04006DB7 RID: 28087
		[global::Cpp2ILInjected.Token(Token = "0x400861E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<int, int> _sacrificeCountNeededByItemId;
	}
}
