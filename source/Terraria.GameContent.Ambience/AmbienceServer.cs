using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Ambience;

[Cpp2IlInjected.Token(Token = "0x200070E")]
public class AmbienceServer
{
	[Cpp2IlInjected.Token(Token = "0x2000AC3")]
	public struct AmbienceSpawnInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F4E")]
		public SkyEntityType skyEntityType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008F4F")]
		public int targetPlayer;
	}

	[Cpp2IlInjected.Token(Token = "0x400712F")]
	private const int MINIMUM_SECONDS_BETWEEN_SPAWNS = 10;

	[Cpp2IlInjected.Token(Token = "0x4007130")]
	private const int MAXIMUM_SECONDS_BETWEEN_SPAWNS = 120;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007131")]
	private readonly Dictionary<SkyEntityType, Func<bool>> _spawnConditions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007132")]
	private readonly Dictionary<SkyEntityType, Func<Player, bool>> _secondarySpawnConditionsPerPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007133")]
	private int _updatesUntilNextAttempt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007134")]
	private List<AmbienceSpawnInfo> _forcedSpawns;

	[Cpp2IlInjected.Token(Token = "0x600460A")]
	[Cpp2IlInjected.Address(RVA = "0xFACFC0", Offset = "0xFACFC0", VA = "0xFACFC0")]
	private static bool IsSunnyDay()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600460B")]
	[Cpp2IlInjected.Address(RVA = "0xFAD0A8", Offset = "0xFAD0A8", VA = "0xFAD0A8")]
	private static bool IsSunset()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600460C")]
	[Cpp2IlInjected.Address(RVA = "0xFAD174", Offset = "0xFAD174", VA = "0xFAD174")]
	private static bool IsCalmNight()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600460D")]
	[Cpp2IlInjected.Address(RVA = "0xFAD2BC", Offset = "0xFAD2BC", VA = "0xFAD2BC")]
	public AmbienceServer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600460E")]
	[Cpp2IlInjected.Address(RVA = "0xFAE688", Offset = "0xFAE688", VA = "0xFAE688")]
	private bool IsPlayerAtRightHeightForType(SkyEntityType type, Player plr)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600460F")]
	[Cpp2IlInjected.Address(RVA = "0xFAE7FC", Offset = "0xFAE7FC", VA = "0xFAE7FC")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004610")]
	[Cpp2IlInjected.Address(RVA = "0xFAE5DC", Offset = "0xFAE5DC", VA = "0xFAE5DC")]
	public void ResetSpawnTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004611")]
	[Cpp2IlInjected.Address(RVA = "0xFAF3AC", Offset = "0xFAF3AC", VA = "0xFAF3AC")]
	public void ForceEntitySpawn(AmbienceSpawnInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004612")]
	[Cpp2IlInjected.Address(RVA = "0xFAEEC4", Offset = "0xFAEEC4", VA = "0xFAEEC4")]
	private void SpawnForcedEntities()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004613")]
	[Cpp2IlInjected.Address(RVA = "0xFAF038", Offset = "0xFAF038", VA = "0xFAF038")]
	private static void FindPlayerThatCanSeeBackgroundAmbience(out Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004614")]
	[Cpp2IlInjected.Address(RVA = "0xFAF418", Offset = "0xFAF418", VA = "0xFAF418")]
	private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbience(Player plr)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004615")]
	[Cpp2IlInjected.Address(RVA = "0xFAE748", Offset = "0xFAE748", VA = "0xFAE748")]
	private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky(Player plr)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004616")]
	[Cpp2IlInjected.Address(RVA = "0xFAE69C", Offset = "0xFAE69C", VA = "0xFAE69C")]
	private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(Player plr)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004617")]
	[Cpp2IlInjected.Address(RVA = "0xFAF2FC", Offset = "0xFAF2FC", VA = "0xFAF2FC")]
	private void SpawnForPlayer(Player player, SkyEntityType type)
	{
	}
}
