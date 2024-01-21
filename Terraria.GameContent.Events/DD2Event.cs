using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000692")]
public class DD2Event
{
	[Cpp2IlInjected.Token(Token = "0x4006DE3")]
	public static bool DownedInvasionT1;

	[Cpp2IlInjected.Token(Token = "0x4006DE4")]
	public static bool DownedInvasionT2;

	[Cpp2IlInjected.Token(Token = "0x4006DE5")]
	public static bool DownedInvasionT3;

	[Cpp2IlInjected.Token(Token = "0x4006DE6")]
	public static bool LostThisRun;

	[Cpp2IlInjected.Token(Token = "0x4006DE7")]
	public static bool WonThisRun;

	[Cpp2IlInjected.Token(Token = "0x4006DE8")]
	public static int LaneSpawnRate;

	[Cpp2IlInjected.Token(Token = "0x4006DE9")]
	private static bool _downedDarkMageT1;

	[Cpp2IlInjected.Token(Token = "0x4006DEA")]
	private static bool _downedOgreT2;

	[Cpp2IlInjected.Token(Token = "0x4006DEB")]
	private static bool _spawnedBetsyT3;

	[Cpp2IlInjected.Token(Token = "0x4006DEC")]
	public static bool Ongoing;

	[Cpp2IlInjected.Token(Token = "0x4006DED")]
	public static Rectangle ArenaHitbox;

	[Cpp2IlInjected.Token(Token = "0x4006DEE")]
	private static int _arenaHitboxingCooldown;

	[Cpp2IlInjected.Token(Token = "0x4006DEF")]
	public static int OngoingDifficulty;

	[Cpp2IlInjected.Token(Token = "0x4006DF0")]
	private static List<Vector2> _deadGoblinSpots;

	[Cpp2IlInjected.Token(Token = "0x4006DF1")]
	private static int _crystalsDropping_lastWave;

	[Cpp2IlInjected.Token(Token = "0x4006DF2")]
	private static int _crystalsDropping_toDrop;

	[Cpp2IlInjected.Token(Token = "0x4006DF3")]
	private static int _crystalsDropping_alreadyDropped;

	[Cpp2IlInjected.Token(Token = "0x4006DF4")]
	private static readonly Color INFO_NEW_WAVE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x4006DF5")]
	private static readonly Color INFO_START_INVASION_COLOR;

	[Cpp2IlInjected.Token(Token = "0x4006DF6")]
	private static readonly Color INFO_FAILURE_INVASION_COLOR;

	[Cpp2IlInjected.Token(Token = "0x4006DF7")]
	private const int INVASION_ID = 3;

	[Cpp2IlInjected.Token(Token = "0x4006DF8")]
	private static int _timeLeftUntilSpawningBegins;

