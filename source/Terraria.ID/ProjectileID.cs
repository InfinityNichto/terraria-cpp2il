using Cpp2IlInjected;
using ReLogic.Reflection;
using Terraria.DataStructures;
using Terraria.WorldBuilding;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x2000402")]
public class ProjectileID
{
	[Cpp2IlInjected.Token(Token = "0x200091C")]
	public static class Sets
	{
		[Cpp2IlInjected.Token(Token = "0x4008A01")]
		public static SetFactory Factory;

		[Cpp2IlInjected.Token(Token = "0x4008A02")]
		public static SettingsForCharacterPreview[] CharacterPreviewAnimations;

		[Cpp2IlInjected.Token(Token = "0x4008A03")]
		public static bool[] DontApplyParryDamageBuff;

		[Cpp2IlInjected.Token(Token = "0x4008A04")]
		public static bool[] IsAGravestone;

		[Cpp2IlInjected.Token(Token = "0x4008A05")]
		public static bool[] IsAWhip;

		[Cpp2IlInjected.Token(Token = "0x4008A06")]
		public static bool[] IsAComplexCollision;

		[Cpp2IlInjected.Token(Token = "0x4008A07")]
		public static bool[] AllowsContactDamageFromJellyfish;

		[Cpp2IlInjected.Token(Token = "0x4008A08")]
		public static bool[] ImmediatelyUpdatesNPCBuffFlags;

		[Cpp2IlInjected.Token(Token = "0x4008A09")]
		public static bool[] IsAnNPCAttachedExplosive;

		[Cpp2IlInjected.Token(Token = "0x4008A0A")]
		public static bool?[] WindPhysicsImmunity;

		[Cpp2IlInjected.Token(Token = "0x4008A0B")]
		public static bool[] RocketsSkipDamageForPlayers;

		[Cpp2IlInjected.Token(Token = "0x4008A0C")]
		public static float[] YoyosLifeTimeMultiplier;

		[Cpp2IlInjected.Token(Token = "0x4008A0D")]
		public static float[] YoyosMaximumRange;

		[Cpp2IlInjected.Token(Token = "0x4008A0E")]
		public static bool[] IsAGolfBall;

		[Cpp2IlInjected.Token(Token = "0x4008A0F")]
		public static float[] YoyosTopSpeed;

		[Cpp2IlInjected.Token(Token = "0x4008A10")]
		public static bool[] CanDistortWater;

		[Cpp2IlInjected.Token(Token = "0x4008A11")]
		public static bool[] MinionShot;

		[Cpp2IlInjected.Token(Token = "0x4008A12")]
		public static bool[] SentryShot;

		[Cpp2IlInjected.Token(Token = "0x4008A13")]
		public static bool[] FallingBlockDoesNotFallThroughPlatforms;

		[Cpp2IlInjected.Token(Token = "0x4008A14")]
		public static bool?[] ForcePlateDetection;

		[Cpp2IlInjected.Token(Token = "0x4008A15")]
		public static int[] TrailingMode;

		[Cpp2IlInjected.Token(Token = "0x4008A16")]
		public static int[] TrailCacheLength;

		[Cpp2IlInjected.Token(Token = "0x4008A17")]
		public static bool[] LightPet;

		[Cpp2IlInjected.Token(Token = "0x4008A18")]
		public static bool[] HeldProjDoesNotUsePlayerGfxOffY;

		[Cpp2IlInjected.Token(Token = "0x4008A19")]
		public static bool[] DontCancelChannelOnKill;

		[Cpp2IlInjected.Token(Token = "0x4008A1A")]
		public static bool[] CultistIsResistantTo;

		[Cpp2IlInjected.Token(Token = "0x4008A1B")]
		public static bool[] IsADD2Turret;

		[Cpp2IlInjected.Token(Token = "0x4008A1C")]
		public static bool[] TurretFeature;

		[Cpp2IlInjected.Token(Token = "0x4008A1D")]
		public static bool[] MinionTargettingFeature;

		[Cpp2IlInjected.Token(Token = "0x4008A1E")]
		public static bool[] MinionSacrificable;

		[Cpp2IlInjected.Token(Token = "0x4008A1F")]
		public static bool[] DontAttachHideToAlpha;

		[Cpp2IlInjected.Token(Token = "0x4008A20")]
		public static GenSearch[] ExtendedCanHitCheckSearch;

		[Cpp2IlInjected.Token(Token = "0x4008A21")]
		public static float[] ExtendedCanHitCheckRange;

		[Cpp2IlInjected.Token(Token = "0x4008A22")]
		public static bool[] NeedsUUID;

		[Cpp2IlInjected.Token(Token = "0x4008A23")]
		public static bool[] StardustDragon;

		[Cpp2IlInjected.Token(Token = "0x4008A24")]
		public static bool[] StormTiger;

		[Cpp2IlInjected.Token(Token = "0x4008A25")]
		public static int[] StormTigerIds;

		[Cpp2IlInjected.Token(Token = "0x4008A26")]
		public static bool[] IsARocketThatDealsDoubleDamageToPrimaryEnemy;

		[Cpp2IlInjected.Token(Token = "0x4008A27")]
		public static bool[] IsAMineThatDealsTripleDamageWhenStationary;

		[Cpp2IlInjected.Token(Token = "0x4008A28")]
		public static bool[] NoLiquidDistortion;

		[Cpp2IlInjected.Token(Token = "0x4008A29")]
		public static bool[] DismountsPlayersOnHit;

		[Cpp2IlInjected.Token(Token = "0x4008A2A")]
		public static bool[] NoMeleeSpeedVelocityScaling;

		[Cpp2IlInjected.Token(Token = "0x4008A2B")]
		public static int[] DrawScreenCheckFluff;

		[Cpp2IlInjected.Token(Token = "0x4008A2C")]
		public static bool[] CanHitPastShimmer;

		[Cpp2IlInjected.Token(Token = "0x6004CB8")]
		[Cpp2IlInjected.Address(RVA = "0x1469188", Offset = "0x1469188", VA = "0x1469188")]
		public static SettingsForCharacterPreview SimpleLoop(int startFrame, int frameCount, int delayPerFrame = 4, bool bounceLoop = false)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4005647")]
	public const short None = 0;

	[Cpp2IlInjected.Token(Token = "0x4005648")]
	public const short WoodenArrowFriendly = 1;

	[Cpp2IlInjected.Token(Token = "0x4005649")]
	public const short FireArrow = 2;

	[Cpp2IlInjected.Token(Token = "0x400564A")]
	public const short Shuriken = 3;

	[Cpp2IlInjected.Token(Token = "0x400564B")]
	public const short UnholyArrow = 4;

	[Cpp2IlInjected.Token(Token = "0x400564C")]
	public const short JestersArrow = 5;

	[Cpp2IlInjected.Token(Token = "0x400564D")]
	public const short EnchantedBoomerang = 6;

	[Cpp2IlInjected.Token(Token = "0x400564E")]
	public const short VilethornBase = 7;

	[Cpp2IlInjected.Token(Token = "0x400564F")]
	public const short VilethornTip = 8;

	[Cpp2IlInjected.Token(Token = "0x4005650")]
	public const short Starfury = 9;

	[Cpp2IlInjected.Token(Token = "0x4005651")]
	public const short PurificationPowder = 10;

	[Cpp2IlInjected.Token(Token = "0x4005652")]
	public const short VilePowder = 11;

	[Cpp2IlInjected.Token(Token = "0x4005653")]
	public const short FallingStar = 12;

	[Cpp2IlInjected.Token(Token = "0x4005654")]
	public const short Hook = 13;

	[Cpp2IlInjected.Token(Token = "0x4005655")]
	public const short Bullet = 14;

	[Cpp2IlInjected.Token(Token = "0x4005656")]
	public const short BallofFire = 15;

	[Cpp2IlInjected.Token(Token = "0x4005657")]
	public const short MagicMissile = 16;

	[Cpp2IlInjected.Token(Token = "0x4005658")]
	public const short DirtBall = 17;

	[Cpp2IlInjected.Token(Token = "0x4005659")]
	public const short ShadowOrb = 18;

	[Cpp2IlInjected.Token(Token = "0x400565A")]
	public const short Flamarang = 19;

	[Cpp2IlInjected.Token(Token = "0x400565B")]
	public const short GreenLaser = 20;

	[Cpp2IlInjected.Token(Token = "0x400565C")]
	public const short Bone = 21;

	[Cpp2IlInjected.Token(Token = "0x400565D")]
	public const short WaterStream = 22;

	[Cpp2IlInjected.Token(Token = "0x400565E")]
	public const short Harpoon = 23;

	[Cpp2IlInjected.Token(Token = "0x400565F")]
	public const short SpikyBall = 24;

	[Cpp2IlInjected.Token(Token = "0x4005660")]
	public const short BallOHurt = 25;

	[Cpp2IlInjected.Token(Token = "0x4005661")]
	public const short BlueMoon = 26;

	[Cpp2IlInjected.Token(Token = "0x4005662")]
	public const short WaterBolt = 27;

	[Cpp2IlInjected.Token(Token = "0x4005663")]
	public const short Bomb = 28;

	[Cpp2IlInjected.Token(Token = "0x4005664")]
	public const short Dynamite = 29;

	[Cpp2IlInjected.Token(Token = "0x4005665")]
	public const short Grenade = 30;

	[Cpp2IlInjected.Token(Token = "0x4005666")]
	public const short SandBallFalling = 31;

	[Cpp2IlInjected.Token(Token = "0x4005667")]
	public const short IvyWhip = 32;

	[Cpp2IlInjected.Token(Token = "0x4005668")]
	public const short ThornChakram = 33;

	[Cpp2IlInjected.Token(Token = "0x4005669")]
	public const short Flamelash = 34;

	[Cpp2IlInjected.Token(Token = "0x400566A")]
	public const short Sunfury = 35;

	[Cpp2IlInjected.Token(Token = "0x400566B")]
	public const short MeteorShot = 36;

	[Cpp2IlInjected.Token(Token = "0x400566C")]
	public const short StickyBomb = 37;

	[Cpp2IlInjected.Token(Token = "0x400566D")]
	public const short HarpyFeather = 38;

	[Cpp2IlInjected.Token(Token = "0x400566E")]
	public const short MudBall = 39;

	[Cpp2IlInjected.Token(Token = "0x400566F")]
	public const short AshBallFalling = 40;

	[Cpp2IlInjected.Token(Token = "0x4005670")]
	public const short HellfireArrow = 41;

	[Cpp2IlInjected.Token(Token = "0x4005671")]
	public const short SandBallGun = 42;

	[Cpp2IlInjected.Token(Token = "0x4005672")]
	public const short Tombstone = 43;

	[Cpp2IlInjected.Token(Token = "0x4005673")]
	public const short DemonSickle = 44;

	[Cpp2IlInjected.Token(Token = "0x4005674")]
	public const short DemonScythe = 45;

	[Cpp2IlInjected.Token(Token = "0x4005675")]
	public const short DarkLance = 46;

	[Cpp2IlInjected.Token(Token = "0x4005676")]
	public const short Trident = 47;

	[Cpp2IlInjected.Token(Token = "0x4005677")]
	public const short ThrowingKnife = 48;

	[Cpp2IlInjected.Token(Token = "0x4005678")]
	public const short Spear = 49;

	[Cpp2IlInjected.Token(Token = "0x4005679")]
	public const short Glowstick = 50;

	[Cpp2IlInjected.Token(Token = "0x400567A")]
	public const short Seed = 51;

	[Cpp2IlInjected.Token(Token = "0x400567B")]
	public const short WoodenBoomerang = 52;

	[Cpp2IlInjected.Token(Token = "0x400567C")]
	public const short StickyGlowstick = 53;

	[Cpp2IlInjected.Token(Token = "0x400567D")]
	public const short PoisonedKnife = 54;

	[Cpp2IlInjected.Token(Token = "0x400567E")]
	public const short Stinger = 55;

	[Cpp2IlInjected.Token(Token = "0x400567F")]
	public const short EbonsandBallFalling = 56;

	[Cpp2IlInjected.Token(Token = "0x4005680")]
	public const short CobaltChainsaw = 57;

	[Cpp2IlInjected.Token(Token = "0x4005681")]
	public const short MythrilChainsaw = 58;

	[Cpp2IlInjected.Token(Token = "0x4005682")]
	public const short CobaltDrill = 59;

	[Cpp2IlInjected.Token(Token = "0x4005683")]
	public const short MythrilDrill = 60;

	[Cpp2IlInjected.Token(Token = "0x4005684")]
	public const short AdamantiteChainsaw = 61;

	[Cpp2IlInjected.Token(Token = "0x4005685")]
	public const short AdamantiteDrill = 62;

	[Cpp2IlInjected.Token(Token = "0x4005686")]
	public const short TheDaoofPow = 63;

	[Cpp2IlInjected.Token(Token = "0x4005687")]
	public const short MythrilHalberd = 64;

	[Cpp2IlInjected.Token(Token = "0x4005688")]
	public const short EbonsandBallGun = 65;

	[Cpp2IlInjected.Token(Token = "0x4005689")]
	public const short AdamantiteGlaive = 66;

	[Cpp2IlInjected.Token(Token = "0x400568A")]
	public const short PearlSandBallFalling = 67;

	[Cpp2IlInjected.Token(Token = "0x400568B")]
	public const short PearlSandBallGun = 68;

	[Cpp2IlInjected.Token(Token = "0x400568C")]
	public const short HolyWater = 69;

	[Cpp2IlInjected.Token(Token = "0x400568D")]
	public const short UnholyWater = 70;

	[Cpp2IlInjected.Token(Token = "0x400568E")]
	public const short SiltBall = 71;

	[Cpp2IlInjected.Token(Token = "0x400568F")]
	public const short BlueFairy = 72;

	[Cpp2IlInjected.Token(Token = "0x4005690")]
	public const short DualHookBlue = 73;

	[Cpp2IlInjected.Token(Token = "0x4005691")]
	public const short DualHookRed = 74;

	[Cpp2IlInjected.Token(Token = "0x4005692")]
	public const short HappyBomb = 75;

	[Cpp2IlInjected.Token(Token = "0x4005693")]
	public const short QuarterNote = 76;

	[Cpp2IlInjected.Token(Token = "0x4005694")]
	public const short EighthNote = 77;

	[Cpp2IlInjected.Token(Token = "0x4005695")]
	public const short TiedEighthNote = 78;

	[Cpp2IlInjected.Token(Token = "0x4005696")]
	public const short RainbowRodBullet = 79;

	[Cpp2IlInjected.Token(Token = "0x4005697")]
	public const short IceBlock = 80;

	[Cpp2IlInjected.Token(Token = "0x4005698")]
	public const short WoodenArrowHostile = 81;

	[Cpp2IlInjected.Token(Token = "0x4005699")]
	public const short FlamingArrow = 82;

	[Cpp2IlInjected.Token(Token = "0x400569A")]
	public const short EyeLaser = 83;

