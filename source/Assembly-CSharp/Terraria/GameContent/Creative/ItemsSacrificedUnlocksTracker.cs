using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.UI.Elements;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000682 RID: 1666
	[global::Cpp2ILInjected.Token(Token = "0x2000A15")]
	public class ItemsSacrificedUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x0002DBB1 File Offset: 0x0002BDB1
		// (set) Token: 0x0600419D RID: 16797 RVA: 0x0002DBB4 File Offset: 0x0002BDB4
		[global::Cpp2ILInjected.Token(Token = "0x17000876")]
		public int LastEditId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004C31")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B82C8", Offset = "0x8B82C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004C32")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B82D0", Offset = "0x8B82D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x0002DBB7 File Offset: 0x0002BDB7
		[global::Cpp2ILInjected.Token(Token = "0x6004C33")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B81FC", Offset = "0x8B81FC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUnlocksTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ItemsSacrificedUnlocksTracker()
		{
			throw null;
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x0002DBBA File Offset: 0x0002BDBA
		[global::Cpp2ILInjected.Token(Token = "0x6004C34")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7308", Offset = "0x8B7308", Length = "0xB4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int GetSacrificeCount(int itemId)
		{
			throw null;
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x0002DBBD File Offset: 0x0002BDBD
		[global::Cpp2ILInjected.Token(Token = "0x6004C35")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7ABC", Offset = "0x8B7ABC", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "UpdateFilter", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "RefreshAvailableInfiniteItemsList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "TryGetSacrificeNumbers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void FillListOfItemsThatCanBeObtainedInfinitely(List<int> toObtainInfinitely)
		{
			throw null;
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x0002DBC0 File Offset: 0x0002BDC0
		[global::Cpp2ILInjected.Token(Token = "0x6004C36")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7464", Offset = "0x8B7464", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "SacrificeItem", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(CreativeUI.ItemSacrificeResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "FillListOfItemsThatCanBeObtainedInfinitely", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeItemSacrificesCatalog), Member = "TryGetSacrificeCountCapToUnlockInfiniteItems", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool TryGetSacrificeNumbers(int itemId, out int amountWeHave, out int amountNeededTotal)
		{
			throw null;
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x0002DBC3 File Offset: 0x0002BDC3
		[global::Cpp2ILInjected.Token(Token = "0x6004C37")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B78D8", Offset = "0x8B78D8", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "ActionResearch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "SacrificeItem", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(CreativeUI.ItemSacrificeResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void RegisterItemSacrifice(int itemId, int amount)
		{
			throw null;
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x0002DBC6 File Offset: 0x0002BDC6
		[global::Cpp2ILInjected.Token(Token = "0x6004C38")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B82E8", Offset = "0x8B82E8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativeUnlocksModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void SetSacrificeCountDirectly(string persistentId, int sacrificeCount)
		{
			throw null;
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x0002DBC9 File Offset: 0x0002BDC9
		[global::Cpp2ILInjected.Token(Token = "0x6004C39")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7D0C", Offset = "0x8B7D0C", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", MemberParameters = new object[] { typeof(IDictionary<object, int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x0002DBCC File Offset: 0x0002BDCC
		[global::Cpp2ILInjected.Token(Token = "0x6004C3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7F10", Offset = "0x8B7F10", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x0002DBCF File Offset: 0x0002BDCF
		[global::Cpp2ILInjected.Token(Token = "0x6004C3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B8438", Offset = "0x8B8438", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x0002DBD2 File Offset: 0x0002BDD2
		[global::Cpp2ILInjected.Token(Token = "0x6004C3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B8118", Offset = "0x8B8118", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x0002DBD5 File Offset: 0x0002BDD5
		[global::Cpp2ILInjected.Token(Token = "0x6004C3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B819C", Offset = "0x8B819C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnPlayerJoining(int playerIndex)
		{
			throw null;
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x0002DBD8 File Offset: 0x0002BDD8
		[global::Cpp2ILInjected.Token(Token = "0x6004C3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B82D8", Offset = "0x8B82D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void MarkContentsDirty()
		{
			throw null;
		}

		// Token: 0x04006DC9 RID: 28105
		[global::Cpp2ILInjected.Token(Token = "0x400864E")]
		public const int POSITIVE_SACRIFICE_COUNT_CAP = 9999;

		// Token: 0x04006DCA RID: 28106
		[global::Cpp2ILInjected.Token(Token = "0x400864F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<string, int> _sacrificeCountByItemPersistentId;

		// Token: 0x04006DCB RID: 28107
		[global::Cpp2ILInjected.Token(Token = "0x4008650")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Dictionary<int, int> SacrificesCountByItemIdCache;

		// Token: 0x04006DCC RID: 28108
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008651")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int <LastEditId>k__BackingField;
	}
}
