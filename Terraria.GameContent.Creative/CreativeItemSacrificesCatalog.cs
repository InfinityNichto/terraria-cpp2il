using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x2000680")]
public class CreativeItemSacrificesCatalog
{
	[Cpp2IlInjected.Token(Token = "0x4006DB7")]
	public static CreativeItemSacrificesCatalog Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006DB8")]
	private Dictionary<int, int> _sacrificeCountNeededByItemId;

	[Cpp2IlInjected.Token(Token = "0x17000796")]
	public Dictionary<int, int> SacrificeCountNeededByItemId
	{
		[Cpp2IlInjected.Token(Token = "0x60041A7")]
		[Cpp2IlInjected.Address(RVA = "0x1081884", Offset = "0x1081884", VA = "0x1081884")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60041A8")]
	[Cpp2IlInjected.Address(RVA = "0x108188C", Offset = "0x108188C", VA = "0x108188C")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041A9")]
	[Cpp2IlInjected.Address(RVA = "0x1081EBC", Offset = "0x1081EBC", VA = "0x1081EBC")]
	public bool TryGetSacrificeCountCapToUnlockInfiniteItems(int itemId, out int amountNeeded)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60041AA")]
	[Cpp2IlInjected.Address(RVA = "0x1081F8C", Offset = "0x1081F8C", VA = "0x1081F8C")]
	public CreativeItemSacrificesCatalog()
	{
	}
}
