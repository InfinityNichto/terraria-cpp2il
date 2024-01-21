using Cpp2IlInjected;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000693")]
public class LanternNight
{
	[Cpp2IlInjected.Token(Token = "0x4006DF9")]
	public static bool ManualLanterns;

	[Cpp2IlInjected.Token(Token = "0x4006DFA")]
	public static bool GenuineLanterns;

	[Cpp2IlInjected.Token(Token = "0x4006DFB")]
	public static bool NextNightIsLanternNight;

	[Cpp2IlInjected.Token(Token = "0x4006DFC")]
	public static int LanternNightsOnCooldown;

	[Cpp2IlInjected.Token(Token = "0x4006DFD")]
	private static bool _wasLanternNight;

	[Cpp2IlInjected.Token(Token = "0x170007A6")]
	public static bool LanternsUp
	{
		[Cpp2IlInjected.Token(Token = "0x6004247")]
		[Cpp2IlInjected.Address(RVA = "0xF5D118", Offset = "0xF5D118", VA = "0xF5D118")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004248")]
	[Cpp2IlInjected.Address(RVA = "0xF5D188", Offset = "0xF5D188", VA = "0xF5D188")]
	public static void CheckMorning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004249")]
	[Cpp2IlInjected.Address(RVA = "0xF5D204", Offset = "0xF5D204", VA = "0xF5D204")]
	public static void CheckNight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600424A")]
	[Cpp2IlInjected.Address(RVA = "0xF5D3BC", Offset = "0xF5D3BC", VA = "0xF5D3BC")]
	public static bool LanternsCanPersist()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600424B")]
	[Cpp2IlInjected.Address(RVA = "0xF5D444", Offset = "0xF5D444", VA = "0xF5D444")]
	public static bool LanternsCanStart()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600424C")]
	[Cpp2IlInjected.Address(RVA = "0xF5D5A4", Offset = "0xF5D5A4", VA = "0xF5D5A4")]
	private static bool BossIsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600424D")]
	[Cpp2IlInjected.Address(RVA = "0xF5D208", Offset = "0xF5D208", VA = "0xF5D208")]
	private static void NaturalAttempt()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600424E")]
	[Cpp2IlInjected.Address(RVA = "0xF5D66C", Offset = "0xF5D66C", VA = "0xF5D66C")]
	public static void ToggleManualLanterns()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600424F")]
	[Cpp2IlInjected.Address(RVA = "0xF5D7BC", Offset = "0xF5D7BC", VA = "0xF5D7BC")]
	public static void WorldClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004250")]
	[Cpp2IlInjected.Address(RVA = "0xF5D838", Offset = "0xF5D838", VA = "0xF5D838")]
	public static void UpdateTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004251")]
	[Cpp2IlInjected.Address(RVA = "0xF5DBDC", Offset = "0xF5DBDC", VA = "0xF5DBDC")]
	public LanternNight()
	{
	}
}