	[Cpp2IlInjected.Token(Token = "0x1700079F")]
	public static bool ReadyToFindBartender
	{
		[Cpp2IlInjected.Token(Token = "0x6004207")]
		[Cpp2IlInjected.Address(RVA = "0xF5145C", Offset = "0xF5145C", VA = "0xF5145C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007A0")]
	public static bool DownedInvasionAnyDifficulty
	{
		[Cpp2IlInjected.Token(Token = "0x6004208")]
		[Cpp2IlInjected.Address(RVA = "0xF514D4", Offset = "0xF514D4", VA = "0xF514D4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007A1")]
	public static int TimeLeftBetweenWaves
	{
		[Cpp2IlInjected.Token(Token = "0x6004209")]
		[Cpp2IlInjected.Address(RVA = "0xF515BC", Offset = "0xF515BC", VA = "0xF515BC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600420A")]
		[Cpp2IlInjected.Address(RVA = "0xF51634", Offset = "0xF51634", VA = "0xF51634")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007A2")]
	public static bool EnemySpawningIsOnHold
	{
		[Cpp2IlInjected.Token(Token = "0x600420B")]
		[Cpp2IlInjected.Address(RVA = "0xF516B0", Offset = "0xF516B0", VA = "0xF516B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007A3")]
	public static bool EnemiesShouldChasePlayers
	{
		[Cpp2IlInjected.Token(Token = "0x600420C")]
		[Cpp2IlInjected.Address(RVA = "0xF51730", Offset = "0xF51730", VA = "0xF51730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007A4")]
	public static bool ReadyForTier2
	{
		[Cpp2IlInjected.Token(Token = "0x6004218")]
		[Cpp2IlInjected.Address(RVA = "0xF53C84", Offset = "0xF53C84", VA = "0xF53C84")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007A5")]
	public static bool ReadyForTier3
	{
		[Cpp2IlInjected.Token(Token = "0x6004219")]
		[Cpp2IlInjected.Address(RVA = "0xF53D4C", Offset = "0xF53D4C", VA = "0xF53D4C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600420D")]
	[Cpp2IlInjected.Address(RVA = "0xF517A0", Offset = "0xF517A0", VA = "0xF517A0")]
	public static void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600420E")]
	[Cpp2IlInjected.Address(RVA = "0xF51870", Offset = "0xF51870", VA = "0xF51870")]
	public static void Load(BinaryReader reader, int gameVersionNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600420F")]
	[Cpp2IlInjected.Address(RVA = "0xF51A10", Offset = "0xF51A10", VA = "0xF51A10")]
	public static void ResetProgressEntirely()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004210")]
	[Cpp2IlInjected.Address(RVA = "0xF51AD0", Offset = "0xF51AD0", VA = "0xF51AD0")]
	public static void ReportEventProgress()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004211")]
	[Cpp2IlInjected.Address(RVA = "0xF51D3C", Offset = "0xF51D3C", VA = "0xF51D3C")]
	public static void SyncInvasionProgress(int toWho)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004212")]
	[Cpp2IlInjected.Address(RVA = "0xF51E60", Offset = "0xF51E60", VA = "0xF51E60")]
	public static void SpawnNPC(ref int newNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004213")]
	[Cpp2IlInjected.Address(RVA = "0xF51E64", Offset = "0xF51E64", VA = "0xF51E64")]
	public static void UpdateTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004214")]
	[Cpp2IlInjected.Address(RVA = "0xF52DD0", Offset = "0xF52DD0", VA = "0xF52DD0")]
	public static void StartInvasion(int difficultyOverride = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004215")]
	[Cpp2IlInjected.Address(RVA = "0xF526E0", Offset = "0xF526E0", VA = "0xF526E0")]
	public static void StopInvasion(bool win = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004216")]
	[Cpp2IlInjected.Address(RVA = "0xF53754", Offset = "0xF53754", VA = "0xF53754")]
	private static void WinInvasionInternal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004217")]
	[Cpp2IlInjected.Address(RVA = "0xF52C24", Offset = "0xF52C24", VA = "0xF52C24")]
	public static void LoseInvasionMessage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600421A")]
	[Cpp2IlInjected.Address(RVA = "0xF5327C", Offset = "0xF5327C", VA = "0xF5327C")]
	private static void FindProperDifficulty()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600421B")]
	[Cpp2IlInjected.Address(RVA = "0xF53E14", Offset = "0xF53E14", VA = "0xF53E14")]
	public static void CheckProgress(int slainMonsterID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600421C")]
	[Cpp2IlInjected.Address(RVA = "0xF5493C", Offset = "0xF5493C", VA = "0xF5493C")]
	public static void StartVictoryScene()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600421D")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF54BA0", VA = "0xF54BA0")]
	public static void ReportLoss()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600421E")]
	[Cpp2IlInjected.Address(RVA = "0xF51BBC", Offset = "0xF51BBC", VA = "0xF51BBC")]
	private static void GetInvasionStatus(out int currentWave, out int requiredKillCount, out int currentKillCount, bool currentlyInCheckProgress = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600421F")]
	[Cpp2IlInjected.Address(RVA = "0xF528F0", Offset = "0xF528F0", VA = "0xF528F0")]
	private static short[] GetEnemiesForWave(int wave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004220")]
	[Cpp2IlInjected.Address(RVA = "0xF5483C", Offset = "0xF5483C", VA = "0xF5483C")]
	private static int GetMonsterPointsWorth(int slainMonsterID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004221")]
	[Cpp2IlInjected.Address(RVA = "0xF55ED4", Offset = "0xF55ED4", VA = "0xF55ED4")]
	public static void SpawnMonsterFromGate(Vector2 gateBottom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004222")]
	[Cpp2IlInjected.Address(RVA = "0xF5AA18", Offset = "0xF5AA18", VA = "0xF5AA18")]
	public static void SummonCrystal(int x, int y, int whoAsks)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004223")]
	[Cpp2IlInjected.Address(RVA = "0xF5AB58", Offset = "0xF5AB58", VA = "0xF5AB58")]
	public static void SummonCrystalDirect(int x, int y, int whoAsks)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004224")]
	[Cpp2IlInjected.Address(RVA = "0xF5AF88", Offset = "0xF5AF88", VA = "0xF5AF88")]
	public static bool WouldFailSpawningHere(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004225")]
	[Cpp2IlInjected.Address(RVA = "0xF5B09C", Offset = "0xF5B09C", VA = "0xF5B09C")]
	public static void FailureMessage(int client)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004226")]
	[Cpp2IlInjected.Address(RVA = "0xF53634", Offset = "0xF53634", VA = "0xF53634")]
	public static void WipeEntities()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004227")]
	[Cpp2IlInjected.Address(RVA = "0xF53390", Offset = "0xF53390", VA = "0xF53390")]
	public static void ClearAllTowersInGame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004228")]
	[Cpp2IlInjected.Address(RVA = "0xF5B2E4", Offset = "0xF5B2E4", VA = "0xF5B2E4")]
	public static void ClearAllDD2HostilesInGame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004229")]
	[Cpp2IlInjected.Address(RVA = "0xF5B6D8", Offset = "0xF5B6D8", VA = "0xF5B6D8")]
	public static void ClearAllDD2EnergyCrystalsInGame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600422A")]
	[Cpp2IlInjected.Address(RVA = "0xF5B4C8", Offset = "0xF5B4C8", VA = "0xF5B4C8")]
	public static void ClearAllDD2EnergyCrystalsInChests()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600422B")]
	[Cpp2IlInjected.Address(RVA = "0xF5B820", Offset = "0xF5B820", VA = "0xF5B820")]
	public static void AnnounceGoblinDeath(NPC n)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600422C")]
	[Cpp2IlInjected.Address(RVA = "0xF5B8D0", Offset = "0xF5B8D0", VA = "0xF5B8D0")]
	public static bool CanRaiseGoblinsHere(Vector2 spot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600422D")]
	[Cpp2IlInjected.Address(RVA = "0xF5BACC", Offset = "0xF5BACC", VA = "0xF5BACC")]
	public static void RaiseGoblins(NPC caller, Vector2 spot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600422E")]
	[Cpp2IlInjected.Address(RVA = "0xF5C1E8", Offset = "0xF5C1E8", VA = "0xF5C1E8")]
	public static void FindArenaHitbox()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600422F")]
	[Cpp2IlInjected.Address(RVA = "0xF5C53C", Offset = "0xF5C53C", VA = "0xF5C53C")]
	public static bool ShouldBlockBuilding(Vector2 worldPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004230")]
	[Cpp2IlInjected.Address(RVA = "0xF53B38", Offset = "0xF53B38", VA = "0xF53B38")]
	public static void DropMedals(int numberOfMedals)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004231")]
	[Cpp2IlInjected.Address(RVA = "0xF5C610", Offset = "0xF5C610", VA = "0xF5C610")]
	public static bool ShouldDropCrystals()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004232")]
	[Cpp2IlInjected.Address(RVA = "0xF529F0", Offset = "0xF529F0", VA = "0xF529F0")]
	private static void SummonBetsy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004233")]
	[Cpp2IlInjected.Address(RVA = "0xF5ADA4", Offset = "0xF5ADA4", VA = "0xF5ADA4")]
	private static void DropStarterCrystals()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004234")]
	[Cpp2IlInjected.Address(RVA = "0xF534E0", Offset = "0xF534E0", VA = "0xF534E0")]
	private static void SetEnemySpawningOnHold(int forHowLong)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004235")]
	[Cpp2IlInjected.Address(RVA = "0xF557C4", Offset = "0xF557C4", VA = "0xF557C4")]
	private static short[] Difficulty_1_GetEnemiesForWave(int wave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004236")]
	[Cpp2IlInjected.Address(RVA = "0xF54F68", Offset = "0xF54F68", VA = "0xF54F68")]
	private static int Difficulty_1_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004237")]
	[Cpp2IlInjected.Address(RVA = "0xF59BD8", Offset = "0xF59BD8", VA = "0xF59BD8")]
	private static void Difficulty_1_SpawnMonsterFromGate(Vector2 gateBottom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004238")]
	[Cpp2IlInjected.Address(RVA = "0xF55CF4", Offset = "0xF55CF4", VA = "0xF55CF4")]
	private static int Difficulty_1_GetMonsterPointsWorth(int slainMonsterID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004239")]
	[Cpp2IlInjected.Address(RVA = "0xF55480", Offset = "0xF55480", VA = "0xF55480")]
	private static short[] Difficulty_2_GetEnemiesForWave(int wave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600423A")]
	[Cpp2IlInjected.Address(RVA = "0xF54DF8", Offset = "0xF54DF8", VA = "0xF54DF8")]
	private static int Difficulty_2_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600423B")]
	[Cpp2IlInjected.Address(RVA = "0xF55B14", Offset = "0xF55B14", VA = "0xF55B14")]
	private static int Difficulty_2_GetMonsterPointsWorth(int slainMonsterID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600423C")]
	[Cpp2IlInjected.Address(RVA = "0xF57D70", Offset = "0xF57D70", VA = "0xF57D70")]
	private static void Difficulty_2_SpawnMonsterFromGate(Vector2 gateBottom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600423D")]
	[Cpp2IlInjected.Address(RVA = "0xF5510C", Offset = "0xF5510C", VA = "0xF5510C")]
	private static short[] Difficulty_3_GetEnemiesForWave(int wave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600423E")]
	[Cpp2IlInjected.Address(RVA = "0xF54C24", Offset = "0xF54C24", VA = "0xF54C24")]
	private static int Difficulty_3_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600423F")]
	[Cpp2IlInjected.Address(RVA = "0xF55A1C", Offset = "0xF55A1C", VA = "0xF55A1C")]
	private static int Difficulty_3_GetMonsterPointsWorth(int slainMonsterID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004240")]
	[Cpp2IlInjected.Address(RVA = "0xF55FE8", Offset = "0xF55FE8", VA = "0xF55FE8")]
	private static void Difficulty_3_SpawnMonsterFromGate(Vector2 gateBottom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004241")]
	[Cpp2IlInjected.Address(RVA = "0xF5CAD4", Offset = "0xF5CAD4", VA = "0xF5CAD4")]
	public static bool IsStandActive(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004242")]
	[Cpp2IlInjected.Address(RVA = "0xF5CC50", Offset = "0xF5CC50", VA = "0xF5CC50")]
	public static void RequestToSkipWaitTime(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004243")]
	[Cpp2IlInjected.Address(RVA = "0xF5CEAC", Offset = "0xF5CEAC", VA = "0xF5CEAC")]
	public static void AttemptToSkipWaitTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004244")]
	[Cpp2IlInjected.Address(RVA = "0xF5CA70", Offset = "0xF5CA70", VA = "0xF5CA70")]
	private static IEntitySource GetSpawnSource_OldOnesArmy()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004245")]
	[Cpp2IlInjected.Address(RVA = "0xF5CFE8", Offset = "0xF5CFE8", VA = "0xF5CFE8")]
	public DD2Event()
	{
	}
}