	[Cpp2IlInjected.Token(Token = "0x400569B")]
	public const short PinkLaser = 84;

	[Cpp2IlInjected.Token(Token = "0x400569C")]
	public const short Flames = 85;

	[Cpp2IlInjected.Token(Token = "0x400569D")]
	public const short PinkFairy = 86;

	[Cpp2IlInjected.Token(Token = "0x400569E")]
	public const short GreenFairy = 87;

	[Cpp2IlInjected.Token(Token = "0x400569F")]
	public const short PurpleLaser = 88;

	[Cpp2IlInjected.Token(Token = "0x40056A0")]
	public const short CrystalBullet = 89;

	[Cpp2IlInjected.Token(Token = "0x40056A1")]
	public const short CrystalShard = 90;

	[Cpp2IlInjected.Token(Token = "0x40056A2")]
	public const short HolyArrow = 91;

	[Cpp2IlInjected.Token(Token = "0x40056A3")]
	public const short HallowStar = 92;

	[Cpp2IlInjected.Token(Token = "0x40056A4")]
	public const short MagicDagger = 93;

	[Cpp2IlInjected.Token(Token = "0x40056A5")]
	public const short CrystalStorm = 94;

	[Cpp2IlInjected.Token(Token = "0x40056A6")]
	public const short CursedFlameFriendly = 95;

	[Cpp2IlInjected.Token(Token = "0x40056A7")]
	public const short CursedFlameHostile = 96;

	[Cpp2IlInjected.Token(Token = "0x40056A8")]
	public const short CobaltNaginata = 97;

	[Cpp2IlInjected.Token(Token = "0x40056A9")]
	public const short PoisonDart = 98;

	[Cpp2IlInjected.Token(Token = "0x40056AA")]
	public const short Boulder = 99;

	[Cpp2IlInjected.Token(Token = "0x40056AB")]
	public const short DeathLaser = 100;

	[Cpp2IlInjected.Token(Token = "0x40056AC")]
	public const short EyeFire = 101;

	[Cpp2IlInjected.Token(Token = "0x40056AD")]
	public const short BombSkeletronPrime = 102;

	[Cpp2IlInjected.Token(Token = "0x40056AE")]
	public const short CursedArrow = 103;

	[Cpp2IlInjected.Token(Token = "0x40056AF")]
	public const short CursedBullet = 104;

	[Cpp2IlInjected.Token(Token = "0x40056B0")]
	public const short Gungnir = 105;

	[Cpp2IlInjected.Token(Token = "0x40056B1")]
	public const short LightDisc = 106;

	[Cpp2IlInjected.Token(Token = "0x40056B2")]
	public const short Hamdrax = 107;

	[Cpp2IlInjected.Token(Token = "0x40056B3")]
	public const short Explosives = 108;

	[Cpp2IlInjected.Token(Token = "0x40056B4")]
	public const short SnowBallHostile = 109;

	[Cpp2IlInjected.Token(Token = "0x40056B5")]
	public const short BulletSnowman = 110;

	[Cpp2IlInjected.Token(Token = "0x40056B6")]
	public const short Bunny = 111;

	[Cpp2IlInjected.Token(Token = "0x40056B7")]
	public const short Penguin = 112;

	[Cpp2IlInjected.Token(Token = "0x40056B8")]
	public const short IceBoomerang = 113;

	[Cpp2IlInjected.Token(Token = "0x40056B9")]
	public const short UnholyTridentFriendly = 114;

	[Cpp2IlInjected.Token(Token = "0x40056BA")]
	public const short UnholyTridentHostile = 115;

	[Cpp2IlInjected.Token(Token = "0x40056BB")]
	public const short SwordBeam = 116;

	[Cpp2IlInjected.Token(Token = "0x40056BC")]
	public const short BoneArrow = 117;

	[Cpp2IlInjected.Token(Token = "0x40056BD")]
	public const short IceBolt = 118;

	[Cpp2IlInjected.Token(Token = "0x40056BE")]
	public const short FrostBoltSword = 119;

	[Cpp2IlInjected.Token(Token = "0x40056BF")]
	public const short FrostArrow = 120;

	[Cpp2IlInjected.Token(Token = "0x40056C0")]
	public const short AmethystBolt = 121;

	[Cpp2IlInjected.Token(Token = "0x40056C1")]
	public const short TopazBolt = 122;

	[Cpp2IlInjected.Token(Token = "0x40056C2")]
	public const short SapphireBolt = 123;

	[Cpp2IlInjected.Token(Token = "0x40056C3")]
	public const short EmeraldBolt = 124;

	[Cpp2IlInjected.Token(Token = "0x40056C4")]
	public const short RubyBolt = 125;

	[Cpp2IlInjected.Token(Token = "0x40056C5")]
	public const short DiamondBolt = 126;

	[Cpp2IlInjected.Token(Token = "0x40056C6")]
	public const short Turtle = 127;

	[Cpp2IlInjected.Token(Token = "0x40056C7")]
	public const short FrostBlastHostile = 128;

	[Cpp2IlInjected.Token(Token = "0x40056C8")]
	public const short RuneBlast = 129;

	[Cpp2IlInjected.Token(Token = "0x40056C9")]
	public const short MushroomSpear = 130;

	[Cpp2IlInjected.Token(Token = "0x40056CA")]
	public const short Mushroom = 131;

	[Cpp2IlInjected.Token(Token = "0x40056CB")]
	public const short TerraBeam = 132;

	[Cpp2IlInjected.Token(Token = "0x40056CC")]
	public const short GrenadeI = 133;

	[Cpp2IlInjected.Token(Token = "0x40056CD")]
	public const short RocketI = 134;

	[Cpp2IlInjected.Token(Token = "0x40056CE")]
	public const short ProximityMineI = 135;

	[Cpp2IlInjected.Token(Token = "0x40056CF")]
	public const short GrenadeII = 136;

	[Cpp2IlInjected.Token(Token = "0x40056D0")]
	public const short RocketII = 137;

	[Cpp2IlInjected.Token(Token = "0x40056D1")]
	public const short ProximityMineII = 138;

	[Cpp2IlInjected.Token(Token = "0x40056D2")]
	public const short GrenadeIII = 139;

	[Cpp2IlInjected.Token(Token = "0x40056D3")]
	public const short RocketIII = 140;

	[Cpp2IlInjected.Token(Token = "0x40056D4")]
	public const short ProximityMineIII = 141;

	[Cpp2IlInjected.Token(Token = "0x40056D5")]
	public const short GrenadeIV = 142;

	[Cpp2IlInjected.Token(Token = "0x40056D6")]
	public const short RocketIV = 143;

	[Cpp2IlInjected.Token(Token = "0x40056D7")]
	public const short ProximityMineIV = 144;

	[Cpp2IlInjected.Token(Token = "0x40056D8")]
	public const short PureSpray = 145;

	[Cpp2IlInjected.Token(Token = "0x40056D9")]
	public const short HallowSpray = 146;

	[Cpp2IlInjected.Token(Token = "0x40056DA")]
	public const short CorruptSpray = 147;

	[Cpp2IlInjected.Token(Token = "0x40056DB")]
	public const short MushroomSpray = 148;

	[Cpp2IlInjected.Token(Token = "0x40056DC")]
	public const short CrimsonSpray = 149;

	[Cpp2IlInjected.Token(Token = "0x40056DD")]
	public const short NettleBurstRight = 150;

	[Cpp2IlInjected.Token(Token = "0x40056DE")]
	public const short NettleBurstLeft = 151;

	[Cpp2IlInjected.Token(Token = "0x40056DF")]
	public const short NettleBurstEnd = 152;

	[Cpp2IlInjected.Token(Token = "0x40056E0")]
	public const short TheRottedFork = 153;

	[Cpp2IlInjected.Token(Token = "0x40056E1")]
	public const short TheMeatball = 154;

	[Cpp2IlInjected.Token(Token = "0x40056E2")]
	public const short BeachBall = 155;

	[Cpp2IlInjected.Token(Token = "0x40056E3")]
	public const short LightBeam = 156;

	[Cpp2IlInjected.Token(Token = "0x40056E4")]
	public const short NightBeam = 157;

	[Cpp2IlInjected.Token(Token = "0x40056E5")]
	public const short CopperCoin = 158;

	[Cpp2IlInjected.Token(Token = "0x40056E6")]
	public const short SilverCoin = 159;

	[Cpp2IlInjected.Token(Token = "0x40056E7")]
	public const short GoldCoin = 160;

	[Cpp2IlInjected.Token(Token = "0x40056E8")]
	public const short PlatinumCoin = 161;

	[Cpp2IlInjected.Token(Token = "0x40056E9")]
	public const short CannonballFriendly = 162;

	[Cpp2IlInjected.Token(Token = "0x40056EA")]
	public const short Flare = 163;

	[Cpp2IlInjected.Token(Token = "0x40056EB")]
	public const short Landmine = 164;

	[Cpp2IlInjected.Token(Token = "0x40056EC")]
	public const short Web = 165;

	[Cpp2IlInjected.Token(Token = "0x40056ED")]
	public const short SnowBallFriendly = 166;

	[Cpp2IlInjected.Token(Token = "0x40056EE")]
	public const short RocketFireworkRed = 167;

	[Cpp2IlInjected.Token(Token = "0x40056EF")]
	public const short RocketFireworkGreen = 168;

	[Cpp2IlInjected.Token(Token = "0x40056F0")]
	public const short RocketFireworkBlue = 169;

	[Cpp2IlInjected.Token(Token = "0x40056F1")]
	public const short RocketFireworkYellow = 170;

	[Cpp2IlInjected.Token(Token = "0x40056F2")]
	public const short RopeCoil = 171;

	[Cpp2IlInjected.Token(Token = "0x40056F3")]
	public const short FrostburnArrow = 172;

	[Cpp2IlInjected.Token(Token = "0x40056F4")]
	public const short EnchantedBeam = 173;

	[Cpp2IlInjected.Token(Token = "0x40056F5")]
	public const short IceSpike = 174;

	[Cpp2IlInjected.Token(Token = "0x40056F6")]
	public const short BabyEater = 175;

	[Cpp2IlInjected.Token(Token = "0x40056F7")]
	public const short JungleSpike = 176;

	[Cpp2IlInjected.Token(Token = "0x40056F8")]
	public const short IcewaterSpit = 177;

	[Cpp2IlInjected.Token(Token = "0x40056F9")]
	public const short ConfettiGun = 178;

	[Cpp2IlInjected.Token(Token = "0x40056FA")]
	public const short SlushBall = 179;

	[Cpp2IlInjected.Token(Token = "0x40056FB")]
	public const short BulletDeadeye = 180;

	[Cpp2IlInjected.Token(Token = "0x40056FC")]
	public const short Bee = 181;

	[Cpp2IlInjected.Token(Token = "0x40056FD")]
	public const short PossessedHatchet = 182;

	[Cpp2IlInjected.Token(Token = "0x40056FE")]
	public const short Beenade = 183;

	[Cpp2IlInjected.Token(Token = "0x40056FF")]
	public const short PoisonDartTrap = 184;

	[Cpp2IlInjected.Token(Token = "0x4005700")]
	public const short SpikyBallTrap = 185;

	[Cpp2IlInjected.Token(Token = "0x4005701")]
	public const short SpearTrap = 186;

	[Cpp2IlInjected.Token(Token = "0x4005702")]
	public const short FlamethrowerTrap = 187;

	[Cpp2IlInjected.Token(Token = "0x4005703")]
	public const short FlamesTrap = 188;

	[Cpp2IlInjected.Token(Token = "0x4005704")]
	public const short Wasp = 189;

	[Cpp2IlInjected.Token(Token = "0x4005705")]
	public const short MechanicalPiranha = 190;

	[Cpp2IlInjected.Token(Token = "0x4005706")]
	public const short Pygmy = 191;

	[Cpp2IlInjected.Token(Token = "0x4005707")]
	public const short Pygmy2 = 192;

	[Cpp2IlInjected.Token(Token = "0x4005708")]
	public const short Pygmy3 = 193;

	[Cpp2IlInjected.Token(Token = "0x4005709")]
	public const short Pygmy4 = 194;

	[Cpp2IlInjected.Token(Token = "0x400570A")]
	public const short PygmySpear = 195;

	[Cpp2IlInjected.Token(Token = "0x400570B")]
	public const short SmokeBomb = 196;

	[Cpp2IlInjected.Token(Token = "0x400570C")]
	public const short BabySkeletronHead = 197;

	[Cpp2IlInjected.Token(Token = "0x400570D")]
	public const short BabyHornet = 198;

	[Cpp2IlInjected.Token(Token = "0x400570E")]
	public const short TikiSpirit = 199;

	[Cpp2IlInjected.Token(Token = "0x400570F")]
	public const short PetLizard = 200;

	[Cpp2IlInjected.Token(Token = "0x4005710")]
	public const short GraveMarker = 201;

	[Cpp2IlInjected.Token(Token = "0x4005711")]
	public const short CrossGraveMarker = 202;

	[Cpp2IlInjected.Token(Token = "0x4005712")]
	public const short Headstone = 203;

	[Cpp2IlInjected.Token(Token = "0x4005713")]
	public const short Gravestone = 204;

	[Cpp2IlInjected.Token(Token = "0x4005714")]
	public const short Obelisk = 205;

	[Cpp2IlInjected.Token(Token = "0x4005715")]
	public const short Leaf = 206;

	[Cpp2IlInjected.Token(Token = "0x4005716")]
	public const short ChlorophyteBullet = 207;

	[Cpp2IlInjected.Token(Token = "0x4005717")]
	public const short Parrot = 208;

	[Cpp2IlInjected.Token(Token = "0x4005718")]
	public const short Truffle = 209;

	[Cpp2IlInjected.Token(Token = "0x4005719")]
	public const short Sapling = 210;

	[Cpp2IlInjected.Token(Token = "0x400571A")]
	public const short Wisp = 211;

	[Cpp2IlInjected.Token(Token = "0x400571B")]
	public const short PalladiumPike = 212;

	[Cpp2IlInjected.Token(Token = "0x400571C")]
	public const short PalladiumDrill = 213;

	[Cpp2IlInjected.Token(Token = "0x400571D")]
	public const short PalladiumChainsaw = 214;

	[Cpp2IlInjected.Token(Token = "0x400571E")]
	public const short OrichalcumHalberd = 215;

	[Cpp2IlInjected.Token(Token = "0x400571F")]
	public const short OrichalcumDrill = 216;

	[Cpp2IlInjected.Token(Token = "0x4005720")]
	public const short OrichalcumChainsaw = 217;

	[Cpp2IlInjected.Token(Token = "0x4005721")]
	public const short TitaniumTrident = 218;

	[Cpp2IlInjected.Token(Token = "0x4005722")]
	public const short TitaniumDrill = 219;

	[Cpp2IlInjected.Token(Token = "0x4005723")]
	public const short TitaniumChainsaw = 220;

	[Cpp2IlInjected.Token(Token = "0x4005724")]
	public const short FlowerPetal = 221;

