using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200031D")]
public class NPC : Entity
{
	[Cpp2IlInjected.Token(Token = "0x4002634")]
	public static int MoonLordCountdown;

	[Cpp2IlInjected.Token(Token = "0x4002635")]
	public static int immuneTime;

	[Cpp2IlInjected.Token(Token = "0x4002636")]
	public static int maxAI;

	[Cpp2IlInjected.Token(Token = "0x4002637")]
	public static int[] killCount;

	[Cpp2IlInjected.Token(Token = "0x4002638")]
	public static float waveKills;

	[Cpp2IlInjected.Token(Token = "0x4002639")]
	public static int waveNumber;

	[Cpp2IlInjected.Token(Token = "0x400263A")]
	public static bool taxCollector;

	[Cpp2IlInjected.Token(Token = "0x400263B")]
	public static bool freeCake;

	[Cpp2IlInjected.Token(Token = "0x400263C")]
	private static float gravity;

	[Cpp2IlInjected.Token(Token = "0x400263D")]
	public static int fireFlyFriendly;

	[Cpp2IlInjected.Token(Token = "0x400263E")]
	public static int fireFlyChance;

	[Cpp2IlInjected.Token(Token = "0x400263F")]
	public static int fireFlyMultiple;

	[Cpp2IlInjected.Token(Token = "0x4002640")]
	public static int butterflyChance;

	[Cpp2IlInjected.Token(Token = "0x4002641")]
	public static int golemBoss;

	[Cpp2IlInjected.Token(Token = "0x4002642")]
	public static int plantBoss;

	[Cpp2IlInjected.Token(Token = "0x4002643")]
	public static int crimsonBoss;

	[Cpp2IlInjected.Token(Token = "0x4002644")]
	public static int deerclopsBoss;

	[Cpp2IlInjected.Token(Token = "0x4002645")]
	public static int sWidth;

	[Cpp2IlInjected.Token(Token = "0x4002646")]
	public static int sHeight;

	[Cpp2IlInjected.Token(Token = "0x4002647")]
	private static int spawnRangeX;

	[Cpp2IlInjected.Token(Token = "0x4002648")]
	private static int spawnRangeY;

	[Cpp2IlInjected.Token(Token = "0x4002649")]
	public static int safeRangeX;

	[Cpp2IlInjected.Token(Token = "0x400264A")]
	public static int safeRangeY;

	[Cpp2IlInjected.Token(Token = "0x400264B")]
	private static int activeRangeX;

	[Cpp2IlInjected.Token(Token = "0x400264C")]
	private static int activeRangeY;

	[Cpp2IlInjected.Token(Token = "0x400264D")]
	private static int townRangeX;

	[Cpp2IlInjected.Token(Token = "0x400264E")]
	private static int townRangeY;

	[Cpp2IlInjected.Token(Token = "0x400264F")]
	private static bool noSpawnCycle;

	[Cpp2IlInjected.Token(Token = "0x4002650")]
	private static int activeTime;

	[Cpp2IlInjected.Token(Token = "0x4002651")]
	private static int defaultSpawnRate;

	[Cpp2IlInjected.Token(Token = "0x4002652")]
	private static int defaultMaxSpawns;

	[Cpp2IlInjected.Token(Token = "0x4002653")]
	public static bool savedTaxCollector;

	[Cpp2IlInjected.Token(Token = "0x4002654")]
	public static bool savedGoblin;

	[Cpp2IlInjected.Token(Token = "0x4002655")]
	public static bool savedWizard;

	[Cpp2IlInjected.Token(Token = "0x4002656")]
	public static bool savedMech;

	[Cpp2IlInjected.Token(Token = "0x4002657")]
	public static bool savedAngler;

	[Cpp2IlInjected.Token(Token = "0x4002658")]
	public static bool savedStylist;

	[Cpp2IlInjected.Token(Token = "0x4002659")]
	public static bool savedBartender;

	[Cpp2IlInjected.Token(Token = "0x400265A")]
	public static bool savedGolfer;

	[Cpp2IlInjected.Token(Token = "0x400265B")]
	public static bool boughtCat;

	[Cpp2IlInjected.Token(Token = "0x400265C")]
	public static bool boughtDog;

	[Cpp2IlInjected.Token(Token = "0x400265D")]
	public static bool boughtBunny;

	[Cpp2IlInjected.Token(Token = "0x400265E")]
	public static bool combatBookWasUsed;

	[Cpp2IlInjected.Token(Token = "0x400265F")]
	public static bool combatBookVolumeTwoWasUsed;

	[Cpp2IlInjected.Token(Token = "0x4002660")]
	public static bool peddlersSatchelWasUsed;

	[Cpp2IlInjected.Token(Token = "0x4002661")]
	public static bool downedBoss1;

	[Cpp2IlInjected.Token(Token = "0x4002662")]
	public static bool downedBoss2;

	[Cpp2IlInjected.Token(Token = "0x4002663")]
	public static bool downedBoss3;

	[Cpp2IlInjected.Token(Token = "0x4002664")]
	public static bool downedQueenBee;

	[Cpp2IlInjected.Token(Token = "0x4002665")]
	public static bool downedSlimeKing;

	[Cpp2IlInjected.Token(Token = "0x4002666")]
	public static bool downedGoblins;

	[Cpp2IlInjected.Token(Token = "0x4002667")]
	public static bool downedFrost;

	[Cpp2IlInjected.Token(Token = "0x4002668")]
	public static bool downedPirates;

	[Cpp2IlInjected.Token(Token = "0x4002669")]
	public static bool downedClown;

	[Cpp2IlInjected.Token(Token = "0x400266A")]
	public static bool downedPlantBoss;

	[Cpp2IlInjected.Token(Token = "0x400266B")]
	public static bool downedGolemBoss;

	[Cpp2IlInjected.Token(Token = "0x400266C")]
	public static bool downedMartians;

	[Cpp2IlInjected.Token(Token = "0x400266D")]
	public static bool downedFishron;

	[Cpp2IlInjected.Token(Token = "0x400266E")]
	public static bool downedHalloweenTree;

	[Cpp2IlInjected.Token(Token = "0x400266F")]
	public static bool downedHalloweenKing;

	[Cpp2IlInjected.Token(Token = "0x4002670")]
	public static bool downedChristmasIceQueen;

	[Cpp2IlInjected.Token(Token = "0x4002671")]
	public static bool downedChristmasTree;

	[Cpp2IlInjected.Token(Token = "0x4002672")]
	public static bool downedChristmasSantank;

	[Cpp2IlInjected.Token(Token = "0x4002673")]
	public static bool downedAncientCultist;

	[Cpp2IlInjected.Token(Token = "0x4002674")]
	public static bool downedMoonlord;

	[Cpp2IlInjected.Token(Token = "0x4002675")]
	public static bool downedTowerSolar;

	[Cpp2IlInjected.Token(Token = "0x4002676")]
	public static bool downedTowerVortex;

	[Cpp2IlInjected.Token(Token = "0x4002677")]
	public static bool downedTowerNebula;

	[Cpp2IlInjected.Token(Token = "0x4002678")]
	public static bool downedTowerStardust;

	[Cpp2IlInjected.Token(Token = "0x4002679")]
	public static bool downedEmpressOfLight;

	[Cpp2IlInjected.Token(Token = "0x400267A")]
	public static bool downedQueenSlime;

	[Cpp2IlInjected.Token(Token = "0x400267B")]
	public static bool downedDeerclops;

	[Cpp2IlInjected.Token(Token = "0x400267C")]
	public static int ShieldStrengthTowerSolar;

	[Cpp2IlInjected.Token(Token = "0x400267D")]
	public static int ShieldStrengthTowerVortex;

	[Cpp2IlInjected.Token(Token = "0x400267E")]
	public static int ShieldStrengthTowerNebula;

	[Cpp2IlInjected.Token(Token = "0x400267F")]
	public static int ShieldStrengthTowerStardust;

	[Cpp2IlInjected.Token(Token = "0x4002680")]
	public static int LunarShieldPowerNormal;

	[Cpp2IlInjected.Token(Token = "0x4002681")]
	public static int LunarShieldPowerExpert;

	[Cpp2IlInjected.Token(Token = "0x4002682")]
	public static bool TowerActiveSolar;

	[Cpp2IlInjected.Token(Token = "0x4002683")]
	public static bool TowerActiveVortex;

	[Cpp2IlInjected.Token(Token = "0x4002684")]
	public static bool TowerActiveNebula;

	[Cpp2IlInjected.Token(Token = "0x4002685")]
	public static bool TowerActiveStardust;

	[Cpp2IlInjected.Token(Token = "0x4002686")]
	public static bool LunarApocalypseIsUp;

	[Cpp2IlInjected.Token(Token = "0x4002687")]
	public static bool downedMechBossAny;

	[Cpp2IlInjected.Token(Token = "0x4002688")]
	public static bool downedMechBoss1;

	[Cpp2IlInjected.Token(Token = "0x4002689")]
	public static bool downedMechBoss2;

	[Cpp2IlInjected.Token(Token = "0x400268A")]
	public static bool downedMechBoss3;

	[Cpp2IlInjected.Token(Token = "0x400268B")]
	public static bool[] npcsFoundForCheckActive;

	[Cpp2IlInjected.Token(Token = "0x400268C")]
	public static int[] lazyNPCOwnedProjectileSearchArray;

	[Cpp2IlInjected.Token(Token = "0x400268D")]
	private static int spawnRate;

	[Cpp2IlInjected.Token(Token = "0x400268E")]
	private static int maxSpawns;

	[Cpp2IlInjected.Token(Token = "0x400268F")]
	public static CoinLossRevengeSystem RevengeManager;

	[Cpp2IlInjected.Token(Token = "0x4002690")]
	public static bool travelNPC;

	[Cpp2IlInjected.Token(Token = "0x4002691")]
	public static int[,] cavernMonsterType;

	[Cpp2IlInjected.Token(Token = "0x4002692")]
	private static bool EoCKilledToday;

	[Cpp2IlInjected.Token(Token = "0x4002693")]
	private static bool WoFKilledToday;

	[Cpp2IlInjected.Token(Token = "0x4002694")]
	public static bool fairyLog;

	[Cpp2IlInjected.Token(Token = "0x4002695")]
	private static int ignorePlayerInteractions;

	[Cpp2IlInjected.Token(Token = "0x4002696")]
	public static int ladyBugGoodLuckTime;

	[Cpp2IlInjected.Token(Token = "0x4002697")]
	public static int ladyBugBadLuckTime;

	[Cpp2IlInjected.Token(Token = "0x4002698")]
	private static int ladyBugRainTime;

	[Cpp2IlInjected.Token(Token = "0x4002699")]
	private static int maximumAmountOfTimesLadyBugRainCanStack;

	[Cpp2IlInjected.Token(Token = "0x400269A")]
	public static int offSetDelayTime;

	[Cpp2IlInjected.Token(Token = "0x400269B")]
	private const int NPC_TARGETS_START = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
	[Cpp2IlInjected.Token(Token = "0x400269C")]
	public bool IsABestiaryIconDummy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
	[Cpp2IlInjected.Token(Token = "0x400269D")]
	public bool ForcePartyHatOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400269E")]
	public float waterMovementSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400269F")]
	public float lavaMovementSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40026A0")]
	public float honeyMovementSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40026A1")]
	public float shimmerMovementSpeed;

	[Cpp2IlInjected.Token(Token = "0x40026A2")]
	public static readonly int[,,,] MoonLordAttacksArray;

	[Cpp2IlInjected.Token(Token = "0x40026A3")]
	public static readonly int[,] MoonLordAttacksArray2;

	[Cpp2IlInjected.Token(Token = "0x40026A4")]
	public static int MoonLordFightingDistance;

	[Cpp2IlInjected.Token(Token = "0x40026A5")]
	public static int MaxMoonLordCountdown;

	[Cpp2IlInjected.Token(Token = "0x40026A6")]
	public const int NaturalMoonlordCountdownTime = 3600;

	[Cpp2IlInjected.Token(Token = "0x40026A7")]
	public const int ItemMoonlordCountdownTime = 720;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40026A8")]
	public int teleportStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40026A9")]
	public float teleportTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40026AA")]
	public int netSpam;

	[Cpp2IlInjected.Token(Token = "0x40026AB")]
	public const int goldCritterChance = 400;

	[Cpp2IlInjected.Token(Token = "0x40026AC")]
	public static float totalInvasionPoints;

	[Cpp2IlInjected.Token(Token = "0x40026AD")]
	public const float nameOverIncrement = 0.025f;

