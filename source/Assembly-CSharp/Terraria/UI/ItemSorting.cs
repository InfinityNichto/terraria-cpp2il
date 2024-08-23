using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.UI
{
	// Token: 0x020004C4 RID: 1220
	[global::Cpp2ILInjected.Token(Token = "0x20006E5")]
	public class ItemSorting
	{
		// Token: 0x060035A3 RID: 13731 RVA: 0x0002B95E File Offset: 0x00029B5E
		[global::Cpp2ILInjected.Token(Token = "0x6003B3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x147D778", Offset = "0x147D778", Length = "0x1234")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 117)]
		public static void SetupWhiteLists()
		{
			throw null;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0002B961 File Offset: 0x00029B61
		[global::Cpp2ILInjected.Token(Token = "0x6003B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x147E9AC", Offset = "0x147E9AC", Length = "0x151C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(bool),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private static void SetupSortingPriorities()
		{
			throw null;
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x0002B964 File Offset: 0x00029B64
		[global::Cpp2ILInjected.Token(Token = "0x6003B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x147FEC8", Offset = "0x147FEC8", Length = "0x9FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "SortInventory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "SortChest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "SetupSortingPriorities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Contains", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<int>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetGlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 56)]
		private static void Sort(Item[] inv, bool fromChest, params int[] ignoreSlots)
		{
			throw null;
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x0002B967 File Offset: 0x00029B67
		[global::Cpp2ILInjected.Token(Token = "0x6003B40")]
		[global::Cpp2ILInjected.Address(RVA = "0x14808C4", Offset = "0x14808C4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "HasItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "SortCoins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "SortAmmo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(bool),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void SortInventory()
		{
			throw null;
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x0002B96A File Offset: 0x00029B6A
		[global::Cpp2ILInjected.Token(Token = "0x6003B41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1480D6C", Offset = "0x1480D6C", Length = "0x424")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new object[] { "T1", "T2", "T3" }, MemberParameters = new object[] { "T1", "T2", "T3" }, ReturnType = "System.Tuple`3<T1, T2, T3>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(bool),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static void SortChest()
		{
			throw null;
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x0002B96D File Offset: 0x00029B6D
		[global::Cpp2ILInjected.Token(Token = "0x6003B42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1480D1C", Offset = "0x1480D1C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "SortInventory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "ClearAmmoSlotSpaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "FillAmmoFromInventory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SortAmmo()
		{
			throw null;
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x0002B970 File Offset: 0x00029B70
		[global::Cpp2ILInjected.Token(Token = "0x6003B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x14812F0", Offset = "0x14812F0", Length = "0x494")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "SortAmmo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetGlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "RefillItemStack", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(Item),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "CanFillEmptyAmmoSlot", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "FitsAmmoSlot", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static void FillAmmoFromInventory()
		{
			throw null;
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x0002B973 File Offset: 0x00029B73
		[global::Cpp2ILInjected.Token(Token = "0x6003B44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1481190", Offset = "0x1481190", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "SortAmmo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "RefillItemStack", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(Item),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "TrySlidingUp", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void ClearAmmoSlotSpaces()
		{
			throw null;
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x0002B976 File Offset: 0x00029B76
		[global::Cpp2ILInjected.Token(Token = "0x6003B45")]
		[global::Cpp2ILInjected.Address(RVA = "0x14809E4", Offset = "0x14809E4", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "SortInventory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsCount", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(Item[]),
			typeof(int[])
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsSplit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItemSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickSpawnItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void SortCoins()
		{
			throw null;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x0002B979 File Offset: 0x00029B79
		[global::Cpp2ILInjected.Token(Token = "0x6003B46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1481784", Offset = "0x1481784", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "FillAmmoFromInventory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "ClearAmmoSlotSpaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private static void RefillItemStack(Item[] inv, Item itemToRefill, int loopStartIndex, int loopEndIndex)
		{
			throw null;
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x0002B97C File Offset: 0x00029B7C
		[global::Cpp2ILInjected.Token(Token = "0x6003B47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1481838", Offset = "0x1481838", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "ClearAmmoSlotSpaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void TrySlidingUp(Item[] inv, int slot, int minimumIndex)
		{
			throw null;
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x0002B97F File Offset: 0x00029B7F
		[global::Cpp2ILInjected.Token(Token = "0x6003B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x14818FC", Offset = "0x14818FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemSorting()
		{
			throw null;
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x0002B982 File Offset: 0x00029B82
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003B49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1481904", Offset = "0x1481904", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static ItemSorting()
		{
			throw null;
		}

		// Token: 0x04006692 RID: 26258
		[global::Cpp2ILInjected.Token(Token = "0x4007B06")]
		private static List<ItemSorting.ItemSortingLayer> _layerList;

		// Token: 0x04006693 RID: 26259
		[global::Cpp2ILInjected.Token(Token = "0x4007B07")]
		private static Dictionary<string, List<int>> _layerWhiteLists;

		// Token: 0x02000956 RID: 2390
		[global::Cpp2ILInjected.Token(Token = "0x20006E6")]
		private class ItemSortingLayer
		{
			// Token: 0x06004D0F RID: 19727 RVA: 0x0002F9F6 File Offset: 0x0002DBF6
			[global::Cpp2ILInjected.Token(Token = "0x6003B4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x14819E0", Offset = "0x14819E0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ItemSortingLayer(string name, Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> method)
			{
				throw null;
			}

			// Token: 0x06004D10 RID: 19728 RVA: 0x0002F9F9 File Offset: 0x0002DBF9
			[global::Cpp2ILInjected.Token(Token = "0x6003B4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1481A0C", Offset = "0x1481A0C", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(IEnumerable<int>),
				typeof(Func<int, bool>)
			}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public void Validate(ref List<int> indexesSortable, Item[] inv)
			{
				throw null;
			}

			// Token: 0x06004D11 RID: 19729 RVA: 0x0002F9FC File Offset: 0x0002DBFC
			[global::Cpp2ILInjected.Token(Token = "0x6003B4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1481B68", Offset = "0x1481B68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04008B53 RID: 35667
			[global::Cpp2ILInjected.Token(Token = "0x4007B08")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly string Name;

			// Token: 0x04008B54 RID: 35668
			[global::Cpp2ILInjected.Token(Token = "0x4007B09")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> SortingMethod;

			// Token: 0x02000B80 RID: 2944
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006E7")]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x0600537C RID: 21372 RVA: 0x00030B66 File Offset: 0x0002ED66
				[global::Cpp2ILInjected.Token(Token = "0x6003B4D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1481B60", Offset = "0x1481B60", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass3_0()
				{
					throw null;
				}

				// Token: 0x0600537D RID: 21373 RVA: 0x00030B69 File Offset: 0x0002ED69
				[global::Cpp2ILInjected.Token(Token = "0x6003B4E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1481B70", Offset = "0x1481B70", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Validate>b__0(int i)
				{
					throw null;
				}

				// Token: 0x040090D7 RID: 37079
				[global::Cpp2ILInjected.Token(Token = "0x4007B0A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public List<int> list;

				// Token: 0x040090D8 RID: 37080
				[global::Cpp2ILInjected.Token(Token = "0x4007B0B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public Item[] inv;
			}
		}

		// Token: 0x02000957 RID: 2391
		[global::Cpp2ILInjected.Token(Token = "0x20006E8")]
		private class ItemSortingLayers
		{
			// Token: 0x06004D12 RID: 19730 RVA: 0x0002F9FF File Offset: 0x0002DBFF
			[global::Cpp2ILInjected.Token(Token = "0x6003B4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1481BD0", Offset = "0x1481BD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ItemSortingLayers()
			{
				throw null;
			}

			// Token: 0x06004D13 RID: 19731 RVA: 0x0002FA02 File Offset: 0x0002DC02
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003B50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1481BD8", Offset = "0x1481BD8", Length = "0x1278")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 157)]
			static ItemSortingLayers()
			{
				throw null;
			}

			// Token: 0x04008B55 RID: 35669
			[global::Cpp2ILInjected.Token(Token = "0x4007B0C")]
			public static ItemSorting.ItemSortingLayer WeaponsMelee;

			// Token: 0x04008B56 RID: 35670
			[global::Cpp2ILInjected.Token(Token = "0x4007B0D")]
			public static ItemSorting.ItemSortingLayer WeaponsRanged;

			// Token: 0x04008B57 RID: 35671
			[global::Cpp2ILInjected.Token(Token = "0x4007B0E")]
			public static ItemSorting.ItemSortingLayer WeaponsMagic;

			// Token: 0x04008B58 RID: 35672
			[global::Cpp2ILInjected.Token(Token = "0x4007B0F")]
			public static ItemSorting.ItemSortingLayer WeaponsMinions;

			// Token: 0x04008B59 RID: 35673
			[global::Cpp2ILInjected.Token(Token = "0x4007B10")]
			public static ItemSorting.ItemSortingLayer WeaponsAssorted;

			// Token: 0x04008B5A RID: 35674
			[global::Cpp2ILInjected.Token(Token = "0x4007B11")]
			public static ItemSorting.ItemSortingLayer WeaponsAmmo;

			// Token: 0x04008B5B RID: 35675
			[global::Cpp2ILInjected.Token(Token = "0x4007B12")]
			public static ItemSorting.ItemSortingLayer ToolsPicksaws;

			// Token: 0x04008B5C RID: 35676
			[global::Cpp2ILInjected.Token(Token = "0x4007B13")]
			public static ItemSorting.ItemSortingLayer ToolsHamaxes;

			// Token: 0x04008B5D RID: 35677
			[global::Cpp2ILInjected.Token(Token = "0x4007B14")]
			public static ItemSorting.ItemSortingLayer ToolsPickaxes;

			// Token: 0x04008B5E RID: 35678
			[global::Cpp2ILInjected.Token(Token = "0x4007B15")]
			public static ItemSorting.ItemSortingLayer ToolsAxes;

			// Token: 0x04008B5F RID: 35679
			[global::Cpp2ILInjected.Token(Token = "0x4007B16")]
			public static ItemSorting.ItemSortingLayer ToolsHammers;

			// Token: 0x04008B60 RID: 35680
			[global::Cpp2ILInjected.Token(Token = "0x4007B17")]
			public static ItemSorting.ItemSortingLayer ToolsTerraforming;

			// Token: 0x04008B61 RID: 35681
			[global::Cpp2ILInjected.Token(Token = "0x4007B18")]
			public static ItemSorting.ItemSortingLayer ToolsAmmoLeftovers;

			// Token: 0x04008B62 RID: 35682
			[global::Cpp2ILInjected.Token(Token = "0x4007B19")]
			public static ItemSorting.ItemSortingLayer ArmorCombat;

			// Token: 0x04008B63 RID: 35683
			[global::Cpp2ILInjected.Token(Token = "0x4007B1A")]
			public static ItemSorting.ItemSortingLayer ArmorVanity;

			// Token: 0x04008B64 RID: 35684
			[global::Cpp2ILInjected.Token(Token = "0x4007B1B")]
			public static ItemSorting.ItemSortingLayer ArmorAccessories;

			// Token: 0x04008B65 RID: 35685
			[global::Cpp2ILInjected.Token(Token = "0x4007B1C")]
			public static ItemSorting.ItemSortingLayer EquipGrapple;

			// Token: 0x04008B66 RID: 35686
			[global::Cpp2ILInjected.Token(Token = "0x4007B1D")]
			public static ItemSorting.ItemSortingLayer EquipMount;

			// Token: 0x04008B67 RID: 35687
			[global::Cpp2ILInjected.Token(Token = "0x4007B1E")]
			public static ItemSorting.ItemSortingLayer EquipCart;

			// Token: 0x04008B68 RID: 35688
			[global::Cpp2ILInjected.Token(Token = "0x4007B1F")]
			public static ItemSorting.ItemSortingLayer EquipLightPet;

			// Token: 0x04008B69 RID: 35689
			[global::Cpp2ILInjected.Token(Token = "0x4007B20")]
			public static ItemSorting.ItemSortingLayer EquipVanityPet;

			// Token: 0x04008B6A RID: 35690
			[global::Cpp2ILInjected.Token(Token = "0x4007B21")]
			public static ItemSorting.ItemSortingLayer PotionsLife;

			// Token: 0x04008B6B RID: 35691
			[global::Cpp2ILInjected.Token(Token = "0x4007B22")]
			public static ItemSorting.ItemSortingLayer PotionsMana;

			// Token: 0x04008B6C RID: 35692
			[global::Cpp2ILInjected.Token(Token = "0x4007B23")]
			public static ItemSorting.ItemSortingLayer PotionsElixirs;

			// Token: 0x04008B6D RID: 35693
			[global::Cpp2ILInjected.Token(Token = "0x4007B24")]
			public static ItemSorting.ItemSortingLayer PotionsBuffs;

			// Token: 0x04008B6E RID: 35694
			[global::Cpp2ILInjected.Token(Token = "0x4007B25")]
			public static ItemSorting.ItemSortingLayer PotionsDyes;

			// Token: 0x04008B6F RID: 35695
			[global::Cpp2ILInjected.Token(Token = "0x4007B26")]
			public static ItemSorting.ItemSortingLayer PotionsHairDyes;

			// Token: 0x04008B70 RID: 35696
			[global::Cpp2ILInjected.Token(Token = "0x4007B27")]
			public static ItemSorting.ItemSortingLayer MiscValuables;

			// Token: 0x04008B71 RID: 35697
			[global::Cpp2ILInjected.Token(Token = "0x4007B28")]
			public static ItemSorting.ItemSortingLayer MiscWiring;

			// Token: 0x04008B72 RID: 35698
			[global::Cpp2ILInjected.Token(Token = "0x4007B29")]
			public static ItemSorting.ItemSortingLayer MiscMaterials;

			// Token: 0x04008B73 RID: 35699
			[global::Cpp2ILInjected.Token(Token = "0x4007B2A")]
			public static ItemSorting.ItemSortingLayer MiscExtractinator;

			// Token: 0x04008B74 RID: 35700
			[global::Cpp2ILInjected.Token(Token = "0x4007B2B")]
			public static ItemSorting.ItemSortingLayer MiscPainting;

			// Token: 0x04008B75 RID: 35701
			[global::Cpp2ILInjected.Token(Token = "0x4007B2C")]
			public static ItemSorting.ItemSortingLayer MiscRopes;

			// Token: 0x04008B76 RID: 35702
			[global::Cpp2ILInjected.Token(Token = "0x4007B2D")]
			public static ItemSorting.ItemSortingLayer LastMaterials;

			// Token: 0x04008B77 RID: 35703
			[global::Cpp2ILInjected.Token(Token = "0x4007B2E")]
			public static ItemSorting.ItemSortingLayer LastTilesImportant;

			// Token: 0x04008B78 RID: 35704
			[global::Cpp2ILInjected.Token(Token = "0x4007B2F")]
			public static ItemSorting.ItemSortingLayer LastTilesCommon;

			// Token: 0x04008B79 RID: 35705
			[global::Cpp2ILInjected.Token(Token = "0x4007B30")]
			public static ItemSorting.ItemSortingLayer LastNotTrash;

			// Token: 0x04008B7A RID: 35706
			[global::Cpp2ILInjected.Token(Token = "0x4007B31")]
			public static ItemSorting.ItemSortingLayer LastTrash;

			// Token: 0x02000B81 RID: 2945
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006E9")]
			private sealed class <>c__DisplayClass39_0
			{
				// Token: 0x0600537E RID: 21374 RVA: 0x00030B6C File Offset: 0x0002ED6C
				[global::Cpp2ILInjected.Token(Token = "0x6003B51")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482E50", Offset = "0x1482E50", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_0()
				{
					throw null;
				}

				// Token: 0x0600537F RID: 21375 RVA: 0x00030B6F File Offset: 0x0002ED6F
				[global::Cpp2ILInjected.Token(Token = "0x6003B52")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482E58", Offset = "0x1482E58", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__38(int i)
				{
					throw null;
				}

				// Token: 0x06005380 RID: 21376 RVA: 0x00030B72 File Offset: 0x0002ED72
				[global::Cpp2ILInjected.Token(Token = "0x6003B53")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482EBC", Offset = "0x1482EBC", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDamage", ReturnType = typeof(int))]
				internal int <.cctor>b__39(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090D9 RID: 37081
				[global::Cpp2ILInjected.Token(Token = "0x4007B32")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B82 RID: 2946
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EA")]
			private sealed class <>c__DisplayClass39_1
			{
				// Token: 0x06005381 RID: 21377 RVA: 0x00030B75 File Offset: 0x0002ED75
				[global::Cpp2ILInjected.Token(Token = "0x6003B54")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482F80", Offset = "0x1482F80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_1()
				{
					throw null;
				}

				// Token: 0x06005382 RID: 21378 RVA: 0x00030B78 File Offset: 0x0002ED78
				[global::Cpp2ILInjected.Token(Token = "0x6003B55")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482F88", Offset = "0x1482F88", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__40(int i)
				{
					throw null;
				}

				// Token: 0x06005383 RID: 21379 RVA: 0x00030B7B File Offset: 0x0002ED7B
				[global::Cpp2ILInjected.Token(Token = "0x6003B56")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482FCC", Offset = "0x1482FCC", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDamage", ReturnType = typeof(int))]
				internal int <.cctor>b__41(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090DA RID: 37082
				[global::Cpp2ILInjected.Token(Token = "0x4007B33")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B83 RID: 2947
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EB")]
			private sealed class <>c__DisplayClass39_2
			{
				// Token: 0x06005384 RID: 21380 RVA: 0x00030B7E File Offset: 0x0002ED7E
				[global::Cpp2ILInjected.Token(Token = "0x6003B57")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483090", Offset = "0x1483090", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_2()
				{
					throw null;
				}

				// Token: 0x06005385 RID: 21381 RVA: 0x00030B81 File Offset: 0x0002ED81
				[global::Cpp2ILInjected.Token(Token = "0x6003B58")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483098", Offset = "0x1483098", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__42(int i)
				{
					throw null;
				}

				// Token: 0x06005386 RID: 21382 RVA: 0x00030B84 File Offset: 0x0002ED84
				[global::Cpp2ILInjected.Token(Token = "0x6003B59")]
				[global::Cpp2ILInjected.Address(RVA = "0x14830DC", Offset = "0x14830DC", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDamage", ReturnType = typeof(int))]
				internal int <.cctor>b__43(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090DB RID: 37083
				[global::Cpp2ILInjected.Token(Token = "0x4007B34")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B84 RID: 2948
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EC")]
			private sealed class <>c__DisplayClass39_3
			{
				// Token: 0x06005387 RID: 21383 RVA: 0x00030B87 File Offset: 0x0002ED87
				[global::Cpp2ILInjected.Token(Token = "0x6003B5A")]
				[global::Cpp2ILInjected.Address(RVA = "0x14831A0", Offset = "0x14831A0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_3()
				{
					throw null;
				}

				// Token: 0x06005388 RID: 21384 RVA: 0x00030B8A File Offset: 0x0002ED8A
				[global::Cpp2ILInjected.Token(Token = "0x6003B5B")]
				[global::Cpp2ILInjected.Address(RVA = "0x14831A8", Offset = "0x14831A8", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__44(int i)
				{
					throw null;
				}

				// Token: 0x06005389 RID: 21385 RVA: 0x00030B8D File Offset: 0x0002ED8D
				[global::Cpp2ILInjected.Token(Token = "0x6003B5C")]
				[global::Cpp2ILInjected.Address(RVA = "0x14831E4", Offset = "0x14831E4", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDamage", ReturnType = typeof(int))]
				internal int <.cctor>b__45(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090DC RID: 37084
				[global::Cpp2ILInjected.Token(Token = "0x4007B35")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B85 RID: 2949
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006ED")]
			private sealed class <>c__DisplayClass39_4
			{
				// Token: 0x0600538A RID: 21386 RVA: 0x00030B90 File Offset: 0x0002ED90
				[global::Cpp2ILInjected.Token(Token = "0x6003B5D")]
				[global::Cpp2ILInjected.Address(RVA = "0x14832A8", Offset = "0x14832A8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_4()
				{
					throw null;
				}

				// Token: 0x0600538B RID: 21387 RVA: 0x00030B93 File Offset: 0x0002ED93
				[global::Cpp2ILInjected.Token(Token = "0x6003B5E")]
				[global::Cpp2ILInjected.Address(RVA = "0x14832B0", Offset = "0x14832B0", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__46(int i)
				{
					throw null;
				}

				// Token: 0x0600538C RID: 21388 RVA: 0x00030B96 File Offset: 0x0002ED96
				[global::Cpp2ILInjected.Token(Token = "0x6003B5F")]
				[global::Cpp2ILInjected.Address(RVA = "0x14832F8", Offset = "0x14832F8", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDamage", ReturnType = typeof(int))]
				internal int <.cctor>b__47(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090DD RID: 37085
				[global::Cpp2ILInjected.Token(Token = "0x4007B36")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B86 RID: 2950
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EE")]
			private sealed class <>c__DisplayClass39_5
			{
				// Token: 0x0600538D RID: 21389 RVA: 0x00030B99 File Offset: 0x0002ED99
				[global::Cpp2ILInjected.Token(Token = "0x6003B60")]
				[global::Cpp2ILInjected.Address(RVA = "0x14833BC", Offset = "0x14833BC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_5()
				{
					throw null;
				}

				// Token: 0x0600538E RID: 21390 RVA: 0x00030B9C File Offset: 0x0002ED9C
				[global::Cpp2ILInjected.Token(Token = "0x6003B61")]
				[global::Cpp2ILInjected.Address(RVA = "0x14833C4", Offset = "0x14833C4", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__48(int i)
				{
					throw null;
				}

				// Token: 0x0600538F RID: 21391 RVA: 0x00030B9F File Offset: 0x0002ED9F
				[global::Cpp2ILInjected.Token(Token = "0x6003B62")]
				[global::Cpp2ILInjected.Address(RVA = "0x14833F4", Offset = "0x14833F4", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDamage", ReturnType = typeof(int))]
				internal int <.cctor>b__49(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090DE RID: 37086
				[global::Cpp2ILInjected.Token(Token = "0x4007B37")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B87 RID: 2951
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EF")]
			private sealed class <>c__DisplayClass39_6
			{
				// Token: 0x06005390 RID: 21392 RVA: 0x00030BA2 File Offset: 0x0002EDA2
				[global::Cpp2ILInjected.Token(Token = "0x6003B63")]
				[global::Cpp2ILInjected.Address(RVA = "0x14834B8", Offset = "0x14834B8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_6()
				{
					throw null;
				}

				// Token: 0x06005391 RID: 21393 RVA: 0x00030BA5 File Offset: 0x0002EDA5
				[global::Cpp2ILInjected.Token(Token = "0x6003B64")]
				[global::Cpp2ILInjected.Address(RVA = "0x14834C0", Offset = "0x14834C0", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__50(int i)
				{
					throw null;
				}

				// Token: 0x06005392 RID: 21394 RVA: 0x00030BA8 File Offset: 0x0002EDA8
				[global::Cpp2ILInjected.Token(Token = "0x6003B65")]
				[global::Cpp2ILInjected.Address(RVA = "0x14834F0", Offset = "0x14834F0", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__51(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090DF RID: 37087
				[global::Cpp2ILInjected.Token(Token = "0x4007B38")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B88 RID: 2952
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F0")]
			private sealed class <>c__DisplayClass39_7
			{
				// Token: 0x06005393 RID: 21395 RVA: 0x00030BAB File Offset: 0x0002EDAB
				[global::Cpp2ILInjected.Token(Token = "0x6003B66")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483510", Offset = "0x1483510", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_7()
				{
					throw null;
				}

				// Token: 0x06005394 RID: 21396 RVA: 0x00030BAE File Offset: 0x0002EDAE
				[global::Cpp2ILInjected.Token(Token = "0x6003B67")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483518", Offset = "0x1483518", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__52(int i)
				{
					throw null;
				}

				// Token: 0x06005395 RID: 21397 RVA: 0x00030BB1 File Offset: 0x0002EDB1
				[global::Cpp2ILInjected.Token(Token = "0x6003B68")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483548", Offset = "0x1483548", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__53(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E0 RID: 37088
				[global::Cpp2ILInjected.Token(Token = "0x4007B39")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B89 RID: 2953
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F1")]
			private sealed class <>c__DisplayClass39_8
			{
				// Token: 0x06005396 RID: 21398 RVA: 0x00030BB4 File Offset: 0x0002EDB4
				[global::Cpp2ILInjected.Token(Token = "0x6003B69")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483568", Offset = "0x1483568", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_8()
				{
					throw null;
				}

				// Token: 0x06005397 RID: 21399 RVA: 0x00030BB7 File Offset: 0x0002EDB7
				[global::Cpp2ILInjected.Token(Token = "0x6003B6A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483570", Offset = "0x1483570", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__54(int i)
				{
					throw null;
				}

				// Token: 0x06005398 RID: 21400 RVA: 0x00030BBA File Offset: 0x0002EDBA
				[global::Cpp2ILInjected.Token(Token = "0x6003B6B")]
				[global::Cpp2ILInjected.Address(RVA = "0x148358C", Offset = "0x148358C", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__55(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E1 RID: 37089
				[global::Cpp2ILInjected.Token(Token = "0x4007B3A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B8A RID: 2954
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F2")]
			private sealed class <>c__DisplayClass39_9
			{
				// Token: 0x06005399 RID: 21401 RVA: 0x00030BBD File Offset: 0x0002EDBD
				[global::Cpp2ILInjected.Token(Token = "0x6003B6C")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835AC", Offset = "0x14835AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_9()
				{
					throw null;
				}

				// Token: 0x0600539A RID: 21402 RVA: 0x00030BC0 File Offset: 0x0002EDC0
				[global::Cpp2ILInjected.Token(Token = "0x6003B6D")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835B4", Offset = "0x14835B4", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__56(int i)
				{
					throw null;
				}

				// Token: 0x0600539B RID: 21403 RVA: 0x00030BC3 File Offset: 0x0002EDC3
				[global::Cpp2ILInjected.Token(Token = "0x6003B6E")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835D0", Offset = "0x14835D0", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__57(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E2 RID: 37090
				[global::Cpp2ILInjected.Token(Token = "0x4007B3B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B8B RID: 2955
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F3")]
			private sealed class <>c__DisplayClass39_10
			{
				// Token: 0x0600539C RID: 21404 RVA: 0x00030BC6 File Offset: 0x0002EDC6
				[global::Cpp2ILInjected.Token(Token = "0x6003B6F")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835F0", Offset = "0x14835F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_10()
				{
					throw null;
				}

				// Token: 0x0600539D RID: 21405 RVA: 0x00030BC9 File Offset: 0x0002EDC9
				[global::Cpp2ILInjected.Token(Token = "0x6003B70")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835F8", Offset = "0x14835F8", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__58(int i)
				{
					throw null;
				}

				// Token: 0x0600539E RID: 21406 RVA: 0x00030BCC File Offset: 0x0002EDCC
				[global::Cpp2ILInjected.Token(Token = "0x6003B71")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483614", Offset = "0x1483614", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__59(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E3 RID: 37091
				[global::Cpp2ILInjected.Token(Token = "0x4007B3C")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B8C RID: 2956
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F4")]
			private sealed class <>c__DisplayClass39_11
			{
				// Token: 0x0600539F RID: 21407 RVA: 0x00030BCF File Offset: 0x0002EDCF
				[global::Cpp2ILInjected.Token(Token = "0x6003B72")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483634", Offset = "0x1483634", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_11()
				{
					throw null;
				}

				// Token: 0x060053A0 RID: 21408 RVA: 0x00030BD2 File Offset: 0x0002EDD2
				[global::Cpp2ILInjected.Token(Token = "0x6003B73")]
				[global::Cpp2ILInjected.Address(RVA = "0x148363C", Offset = "0x148363C", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__60(int i)
				{
					throw null;
				}

				// Token: 0x060053A1 RID: 21409 RVA: 0x00030BD5 File Offset: 0x0002EDD5
				[global::Cpp2ILInjected.Token(Token = "0x6003B74")]
				[global::Cpp2ILInjected.Address(RVA = "0x14836E0", Offset = "0x14836E0", Length = "0xE4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal int <.cctor>b__61(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E4 RID: 37092
				[global::Cpp2ILInjected.Token(Token = "0x4007B3D")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B8D RID: 2957
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F5")]
			private sealed class <>c__DisplayClass39_12
			{
				// Token: 0x060053A2 RID: 21410 RVA: 0x00030BD8 File Offset: 0x0002EDD8
				[global::Cpp2ILInjected.Token(Token = "0x6003B75")]
				[global::Cpp2ILInjected.Address(RVA = "0x14837C4", Offset = "0x14837C4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_12()
				{
					throw null;
				}

				// Token: 0x060053A3 RID: 21411 RVA: 0x00030BDB File Offset: 0x0002EDDB
				[global::Cpp2ILInjected.Token(Token = "0x6003B76")]
				[global::Cpp2ILInjected.Address(RVA = "0x14837CC", Offset = "0x14837CC", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__62(int i)
				{
					throw null;
				}

				// Token: 0x060053A4 RID: 21412 RVA: 0x00030BDE File Offset: 0x0002EDDE
				[global::Cpp2ILInjected.Token(Token = "0x6003B77")]
				[global::Cpp2ILInjected.Address(RVA = "0x14837E8", Offset = "0x14837E8", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDamage", ReturnType = typeof(int))]
				internal int <.cctor>b__63(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E5 RID: 37093
				[global::Cpp2ILInjected.Token(Token = "0x4007B3E")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B8E RID: 2958
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F6")]
			private sealed class <>c__DisplayClass39_13
			{
				// Token: 0x060053A5 RID: 21413 RVA: 0x00030BE1 File Offset: 0x0002EDE1
				[global::Cpp2ILInjected.Token(Token = "0x6003B78")]
				[global::Cpp2ILInjected.Address(RVA = "0x14838AC", Offset = "0x14838AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_13()
				{
					throw null;
				}

				// Token: 0x060053A6 RID: 21414 RVA: 0x00030BE4 File Offset: 0x0002EDE4
				[global::Cpp2ILInjected.Token(Token = "0x6003B79")]
				[global::Cpp2ILInjected.Address(RVA = "0x14838B4", Offset = "0x14838B4", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__64(int i)
				{
					throw null;
				}

				// Token: 0x060053A7 RID: 21415 RVA: 0x00030BE7 File Offset: 0x0002EDE7
				[global::Cpp2ILInjected.Token(Token = "0x6003B7A")]
				[global::Cpp2ILInjected.Address(RVA = "0x14838F0", Offset = "0x14838F0", Length = "0xD0")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDefense", ReturnType = typeof(int))]
				internal int <.cctor>b__65(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E6 RID: 37094
				[global::Cpp2ILInjected.Token(Token = "0x4007B3F")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B8F RID: 2959
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F7")]
			private sealed class <>c__DisplayClass39_14
			{
				// Token: 0x060053A8 RID: 21416 RVA: 0x00030BEA File Offset: 0x0002EDEA
				[global::Cpp2ILInjected.Token(Token = "0x6003B7B")]
				[global::Cpp2ILInjected.Address(RVA = "0x14839C0", Offset = "0x14839C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_14()
				{
					throw null;
				}

				// Token: 0x060053A9 RID: 21417 RVA: 0x00030BED File Offset: 0x0002EDED
				[global::Cpp2ILInjected.Token(Token = "0x6003B7C")]
				[global::Cpp2ILInjected.Address(RVA = "0x14839C8", Offset = "0x14839C8", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__66(int i)
				{
					throw null;
				}

				// Token: 0x060053AA RID: 21418 RVA: 0x00030BF0 File Offset: 0x0002EDF0
				[global::Cpp2ILInjected.Token(Token = "0x6003B7D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483A04", Offset = "0x1483A04", Length = "0x90")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__67(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E7 RID: 37095
				[global::Cpp2ILInjected.Token(Token = "0x4007B40")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B90 RID: 2960
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F8")]
			private sealed class <>c__DisplayClass39_15
			{
				// Token: 0x060053AB RID: 21419 RVA: 0x00030BF3 File Offset: 0x0002EDF3
				[global::Cpp2ILInjected.Token(Token = "0x6003B7E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483A94", Offset = "0x1483A94", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_15()
				{
					throw null;
				}

				// Token: 0x060053AC RID: 21420 RVA: 0x00030BF6 File Offset: 0x0002EDF6
				[global::Cpp2ILInjected.Token(Token = "0x6003B7F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483A9C", Offset = "0x1483A9C", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__68(int i)
				{
					throw null;
				}

				// Token: 0x060053AD RID: 21421 RVA: 0x00030BF9 File Offset: 0x0002EDF9
				[global::Cpp2ILInjected.Token(Token = "0x6003B80")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483AB0", Offset = "0x1483AB0", Length = "0xF8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "CompareTo", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalDefense", ReturnType = typeof(int))]
				internal int <.cctor>b__69(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E8 RID: 37096
				[global::Cpp2ILInjected.Token(Token = "0x4007B41")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B91 RID: 2961
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F9")]
			private sealed class <>c__DisplayClass39_16
			{
				// Token: 0x060053AE RID: 21422 RVA: 0x00030BFC File Offset: 0x0002EDFC
				[global::Cpp2ILInjected.Token(Token = "0x6003B81")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483BA8", Offset = "0x1483BA8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_16()
				{
					throw null;
				}

				// Token: 0x060053AF RID: 21423 RVA: 0x00030BFF File Offset: 0x0002EDFF
				[global::Cpp2ILInjected.Token(Token = "0x6003B82")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483BB0", Offset = "0x1483BB0", Length = "0x80")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__70(int i)
				{
					throw null;
				}

				// Token: 0x060053B0 RID: 21424 RVA: 0x00030C02 File Offset: 0x0002EE02
				[global::Cpp2ILInjected.Token(Token = "0x6003B83")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483C30", Offset = "0x1483C30", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__71(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090E9 RID: 37097
				[global::Cpp2ILInjected.Token(Token = "0x4007B42")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B92 RID: 2962
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FA")]
			private sealed class <>c__DisplayClass39_17
			{
				// Token: 0x060053B1 RID: 21425 RVA: 0x00030C05 File Offset: 0x0002EE05
				[global::Cpp2ILInjected.Token(Token = "0x6003B84")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483CD8", Offset = "0x1483CD8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_17()
				{
					throw null;
				}

				// Token: 0x060053B2 RID: 21426 RVA: 0x00030C08 File Offset: 0x0002EE08
				[global::Cpp2ILInjected.Token(Token = "0x6003B85")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483CE0", Offset = "0x1483CE0", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__72(int i)
				{
					throw null;
				}

				// Token: 0x060053B3 RID: 21427 RVA: 0x00030C0B File Offset: 0x0002EE0B
				[global::Cpp2ILInjected.Token(Token = "0x6003B86")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483D84", Offset = "0x1483D84", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__73(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090EA RID: 37098
				[global::Cpp2ILInjected.Token(Token = "0x4007B43")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B93 RID: 2963
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FB")]
			private sealed class <>c__DisplayClass39_18
			{
				// Token: 0x060053B4 RID: 21428 RVA: 0x00030C0E File Offset: 0x0002EE0E
				[global::Cpp2ILInjected.Token(Token = "0x6003B87")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483E2C", Offset = "0x1483E2C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_18()
				{
					throw null;
				}

				// Token: 0x060053B5 RID: 21429 RVA: 0x00030C11 File Offset: 0x0002EE11
				[global::Cpp2ILInjected.Token(Token = "0x6003B88")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483E34", Offset = "0x1483E34", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__74(int i)
				{
					throw null;
				}

				// Token: 0x060053B6 RID: 21430 RVA: 0x00030C14 File Offset: 0x0002EE14
				[global::Cpp2ILInjected.Token(Token = "0x6003B89")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483ED8", Offset = "0x1483ED8", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__75(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090EB RID: 37099
				[global::Cpp2ILInjected.Token(Token = "0x4007B44")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B94 RID: 2964
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FC")]
			private sealed class <>c__DisplayClass39_19
			{
				// Token: 0x060053B7 RID: 21431 RVA: 0x00030C17 File Offset: 0x0002EE17
				[global::Cpp2ILInjected.Token(Token = "0x6003B8A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483F80", Offset = "0x1483F80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_19()
				{
					throw null;
				}

				// Token: 0x060053B8 RID: 21432 RVA: 0x00030C1A File Offset: 0x0002EE1A
				[global::Cpp2ILInjected.Token(Token = "0x6003B8B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483F88", Offset = "0x1483F88", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__76(int i)
				{
					throw null;
				}

				// Token: 0x060053B9 RID: 21433 RVA: 0x00030C1D File Offset: 0x0002EE1D
				[global::Cpp2ILInjected.Token(Token = "0x6003B8C")]
				[global::Cpp2ILInjected.Address(RVA = "0x148402C", Offset = "0x148402C", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__77(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090EC RID: 37100
				[global::Cpp2ILInjected.Token(Token = "0x4007B45")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B95 RID: 2965
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FD")]
			private sealed class <>c__DisplayClass39_20
			{
				// Token: 0x060053BA RID: 21434 RVA: 0x00030C20 File Offset: 0x0002EE20
				[global::Cpp2ILInjected.Token(Token = "0x6003B8D")]
				[global::Cpp2ILInjected.Address(RVA = "0x14840D4", Offset = "0x14840D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_20()
				{
					throw null;
				}

				// Token: 0x060053BB RID: 21435 RVA: 0x00030C23 File Offset: 0x0002EE23
				[global::Cpp2ILInjected.Token(Token = "0x6003B8E")]
				[global::Cpp2ILInjected.Address(RVA = "0x14840DC", Offset = "0x14840DC", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__78(int i)
				{
					throw null;
				}

				// Token: 0x060053BC RID: 21436 RVA: 0x00030C26 File Offset: 0x0002EE26
				[global::Cpp2ILInjected.Token(Token = "0x6003B8F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484180", Offset = "0x1484180", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__79(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090ED RID: 37101
				[global::Cpp2ILInjected.Token(Token = "0x4007B46")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B96 RID: 2966
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FE")]
			private sealed class <>c__DisplayClass39_21
			{
				// Token: 0x060053BD RID: 21437 RVA: 0x00030C29 File Offset: 0x0002EE29
				[global::Cpp2ILInjected.Token(Token = "0x6003B90")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484228", Offset = "0x1484228", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_21()
				{
					throw null;
				}

				// Token: 0x060053BE RID: 21438 RVA: 0x00030C2C File Offset: 0x0002EE2C
				[global::Cpp2ILInjected.Token(Token = "0x6003B91")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484230", Offset = "0x1484230", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__80(int i)
				{
					throw null;
				}

				// Token: 0x060053BF RID: 21439 RVA: 0x00030C2F File Offset: 0x0002EE2F
				[global::Cpp2ILInjected.Token(Token = "0x6003B92")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484268", Offset = "0x1484268", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__81(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090EE RID: 37102
				[global::Cpp2ILInjected.Token(Token = "0x4007B47")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B97 RID: 2967
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FF")]
			private sealed class <>c__DisplayClass39_22
			{
				// Token: 0x060053C0 RID: 21440 RVA: 0x00030C32 File Offset: 0x0002EE32
				[global::Cpp2ILInjected.Token(Token = "0x6003B93")]
				[global::Cpp2ILInjected.Address(RVA = "0x14842F4", Offset = "0x14842F4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_22()
				{
					throw null;
				}

				// Token: 0x060053C1 RID: 21441 RVA: 0x00030C35 File Offset: 0x0002EE35
				[global::Cpp2ILInjected.Token(Token = "0x6003B94")]
				[global::Cpp2ILInjected.Address(RVA = "0x14842FC", Offset = "0x14842FC", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__82(int i)
				{
					throw null;
				}

				// Token: 0x060053C2 RID: 21442 RVA: 0x00030C38 File Offset: 0x0002EE38
				[global::Cpp2ILInjected.Token(Token = "0x6003B95")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484334", Offset = "0x1484334", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__83(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090EF RID: 37103
				[global::Cpp2ILInjected.Token(Token = "0x4007B48")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B98 RID: 2968
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000700")]
			private sealed class <>c__DisplayClass39_23
			{
				// Token: 0x060053C3 RID: 21443 RVA: 0x00030C3B File Offset: 0x0002EE3B
				[global::Cpp2ILInjected.Token(Token = "0x6003B96")]
				[global::Cpp2ILInjected.Address(RVA = "0x14843C0", Offset = "0x14843C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_23()
				{
					throw null;
				}

				// Token: 0x060053C4 RID: 21444 RVA: 0x00030C3E File Offset: 0x0002EE3E
				[global::Cpp2ILInjected.Token(Token = "0x6003B97")]
				[global::Cpp2ILInjected.Address(RVA = "0x14843C8", Offset = "0x14843C8", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__84(int i)
				{
					throw null;
				}

				// Token: 0x060053C5 RID: 21445 RVA: 0x00030C41 File Offset: 0x0002EE41
				[global::Cpp2ILInjected.Token(Token = "0x6003B98")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484400", Offset = "0x1484400", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__85(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F0 RID: 37104
				[global::Cpp2ILInjected.Token(Token = "0x4007B49")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B99 RID: 2969
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000701")]
			private sealed class <>c__DisplayClass39_24
			{
				// Token: 0x060053C6 RID: 21446 RVA: 0x00030C44 File Offset: 0x0002EE44
				[global::Cpp2ILInjected.Token(Token = "0x6003B99")]
				[global::Cpp2ILInjected.Address(RVA = "0x148448C", Offset = "0x148448C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_24()
				{
					throw null;
				}

				// Token: 0x060053C7 RID: 21447 RVA: 0x00030C47 File Offset: 0x0002EE47
				[global::Cpp2ILInjected.Token(Token = "0x6003B9A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484494", Offset = "0x1484494", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__86(int i)
				{
					throw null;
				}

				// Token: 0x060053C8 RID: 21448 RVA: 0x00030C4A File Offset: 0x0002EE4A
				[global::Cpp2ILInjected.Token(Token = "0x6003B9B")]
				[global::Cpp2ILInjected.Address(RVA = "0x14844C0", Offset = "0x14844C0", Length = "0xCC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__87(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F1 RID: 37105
				[global::Cpp2ILInjected.Token(Token = "0x4007B4A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B9A RID: 2970
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000702")]
			private sealed class <>c__DisplayClass39_25
			{
				// Token: 0x060053C9 RID: 21449 RVA: 0x00030C4D File Offset: 0x0002EE4D
				[global::Cpp2ILInjected.Token(Token = "0x6003B9C")]
				[global::Cpp2ILInjected.Address(RVA = "0x148458C", Offset = "0x148458C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_25()
				{
					throw null;
				}

				// Token: 0x060053CA RID: 21450 RVA: 0x00030C50 File Offset: 0x0002EE50
				[global::Cpp2ILInjected.Token(Token = "0x6003B9D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484594", Offset = "0x1484594", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__88(int i)
				{
					throw null;
				}

				// Token: 0x060053CB RID: 21451 RVA: 0x00030C53 File Offset: 0x0002EE53
				[global::Cpp2ILInjected.Token(Token = "0x6003B9E")]
				[global::Cpp2ILInjected.Address(RVA = "0x14845B0", Offset = "0x14845B0", Length = "0xCC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "CompareTo", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(int))]
				internal int <.cctor>b__89(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F2 RID: 37106
				[global::Cpp2ILInjected.Token(Token = "0x4007B4B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B9B RID: 2971
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000703")]
			private sealed class <>c__DisplayClass39_26
			{
				// Token: 0x060053CC RID: 21452 RVA: 0x00030C56 File Offset: 0x0002EE56
				[global::Cpp2ILInjected.Token(Token = "0x6003B9F")]
				[global::Cpp2ILInjected.Address(RVA = "0x148467C", Offset = "0x148467C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_26()
				{
					throw null;
				}

				// Token: 0x060053CD RID: 21453 RVA: 0x00030C59 File Offset: 0x0002EE59
				[global::Cpp2ILInjected.Token(Token = "0x6003BA0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484684", Offset = "0x1484684", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__90(int i)
				{
					throw null;
				}

				// Token: 0x060053CE RID: 21454 RVA: 0x00030C5C File Offset: 0x0002EE5C
				[global::Cpp2ILInjected.Token(Token = "0x6003BA1")]
				[global::Cpp2ILInjected.Address(RVA = "0x14846A0", Offset = "0x14846A0", Length = "0xCC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "CompareTo", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(int))]
				internal int <.cctor>b__91(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F3 RID: 37107
				[global::Cpp2ILInjected.Token(Token = "0x4007B4C")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B9C RID: 2972
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000704")]
			private sealed class <>c__DisplayClass39_27
			{
				// Token: 0x060053CF RID: 21455 RVA: 0x00030C5F File Offset: 0x0002EE5F
				[global::Cpp2ILInjected.Token(Token = "0x6003BA2")]
				[global::Cpp2ILInjected.Address(RVA = "0x148476C", Offset = "0x148476C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_27()
				{
					throw null;
				}

				// Token: 0x060053D0 RID: 21456 RVA: 0x00030C62 File Offset: 0x0002EE62
				[global::Cpp2ILInjected.Token(Token = "0x6003BA3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484774", Offset = "0x1484774", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__92(int i)
				{
					throw null;
				}

				// Token: 0x060053D1 RID: 21457 RVA: 0x00030C65 File Offset: 0x0002EE65
				[global::Cpp2ILInjected.Token(Token = "0x6003BA4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484818", Offset = "0x1484818", Length = "0xE4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal int <.cctor>b__93(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F4 RID: 37108
				[global::Cpp2ILInjected.Token(Token = "0x4007B4D")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B9D RID: 2973
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000705")]
			private sealed class <>c__DisplayClass39_28
			{
				// Token: 0x060053D2 RID: 21458 RVA: 0x00030C68 File Offset: 0x0002EE68
				[global::Cpp2ILInjected.Token(Token = "0x6003BA5")]
				[global::Cpp2ILInjected.Address(RVA = "0x14848FC", Offset = "0x14848FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_28()
				{
					throw null;
				}

				// Token: 0x060053D3 RID: 21459 RVA: 0x00030C6B File Offset: 0x0002EE6B
				[global::Cpp2ILInjected.Token(Token = "0x6003BA6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484904", Offset = "0x1484904", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__94(int i)
				{
					throw null;
				}

				// Token: 0x060053D4 RID: 21460 RVA: 0x00030C6E File Offset: 0x0002EE6E
				[global::Cpp2ILInjected.Token(Token = "0x6003BA7")]
				[global::Cpp2ILInjected.Address(RVA = "0x14849B0", Offset = "0x14849B0", Length = "0x14C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal int <.cctor>b__95(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F5 RID: 37109
				[global::Cpp2ILInjected.Token(Token = "0x4007B4E")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B9E RID: 2974
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000706")]
			private sealed class <>c__DisplayClass39_29
			{
				// Token: 0x060053D5 RID: 21461 RVA: 0x00030C71 File Offset: 0x0002EE71
				[global::Cpp2ILInjected.Token(Token = "0x6003BA8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484AFC", Offset = "0x1484AFC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_29()
				{
					throw null;
				}

				// Token: 0x060053D6 RID: 21462 RVA: 0x00030C74 File Offset: 0x0002EE74
				[global::Cpp2ILInjected.Token(Token = "0x6003BA9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484B04", Offset = "0x1484B04", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__96(int i)
				{
					throw null;
				}

				// Token: 0x060053D7 RID: 21463 RVA: 0x00030C77 File Offset: 0x0002EE77
				[global::Cpp2ILInjected.Token(Token = "0x6003BAA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484BA8", Offset = "0x1484BA8", Length = "0xE4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal int <.cctor>b__97(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F6 RID: 37110
				[global::Cpp2ILInjected.Token(Token = "0x4007B4F")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000B9F RID: 2975
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000707")]
			private sealed class <>c__DisplayClass39_30
			{
				// Token: 0x060053D8 RID: 21464 RVA: 0x00030C7A File Offset: 0x0002EE7A
				[global::Cpp2ILInjected.Token(Token = "0x6003BAB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484C8C", Offset = "0x1484C8C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_30()
				{
					throw null;
				}

				// Token: 0x060053D9 RID: 21465 RVA: 0x00030C7D File Offset: 0x0002EE7D
				[global::Cpp2ILInjected.Token(Token = "0x6003BAC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484C94", Offset = "0x1484C94", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__98(int i)
				{
					throw null;
				}

				// Token: 0x060053DA RID: 21466 RVA: 0x00030C80 File Offset: 0x0002EE80
				[global::Cpp2ILInjected.Token(Token = "0x6003BAD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484D38", Offset = "0x1484D38", Length = "0xE4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal int <.cctor>b__99(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F7 RID: 37111
				[global::Cpp2ILInjected.Token(Token = "0x4007B50")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000BA0 RID: 2976
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000708")]
			private sealed class <>c__DisplayClass39_31
			{
				// Token: 0x060053DB RID: 21467 RVA: 0x00030C83 File Offset: 0x0002EE83
				[global::Cpp2ILInjected.Token(Token = "0x6003BAE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484E1C", Offset = "0x1484E1C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_31()
				{
					throw null;
				}

				// Token: 0x060053DC RID: 21468 RVA: 0x00030C86 File Offset: 0x0002EE86
				[global::Cpp2ILInjected.Token(Token = "0x6003BAF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484E24", Offset = "0x1484E24", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__100(int i)
				{
					throw null;
				}

				// Token: 0x060053DD RID: 21469 RVA: 0x00030C89 File Offset: 0x0002EE89
				[global::Cpp2ILInjected.Token(Token = "0x6003BB0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484ED0", Offset = "0x1484ED0", Length = "0x12C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "CompareTo", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal int <.cctor>b__101(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F8 RID: 37112
				[global::Cpp2ILInjected.Token(Token = "0x4007B51")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000BA1 RID: 2977
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000709")]
			private sealed class <>c__DisplayClass39_32
			{
				// Token: 0x060053DE RID: 21470 RVA: 0x00030C8C File Offset: 0x0002EE8C
				[global::Cpp2ILInjected.Token(Token = "0x6003BB1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484FFC", Offset = "0x1484FFC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_32()
				{
					throw null;
				}

				// Token: 0x060053DF RID: 21471 RVA: 0x00030C8F File Offset: 0x0002EE8F
				[global::Cpp2ILInjected.Token(Token = "0x6003BB2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485004", Offset = "0x1485004", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__102(int i)
				{
					throw null;
				}

				// Token: 0x060053E0 RID: 21472 RVA: 0x00030C92 File Offset: 0x0002EE92
				[global::Cpp2ILInjected.Token(Token = "0x6003BB3")]
				[global::Cpp2ILInjected.Address(RVA = "0x14850A8", Offset = "0x14850A8", Length = "0xE4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal int <.cctor>b__103(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090F9 RID: 37113
				[global::Cpp2ILInjected.Token(Token = "0x4007B52")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000BA2 RID: 2978
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070A")]
			private sealed class <>c__DisplayClass39_33
			{
				// Token: 0x060053E1 RID: 21473 RVA: 0x00030C95 File Offset: 0x0002EE95
				[global::Cpp2ILInjected.Token(Token = "0x6003BB4")]
				[global::Cpp2ILInjected.Address(RVA = "0x148518C", Offset = "0x148518C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_33()
				{
					throw null;
				}

				// Token: 0x060053E2 RID: 21474 RVA: 0x00030C98 File Offset: 0x0002EE98
				[global::Cpp2ILInjected.Token(Token = "0x6003BB5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485194", Offset = "0x1485194", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__104(int i)
				{
					throw null;
				}

				// Token: 0x060053E3 RID: 21475 RVA: 0x00030C9B File Offset: 0x0002EE9B
				[global::Cpp2ILInjected.Token(Token = "0x6003BB6")]
				[global::Cpp2ILInjected.Address(RVA = "0x14851C0", Offset = "0x14851C0", Length = "0xCC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__105(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090FA RID: 37114
				[global::Cpp2ILInjected.Token(Token = "0x4007B53")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000BA3 RID: 2979
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070B")]
			private sealed class <>c__DisplayClass39_34
			{
				// Token: 0x060053E4 RID: 21476 RVA: 0x00030C9E File Offset: 0x0002EE9E
				[global::Cpp2ILInjected.Token(Token = "0x6003BB7")]
				[global::Cpp2ILInjected.Address(RVA = "0x148528C", Offset = "0x148528C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_34()
				{
					throw null;
				}

				// Token: 0x060053E5 RID: 21477 RVA: 0x00030CA1 File Offset: 0x0002EEA1
				[global::Cpp2ILInjected.Token(Token = "0x6003BB8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485294", Offset = "0x1485294", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__106(int i)
				{
					throw null;
				}

				// Token: 0x060053E6 RID: 21478 RVA: 0x00030CA4 File Offset: 0x0002EEA4
				[global::Cpp2ILInjected.Token(Token = "0x6003BB9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485334", Offset = "0x1485334", Length = "0xB0")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
				{
					typeof(string),
					typeof(string),
					typeof(StringComparison)
				}, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__107(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090FB RID: 37115
				[global::Cpp2ILInjected.Token(Token = "0x4007B54")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000BA4 RID: 2980
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070C")]
			private sealed class <>c__DisplayClass39_35
			{
				// Token: 0x060053E7 RID: 21479 RVA: 0x00030CA7 File Offset: 0x0002EEA7
				[global::Cpp2ILInjected.Token(Token = "0x6003BBA")]
				[global::Cpp2ILInjected.Address(RVA = "0x14853E4", Offset = "0x14853E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_35()
				{
					throw null;
				}

				// Token: 0x060053E8 RID: 21480 RVA: 0x00030CAA File Offset: 0x0002EEAA
				[global::Cpp2ILInjected.Token(Token = "0x6003BBB")]
				[global::Cpp2ILInjected.Address(RVA = "0x14853EC", Offset = "0x14853EC", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__108(int i)
				{
					throw null;
				}

				// Token: 0x060053E9 RID: 21481 RVA: 0x00030CAD File Offset: 0x0002EEAD
				[global::Cpp2ILInjected.Token(Token = "0x6003BBC")]
				[global::Cpp2ILInjected.Address(RVA = "0x148541C", Offset = "0x148541C", Length = "0xB0")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
				{
					typeof(string),
					typeof(string),
					typeof(StringComparison)
				}, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__109(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090FC RID: 37116
				[global::Cpp2ILInjected.Token(Token = "0x4007B55")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000BA5 RID: 2981
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070D")]
			private sealed class <>c__DisplayClass39_36
			{
				// Token: 0x060053EA RID: 21482 RVA: 0x00030CB0 File Offset: 0x0002EEB0
				[global::Cpp2ILInjected.Token(Token = "0x6003BBD")]
				[global::Cpp2ILInjected.Address(RVA = "0x14854CC", Offset = "0x14854CC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_36()
				{
					throw null;
				}

				// Token: 0x060053EB RID: 21483 RVA: 0x00030CB3 File Offset: 0x0002EEB3
				[global::Cpp2ILInjected.Token(Token = "0x6003BBE")]
				[global::Cpp2ILInjected.Address(RVA = "0x14854D4", Offset = "0x14854D4", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				internal bool <.cctor>b__110(int i)
				{
					throw null;
				}

				// Token: 0x060053EC RID: 21484 RVA: 0x00030CB6 File Offset: 0x0002EEB6
				[global::Cpp2ILInjected.Token(Token = "0x6003BBF")]
				[global::Cpp2ILInjected.Address(RVA = "0x14854FC", Offset = "0x14854FC", Length = "0xF8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
				{
					typeof(string),
					typeof(string),
					typeof(StringComparison)
				}, ReturnType = typeof(int))]
				internal int <.cctor>b__111(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090FD RID: 37117
				[global::Cpp2ILInjected.Token(Token = "0x4007B56")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000BA6 RID: 2982
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070E")]
			private sealed class <>c__DisplayClass39_37
			{
				// Token: 0x060053ED RID: 21485 RVA: 0x00030CB9 File Offset: 0x0002EEB9
				[global::Cpp2ILInjected.Token(Token = "0x6003BC0")]
				[global::Cpp2ILInjected.Address(RVA = "0x14855F4", Offset = "0x14855F4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_37()
				{
					throw null;
				}

				// Token: 0x060053EE RID: 21486 RVA: 0x00030CBC File Offset: 0x0002EEBC
				[global::Cpp2ILInjected.Token(Token = "0x6003BC1")]
				[global::Cpp2ILInjected.Address(RVA = "0x14855FC", Offset = "0x14855FC", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__112(int x, int y)
				{
					throw null;
				}

				// Token: 0x040090FE RID: 37118
				[global::Cpp2ILInjected.Token(Token = "0x4007B57")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			// Token: 0x02000BA7 RID: 2983
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070F")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060053EF RID: 21487 RVA: 0x00030CBF File Offset: 0x0002EEBF
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6003BC2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485688", Offset = "0x1485688", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x060053F0 RID: 21488 RVA: 0x00030CC2 File Offset: 0x0002EEC2
				[global::Cpp2ILInjected.Token(Token = "0x6003BC3")]
				[global::Cpp2ILInjected.Address(RVA = "0x14856E4", Offset = "0x14856E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x060053F1 RID: 21489 RVA: 0x00030CC5 File Offset: 0x0002EEC5
				[global::Cpp2ILInjected.Token(Token = "0x6003BC4")]
				[global::Cpp2ILInjected.Address(RVA = "0x14856EC", Offset = "0x14856EC", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_0(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053F2 RID: 21490 RVA: 0x00030CC8 File Offset: 0x0002EEC8
				[global::Cpp2ILInjected.Token(Token = "0x6003BC5")]
				[global::Cpp2ILInjected.Address(RVA = "0x14859A8", Offset = "0x14859A8", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_1(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053F3 RID: 21491 RVA: 0x00030CCB File Offset: 0x0002EECB
				[global::Cpp2ILInjected.Token(Token = "0x6003BC6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485C64", Offset = "0x1485C64", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_2(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053F4 RID: 21492 RVA: 0x00030CCE File Offset: 0x0002EECE
				[global::Cpp2ILInjected.Token(Token = "0x6003BC7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485F20", Offset = "0x1485F20", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_3(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053F5 RID: 21493 RVA: 0x00030CD1 File Offset: 0x0002EED1
				[global::Cpp2ILInjected.Token(Token = "0x6003BC8")]
				[global::Cpp2ILInjected.Address(RVA = "0x14861DC", Offset = "0x14861DC", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_4(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053F6 RID: 21494 RVA: 0x00030CD4 File Offset: 0x0002EED4
				[global::Cpp2ILInjected.Token(Token = "0x6003BC9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1486498", Offset = "0x1486498", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_5(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053F7 RID: 21495 RVA: 0x00030CD7 File Offset: 0x0002EED7
				[global::Cpp2ILInjected.Token(Token = "0x6003BCA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1486754", Offset = "0x1486754", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_6(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053F8 RID: 21496 RVA: 0x00030CDA File Offset: 0x0002EEDA
				[global::Cpp2ILInjected.Token(Token = "0x6003BCB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1486A10", Offset = "0x1486A10", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_7(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053F9 RID: 21497 RVA: 0x00030CDD File Offset: 0x0002EEDD
				[global::Cpp2ILInjected.Token(Token = "0x6003BCC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1486CCC", Offset = "0x1486CCC", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_8(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053FA RID: 21498 RVA: 0x00030CE0 File Offset: 0x0002EEE0
				[global::Cpp2ILInjected.Token(Token = "0x6003BCD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1486F88", Offset = "0x1486F88", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_9(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053FB RID: 21499 RVA: 0x00030CE3 File Offset: 0x0002EEE3
				[global::Cpp2ILInjected.Token(Token = "0x6003BCE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1487244", Offset = "0x1487244", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_10(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053FC RID: 21500 RVA: 0x00030CE6 File Offset: 0x0002EEE6
				[global::Cpp2ILInjected.Token(Token = "0x6003BCF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1487500", Offset = "0x1487500", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_11(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053FD RID: 21501 RVA: 0x00030CE9 File Offset: 0x0002EEE9
				[global::Cpp2ILInjected.Token(Token = "0x6003BD0")]
				[global::Cpp2ILInjected.Address(RVA = "0x14877BC", Offset = "0x14877BC", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_12(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053FE RID: 21502 RVA: 0x00030CEC File Offset: 0x0002EEEC
				[global::Cpp2ILInjected.Token(Token = "0x6003BD1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1487A78", Offset = "0x1487A78", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_13(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x060053FF RID: 21503 RVA: 0x00030CEF File Offset: 0x0002EEEF
				[global::Cpp2ILInjected.Token(Token = "0x6003BD2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1487D34", Offset = "0x1487D34", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_14(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005400 RID: 21504 RVA: 0x00030CF2 File Offset: 0x0002EEF2
				[global::Cpp2ILInjected.Token(Token = "0x6003BD3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1487FF0", Offset = "0x1487FF0", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_15(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005401 RID: 21505 RVA: 0x00030CF5 File Offset: 0x0002EEF5
				[global::Cpp2ILInjected.Token(Token = "0x6003BD4")]
				[global::Cpp2ILInjected.Address(RVA = "0x14882AC", Offset = "0x14882AC", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_16(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005402 RID: 21506 RVA: 0x00030CF8 File Offset: 0x0002EEF8
				[global::Cpp2ILInjected.Token(Token = "0x6003BD5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1488568", Offset = "0x1488568", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_17(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005403 RID: 21507 RVA: 0x00030CFB File Offset: 0x0002EEFB
				[global::Cpp2ILInjected.Token(Token = "0x6003BD6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1488824", Offset = "0x1488824", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_18(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005404 RID: 21508 RVA: 0x00030CFE File Offset: 0x0002EEFE
				[global::Cpp2ILInjected.Token(Token = "0x6003BD7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1488AE0", Offset = "0x1488AE0", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_19(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005405 RID: 21509 RVA: 0x00030D01 File Offset: 0x0002EF01
				[global::Cpp2ILInjected.Token(Token = "0x6003BD8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1488D9C", Offset = "0x1488D9C", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_20(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005406 RID: 21510 RVA: 0x00030D04 File Offset: 0x0002EF04
				[global::Cpp2ILInjected.Token(Token = "0x6003BD9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1489058", Offset = "0x1489058", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_21(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005407 RID: 21511 RVA: 0x00030D07 File Offset: 0x0002EF07
				[global::Cpp2ILInjected.Token(Token = "0x6003BDA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1489314", Offset = "0x1489314", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_22(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005408 RID: 21512 RVA: 0x00030D0A File Offset: 0x0002EF0A
				[global::Cpp2ILInjected.Token(Token = "0x6003BDB")]
				[global::Cpp2ILInjected.Address(RVA = "0x14895D0", Offset = "0x14895D0", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_23(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005409 RID: 21513 RVA: 0x00030D0D File Offset: 0x0002EF0D
				[global::Cpp2ILInjected.Token(Token = "0x6003BDC")]
				[global::Cpp2ILInjected.Address(RVA = "0x148988C", Offset = "0x148988C", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_24(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x0600540A RID: 21514 RVA: 0x00030D10 File Offset: 0x0002EF10
				[global::Cpp2ILInjected.Token(Token = "0x6003BDD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1489B48", Offset = "0x1489B48", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_25(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x0600540B RID: 21515 RVA: 0x00030D13 File Offset: 0x0002EF13
				[global::Cpp2ILInjected.Token(Token = "0x6003BDE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1489E04", Offset = "0x1489E04", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_26(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x0600540C RID: 21516 RVA: 0x00030D16 File Offset: 0x0002EF16
				[global::Cpp2ILInjected.Token(Token = "0x6003BDF")]
				[global::Cpp2ILInjected.Address(RVA = "0x148A0C0", Offset = "0x148A0C0", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_27(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x0600540D RID: 21517 RVA: 0x00030D19 File Offset: 0x0002EF19
				[global::Cpp2ILInjected.Token(Token = "0x6003BE0")]
				[global::Cpp2ILInjected.Address(RVA = "0x148A37C", Offset = "0x148A37C", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_28(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x0600540E RID: 21518 RVA: 0x00030D1C File Offset: 0x0002EF1C
				[global::Cpp2ILInjected.Token(Token = "0x6003BE1")]
				[global::Cpp2ILInjected.Address(RVA = "0x148A638", Offset = "0x148A638", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_29(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x0600540F RID: 21519 RVA: 0x00030D1F File Offset: 0x0002EF1F
				[global::Cpp2ILInjected.Token(Token = "0x6003BE2")]
				[global::Cpp2ILInjected.Address(RVA = "0x148A8F4", Offset = "0x148A8F4", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_30(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005410 RID: 21520 RVA: 0x00030D22 File Offset: 0x0002EF22
				[global::Cpp2ILInjected.Token(Token = "0x6003BE3")]
				[global::Cpp2ILInjected.Address(RVA = "0x148ABB0", Offset = "0x148ABB0", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_31(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005411 RID: 21521 RVA: 0x00030D25 File Offset: 0x0002EF25
				[global::Cpp2ILInjected.Token(Token = "0x6003BE4")]
				[global::Cpp2ILInjected.Address(RVA = "0x148AE6C", Offset = "0x148AE6C", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_32(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005412 RID: 21522 RVA: 0x00030D28 File Offset: 0x0002EF28
				[global::Cpp2ILInjected.Token(Token = "0x6003BE5")]
				[global::Cpp2ILInjected.Address(RVA = "0x148B128", Offset = "0x148B128", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_33(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005413 RID: 21523 RVA: 0x00030D2B File Offset: 0x0002EF2B
				[global::Cpp2ILInjected.Token(Token = "0x6003BE6")]
				[global::Cpp2ILInjected.Address(RVA = "0x148B3E4", Offset = "0x148B3E4", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_34(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005414 RID: 21524 RVA: 0x00030D2E File Offset: 0x0002EF2E
				[global::Cpp2ILInjected.Token(Token = "0x6003BE7")]
				[global::Cpp2ILInjected.Address(RVA = "0x148B6A0", Offset = "0x148B6A0", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_35(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005415 RID: 21525 RVA: 0x00030D31 File Offset: 0x0002EF31
				[global::Cpp2ILInjected.Token(Token = "0x6003BE8")]
				[global::Cpp2ILInjected.Address(RVA = "0x148B95C", Offset = "0x148B95C", Length = "0x2BC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, bool>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(IEnumerable<int>),
					typeof(Func<int, bool>)
				}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				internal List<int> <.cctor>b__39_36(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x06005416 RID: 21526 RVA: 0x00030D34 File Offset: 0x0002EF34
				[global::Cpp2ILInjected.Token(Token = "0x6003BE9")]
				[global::Cpp2ILInjected.Address(RVA = "0x148BC18", Offset = "0x148BC18", Length = "0x268")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.UI.ItemSorting.ItemSortingLayer", Member = "Validate", MemberParameters = new object[]
				{
					typeof(ref List<int>),
					typeof(Item[])
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
				internal List<int> <.cctor>b__39_37(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					throw null;
				}

				// Token: 0x040090FF RID: 37119
				[global::Cpp2ILInjected.Token(Token = "0x4007B58")]
				public static readonly ItemSorting.ItemSortingLayers.<>c <>9;
			}
		}

		// Token: 0x02000958 RID: 2392
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000710")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004D14 RID: 19732 RVA: 0x0002FA05 File Offset: 0x0002DC05
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003BEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x148BE80", Offset = "0x148BE80", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004D15 RID: 19733 RVA: 0x0002FA08 File Offset: 0x0002DC08
			[global::Cpp2ILInjected.Token(Token = "0x6003BEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x148BEDC", Offset = "0x148BEDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004D16 RID: 19734 RVA: 0x0002FA0B File Offset: 0x0002DC0B
			[global::Cpp2ILInjected.Token(Token = "0x6003BEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x148BEE4", Offset = "0x148BEE4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			internal int <SetupSortingPriorities>b__5_0(float x, float y)
			{
				throw null;
			}

			// Token: 0x04008B7B RID: 35707
			[global::Cpp2ILInjected.Token(Token = "0x4007B59")]
			public static readonly ItemSorting.<>c <>9;

			// Token: 0x04008B7C RID: 35708
			[global::Cpp2ILInjected.Token(Token = "0x4007B5A")]
			public static Comparison<float> <>9__5_0;
		}
	}
}