	[Cpp2IlInjected.Token(Token = "0x4005725")]
	public const short ChlorophytePartisan = 222;

	[Cpp2IlInjected.Token(Token = "0x4005726")]
	public const short ChlorophyteDrill = 223;

	[Cpp2IlInjected.Token(Token = "0x4005727")]
	public const short ChlorophyteChainsaw = 224;

	[Cpp2IlInjected.Token(Token = "0x4005728")]
	public const short ChlorophyteArrow = 225;

	[Cpp2IlInjected.Token(Token = "0x4005729")]
	public const short CrystalLeaf = 226;

	[Cpp2IlInjected.Token(Token = "0x400572A")]
	public const short CrystalLeafShot = 227;

	[Cpp2IlInjected.Token(Token = "0x400572B")]
	public const short SporeCloud = 228;

	[Cpp2IlInjected.Token(Token = "0x400572C")]
	public const short ChlorophyteOrb = 229;

	[Cpp2IlInjected.Token(Token = "0x400572D")]
	public const short GemHookAmethyst = 230;

	[Cpp2IlInjected.Token(Token = "0x400572E")]
	public const short GemHookTopaz = 231;

	[Cpp2IlInjected.Token(Token = "0x400572F")]
	public const short GemHookSapphire = 232;

	[Cpp2IlInjected.Token(Token = "0x4005730")]
	public const short GemHookEmerald = 233;

	[Cpp2IlInjected.Token(Token = "0x4005731")]
	public const short GemHookRuby = 234;

	[Cpp2IlInjected.Token(Token = "0x4005732")]
	public const short GemHookDiamond = 235;

	[Cpp2IlInjected.Token(Token = "0x4005733")]
	public const short BabyDino = 236;

	[Cpp2IlInjected.Token(Token = "0x4005734")]
	public const short RainCloudMoving = 237;

	[Cpp2IlInjected.Token(Token = "0x4005735")]
	public const short RainCloudRaining = 238;

	[Cpp2IlInjected.Token(Token = "0x4005736")]
	public const short RainFriendly = 239;

	[Cpp2IlInjected.Token(Token = "0x4005737")]
	public const short CannonballHostile = 240;

	[Cpp2IlInjected.Token(Token = "0x4005738")]
	public const short CrimsandBallFalling = 241;

	[Cpp2IlInjected.Token(Token = "0x4005739")]
	public const short BulletHighVelocity = 242;

	[Cpp2IlInjected.Token(Token = "0x400573A")]
	public const short BloodCloudMoving = 243;

	[Cpp2IlInjected.Token(Token = "0x400573B")]
	public const short BloodCloudRaining = 244;

	[Cpp2IlInjected.Token(Token = "0x400573C")]
	public const short BloodRain = 245;

	[Cpp2IlInjected.Token(Token = "0x400573D")]
	public const short Stynger = 246;

	[Cpp2IlInjected.Token(Token = "0x400573E")]
	public const short FlowerPow = 247;

	[Cpp2IlInjected.Token(Token = "0x400573F")]
	public const short FlowerPowPetal = 248;

	[Cpp2IlInjected.Token(Token = "0x4005740")]
	public const short StyngerShrapnel = 249;

	[Cpp2IlInjected.Token(Token = "0x4005741")]
	public const short RainbowFront = 250;

	[Cpp2IlInjected.Token(Token = "0x4005742")]
	public const short RainbowBack = 251;

	[Cpp2IlInjected.Token(Token = "0x4005743")]
	public const short ChlorophyteJackhammer = 252;

	[Cpp2IlInjected.Token(Token = "0x4005744")]
	public const short BallofFrost = 253;

	[Cpp2IlInjected.Token(Token = "0x4005745")]
	public const short MagnetSphereBall = 254;

	[Cpp2IlInjected.Token(Token = "0x4005746")]
	public const short MagnetSphereBolt = 255;

	[Cpp2IlInjected.Token(Token = "0x4005747")]
	public const short SkeletronHand = 256;

	[Cpp2IlInjected.Token(Token = "0x4005748")]
	public const short FrostBeam = 257;

	[Cpp2IlInjected.Token(Token = "0x4005749")]
	public const short Fireball = 258;

	[Cpp2IlInjected.Token(Token = "0x400574A")]
	public const short EyeBeam = 259;

	[Cpp2IlInjected.Token(Token = "0x400574B")]
	public const short HeatRay = 260;

	[Cpp2IlInjected.Token(Token = "0x400574C")]
	public const short BoulderStaffOfEarth = 261;

	[Cpp2IlInjected.Token(Token = "0x400574D")]
	public const short GolemFist = 262;

	[Cpp2IlInjected.Token(Token = "0x400574E")]
	public const short IceSickle = 263;

	[Cpp2IlInjected.Token(Token = "0x400574F")]
	public const short RainNimbus = 264;

	[Cpp2IlInjected.Token(Token = "0x4005750")]
	public const short PoisonFang = 265;

	[Cpp2IlInjected.Token(Token = "0x4005751")]
	public const short BabySlime = 266;

	[Cpp2IlInjected.Token(Token = "0x4005752")]
	public const short PoisonDartBlowgun = 267;

	[Cpp2IlInjected.Token(Token = "0x4005753")]
	public const short EyeSpring = 268;

	[Cpp2IlInjected.Token(Token = "0x4005754")]
	public const short BabySnowman = 269;

	[Cpp2IlInjected.Token(Token = "0x4005755")]
	public const short Skull = 270;

	[Cpp2IlInjected.Token(Token = "0x4005756")]
	public const short BoxingGlove = 271;

	[Cpp2IlInjected.Token(Token = "0x4005757")]
	public const short Bananarang = 272;

	[Cpp2IlInjected.Token(Token = "0x4005758")]
	public const short ChainKnife = 273;

	[Cpp2IlInjected.Token(Token = "0x4005759")]
	public const short DeathSickle = 274;

	[Cpp2IlInjected.Token(Token = "0x400575A")]
	public const short SeedPlantera = 275;

	[Cpp2IlInjected.Token(Token = "0x400575B")]
	public const short PoisonSeedPlantera = 276;

	[Cpp2IlInjected.Token(Token = "0x400575C")]
	public const short ThornBall = 277;

	[Cpp2IlInjected.Token(Token = "0x400575D")]
	public const short IchorArrow = 278;

	[Cpp2IlInjected.Token(Token = "0x400575E")]
	public const short IchorBullet = 279;

	[Cpp2IlInjected.Token(Token = "0x400575F")]
	public const short GoldenShowerFriendly = 280;

	[Cpp2IlInjected.Token(Token = "0x4005760")]
	public const short ExplosiveBunny = 281;

	[Cpp2IlInjected.Token(Token = "0x4005761")]
	public const short VenomArrow = 282;

	[Cpp2IlInjected.Token(Token = "0x4005762")]
	public const short VenomBullet = 283;

	[Cpp2IlInjected.Token(Token = "0x4005763")]
	public const short PartyBullet = 284;

	[Cpp2IlInjected.Token(Token = "0x4005764")]
	public const short NanoBullet = 285;

	[Cpp2IlInjected.Token(Token = "0x4005765")]
	public const short ExplosiveBullet = 286;

	[Cpp2IlInjected.Token(Token = "0x4005766")]
	public const short GoldenBullet = 287;

	[Cpp2IlInjected.Token(Token = "0x4005767")]
	public const short GoldenShowerHostile = 288;

	[Cpp2IlInjected.Token(Token = "0x4005768")]
	public const short ConfettiMelee = 289;

	[Cpp2IlInjected.Token(Token = "0x4005769")]
	public const short ShadowBeamHostile = 290;

	[Cpp2IlInjected.Token(Token = "0x400576A")]
	public const short InfernoHostileBolt = 291;

	[Cpp2IlInjected.Token(Token = "0x400576B")]
	public const short InfernoHostileBlast = 292;

	[Cpp2IlInjected.Token(Token = "0x400576C")]
	public const short LostSoulHostile = 293;

	[Cpp2IlInjected.Token(Token = "0x400576D")]
	public const short ShadowBeamFriendly = 294;

	[Cpp2IlInjected.Token(Token = "0x400576E")]
	public const short InfernoFriendlyBolt = 295;

	[Cpp2IlInjected.Token(Token = "0x400576F")]
	public const short InfernoFriendlyBlast = 296;

	[Cpp2IlInjected.Token(Token = "0x4005770")]
	public const short LostSoulFriendly = 297;

	[Cpp2IlInjected.Token(Token = "0x4005771")]
	public const short SpiritHeal = 298;

	[Cpp2IlInjected.Token(Token = "0x4005772")]
	public const short Shadowflames = 299;

	[Cpp2IlInjected.Token(Token = "0x4005773")]
	public const short PaladinsHammerHostile = 300;

	[Cpp2IlInjected.Token(Token = "0x4005774")]
	public const short PaladinsHammerFriendly = 301;

	[Cpp2IlInjected.Token(Token = "0x4005775")]
	public const short SniperBullet = 302;

	[Cpp2IlInjected.Token(Token = "0x4005776")]
	public const short RocketSkeleton = 303;

	[Cpp2IlInjected.Token(Token = "0x4005777")]
	public const short VampireKnife = 304;

	[Cpp2IlInjected.Token(Token = "0x4005778")]
	public const short VampireHeal = 305;

	[Cpp2IlInjected.Token(Token = "0x4005779")]
	public const short EatersBite = 306;

	[Cpp2IlInjected.Token(Token = "0x400577A")]
	public const short TinyEater = 307;

	[Cpp2IlInjected.Token(Token = "0x400577B")]
	public const short FrostHydra = 308;

	[Cpp2IlInjected.Token(Token = "0x400577C")]
	public const short FrostBlastFriendly = 309;

	[Cpp2IlInjected.Token(Token = "0x400577D")]
	public const short BlueFlare = 310;

	[Cpp2IlInjected.Token(Token = "0x400577E")]
	public const short CandyCorn = 311;

	[Cpp2IlInjected.Token(Token = "0x400577F")]
	public const short JackOLantern = 312;

	[Cpp2IlInjected.Token(Token = "0x4005780")]
	public const short Spider = 313;

	[Cpp2IlInjected.Token(Token = "0x4005781")]
	public const short Squashling = 314;

	[Cpp2IlInjected.Token(Token = "0x4005782")]
	public const short BatHook = 315;

	[Cpp2IlInjected.Token(Token = "0x4005783")]
	public const short Bat = 316;

	[Cpp2IlInjected.Token(Token = "0x4005784")]
	public const short Raven = 317;

	[Cpp2IlInjected.Token(Token = "0x4005785")]
	public const short RottenEgg = 318;

	[Cpp2IlInjected.Token(Token = "0x4005786")]
	public const short BlackCat = 319;

	[Cpp2IlInjected.Token(Token = "0x4005787")]
	public const short BloodyMachete = 320;

	[Cpp2IlInjected.Token(Token = "0x4005788")]
	public const short FlamingJack = 321;

	[Cpp2IlInjected.Token(Token = "0x4005789")]
	public const short WoodHook = 322;

	[Cpp2IlInjected.Token(Token = "0x400578A")]
	public const short Stake = 323;

	[Cpp2IlInjected.Token(Token = "0x400578B")]
	public const short CursedSapling = 324;

	[Cpp2IlInjected.Token(Token = "0x400578C")]
	public const short FlamingWood = 325;

	[Cpp2IlInjected.Token(Token = "0x400578D")]
	public const short GreekFire1 = 326;

	[Cpp2IlInjected.Token(Token = "0x400578E")]
	public const short GreekFire2 = 327;

	[Cpp2IlInjected.Token(Token = "0x400578F")]
	public const short GreekFire3 = 328;

	[Cpp2IlInjected.Token(Token = "0x4005790")]
	public const short FlamingScythe = 329;

	[Cpp2IlInjected.Token(Token = "0x4005791")]
	public const short StarAnise = 330;

	[Cpp2IlInjected.Token(Token = "0x4005792")]
	public const short CandyCaneHook = 331;

	[Cpp2IlInjected.Token(Token = "0x4005793")]
	public const short ChristmasHook = 332;

	[Cpp2IlInjected.Token(Token = "0x4005794")]
	public const short FruitcakeChakram = 333;

	[Cpp2IlInjected.Token(Token = "0x4005795")]
	public const short Puppy = 334;

	[Cpp2IlInjected.Token(Token = "0x4005796")]
	public const short OrnamentFriendly = 335;

	[Cpp2IlInjected.Token(Token = "0x4005797")]
	public const short PineNeedleFriendly = 336;

	[Cpp2IlInjected.Token(Token = "0x4005798")]
	public const short Blizzard = 337;

	[Cpp2IlInjected.Token(Token = "0x4005799")]
	public const short RocketSnowmanI = 338;

	[Cpp2IlInjected.Token(Token = "0x400579A")]
	public const short RocketSnowmanII = 339;

	[Cpp2IlInjected.Token(Token = "0x400579B")]
	public const short RocketSnowmanIII = 340;

	[Cpp2IlInjected.Token(Token = "0x400579C")]
	public const short RocketSnowmanIV = 341;

	[Cpp2IlInjected.Token(Token = "0x400579D")]
	public const short NorthPoleWeapon = 342;

	[Cpp2IlInjected.Token(Token = "0x400579E")]
	public const short NorthPoleSpear = 343;

	[Cpp2IlInjected.Token(Token = "0x400579F")]
	public const short NorthPoleSnowflake = 344;

	[Cpp2IlInjected.Token(Token = "0x40057A0")]
	public const short PineNeedleHostile = 345;

	[Cpp2IlInjected.Token(Token = "0x40057A1")]
	public const short OrnamentHostile = 346;

	[Cpp2IlInjected.Token(Token = "0x40057A2")]
	public const short OrnamentHostileShrapnel = 347;

	[Cpp2IlInjected.Token(Token = "0x40057A3")]
	public const short FrostWave = 348;

	[Cpp2IlInjected.Token(Token = "0x40057A4")]
	public const short FrostShard = 349;

	[Cpp2IlInjected.Token(Token = "0x40057A5")]
	public const short Missile = 350;

	[Cpp2IlInjected.Token(Token = "0x40057A6")]
	public const short Present = 351;

	[Cpp2IlInjected.Token(Token = "0x40057A7")]
	public const short Spike = 352;

	[Cpp2IlInjected.Token(Token = "0x40057A8")]
	public const short BabyGrinch = 353;

	[Cpp2IlInjected.Token(Token = "0x40057A9")]
	public const short CrimsandBallGun = 354;

	[Cpp2IlInjected.Token(Token = "0x40057AA")]
	public const short VenomFang = 355;

	[Cpp2IlInjected.Token(Token = "0x40057AB")]
	public const short SpectreWrath = 356;

	[Cpp2IlInjected.Token(Token = "0x40057AC")]
	public const short PulseBolt = 357;

	[Cpp2IlInjected.Token(Token = "0x40057AD")]
	public const short WaterGun = 358;

	[Cpp2IlInjected.Token(Token = "0x40057AE")]
	public const short FrostBoltStaff = 359;

