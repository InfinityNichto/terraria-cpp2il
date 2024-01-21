using Cpp2IlInjected;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x200070A")]
public class StardustPillarBigProgressBar : LunarPillarBigProgessBar
{
	[Cpp2IlInjected.Token(Token = "0x60045FA")]
	[Cpp2IlInjected.Address(RVA = "0x118217C", Offset = "0x118217C", VA = "0x118217C", Slot = "6")]
	internal override float GetCurrentShieldValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60045FB")]
	[Cpp2IlInjected.Address(RVA = "0x11821FC", Offset = "0x11821FC", VA = "0x11821FC", Slot = "7")]
	internal override float GetMaxShieldValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60045FC")]
	[Cpp2IlInjected.Address(RVA = "0x118227C", Offset = "0x118227C", VA = "0x118227C", Slot = "8")]
	internal override bool IsPlayerInCombatArea()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045FD")]
	[Cpp2IlInjected.Address(RVA = "0x117F768", Offset = "0x117F768", VA = "0x117F768")]
	public StardustPillarBigProgressBar()
	{
	}
}