	[Cpp2IlInjected.Token(Token = "0x40026AE")]
	public const float nameOverDistance = 350f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40026AF")]
	public float nameOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40026B0")]
	public bool SpawnedFromStatue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
	[Cpp2IlInjected.Token(Token = "0x40026B1")]
	public bool CanBeReplacedByOtherNPCs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
	[Cpp2IlInjected.Token(Token = "0x40026B2")]
	public bool dripping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x73")]
	[Cpp2IlInjected.Token(Token = "0x40026B3")]
	public bool drippingSlime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40026B4")]
	public bool drippingSparkleSlime;

	[Cpp2IlInjected.Token(Token = "0x40026B5")]
	public static readonly int AFKTimeNeededForNoWorms;

	[Cpp2IlInjected.Token(Token = "0x40026B6")]
	public static bool[] ShimmeredTownNPCs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40026B7")]
	public int altTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40026B8")]
	public int townNpcVariationIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40026B9")]
	public Vector2 netOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40026BA")]
	public short catchItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
	[Cpp2IlInjected.Token(Token = "0x40026BB")]
	public short releaseOwner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40026BC")]
	public int rarity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40026BD")]
	public bool[] playerInteraction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40026BE")]
	public int lastInteraction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40026BF")]
	public float takenDamageMultiplier;

	[Cpp2IlInjected.Token(Token = "0x40026C0")]
	private static int spawnSpaceX;

	[Cpp2IlInjected.Token(Token = "0x40026C1")]
	private static int spawnSpaceY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40026C2")]
	public float gfxOffY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40026C3")]
	public float stepSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40026C4")]
	public bool teleporting;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
	[Cpp2IlInjected.Token(Token = "0x40026C5")]
	public bool stairFall;

	[Cpp2IlInjected.Token(Token = "0x40026C6")]
	public static int stinkBugChance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40026C7")]
	private int netStream;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40026C8")]
	private int[] streamPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40026C9")]
	private bool needsUniqueInfoUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40026CA")]
	public Vector2[] oldPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40026CB")]
	public float[] oldRot;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40026CC")]
	public bool setFrameSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40026CD")]
	public int netSkip;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40026CE")]
	public bool netAlways;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40026CF")]
	public int realLife;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40026D0")]
	private string _givenName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40026D1")]
	public float npcSlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40026D2")]
	public float shimmerTransparency;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40026D3")]
	public bool dontCountMe;

	[Cpp2IlInjected.Token(Token = "0x40026D4")]
	public static readonly int maxBuffs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40026D5")]
	public int[] buffType;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40026D6")]
	public int[] buffTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40026D7")]
	public bool[] buffImmune;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40026D8")]
	public bool canDisplayBuffs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x40026D9")]
	public bool midas;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEA")]
	[Cpp2IlInjected.Token(Token = "0x40026DA")]
	public bool ichor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEB")]
	[Cpp2IlInjected.Token(Token = "0x40026DB")]
	public bool onFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40026DC")]
	public bool onFire2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40026DD")]
	public bool onFire3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40026DE")]
	public bool onFrostBurn;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40026DF")]
	public bool onFrostBurn2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40026E0")]
	public bool poisoned;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x40026E1")]
	public bool markedByScytheWhip;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
	[Cpp2IlInjected.Token(Token = "0x40026E2")]
	public bool venom;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF3")]
	[Cpp2IlInjected.Token(Token = "0x40026E3")]
	public bool shadowFlame;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40026E4")]
	public bool soulDrain;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40026E5")]
	public bool shimmering;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40026E6")]
	public int lifeRegen;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40026E7")]
	public int lifeRegenCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40026E8")]
	public int lifeRegenExpectedLossPerSecond;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40026E9")]
	public bool confused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x105")]
	[Cpp2IlInjected.Token(Token = "0x40026EA")]
	public bool loveStruck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x106")]
	[Cpp2IlInjected.Token(Token = "0x40026EB")]
	public bool stinky;

	[Cpp2IlInjected.FieldOffset(Offset = "0x107")]
	[Cpp2IlInjected.Token(Token = "0x40026EC")]
	public bool dryadWard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40026ED")]
	public bool immortal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
	[Cpp2IlInjected.Token(Token = "0x40026EE")]
	public bool chaseable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10A")]
	[Cpp2IlInjected.Token(Token = "0x40026EF")]
	public bool canGhostHeal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10B")]
	[Cpp2IlInjected.Token(Token = "0x40026F0")]
	public bool javelined;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40026F1")]
	public bool tentacleSpiked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D")]
	[Cpp2IlInjected.Token(Token = "0x40026F2")]
	public bool bloodButchered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10E")]
	[Cpp2IlInjected.Token(Token = "0x40026F3")]
	public bool celled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10F")]
	[Cpp2IlInjected.Token(Token = "0x40026F4")]
	public bool dryadBane;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40026F5")]
	public bool daybreak;