	[Cpp2IlInjected.Token(Token = "0x40057AF")]
	public const short BobberWooden = 360;

	[Cpp2IlInjected.Token(Token = "0x40057B0")]
	public const short BobberReinforced = 361;

	[Cpp2IlInjected.Token(Token = "0x40057B1")]
	public const short BobberFiberglass = 362;

	[Cpp2IlInjected.Token(Token = "0x40057B2")]
	public const short BobberFisherOfSouls = 363;

	[Cpp2IlInjected.Token(Token = "0x40057B3")]
	public const short BobberGolden = 364;

	[Cpp2IlInjected.Token(Token = "0x40057B4")]
	public const short BobberMechanics = 365;

	[Cpp2IlInjected.Token(Token = "0x40057B5")]
	public const short BobbersittingDuck = 366;

	[Cpp2IlInjected.Token(Token = "0x40057B6")]
	public const short ObsidianSwordfish = 367;

	[Cpp2IlInjected.Token(Token = "0x40057B7")]
	public const short Swordfish = 368;

	[Cpp2IlInjected.Token(Token = "0x40057B8")]
	public const short SawtoothShark = 369;

	[Cpp2IlInjected.Token(Token = "0x40057B9")]
	public const short LovePotion = 370;

	[Cpp2IlInjected.Token(Token = "0x40057BA")]
	public const short FoulPotion = 371;

	[Cpp2IlInjected.Token(Token = "0x40057BB")]
	public const short FishHook = 372;

	[Cpp2IlInjected.Token(Token = "0x40057BC")]
	public const short Hornet = 373;

	[Cpp2IlInjected.Token(Token = "0x40057BD")]
	public const short HornetStinger = 374;

	[Cpp2IlInjected.Token(Token = "0x40057BE")]
	public const short FlyingImp = 375;

	[Cpp2IlInjected.Token(Token = "0x40057BF")]
	public const short ImpFireball = 376;

	[Cpp2IlInjected.Token(Token = "0x40057C0")]
	public const short SpiderHiver = 377;

	[Cpp2IlInjected.Token(Token = "0x40057C1")]
	public const short SpiderEgg = 378;

	[Cpp2IlInjected.Token(Token = "0x40057C2")]
	public const short BabySpider = 379;

	[Cpp2IlInjected.Token(Token = "0x40057C3")]
	public const short ZephyrFish = 380;

	[Cpp2IlInjected.Token(Token = "0x40057C4")]
	public const short BobberFleshcatcher = 381;

	[Cpp2IlInjected.Token(Token = "0x40057C5")]
	public const short BobberHotline = 382;

	[Cpp2IlInjected.Token(Token = "0x40057C6")]
	public const short Anchor = 383;

	[Cpp2IlInjected.Token(Token = "0x40057C7")]
	public const short Sharknado = 384;

	[Cpp2IlInjected.Token(Token = "0x40057C8")]
	public const short SharknadoBolt = 385;

	[Cpp2IlInjected.Token(Token = "0x40057C9")]
	public const short Cthulunado = 386;

	[Cpp2IlInjected.Token(Token = "0x40057CA")]
	public const short Retanimini = 387;

	[Cpp2IlInjected.Token(Token = "0x40057CB")]
	public const short Spazmamini = 388;

	[Cpp2IlInjected.Token(Token = "0x40057CC")]
	public const short MiniRetinaLaser = 389;

	[Cpp2IlInjected.Token(Token = "0x40057CD")]
	public const short VenomSpider = 390;

	[Cpp2IlInjected.Token(Token = "0x40057CE")]
	public const short JumperSpider = 391;

	[Cpp2IlInjected.Token(Token = "0x40057CF")]
	public const short DangerousSpider = 392;

	[Cpp2IlInjected.Token(Token = "0x40057D0")]
	public const short OneEyedPirate = 393;

	[Cpp2IlInjected.Token(Token = "0x40057D1")]
	public const short SoulscourgePirate = 394;

	[Cpp2IlInjected.Token(Token = "0x40057D2")]
	public const short PirateCaptain = 395;

	[Cpp2IlInjected.Token(Token = "0x40057D3")]
	public const short SlimeHook = 396;

	[Cpp2IlInjected.Token(Token = "0x40057D4")]
	public const short StickyGrenade = 397;

	[Cpp2IlInjected.Token(Token = "0x40057D5")]
	public const short MiniMinotaur = 398;

	[Cpp2IlInjected.Token(Token = "0x40057D6")]
	public const short MolotovCocktail = 399;

	[Cpp2IlInjected.Token(Token = "0x40057D7")]
	public const short MolotovFire = 400;

	[Cpp2IlInjected.Token(Token = "0x40057D8")]
	public const short MolotovFire2 = 401;

	[Cpp2IlInjected.Token(Token = "0x40057D9")]
	public const short MolotovFire3 = 402;

	[Cpp2IlInjected.Token(Token = "0x40057DA")]
	public const short TrackHook = 403;

	[Cpp2IlInjected.Token(Token = "0x40057DB")]
	public const short Flairon = 404;

	[Cpp2IlInjected.Token(Token = "0x40057DC")]
	public const short FlaironBubble = 405;

	[Cpp2IlInjected.Token(Token = "0x40057DD")]
	public const short SlimeGun = 406;

	[Cpp2IlInjected.Token(Token = "0x40057DE")]
	public const short Tempest = 407;

	[Cpp2IlInjected.Token(Token = "0x40057DF")]
	public const short MiniSharkron = 408;

	[Cpp2IlInjected.Token(Token = "0x40057E0")]
	public const short Typhoon = 409;

	[Cpp2IlInjected.Token(Token = "0x40057E1")]
	public const short Bubble = 410;

	[Cpp2IlInjected.Token(Token = "0x40057E2")]
	public const short CopperCoinsFalling = 411;

	[Cpp2IlInjected.Token(Token = "0x40057E3")]
	public const short SilverCoinsFalling = 412;

	[Cpp2IlInjected.Token(Token = "0x40057E4")]
	public const short GoldCoinsFalling = 413;

	[Cpp2IlInjected.Token(Token = "0x40057E5")]
	public const short PlatinumCoinsFalling = 414;

	[Cpp2IlInjected.Token(Token = "0x40057E6")]
	public const short RocketFireworksBoxRed = 415;

	[Cpp2IlInjected.Token(Token = "0x40057E7")]
	public const short RocketFireworksBoxGreen = 416;

	[Cpp2IlInjected.Token(Token = "0x40057E8")]
	public const short RocketFireworksBoxBlue = 417;

	[Cpp2IlInjected.Token(Token = "0x40057E9")]
	public const short RocketFireworksBoxYellow = 418;

	[Cpp2IlInjected.Token(Token = "0x40057EA")]
	public const short FireworkFountainYellow = 419;

	[Cpp2IlInjected.Token(Token = "0x40057EB")]
	public const short FireworkFountainRed = 420;

	[Cpp2IlInjected.Token(Token = "0x40057EC")]
	public const short FireworkFountainBlue = 421;

	[Cpp2IlInjected.Token(Token = "0x40057ED")]
	public const short FireworkFountainRainbow = 422;

	[Cpp2IlInjected.Token(Token = "0x40057EE")]
	public const short UFOMinion = 423;

	[Cpp2IlInjected.Token(Token = "0x40057EF")]
	public const short Meteor1 = 424;

	[Cpp2IlInjected.Token(Token = "0x40057F0")]
	public const short Meteor2 = 425;

	[Cpp2IlInjected.Token(Token = "0x40057F1")]
	public const short Meteor3 = 426;

	[Cpp2IlInjected.Token(Token = "0x40057F2")]
	public const short VortexChainsaw = 427;

	[Cpp2IlInjected.Token(Token = "0x40057F3")]
	public const short VortexDrill = 428;

	[Cpp2IlInjected.Token(Token = "0x40057F4")]
	public const short NebulaChainsaw = 429;

	[Cpp2IlInjected.Token(Token = "0x40057F5")]
	public const short NebulaDrill = 430;

	[Cpp2IlInjected.Token(Token = "0x40057F6")]
	public const short SolarFlareChainsaw = 431;

	[Cpp2IlInjected.Token(Token = "0x40057F7")]
	public const short SolarFlareDrill = 432;

	[Cpp2IlInjected.Token(Token = "0x40057F8")]
	public const short UFOLaser = 433;

	[Cpp2IlInjected.Token(Token = "0x40057F9")]
	public const short ScutlixLaserFriendly = 434;

	[Cpp2IlInjected.Token(Token = "0x40057FA")]
	public const short MartianTurretBolt = 435;

	[Cpp2IlInjected.Token(Token = "0x40057FB")]
	public const short BrainScramblerBolt = 436;

	[Cpp2IlInjected.Token(Token = "0x40057FC")]
	public const short GigaZapperSpear = 437;

	[Cpp2IlInjected.Token(Token = "0x40057FD")]
	public const short RayGunnerLaser = 438;

	[Cpp2IlInjected.Token(Token = "0x40057FE")]
	public const short LaserMachinegun = 439;

	[Cpp2IlInjected.Token(Token = "0x40057FF")]
	public const short LaserMachinegunLaser = 440;

	[Cpp2IlInjected.Token(Token = "0x4005800")]
	public const short ScutlixLaserCrosshair = 441;

	[Cpp2IlInjected.Token(Token = "0x4005801")]
	public const short ElectrosphereMissile = 442;

	[Cpp2IlInjected.Token(Token = "0x4005802")]
	public const short Electrosphere = 443;

	[Cpp2IlInjected.Token(Token = "0x4005803")]
	public const short Xenopopper = 444;

	[Cpp2IlInjected.Token(Token = "0x4005804")]
	public const short LaserDrill = 445;

	[Cpp2IlInjected.Token(Token = "0x4005805")]
	public const short AntiGravityHook = 446;

	[Cpp2IlInjected.Token(Token = "0x4005806")]
	public const short SaucerDeathray = 447;

	[Cpp2IlInjected.Token(Token = "0x4005807")]
	public const short SaucerMissile = 448;

	[Cpp2IlInjected.Token(Token = "0x4005808")]
	public const short SaucerLaser = 449;

	[Cpp2IlInjected.Token(Token = "0x4005809")]
	public const short SaucerScrap = 450;

	[Cpp2IlInjected.Token(Token = "0x400580A")]
	public const short InfluxWaver = 451;

	[Cpp2IlInjected.Token(Token = "0x400580B")]
	public const short PhantasmalEye = 452;

	[Cpp2IlInjected.Token(Token = "0x400580C")]
	public const short DrillMountCrosshair = 453;

	[Cpp2IlInjected.Token(Token = "0x400580D")]
	public const short PhantasmalSphere = 454;

	[Cpp2IlInjected.Token(Token = "0x400580E")]
	public const short PhantasmalDeathray = 455;

	[Cpp2IlInjected.Token(Token = "0x400580F")]
	public const short MoonLeech = 456;

	[Cpp2IlInjected.Token(Token = "0x4005810")]
	public const short PhasicWarpEjector = 457;

	[Cpp2IlInjected.Token(Token = "0x4005811")]
	public const short PhasicWarpDisc = 458;

	[Cpp2IlInjected.Token(Token = "0x4005812")]
	public const short ChargedBlasterOrb = 459;

	[Cpp2IlInjected.Token(Token = "0x4005813")]
	public const short ChargedBlasterCannon = 460;

	[Cpp2IlInjected.Token(Token = "0x4005814")]
	public const short ChargedBlasterLaser = 461;

	[Cpp2IlInjected.Token(Token = "0x4005815")]
	public const short PhantasmalBolt = 462;

	[Cpp2IlInjected.Token(Token = "0x4005816")]
	public const short ViciousPowder = 463;

	[Cpp2IlInjected.Token(Token = "0x4005817")]
	public const short CultistBossIceMist = 464;

	[Cpp2IlInjected.Token(Token = "0x4005818")]
	public const short CultistBossLightningOrb = 465;

	[Cpp2IlInjected.Token(Token = "0x4005819")]
	public const short CultistBossLightningOrbArc = 466;

	[Cpp2IlInjected.Token(Token = "0x400581A")]
	public const short CultistBossFireBall = 467;

	[Cpp2IlInjected.Token(Token = "0x400581B")]
	public const short CultistBossFireBallClone = 468;

	[Cpp2IlInjected.Token(Token = "0x400581C")]
	public const short BeeArrow = 469;

	[Cpp2IlInjected.Token(Token = "0x400581D")]
	public const short StickyDynamite = 470;

	[Cpp2IlInjected.Token(Token = "0x400581E")]
	public const short SkeletonBone = 471;

	[Cpp2IlInjected.Token(Token = "0x400581F")]
	public const short WebSpit = 472;

	[Cpp2IlInjected.Token(Token = "0x4005820")]
	public const short SpelunkerGlowstick = 473;

	[Cpp2IlInjected.Token(Token = "0x4005821")]
	public const short BoneArrowFromMerchant = 474;

	[Cpp2IlInjected.Token(Token = "0x4005822")]
	public const short VineRopeCoil = 475;

	[Cpp2IlInjected.Token(Token = "0x4005823")]
	public const short SoulDrain = 476;

	[Cpp2IlInjected.Token(Token = "0x4005824")]
	public const short CrystalDart = 477;

	[Cpp2IlInjected.Token(Token = "0x4005825")]
	public const short CursedDart = 478;

	[Cpp2IlInjected.Token(Token = "0x4005826")]
	public const short IchorDart = 479;

	[Cpp2IlInjected.Token(Token = "0x4005827")]
	public const short CursedDartFlame = 480;

	[Cpp2IlInjected.Token(Token = "0x4005828")]
	public const short ChainGuillotine = 481;

	[Cpp2IlInjected.Token(Token = "0x4005829")]
	public const short ClingerStaff = 482;

	[Cpp2IlInjected.Token(Token = "0x400582A")]
	public const short SeedlerNut = 483;

	[Cpp2IlInjected.Token(Token = "0x400582B")]
	public const short SeedlerThorn = 484;

	[Cpp2IlInjected.Token(Token = "0x400582C")]
	public const short Hellwing = 485;

	[Cpp2IlInjected.Token(Token = "0x400582D")]
	public const short TendonHook = 486;

	[Cpp2IlInjected.Token(Token = "0x400582E")]
	public const short ThornHook = 487;

	[Cpp2IlInjected.Token(Token = "0x400582F")]
	public const short IlluminantHook = 488;

	[Cpp2IlInjected.Token(Token = "0x4005830")]
	public const short WormHook = 489;

	[Cpp2IlInjected.Token(Token = "0x4005831")]
	public const short CultistRitual = 490;

	[Cpp2IlInjected.Token(Token = "0x4005832")]
	public const short FlyingKnife = 491;

	[Cpp2IlInjected.Token(Token = "0x4005833")]
	public const short MagicLantern = 492;

	[Cpp2IlInjected.Token(Token = "0x4005834")]
	public const short CrystalVileShardHead = 493;

