using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200054E")]
public class HairstyleUnlocksHelper
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068E7")]
	public List<int> AvailableHairstyles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40068E8")]
	private bool _defeatedMartians;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40068E9")]
	private bool _defeatedMoonlord;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x40068EA")]
	private bool _defeatedPlantera;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x40068EB")]
	private bool _isAtStylist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40068EC")]
	private bool _isAtCharacterCreation;

	[Cpp2IlInjected.Token(Token = "0x60039F7")]
	[Cpp2IlInjected.Address(RVA = "0xE70A90", Offset = "0xE70A90", VA = "0xE70A90")]
	public void UpdateUnlocks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039F8")]
	[Cpp2IlInjected.Address(RVA = "0xE70AB4", Offset = "0xE70AB4", VA = "0xE70AB4")]
	private bool ListWarrantsRemake()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039F9")]
	[Cpp2IlInjected.Address(RVA = "0xE70D6C", Offset = "0xE70D6C", VA = "0xE70D6C")]
	private void RebuildList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039FA")]
	[Cpp2IlInjected.Address(RVA = "0xE710BC", Offset = "0xE710BC", VA = "0xE710BC")]
	public HairstyleUnlocksHelper()
	{
	}
}
