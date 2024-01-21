using Cpp2IlInjected;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000707")]
public class SolarFlarePillarBigProgressBar : LunarPillarBigProgessBar
{
	[Cpp2IlInjected.Token(Token = "0x60045EE")]
	[Cpp2IlInjected.Address(RVA = "0x1182000", Offset = "0x1182000", VA = "0x1182000", Slot = "6")]
	internal override float GetCurrentShieldValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60045EF")]
	[Cpp2IlInjected.Address(RVA = "0x1182080", Offset = "0x1182080", VA = "0x1182080", Slot = "7")]
	internal override float GetMaxShieldValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60045F0")]
	[Cpp2IlInjected.Address(RVA = "0x1182100", Offset = "0x1182100", VA = "0x1182100", Slot = "8")]
	internal override bool IsPlayerInCombatArea()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045F1")]
	[Cpp2IlInjected.Address(RVA = "0x117F750", Offset = "0x117F750", VA = "0x117F750")]
	public SolarFlarePillarBigProgressBar()
	{
	}
}
