using Cpp2IlInjected;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000695")]
public class CreditsRollEvent
{
	[Cpp2IlInjected.Token(Token = "0x4006E03")]
	private const int MAX_TIME_FOR_CREDITS_ROLL_IN_FRAMES = 28800;

	[Cpp2IlInjected.Token(Token = "0x4006E04")]
	private static int _creditsRollRemainingTime;

	[Cpp2IlInjected.Token(Token = "0x170007A7")]
	public static bool IsEventOngoing
	{
		[Cpp2IlInjected.Token(Token = "0x600425B")]
		[Cpp2IlInjected.Address(RVA = "0xF50400", Offset = "0xF50400", VA = "0xF50400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600425C")]
	[Cpp2IlInjected.Address(RVA = "0xF50484", Offset = "0xF50484", VA = "0xF50484")]
	public static void TryStartingCreditsRoll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600425D")]
	[Cpp2IlInjected.Address(RVA = "0xF506B0", Offset = "0xF506B0", VA = "0xF506B0")]
	public static void SendCreditsRollRemainingTimeToPlayer(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600425E")]
	[Cpp2IlInjected.Address(RVA = "0xF50814", Offset = "0xF50814", VA = "0xF50814")]
	public static void UpdateTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600425F")]
	[Cpp2IlInjected.Address(RVA = "0xF508E8", Offset = "0xF508E8", VA = "0xF508E8")]
	public static void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004260")]
	[Cpp2IlInjected.Address(RVA = "0xF50964", Offset = "0xF50964", VA = "0xF50964")]
	public static void SetRemainingTimeDirect(int time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004261")]
	[Cpp2IlInjected.Address(RVA = "0xF50A30", Offset = "0xF50A30", VA = "0xF50A30")]
	public CreditsRollEvent()
	{
	}
}
