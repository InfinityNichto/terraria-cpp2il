using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000548")]
public class DontStarveDarknessDamageDealer
{
	[Cpp2IlInjected.Token(Token = "0x40068CE")]
	public const int DARKNESS_HIT_TIMER_MAX_BEFORE_HIT = 60;

	[Cpp2IlInjected.Token(Token = "0x40068CF")]
	public static int darknessTimer;

	[Cpp2IlInjected.Token(Token = "0x40068D0")]
	public static int darknessHitTimer;

	[Cpp2IlInjected.Token(Token = "0x40068D1")]
	public static bool saidMessage;

	[Cpp2IlInjected.Token(Token = "0x40068D2")]
	public static bool lastFrameWasTooBright;

	[Cpp2IlInjected.Token(Token = "0x60039CF")]
	[Cpp2IlInjected.Address(RVA = "0xD772A8", Offset = "0xD772A8", VA = "0xD772A8")]
	public static void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039D0")]
	[Cpp2IlInjected.Address(RVA = "0xD77334", Offset = "0xD77334", VA = "0xD77334")]
	private static void ResetTimer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039D1")]
	[Cpp2IlInjected.Address(RVA = "0xD773C0", Offset = "0xD773C0", VA = "0xD773C0")]
	private static int GetDarknessDamagePerHit()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60039D2")]
	[Cpp2IlInjected.Address(RVA = "0xD773C8", Offset = "0xD773C8", VA = "0xD773C8")]
	private static int GetDarknessTimeBeforeStartingHits()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60039D3")]
	[Cpp2IlInjected.Address(RVA = "0xD773D0", Offset = "0xD773D0", VA = "0xD773D0")]
	private static int GetDarknessTimeForMessage()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60039D4")]
	[Cpp2IlInjected.Address(RVA = "0xD773D8", Offset = "0xD773D8", VA = "0xD773D8")]
	public static void Update(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039D5")]
	[Cpp2IlInjected.Address(RVA = "0xD77624", Offset = "0xD77624", VA = "0xD77624")]
	private static void UpdateDarknessState(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039D6")]
	[Cpp2IlInjected.Address(RVA = "0xD77934", Offset = "0xD77934", VA = "0xD77934")]
	private static bool IsPlayerSafe(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039D7")]
	[Cpp2IlInjected.Address(RVA = "0xD77BC4", Offset = "0xD77BC4", VA = "0xD77BC4")]
	public DontStarveDarknessDamageDealer()
	{
	}
}
