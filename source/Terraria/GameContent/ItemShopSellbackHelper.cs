using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent
{
	// Token: 0x0200055A RID: 1370
	[global::Cpp2ILInjected.Token(Token = "0x20007DA")]
	public class ItemShopSellbackHelper
	{
		// Token: 0x060039F8 RID: 14840 RVA: 0x0002C58B File Offset: 0x0002A78B
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

		// Token: 0x060039F9 RID: 14841 RVA: 0x0002C58E File Offset: 0x0002A78E
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

		// Token: 0x060039FA RID: 14842 RVA: 0x0002C591 File Offset: 0x0002A791
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

		// Token: 0x060039FB RID: 14843 RVA: 0x0002C594 File Offset: 0x0002A794
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

		// Token: 0x060039FC RID: 14844 RVA: 0x0002C597 File Offset: 0x0002A797
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

		// Token: 0x04006922 RID: 26914
		[global::Cpp2ILInjected.Token(Token = "0x4007EA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<ItemShopSellbackHelper.ItemMemo> _memos;

		// Token: 0x0200098B RID: 2443
		[global::Cpp2ILInjected.Token(Token = "0x20007DB")]
		private class ItemMemo
		{
			// Token: 0x06004DBA RID: 19898 RVA: 0x0002FB76 File Offset: 0x0002DD76
			[global::Cpp2ILInjected.Token(Token = "0x60040E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7742C0", Offset = "0x7742C0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ItemMemo(Item item)
			{
				throw null;
			}

			// Token: 0x06004DBB RID: 19899 RVA: 0x0002FB79 File Offset: 0x0002DD79
			[global::Cpp2ILInjected.Token(Token = "0x60040E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7745F0", Offset = "0x7745F0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Matches(Item item)
			{
				throw null;
			}

			// Token: 0x04008C36 RID: 35894
			[global::Cpp2ILInjected.Token(Token = "0x4007EA4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly int itemNetID;

			// Token: 0x04008C37 RID: 35895
			[global::Cpp2ILInjected.Token(Token = "0x4007EA5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public readonly int itemPrefix;

			// Token: 0x04008C38 RID: 35896
			[global::Cpp2ILInjected.Token(Token = "0x4007EA6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int stack;
		}

		// Token: 0x0200098C RID: 2444
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007DC")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06004DBC RID: 19900 RVA: 0x0002FB7C File Offset: 0x0002DD7C
			[global::Cpp2ILInjected.Token(Token = "0x60040E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7742B8", Offset = "0x7742B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass2_0()
			{
				throw null;
			}

			// Token: 0x06004DBD RID: 19901 RVA: 0x0002FB7F File Offset: 0x0002DD7F
			[global::Cpp2ILInjected.Token(Token = "0x60040E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x77461C", Offset = "0x77461C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Add>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				throw null;
			}

			// Token: 0x04008C39 RID: 35897
			[global::Cpp2ILInjected.Token(Token = "0x4007EA7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Item item;
		}

		// Token: 0x0200098D RID: 2445
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007DD")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004DBE RID: 19902 RVA: 0x0002FB82 File Offset: 0x0002DD82
			[global::Cpp2ILInjected.Token(Token = "0x60040E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x774444", Offset = "0x774444", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass4_0()
			{
				throw null;
			}

			// Token: 0x06004DBF RID: 19903 RVA: 0x0002FB85 File Offset: 0x0002DD85
			[global::Cpp2ILInjected.Token(Token = "0x60040E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x77464C", Offset = "0x77464C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <GetAmount>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				throw null;
			}

			// Token: 0x04008C3A RID: 35898
			[global::Cpp2ILInjected.Token(Token = "0x4007EA8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Item item;
		}

		// Token: 0x0200098E RID: 2446
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007DE")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004DC0 RID: 19904 RVA: 0x0002FB88 File Offset: 0x0002DD88
			[global::Cpp2ILInjected.Token(Token = "0x60040E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x77456C", Offset = "0x77456C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

			// Token: 0x06004DC1 RID: 19905 RVA: 0x0002FB8B File Offset: 0x0002DD8B
			[global::Cpp2ILInjected.Token(Token = "0x60040E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x77467C", Offset = "0x77467C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Remove>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				throw null;
			}

			// Token: 0x04008C3B RID: 35899
			[global::Cpp2ILInjected.Token(Token = "0x4007EA9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Item item;
		}
	}
}