	[Cpp2IlInjected.Token(Token = "0x4005835")]
	public const short CrystalVileShardShaft = 494;

	[Cpp2IlInjected.Token(Token = "0x4005836")]
	public const short ShadowFlameArrow = 495;

	[Cpp2IlInjected.Token(Token = "0x4005837")]
	public const short ShadowFlame = 496;

	[Cpp2IlInjected.Token(Token = "0x4005838")]
	public const short ShadowFlameKnife = 497;

	[Cpp2IlInjected.Token(Token = "0x4005839")]
	public const short Nail = 498;

	[Cpp2IlInjected.Token(Token = "0x400583A")]
	public const short BabyFaceMonster = 499;

	[Cpp2IlInjected.Token(Token = "0x400583B")]
	public const short CrimsonHeart = 500;

	[Cpp2IlInjected.Token(Token = "0x400583C")]
	public const short DrManFlyFlask = 501;

	[Cpp2IlInjected.Token(Token = "0x400583D")]
	public const short Meowmere = 502;

	[Cpp2IlInjected.Token(Token = "0x400583E")]
	public const short StarWrath = 503;

	[Cpp2IlInjected.Token(Token = "0x400583F")]
	public const short Spark = 504;

	[Cpp2IlInjected.Token(Token = "0x4005840")]
	public const short SilkRopeCoil = 505;

	[Cpp2IlInjected.Token(Token = "0x4005841")]
	public const short WebRopeCoil = 506;

	[Cpp2IlInjected.Token(Token = "0x4005842")]
	public const short JavelinFriendly = 507;

	[Cpp2IlInjected.Token(Token = "0x4005843")]
	public const short JavelinHostile = 508;

	[Cpp2IlInjected.Token(Token = "0x4005844")]
	public const short ButchersChainsaw = 509;

	[Cpp2IlInjected.Token(Token = "0x4005845")]
	public const short ToxicFlask = 510;

	[Cpp2IlInjected.Token(Token = "0x4005846")]
	public const short ToxicCloud = 511;

	[Cpp2IlInjected.Token(Token = "0x4005847")]
	public const short ToxicCloud2 = 512;

	[Cpp2IlInjected.Token(Token = "0x4005848")]
	public const short ToxicCloud3 = 513;

	[Cpp2IlInjected.Token(Token = "0x4005849")]
	public const short NailFriendly = 514;

	[Cpp2IlInjected.Token(Token = "0x400584A")]
	public const short BouncyGlowstick = 515;

	[Cpp2IlInjected.Token(Token = "0x400584B")]
	public const short BouncyBomb = 516;

	[Cpp2IlInjected.Token(Token = "0x400584C")]
	public const short BouncyGrenade = 517;

	[Cpp2IlInjected.Token(Token = "0x400584D")]
	public const short CoinPortal = 518;

	[Cpp2IlInjected.Token(Token = "0x400584E")]
	public const short BombFish = 519;

	[Cpp2IlInjected.Token(Token = "0x400584F")]
	public const short FrostDaggerfish = 520;

	[Cpp2IlInjected.Token(Token = "0x4005850")]
	public const short CrystalPulse = 521;

	[Cpp2IlInjected.Token(Token = "0x4005851")]
	public const short CrystalPulse2 = 522;

	[Cpp2IlInjected.Token(Token = "0x4005852")]
	public const short ToxicBubble = 523;

	[Cpp2IlInjected.Token(Token = "0x4005853")]
	public const short IchorSplash = 524;

	[Cpp2IlInjected.Token(Token = "0x4005854")]
	public const short FlyingPiggyBank = 525;

	[Cpp2IlInjected.Token(Token = "0x4005855")]
	public const short CultistBossParticle = 526;

	[Cpp2IlInjected.Token(Token = "0x4005856")]
	public const short RichGravestone1 = 527;

	[Cpp2IlInjected.Token(Token = "0x4005857")]
	public const short RichGravestone2 = 528;

	[Cpp2IlInjected.Token(Token = "0x4005858")]
	public const short RichGravestone3 = 529;

	[Cpp2IlInjected.Token(Token = "0x4005859")]
	public const short RichGravestone4 = 530;

	[Cpp2IlInjected.Token(Token = "0x400585A")]
	public const short RichGravestone5 = 531;

	[Cpp2IlInjected.Token(Token = "0x400585B")]
	public const short BoneGloveProj = 532;

	[Cpp2IlInjected.Token(Token = "0x400585C")]
	public const short DeadlySphere = 533;

	[Cpp2IlInjected.Token(Token = "0x400585D")]
	public const short Code1 = 534;

	[Cpp2IlInjected.Token(Token = "0x400585E")]
	public const short MedusaHead = 535;

	[Cpp2IlInjected.Token(Token = "0x400585F")]
	public const short MedusaHeadRay = 536;

	[Cpp2IlInjected.Token(Token = "0x4005860")]
	public const short StardustSoldierLaser = 537;

	[Cpp2IlInjected.Token(Token = "0x4005861")]
	public const short Twinkle = 538;

	[Cpp2IlInjected.Token(Token = "0x4005862")]
	public const short StardustJellyfishSmall = 539;

	[Cpp2IlInjected.Token(Token = "0x4005863")]
	public const short StardustTowerMark = 540;

	[Cpp2IlInjected.Token(Token = "0x4005864")]
	public const short WoodYoyo = 541;

	[Cpp2IlInjected.Token(Token = "0x4005865")]
	public const short CorruptYoyo = 542;

	[Cpp2IlInjected.Token(Token = "0x4005866")]
	public const short CrimsonYoyo = 543;

	[Cpp2IlInjected.Token(Token = "0x4005867")]
	public const short JungleYoyo = 544;

	[Cpp2IlInjected.Token(Token = "0x4005868")]
	public const short Cascade = 545;

	[Cpp2IlInjected.Token(Token = "0x4005869")]
	public const short Chik = 546;

	[Cpp2IlInjected.Token(Token = "0x400586A")]
	public const short Code2 = 547;

	[Cpp2IlInjected.Token(Token = "0x400586B")]
	public const short Rally = 548;

	[Cpp2IlInjected.Token(Token = "0x400586C")]
	public const short Yelets = 549;

	[Cpp2IlInjected.Token(Token = "0x400586D")]
	public const short RedsYoyo = 550;

	[Cpp2IlInjected.Token(Token = "0x400586E")]
	public const short ValkyrieYoyo = 551;

	[Cpp2IlInjected.Token(Token = "0x400586F")]
	public const short Amarok = 552;

	[Cpp2IlInjected.Token(Token = "0x4005870")]
	public const short HelFire = 553;

	[Cpp2IlInjected.Token(Token = "0x4005871")]
	public const short Kraken = 554;

	[Cpp2IlInjected.Token(Token = "0x4005872")]
	public const short TheEyeOfCthulhu = 555;

	[Cpp2IlInjected.Token(Token = "0x4005873")]
	public const short BlackCounterweight = 556;

	[Cpp2IlInjected.Token(Token = "0x4005874")]
	public const short BlueCounterweight = 557;

	[Cpp2IlInjected.Token(Token = "0x4005875")]
	public const short GreenCounterweight = 558;

	[Cpp2IlInjected.Token(Token = "0x4005876")]
	public const short PurpleCounterweight = 559;

	[Cpp2IlInjected.Token(Token = "0x4005877")]
	public const short RedCounterweight = 560;

	[Cpp2IlInjected.Token(Token = "0x4005878")]
	public const short YellowCounterweight = 561;

	[Cpp2IlInjected.Token(Token = "0x4005879")]
	public const short FormatC = 562;

	[Cpp2IlInjected.Token(Token = "0x400587A")]
	public const short Gradient = 563;

	[Cpp2IlInjected.Token(Token = "0x400587B")]
	public const short Valor = 564;

	[Cpp2IlInjected.Token(Token = "0x400587C")]
	public const short BrainOfConfusion = 565;

	[Cpp2IlInjected.Token(Token = "0x400587D")]
	public const short GiantBee = 566;

	[Cpp2IlInjected.Token(Token = "0x400587E")]
	public const short SporeTrap = 567;

	[Cpp2IlInjected.Token(Token = "0x400587F")]
	public const short SporeTrap2 = 568;

	[Cpp2IlInjected.Token(Token = "0x4005880")]
	public const short SporeGas = 569;

	[Cpp2IlInjected.Token(Token = "0x4005881")]
	public const short SporeGas2 = 570;

	[Cpp2IlInjected.Token(Token = "0x4005882")]
	public const short SporeGas3 = 571;

	[Cpp2IlInjected.Token(Token = "0x4005883")]
	public const short SalamanderSpit = 572;

	[Cpp2IlInjected.Token(Token = "0x4005884")]
	public const short NebulaBolt = 573;

	[Cpp2IlInjected.Token(Token = "0x4005885")]
	public const short NebulaEye = 574;

	[Cpp2IlInjected.Token(Token = "0x4005886")]
	public const short NebulaSphere = 575;

	[Cpp2IlInjected.Token(Token = "0x4005887")]
	public const short NebulaLaser = 576;

	[Cpp2IlInjected.Token(Token = "0x4005888")]
	public const short VortexLaser = 577;

	[Cpp2IlInjected.Token(Token = "0x4005889")]
	public const short VortexVortexLightning = 578;

	[Cpp2IlInjected.Token(Token = "0x400588A")]
	public const short VortexVortexPortal = 579;

	[Cpp2IlInjected.Token(Token = "0x400588B")]
	public const short VortexLightning = 580;

	[Cpp2IlInjected.Token(Token = "0x400588C")]
	public const short VortexAcid = 581;

	[Cpp2IlInjected.Token(Token = "0x400588D")]
	public const short MechanicWrench = 582;

	[Cpp2IlInjected.Token(Token = "0x400588E")]
	public const short NurseSyringeHurt = 583;

	[Cpp2IlInjected.Token(Token = "0x400588F")]
	public const short NurseSyringeHeal = 584;

	[Cpp2IlInjected.Token(Token = "0x4005890")]
	public const short ClothiersCurse = 585;

	[Cpp2IlInjected.Token(Token = "0x4005891")]
	public const short DryadsWardCircle = 586;

	[Cpp2IlInjected.Token(Token = "0x4005892")]
	public const short PainterPaintball = 587;

	[Cpp2IlInjected.Token(Token = "0x4005893")]
	public const short PartyGirlGrenade = 588;

	[Cpp2IlInjected.Token(Token = "0x4005894")]
	public const short SantaBombs = 589;

	[Cpp2IlInjected.Token(Token = "0x4005895")]
	public const short TruffleSpore = 590;

	[Cpp2IlInjected.Token(Token = "0x4005896")]
	public const short MinecartMechLaser = 591;

	[Cpp2IlInjected.Token(Token = "0x4005897")]
	public const short MartianWalkerLaser = 592;

	[Cpp2IlInjected.Token(Token = "0x4005898")]
	public const short AncientDoomProjectile = 593;

	[Cpp2IlInjected.Token(Token = "0x4005899")]
	public const short BlowupSmoke = 594;

	[Cpp2IlInjected.Token(Token = "0x400589A")]
	public const short Arkhalis = 595;

	[Cpp2IlInjected.Token(Token = "0x400589B")]
	public const short DesertDjinnCurse = 596;

	[Cpp2IlInjected.Token(Token = "0x400589C")]
	public const short AmberBolt = 597;

	[Cpp2IlInjected.Token(Token = "0x400589D")]
	public const short BoneJavelin = 598;

	[Cpp2IlInjected.Token(Token = "0x400589E")]
	public const short BoneDagger = 599;

	[Cpp2IlInjected.Token(Token = "0x400589F")]
	public const short PortalGun = 600;

	[Cpp2IlInjected.Token(Token = "0x40058A0")]
	public const short PortalGunBolt = 601;

	[Cpp2IlInjected.Token(Token = "0x40058A1")]
	public const short PortalGunGate = 602;

	[Cpp2IlInjected.Token(Token = "0x40058A2")]
	public const short Terrarian = 603;

	[Cpp2IlInjected.Token(Token = "0x40058A3")]
	public const short TerrarianBeam = 604;

	[Cpp2IlInjected.Token(Token = "0x40058A4")]
	public const short SpikedSlimeSpike = 605;

	[Cpp2IlInjected.Token(Token = "0x40058A5")]
	public const short ScutlixLaser = 606;

	[Cpp2IlInjected.Token(Token = "0x40058A6")]
	public const short SolarFlareRay = 607;

	[Cpp2IlInjected.Token(Token = "0x40058A7")]
	public const short SolarCounter = 608;

	[Cpp2IlInjected.Token(Token = "0x40058A8")]
	public const short StardustDrill = 609;

	[Cpp2IlInjected.Token(Token = "0x40058A9")]
	public const short StardustChainsaw = 610;

	[Cpp2IlInjected.Token(Token = "0x40058AA")]
	public const short SolarWhipSword = 611;

	[Cpp2IlInjected.Token(Token = "0x40058AB")]
	public const short SolarWhipSwordExplosion = 612;

	[Cpp2IlInjected.Token(Token = "0x40058AC")]
	public const short StardustCellMinion = 613;

	[Cpp2IlInjected.Token(Token = "0x40058AD")]
	public const short StardustCellMinionShot = 614;

	[Cpp2IlInjected.Token(Token = "0x40058AE")]
	public const short VortexBeater = 615;

	[Cpp2IlInjected.Token(Token = "0x40058AF")]
	public const short VortexBeaterRocket = 616;

	[Cpp2IlInjected.Token(Token = "0x40058B0")]
	public const short NebulaArcanum = 617;

	[Cpp2IlInjected.Token(Token = "0x40058B1")]
	public const short NebulaArcanumSubshot = 618;

	[Cpp2IlInjected.Token(Token = "0x40058B2")]
	public const short NebulaArcanumExplosionShot = 619;

	[Cpp2IlInjected.Token(Token = "0x40058B3")]
	public const short NebulaArcanumExplosionShotShard = 620;

	[Cpp2IlInjected.Token(Token = "0x40058B4")]
	public const short BloodWater = 621;

	[Cpp2IlInjected.Token(Token = "0x40058B5")]
	public const short BlowupSmokeMoonlord = 622;

	[Cpp2IlInjected.Token(Token = "0x40058B6")]
	public const short StardustGuardian = 623;

	[Cpp2IlInjected.Token(Token = "0x40058B7")]
	public const short StardustGuardianExplosion = 624;

	[Cpp2IlInjected.Token(Token = "0x40058B8")]
	public const short StardustDragon1 = 625;

	[Cpp2IlInjected.Token(Token = "0x40058B9")]
	public const short StardustDragon2 = 626;

	[Cpp2IlInjected.Token(Token = "0x40058BA")]
	public const short StardustDragon3 = 627;

	[Cpp2IlInjected.Token(Token = "0x40058BB")]
	public const short StardustDragon4 = 628;

	[Cpp2IlInjected.Token(Token = "0x40058BC")]
	public const short TowerDamageBolt = 629;

	[Cpp2IlInjected.Token(Token = "0x40058BD")]
	public const short Phantasm = 630;

