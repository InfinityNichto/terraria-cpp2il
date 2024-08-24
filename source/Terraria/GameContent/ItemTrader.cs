using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent
{
	// Token: 0x0200055B RID: 1371
	[global::Cpp2ILInjected.Token(Token = "0x20007DF")]
	public class ItemTrader
	{
		// Token: 0x060039FD RID: 14845 RVA: 0x0002C59A File Offset: 0x0002A79A
		[global::Cpp2ILInjected.Token(Token = "0x60040EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7746AC", Offset = "0x7746AC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTrader), Member = "AddOption_OneWay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void AddOption_Interchangable(int itemType1, int itemType2)
		{
			throw null;
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x0002C59D File Offset: 0x0002A79D
		[global::Cpp2ILInjected.Token(Token = "0x60040EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7747F0", Offset = "0x7747F0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTrader), Member = "CreateChlorophyteExtractinator", ReturnType = typeof(ItemTrader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTrader), Member = "AddOption_OneWay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void AddOption_CyclicLoop(params int[] typesInOrder)
		{
			throw null;
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x0002C5A0 File Offset: 0x0002A7A0
		[global::Cpp2ILInjected.Token(Token = "0x60040EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x774878", Offset = "0x774878", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTrader), Member = "CreateChlorophyteExtractinator", ReturnType = typeof(ItemTrader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTrader), Member = "AddOption_OneWay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void AddOption_FromAny(int givingItemType, params int[] takingItemTypes)
		{
			throw null;
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x0002C5A3 File Offset: 0x0002A7A3
		[global::Cpp2ILInjected.Token(Token = "0x60040ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x7746F0", Offset = "0x7746F0", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTrader), Member = "AddOption_Interchangable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTrader), Member = "AddOption_CyclicLoop", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTrader), Member = "AddOption_FromAny", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTrader), Member = "CreateChlorophyteExtractinator", ReturnType = typeof(ItemTrader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AddOption_OneWay(int takingItemType, int takingItemStack, int givingItemType, int givingItemStack)
		{
			throw null;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x0002C5A6 File Offset: 0x0002A7A6
		[global::Cpp2ILInjected.Token(Token = "0x60040EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7748E4", Offset = "0x7748E4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SmartSelect_PickToolForStrategy", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_ItemInExtractinator", MemberParameters = new object[] { typeof(ref Player.ItemCheckContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryGetTradeOption(Item item, out ItemTrader.TradeOption option)
		{
			throw null;
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x0002C5A9 File Offset: 0x0002A7A9
		[global::Cpp2ILInjected.Token(Token = "0x60040EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7749D4", Offset = "0x7749D4", Length = "0x528")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTrader), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTrader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTrader), Member = "AddOption_OneWay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTrader), Member = "AddOption_CyclicLoop", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTrader), Member = "AddOption_FromAny", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static ItemTrader CreateChlorophyteExtractinator()
		{
			throw null;
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x0002C5AC File Offset: 0x0002A7AC
		[global::Cpp2ILInjected.Token(Token = "0x60040F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x774EFC", Offset = "0x774EFC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTrader), Member = "CreateChlorophyteExtractinator", ReturnType = typeof(ItemTrader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ItemTrader()
		{
			throw null;
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x0002C5AF File Offset: 0x0002A7AF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60040F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x774F78", Offset = "0x774F78", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTrader), Member = "CreateChlorophyteExtractinator", ReturnType = typeof(ItemTrader))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static ItemTrader()
		{
			throw null;
		}

		// Token: 0x04006923 RID: 26915
		[global::Cpp2ILInjected.Token(Token = "0x4007EAA")]
		public static ItemTrader ChlorophyteExtractinator;

		// Token: 0x04006924 RID: 26916
		[global::Cpp2ILInjected.Token(Token = "0x4007EAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<ItemTrader.TradeOption> _options;

		// Token: 0x0200098F RID: 2447
		[global::Cpp2ILInjected.Token(Token = "0x20007E0")]
		public class TradeOption
		{
			// Token: 0x06004DC2 RID: 19906 RVA: 0x0002FB8E File Offset: 0x0002DD8E
			[global::Cpp2ILInjected.Token(Token = "0x60040F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7749B0", Offset = "0x7749B0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool WillTradeFor(int offeredItemType, int offeredItemStack)
			{
				throw null;
			}

			// Token: 0x06004DC3 RID: 19907 RVA: 0x0002FB91 File Offset: 0x0002DD91
			[global::Cpp2ILInjected.Token(Token = "0x60040F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7748DC", Offset = "0x7748DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TradeOption()
			{
				throw null;
			}

			// Token: 0x04008C3C RID: 35900
			[global::Cpp2ILInjected.Token(Token = "0x4007EAC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int TakingItemType;

			// Token: 0x04008C3D RID: 35901
			[global::Cpp2ILInjected.Token(Token = "0x4007EAD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int TakingItemStack;

			// Token: 0x04008C3E RID: 35902
			[global::Cpp2ILInjected.Token(Token = "0x4007EAE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int GivingITemType;

			// Token: 0x04008C3F RID: 35903
			[global::Cpp2ILInjected.Token(Token = "0x4007EAF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int GivingItemStack;
		}
	}
}
