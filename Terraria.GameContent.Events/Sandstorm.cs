using Cpp2IlInjected;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000697")]
public class Sandstorm
{
	[Cpp2IlInjected.Token(Token = "0x4006E09")]
	private const int SANDSTORM_DURATION_MINIMUM = 28800;

	[Cpp2IlInjected.Token(Token = "0x4006E0A")]
	private const int SANDSTORM_DURATION_MAXIMUM = 86400;

	[Cpp2IlInjected.Token(Token = "0x4006E0B")]
	public static bool Happening;

	[Cpp2IlInjected.Token(Token = "0x4006E0C")]
	public static int TimeLeft;

	[Cpp2IlInjected.Token(Token = "0x4006E0D")]
	public static float Severity;

	[Cpp2IlInjected.Token(Token = "0x4006E0E")]
	public static float IntendedSeverity;

	[Cpp2IlInjected.Token(Token = "0x4006E0F")]
	private static bool _effectsUp;

	[Cpp2IlInjected.Token(Token = "0x600426E")]
	[Cpp2IlInjected.Address(RVA = "0xF61824", Offset = "0xF61824", VA = "0xF61824")]
	private static bool HasSufficientWind()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600426F")]
	[Cpp2IlInjected.Address(RVA = "0xF618F4", Offset = "0xF618F4", VA = "0xF618F4")]
	public static void WorldClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004270")]
	[Cpp2IlInjected.Address(RVA = "0xF61950", Offset = "0xF61950", VA = "0xF61950")]
	public static void UpdateTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004271")]
	[Cpp2IlInjected.Address(RVA = "0xF61D34", Offset = "0xF61D34", VA = "0xF61D34")]
	private static void ChangeSeverityIntentions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004272")]
	[Cpp2IlInjected.Address(RVA = "0xF61F8C", Offset = "0xF61F8C", VA = "0xF61F8C")]
	private static void UpdateSeverity()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004273")]
	[Cpp2IlInjected.Address(RVA = "0xF61C7C", Offset = "0xF61C7C", VA = "0xF61C7C")]
	private static void StartSandstorm()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004274")]
	[Cpp2IlInjected.Address(RVA = "0xF61C10", Offset = "0xF61C10", VA = "0xF61C10")]
	private static void StopSandstorm()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004275")]
	[Cpp2IlInjected.Address(RVA = "0xF620E8", Offset = "0xF620E8", VA = "0xF620E8")]
	public static void HandleEffectAndSky(bool toState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004276")]
	[Cpp2IlInjected.Address(RVA = "0xF627BC", Offset = "0xF627BC", VA = "0xF627BC")]
	public static bool ShouldSandstormDustPersist()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004277")]
	[Cpp2IlInjected.Address(RVA = "0xF6291C", Offset = "0xF6291C", VA = "0xF6291C")]
	public static void EmitDust()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004278")]
	[Cpp2IlInjected.Address(RVA = "0xF639DC", Offset = "0xF639DC", VA = "0xF639DC")]
	public Sandstorm()
	{
	}
}