	[Cpp2IlInjected.Token(Token = "0x40058BE")]
	public const short PhantasmArrow = 631;

	[Cpp2IlInjected.Token(Token = "0x40058BF")]
	public const short LastPrismLaser = 632;

	[Cpp2IlInjected.Token(Token = "0x40058C0")]
	public const short LastPrism = 633;

	[Cpp2IlInjected.Token(Token = "0x40058C1")]
	public const short NebulaBlaze1 = 634;

	[Cpp2IlInjected.Token(Token = "0x40058C2")]
	public const short NebulaBlaze2 = 635;

	[Cpp2IlInjected.Token(Token = "0x40058C3")]
	public const short Daybreak = 636;

	[Cpp2IlInjected.Token(Token = "0x40058C4")]
	public const short BouncyDynamite = 637;

	[Cpp2IlInjected.Token(Token = "0x40058C5")]
	public const short MoonlordBullet = 638;

	[Cpp2IlInjected.Token(Token = "0x40058C6")]
	public const short MoonlordArrow = 639;

	[Cpp2IlInjected.Token(Token = "0x40058C7")]
	public const short MoonlordArrowTrail = 640;

	[Cpp2IlInjected.Token(Token = "0x40058C8")]
	public const short MoonlordTurret = 641;

	[Cpp2IlInjected.Token(Token = "0x40058C9")]
	public const short MoonlordTurretLaser = 642;

	[Cpp2IlInjected.Token(Token = "0x40058CA")]
	public const short RainbowCrystal = 643;

	[Cpp2IlInjected.Token(Token = "0x40058CB")]
	public const short RainbowCrystalExplosion = 644;

	[Cpp2IlInjected.Token(Token = "0x40058CC")]
	public const short LunarFlare = 645;

	[Cpp2IlInjected.Token(Token = "0x40058CD")]
	public const short LunarHookSolar = 646;

	[Cpp2IlInjected.Token(Token = "0x40058CE")]
	public const short LunarHookVortex = 647;

	[Cpp2IlInjected.Token(Token = "0x40058CF")]
	public const short LunarHookNebula = 648;

	[Cpp2IlInjected.Token(Token = "0x40058D0")]
	public const short LunarHookStardust = 649;

	[Cpp2IlInjected.Token(Token = "0x40058D1")]
	public const short SuspiciousTentacle = 650;

	[Cpp2IlInjected.Token(Token = "0x40058D2")]
	public const short WireKite = 651;

	[Cpp2IlInjected.Token(Token = "0x40058D3")]
	public const short StaticHook = 652;

	[Cpp2IlInjected.Token(Token = "0x40058D4")]
	public const short CompanionCube = 653;

	[Cpp2IlInjected.Token(Token = "0x40058D5")]
	public const short GeyserTrap = 654;

	[Cpp2IlInjected.Token(Token = "0x40058D6")]
	public const short BeeHive = 655;

	[Cpp2IlInjected.Token(Token = "0x40058D7")]
	public const short SandnadoFriendly = 656;

	[Cpp2IlInjected.Token(Token = "0x40058D8")]
	public const short SandnadoHostile = 657;

	[Cpp2IlInjected.Token(Token = "0x40058D9")]
	public const short SandnadoHostileMark = 658;

	[Cpp2IlInjected.Token(Token = "0x40058DA")]
	public const short SpiritFlame = 659;

	[Cpp2IlInjected.Token(Token = "0x40058DB")]
	public const short SkyFracture = 660;

	[Cpp2IlInjected.Token(Token = "0x40058DC")]
	public const short BlackBolt = 661;

	[Cpp2IlInjected.Token(Token = "0x40058DD")]
	public const short DD2JavelinHostile = 662;

	[Cpp2IlInjected.Token(Token = "0x40058DE")]
	public const short DD2FlameBurstTowerT1 = 663;

	[Cpp2IlInjected.Token(Token = "0x40058DF")]
	public const short DD2FlameBurstTowerT1Shot = 664;

	[Cpp2IlInjected.Token(Token = "0x40058E0")]
	public const short DD2FlameBurstTowerT2 = 665;

	[Cpp2IlInjected.Token(Token = "0x40058E1")]
	public const short DD2FlameBurstTowerT2Shot = 666;

	[Cpp2IlInjected.Token(Token = "0x40058E2")]
	public const short DD2FlameBurstTowerT3 = 667;

	[Cpp2IlInjected.Token(Token = "0x40058E3")]
	public const short DD2FlameBurstTowerT3Shot = 668;

	[Cpp2IlInjected.Token(Token = "0x40058E4")]
	public const short Ale = 669;

	[Cpp2IlInjected.Token(Token = "0x40058E5")]
	public const short DD2OgreStomp = 670;

	[Cpp2IlInjected.Token(Token = "0x40058E6")]
	public const short DD2DrakinShot = 671;

	[Cpp2IlInjected.Token(Token = "0x40058E7")]
	public const short DD2ElderWins = 672;

	[Cpp2IlInjected.Token(Token = "0x40058E8")]
	public const short DD2DarkMageRaise = 673;

	[Cpp2IlInjected.Token(Token = "0x40058E9")]
	public const short DD2DarkMageHeal = 674;

	[Cpp2IlInjected.Token(Token = "0x40058EA")]
	public const short DD2DarkMageBolt = 675;

	[Cpp2IlInjected.Token(Token = "0x40058EB")]
	public const short DD2OgreSpit = 676;

	[Cpp2IlInjected.Token(Token = "0x40058EC")]
	public const short DD2BallistraTowerT1 = 677;

	[Cpp2IlInjected.Token(Token = "0x40058ED")]
	public const short DD2BallistraTowerT2 = 678;

	[Cpp2IlInjected.Token(Token = "0x40058EE")]
	public const short DD2BallistraTowerT3 = 679;

	[Cpp2IlInjected.Token(Token = "0x40058EF")]
	public const short DD2BallistraProj = 680;

	[Cpp2IlInjected.Token(Token = "0x40058F0")]
	public const short DD2GoblinBomb = 681;

	[Cpp2IlInjected.Token(Token = "0x40058F1")]
	public const short DD2LightningBugZap = 682;

	[Cpp2IlInjected.Token(Token = "0x40058F2")]
	public const short DD2OgreSmash = 683;

	[Cpp2IlInjected.Token(Token = "0x40058F3")]
	public const short DD2SquireSonicBoom = 684;

	[Cpp2IlInjected.Token(Token = "0x40058F4")]
	public const short DD2JavelinHostileT3 = 685;

	[Cpp2IlInjected.Token(Token = "0x40058F5")]
	public const short DD2BetsyFireball = 686;

	[Cpp2IlInjected.Token(Token = "0x40058F6")]
	public const short DD2BetsyFlameBreath = 687;

	[Cpp2IlInjected.Token(Token = "0x40058F7")]
	public const short DD2LightningAuraT1 = 688;

	[Cpp2IlInjected.Token(Token = "0x40058F8")]
	public const short DD2LightningAuraT2 = 689;

	[Cpp2IlInjected.Token(Token = "0x40058F9")]
	public const short DD2LightningAuraT3 = 690;

	[Cpp2IlInjected.Token(Token = "0x40058FA")]
	public const short DD2ExplosiveTrapT1 = 691;

	[Cpp2IlInjected.Token(Token = "0x40058FB")]
	public const short DD2ExplosiveTrapT2 = 692;

	[Cpp2IlInjected.Token(Token = "0x40058FC")]
	public const short DD2ExplosiveTrapT3 = 693;

	[Cpp2IlInjected.Token(Token = "0x40058FD")]
	public const short DD2ExplosiveTrapT1Explosion = 694;

	[Cpp2IlInjected.Token(Token = "0x40058FE")]
	public const short DD2ExplosiveTrapT2Explosion = 695;

	[Cpp2IlInjected.Token(Token = "0x40058FF")]
	public const short DD2ExplosiveTrapT3Explosion = 696;

	[Cpp2IlInjected.Token(Token = "0x4005900")]
	public const short MonkStaffT1 = 697;

	[Cpp2IlInjected.Token(Token = "0x4005901")]
	public const short MonkStaffT1Explosion = 698;

	[Cpp2IlInjected.Token(Token = "0x4005902")]
	public const short MonkStaffT2 = 699;

	[Cpp2IlInjected.Token(Token = "0x4005903")]
	public const short MonkStaffT2Ghast = 700;

	[Cpp2IlInjected.Token(Token = "0x4005904")]
	public const short DD2PetDragon = 701;

	[Cpp2IlInjected.Token(Token = "0x4005905")]
	public const short DD2PetGhost = 702;

	[Cpp2IlInjected.Token(Token = "0x4005906")]
	public const short DD2PetGato = 703;

	[Cpp2IlInjected.Token(Token = "0x4005907")]
	public const short DD2ApprenticeStorm = 704;

	[Cpp2IlInjected.Token(Token = "0x4005908")]
	public const short DD2PhoenixBow = 705;

	[Cpp2IlInjected.Token(Token = "0x4005909")]
	public const short DD2PhoenixBowShot = 706;

	[Cpp2IlInjected.Token(Token = "0x400590A")]
	public const short MonkStaffT3 = 707;

	[Cpp2IlInjected.Token(Token = "0x400590B")]
	public const short MonkStaffT3_Alt = 708;

	[Cpp2IlInjected.Token(Token = "0x400590C")]
	public const short MonkStaffT3_AltShot = 709;

	[Cpp2IlInjected.Token(Token = "0x400590D")]
	public const short DD2BetsyArrow = 710;

	[Cpp2IlInjected.Token(Token = "0x400590E")]
	public const short ApprenticeStaffT3Shot = 711;

	[Cpp2IlInjected.Token(Token = "0x400590F")]
	public const short BookStaffShot = 712;

	[Cpp2IlInjected.Token(Token = "0x4005910")]
	public const short DD2Win = 713;

	[Cpp2IlInjected.Token(Token = "0x4005911")]
	public const short Celeb2Weapon = 714;

	[Cpp2IlInjected.Token(Token = "0x4005912")]
	public const short Celeb2Rocket = 715;

	[Cpp2IlInjected.Token(Token = "0x4005913")]
	public const short Celeb2RocketExplosive = 716;

	[Cpp2IlInjected.Token(Token = "0x4005914")]
	public const short Celeb2RocketLarge = 717;

	[Cpp2IlInjected.Token(Token = "0x4005915")]
	public const short Celeb2RocketExplosiveLarge = 718;

	[Cpp2IlInjected.Token(Token = "0x4005916")]
	public const short QueenBeeStinger = 719;

	[Cpp2IlInjected.Token(Token = "0x4005917")]
	public const short FallingStarSpawner = 720;

	[Cpp2IlInjected.Token(Token = "0x4005918")]
	public const short DirtGolfBall = 721;

	[Cpp2IlInjected.Token(Token = "0x4005919")]
	public const short GolfClubHelper = 722;

	[Cpp2IlInjected.Token(Token = "0x400591A")]
	public const short ManaCloakStar = 723;

	[Cpp2IlInjected.Token(Token = "0x400591B")]
	public const short BeeCloakStar = 724;

	[Cpp2IlInjected.Token(Token = "0x400591C")]
	public const short StarVeilStar = 725;

	[Cpp2IlInjected.Token(Token = "0x400591D")]
	public const short StarCloakStar = 726;

	[Cpp2IlInjected.Token(Token = "0x400591E")]
	public const short RollingCactus = 727;

	[Cpp2IlInjected.Token(Token = "0x400591F")]
	public const short SuperStar = 728;

	[Cpp2IlInjected.Token(Token = "0x4005920")]
	public const short SuperStarSlash = 729;

	[Cpp2IlInjected.Token(Token = "0x4005921")]
	public const short ThunderSpear = 730;

	[Cpp2IlInjected.Token(Token = "0x4005922")]
	public const short ThunderStaffShot = 731;

	[Cpp2IlInjected.Token(Token = "0x4005923")]
	public const short ThunderSpearShot = 732;

	[Cpp2IlInjected.Token(Token = "0x4005924")]
	public const short ToiletEffect = 733;

	[Cpp2IlInjected.Token(Token = "0x4005925")]
	public const short VoidLens = 734;

	[Cpp2IlInjected.Token(Token = "0x4005926")]
	public const short Terragrim = 735;

	[Cpp2IlInjected.Token(Token = "0x4005927")]
	public const short BlueDungeonDebris = 736;

	[Cpp2IlInjected.Token(Token = "0x4005928")]
	public const short GreenDungeonDebris = 737;

	[Cpp2IlInjected.Token(Token = "0x4005929")]
	public const short PinkDungeonDebris = 738;

	[Cpp2IlInjected.Token(Token = "0x400592A")]
	public const short GolfBallDyedBlack = 739;

	[Cpp2IlInjected.Token(Token = "0x400592B")]
	public const short GolfBallDyedBlue = 740;

	[Cpp2IlInjected.Token(Token = "0x400592C")]
	public const short GolfBallDyedBrown = 741;

	[Cpp2IlInjected.Token(Token = "0x400592D")]
	public const short GolfBallDyedCyan = 742;

	[Cpp2IlInjected.Token(Token = "0x400592E")]
	public const short GolfBallDyedGreen = 743;

	[Cpp2IlInjected.Token(Token = "0x400592F")]
	public const short GolfBallDyedLimeGreen = 744;

	[Cpp2IlInjected.Token(Token = "0x4005930")]
	public const short GolfBallDyedOrange = 745;

	[Cpp2IlInjected.Token(Token = "0x4005931")]
	public const short GolfBallDyedPink = 746;

	[Cpp2IlInjected.Token(Token = "0x4005932")]
	public const short GolfBallDyedPurple = 747;

	[Cpp2IlInjected.Token(Token = "0x4005933")]
	public const short GolfBallDyedRed = 748;

	[Cpp2IlInjected.Token(Token = "0x4005934")]
	public const short GolfBallDyedSkyBlue = 749;

	[Cpp2IlInjected.Token(Token = "0x4005935")]
	public const short GolfBallDyedTeal = 750;

	[Cpp2IlInjected.Token(Token = "0x4005936")]
	public const short GolfBallDyedViolet = 751;

	[Cpp2IlInjected.Token(Token = "0x4005937")]
	public const short GolfBallDyedYellow = 752;

	[Cpp2IlInjected.Token(Token = "0x4005938")]
	public const short AmberHook = 753;

	[Cpp2IlInjected.Token(Token = "0x4005939")]
	public const short MysticSnakeCoil = 754;

	[Cpp2IlInjected.Token(Token = "0x400593A")]
	public const short BatOfLight = 755;

	[Cpp2IlInjected.Token(Token = "0x400593B")]
	public const short SharpTears = 756;

	[Cpp2IlInjected.Token(Token = "0x400593C")]
	public const short DripplerFlail = 757;

	[Cpp2IlInjected.Token(Token = "0x400593D")]
	public const short VampireFrog = 758;

	[Cpp2IlInjected.Token(Token = "0x400593E")]
	public const short BabyBird = 759;

