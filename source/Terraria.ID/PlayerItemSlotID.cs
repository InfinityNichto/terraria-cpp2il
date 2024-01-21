using Cpp2IlInjected;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x20003FE")]
public static class PlayerItemSlotID
{
	[Cpp2IlInjected.Token(Token = "0x40055C1")]
	public static readonly int Inventory0;

	[Cpp2IlInjected.Token(Token = "0x40055C2")]
	public static readonly int InventoryMouseItem;

	[Cpp2IlInjected.Token(Token = "0x40055C3")]
	public static readonly int Armor0;

	[Cpp2IlInjected.Token(Token = "0x40055C4")]
	public static readonly int Dye0;

	[Cpp2IlInjected.Token(Token = "0x40055C5")]
	public static readonly int Misc0;

	[Cpp2IlInjected.Token(Token = "0x40055C6")]
	public static readonly int MiscDye0;

	[Cpp2IlInjected.Token(Token = "0x40055C7")]
	public static readonly int Bank1_0;

	[Cpp2IlInjected.Token(Token = "0x40055C8")]
	public static readonly int Bank2_0;

	[Cpp2IlInjected.Token(Token = "0x40055C9")]
	public static readonly int TrashItem;

	[Cpp2IlInjected.Token(Token = "0x40055CA")]
	public static readonly int Bank3_0;

	[Cpp2IlInjected.Token(Token = "0x40055CB")]
	public static readonly int Bank4_0;

	[Cpp2IlInjected.Token(Token = "0x40055CC")]
	public static readonly int Loadout1_Armor_0;

	[Cpp2IlInjected.Token(Token = "0x40055CD")]
	public static readonly int Loadout1_Dye_0;

	[Cpp2IlInjected.Token(Token = "0x40055CE")]
	public static readonly int Loadout2_Armor_0;

	[Cpp2IlInjected.Token(Token = "0x40055CF")]
	public static readonly int Loadout2_Dye_0;

	[Cpp2IlInjected.Token(Token = "0x40055D0")]
	public static readonly int Loadout3_Armor_0;

	[Cpp2IlInjected.Token(Token = "0x40055D1")]
	public static readonly int Loadout3_Dye_0;

	[Cpp2IlInjected.Token(Token = "0x40055D2")]
	public static bool[] CanRelay;

	[Cpp2IlInjected.Token(Token = "0x40055D3")]
	private static int _nextSlotId;

	[Cpp2IlInjected.Token(Token = "0x60030A5")]
	[Cpp2IlInjected.Address(RVA = "0x146874C", Offset = "0x146874C", VA = "0x146874C")]
	static PlayerItemSlotID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030A6")]
	[Cpp2IlInjected.Address(RVA = "0x1468954", Offset = "0x1468954", VA = "0x1468954")]
	private static int AllocateSlots(int amount, bool canNetRelay)
	{
		return default(int);
	}
}
