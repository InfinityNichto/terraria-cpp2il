using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200055E")]
public class ItemTrader
{
	[Cpp2IlInjected.Token(Token = "0x2000986")]
	public class TradeOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C29")]
		public int TakingItemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C2A")]
		public int TakingItemStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008C2B")]
		public int GivingITemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008C2C")]
		public int GivingItemStack;

		[Cpp2IlInjected.Token(Token = "0x6004DF9")]
		[Cpp2IlInjected.Address(RVA = "0x104DB34", Offset = "0x104DB34", VA = "0x104DB34")]
		public bool WillTradeFor(int offeredItemType, int offeredItemStack)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFA")]
		[Cpp2IlInjected.Address(RVA = "0x104DA64", Offset = "0x104DA64", VA = "0x104DA64")]
		public TradeOption()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006924")]
	public static ItemTrader ChlorophyteExtractinator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006925")]
	private List<TradeOption> _options;

	[Cpp2IlInjected.Token(Token = "0x6003A39")]
	[Cpp2IlInjected.Address(RVA = "0x104D894", Offset = "0x104D894", VA = "0x104D894")]
	public void AddOption_Interchangable(int itemType1, int itemType2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A3A")]
	[Cpp2IlInjected.Address(RVA = "0x104D984", Offset = "0x104D984", VA = "0x104D984")]
	public void AddOption_CyclicLoop(params int[] typesInOrder)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A3B")]
	[Cpp2IlInjected.Address(RVA = "0x104DA04", Offset = "0x104DA04", VA = "0x104DA04")]
	public void AddOption_FromAny(int givingItemType, params int[] takingItemTypes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A3C")]
	[Cpp2IlInjected.Address(RVA = "0x104D8E0", Offset = "0x104D8E0", VA = "0x104D8E0")]
	public void AddOption_OneWay(int takingItemType, int takingItemStack, int givingItemType, int givingItemStack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A3D")]
	[Cpp2IlInjected.Address(RVA = "0x104DA6C", Offset = "0x104DA6C", VA = "0x104DA6C")]
	public bool TryGetTradeOption(Item item, out TradeOption option)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A3E")]
	[Cpp2IlInjected.Address(RVA = "0x104DB58", Offset = "0x104DB58", VA = "0x104DB58")]
	public static ItemTrader CreateChlorophyteExtractinator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A3F")]
	[Cpp2IlInjected.Address(RVA = "0x104E064", Offset = "0x104E064", VA = "0x104E064")]
	public ItemTrader()
	{
	}
}