	[Cpp2IlInjected.Token(Token = "0x400593F")]
	public const short BobberBloody = 760;

	[Cpp2IlInjected.Token(Token = "0x4005940")]
	public const short PaperAirplaneA = 761;

	[Cpp2IlInjected.Token(Token = "0x4005941")]
	public const short PaperAirplaneB = 762;

	[Cpp2IlInjected.Token(Token = "0x4005942")]
	public const short RollingCactusSpike = 763;

	[Cpp2IlInjected.Token(Token = "0x4005943")]
	public const short UpbeatStar = 764;

	[Cpp2IlInjected.Token(Token = "0x4005944")]
	public const short SugarGlider = 765;

	[Cpp2IlInjected.Token(Token = "0x4005945")]
	public const short KiteBlue = 766;

	[Cpp2IlInjected.Token(Token = "0x4005946")]
	public const short KiteBlueAndYellow = 767;

	[Cpp2IlInjected.Token(Token = "0x4005947")]
	public const short KiteRed = 768;

	[Cpp2IlInjected.Token(Token = "0x4005948")]
	public const short KiteRedAndYellow = 769;

	[Cpp2IlInjected.Token(Token = "0x4005949")]
	public const short KiteYellow = 770;

	[Cpp2IlInjected.Token(Token = "0x400594A")]
	public const short KiteWyvern = 771;

	[Cpp2IlInjected.Token(Token = "0x400594B")]
	public const short Geode = 772;

	[Cpp2IlInjected.Token(Token = "0x400594C")]
	public const short ScarabBomb = 773;

	[Cpp2IlInjected.Token(Token = "0x400594D")]
	public const short SharkPup = 774;

	[Cpp2IlInjected.Token(Token = "0x400594E")]
	public const short BobberScarab = 775;

	[Cpp2IlInjected.Token(Token = "0x400594F")]
	public const short ClusterRocketI = 776;

	[Cpp2IlInjected.Token(Token = "0x4005950")]
	public const short ClusterGrenadeI = 777;

	[Cpp2IlInjected.Token(Token = "0x4005951")]
	public const short ClusterMineI = 778;

	[Cpp2IlInjected.Token(Token = "0x4005952")]
	public const short ClusterFragmentsI = 779;

	[Cpp2IlInjected.Token(Token = "0x4005953")]
	public const short ClusterRocketII = 780;

	[Cpp2IlInjected.Token(Token = "0x4005954")]
	public const short ClusterGrenadeII = 781;

	[Cpp2IlInjected.Token(Token = "0x4005955")]
	public const short ClusterMineII = 782;

	[Cpp2IlInjected.Token(Token = "0x4005956")]
	public const short ClusterFragmentsII = 783;

	[Cpp2IlInjected.Token(Token = "0x4005957")]
	public const short WetRocket = 784;

	[Cpp2IlInjected.Token(Token = "0x4005958")]
	public const short WetGrenade = 785;

	[Cpp2IlInjected.Token(Token = "0x4005959")]
	public const short WetMine = 786;

	[Cpp2IlInjected.Token(Token = "0x400595A")]
	public const short LavaRocket = 787;

	[Cpp2IlInjected.Token(Token = "0x400595B")]
	public const short LavaGrenade = 788;

	[Cpp2IlInjected.Token(Token = "0x400595C")]
	public const short LavaMine = 789;

	[Cpp2IlInjected.Token(Token = "0x400595D")]
	public const short HoneyRocket = 790;

	[Cpp2IlInjected.Token(Token = "0x400595E")]
	public const short HoneyGrenade = 791;

	[Cpp2IlInjected.Token(Token = "0x400595F")]
	public const short HoneyMine = 792;

	[Cpp2IlInjected.Token(Token = "0x4005960")]
	public const short MiniNukeRocketI = 793;

	[Cpp2IlInjected.Token(Token = "0x4005961")]
	public const short MiniNukeGrenadeI = 794;

	[Cpp2IlInjected.Token(Token = "0x4005962")]
	public const short MiniNukeMineI = 795;

	[Cpp2IlInjected.Token(Token = "0x4005963")]
	public const short MiniNukeRocketII = 796;

	[Cpp2IlInjected.Token(Token = "0x4005964")]
	public const short MiniNukeGrenadeII = 797;

	[Cpp2IlInjected.Token(Token = "0x4005965")]
	public const short MiniNukeMineII = 798;

	[Cpp2IlInjected.Token(Token = "0x4005966")]
	public const short DryRocket = 799;

	[Cpp2IlInjected.Token(Token = "0x4005967")]
	public const short DryGrenade = 800;

	[Cpp2IlInjected.Token(Token = "0x4005968")]
	public const short DryMine = 801;

	[Cpp2IlInjected.Token(Token = "0x4005969")]
	public const short GladiusStab = 802;

	[Cpp2IlInjected.Token(Token = "0x400596A")]
	public const short ClusterSnowmanRocketI = 803;

	[Cpp2IlInjected.Token(Token = "0x400596B")]
	public const short ClusterSnowmanRocketII = 804;

	[Cpp2IlInjected.Token(Token = "0x400596C")]
	public const short WetSnowmanRocket = 805;

	[Cpp2IlInjected.Token(Token = "0x400596D")]
	public const short LavaSnowmanRocket = 806;

	[Cpp2IlInjected.Token(Token = "0x400596E")]
	public const short HoneySnowmanRocket = 807;

	[Cpp2IlInjected.Token(Token = "0x400596F")]
	public const short MiniNukeSnowmanRocketI = 808;

	[Cpp2IlInjected.Token(Token = "0x4005970")]
	public const short MiniNukeSnowmanRocketII = 809;

	[Cpp2IlInjected.Token(Token = "0x4005971")]
	public const short DrySnowmanRocket = 810;

	[Cpp2IlInjected.Token(Token = "0x4005972")]
	public const short BloodShot = 811;

	[Cpp2IlInjected.Token(Token = "0x4005973")]
	public const short ShellPileFalling = 812;

	[Cpp2IlInjected.Token(Token = "0x4005974")]
	public const short BloodNautilusTears = 813;

	[Cpp2IlInjected.Token(Token = "0x4005975")]
	public const short BloodNautilusShot = 814;

	[Cpp2IlInjected.Token(Token = "0x4005976")]
	public const short LilHarpy = 815;

	[Cpp2IlInjected.Token(Token = "0x4005977")]
	public const short FennecFox = 816;

	[Cpp2IlInjected.Token(Token = "0x4005978")]
	public const short GlitteryButterfly = 817;

	[Cpp2IlInjected.Token(Token = "0x4005979")]
	public const short WhiteTigerPounce = 818;

	[Cpp2IlInjected.Token(Token = "0x400597A")]
	public const short BloodArrow = 819;

	[Cpp2IlInjected.Token(Token = "0x400597B")]
	public const short ChumBucket = 820;

	[Cpp2IlInjected.Token(Token = "0x400597C")]
	public const short BabyImp = 821;

	[Cpp2IlInjected.Token(Token = "0x400597D")]
	public const short KiteBoneSerpent = 822;

	[Cpp2IlInjected.Token(Token = "0x400597E")]
	public const short KiteWorldFeeder = 823;

	[Cpp2IlInjected.Token(Token = "0x400597F")]
	public const short KiteBunny = 824;

	[Cpp2IlInjected.Token(Token = "0x4005980")]
	public const short BabyRedPanda = 825;

	[Cpp2IlInjected.Token(Token = "0x4005981")]
	public const short KitePigron = 826;

	[Cpp2IlInjected.Token(Token = "0x4005982")]
	public const short KiteManEater = 827;

	[Cpp2IlInjected.Token(Token = "0x4005983")]
	public const short KiteJellyfishBlue = 828;

	[Cpp2IlInjected.Token(Token = "0x4005984")]
	public const short KiteJellyfishPink = 829;

	[Cpp2IlInjected.Token(Token = "0x4005985")]
	public const short KiteShark = 830;

	[Cpp2IlInjected.Token(Token = "0x4005986")]
	public const short StormTigerGem = 831;

	[Cpp2IlInjected.Token(Token = "0x4005987")]
	public const short StormTigerAttack = 832;

	[Cpp2IlInjected.Token(Token = "0x4005988")]
	public const short StormTigerTier1 = 833;

	[Cpp2IlInjected.Token(Token = "0x4005989")]
	public const short StormTigerTier2 = 834;

	[Cpp2IlInjected.Token(Token = "0x400598A")]
	public const short StormTigerTier3 = 835;

	[Cpp2IlInjected.Token(Token = "0x400598B")]
	public const short DandelionSeed = 836;

	[Cpp2IlInjected.Token(Token = "0x400598C")]
	public const short BookOfSkullsSkull = 837;

	[Cpp2IlInjected.Token(Token = "0x400598D")]
	public const short KiteSandShark = 838;

	[Cpp2IlInjected.Token(Token = "0x400598E")]
	public const short KiteBunnyCorrupt = 839;

	[Cpp2IlInjected.Token(Token = "0x400598F")]
	public const short KiteBunnyCrimson = 840;

	[Cpp2IlInjected.Token(Token = "0x4005990")]
	public const short BlandWhip = 841;

	[Cpp2IlInjected.Token(Token = "0x4005991")]
	public const short RulerStab = 842;

	[Cpp2IlInjected.Token(Token = "0x4005992")]
	public const short KiteGoldfish = 843;

	[Cpp2IlInjected.Token(Token = "0x4005993")]
	public const short KiteAngryTrapper = 844;

	[Cpp2IlInjected.Token(Token = "0x4005994")]
	public const short KiteKoi = 845;

	[Cpp2IlInjected.Token(Token = "0x4005995")]
	public const short KiteCrawltipede = 846;

	[Cpp2IlInjected.Token(Token = "0x4005996")]
	public const short SwordWhip = 847;

	[Cpp2IlInjected.Token(Token = "0x4005997")]
	public const short MaceWhip = 848;

	[Cpp2IlInjected.Token(Token = "0x4005998")]
	public const short ScytheWhip = 849;

	[Cpp2IlInjected.Token(Token = "0x4005999")]
	public const short KiteSpectrum = 850;

	[Cpp2IlInjected.Token(Token = "0x400599A")]
	public const short ReleaseDoves = 851;

	[Cpp2IlInjected.Token(Token = "0x400599B")]
	public const short KiteWanderingEye = 852;

	[Cpp2IlInjected.Token(Token = "0x400599C")]
	public const short KiteUnicorn = 853;

	[Cpp2IlInjected.Token(Token = "0x400599D")]
	public const short Plantero = 854;

	[Cpp2IlInjected.Token(Token = "0x400599E")]
	public const short ReleaseLantern = 855;

	[Cpp2IlInjected.Token(Token = "0x400599F")]
	public const short SparkleGuitar = 856;

	[Cpp2IlInjected.Token(Token = "0x40059A0")]
	public const short FirstFractal = 857;

	[Cpp2IlInjected.Token(Token = "0x40059A1")]
	public const short DynamiteKitten = 858;

	[Cpp2IlInjected.Token(Token = "0x40059A2")]
	public const short BabyWerewolf = 859;

	[Cpp2IlInjected.Token(Token = "0x40059A3")]
	public const short ShadowMimic = 860;

	[Cpp2IlInjected.Token(Token = "0x40059A4")]
	public const short Football = 861;

	[Cpp2IlInjected.Token(Token = "0x40059A5")]
	public const short ClusterSnowmanFragmentsI = 862;

	[Cpp2IlInjected.Token(Token = "0x40059A6")]
	public const short ClusterSnowmanFragmentsII = 863;

	[Cpp2IlInjected.Token(Token = "0x40059A7")]
	public const short Smolstar = 864;

	[Cpp2IlInjected.Token(Token = "0x40059A8")]
	public const short SquirrelHook = 865;

	[Cpp2IlInjected.Token(Token = "0x40059A9")]
	public const short BouncingShield = 866;

	[Cpp2IlInjected.Token(Token = "0x40059AA")]
	public const short Shroomerang = 867;

	[Cpp2IlInjected.Token(Token = "0x40059AB")]
	public const short TreeGlobe = 868;

	[Cpp2IlInjected.Token(Token = "0x40059AC")]
	public const short WorldGlobe = 869;

	[Cpp2IlInjected.Token(Token = "0x40059AD")]
	public const short FairyGlowstick = 870;

	[Cpp2IlInjected.Token(Token = "0x40059AE")]
	public const short HallowBossSplitShotCore = 871;

	[Cpp2IlInjected.Token(Token = "0x40059AF")]
	public const short HallowBossLastingRainbow = 872;

	[Cpp2IlInjected.Token(Token = "0x40059B0")]
	public const short HallowBossRainbowStreak = 873;

	[Cpp2IlInjected.Token(Token = "0x40059B1")]
	public const short HallowBossDeathAurora = 874;

	[Cpp2IlInjected.Token(Token = "0x40059B2")]
	public const short VoltBunny = 875;

	[Cpp2IlInjected.Token(Token = "0x40059B3")]
	public const short ZapinatorLaser = 876;

	[Cpp2IlInjected.Token(Token = "0x40059B4")]
	public const short JoustingLance = 877;

	[Cpp2IlInjected.Token(Token = "0x40059B5")]
	public const short ShadowJoustingLance = 878;

	[Cpp2IlInjected.Token(Token = "0x40059B6")]
	public const short HallowJoustingLance = 879;

	[Cpp2IlInjected.Token(Token = "0x40059B7")]
	public const short ZoologistStrikeGreen = 880;

	[Cpp2IlInjected.Token(Token = "0x40059B8")]
	public const short KingSlimePet = 881;

	[Cpp2IlInjected.Token(Token = "0x40059B9")]
	public const short EyeOfCthulhuPet = 882;

	[Cpp2IlInjected.Token(Token = "0x40059BA")]
	public const short EaterOfWorldsPet = 883;

	[Cpp2IlInjected.Token(Token = "0x40059BB")]
	public const short BrainOfCthulhuPet = 884;

	[Cpp2IlInjected.Token(Token = "0x40059BC")]
	public const short SkeletronPet = 885;

	[Cpp2IlInjected.Token(Token = "0x40059BD")]
	public const short QueenBeePet = 886;

	[Cpp2IlInjected.Token(Token = "0x40059BE")]
	public const short DestroyerPet = 887;

	[Cpp2IlInjected.Token(Token = "0x40059BF")]
	public const short TwinsPet = 888;

	[Cpp2IlInjected.Token(Token = "0x40059C0")]
	public const short SkeletronPrimePet = 889;

	[Cpp2IlInjected.Token(Token = "0x40059C1")]
	public const short PlanteraPet = 890;

	[Cpp2IlInjected.Token(Token = "0x40059C2")]
	public const short GolemPet = 891;

	[Cpp2IlInjected.Token(Token = "0x40059C3")]
	public const short DukeFishronPet = 892;

	[Cpp2IlInjected.Token(Token = "0x40059C4")]
	public const short LunaticCultistPet = 893;

