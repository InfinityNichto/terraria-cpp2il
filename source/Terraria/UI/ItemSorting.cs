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
	[global::Cpp2ILInjected.Token(Token = "0x20006E5")]
	public class ItemSorting
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x14818FC", Offset = "0x14818FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemSorting()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007B06")]
		private static List<ItemSorting.ItemSortingLayer> _layerList;

		[global::Cpp2ILInjected.Token(Token = "0x4007B07")]
		private static Dictionary<string, List<int>> _layerWhiteLists;

		[global::Cpp2ILInjected.Token(Token = "0x20006E6")]
		private class ItemSortingLayer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003B4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x14819E0", Offset = "0x14819E0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ItemSortingLayer(string name, Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> method)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003B4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1481A0C", Offset = "0x1481A0C", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_0", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_1", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_2", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_3", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_4", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_5", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_6", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_7", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_8", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_9", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_10", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_11", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_12", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_13", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_14", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_15", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_16", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_17", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_18", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_19", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_20", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_21", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_22", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_23", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_24", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_25", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_26", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_27", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_28", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_29", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_30", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_31", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_32", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_33", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_34", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_35", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_36", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c", Member = "<.cctor>b__39_37", MemberParameters = new object[]
			{
				typeof(ItemSorting.ItemSortingLayer),
				typeof(Item[]),
				typeof(List<int>)
			}, ReturnType = typeof(List<int>))]
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

			[global::Cpp2ILInjected.Token(Token = "0x6003B4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1481B68", Offset = "0x1481B68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override string ToString()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007B08")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly string Name;

			[global::Cpp2ILInjected.Token(Token = "0x4007B09")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> SortingMethod;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006E7")]
			private sealed class <>c__DisplayClass3_0
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B4D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1481B60", Offset = "0x1481B60", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass3_0()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B4E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1481B70", Offset = "0x1481B70", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Validate>b__0(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B0A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public List<int> list;

				[global::Cpp2ILInjected.Token(Token = "0x4007B0B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public Item[] inv;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20006E8")]
		private class ItemSortingLayers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003B4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1481BD0", Offset = "0x1481BD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ItemSortingLayers()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4007B0C")]
			public static ItemSorting.ItemSortingLayer WeaponsMelee;

			[global::Cpp2ILInjected.Token(Token = "0x4007B0D")]
			public static ItemSorting.ItemSortingLayer WeaponsRanged;

			[global::Cpp2ILInjected.Token(Token = "0x4007B0E")]
			public static ItemSorting.ItemSortingLayer WeaponsMagic;

			[global::Cpp2ILInjected.Token(Token = "0x4007B0F")]
			public static ItemSorting.ItemSortingLayer WeaponsMinions;

			[global::Cpp2ILInjected.Token(Token = "0x4007B10")]
			public static ItemSorting.ItemSortingLayer WeaponsAssorted;

			[global::Cpp2ILInjected.Token(Token = "0x4007B11")]
			public static ItemSorting.ItemSortingLayer WeaponsAmmo;

			[global::Cpp2ILInjected.Token(Token = "0x4007B12")]
			public static ItemSorting.ItemSortingLayer ToolsPicksaws;

			[global::Cpp2ILInjected.Token(Token = "0x4007B13")]
			public static ItemSorting.ItemSortingLayer ToolsHamaxes;

			[global::Cpp2ILInjected.Token(Token = "0x4007B14")]
			public static ItemSorting.ItemSortingLayer ToolsPickaxes;

			[global::Cpp2ILInjected.Token(Token = "0x4007B15")]
			public static ItemSorting.ItemSortingLayer ToolsAxes;

			[global::Cpp2ILInjected.Token(Token = "0x4007B16")]
			public static ItemSorting.ItemSortingLayer ToolsHammers;

			[global::Cpp2ILInjected.Token(Token = "0x4007B17")]
			public static ItemSorting.ItemSortingLayer ToolsTerraforming;

			[global::Cpp2ILInjected.Token(Token = "0x4007B18")]
			public static ItemSorting.ItemSortingLayer ToolsAmmoLeftovers;

			[global::Cpp2ILInjected.Token(Token = "0x4007B19")]
			public static ItemSorting.ItemSortingLayer ArmorCombat;

			[global::Cpp2ILInjected.Token(Token = "0x4007B1A")]
			public static ItemSorting.ItemSortingLayer ArmorVanity;

			[global::Cpp2ILInjected.Token(Token = "0x4007B1B")]
			public static ItemSorting.ItemSortingLayer ArmorAccessories;

			[global::Cpp2ILInjected.Token(Token = "0x4007B1C")]
			public static ItemSorting.ItemSortingLayer EquipGrapple;

			[global::Cpp2ILInjected.Token(Token = "0x4007B1D")]
			public static ItemSorting.ItemSortingLayer EquipMount;

			[global::Cpp2ILInjected.Token(Token = "0x4007B1E")]
			public static ItemSorting.ItemSortingLayer EquipCart;

			[global::Cpp2ILInjected.Token(Token = "0x4007B1F")]
			public static ItemSorting.ItemSortingLayer EquipLightPet;

			[global::Cpp2ILInjected.Token(Token = "0x4007B20")]
			public static ItemSorting.ItemSortingLayer EquipVanityPet;

			[global::Cpp2ILInjected.Token(Token = "0x4007B21")]
			public static ItemSorting.ItemSortingLayer PotionsLife;

			[global::Cpp2ILInjected.Token(Token = "0x4007B22")]
			public static ItemSorting.ItemSortingLayer PotionsMana;

			[global::Cpp2ILInjected.Token(Token = "0x4007B23")]
			public static ItemSorting.ItemSortingLayer PotionsElixirs;

			[global::Cpp2ILInjected.Token(Token = "0x4007B24")]
			public static ItemSorting.ItemSortingLayer PotionsBuffs;

			[global::Cpp2ILInjected.Token(Token = "0x4007B25")]
			public static ItemSorting.ItemSortingLayer PotionsDyes;

			[global::Cpp2ILInjected.Token(Token = "0x4007B26")]
			public static ItemSorting.ItemSortingLayer PotionsHairDyes;

			[global::Cpp2ILInjected.Token(Token = "0x4007B27")]
			public static ItemSorting.ItemSortingLayer MiscValuables;

			[global::Cpp2ILInjected.Token(Token = "0x4007B28")]
			public static ItemSorting.ItemSortingLayer MiscWiring;

			[global::Cpp2ILInjected.Token(Token = "0x4007B29")]
			public static ItemSorting.ItemSortingLayer MiscMaterials;

			[global::Cpp2ILInjected.Token(Token = "0x4007B2A")]
			public static ItemSorting.ItemSortingLayer MiscExtractinator;

			[global::Cpp2ILInjected.Token(Token = "0x4007B2B")]
			public static ItemSorting.ItemSortingLayer MiscPainting;

			[global::Cpp2ILInjected.Token(Token = "0x4007B2C")]
			public static ItemSorting.ItemSortingLayer MiscRopes;

			[global::Cpp2ILInjected.Token(Token = "0x4007B2D")]
			public static ItemSorting.ItemSortingLayer LastMaterials;

			[global::Cpp2ILInjected.Token(Token = "0x4007B2E")]
			public static ItemSorting.ItemSortingLayer LastTilesImportant;

			[global::Cpp2ILInjected.Token(Token = "0x4007B2F")]
			public static ItemSorting.ItemSortingLayer LastTilesCommon;

			[global::Cpp2ILInjected.Token(Token = "0x4007B30")]
			public static ItemSorting.ItemSortingLayer LastNotTrash;

			[global::Cpp2ILInjected.Token(Token = "0x4007B31")]
			public static ItemSorting.ItemSortingLayer LastTrash;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006E9")]
			private sealed class <>c__DisplayClass39_0
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B51")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482E50", Offset = "0x1482E50", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_0()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B52")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482E58", Offset = "0x1482E58", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__38(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B32")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EA")]
			private sealed class <>c__DisplayClass39_1
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B54")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482F80", Offset = "0x1482F80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_1()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B55")]
				[global::Cpp2ILInjected.Address(RVA = "0x1482F88", Offset = "0x1482F88", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__40(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B33")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EB")]
			private sealed class <>c__DisplayClass39_2
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B57")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483090", Offset = "0x1483090", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_2()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B58")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483098", Offset = "0x1483098", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__42(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B34")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EC")]
			private sealed class <>c__DisplayClass39_3
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B5A")]
				[global::Cpp2ILInjected.Address(RVA = "0x14831A0", Offset = "0x14831A0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_3()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B5B")]
				[global::Cpp2ILInjected.Address(RVA = "0x14831A8", Offset = "0x14831A8", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__44(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B35")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006ED")]
			private sealed class <>c__DisplayClass39_4
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B5D")]
				[global::Cpp2ILInjected.Address(RVA = "0x14832A8", Offset = "0x14832A8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_4()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B5E")]
				[global::Cpp2ILInjected.Address(RVA = "0x14832B0", Offset = "0x14832B0", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__46(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B36")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EE")]
			private sealed class <>c__DisplayClass39_5
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B60")]
				[global::Cpp2ILInjected.Address(RVA = "0x14833BC", Offset = "0x14833BC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_5()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B61")]
				[global::Cpp2ILInjected.Address(RVA = "0x14833C4", Offset = "0x14833C4", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__48(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B37")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006EF")]
			private sealed class <>c__DisplayClass39_6
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B63")]
				[global::Cpp2ILInjected.Address(RVA = "0x14834B8", Offset = "0x14834B8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_6()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B64")]
				[global::Cpp2ILInjected.Address(RVA = "0x14834C0", Offset = "0x14834C0", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__50(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B65")]
				[global::Cpp2ILInjected.Address(RVA = "0x14834F0", Offset = "0x14834F0", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__51(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B38")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F0")]
			private sealed class <>c__DisplayClass39_7
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B66")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483510", Offset = "0x1483510", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_7()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B67")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483518", Offset = "0x1483518", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__52(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B68")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483548", Offset = "0x1483548", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__53(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B39")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F1")]
			private sealed class <>c__DisplayClass39_8
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B69")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483568", Offset = "0x1483568", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_8()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B6A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483570", Offset = "0x1483570", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__54(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B6B")]
				[global::Cpp2ILInjected.Address(RVA = "0x148358C", Offset = "0x148358C", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__55(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B3A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F2")]
			private sealed class <>c__DisplayClass39_9
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B6C")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835AC", Offset = "0x14835AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_9()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B6D")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835B4", Offset = "0x14835B4", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__56(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B6E")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835D0", Offset = "0x14835D0", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__57(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B3B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F3")]
			private sealed class <>c__DisplayClass39_10
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B6F")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835F0", Offset = "0x14835F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_10()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B70")]
				[global::Cpp2ILInjected.Address(RVA = "0x14835F8", Offset = "0x14835F8", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__58(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B71")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483614", Offset = "0x1483614", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__59(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B3C")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F4")]
			private sealed class <>c__DisplayClass39_11
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B72")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483634", Offset = "0x1483634", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_11()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B73")]
				[global::Cpp2ILInjected.Address(RVA = "0x148363C", Offset = "0x148363C", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__60(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B3D")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F5")]
			private sealed class <>c__DisplayClass39_12
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B75")]
				[global::Cpp2ILInjected.Address(RVA = "0x14837C4", Offset = "0x14837C4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_12()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B76")]
				[global::Cpp2ILInjected.Address(RVA = "0x14837CC", Offset = "0x14837CC", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__62(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B3E")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F6")]
			private sealed class <>c__DisplayClass39_13
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B78")]
				[global::Cpp2ILInjected.Address(RVA = "0x14838AC", Offset = "0x14838AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_13()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B79")]
				[global::Cpp2ILInjected.Address(RVA = "0x14838B4", Offset = "0x14838B4", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__64(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B3F")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F7")]
			private sealed class <>c__DisplayClass39_14
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B7B")]
				[global::Cpp2ILInjected.Address(RVA = "0x14839C0", Offset = "0x14839C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_14()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B7C")]
				[global::Cpp2ILInjected.Address(RVA = "0x14839C8", Offset = "0x14839C8", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__66(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B7D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483A04", Offset = "0x1483A04", Length = "0x90")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__67(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B40")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F8")]
			private sealed class <>c__DisplayClass39_15
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B7E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483A94", Offset = "0x1483A94", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_15()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B7F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483A9C", Offset = "0x1483A9C", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__68(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B41")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006F9")]
			private sealed class <>c__DisplayClass39_16
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B81")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483BA8", Offset = "0x1483BA8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_16()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B82")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483BB0", Offset = "0x1483BB0", Length = "0x80")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__70(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B83")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483C30", Offset = "0x1483C30", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__71(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B42")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FA")]
			private sealed class <>c__DisplayClass39_17
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B84")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483CD8", Offset = "0x1483CD8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_17()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B85")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483CE0", Offset = "0x1483CE0", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__72(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B86")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483D84", Offset = "0x1483D84", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__73(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B43")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FB")]
			private sealed class <>c__DisplayClass39_18
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B87")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483E2C", Offset = "0x1483E2C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_18()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B88")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483E34", Offset = "0x1483E34", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__74(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B89")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483ED8", Offset = "0x1483ED8", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__75(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B44")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FC")]
			private sealed class <>c__DisplayClass39_19
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B8A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483F80", Offset = "0x1483F80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_19()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B8B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1483F88", Offset = "0x1483F88", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__76(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B8C")]
				[global::Cpp2ILInjected.Address(RVA = "0x148402C", Offset = "0x148402C", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__77(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B45")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FD")]
			private sealed class <>c__DisplayClass39_20
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B8D")]
				[global::Cpp2ILInjected.Address(RVA = "0x14840D4", Offset = "0x14840D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_20()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B8E")]
				[global::Cpp2ILInjected.Address(RVA = "0x14840DC", Offset = "0x14840DC", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__78(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B8F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484180", Offset = "0x1484180", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__79(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B46")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FE")]
			private sealed class <>c__DisplayClass39_21
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B90")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484228", Offset = "0x1484228", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_21()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B91")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484230", Offset = "0x1484230", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__80(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B92")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484268", Offset = "0x1484268", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__81(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B47")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20006FF")]
			private sealed class <>c__DisplayClass39_22
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B93")]
				[global::Cpp2ILInjected.Address(RVA = "0x14842F4", Offset = "0x14842F4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_22()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B94")]
				[global::Cpp2ILInjected.Address(RVA = "0x14842FC", Offset = "0x14842FC", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__82(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B95")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484334", Offset = "0x1484334", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__83(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B48")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000700")]
			private sealed class <>c__DisplayClass39_23
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B96")]
				[global::Cpp2ILInjected.Address(RVA = "0x14843C0", Offset = "0x14843C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_23()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B97")]
				[global::Cpp2ILInjected.Address(RVA = "0x14843C8", Offset = "0x14843C8", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__84(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B98")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484400", Offset = "0x1484400", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__85(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B49")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000701")]
			private sealed class <>c__DisplayClass39_24
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B99")]
				[global::Cpp2ILInjected.Address(RVA = "0x148448C", Offset = "0x148448C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_24()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B9A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484494", Offset = "0x1484494", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__86(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B9B")]
				[global::Cpp2ILInjected.Address(RVA = "0x14844C0", Offset = "0x14844C0", Length = "0xCC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__87(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B4A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000702")]
			private sealed class <>c__DisplayClass39_25
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B9C")]
				[global::Cpp2ILInjected.Address(RVA = "0x148458C", Offset = "0x148458C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_25()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003B9D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484594", Offset = "0x1484594", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__88(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B4B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000703")]
			private sealed class <>c__DisplayClass39_26
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003B9F")]
				[global::Cpp2ILInjected.Address(RVA = "0x148467C", Offset = "0x148467C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_26()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BA0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484684", Offset = "0x1484684", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__90(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B4C")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000704")]
			private sealed class <>c__DisplayClass39_27
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BA2")]
				[global::Cpp2ILInjected.Address(RVA = "0x148476C", Offset = "0x148476C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_27()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BA3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484774", Offset = "0x1484774", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__92(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B4D")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000705")]
			private sealed class <>c__DisplayClass39_28
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BA5")]
				[global::Cpp2ILInjected.Address(RVA = "0x14848FC", Offset = "0x14848FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_28()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BA6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484904", Offset = "0x1484904", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__94(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B4E")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000706")]
			private sealed class <>c__DisplayClass39_29
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BA8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484AFC", Offset = "0x1484AFC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_29()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BA9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484B04", Offset = "0x1484B04", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__96(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B4F")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000707")]
			private sealed class <>c__DisplayClass39_30
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BAB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484C8C", Offset = "0x1484C8C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_30()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BAC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484C94", Offset = "0x1484C94", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__98(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B50")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000708")]
			private sealed class <>c__DisplayClass39_31
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BAE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484E1C", Offset = "0x1484E1C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_31()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BAF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484E24", Offset = "0x1484E24", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__100(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B51")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000709")]
			private sealed class <>c__DisplayClass39_32
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BB1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1484FFC", Offset = "0x1484FFC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_32()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BB2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485004", Offset = "0x1485004", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__102(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B52")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070A")]
			private sealed class <>c__DisplayClass39_33
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BB4")]
				[global::Cpp2ILInjected.Address(RVA = "0x148518C", Offset = "0x148518C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_33()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BB5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485194", Offset = "0x1485194", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__104(int i)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BB6")]
				[global::Cpp2ILInjected.Address(RVA = "0x14851C0", Offset = "0x14851C0", Length = "0xCC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__105(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B53")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070B")]
			private sealed class <>c__DisplayClass39_34
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BB7")]
				[global::Cpp2ILInjected.Address(RVA = "0x148528C", Offset = "0x148528C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_34()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BB8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1485294", Offset = "0x1485294", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal bool <.cctor>b__106(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B54")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070C")]
			private sealed class <>c__DisplayClass39_35
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BBA")]
				[global::Cpp2ILInjected.Address(RVA = "0x14853E4", Offset = "0x14853E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_35()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BBB")]
				[global::Cpp2ILInjected.Address(RVA = "0x14853EC", Offset = "0x14853EC", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal bool <.cctor>b__108(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B55")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070D")]
			private sealed class <>c__DisplayClass39_36
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BBD")]
				[global::Cpp2ILInjected.Address(RVA = "0x14854CC", Offset = "0x14854CC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_36()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BBE")]
				[global::Cpp2ILInjected.Address(RVA = "0x14854D4", Offset = "0x14854D4", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_OriginalRarity", ReturnType = typeof(int))]
				internal bool <.cctor>b__110(int i)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B56")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070E")]
			private sealed class <>c__DisplayClass39_37
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003BC0")]
				[global::Cpp2ILInjected.Address(RVA = "0x14855F4", Offset = "0x14855F4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c__DisplayClass39_37()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003BC1")]
				[global::Cpp2ILInjected.Address(RVA = "0x14855FC", Offset = "0x14855FC", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
				internal int <.cctor>b__112(int x, int y)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007B57")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public Item[] inv;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200070F")]
			[Serializable]
			private sealed class <>c
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6003BC3")]
				[global::Cpp2ILInjected.Address(RVA = "0x14856E4", Offset = "0x14856E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x4007B58")]
				public static readonly ItemSorting.ItemSortingLayers.<>c <>9;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000710")]
		[Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6003BEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x148BEDC", Offset = "0x148BEDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003BEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x148BEE4", Offset = "0x148BEE4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			internal int <SetupSortingPriorities>b__5_0(float x, float y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007B59")]
			public static readonly ItemSorting.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4007B5A")]
			public static Comparison<float> <>9__5_0;
		}
	}
}
