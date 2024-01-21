using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000691")]
public class CultistRitual
{
	[Cpp2IlInjected.Token(Token = "0x4006DDD")]
	public static int delay;

	[Cpp2IlInjected.Token(Token = "0x4006DDE")]
	public static int recheck;

	[Cpp2IlInjected.Token(Token = "0x4006DDF")]
	public const int delayStart = 86400;

	[Cpp2IlInjected.Token(Token = "0x4006DE0")]
	public const int respawnDelay = 43200;

	[Cpp2IlInjected.Token(Token = "0x4006DE1")]
	private const int timePerCultist = 3600;

	[Cpp2IlInjected.Token(Token = "0x4006DE2")]
	private const int recheckStart = 600;

	[Cpp2IlInjected.Token(Token = "0x6004200")]
	[Cpp2IlInjected.Address(RVA = "0xF50A3C", Offset = "0xF50A3C", VA = "0xF50A3C")]
	public static void UpdateTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004201")]
	[Cpp2IlInjected.Address(RVA = "0xF50DAC", Offset = "0xF50DAC", VA = "0xF50DAC")]
	public static void CultistSlain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004202")]
	[Cpp2IlInjected.Address(RVA = "0xF50E0C", Offset = "0xF50E0C", VA = "0xF50E0C")]
	public static void TabletDestroyed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004203")]
	[Cpp2IlInjected.Address(RVA = "0xF50C40", Offset = "0xF50C40", VA = "0xF50C40")]
	public static void TrySpawning(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004204")]
	[Cpp2IlInjected.Address(RVA = "0xF50E68", Offset = "0xF50E68", VA = "0xF50E68")]
	private static bool CheckRitual(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004205")]
	[Cpp2IlInjected.Address(RVA = "0xF510B0", Offset = "0xF510B0", VA = "0xF510B0")]
	public static bool CheckFloor(Vector2 Center, out Point[] spawnPoints)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004206")]
	[Cpp2IlInjected.Address(RVA = "0xF51454", Offset = "0xF51454", VA = "0xF51454")]
	public CultistRitual()
	{
	}
}