	[Cpp2IlInjected.Token(Token = "0x40059C5")]
	public const short MoonLordPet = 894;

	[Cpp2IlInjected.Token(Token = "0x40059C6")]
	public const short FairyQueenPet = 895;

	[Cpp2IlInjected.Token(Token = "0x40059C7")]
	public const short PumpkingPet = 896;

	[Cpp2IlInjected.Token(Token = "0x40059C8")]
	public const short EverscreamPet = 897;

	[Cpp2IlInjected.Token(Token = "0x40059C9")]
	public const short IceQueenPet = 898;

	[Cpp2IlInjected.Token(Token = "0x40059CA")]
	public const short MartianPet = 899;

	[Cpp2IlInjected.Token(Token = "0x40059CB")]
	public const short DD2OgrePet = 900;

	[Cpp2IlInjected.Token(Token = "0x40059CC")]
	public const short DD2BetsyPet = 901;

	[Cpp2IlInjected.Token(Token = "0x40059CD")]
	public const short CombatWrench = 902;

	[Cpp2IlInjected.Token(Token = "0x40059CE")]
	public const short WetBomb = 903;

	[Cpp2IlInjected.Token(Token = "0x40059CF")]
	public const short LavaBomb = 904;

	[Cpp2IlInjected.Token(Token = "0x40059D0")]
	public const short HoneyBomb = 905;

	[Cpp2IlInjected.Token(Token = "0x40059D1")]
	public const short DryBomb = 906;

	[Cpp2IlInjected.Token(Token = "0x40059D2")]
	public const short OrnamentStar = 907;

	[Cpp2IlInjected.Token(Token = "0x40059D3")]
	public const short TitaniumStormShard = 908;

	[Cpp2IlInjected.Token(Token = "0x40059D4")]
	public const short RockGolemRock = 909;

	[Cpp2IlInjected.Token(Token = "0x40059D5")]
	public const short DirtBomb = 910;

	[Cpp2IlInjected.Token(Token = "0x40059D6")]
	public const short DirtStickyBomb = 911;

	[Cpp2IlInjected.Token(Token = "0x40059D7")]
	public const short CoolWhip = 912;

	[Cpp2IlInjected.Token(Token = "0x40059D8")]
	public const short FireWhip = 913;

	[Cpp2IlInjected.Token(Token = "0x40059D9")]
	public const short ThornWhip = 914;

	[Cpp2IlInjected.Token(Token = "0x40059DA")]
	public const short RainbowWhip = 915;

	[Cpp2IlInjected.Token(Token = "0x40059DB")]
	public const short ScytheWhipProj = 916;

	[Cpp2IlInjected.Token(Token = "0x40059DC")]
	public const short CoolWhipProj = 917;

	[Cpp2IlInjected.Token(Token = "0x40059DD")]
	public const short FireWhipProj = 918;

	[Cpp2IlInjected.Token(Token = "0x40059DE")]
	public const short FairyQueenLance = 919;

	[Cpp2IlInjected.Token(Token = "0x40059DF")]
	public const short QueenSlimeMinionBlueSpike = 920;

	[Cpp2IlInjected.Token(Token = "0x40059E0")]
	public const short QueenSlimeMinionPinkBall = 921;

	[Cpp2IlInjected.Token(Token = "0x40059E1")]
	public const short QueenSlimeSmash = 922;

	[Cpp2IlInjected.Token(Token = "0x40059E2")]
	public const short FairyQueenSunDance = 923;

	[Cpp2IlInjected.Token(Token = "0x40059E3")]
	public const short FairyQueenHymn = 924;

	[Cpp2IlInjected.Token(Token = "0x40059E4")]
	public const short StardustPunch = 925;

	[Cpp2IlInjected.Token(Token = "0x40059E5")]
	public const short QueenSlimeGelAttack = 926;

	[Cpp2IlInjected.Token(Token = "0x40059E6")]
	public const short PiercingStarlight = 927;

	[Cpp2IlInjected.Token(Token = "0x40059E7")]
	public const short DripplerFlailExtraBall = 928;

	[Cpp2IlInjected.Token(Token = "0x40059E8")]
	public const short ZoologistStrikeRed = 929;

	[Cpp2IlInjected.Token(Token = "0x40059E9")]
	public const short SantankMountRocket = 930;

	[Cpp2IlInjected.Token(Token = "0x40059EA")]
	public const short FairyQueenMagicItemShot = 931;

	[Cpp2IlInjected.Token(Token = "0x40059EB")]
	public const short FairyQueenRangedItemShot = 932;

	[Cpp2IlInjected.Token(Token = "0x40059EC")]
	public const short FinalFractal = 933;

	[Cpp2IlInjected.Token(Token = "0x40059ED")]
	public const short QueenSlimePet = 934;

	[Cpp2IlInjected.Token(Token = "0x40059EE")]
	public const short QueenSlimeHook = 935;

	[Cpp2IlInjected.Token(Token = "0x40059EF")]
	public const short GelBalloon = 936;

	[Cpp2IlInjected.Token(Token = "0x40059F0")]
	public const short VolatileGelatinBall = 937;

	[Cpp2IlInjected.Token(Token = "0x40059F1")]
	public const short CopperShortswordStab = 938;

	[Cpp2IlInjected.Token(Token = "0x40059F2")]
	public const short TinShortswordStab = 939;

	[Cpp2IlInjected.Token(Token = "0x40059F3")]
	public const short IronShortswordStab = 940;

	[Cpp2IlInjected.Token(Token = "0x40059F4")]
	public const short LeadShortswordStab = 941;

	[Cpp2IlInjected.Token(Token = "0x40059F5")]
	public const short SilverShortswordStab = 942;

	[Cpp2IlInjected.Token(Token = "0x40059F6")]
	public const short TungstenShortswordStab = 943;

	[Cpp2IlInjected.Token(Token = "0x40059F7")]
	public const short GoldShortswordStab = 944;

	[Cpp2IlInjected.Token(Token = "0x40059F8")]
	public const short PlatinumShortswordStab = 945;

	[Cpp2IlInjected.Token(Token = "0x40059F9")]
	public const short EmpressBlade = 946;

	[Cpp2IlInjected.Token(Token = "0x40059FA")]
	public const short Mace = 947;

	[Cpp2IlInjected.Token(Token = "0x40059FB")]
	public const short FlamingMace = 948;

	[Cpp2IlInjected.Token(Token = "0x40059FC")]
	public const short TorchGod = 949;

	[Cpp2IlInjected.Token(Token = "0x40059FD")]
	public const short PrincessWeapon = 950;

	[Cpp2IlInjected.Token(Token = "0x40059FE")]
	public const short FlinxMinion = 951;

	[Cpp2IlInjected.Token(Token = "0x40059FF")]
	public const short BoneWhip = 952;

	[Cpp2IlInjected.Token(Token = "0x4005A00")]
	public const short DaybreakExplosion = 953;

	[Cpp2IlInjected.Token(Token = "0x4005A01")]
	public const short WandOfSparkingSpark = 954;

	[Cpp2IlInjected.Token(Token = "0x4005A02")]
	public const short StarCannonStar = 955;

	[Cpp2IlInjected.Token(Token = "0x4005A03")]
	public const short BerniePet = 956;

	[Cpp2IlInjected.Token(Token = "0x4005A04")]
	public const short GlommerPet = 957;

	[Cpp2IlInjected.Token(Token = "0x4005A05")]
	public const short DeerclopsPet = 958;

	[Cpp2IlInjected.Token(Token = "0x4005A06")]
	public const short PigPet = 959;

	[Cpp2IlInjected.Token(Token = "0x4005A07")]
	public const short ChesterPet = 960;

	[Cpp2IlInjected.Token(Token = "0x4005A08")]
	public const short DeerclopsIceSpike = 961;

	[Cpp2IlInjected.Token(Token = "0x4005A09")]
	public const short DeerclopsRangedProjectile = 962;

	[Cpp2IlInjected.Token(Token = "0x4005A0A")]
	public const short AbigailMinion = 963;

	[Cpp2IlInjected.Token(Token = "0x4005A0B")]
	public const short InsanityShadowFriendly = 964;

	[Cpp2IlInjected.Token(Token = "0x4005A0C")]
	public const short InsanityShadowHostile = 965;

	[Cpp2IlInjected.Token(Token = "0x4005A0D")]
	public const short HoundiusShootius = 966;

	[Cpp2IlInjected.Token(Token = "0x4005A0E")]
	public const short HoundiusShootiusFireball = 967;

	[Cpp2IlInjected.Token(Token = "0x4005A0F")]
	public const short PewMaticHornShot = 968;

	[Cpp2IlInjected.Token(Token = "0x4005A10")]
	public const short WeatherPainShot = 969;

	[Cpp2IlInjected.Token(Token = "0x4005A11")]
	public const short AbigailCounter = 970;

	[Cpp2IlInjected.Token(Token = "0x4005A12")]
	public const short TentacleSpike = 971;

	[Cpp2IlInjected.Token(Token = "0x4005A13")]
	public const short NightsEdge = 972;

	[Cpp2IlInjected.Token(Token = "0x4005A14")]
	public const short TrueNightsEdge = 973;

	[Cpp2IlInjected.Token(Token = "0x4005A15")]
	public const short LightsBane = 974;

	[Cpp2IlInjected.Token(Token = "0x4005A16")]
	public const short BloodButcherer = 975;

	[Cpp2IlInjected.Token(Token = "0x4005A17")]
	public const short BladeOfGrass = 976;

	[Cpp2IlInjected.Token(Token = "0x4005A18")]
	public const short Muramasa = 977;

	[Cpp2IlInjected.Token(Token = "0x4005A19")]
	public const short Volcano = 978;

	[Cpp2IlInjected.Token(Token = "0x4005A1A")]
	public const short WandOfFrostingFrost = 979;

	[Cpp2IlInjected.Token(Token = "0x4005A1B")]
	public const short VenomDartTrap = 980;

	[Cpp2IlInjected.Token(Token = "0x4005A1C")]
	public const short SilverBullet = 981;

	[Cpp2IlInjected.Token(Token = "0x4005A1D")]
	public const short Excalibur = 982;

	[Cpp2IlInjected.Token(Token = "0x4005A1E")]
	public const short TrueExcalibur = 983;

	[Cpp2IlInjected.Token(Token = "0x4005A1F")]
	public const short TerraBlade2 = 984;

	[Cpp2IlInjected.Token(Token = "0x4005A20")]
	public const short TerraBlade2Shot = 985;

	[Cpp2IlInjected.Token(Token = "0x4005A21")]
	public const short FishingBobber = 986;

	[Cpp2IlInjected.Token(Token = "0x4005A22")]
	public const short FishingBobberGlowingStar = 987;

	[Cpp2IlInjected.Token(Token = "0x4005A23")]
	public const short FishingBobberGlowingLava = 988;

	[Cpp2IlInjected.Token(Token = "0x4005A24")]
	public const short FishingBobberGlowingKrypton = 989;

	[Cpp2IlInjected.Token(Token = "0x4005A25")]
	public const short FishingBobberGlowingXenon = 990;

	[Cpp2IlInjected.Token(Token = "0x4005A26")]
	public const short FishingBobberGlowingArgon = 991;

	[Cpp2IlInjected.Token(Token = "0x4005A27")]
	public const short FishingBobberGlowingViolet = 992;

	[Cpp2IlInjected.Token(Token = "0x4005A28")]
	public const short FishingBobberGlowingRainbow = 993;

	[Cpp2IlInjected.Token(Token = "0x4005A29")]
	public const short JunimoPet = 994;

	[Cpp2IlInjected.Token(Token = "0x4005A2A")]
	public const short JuminoStardropAnimation = 995;

	[Cpp2IlInjected.Token(Token = "0x4005A2B")]
	public const short MoonGlobe = 996;

	[Cpp2IlInjected.Token(Token = "0x4005A2C")]
	public const short TheHorsemansBlade = 997;

	[Cpp2IlInjected.Token(Token = "0x4005A2D")]
	public const short BlueChickenPet = 998;

	[Cpp2IlInjected.Token(Token = "0x4005A2E")]
	public const short HiveFive = 999;

	[Cpp2IlInjected.Token(Token = "0x4005A2F")]
	public const short Trimarang = 1000;

	[Cpp2IlInjected.Token(Token = "0x4005A30")]
	public const short HorsemanPumpkin = 1001;

	[Cpp2IlInjected.Token(Token = "0x4005A31")]
	public const short TNTBarrel = 1002;

	[Cpp2IlInjected.Token(Token = "0x4005A32")]
	public const short Spiffo = 1003;

	[Cpp2IlInjected.Token(Token = "0x4005A33")]
	public const short CavelingGardener = 1004;

	[Cpp2IlInjected.Token(Token = "0x4005A34")]
	public const short MiniBoulder = 1005;

	[Cpp2IlInjected.Token(Token = "0x4005A35")]
	public const short ShimmerArrow = 1006;

	[Cpp2IlInjected.Token(Token = "0x4005A36")]
	public const short GasTrap = 1007;

	[Cpp2IlInjected.Token(Token = "0x4005A37")]
	public const short SpelunkerFlare = 1008;

	[Cpp2IlInjected.Token(Token = "0x4005A38")]
	public const short CursedFlare = 1009;

	[Cpp2IlInjected.Token(Token = "0x4005A39")]
	public const short RainbowFlare = 1010;

	[Cpp2IlInjected.Token(Token = "0x4005A3A")]
	public const short ShimmerFlare = 1011;

	[Cpp2IlInjected.Token(Token = "0x4005A3B")]
	public const short Waffle = 1012;

	[Cpp2IlInjected.Token(Token = "0x4005A3C")]
	public const short BouncyBoulder = 1013;

	[Cpp2IlInjected.Token(Token = "0x4005A3D")]
	public const short LifeCrystalBoulder = 1014;

	[Cpp2IlInjected.Token(Token = "0x4005A3E")]
	public const short SandSpray = 1015;

	[Cpp2IlInjected.Token(Token = "0x4005A3F")]
	public const short SnowSpray = 1016;

	[Cpp2IlInjected.Token(Token = "0x4005A40")]
	public const short DirtSpray = 1017;

	[Cpp2IlInjected.Token(Token = "0x4005A41")]
	public const short DirtiestBlock = 1018;

	[Cpp2IlInjected.Token(Token = "0x4005A42")]
	public const short Fertilizer = 1019;

	[Cpp2IlInjected.Token(Token = "0x4005A43")]
	public const short JimsDrone = 1020;

	[Cpp2IlInjected.Token(Token = "0x4005A44")]
	public const short MoonBoulder = 1021;

	[Cpp2IlInjected.Token(Token = "0x4005A45")]
	public const short Count = 1022;

	[Cpp2IlInjected.Token(Token = "0x4005A46")]
	public static readonly IdDictionary Search;

	[Cpp2IlInjected.Token(Token = "0x60030AB")]
	[Cpp2IlInjected.Address(RVA = "0x1469114", Offset = "0x1469114", VA = "0x1469114")]
	public ProjectileID()
	{
	}
}
