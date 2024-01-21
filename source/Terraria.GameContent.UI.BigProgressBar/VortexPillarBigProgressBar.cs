using Cpp2IlInjected;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000708")]
public class VortexPillarBigProgressBar : LunarPillarBigProgessBar
{
	[Cpp2IlInjected.Token(Token = "0x60045F2")]
	[Cpp2IlInjected.Address(RVA = "0x11825AC", Offset = "0x11825AC", VA = "0x11825AC", Slot = "6")]
	internal override float GetCurrentShieldValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60045F3")]
	[Cpp2IlInjected.Address(RVA = "0x118262C", Offset = "0x118262C", VA = "0x118262C", Slot = "7")]
	internal override float GetMaxShieldValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60045F4")]
	[Cpp2IlInjected.Address(RVA = "0x11826AC", Offset = "0x11826AC", VA = "0x11826AC", Slot = "8")]
	internal override bool IsPlayerInCombatArea()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045F5")]
	[Cpp2IlInjected.Address(RVA = "0x117F758", Offset = "0x117F758", VA = "0x117F758")]
	public VortexPillarBigProgressBar()
	{
	}
}
