using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007DA")]
	public class ItemShopSellbackHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x774108", Offset = "0x774108", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "PurchasePressedAndHeld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "HandleShopSlot", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Find", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Add(Item item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7742FC", Offset = "0x7742FC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateOldNPCShop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x774364", Offset = "0x774364", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip", MemberParameters = new object[]
		{
			typeof(Main.MouseTextCache),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SellItemAmount", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SellItem", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Find", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public int GetAmount(Item item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x77444C", Offset = "0x77444C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "AddItemToShop", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Find", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int Remove(Item item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x774574", Offset = "0x774574", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ItemShopSellbackHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007EA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<ItemShopSellbackHelper.ItemMemo> _memos;

		[global::Cpp2ILInjected.Token(Token = "0x20007DB")]
		private class ItemMemo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60040E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7742C0", Offset = "0x7742C0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ItemMemo(Item item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7745F0", Offset = "0x7745F0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Matches(Item item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007EA4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly int itemNetID;

			[global::Cpp2ILInjected.Token(Token = "0x4007EA5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public readonly int itemPrefix;

			[global::Cpp2ILInjected.Token(Token = "0x4007EA6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int stack;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007DC")]
		private sealed class <>c__DisplayClass2_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60040E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7742B8", Offset = "0x7742B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass2_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x77461C", Offset = "0x77461C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Add>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007EA7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Item item;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007DD")]
		private sealed class <>c__DisplayClass4_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60040E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x774444", Offset = "0x774444", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass4_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x77464C", Offset = "0x77464C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <GetAmount>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007EA8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Item item;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007DE")]
		private sealed class <>c__DisplayClass5_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60040E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x77456C", Offset = "0x77456C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x77467C", Offset = "0x77467C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Remove>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007EA9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Item item;
		}
	}
}
