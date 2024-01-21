using System.IO;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200033D")]
public class EquipmentLoadout : IFixLoadedData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002ECF")]
	public Item[] Armor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002ED0")]
	public Item[] Dye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002ED1")]
	public bool[] Hide;

	[Cpp2IlInjected.Token(Token = "0x6002703")]
	[Cpp2IlInjected.Address(RVA = "0x132E354", Offset = "0x132E354", VA = "0x132E354")]
	public EquipmentLoadout()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002704")]
	[Cpp2IlInjected.Address(RVA = "0x132E3D8", Offset = "0x132E3D8", VA = "0x132E3D8")]
	private Item[] CreateItemArray(int length)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002705")]
	[Cpp2IlInjected.Address(RVA = "0x132E4A0", Offset = "0x132E4A0", VA = "0x132E4A0")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002706")]
	[Cpp2IlInjected.Address(RVA = "0x132E578", Offset = "0x132E578", VA = "0x132E578")]
	public void Deserialize(BinaryReader reader, int gameVersion)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002707")]
	[Cpp2IlInjected.Address(RVA = "0x132E650", Offset = "0x132E650", VA = "0x132E650")]
	public void Swap(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002708")]
	[Cpp2IlInjected.Address(RVA = "0x132E810", Offset = "0x132E810", VA = "0x132E810")]
	public void TryDroppingItems(Player player, IEntitySource source)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002709")]
	[Cpp2IlInjected.Address(RVA = "0x132E8A8", Offset = "0x132E8A8", VA = "0x132E8A8", Slot = "4")]
	public void FixLoadedData()
	{
	}
}
