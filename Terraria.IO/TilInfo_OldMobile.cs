using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D6")]
public class TilInfo_OldMobile
{
	[Cpp2IlInjected.Token(Token = "0x6002FED")]
	[Cpp2IlInjected.Address(RVA = "0xE486CC", Offset = "0xE486CC", VA = "0xE486CC")]
	private void PatchFrameY(int release, int type, ref short frameY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FEE")]
	[Cpp2IlInjected.Address(RVA = "0xE486F4", Offset = "0xE486F4", VA = "0xE486F4")]
	private byte ConverTileColor(byte input)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FEF")]
	[Cpp2IlInjected.Address(RVA = "0xE48704", Offset = "0xE48704", VA = "0xE48704")]
	public bool Load(BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF0")]
	[Cpp2IlInjected.Address(RVA = "0xE490E4", Offset = "0xE490E4", VA = "0xE490E4")]
	private void CleanItemsStoredInTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF1")]
	[Cpp2IlInjected.Address(RVA = "0xE49C34", Offset = "0xE49C34", VA = "0xE49C34")]
	private void FixChairFrame(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF2")]
	[Cpp2IlInjected.Address(RVA = "0xE49270", Offset = "0xE49270", VA = "0xE49270")]
	private void CheckWeaponsRack(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF3")]
	[Cpp2IlInjected.Address(RVA = "0xE49D1C", Offset = "0xE49D1C", VA = "0xE49D1C")]
	public bool ItemFitsWeaponRack(Item i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF4")]
	[Cpp2IlInjected.Address(RVA = "0xE49D7C", Offset = "0xE49D7C", VA = "0xE49D7C")]
	public void PlaceWeapon(int x, int y, Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF5")]
	[Cpp2IlInjected.Address(RVA = "0xE494F0", Offset = "0xE494F0", VA = "0xE494F0")]
	private void CheckMannequin(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF6")]
	[Cpp2IlInjected.Address(RVA = "0xE4A134", Offset = "0xE4A134", VA = "0xE4A134")]
	public TilInfo_OldMobile()
	{
	}
}