	[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
	[Cpp2IlInjected.Token(Token = "0x40026F6")]
	public bool dontTakeDamageFromHostiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x112")]
	[Cpp2IlInjected.Token(Token = "0x40026F7")]
	public bool betsysCurse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x113")]
	[Cpp2IlInjected.Token(Token = "0x40026F8")]
	public bool oiled;

	[Cpp2IlInjected.Token(Token = "0x40026F9")]
	public static bool unlockedSlimeBlueSpawn;

	[Cpp2IlInjected.Token(Token = "0x40026FA")]
	public static bool unlockedSlimeGreenSpawn;

	[Cpp2IlInjected.Token(Token = "0x40026FB")]
	public static bool unlockedSlimeOldSpawn;

	[Cpp2IlInjected.Token(Token = "0x40026FC")]
	public static bool unlockedSlimePurpleSpawn;

	[Cpp2IlInjected.Token(Token = "0x40026FD")]
	public static bool unlockedSlimeRainbowSpawn;

	[Cpp2IlInjected.Token(Token = "0x40026FE")]
	public static bool unlockedSlimeRedSpawn;

	[Cpp2IlInjected.Token(Token = "0x40026FF")]
	public static bool unlockedSlimeYellowSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002700")]
	public static bool unlockedSlimeCopperSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002701")]
	public static bool unlockedMerchantSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002702")]
	public static bool unlockedDemolitionistSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002703")]
	public static bool unlockedPartyGirlSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002704")]
	public static bool unlockedDyeTraderSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002705")]
	public static bool unlockedTruffleSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002706")]
	public static bool unlockedArmsDealerSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002707")]
	public static bool unlockedNurseSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002708")]
	public static bool unlockedPrincessSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002709")]
	public static int LunarShieldPowerMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x400270A")]
	public int soundDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400270B")]
	public int[] immune;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400270C")]
	public int directionY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400270D")]
	public int type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400270E")]
	public float[] ai;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400270F")]
	public float[] localAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4002710")]
	public int aiAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4002711")]
	public int aiStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4002712")]
	public bool justHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4002713")]
	public int timeLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x4002714")]
	public int target;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4002715")]
	public int damage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4002716")]
	public int defense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4002717")]
	public int defDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x4002718")]
	public int defDefense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4002719")]
	public bool coldDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
	[Cpp2IlInjected.Token(Token = "0x400271A")]
	public bool trapImmune;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x400271B")]
	public LegacySoundStyle HitSound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400271C")]
	public LegacySoundStyle DeathSound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x400271D")]
	public int life;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400271E")]
	public int lifeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x400271F")]
	public Rectangle targetRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4002720")]
	public double frameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4002721")]
	public Rectangle frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4002722")]
	public Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4002723")]
	public int alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4002724")]
	public bool hide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4002725")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4002726")]
	public float knockBackResist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4002727")]
	public int oldDirectionY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4002728")]
	public int oldTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4002729")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400272A")]
	public bool noGravity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
	[Cpp2IlInjected.Token(Token = "0x400272B")]
	public bool noTileCollide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B2")]
	[Cpp2IlInjected.Token(Token = "0x400272C")]
	public bool netUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B3")]
	[Cpp2IlInjected.Token(Token = "0x400272D")]
	public bool netUpdate2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400272E")]
	public bool collideX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B5")]
	[Cpp2IlInjected.Token(Token = "0x400272F")]
	public bool collideY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B6")]
	[Cpp2IlInjected.Token(Token = "0x4002730")]
	public bool boss;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4002731")]
	public int spriteDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4002732")]
	public bool behindTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BD")]
	[Cpp2IlInjected.Token(Token = "0x4002733")]
	public bool lavaImmune;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4002734")]
	public float value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4002735")]
	public int extraValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4002736")]
	public bool dontTakeDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4002737")]
	private int catchableNPCTempImmunityCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4002738")]
	public int netID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Cpp2IlInjected.Token(Token = "0x4002739")]
	public int statsAreScaledForThisManyPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x400273A")]
	public float strengthMultiplier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x400273B")]
	public bool townNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DD")]
	[Cpp2IlInjected.Token(Token = "0x400273C")]
	public bool homeless;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x400273D")]
	public int homeTileX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Cpp2IlInjected.Token(Token = "0x400273E")]
	public int homeTileY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x400273F")]
	public int housingCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Cpp2IlInjected.Token(Token = "0x4002740")]
	public bool oldHomeless;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4002741")]
	public int oldHomeTileX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
	[Cpp2IlInjected.Token(Token = "0x4002742")]
	public int oldHomeTileY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x4002743")]
	public bool friendly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F9")]
	[Cpp2IlInjected.Token(Token = "0x4002744")]
	public bool closeDoor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
	[Cpp2IlInjected.Token(Token = "0x4002745")]
	public int doorX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x4002746")]
	public int doorY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x4002747")]
	public int friendlyRegen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x4002748")]
	public int breath;

	[Cpp2IlInjected.Token(Token = "0x4002749")]
	public const int breathMax = 200;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x400274A")]
	public int breathCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x400274B")]
	public bool reflectsProjectiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x400274C")]
	public int lastPortalColorIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x400274D")]
	public bool despawnEncouraged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x400274E")]
	private long GoodRestingTileCacheTileState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x400274F")]
	private bool GoodRestingTileCacheFound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x4002750")]
	private Point GoodRestingTileCacheOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x4002751")]
	private Point GoodRestingTileCacheResult;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Cpp2IlInjected.Token(Token = "0x4002752")]
	private bool netShimmer;

	[Cpp2IlInjected.Token(Token = "0x4002753")]
	public static int mechQueen;

	[Cpp2IlInjected.Token(Token = "0x4002754")]
	public static int brainOfGravity;

	[Cpp2IlInjected.Token(Token = "0x4002755")]
	public static bool empressRageMode;

	[Cpp2IlInjected.Token(Token = "0x4002756")]
	private static readonly int[] _deerclopsAttack1Frames;

	[Cpp2IlInjected.Token(Token = "0x4002757")]
	private static readonly int[] _deerclopsAttack2Frames;

	[Cpp2IlInjected.Token(Token = "0x4002758")]
	private static readonly int[] _deerclopsAttack3Frames;

	[Cpp2IlInjected.Token(Token = "0x4002759")]
	public static int[] MoonEventRequiredPointsPerWaveLookup;

	[Cpp2IlInjected.Token(Token = "0x400275A")]
	private static bool dayTimeHax;

	[Cpp2IlInjected.Token(Token = "0x400275B")]
	private static bool rainingHax;

	[Cpp2IlInjected.Token(Token = "0x400275C")]
	private static float cloudAlphaHax;

	[Cpp2IlInjected.Token(Token = "0x400275D")]
	public static bool PreventJojaColaDialog;

	[Cpp2IlInjected.Token(Token = "0x400275E")]
	public static int RerollDryadText;

	[Cpp2IlInjected.Token(Token = "0x170004B3")]
	public bool CanTalk
	{
		[Cpp2IlInjected.Token(Token = "0x6001F41")]
		[Cpp2IlInjected.Address(RVA = "0x67926C", Offset = "0x67926C", VA = "0x67926C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B4")]
	public bool CanBeTalkedTo
	{
		[Cpp2IlInjected.Token(Token = "0x6001F42")]
		[Cpp2IlInjected.Address(RVA = "0x679368", Offset = "0x679368", VA = "0x679368")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B5")]
	public bool HasValidTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6001F43")]
		[Cpp2IlInjected.Address(RVA = "0x6793B8", Offset = "0x6793B8", VA = "0x6793B8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B6")]
	private Player TargetPlayer
	{
		[Cpp2IlInjected.Token(Token = "0x6001F44")]
		[Cpp2IlInjected.Address(RVA = "0x6794E4", Offset = "0x6794E4", VA = "0x6794E4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B7")]
	public bool HasPlayerTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6001F45")]
		[Cpp2IlInjected.Address(RVA = "0x6794D0", Offset = "0x6794D0", VA = "0x6794D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B8")]
	public bool HasNPCTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6001F46")]
		[Cpp2IlInjected.Address(RVA = "0x679634", Offset = "0x679634", VA = "0x679634")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B9")]
	public bool SupportsNPCTargets
	{
		[Cpp2IlInjected.Token(Token = "0x6001F47")]
		[Cpp2IlInjected.Address(RVA = "0x6795AC", Offset = "0x6795AC", VA = "0x6795AC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004BA")]
	public int TranslatedTargetIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6001F48")]
		[Cpp2IlInjected.Address(RVA = "0x67964C", Offset = "0x67964C", VA = "0x67964C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004BB")]
	public int WhoAmIToTargettingIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6001F49")]
		[Cpp2IlInjected.Address(RVA = "0x679660", Offset = "0x679660", VA = "0x679660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004BC")]
	public bool IsShimmerVariant
	{
		[Cpp2IlInjected.Token(Token = "0x6001F4B")]
		[Cpp2IlInjected.Address(RVA = "0x6797B8", Offset = "0x6797B8", VA = "0x6797B8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004BD")]
	public string TypeName
	{
		[Cpp2IlInjected.Token(Token = "0x6001F4E")]
		[Cpp2IlInjected.Address(RVA = "0x67A7D8", Offset = "0x67A7D8", VA = "0x67A7D8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004BE")]
	public string FullName
	{
		[Cpp2IlInjected.Token(Token = "0x6001F4F")]
		[Cpp2IlInjected.Address(RVA = "0x67A858", Offset = "0x67A858", VA = "0x67A858")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004BF")]
	public bool HasGivenName
	{
		[Cpp2IlInjected.Token(Token = "0x6001F50")]
		[Cpp2IlInjected.Address(RVA = "0x67A8DC", Offset = "0x67A8DC", VA = "0x67A8DC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C0")]
	public string GivenOrTypeName
	{
		[Cpp2IlInjected.Token(Token = "0x6001F51")]
		[Cpp2IlInjected.Address(RVA = "0x67A8F0", Offset = "0x67A8F0", VA = "0x67A8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C1")]
	public string GivenName
	{
		[Cpp2IlInjected.Token(Token = "0x6001F52")]
		[Cpp2IlInjected.Address(RVA = "0x67A908", Offset = "0x67A908", VA = "0x67A908")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001F53")]
		[Cpp2IlInjected.Address(RVA = "0x67A910", Offset = "0x67A910", VA = "0x67A910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C2")]
	public static bool downedTowers
	{
		[Cpp2IlInjected.Token(Token = "0x6001F55")]
		[Cpp2IlInjected.Address(RVA = "0x67AAC0", Offset = "0x67AAC0", VA = "0x67AAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C3")]
	public static int ShieldStrengthTowerMax
	{
		[Cpp2IlInjected.Token(Token = "0x6001F56")]
		[Cpp2IlInjected.Address(RVA = "0x67ABD8", Offset = "0x67ABD8", VA = "0x67ABD8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C4")]
	public static bool TowersDefeated
	{
		[Cpp2IlInjected.Token(Token = "0x6001F57")]
		[Cpp2IlInjected.Address(RVA = "0x67AC60", Offset = "0x67AC60", VA = "0x67AC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C5")]
	public float Opacity
	{
		[Cpp2IlInjected.Token(Token = "0x6001F59")]
		[Cpp2IlInjected.Address(RVA = "0x67AF34", Offset = "0x67AF34", VA = "0x67AF34")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001F5A")]
		[Cpp2IlInjected.Address(RVA = "0x67AF58", Offset = "0x67AF58", VA = "0x67AF58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C6")]
	public bool isLikeATownNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6001F60")]
		[Cpp2IlInjected.Address(RVA = "0x679340", Offset = "0x679340", VA = "0x679340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C7")]
	public static bool IsMechQueenUp
	{
		[Cpp2IlInjected.Token(Token = "0x6001F9B")]
		[Cpp2IlInjected.Address(RVA = "0x69DCF4", Offset = "0x69DCF4", VA = "0x69DCF4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C8")]
	public static bool TooWindyForButterflies
	{
		[Cpp2IlInjected.Token(Token = "0x6001FC3")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D80", Offset = "0x7E9D80", VA = "0x7E9D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004C9")]
	public bool CountsAsACritter
	{
		[Cpp2IlInjected.Token(Token = "0x6002076")]
		[Cpp2IlInjected.Address(RVA = "0x8482DC", Offset = "0x8482DC", VA = "0x8482DC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001F4A")]
	[Cpp2IlInjected.Address(RVA = "0x67966C", Offset = "0x67966C", VA = "0x67966C")]
	public NPCAimedTarget GetTargetData(bool ignorePlayerTankPets = true)
	{
		return default(NPCAimedTarget);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F4C")]
	[Cpp2IlInjected.Address(RVA = "0x679858", Offset = "0x679858", VA = "0x679858")]
	public static int[,,,] InitializeMoonLordAttacks()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F4D")]
	[Cpp2IlInjected.Address(RVA = "0x67A580", Offset = "0x67A580", VA = "0x67A580")]
	public static int[,] InitializeMoonLordAttacks2()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F54")]
	[Cpp2IlInjected.Address(RVA = "0x67A974", Offset = "0x67A974", VA = "0x67A974")]
	public static string GetFullnameByID(int npcID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F58")]
	[Cpp2IlInjected.Address(RVA = "0x67AD78", Offset = "0x67AD78", VA = "0x67AD78")]
	public static bool BusyWithAnyInvasionOfSorts()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F5B")]
	[Cpp2IlInjected.Address(RVA = "0x67AFA4", Offset = "0x67AFA4", VA = "0x67AFA4")]
	public int GetAttackDamage_ScaledByStrength(float normalDamage)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F5C")]
	[Cpp2IlInjected.Address(RVA = "0x67B09C", Offset = "0x67B09C", VA = "0x67B09C")]
	public float GetAttackDamage_LerpBetweenFinalValuesFloat(float normalDamage, float expertDamage)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F5D")]
	[Cpp2IlInjected.Address(RVA = "0x67B1FC", Offset = "0x67B1FC", VA = "0x67B1FC")]
	public int GetAttackDamage_LerpBetweenFinalValues(float normalDamage, float expertDamage)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F5E")]
	[Cpp2IlInjected.Address(RVA = "0x67B368", Offset = "0x67B368", VA = "0x67B368")]
	public int GetAttackDamage_ForProjectiles(float normalDamage, float expertDamage)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F5F")]
	[Cpp2IlInjected.Address(RVA = "0x67B4D4", Offset = "0x67B4D4", VA = "0x67B4D4")]
	public int GetAttackDamage_ForProjectiles_MultiLerp(float normalDamage, float expertDamage, float masterDamage)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F61")]
	[Cpp2IlInjected.Address(RVA = "0x67B6E0", Offset = "0x67B6E0", VA = "0x67B6E0")]
	public static bool SpawnAllowed_Demolitionist()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F62")]
	[Cpp2IlInjected.Address(RVA = "0x67B854", Offset = "0x67B854", VA = "0x67B854")]
	public static bool SpawnAllowed_ArmsDealer()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F63")]
	[Cpp2IlInjected.Address(RVA = "0x67BA00", Offset = "0x67BA00", VA = "0x67BA00")]
	public static bool SpawnAllowed_DyeTrader()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F64")]
	[Cpp2IlInjected.Address(RVA = "0x67BBD8", Offset = "0x67BBD8", VA = "0x67BBD8")]
	public static bool SpawnAllowed_Nurse()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F65")]
	[Cpp2IlInjected.Address(RVA = "0x67BCD0", Offset = "0x67BCD0", VA = "0x67BCD0")]
	public static bool SpawnAllowed_Merchant()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F66")]
	[Cpp2IlInjected.Address(RVA = "0x67BE6C", Offset = "0x67BE6C", VA = "0x67BE6C")]
	public static void ClearFoundActiveNPCs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F67")]
	[Cpp2IlInjected.Address(RVA = "0x67BF30", Offset = "0x67BF30", VA = "0x67BF30")]
	public static void UpdateFoundActiveNPCs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F68")]
	[Cpp2IlInjected.Address(RVA = "0x67C020", Offset = "0x67C020", VA = "0x67C020")]
	public static void ClearFoundNPCTypesForBestiary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F69")]
	[Cpp2IlInjected.Address(RVA = "0x67C0E4", Offset = "0x67C0E4", VA = "0x67C0E4")]
	public void SpawnWithHigherTime(int timeMult)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F6A")]
	[Cpp2IlInjected.Address(RVA = "0x67C16C", Offset = "0x67C16C", VA = "0x67C16C")]
	public void EncourageDespawn(int despawnTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F6B")]
	[Cpp2IlInjected.Address(RVA = "0x67C184", Offset = "0x67C184", VA = "0x67C184")]
	public void DiscourageDespawn(int despawnTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F6C")]
	[Cpp2IlInjected.Address(RVA = "0x67C19C", Offset = "0x67C19C", VA = "0x67C19C")]
	public static bool WouldBeEncouragedToDespawn(int aistyle, int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F6D")]
	[Cpp2IlInjected.Address(RVA = "0x67C22C", Offset = "0x67C22C", VA = "0x67C22C")]
	public static string getNewNPCName(int npcType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F6E")]
	[Cpp2IlInjected.Address(RVA = "0x67C2A4", Offset = "0x67C2A4", VA = "0x67C2A4")]
	private static string getNewNPCNameInner(int npcType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F6F")]
	[Cpp2IlInjected.Address(RVA = "0x67CFB4", Offset = "0x67CFB4", VA = "0x67CFB4")]
	public NetworkText GetTypeNetName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F70")]
	[Cpp2IlInjected.Address(RVA = "0x67D11C", Offset = "0x67D11C", VA = "0x67D11C")]
	public void GetLifeStats(out int statLife, out int statLifeMax)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F71")]
	[Cpp2IlInjected.Address(RVA = "0x67D1F0", Offset = "0x67D1F0", VA = "0x67D1F0")]
	public float GetLifePercent()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F72")]
	[Cpp2IlInjected.Address(RVA = "0x67D234", Offset = "0x67D234", VA = "0x67D234")]
	public NetworkText GetFullNetName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F73")]
	[Cpp2IlInjected.Address(RVA = "0x67D3F0", Offset = "0x67D3F0", VA = "0x67D3F0")]
	public NetworkText GetGivenOrTypeNetName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F74")]
	[Cpp2IlInjected.Address(RVA = "0x67D370", Offset = "0x67D370", VA = "0x67D370")]
	public NetworkText GetGivenNetName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F75")]
	[Cpp2IlInjected.Address(RVA = "0x67D408", Offset = "0x67D408", VA = "0x67D408")]
	public static void setNPCName(string newName, int npcType, bool resetExtras = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F76")]
	[Cpp2IlInjected.Address(RVA = "0x67D64C", Offset = "0x67D64C", VA = "0x67D64C")]
	public static string firstNPCName(int npcType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F77")]
	[Cpp2IlInjected.Address(RVA = "0x67D7A8", Offset = "0x67D7A8", VA = "0x67D7A8")]
	public static string GetFirstNPCNameOrNull(int npcType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F78")]
	[Cpp2IlInjected.Address(RVA = "0x67D8D4", Offset = "0x67D8D4", VA = "0x67D8D4")]
	public static bool MechSpawn(float x, float y, int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F79")]
	[Cpp2IlInjected.Address(RVA = "0x67E060", Offset = "0x67E060", VA = "0x67E060")]
	public static int TypeToDefaultHeadIndex(int type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F7A")]
	[Cpp2IlInjected.Address(RVA = "0x67E32C", Offset = "0x67E32C", VA = "0x67E32C")]
	public int GetBossHeadTextureIndex()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F7B")]
	[Cpp2IlInjected.Address(RVA = "0x67E4E0", Offset = "0x67E4E0", VA = "0x67E4E0")]
	public float GetBossHeadRotation()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F7C")]
	[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67E580", VA = "0x67E580")]
	public SpriteEffects GetBossHeadSpriteEffects()
	{
		return default(SpriteEffects);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F7D")]
	[Cpp2IlInjected.Address(RVA = "0x67E5A8", Offset = "0x67E5A8", VA = "0x67E5A8")]
	public int BannerID()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F7E")]
	[Cpp2IlInjected.Address(RVA = "0x67E5C0", Offset = "0x67E5C0", VA = "0x67E5C0")]
	private void SetDefaultsFromNetId(int id, [Optional] NPCSpawnParams spawnparams)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F7F")]
	[Cpp2IlInjected.Address(RVA = "0x695D4C", Offset = "0x695D4C", VA = "0x695D4C")]
	public void SetDefaultsKeepPlayerInteraction(int Type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F80")]
	[Cpp2IlInjected.Address(RVA = "0x695698", Offset = "0x695698", VA = "0x695698")]
	public void SetDefaults_ForNetId(int Type, float scaleOverride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F81")]
	[Cpp2IlInjected.Address(RVA = "0x69578C", Offset = "0x69578C", VA = "0x69578C")]
	public void SetDefaults_ForNetId(int Type, NPCSpawnParams spawnparams, float scaleOverride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F82")]
	[Cpp2IlInjected.Address(RVA = "0x695E50", Offset = "0x695E50", VA = "0x695E50")]
	public void SetNetShimmerEffect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F83")]
	[Cpp2IlInjected.Address(RVA = "0x67F200", Offset = "0x67F200", VA = "0x67F200")]
	public void SetDefaults(int Type, [Optional] NPCSpawnParams spawnparams)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F84")]
	[Cpp2IlInjected.Address(RVA = "0x696124", Offset = "0x696124", VA = "0x696124")]
	private void getTenthAnniversaryAdjustments()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F85")]
	[Cpp2IlInjected.Address(RVA = "0x695E78", Offset = "0x695E78", VA = "0x695E78")]
	private void getZenithSeedAdjustmentsBeforeEverything()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F86")]
	[Cpp2IlInjected.Address(RVA = "0x695EB0", Offset = "0x695EB0", VA = "0x695EB0")]
	private void getGoodAdjustments()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F87")]
	[Cpp2IlInjected.Address(RVA = "0x695E64", Offset = "0x695E64", VA = "0x695E64")]
	private void LazySetLiquidMovementDD2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F88")]
	[Cpp2IlInjected.Address(RVA = "0x696298", Offset = "0x696298", VA = "0x696298")]
	public static void SetWorldSpecificMonstersByWorldID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F89")]
	[Cpp2IlInjected.Address(RVA = "0x696490", Offset = "0x696490", VA = "0x696490")]
	public NPCSpawnParams GetMatchingSpawnParams()
	{
		return default(NPCSpawnParams);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F8A")]
	[Cpp2IlInjected.Address(RVA = "0x695818", Offset = "0x695818", VA = "0x695818")]
	public void ScaleStats(int? activePlayersCount, GameModeData gameModeData, float? strengthOverride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F8B")]
	[Cpp2IlInjected.Address(RVA = "0x6979D0", Offset = "0x6979D0", VA = "0x6979D0")]
	public void ScaleStats_UseStrengthMultiplier(float strength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F8C")]
	[Cpp2IlInjected.Address(RVA = "0x697CC0", Offset = "0x697CC0", VA = "0x697CC0")]
	public static float GetBalance()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F8D")]
	[Cpp2IlInjected.Address(RVA = "0x697DA8", Offset = "0x697DA8", VA = "0x697DA8")]
	public float GetMyBalance()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F8E")]
	[Cpp2IlInjected.Address(RVA = "0x696ABC", Offset = "0x696ABC", VA = "0x696ABC")]
	private static int GetActivePlayerCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F8F")]
	[Cpp2IlInjected.Address(RVA = "0x696588", Offset = "0x696588", VA = "0x696588")]
	private void ScaleStats_ApplyExpertTweaks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F90")]
	[Cpp2IlInjected.Address(RVA = "0x696950", Offset = "0x696950", VA = "0x696950")]
	private void ScaleStats_ApplyGameMode(GameModeData gameModeData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F91")]
	[Cpp2IlInjected.Address(RVA = "0x696C10", Offset = "0x696C10", VA = "0x696C10")]
	private void ScaleStats_ApplyMultiplayerStats(int numPlayers, float balance, float boost, float bossAdjustment)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F92")]
	[Cpp2IlInjected.Address(RVA = "0x696B6C", Offset = "0x696B6C", VA = "0x696B6C")]
	public static void GetStatScalingFactors(int numPlayers, out float balance, out float boost)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F93")]
	[Cpp2IlInjected.Address(RVA = "0x697F7C", Offset = "0x697F7C", VA = "0x697F7C")]
	public static bool GetNPCLocation(int i, bool seekHead, bool averageDirection, out int index, out Vector2 pos)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F94")]
	[Cpp2IlInjected.Address(RVA = "0x698874", Offset = "0x698874", VA = "0x698874")]
	public void PopAllAttachedProjectilesAndTakeDamageForThem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F95")]
	[Cpp2IlInjected.Address(RVA = "0x6989B0", Offset = "0x6989B0", VA = "0x6989B0")]
	public bool AI_AttemptToFindTeleportSpot(ref Vector2 chosenTile, int targetTileX, int targetTileY, int rangeFromTargetTile = 20, int telefragPreventionDistanceInTiles = 5, int solidTileCheckFluff = 1, bool solidTileCheckCentered = false, bool teleportInAir = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F96")]
	[Cpp2IlInjected.Address(RVA = "0x69913C", Offset = "0x69913C", VA = "0x69913C")]
	public static void TransformElderSlime(int npcIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F97")]
	[Cpp2IlInjected.Address(RVA = "0x6999D4", Offset = "0x6999D4", VA = "0x6999D4")]
	public static void TransformCopperSlime(int npcIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F98")]
	[Cpp2IlInjected.Address(RVA = "0x699DD0", Offset = "0x699DD0", VA = "0x699DD0")]
	public static void HaveDryadDoStardewAnimation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F99")]
	[Cpp2IlInjected.Address(RVA = "0x69A2E8", Offset = "0x69A2E8", VA = "0x69A2E8")]
	private void AI_047_GolemFist()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F9A")]
	[Cpp2IlInjected.Address(RVA = "0x69BB78", Offset = "0x69BB78", VA = "0x69BB78")]
	private void AI_045_Golem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F9C")]
	[Cpp2IlInjected.Address(RVA = "0x69DECC", Offset = "0x69DECC", VA = "0x69DECC")]
	public static bool SpawnMechQueen(int onWhichPlayer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F9D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0490", Offset = "0x6A0490", VA = "0x6A0490")]
	public void AI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F9E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3B9C", Offset = "0x7E3B9C", VA = "0x7E3B9C")]
	private void AI_124_ElderSlimeChest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F9F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3BB4", Offset = "0x7E3BB4", VA = "0x7E3BB4")]
	private void AI_125_ClumsySlimeBalloon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA0")]
	[Cpp2IlInjected.Address(RVA = "0x7B9054", Offset = "0x7B9054", VA = "0x7B9054")]
	private void SpawnStardustMark_StardustTower()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA1")]
	[Cpp2IlInjected.Address(RVA = "0x7E45B8", Offset = "0x7E45B8", VA = "0x7E45B8")]
	private void SpawnStardustMark_StardustWorm()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA2")]
	[Cpp2IlInjected.Address(RVA = "0x7E51AC", Offset = "0x7E51AC", VA = "0x7E51AC")]
	public static bool IsDeerclopsHostile()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA3")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D8C", Offset = "0x7E1D8C", VA = "0x7E1D8C")]
	private void AI_123_Deerclops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA4")]
	[Cpp2IlInjected.Address(RVA = "0x7E5664", Offset = "0x7E5664", VA = "0x7E5664")]
	private bool ShouldRunAway(ref NPCAimedTarget targetData, bool isChasing)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA5")]
	[Cpp2IlInjected.Address(RVA = "0x7E53D0", Offset = "0x7E53D0", VA = "0x7E53D0")]
	private void SpawnPassiveShadowHands(float lifePercent, int shadowHandDamage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA6")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C8C", Offset = "0x7E5C8C", VA = "0x7E5C8C")]
	private void AI_123_Deerclops_ShootRubbleUp(ref NPCAimedTarget targetData, ref Point sourceTileCoords, int howMany, int distancedByThisManyTiles, float upBiasPerSpike, int whichOne)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA7")]
	[Cpp2IlInjected.Address(RVA = "0x7E5780", Offset = "0x7E5780", VA = "0x7E5780")]
	private void AI_123_Deerclops_MakeSpikesForward(int AISLOT_PhaseCounter, NPCAimedTarget targetData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA8")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A00", Offset = "0x7E5A00", VA = "0x7E5A00")]
	private void AI_123_Deerclops_MakeSpikesBothSides(int AISLOT_PhaseCounter, NPCAimedTarget targetData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FA9")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B60", Offset = "0x7E6B60", VA = "0x7E6B60")]
	public static bool IsADeerclopsNearScreen()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FAA")]
	[Cpp2IlInjected.Address(RVA = "0x7E6BDC", Offset = "0x7E6BDC", VA = "0x7E6BDC")]
	private void AI_123_Deerclops_FindSpotToSpawnSpike(int howMany, int whichOne, ref int x, ref int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FAB")]
	[Cpp2IlInjected.Address(RVA = "0x7E6898", Offset = "0x7E6898", VA = "0x7E6898")]
	private void AI_123_Deerclops_TryMakingSpike(ref Point sourceTileCoords, int dir, int howMany, int whichOne, int xOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FAC")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F1C", Offset = "0x7E6F1C", VA = "0x7E6F1C")]
	private int AI_123_Deerclops_TryMakingSpike_FindBestY(ref Point sourceTileCoords, int x)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FAD")]
	[Cpp2IlInjected.Address(RVA = "0x7E6128", Offset = "0x7E6128", VA = "0x7E6128")]
	private void AI_123_Deerclops_Movement(bool haltMovement, bool goHome)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FAE")]
	[Cpp2IlInjected.Address(RVA = "0x7E7334", Offset = "0x7E7334", VA = "0x7E7334")]
	private void AI_124_DeerclopsLeg()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FAF")]
	[Cpp2IlInjected.Address(RVA = "0x7E7A24", Offset = "0x7E7A24", VA = "0x7E7A24")]
	private static float? TryFindingFloor(Vector2 searchStartPositionInWorld, int searchRange, out int tilesTraveled)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB0")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F68", Offset = "0x7B8F68", VA = "0x7B8F68")]
	private void AI_87_BigMimic_FireStuffCannonBurst()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB1")]
	[Cpp2IlInjected.Address(RVA = "0x7E7C04", Offset = "0x7E7C04", VA = "0x7E7C04")]
	private void AI_87_BigMimic_ShootItem(int itemID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB2")]
	[Cpp2IlInjected.Address(RVA = "0x7E17A4", Offset = "0x7E17A4", VA = "0x7E17A4")]
	public void AI_122_PirateGhost()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB3")]
	[Cpp2IlInjected.Address(RVA = "0x720210", Offset = "0x720210", VA = "0x720210")]
	public void AI_000_TransformBoundNPC(int playerID, int npcType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB4")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AAC60", VA = "0x7AAC60")]
	private void AI_065_Butterflies()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB5")]
	[Cpp2IlInjected.Address(RVA = "0x7E8048", Offset = "0x7E8048", VA = "0x7E8048")]
	public static Color AI_121_QueenSlime_GetDustColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB6")]
	[Cpp2IlInjected.Address(RVA = "0x7E81D0", Offset = "0x7E81D0", VA = "0x7E81D0")]
	private void AI_121_QueenSlime_FlyMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB7")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD28", Offset = "0x7DDD28", VA = "0x7DDD28")]
	private void AI_121_QueenSlime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB8")]
	[Cpp2IlInjected.Address(RVA = "0x7E8828", Offset = "0x7E8828", VA = "0x7E8828")]
	public bool AI_120_HallowBoss_IsInPhase2()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FB9")]
	[Cpp2IlInjected.Address(RVA = "0x7E8860", Offset = "0x7E8860", VA = "0x7E8860")]
	public bool AI_120_HallowBoss_IsGenuinelyEnraged()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FBA")]
	[Cpp2IlInjected.Address(RVA = "0x7E8898", Offset = "0x7E8898", VA = "0x7E8898")]
	private void AI_120_HallowBoss_DoMagicEffect(Vector2 spot, int effectType, float progress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FBB")]
	[Cpp2IlInjected.Address(RVA = "0x7E9148", Offset = "0x7E9148", VA = "0x7E9148")]
	public static bool ShouldEmpressBeEnraged()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FBC")]
	[Cpp2IlInjected.Address(RVA = "0x7D58E8", Offset = "0x7D58E8", VA = "0x7D58E8")]
	private void AI_120_HallowBoss()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FBD")]
	[Cpp2IlInjected.Address(RVA = "0x7E9368", Offset = "0x7E9368", VA = "0x7E9368")]
	private void AI_120_HallowBoss_DashTo(Vector2 targetPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FBE")]
	[Cpp2IlInjected.Address(RVA = "0x7E675C", Offset = "0x7E675C", VA = "0x7E675C")]
	public bool Boss_CanShootExtraAt(int playerIndex, int rotationIndexToAttack, int rotationSize, float attackScanDistance, bool alwaysSkipMainTarget = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FBF")]
	[Cpp2IlInjected.Address(RVA = "0x7D517C", Offset = "0x7D517C", VA = "0x7D517C")]
	private void AI_119_Dandelion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC0")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BD8", Offset = "0x7D4BD8", VA = "0x7D4BD8")]
	private void AI_118_Seahorses()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC1")]
	[Cpp2IlInjected.Address(RVA = "0x7D1304", Offset = "0x7D1304", VA = "0x7D1304")]
	private void AI_117_BloodNautilus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC2")]
	[Cpp2IlInjected.Address(RVA = "0x7E9874", Offset = "0x7E9874", VA = "0x7E9874")]
	private void BloodNautilus_CallForHelp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC4")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F80", Offset = "0x7D0F80", VA = "0x7D0F80")]
	private void AI_116_WaterStriders()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC5")]
	[Cpp2IlInjected.Address(RVA = "0x7D0040", Offset = "0x7D0040", VA = "0x7D0040")]
	private void AI_115_LadyBugs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC6")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC10", Offset = "0x7CEC10", VA = "0x7CEC10")]
	private void AI_114_Dragonflies()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC7")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCA8", Offset = "0x7CDCA8", VA = "0x7CDCA8")]
	private void AI_113_WindyBalloon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC8")]
	[Cpp2IlInjected.Address(RVA = "0x7EA088", Offset = "0x7EA088", VA = "0x7EA088")]
	public NPC AI_113_WindyBalloon_GetSlaveNPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001FC9")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEA0", Offset = "0x7CAEA0", VA = "0x7CAEA0")]
	private void AI_112_FairyCritter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FCA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB04", Offset = "0x7EAB04", VA = "0x7EAB04")]
	public static void FairyEffects(Vector2 Position, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FCB")]
	[Cpp2IlInjected.Address(RVA = "0x7EA794", Offset = "0x7EA794", VA = "0x7EA794")]
	private void GetBirdFlightRecommendation(int downScanRange, int upRange, Point tCoords, out bool goDownwards, out bool goUpwards)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FCC")]
	[Cpp2IlInjected.Address(RVA = "0x7EA974", Offset = "0x7EA974", VA = "0x7EA974")]
	private Vector2 GetFairyCircleOffset(float elapsedTime, float circleRotation, float circleHeight)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FCD")]
	[Cpp2IlInjected.Address(RVA = "0x7EA178", Offset = "0x7EA178", VA = "0x7EA178")]
	private bool GetFairyTreasureCoords(out Point treasureCoords)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FCE")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0E0", Offset = "0x7AD0E0", VA = "0x7AD0E0")]
	private void AI_069_DukeFishron()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FCF")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CD8", Offset = "0x7A6CD8", VA = "0x7A6CD8")]
	private void AI_037_Destroyer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD0")]
	[Cpp2IlInjected.Address(RVA = "0x73C344", Offset = "0x73C344", VA = "0x73C344")]
	private void AI_005_EaterOfSouls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB048", Offset = "0x7EB048", VA = "0x7EB048")]
	public void CopyInteractions(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD2")]
	[Cpp2IlInjected.Address(RVA = "0x7EB094", Offset = "0x7EB094", VA = "0x7EB094")]
	public static int GetEaterOfWorldsSegmentsCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB118", Offset = "0x7EB118", VA = "0x7EB118")]
	public static int GetEaterOfWorldsSegmentsCountByGamemode(int gamemode)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD4")]
	[Cpp2IlInjected.Address(RVA = "0x7AABDC", Offset = "0x7AABDC", VA = "0x7AABDC")]
	public static int GetBrainOfCthuluCreepersCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD5")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFC4", Offset = "0x7EAFC4", VA = "0x7EAFC4")]
	public static int GetDestroyerSegmentsCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD6")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BB0", Offset = "0x7A6BB0", VA = "0x7A6BB0")]
	public Vector2 GetMechQueenCenter()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD7")]
	[Cpp2IlInjected.Address(RVA = "0x73FA58", Offset = "0x73FA58", VA = "0x73FA58")]
	private void AI_006_Worms()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD8")]
	[Cpp2IlInjected.Address(RVA = "0x724EC8", Offset = "0x724EC8", VA = "0x724EC8")]
	private void AI_002_FloatingEye()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FD9")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3BC", Offset = "0x7EB3BC", VA = "0x7EB3BC")]
	private void StingerExplosion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FDA")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1E4", Offset = "0x7EB1E4", VA = "0x7EB1E4")]
	public static bool DespawnEncouragement_AIStyle2_FloatingEye_IsDiscouraged(int npcID, Vector2 npcPosition, int target = 255)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FDB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6B8", Offset = "0x7EB6B8", VA = "0x7EB6B8")]
	private bool AI_007_TownEntities_IsInAGoodRestingSpot(int tileX, int tileY, int idealRestX, int idealRestY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FDC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB828", Offset = "0x7EB828", VA = "0x7EB828")]
	private void AI_007_FindGoodRestingSpot(int myTileX, int myTileY, out int floorX, out int floorY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FDD")]
	[Cpp2IlInjected.Address(RVA = "0x7EC62C", Offset = "0x7EC62C", VA = "0x7EC62C")]
	private void AI_007_TryForcingSitting(int homeFloorX, int homeFloorY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FDE")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD7C", Offset = "0x7ECD7C", VA = "0x7ECD7C")]
	public void UpdateHomeTileState(bool homeless, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FDF")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF2C", Offset = "0x7ECF2C", VA = "0x7ECF2C")]
	public Color GetMagicAuraColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE0")]
	[Cpp2IlInjected.Address(RVA = "0x746BD8", Offset = "0x746BD8", VA = "0x746BD8")]
	private void AI_007_TownEntities()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED078", Offset = "0x7ED078", VA = "0x7ED078")]
	private void AI_007_TownEntities_Shimmer_TeleportToLandingSpot()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE2")]
	[Cpp2IlInjected.Address(RVA = "0x7EE844", Offset = "0x7EE844", VA = "0x7EE844")]
	private Vector2? AI_007_TownEntities_Shimmer_ScanForBestSpotToLandOn()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4FC", Offset = "0x7ED4FC", VA = "0x7ED4FC")]
	private void AI_007_TownEntities_TeleportToHome(int homeFloorX, int homeFloorY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6E4", Offset = "0x7ED6E4", VA = "0x7ED6E4")]
	private void AI_007_TownEntities_GetWalkPrediction(int myTileX, int homeFloorX, bool canBreathUnderWater, bool currentlyDrowning, int tileX, int tileY, out bool keepwalking, out bool avoidFalling)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE5")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1C8", Offset = "0x7EE1C8", VA = "0x7EE1C8")]
	private bool AI_007_TownEntities_CheckIfWillDrown(bool currentlyDrowning)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE6")]
	[Cpp2IlInjected.Address(RVA = "0x7EDDE4", Offset = "0x7EDDE4", VA = "0x7EDDE4")]
	private void AI_007_AttemptToPlayIdleAnimationsForPets(int petIdleChance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE7")]
	[Cpp2IlInjected.Address(RVA = "0x7A90F4", Offset = "0x7A90F4", VA = "0x7A90F4")]
	public bool NPCCanStickToWalls()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE8")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC7C", Offset = "0x7EEC7C", VA = "0x7EEC7C")]
	private bool AI_003_Gnomes_ShouldTurnToStone()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FE9")]
	[Cpp2IlInjected.Address(RVA = "0x726288", Offset = "0x726288", VA = "0x726288")]
	private void AI_003_Fighters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FEA")]
	[Cpp2IlInjected.Address(RVA = "0x7EF840", Offset = "0x7EF840", VA = "0x7EF840")]
	public static bool DespawnEncouragement_AIStyle3_Fighters_NotDiscouraged(int npcID, Vector2 position, NPC npcInstance)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FEB")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE00", Offset = "0x7EFE00", VA = "0x7EFE00")]
	public static bool DespawnEncouragement_AIStyle3_Fighters_CanBeBusyWithAction(int npcID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FEC")]
	[Cpp2IlInjected.Address(RVA = "0x720350", Offset = "0x720350", VA = "0x720350")]
	private void AI_001_Slimes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FED")]
	[Cpp2IlInjected.Address(RVA = "0x7F024C", Offset = "0x7F024C", VA = "0x7F024C")]
	public void AI_001_SetRainbowSlimeColor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FEE")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEF8", Offset = "0x7EFEF8", VA = "0x7EFEF8")]
	private static int AI_001_Slimes_GenerateItemInsideBody(bool isBallooned)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FEF")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F74", Offset = "0x7C6F74", VA = "0x7C6F74")]
	private void AI_110_Betsy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF0")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F38", Offset = "0x7A2F38", VA = "0x7A2F38")]
	private void AI_026_Unicorns()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF1")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D40", Offset = "0x7B9D40", VA = "0x7B9D40")]
	private void AI_107_ImprovedWalkers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF2")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB8", Offset = "0x7B1CB8", VA = "0x7B1CB8")]
	private void AI_084_LunaticCultist()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF3")]
	[Cpp2IlInjected.Address(RVA = "0x7C2254", Offset = "0x7C2254", VA = "0x7C2254")]
	private void AI_108_DivingFlyer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF4")]
	[Cpp2IlInjected.Address(RVA = "0x7C50AC", Offset = "0x7C50AC", VA = "0x7C50AC")]
	private void AI_109_DarkMage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF5")]
	[Cpp2IlInjected.Address(RVA = "0x7C99E4", Offset = "0x7C99E4", VA = "0x7C99E4")]
	private void AI_111_DD2LightningBug()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF6")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E18", Offset = "0x7B8E18", VA = "0x7B8E18")]
	public void ReflectProjectiles(Rectangle myRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF7")]
	[Cpp2IlInjected.Address(RVA = "0x7F0810", Offset = "0x7F0810", VA = "0x7F0810")]
	public bool CanReflectProjectile(Projectile proj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF8")]
	[Cpp2IlInjected.Address(RVA = "0x7E9718", Offset = "0x7E9718", VA = "0x7E9718")]
	public void BloodNautilus_GetMouthPositionAndRotation(out Vector2 mouthPosition, out Vector2 mouthDirection)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FF9")]
	[Cpp2IlInjected.Address(RVA = "0x7F08B0", Offset = "0x7F08B0", VA = "0x7F08B0")]
	public void ReflectProjectile(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FFA")]
	[Cpp2IlInjected.Address(RVA = "0x7F0D10", Offset = "0x7F0D10", VA = "0x7F0D10")]
	public int GetShootingFrame(float circleY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FFB")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2F0", Offset = "0x7EE2F0", VA = "0x7EE2F0")]
	public Tuple<Vector2, float> GetSwingStats(int swingMax, int swingCurrent, int aimDir, int itemWidth, int itemHeight)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001FFC")]
	[Cpp2IlInjected.Address(RVA = "0x7EE610", Offset = "0x7EE610", VA = "0x7EE610")]
	public void TweakSwingStats(int swingMax, int swingCurrent, int aimDir, ref Rectangle itemRectangle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001FFD")]
	[Cpp2IlInjected.Address(RVA = "0x7F0DB4", Offset = "0x7F0DB4", VA = "0x7F0DB4")]
	public bool UsesPartyHat()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FFE")]
	[Cpp2IlInjected.Address(RVA = "0x7F0EB4", Offset = "0x7F0EB4", VA = "0x7F0EB4")]
	public PartyHatColor GetPartyHatColor()
	{
		return default(PartyHatColor);
	}

	[Cpp2IlInjected.Token(Token = "0x6001FFF")]
	[Cpp2IlInjected.Address(RVA = "0x7F1030", Offset = "0x7F1030", VA = "0x7F1030")]
	public void SetFrameSize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002000")]
	[Cpp2IlInjected.Address(RVA = "0x7F11F0", Offset = "0x7F11F0", VA = "0x7F11F0")]
	public void FindFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002001")]
	[Cpp2IlInjected.Address(RVA = "0x806064", Offset = "0x806064", VA = "0x806064")]
	private static int FindFrame_FromSequence(int sequenceFrame, int[] frames)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002002")]
	[Cpp2IlInjected.Address(RVA = "0x805EB4", Offset = "0x805EB4", VA = "0x805EB4")]
	private static int FindFrame_Deerclops_GetAttack1Frame(int sequenceFrame)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002003")]
	[Cpp2IlInjected.Address(RVA = "0x805F44", Offset = "0x805F44", VA = "0x805F44")]
	private static int FindFrame_Deerclops_GetAttack2Frame(int sequenceFrame)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002004")]
	[Cpp2IlInjected.Address(RVA = "0x805FD4", Offset = "0x805FD4", VA = "0x805FD4")]
	private static int FindFrame_Deerclops_GetAttack3Frame(int sequenceFrame)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002005")]
	[Cpp2IlInjected.Address(RVA = "0x7B16C0", Offset = "0x7B16C0", VA = "0x7B16C0")]
	public void SimpleFlyMovement(Vector2 desiredVelocity, float moveSpeed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002006")]
	[Cpp2IlInjected.Address(RVA = "0x7F02F4", Offset = "0x7F02F4", VA = "0x7F02F4")]
	public void HealEffect(int healAmount, bool broadcast = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002007")]
	[Cpp2IlInjected.Address(RVA = "0x7B1A9C", Offset = "0x7B1A9C", VA = "0x7B1A9C")]
	public static void HealEffect(Rectangle r, int healAmount, bool broadcast = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002008")]
	[Cpp2IlInjected.Address(RVA = "0x7B1A78", Offset = "0x7B1A78", VA = "0x7B1A78")]
	public int FindClosestPlayer()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002009")]
	[Cpp2IlInjected.Address(RVA = "0x7B1798", Offset = "0x7B1798", VA = "0x7B1798")]
	public int FindClosestPlayer(out float distanceToPlayer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600200A")]
	[Cpp2IlInjected.Address(RVA = "0x80607C", Offset = "0x80607C", VA = "0x80607C")]
	public void BigMimicSpawnSmoke()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600200B")]
	[Cpp2IlInjected.Address(RVA = "0x806490", Offset = "0x806490", VA = "0x806490")]
	public static bool BigMimicSummonCheck(int x, int y, Player user)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600200C")]
	[Cpp2IlInjected.Address(RVA = "0x806EF8", Offset = "0x806EF8", VA = "0x806EF8")]
	public bool ShouldFaceTarget(ref NPCUtils.TargetSearchResults searchResults, [Optional] NPCUtils.TargetType? overrideTargetType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600200D")]
	[Cpp2IlInjected.Address(RVA = "0x807050", Offset = "0x807050", VA = "0x807050")]
	public void FaceTarget()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600200E")]
	[Cpp2IlInjected.Address(RVA = "0x8070F4", Offset = "0x8070F4", VA = "0x8070F4")]
	public void TargetClosestUpgraded(bool faceTarget = true, [Optional] Vector2? checkPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600200F")]
	[Cpp2IlInjected.Address(RVA = "0x69B9A0", Offset = "0x69B9A0", VA = "0x69B9A0")]
	public void TargetClosest(bool faceTarget = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002010")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A04", Offset = "0x7A6A04", VA = "0x7A6A04")]
	public void TargetClosest_WOF(bool faceTarget = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002011")]
	[Cpp2IlInjected.Address(RVA = "0x807864", Offset = "0x807864", VA = "0x807864")]
	private void TryTrackingTarget(ref float distance, ref float realDist, ref bool t, ref int tankTarget, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002012")]
	[Cpp2IlInjected.Address(RVA = "0x807E1C", Offset = "0x807E1C", VA = "0x807E1C")]
	private void SetTargetTrackingValues(bool faceTarget, float realDist, int tankTarget)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002013")]
	[Cpp2IlInjected.Address(RVA = "0x8081C0", Offset = "0x8081C0", VA = "0x8081C0")]
	public bool DoesntDespawnToInactivityAndCountsNPCSlots()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002014")]
	[Cpp2IlInjected.Address(RVA = "0x8081D4", Offset = "0x8081D4", VA = "0x8081D4")]
	public bool DoesntDespawnToInactivity()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002015")]
	[Cpp2IlInjected.Address(RVA = "0x808564", Offset = "0x808564", VA = "0x808564")]
	public void CheckActive()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002016")]
	[Cpp2IlInjected.Address(RVA = "0x8093EC", Offset = "0x8093EC", VA = "0x8093EC")]
	private void CheckActive_WormSegments()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002017")]
	[Cpp2IlInjected.Address(RVA = "0x808E5C", Offset = "0x808E5C", VA = "0x808E5C")]
	private void AddIntoPlayersTownNPCSlots()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002018")]
	[Cpp2IlInjected.Address(RVA = "0x7A92FC", Offset = "0x7A92FC", VA = "0x7A92FC")]
	public void checkDead()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002019")]
	[Cpp2IlInjected.Address(RVA = "0x809CA8", Offset = "0x809CA8", VA = "0x809CA8")]
	public void DropTombstoneTownNPC(NetworkText deathText)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600201A")]
	[Cpp2IlInjected.Address(RVA = "0x80CC78", Offset = "0x80CC78", VA = "0x80CC78")]
	public static int GetNPCInvasionGroup(int npcID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600201B")]
	[Cpp2IlInjected.Address(RVA = "0x80A704", Offset = "0x80A704", VA = "0x80A704")]
	private void DropEoWLoot(bool fromCheckDead = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600201C")]
	[Cpp2IlInjected.Address(RVA = "0x80CD40", Offset = "0x80CD40", VA = "0x80CD40")]
	private float GetMoonEventPointScalar()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600201D")]
	[Cpp2IlInjected.Address(RVA = "0x80B0B0", Offset = "0x80B0B0", VA = "0x80B0B0")]
	private void CheckProgressFrostMoon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600201E")]
	[Cpp2IlInjected.Address(RVA = "0x80BEAC", Offset = "0x80BEAC", VA = "0x80BEAC")]
	private void CheckProgressPumpkinMoon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600201F")]
	[Cpp2IlInjected.Address(RVA = "0x80CE04", Offset = "0x80CE04", VA = "0x80CE04")]
	public static void ResetKillCount()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002020")]
	[Cpp2IlInjected.Address(RVA = "0x80CE94", Offset = "0x80CE94", VA = "0x80CE94")]
	public bool AnyInteractions()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002021")]
	[Cpp2IlInjected.Address(RVA = "0x80CFB0", Offset = "0x80CFB0", VA = "0x80CFB0")]
	public bool IsDamageDodgeable()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002022")]
	[Cpp2IlInjected.Address(RVA = "0x80D074", Offset = "0x80D074", VA = "0x80D074")]
	public static void SetEventFlagCleared(ref bool eventFlag, int gameEventId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002023")]
	[Cpp2IlInjected.Address(RVA = "0x80D104", Offset = "0x80D104", VA = "0x80D104")]
	public static void OnGameEventClearedForTheFirstTime(int gameEventId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002024")]
	[Cpp2IlInjected.Address(RVA = "0x80A868", Offset = "0x80A868", VA = "0x80A868")]
	public void NPCLoot()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002025")]
	[Cpp2IlInjected.Address(RVA = "0x7EEDF4", Offset = "0x7EEDF4", VA = "0x7EEDF4")]
	public bool IsNPCValidForBestiaryKillCredit()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002026")]
	[Cpp2IlInjected.Address(RVA = "0x80D5C0", Offset = "0x80D5C0", VA = "0x80D5C0")]
	private void DoDeathEvents_BeforeLoot(Player closestPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002027")]
	[Cpp2IlInjected.Address(RVA = "0x80D664", Offset = "0x80D664", VA = "0x80D664")]
	private void NPCLoot_DropItems(Player closestPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002028")]
	[Cpp2IlInjected.Address(RVA = "0x810A4C", Offset = "0x810A4C", VA = "0x810A4C")]
	public static void ResetBadgerHatTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002029")]
	[Cpp2IlInjected.Address(RVA = "0x810AD0", Offset = "0x810AD0", VA = "0x810AD0")]
	private void DoDeathEvents_DropBossPotionsAndHearts()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600202A")]
	[Cpp2IlInjected.Address(RVA = "0x810F58", Offset = "0x810F58", VA = "0x810F58")]
	private void DoDeathEvents_CelebrateBossDeath()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600202B")]
	[Cpp2IlInjected.Address(RVA = "0x81161C", Offset = "0x81161C", VA = "0x81161C")]
	private void CreateBrickBoxForWallOfFlesh()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600202C")]
	[Cpp2IlInjected.Address(RVA = "0x811988", Offset = "0x811988", VA = "0x811988")]
	private void DoDeathEvents_SummonDungeonSpirit(Player closestPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600202D")]
	[Cpp2IlInjected.Address(RVA = "0x811C9C", Offset = "0x811C9C", VA = "0x811C9C")]
	private void DoDeathEvents_AdvanceSlimeRain(Player closestPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600202E")]
	[Cpp2IlInjected.Address(RVA = "0x8104B0", Offset = "0x8104B0", VA = "0x8104B0")]
	private void NPCLoot_DropHeals(Player closestPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600202F")]
	[Cpp2IlInjected.Address(RVA = "0x80D72C", Offset = "0x80D72C", VA = "0x80D72C")]
	private void DoDeathEvents(Player closestPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002030")]
	[Cpp2IlInjected.Address(RVA = "0x8133F8", Offset = "0x8133F8", VA = "0x8133F8")]
	private void ViolentlySpawnNerdySlime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002031")]
	[Cpp2IlInjected.Address(RVA = "0x811E7C", Offset = "0x811E7C", VA = "0x811E7C")]
	private void NPCLoot_DropCommonLifeAndMana(Player closestPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002032")]
	[Cpp2IlInjected.Address(RVA = "0x80F73C", Offset = "0x80F73C", VA = "0x80F73C")]
	private void NPCLoot_DropMoney(Player closestPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002033")]
	[Cpp2IlInjected.Address(RVA = "0x813650", Offset = "0x813650", VA = "0x813650")]
	public static int GetStackForSlimeItemDrop(int item)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002034")]
	[Cpp2IlInjected.Address(RVA = "0x813914", Offset = "0x813914", VA = "0x813914")]
	public bool ExcludedFromDeathTally()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002035")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE1C", Offset = "0x7EEE1C", VA = "0x7EEE1C")]
	private void CountKillForBannersAndDropThem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002036")]
	[Cpp2IlInjected.Address(RVA = "0x80D51C", Offset = "0x80D51C", VA = "0x80D51C")]
	public bool GetWereThereAnyInteractions()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002037")]
	[Cpp2IlInjected.Address(RVA = "0x80D34C", Offset = "0x80D34C", VA = "0x80D34C")]
	private void CountKillForAchievements()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002038")]
	[Cpp2IlInjected.Address(RVA = "0x813A08", Offset = "0x813A08", VA = "0x813A08")]
	private bool TryTeleportingCaughtMysticFrog()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002039")]
	[Cpp2IlInjected.Address(RVA = "0x813DF4", Offset = "0x813DF4", VA = "0x813DF4")]
	public static void CatchNPC(int i, int who = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600203A")]
	[Cpp2IlInjected.Address(RVA = "0x8144B4", Offset = "0x8144B4", VA = "0x8144B4")]
	public void DropItemInstanced(Vector2 Position, Vector2 HitboxSize, int itemType, int itemStack = 1, bool interactionRequired = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600203B")]
	[Cpp2IlInjected.Address(RVA = "0x814B84", Offset = "0x814B84", VA = "0x814B84")]
	public void PlayerInteraction(int player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600203C")]
	[Cpp2IlInjected.Address(RVA = "0x8157F0", Offset = "0x8157F0", VA = "0x8157F0")]
	public void ApplyInteraction(int player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600203D")]
	[Cpp2IlInjected.Address(RVA = "0x8158F8", Offset = "0x8158F8", VA = "0x8158F8")]
	public static bool CanReleaseNPCs(int who)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600203E")]
	[Cpp2IlInjected.Address(RVA = "0x815B0C", Offset = "0x815B0C", VA = "0x815B0C")]
	public static int ReleaseNPC(int x, int y, int Type, int Style, int who)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600203F")]
	[Cpp2IlInjected.Address(RVA = "0x816248", Offset = "0x816248", VA = "0x816248")]
	public static void SlimeRainSpawns(int plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002040")]
	[Cpp2IlInjected.Address(RVA = "0x816A58", Offset = "0x816A58", VA = "0x816A58")]
	public static bool Spawning_SandstoneCheck(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002041")]
	[Cpp2IlInjected.Address(RVA = "0x816DC8", Offset = "0x816DC8", VA = "0x816DC8")]
	public static bool Spawning_FlyingAntlionCheck(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002042")]
	[Cpp2IlInjected.Address(RVA = "0x816F8C", Offset = "0x816F8C", VA = "0x816F8C")]
	private static int RollDragonflyType(int tileType = 2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002043")]
	[Cpp2IlInjected.Address(RVA = "0x8170E4", Offset = "0x8170E4", VA = "0x8170E4")]
	public static void ResetRemixHax()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002044")]
	[Cpp2IlInjected.Address(RVA = "0x8171C0", Offset = "0x8171C0", VA = "0x8171C0")]
	public static void SetRemixHax()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002045")]
	[Cpp2IlInjected.Address(RVA = "0x81729C", Offset = "0x81729C", VA = "0x81729C")]
	public static bool SpawnTileOrAboveHasAnyWallInSet(int x, int y, bool[] wallTypes)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002046")]
	[Cpp2IlInjected.Address(RVA = "0x8174A8", Offset = "0x8174A8", VA = "0x8174A8")]
	public static void SpawnNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002047")]
	[Cpp2IlInjected.Address(RVA = "0x842D48", Offset = "0x842D48", VA = "0x842D48")]
	public static void SpawnNPC_SpawnFrog(int spawnTileX, int spawnTileY, int plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002048")]
	[Cpp2IlInjected.Address(RVA = "0x843068", Offset = "0x843068", VA = "0x843068")]
	public static int SpawnNPC_GetGemBunnyToSpawn()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002049")]
	[Cpp2IlInjected.Address(RVA = "0x842F9C", Offset = "0x842F9C", VA = "0x842F9C")]
	public static int SpawnNPC_GetGemSquirrelToSpawn()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600204A")]
	[Cpp2IlInjected.Address(RVA = "0x8439F8", Offset = "0x8439F8", VA = "0x8439F8")]
	private static bool SpawnNPC_CheckToSpawnRockGolem(int spawnTileX, int spawnTileY, int plr, int tileType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600204B")]
	[Cpp2IlInjected.Address(RVA = "0x8437B4", Offset = "0x8437B4", VA = "0x8437B4")]
	private static bool SpawnNPC_CheckToSpawnUndergroundFairy(int spawnTileX, int spawnTileY, int plr)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600204C")]
	[Cpp2IlInjected.Address(RVA = "0x843134", Offset = "0x843134", VA = "0x843134")]
	private static int SpawnNPC_SpawnLavaBaitCritters(int spawnTileX, int spawnTileY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600204D")]
	[Cpp2IlInjected.Address(RVA = "0x8428B8", Offset = "0x8428B8", VA = "0x8428B8")]
	private static int SpawnNPC_TryFindingProperGroundTileType(int spawnTileType, int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600204E")]
	[Cpp2IlInjected.Address(RVA = "0x843DCC", Offset = "0x843DCC", VA = "0x843DCC")]
	public static bool IsValidSpawningGroundTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600204F")]
	[Cpp2IlInjected.Address(RVA = "0x7E9E54", Offset = "0x7E9E54", VA = "0x7E9E54")]
	public static bool FindCattailTop(int landX, int landY, out int cattailX, out int cattailY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002050")]
	[Cpp2IlInjected.Address(RVA = "0x843F74", Offset = "0x843F74", VA = "0x843F74")]
	public static bool FindTreeBranch(int landX, int landY, out int treeBranchX, out int treeBranchY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002051")]
	[Cpp2IlInjected.Address(RVA = "0x8429F8", Offset = "0x8429F8", VA = "0x8429F8")]
	public static bool AnyDanger(bool quickBossNPCCheck = false, bool ignorePillarsAndMoonlordCountdown = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002052")]
	[Cpp2IlInjected.Address(RVA = "0x84428C", Offset = "0x84428C", VA = "0x84428C")]
	public static bool AnyoneNearCultists()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002053")]
	[Cpp2IlInjected.Address(RVA = "0x8129DC", Offset = "0x8129DC", VA = "0x8129DC")]
	public static void SpawnWOF(Vector2 pos)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002054")]
	[Cpp2IlInjected.Address(RVA = "0x80A08C", Offset = "0x80A08C", VA = "0x80A08C")]
	public static void SpawnSkeletron(int onWho)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002055")]
	[Cpp2IlInjected.Address(RVA = "0x8445F8", Offset = "0x8445F8", VA = "0x8445F8")]
	public static void SpawnFaelings(int plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002056")]
	[Cpp2IlInjected.Address(RVA = "0x69E488", Offset = "0x69E488", VA = "0x69E488")]
	public static void SpawnOnPlayer(int plr, int Type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002057")]
	[Cpp2IlInjected.Address(RVA = "0x844D38", Offset = "0x844D38", VA = "0x844D38")]
	public static int GetAvailableAmountOfNPCsToSpawnUpToSlot(int amountWeWant, int highestNPCSlotIndexWeWillPick = 100)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002058")]
	[Cpp2IlInjected.Address(RVA = "0x6A03E4", Offset = "0x6A03E4", VA = "0x6A03E4")]
	public static IEntitySource GetBossSpawnSource(int targetPlayerIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002059")]
	[Cpp2IlInjected.Address(RVA = "0x81219C", Offset = "0x81219C", VA = "0x81219C")]
	public static void SpawnBoss(int spawnPositionX, int spawnPositionY, int Type, int targetPlayerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600205A")]
	[Cpp2IlInjected.Address(RVA = "0x69D6F0", Offset = "0x69D6F0", VA = "0x69D6F0")]
	public static int NewNPC(IEntitySource source, int X, int Y, int Type, int Start = 0, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f, int Target = 255)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600205B")]
	[Cpp2IlInjected.Address(RVA = "0x844E0C", Offset = "0x844E0C", VA = "0x844E0C")]
	private static int GetAvailableNPCSlot(int Type, int startIndex)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600205C")]
	[Cpp2IlInjected.Address(RVA = "0x8452A0", Offset = "0x8452A0", VA = "0x8452A0")]
	private static void GiveTownUniqueDataToNPCsThatNeedIt(int Type, int nextNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600205D")]
	[Cpp2IlInjected.Address(RVA = "0x8455C8", Offset = "0x8455C8", VA = "0x8455C8")]
	public static void UnlockOrExchangePet(ref bool petBoughtFlag, int npcType, string textKeyForLicense, int netMessageData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600205E")]
	[Cpp2IlInjected.Address(RVA = "0x845AAC", Offset = "0x845AAC", VA = "0x845AAC")]
	public static bool RerollVariationForNPCType(int npcType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600205F")]
	[Cpp2IlInjected.Address(RVA = "0x845B6C", Offset = "0x845B6C", VA = "0x845B6C")]
	public bool RerollVariation()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002060")]
	[Cpp2IlInjected.Address(RVA = "0x845EC8", Offset = "0x845EC8", VA = "0x845EC8")]
	public void TransformVisuals(int oldType, int newType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002061")]
	[Cpp2IlInjected.Address(RVA = "0x7ED284", Offset = "0x7ED284", VA = "0x7ED284")]
	public void Teleport(Vector2 newPos, int Style = 0, int extraInfo = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002062")]
	[Cpp2IlInjected.Address(RVA = "0x6994EC", Offset = "0x6994EC", VA = "0x6994EC")]
	public void Transform(int newType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002063")]
	[Cpp2IlInjected.Address(RVA = "0x846D70", Offset = "0x846D70", VA = "0x846D70")]
	public int checkArmorPenetration(int armorPenetration, float armorPenetrationPercent)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002064")]
	[Cpp2IlInjected.Address(RVA = "0x69B898", Offset = "0x69B898", VA = "0x69B898")]
	public double StrikeNPCNoInteraction(int Damage, float knockBack, int hitDirection, bool crit = false, bool noEffect = false, bool fromNet = false)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002065")]
	[Cpp2IlInjected.Address(RVA = "0x846DD0", Offset = "0x846DD0", VA = "0x846DD0")]
	public double StrikeNPC(int Damage, float knockBack, int hitDirection, bool crit = false, bool noEffect = false, bool fromNet = false)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002066")]
	[Cpp2IlInjected.Address(RVA = "0x809590", Offset = "0x809590", VA = "0x809590")]
	public static void LadyBugKilled(Vector2 Position, bool GoldLadyBug = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002067")]
	[Cpp2IlInjected.Address(RVA = "0x8090E8", Offset = "0x8090E8", VA = "0x8090E8")]
	private void LadyBugLuck(int plr, bool GoldLadyBug = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002068")]
	[Cpp2IlInjected.Address(RVA = "0x809964", Offset = "0x809964", VA = "0x809964")]
	private void NPCLuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002069")]
	[Cpp2IlInjected.Address(RVA = "0x7559F8", Offset = "0x7559F8", VA = "0x7559F8")]
	public void HitEffect(int hitDirection = 0, double dmg = 10.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600206A")]
	[Cpp2IlInjected.Address(RVA = "0x7558B4", Offset = "0x7558B4", VA = "0x7558B4")]
	public static int CountNPCS(int Type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600206B")]
	[Cpp2IlInjected.Address(RVA = "0x843C24", Offset = "0x843C24", VA = "0x843C24")]
	public static bool AnyHelpfulFairies()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600206C")]
	[Cpp2IlInjected.Address(RVA = "0x697E94", Offset = "0x697E94", VA = "0x697E94")]
	public static bool AnyNPCs(int Type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600206D")]
	[Cpp2IlInjected.Address(RVA = "0x6A02FC", Offset = "0x6A02FC", VA = "0x6A02FC")]
	public static int FindFirstNPC(int Type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600206E")]
	[Cpp2IlInjected.Address(RVA = "0x843604", Offset = "0x843604", VA = "0x843604")]
	public static bool NearSpikeBall(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600206F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE770", Offset = "0x7EE770", VA = "0x7EE770")]
	public int FindBuffIndex(int type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002070")]
	[Cpp2IlInjected.Address(RVA = "0x847BCC", Offset = "0x847BCC", VA = "0x847BCC")]
	public void AddBuff(int type, int time, bool quiet = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002071")]
	[Cpp2IlInjected.Address(RVA = "0x848128", Offset = "0x848128", VA = "0x848128")]
	public void RequestBuffRemoval(int buffTypeToRemove)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002072")]
	[Cpp2IlInjected.Address(RVA = "0x847F1C", Offset = "0x847F1C", VA = "0x847F1C")]
	public void DelBuff(int buffIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002073")]
	[Cpp2IlInjected.Address(RVA = "0x7B1674", Offset = "0x7B1674", VA = "0x7B1674")]
	public Rectangle getRect()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002074")]
	[Cpp2IlInjected.Address(RVA = "0x7ED68C", Offset = "0x7ED68C", VA = "0x7ED68C")]
	public bool CanBeChasedBy([Optional] object attacker, bool ignoreDontTakeDamage = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002075")]
	[Cpp2IlInjected.Address(RVA = "0x848298", Offset = "0x848298", VA = "0x848298")]
	public bool HittableForOnHitRewards()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002077")]
	[Cpp2IlInjected.Address(RVA = "0x848320", Offset = "0x848320", VA = "0x848320")]
	public void moneyPing(Vector2 pos)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002078")]
	[Cpp2IlInjected.Address(RVA = "0x848508", Offset = "0x848508", VA = "0x848508")]
	public void IdleSounds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002079")]
	[Cpp2IlInjected.Address(RVA = "0x8497E0", Offset = "0x8497E0", VA = "0x8497E0")]
	public void UpdateAltTexture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600207A")]
	[Cpp2IlInjected.Address(RVA = "0x8498E4", Offset = "0x8498E4", VA = "0x8498E4")]
	private void MakeTransitionEffectsForTextureChanges(int oldAltTexture, int currentAltTexture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600207B")]
	[Cpp2IlInjected.Address(RVA = "0x849B68", Offset = "0x849B68", VA = "0x849B68")]
	public static void ResetNetOffsets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600207C")]
	[Cpp2IlInjected.Address(RVA = "0x849C98", Offset = "0x849C98", VA = "0x849C98")]
	public void UpdateNPC(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600207D")]
	[Cpp2IlInjected.Address(RVA = "0x852A38", Offset = "0x852A38", VA = "0x852A38")]
	private void SubAI_HandleTemporaryCatchableNPCPlayerInvulnerability()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600207E")]
	[Cpp2IlInjected.Address(RVA = "0x84CD54", Offset = "0x84CD54", VA = "0x84CD54")]
	private void TrySyncingUniqueTownNPCData(int npcIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600207F")]
	[Cpp2IlInjected.Address(RVA = "0x85221C", Offset = "0x85221C", VA = "0x85221C")]
	private void UpdateNetworkCode(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002080")]
	[Cpp2IlInjected.Address(RVA = "0x853CD4", Offset = "0x853CD4", VA = "0x853CD4")]
	public IEntitySource GetItemSource_Misc(int itemSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002081")]
	[Cpp2IlInjected.Address(RVA = "0x81619C", Offset = "0x81619C", VA = "0x81619C")]
	public static IEntitySource GetSpawnSource_NPCRelease(int whoReleasedIt)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002082")]
	[Cpp2IlInjected.Address(RVA = "0x814408", Offset = "0x814408", VA = "0x814408")]
	public static IEntitySource GetSpawnSource_NPCCatch(int whoCatchedIt)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002083")]
	[Cpp2IlInjected.Address(RVA = "0x811C30", Offset = "0x811C30", VA = "0x811C30")]
	public IEntitySource GetSpawnSource_NPCHurt()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002084")]
	[Cpp2IlInjected.Address(RVA = "0x7557DC", Offset = "0x7557DC", VA = "0x7557DC")]
	public IEntitySource GetSpawnSource_ForProjectile()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002085")]
	[Cpp2IlInjected.Address(RVA = "0x755848", Offset = "0x755848", VA = "0x755848")]
	public IEntitySource GetSpawnSourceForProjectileNPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002086")]
	[Cpp2IlInjected.Address(RVA = "0x755990", Offset = "0x755990", VA = "0x755990")]
	public static IEntitySource GetSpawnSourceForNaturalSpawn()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002087")]
	[Cpp2IlInjected.Address(RVA = "0x853D48", Offset = "0x853D48", VA = "0x853D48")]
	public static IEntitySource GetSpawnSourceForTownSpawn()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002088")]
	[Cpp2IlInjected.Address(RVA = "0x69D684", Offset = "0x69D684", VA = "0x69D684")]
	public IEntitySource GetSpawnSourceForNPCFromNPCAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002089")]
	[Cpp2IlInjected.Address(RVA = "0x7E7FDC", Offset = "0x7E7FDC", VA = "0x7E7FDC")]
	public IEntitySource GetItemSource_Loot()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600208A")]
	[Cpp2IlInjected.Address(RVA = "0x853470", Offset = "0x853470", VA = "0x853470")]
	private void UpdateNPC_UpdateTrails()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600208B")]
	[Cpp2IlInjected.Address(RVA = "0x851D80", Offset = "0x851D80", VA = "0x851D80")]
	private void UpdateNPC_UpdateGravity(out float maxFallSpeed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600208C")]
	[Cpp2IlInjected.Address(RVA = "0x84D11C", Offset = "0x84D11C", VA = "0x84D11C")]
	private void UpdateNPC_SoulDrainDebuff()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600208D")]
	[Cpp2IlInjected.Address(RVA = "0x853DB0", Offset = "0x853DB0", VA = "0x853DB0")]
	public static Color buffColor(Color newColor, float R, float G, float B, float A)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600208E")]
	[Cpp2IlInjected.Address(RVA = "0x853E78", Offset = "0x853E78", VA = "0x853E78")]
	public bool CanApplyHunterPotionEffects()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600208F")]
	[Cpp2IlInjected.Address(RVA = "0x853F04", Offset = "0x853F04", VA = "0x853F04")]
	public Color GetNPCColorTintedByBuffs(Color npcColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002090")]
	[Cpp2IlInjected.Address(RVA = "0x84EF40", Offset = "0x84EF40", VA = "0x84EF40")]
	private void UpdateNPC_BuffApplyVFX()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002091")]
	[Cpp2IlInjected.Address(RVA = "0x7AC7F8", Offset = "0x7AC7F8", VA = "0x7AC7F8")]
	private void GetShimmered()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002092")]
	[Cpp2IlInjected.Address(RVA = "0x84D84C", Offset = "0x84D84C", VA = "0x84D84C")]
	private void UpdateNPC_BuffApplyDOTs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002093")]
	[Cpp2IlInjected.Address(RVA = "0x84D6B4", Offset = "0x84D6B4", VA = "0x84D6B4")]
	private void UpdateNPC_BuffClearExpiredBuffs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002094")]
	[Cpp2IlInjected.Address(RVA = "0x851C70", Offset = "0x851C70", VA = "0x851C70")]
	private void UpdateNPC_BloodMoonTransformations()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002095")]
	[Cpp2IlInjected.Address(RVA = "0x8543B4", Offset = "0x8543B4", VA = "0x8543B4")]
	public void AttemptToConvertNPCToEvil(bool crimson)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002096")]
	[Cpp2IlInjected.Address(RVA = "0x84CEB0", Offset = "0x84CEB0", VA = "0x84CEB0")]
	public void UpdateNPC_BuffSetFlags(bool lowerBuffTime = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002097")]
	[Cpp2IlInjected.Address(RVA = "0x84CE6C", Offset = "0x84CE6C", VA = "0x84CE6C")]
	private void UpdateNPC_BuffFlagsReset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002098")]
	[Cpp2IlInjected.Address(RVA = "0x84BDB0", Offset = "0x84BDB0", VA = "0x84BDB0")]
	private void UpdateNPC_TeleportVisuals()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002099")]
	[Cpp2IlInjected.Address(RVA = "0x84C490", Offset = "0x84C490", VA = "0x84C490")]
	private void UpdateNPC_CritterSounds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600209A")]
	[Cpp2IlInjected.Address(RVA = "0x84B448", Offset = "0x84B448", VA = "0x84B448")]
	private void UpdateNPC_CastLights()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600209B")]
	[Cpp2IlInjected.Address(RVA = "0x852F20", Offset = "0x852F20", VA = "0x852F20")]
	private void GetHurtByOtherNPCs(bool[] acceptableNPCIDs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600209C")]
	[Cpp2IlInjected.Address(RVA = "0x854B00", Offset = "0x854B00", VA = "0x854B00")]
	private void BeHurtByOtherNPC(int npcIndex, NPC thatNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600209D")]
	[Cpp2IlInjected.Address(RVA = "0x852ED0", Offset = "0x852ED0", VA = "0x852ED0")]
	private void CheckLifeRegen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600209E")]
	[Cpp2IlInjected.Address(RVA = "0x854F94", Offset = "0x854F94", VA = "0x854F94")]
	public void GetImmuneTime(int fromWho, int time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600209F")]
	[Cpp2IlInjected.Address(RVA = "0x853230", Offset = "0x853230", VA = "0x853230")]
	private void UpdateCollision()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A0")]
	[Cpp2IlInjected.Address(RVA = "0x8574D4", Offset = "0x8574D4", VA = "0x8574D4")]
	private void Collision_MoveWhileDry()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A1")]
	[Cpp2IlInjected.Address(RVA = "0x857288", Offset = "0x857288", VA = "0x857288")]
	private void ApplyTileCollision(bool fall, Vector2 cPosition, int cWidth, int cHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A2")]
	[Cpp2IlInjected.Address(RVA = "0x85780C", Offset = "0x85780C", VA = "0x85780C")]
	private void Collision_MoveSlopesAndStairFall(bool fall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A3")]
	[Cpp2IlInjected.Address(RVA = "0x857610", Offset = "0x857610", VA = "0x857610")]
	private void Collision_MoveSnailOnSlopes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A4")]
	[Cpp2IlInjected.Address(RVA = "0x858384", Offset = "0x858384", VA = "0x858384")]
	private void Collision_MoveNormal(bool fall, Vector2 cPosition, int cWidth, int cHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A5")]
	[Cpp2IlInjected.Address(RVA = "0x857EB4", Offset = "0x857EB4", VA = "0x857EB4")]
	private void Collision_MoveSandshark(bool fall, Vector2 cPosition, int cWidth, int cHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A6")]
	[Cpp2IlInjected.Address(RVA = "0x85819C", Offset = "0x85819C", VA = "0x85819C")]
	private void Collision_MoveSolarSroller(bool fall, Vector2 cPosition, int cWidth, int cHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A7")]
	[Cpp2IlInjected.Address(RVA = "0x858008", Offset = "0x858008", VA = "0x858008")]
	private void Collision_MoveStardustCell(bool fall, Vector2 cPosition, int cWidth, int cHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A8")]
	[Cpp2IlInjected.Address(RVA = "0x857D80", Offset = "0x857D80", VA = "0x857D80")]
	private void Collision_MoveBlazingWheel()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020A9")]
	[Cpp2IlInjected.Address(RVA = "0x857330", Offset = "0x857330", VA = "0x857330")]
	private void Collision_MoveWhileWet(Vector2 oldDryVelocity, float Slowdown = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F03C4", Offset = "0x7F03C4", VA = "0x7F03C4")]
	public void GetTileCollisionParameters(out Vector2 cPosition, out int cWidth, out int cHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020AB")]
	[Cpp2IlInjected.Address(RVA = "0x85708C", Offset = "0x85708C", VA = "0x85708C")]
	private void FishTransformationDuringRain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020AC")]
	[Cpp2IlInjected.Address(RVA = "0x856B40", Offset = "0x856B40", VA = "0x856B40")]
	private bool Collision_DecideFallThroughPlatforms()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020AD")]
	[Cpp2IlInjected.Address(RVA = "0x855428", Offset = "0x855428", VA = "0x855428")]
	private bool Collision_WaterCollision(bool lava)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020AE")]
	[Cpp2IlInjected.Address(RVA = "0x855108", Offset = "0x855108", VA = "0x855108")]
	private bool Collision_LavaCollision()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020AF")]
	[Cpp2IlInjected.Address(RVA = "0x854FEC", Offset = "0x854FEC", VA = "0x854FEC")]
	private void Collision_WalkDownSlopes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020B0")]
	[Cpp2IlInjected.Address(RVA = "0x85845C", Offset = "0x85845C", VA = "0x85845C")]
	public static void setFireFlyChance()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020B1")]
	[Cpp2IlInjected.Address(RVA = "0x858AF0", Offset = "0x858AF0", VA = "0x858AF0")]
	public Color GetBestiaryEntryColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60020B2")]
	[Cpp2IlInjected.Address(RVA = "0x858B68", Offset = "0x858B68", VA = "0x858B68")]
	public Color GetAlpha(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60020B3")]
	[Cpp2IlInjected.Address(RVA = "0x859638", Offset = "0x859638", VA = "0x859638")]
	public Color GetShimmerColor(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60020B4")]
	[Cpp2IlInjected.Address(RVA = "0x8596E8", Offset = "0x8596E8", VA = "0x8596E8")]
	public Color GetColor(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60020B5")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1D0", Offset = "0x7EE1D0", VA = "0x7EE1D0")]
	public bool ShouldBestiaryGirlBeLycantrope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020B6")]
	[Cpp2IlInjected.Address(RVA = "0x859870", Offset = "0x859870", VA = "0x859870")]
	public string GetChat()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60020B7")]
	[Cpp2IlInjected.Address(RVA = "0x862564", Offset = "0x862564", VA = "0x862564")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60020B8")]
	[Cpp2IlInjected.Address(RVA = "0x8622E8", Offset = "0x8622E8", VA = "0x8622E8")]
	public bool HasLuckTextForWizard(out string specialEventText)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020B9")]
	[Cpp2IlInjected.Address(RVA = "0x861D54", Offset = "0x861D54", VA = "0x861D54")]
	public bool HasSpecialEventText(string specialTextCategoryKey, out string specialEventText)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020BA")]
	[Cpp2IlInjected.Address(RVA = "0x86256C", Offset = "0x86256C", VA = "0x86256C")]
	public bool GetSpecialEventTextIfNotEmpty(string specialTextKey, object substitutes, ref string specialEventText)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020BB")]
	[Cpp2IlInjected.Address(RVA = "0x852B40", Offset = "0x852B40", VA = "0x852B40")]
	public void CheckDrowning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020BC")]
	[Cpp2IlInjected.Address(RVA = "0x852970", Offset = "0x852970", VA = "0x852970")]
	public void TryPortalJumping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020BD")]
	[Cpp2IlInjected.Address(RVA = "0x854468", Offset = "0x854468", VA = "0x854468")]
	public static void GetMeleeCollisionData(Rectangle victimHitbox, int enemyIndex, ref int specialHitSetter, ref float damageMultiplier, ref Rectangle npcRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020BE")]
	[Cpp2IlInjected.Address(RVA = "0x862660", Offset = "0x862660", VA = "0x862660")]
	public string GetBestiaryCreditId()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60020BF")]
	[Cpp2IlInjected.Address(RVA = "0x8626F4", Offset = "0x8626F4", VA = "0x8626F4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60020C0")]
	[Cpp2IlInjected.Address(RVA = "0x844FC0", Offset = "0x844FC0", VA = "0x844FC0")]
	public NPC()
	{
	}
}
