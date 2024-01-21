using Cpp2IlInjected;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000709")]
public class NebulaPillarBigProgressBar : LunarPillarBigProgessBar
{
	[Cpp2IlInjected.Token(Token = "0x60045F6")]
	[Cpp2IlInjected.Address(RVA = "0x118198C", Offset = "0x118198C", VA = "0x118198C", Slot = "6")]
	internal override float GetCurrentShieldValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60045F7")]
	[Cpp2IlInjected.Address(RVA = "0x1181A0C", Offset = "0x1181A0C", VA = "0x1181A0C", Slot = "7")]
	internal override float GetMaxShieldValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60045F8")]
	[Cpp2IlInjected.Address(RVA = "0x1181A8C", Offset = "0x1181A8C", VA = "0x1181A8C", Slot = "8")]
	internal override bool IsPlayerInCombatArea()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045F9")]
	[Cpp2IlInjected.Address(RVA = "0x117F760", Offset = "0x117F760", VA = "0x117F760")]
	public NebulaPillarBigProgressBar()
	{
	}
}
