using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000690")]
public class BirthdayParty
{
	[Cpp2IlInjected.Token(Token = "0x4006DD8")]
	public static bool ManualParty;

	[Cpp2IlInjected.Token(Token = "0x4006DD9")]
	public static bool GenuineParty;

	[Cpp2IlInjected.Token(Token = "0x4006DDA")]
	public static int PartyDaysOnCooldown;

	[Cpp2IlInjected.Token(Token = "0x4006DDB")]
	public static List<int> CelebratingNPCs;

	[Cpp2IlInjected.Token(Token = "0x4006DDC")]
	private static bool _wasCelebrating;

	[Cpp2IlInjected.Token(Token = "0x1700079E")]
	public static bool PartyIsUp
	{
		[Cpp2IlInjected.Token(Token = "0x60041F5")]
		[Cpp2IlInjected.Address(RVA = "0xF4E740", Offset = "0xF4E740", VA = "0xF4E740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60041F6")]
	[Cpp2IlInjected.Address(RVA = "0xF4E7F8", Offset = "0xF4E7F8", VA = "0xF4E7F8")]
	public static void CheckMorning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041F7")]
	[Cpp2IlInjected.Address(RVA = "0xF4F42C", Offset = "0xF4F42C", VA = "0xF4F42C")]
	public static void CheckNight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041F8")]
	[Cpp2IlInjected.Address(RVA = "0xF4F700", Offset = "0xF4F700", VA = "0xF4F700")]
	private static bool CanNPCParty(NPC n)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60041F9")]
	[Cpp2IlInjected.Address(RVA = "0xF4E868", Offset = "0xF4E868", VA = "0xF4E868")]
	private static void NaturalAttempt()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041FA")]
	[Cpp2IlInjected.Address(RVA = "0xF4F858", Offset = "0xF4F858", VA = "0xF4F858")]
	public static void ToggleManualParty()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041FB")]
	[Cpp2IlInjected.Address(RVA = "0xF4F7D4", Offset = "0xF4F7D4", VA = "0xF4F7D4")]
	private static void CheckForAchievement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041FC")]
	[Cpp2IlInjected.Address(RVA = "0xF4FA9C", Offset = "0xF4FA9C", VA = "0xF4FA9C")]
	public static void WorldClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041FD")]
	[Cpp2IlInjected.Address(RVA = "0xF4FB58", Offset = "0xF4FB58", VA = "0xF4FB58")]
	public static void UpdateTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041FE")]
	[Cpp2IlInjected.Address(RVA = "0xF5027C", Offset = "0xF5027C", VA = "0xF5027C")]
	public BirthdayParty()
	{
	}
}
