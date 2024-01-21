using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200055D")]
public class ItemShopSellbackHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000982")]
	private class ItemMemo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C23")]
		public readonly int itemNetID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C24")]
		public readonly int itemPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008C25")]
		public int stack;

		[Cpp2IlInjected.Token(Token = "0x6004DF1")]
		[Cpp2IlInjected.Address(RVA = "0x104D4B4", Offset = "0x104D4B4", VA = "0x104D4B4")]
		public ItemMemo(Item item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF2")]
		[Cpp2IlInjected.Address(RVA = "0x104D804", Offset = "0x104D804", VA = "0x104D804")]
		public bool Matches(Item item)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006923")]
	private List<ItemMemo> _memos;

	[Cpp2IlInjected.Token(Token = "0x6003A34")]
	[Cpp2IlInjected.Address(RVA = "0x104D360", Offset = "0x104D360", VA = "0x104D360")]
	public void Add(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A35")]
	[Cpp2IlInjected.Address(RVA = "0x104D4E8", Offset = "0x104D4E8", VA = "0x104D4E8")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A36")]
	[Cpp2IlInjected.Address(RVA = "0x104D544", Offset = "0x104D544", VA = "0x104D544")]
	public int GetAmount(Item item)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A37")]
	[Cpp2IlInjected.Address(RVA = "0x104D62C", Offset = "0x104D62C", VA = "0x104D62C")]
	public int Remove(Item item)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A38")]
	[Cpp2IlInjected.Address(RVA = "0x104D750", Offset = "0x104D750", VA = "0x104D750")]
	public ItemShopSellbackHelper()
	{
	}
}
