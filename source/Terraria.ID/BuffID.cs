using Cpp2IlInjected;
using ReLogic.Reflection;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x20003E3")]
public class BuffID
{
	[Cpp2IlInjected.Token(Token = "0x2000910")]
	public class Sets
	{
		[Cpp2IlInjected.Token(Token = "0x2000B6A")]
		public class BuffMountData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009031")]
			public int mountID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009032")]
			public bool faceLeft;

			[Cpp2IlInjected.Token(Token = "0x600539A")]
			[Cpp2IlInjected.Address(RVA = "0x140D9C8", Offset = "0x140D9C8", VA = "0x140D9C8")]
			public BuffMountData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4008945")]
		public static SetFactory Factory;

		[Cpp2IlInjected.Token(Token = "0x4008946")]
		public static bool[] IsWellFed;

		[Cpp2IlInjected.Token(Token = "0x4008947")]
		public static bool[] IsFedState;

		[Cpp2IlInjected.Token(Token = "0x4008948")]
		public static bool[] IsAnNPCWhipDebuff;

		[Cpp2IlInjected.Token(Token = "0x4008949")]
		public static bool[] TimeLeftDoesNotDecrease;

		[Cpp2IlInjected.Token(Token = "0x400894A")]
		public static bool[] CanBeRemovedByNetMessage;

		[Cpp2IlInjected.Token(Token = "0x400894B")]
		public static bool[] IsAFlaskBuff;

		[Cpp2IlInjected.Token(Token = "0x400894C")]
		public static bool[] NurseCannotRemoveDebuff;

		[Cpp2IlInjected.Token(Token = "0x400894D")]
		public static BuffMountData[] BasicMountData;

		[Cpp2IlInjected.Token(Token = "0x6004C98")]
		[Cpp2IlInjected.Address(RVA = "0x140B5B0", Offset = "0x140B5B0", VA = "0x140B5B0")]
		public Sets()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40033C4")]
	public const int ObsidianSkin = 1;

	[Cpp2IlInjected.Token(Token = "0x40033C5")]
	public const int Regeneration = 2;

	[Cpp2IlInjected.Token(Token = "0x40033C6")]
	public const int Swiftness = 3;

	[Cpp2IlInjected.Token(Token = "0x40033C7")]
	public const int Gills = 4;

	[Cpp2IlInjected.Token(Token = "0x40033C8")]
	public const int Ironskin = 5;

	[Cpp2IlInjected.Token(Token = "0x40033C9")]
	public const int ManaRegeneration = 6;

	[Cpp2IlInjected.Token(Token = "0x40033CA")]
	public const int MagicPower = 7;

	[Cpp2IlInjected.Token(Token = "0x40033CB")]
	public const int Featherfall = 8;

	[Cpp2IlInjected.Token(Token = "0x40033CC")]
	public const int Spelunker = 9;

	[Cpp2IlInjected.Token(Token = "0x40033CD")]
	public const int Invisibility = 10;

	[Cpp2IlInjected.Token(Token = "0x40033CE")]
	public const int Shine = 11;

	[Cpp2IlInjected.Token(Token = "0x40033CF")]
	public const int NightOwl = 12;

	[Cpp2IlInjected.Token(Token = "0x40033D0")]
	public const int Battle = 13;

	[Cpp2IlInjected.Token(Token = "0x40033D1")]
	public const int Thorns = 14;

	[Cpp2IlInjected.Token(Token = "0x40033D2")]
	public const int WaterWalking = 15;

	[Cpp2IlInjected.Token(Token = "0x40033D3")]
	public const int Archery = 16;

	[Cpp2IlInjected.Token(Token = "0x40033D4")]
	public const int Hunter = 17;

	[Cpp2IlInjected.Token(Token = "0x40033D5")]
	public const int Gravitation = 18;

	[Cpp2IlInjected.Token(Token = "0x40033D6")]
	public const int ShadowOrb = 19;

	[Cpp2IlInjected.Token(Token = "0x40033D7")]
	public const int Poisoned = 20;

	[Cpp2IlInjected.Token(Token = "0x40033D8")]
	public const int PotionSickness = 21;

	[Cpp2IlInjected.Token(Token = "0x40033D9")]
	public const int Darkness = 22;

	[Cpp2IlInjected.Token(Token = "0x40033DA")]
	public const int Cursed = 23;

	[Cpp2IlInjected.Token(Token = "0x40033DB")]
	public const int OnFire = 24;

	[Cpp2IlInjected.Token(Token = "0x40033DC")]
	public const int Tipsy = 25;

	[Cpp2IlInjected.Token(Token = "0x40033DD")]
	public const int WellFed = 26;

	[Cpp2IlInjected.Token(Token = "0x40033DE")]
	public const int FairyBlue = 27;

	[Cpp2IlInjected.Token(Token = "0x40033DF")]
	public const int Werewolf = 28;

	[Cpp2IlInjected.Token(Token = "0x40033E0")]
	public const int Clairvoyance = 29;

	[Cpp2IlInjected.Token(Token = "0x40033E1")]
	public const int Bleeding = 30;

	[Cpp2IlInjected.Token(Token = "0x40033E2")]
	public const int Confused = 31;

	[Cpp2IlInjected.Token(Token = "0x40033E3")]
	public const int Slow = 32;

	[Cpp2IlInjected.Token(Token = "0x40033E4")]
	public const int Weak = 33;

	[Cpp2IlInjected.Token(Token = "0x40033E5")]
	public const int Merfolk = 34;

	[Cpp2IlInjected.Token(Token = "0x40033E6")]
	public const int Silenced = 35;

	[Cpp2IlInjected.Token(Token = "0x40033E7")]
	public const int BrokenArmor = 36;

	[Cpp2IlInjected.Token(Token = "0x40033E8")]
	public const int Horrified = 37;

	[Cpp2IlInjected.Token(Token = "0x40033E9")]
	public const int TheTongue = 38;

	[Cpp2IlInjected.Token(Token = "0x40033EA")]
	public const int CursedInferno = 39;

	[Cpp2IlInjected.Token(Token = "0x40033EB")]
	public const int PetBunny = 40;

	[Cpp2IlInjected.Token(Token = "0x40033EC")]
	public const int BabyPenguin = 41;

	[Cpp2IlInjected.Token(Token = "0x40033ED")]
	public const int PetTurtle = 42;

	[Cpp2IlInjected.Token(Token = "0x40033EE")]
	public const int PaladinsShield = 43;

	[Cpp2IlInjected.Token(Token = "0x40033EF")]
	public const int Frostburn = 44;

	[Cpp2IlInjected.Token(Token = "0x40033F0")]
	public const int BabyEater = 45;

	[Cpp2IlInjected.Token(Token = "0x40033F1")]
	public const int Chilled = 46;

	[Cpp2IlInjected.Token(Token = "0x40033F2")]
	public const int Frozen = 47;

	[Cpp2IlInjected.Token(Token = "0x40033F3")]
	public const int Honey = 48;

	[Cpp2IlInjected.Token(Token = "0x40033F4")]
	public const int Pygmies = 49;

	[Cpp2IlInjected.Token(Token = "0x40033F5")]
	public const int BabySkeletronHead = 50;

	[Cpp2IlInjected.Token(Token = "0x40033F6")]
	public const int BabyHornet = 51;

	[Cpp2IlInjected.Token(Token = "0x40033F7")]
	public const int TikiSpirit = 52;

	[Cpp2IlInjected.Token(Token = "0x40033F8")]
	public const int PetLizard = 53;

	[Cpp2IlInjected.Token(Token = "0x40033F9")]
	public const int PetParrot = 54;

	[Cpp2IlInjected.Token(Token = "0x40033FA")]
	public const int BabyTruffle = 55;

	[Cpp2IlInjected.Token(Token = "0x40033FB")]
	public const int PetSapling = 56;

	[Cpp2IlInjected.Token(Token = "0x40033FC")]
	public const int Wisp = 57;

	[Cpp2IlInjected.Token(Token = "0x40033FD")]
	public const int RapidHealing = 58;

	[Cpp2IlInjected.Token(Token = "0x40033FE")]
	public const int ShadowDodge = 59;

	[Cpp2IlInjected.Token(Token = "0x40033FF")]
	public const int LeafCrystal = 60;

	[Cpp2IlInjected.Token(Token = "0x4003400")]
	public const int BabyDinosaur = 61;

	[Cpp2IlInjected.Token(Token = "0x4003401")]
	public const int IceBarrier = 62;

	[Cpp2IlInjected.Token(Token = "0x4003402")]
	public const int Panic = 63;

	[Cpp2IlInjected.Token(Token = "0x4003403")]
	public const int BabySlime = 64;

	[Cpp2IlInjected.Token(Token = "0x4003404")]
	public const int EyeballSpring = 65;

	[Cpp2IlInjected.Token(Token = "0x4003405")]
	public const int BabySnowman = 66;

	[Cpp2IlInjected.Token(Token = "0x4003406")]
	public const int Burning = 67;

	[Cpp2IlInjected.Token(Token = "0x4003407")]
	public const int Suffocation = 68;

	[Cpp2IlInjected.Token(Token = "0x4003408")]
	public const int Ichor = 69;

	[Cpp2IlInjected.Token(Token = "0x4003409")]
	public const int Venom = 70;

	[Cpp2IlInjected.Token(Token = "0x400340A")]
	public const int WeaponImbueVenom = 71;

	[Cpp2IlInjected.Token(Token = "0x400340B")]
	public const int Midas = 72;

	[Cpp2IlInjected.Token(Token = "0x400340C")]
	public const int WeaponImbueCursedFlames = 73;

	[Cpp2IlInjected.Token(Token = "0x400340D")]
	public const int WeaponImbueFire = 74;

	[Cpp2IlInjected.Token(Token = "0x400340E")]
	public const int WeaponImbueGold = 75;

	[Cpp2IlInjected.Token(Token = "0x400340F")]
	public const int WeaponImbueIchor = 76;

	[Cpp2IlInjected.Token(Token = "0x4003410")]
	public const int WeaponImbueNanites = 77;

	[Cpp2IlInjected.Token(Token = "0x4003411")]
	public const int WeaponImbueConfetti = 78;

	[Cpp2IlInjected.Token(Token = "0x4003412")]
	public const int WeaponImbuePoison = 79;

	[Cpp2IlInjected.Token(Token = "0x4003413")]
	public const int Blackout = 80;

	[Cpp2IlInjected.Token(Token = "0x4003414")]
	public const int PetSpider = 81;

	[Cpp2IlInjected.Token(Token = "0x4003415")]
	public const int Squashling = 82;

	[Cpp2IlInjected.Token(Token = "0x4003416")]
	public const int Ravens = 83;

	[Cpp2IlInjected.Token(Token = "0x4003417")]
	public const int BlackCat = 84;

	[Cpp2IlInjected.Token(Token = "0x4003418")]
	public const int CursedSapling = 85;

	[Cpp2IlInjected.Token(Token = "0x4003419")]
	public const int WaterCandle = 86;

	[Cpp2IlInjected.Token(Token = "0x400341A")]
	public const int Campfire = 87;

	[Cpp2IlInjected.Token(Token = "0x400341B")]
	public const int ChaosState = 88;

	[Cpp2IlInjected.Token(Token = "0x400341C")]
	public const int HeartLamp = 89;

	[Cpp2IlInjected.Token(Token = "0x400341D")]
	public const int Rudolph = 90;

	[Cpp2IlInjected.Token(Token = "0x400341E")]
	public const int Puppy = 91;

	[Cpp2IlInjected.Token(Token = "0x400341F")]
	public const int BabyGrinch = 92;

	[Cpp2IlInjected.Token(Token = "0x4003420")]
	public const int AmmoBox = 93;

	[Cpp2IlInjected.Token(Token = "0x4003421")]
	public const int ManaSickness = 94;

	[Cpp2IlInjected.Token(Token = "0x4003422")]
	public const int BeetleEndurance1 = 95;

	[Cpp2IlInjected.Token(Token = "0x4003423")]
	public const int BeetleEndurance2 = 96;

	[Cpp2IlInjected.Token(Token = "0x4003424")]
	public const int BeetleEndurance3 = 97;

	[Cpp2IlInjected.Token(Token = "0x4003425")]
	public const int BeetleMight1 = 98;

	[Cpp2IlInjected.Token(Token = "0x4003426")]
	public const int BeetleMight2 = 99;

	[Cpp2IlInjected.Token(Token = "0x4003427")]
	public const int BeetleMight3 = 100;

	[Cpp2IlInjected.Token(Token = "0x4003428")]
	public const int FairyRed = 101;

	[Cpp2IlInjected.Token(Token = "0x4003429")]
	public const int FairyGreen = 102;

	[Cpp2IlInjected.Token(Token = "0x400342A")]
	public const int Wet = 103;

	[Cpp2IlInjected.Token(Token = "0x400342B")]
	public const int Mining = 104;

	[Cpp2IlInjected.Token(Token = "0x400342C")]
	public const int Heartreach = 105;

	[Cpp2IlInjected.Token(Token = "0x400342D")]
	public const int Calm = 106;

	[Cpp2IlInjected.Token(Token = "0x400342E")]
	public const int Builder = 107;

	[Cpp2IlInjected.Token(Token = "0x400342F")]
	public const int Titan = 108;

	[Cpp2IlInjected.Token(Token = "0x4003430")]
	public const int Flipper = 109;

	[Cpp2IlInjected.Token(Token = "0x4003431")]
	public const int Summoning = 110;

	[Cpp2IlInjected.Token(Token = "0x4003432")]
	public const int Dangersense = 111;

	[Cpp2IlInjected.Token(Token = "0x4003433")]
	public const int AmmoReservation = 112;

	[Cpp2IlInjected.Token(Token = "0x4003434")]
	public const int Lifeforce = 113;

	[Cpp2IlInjected.Token(Token = "0x4003435")]
	public const int Endurance = 114;

	[Cpp2IlInjected.Token(Token = "0x4003436")]
	public const int Rage = 115;

	[Cpp2IlInjected.Token(Token = "0x4003437")]
	public const int Inferno = 116;

	[Cpp2IlInjected.Token(Token = "0x4003438")]
	public const int Wrath = 117;

	[Cpp2IlInjected.Token(Token = "0x4003439")]
	public const int MinecartLeft = 118;

	[Cpp2IlInjected.Token(Token = "0x400343A")]
	public const int Lovestruck = 119;

	[Cpp2IlInjected.Token(Token = "0x400343B")]
	public const int Stinky = 120;

	[Cpp2IlInjected.Token(Token = "0x400343C")]
	public const int Fishing = 121;

	[Cpp2IlInjected.Token(Token = "0x400343D")]
	public const int Sonar = 122;

	[Cpp2IlInjected.Token(Token = "0x400343E")]
	public const int Crate = 123;

	[Cpp2IlInjected.Token(Token = "0x400343F")]
	public const int Warmth = 124;

	[Cpp2IlInjected.Token(Token = "0x4003440")]
	public const int HornetMinion = 125;

	[Cpp2IlInjected.Token(Token = "0x4003441")]
	public const int ImpMinion = 126;

	[Cpp2IlInjected.Token(Token = "0x4003442")]
	public const int ZephyrFish = 127;

	[Cpp2IlInjected.Token(Token = "0x4003443")]
	public const int BunnyMount = 128;

	[Cpp2IlInjected.Token(Token = "0x4003444")]
	public const int PigronMount = 129;

	[Cpp2IlInjected.Token(Token = "0x4003445")]
	public const int SlimeMount = 130;

	[Cpp2IlInjected.Token(Token = "0x4003446")]
	public const int TurtleMount = 131;

	[Cpp2IlInjected.Token(Token = "0x4003447")]
	public const int BeeMount = 132;

	[Cpp2IlInjected.Token(Token = "0x4003448")]
	public const int SpiderMinion = 133;

	[Cpp2IlInjected.Token(Token = "0x4003449")]
	public const int TwinEyesMinion = 134;

	[Cpp2IlInjected.Token(Token = "0x400344A")]
	public const int PirateMinion = 135;

	[Cpp2IlInjected.Token(Token = "0x400344B")]
	public const int MiniMinotaur = 136;

	[Cpp2IlInjected.Token(Token = "0x400344C")]
	public const int Slimed = 137;

	[Cpp2IlInjected.Token(Token = "0x400344D")]
	public const int MinecartRight = 138;

	[Cpp2IlInjected.Token(Token = "0x400344E")]
	public const int SharknadoMinion = 139;

	[Cpp2IlInjected.Token(Token = "0x400344F")]
	public const int UFOMinion = 140;

	[Cpp2IlInjected.Token(Token = "0x4003450")]
	public const int UFOMount = 141;

	[Cpp2IlInjected.Token(Token = "0x4003451")]
	public const int DrillMount = 142;

	[Cpp2IlInjected.Token(Token = "0x4003452")]
	public const int ScutlixMount = 143;

	[Cpp2IlInjected.Token(Token = "0x4003453")]
	public const int Electrified = 144;

	[Cpp2IlInjected.Token(Token = "0x4003454")]
	public const int MoonLeech = 145;

	[Cpp2IlInjected.Token(Token = "0x4003455")]
	public const int Sunflower = 146;

	[Cpp2IlInjected.Token(Token = "0x4003456")]
	public const int MonsterBanner = 147;

	[Cpp2IlInjected.Token(Token = "0x4003457")]
	public const int Rabies = 148;

	[Cpp2IlInjected.Token(Token = "0x4003458")]
	public const int Webbed = 149;

	[Cpp2IlInjected.Token(Token = "0x4003459")]
	public const int Bewitched = 150;

	[Cpp2IlInjected.Token(Token = "0x400345A")]
	public const int SoulDrain = 151;

	[Cpp2IlInjected.Token(Token = "0x400345B")]
	public const int MagicLantern = 152;

	[Cpp2IlInjected.Token(Token = "0x400345C")]
	public const int ShadowFlame = 153;

	[Cpp2IlInjected.Token(Token = "0x400345D")]
	public const int BabyFaceMonster = 154;

	[Cpp2IlInjected.Token(Token = "0x400345E")]
	public const int CrimsonHeart = 155;

	[Cpp2IlInjected.Token(Token = "0x400345F")]
	public const int Stoned = 156;

	[Cpp2IlInjected.Token(Token = "0x4003460")]
	public const int PeaceCandle = 157;

	[Cpp2IlInjected.Token(Token = "0x4003461")]
	public const int StarInBottle = 158;

	[Cpp2IlInjected.Token(Token = "0x4003462")]
	public const int Sharpened = 159;

	[Cpp2IlInjected.Token(Token = "0x4003463")]
	public const int Dazed = 160;

	[Cpp2IlInjected.Token(Token = "0x4003464")]
	public const int DeadlySphere = 161;

	[Cpp2IlInjected.Token(Token = "0x4003465")]
	public const int UnicornMount = 162;

	[Cpp2IlInjected.Token(Token = "0x4003466")]
	public const int Obstructed = 163;

	[Cpp2IlInjected.Token(Token = "0x4003467")]
	public const int VortexDebuff = 164;

	[Cpp2IlInjected.Token(Token = "0x4003468")]
	public const int DryadsWard = 165;

	[Cpp2IlInjected.Token(Token = "0x4003469")]
	public const int MinecartRightMech = 166;

	[Cpp2IlInjected.Token(Token = "0x400346A")]
	public const int MinecartLeftMech = 167;

	[Cpp2IlInjected.Token(Token = "0x400346B")]
	public const int CuteFishronMount = 168;

	[Cpp2IlInjected.Token(Token = "0x400346C")]
	public const int BoneJavelin = 169;

	[Cpp2IlInjected.Token(Token = "0x400346D")]
	public const int SolarShield1 = 170;

	[Cpp2IlInjected.Token(Token = "0x400346E")]
	public const int SolarShield2 = 171;

	[Cpp2IlInjected.Token(Token = "0x400346F")]
	public const int SolarShield3 = 172;

	[Cpp2IlInjected.Token(Token = "0x4003470")]
	public const int NebulaUpLife1 = 173;

	[Cpp2IlInjected.Token(Token = "0x4003471")]
	public const int NebulaUpLife2 = 174;

	[Cpp2IlInjected.Token(Token = "0x4003472")]
	public const int NebulaUpLife3 = 175;

	[Cpp2IlInjected.Token(Token = "0x4003473")]
	public const int NebulaUpMana1 = 176;

	[Cpp2IlInjected.Token(Token = "0x4003474")]
	public const int NebulaUpMana2 = 177;

	[Cpp2IlInjected.Token(Token = "0x4003475")]
	public const int NebulaUpMana3 = 178;

	[Cpp2IlInjected.Token(Token = "0x4003476")]
	public const int NebulaUpDmg1 = 179;

	[Cpp2IlInjected.Token(Token = "0x4003477")]
	public const int NebulaUpDmg2 = 180;

	[Cpp2IlInjected.Token(Token = "0x4003478")]
	public const int NebulaUpDmg3 = 181;

	[Cpp2IlInjected.Token(Token = "0x4003479")]
	public const int StardustMinion = 182;

	[Cpp2IlInjected.Token(Token = "0x400347A")]
	public const int StardustMinionBleed = 183;

	[Cpp2IlInjected.Token(Token = "0x400347B")]
	public const int MinecartLeftWood = 184;

	[Cpp2IlInjected.Token(Token = "0x400347C")]
	public const int MinecartRightWood = 185;

	[Cpp2IlInjected.Token(Token = "0x400347D")]
	public const int DryadsWardDebuff = 186;

	[Cpp2IlInjected.Token(Token = "0x400347E")]
	public const int StardustGuardianMinion = 187;

	[Cpp2IlInjected.Token(Token = "0x400347F")]
	public const int StardustDragonMinion = 188;

	[Cpp2IlInjected.Token(Token = "0x4003480")]
	public const int Daybreak = 189;

	[Cpp2IlInjected.Token(Token = "0x4003481")]
	public const int SuspiciousTentacle = 190;

	[Cpp2IlInjected.Token(Token = "0x4003482")]
	public const int CompanionCube = 191;

	[Cpp2IlInjected.Token(Token = "0x4003483")]
	public const int SugarRush = 192;

	[Cpp2IlInjected.Token(Token = "0x4003484")]
	public const int BasiliskMount = 193;

	[Cpp2IlInjected.Token(Token = "0x4003485")]
	public const int WindPushed = 194;

	[Cpp2IlInjected.Token(Token = "0x4003486")]
	public const int WitheredArmor = 195;

	[Cpp2IlInjected.Token(Token = "0x4003487")]
	public const int WitheredWeapon = 196;

	[Cpp2IlInjected.Token(Token = "0x4003488")]
	public const int OgreSpit = 197;

	[Cpp2IlInjected.Token(Token = "0x4003489")]
	public const int ParryDamageBuff = 198;

	[Cpp2IlInjected.Token(Token = "0x400348A")]
	public const int NoBuilding = 199;

	[Cpp2IlInjected.Token(Token = "0x400348B")]
	public const int PetDD2Gato = 200;

	[Cpp2IlInjected.Token(Token = "0x400348C")]
	public const int PetDD2Ghost = 201;

	[Cpp2IlInjected.Token(Token = "0x400348D")]
	public const int PetDD2Dragon = 202;

	[Cpp2IlInjected.Token(Token = "0x400348E")]
	public const int BetsysCurse = 203;

	[Cpp2IlInjected.Token(Token = "0x400348F")]
	public const int Oiled = 204;

	[Cpp2IlInjected.Token(Token = "0x4003490")]
	public const int BallistaPanic = 205;

	[Cpp2IlInjected.Token(Token = "0x4003491")]
	public const int WellFed2 = 206;

	[Cpp2IlInjected.Token(Token = "0x4003492")]
	public const int WellFed3 = 207;

	[Cpp2IlInjected.Token(Token = "0x4003493")]
	public const int DesertMinecartRight = 208;

	[Cpp2IlInjected.Token(Token = "0x4003494")]
	public const int DesertMinecartLeft = 209;

	[Cpp2IlInjected.Token(Token = "0x4003495")]
	public const int FishMinecartRight = 210;

	[Cpp2IlInjected.Token(Token = "0x4003496")]
	public const int FishMinecartLeft = 211;

	[Cpp2IlInjected.Token(Token = "0x4003497")]
	public const int GolfCartMount = 212;

	[Cpp2IlInjected.Token(Token = "0x4003498")]
	public const int BatOfLight = 213;

	[Cpp2IlInjected.Token(Token = "0x4003499")]
	public const int VampireFrog = 214;

	[Cpp2IlInjected.Token(Token = "0x400349A")]
	public const int CatBast = 215;

	[Cpp2IlInjected.Token(Token = "0x400349B")]
	public const int BabyBird = 216;

	[Cpp2IlInjected.Token(Token = "0x400349C")]
	public const int UpbeatStar = 217;

	[Cpp2IlInjected.Token(Token = "0x400349D")]
	public const int SugarGlider = 218;

	[Cpp2IlInjected.Token(Token = "0x400349E")]
	public const int SharkPup = 219;

	[Cpp2IlInjected.Token(Token = "0x400349F")]
	public const int BeeMinecartRight = 220;

	[Cpp2IlInjected.Token(Token = "0x40034A0")]
	public const int BeeMinecartLeft = 221;

	[Cpp2IlInjected.Token(Token = "0x40034A1")]
	public const int LadybugMinecartRight = 222;

	[Cpp2IlInjected.Token(Token = "0x40034A2")]
	public const int LadybugMinecartLeft = 223;

	[Cpp2IlInjected.Token(Token = "0x40034A3")]
	public const int PigronMinecartRight = 224;

	[Cpp2IlInjected.Token(Token = "0x40034A4")]
	public const int PigronMinecartLeft = 225;

	[Cpp2IlInjected.Token(Token = "0x40034A5")]
	public const int SunflowerMinecartRight = 226;

	[Cpp2IlInjected.Token(Token = "0x40034A6")]
	public const int SunflowerMinecartLeft = 227;

	[Cpp2IlInjected.Token(Token = "0x40034A7")]
	public const int HellMinecartRight = 228;

	[Cpp2IlInjected.Token(Token = "0x40034A8")]
	public const int HellMinecartLeft = 229;

	[Cpp2IlInjected.Token(Token = "0x40034A9")]
	public const int WitchBroom = 230;

	[Cpp2IlInjected.Token(Token = "0x40034AA")]
	public const int ShroomMinecartRight = 231;

	[Cpp2IlInjected.Token(Token = "0x40034AB")]
	public const int ShroomMinecartLeft = 232;

	[Cpp2IlInjected.Token(Token = "0x40034AC")]
	public const int AmethystMinecartRight = 233;

	[Cpp2IlInjected.Token(Token = "0x40034AD")]
	public const int AmethystMinecartLeft = 234;

	[Cpp2IlInjected.Token(Token = "0x40034AE")]
	public const int TopazMinecartRight = 235;

	[Cpp2IlInjected.Token(Token = "0x40034AF")]
	public const int TopazMinecartLeft = 236;

	[Cpp2IlInjected.Token(Token = "0x40034B0")]
	public const int SapphireMinecartRight = 237;

	[Cpp2IlInjected.Token(Token = "0x40034B1")]
	public const int SapphireMinecartLeft = 238;

	[Cpp2IlInjected.Token(Token = "0x40034B2")]
	public const int EmeraldMinecartRight = 239;

	[Cpp2IlInjected.Token(Token = "0x40034B3")]
	public const int EmeraldMinecartLeft = 240;

	[Cpp2IlInjected.Token(Token = "0x40034B4")]
	public const int RubyMinecartRight = 241;

	[Cpp2IlInjected.Token(Token = "0x40034B5")]
	public const int RubyMinecartLeft = 242;

	[Cpp2IlInjected.Token(Token = "0x40034B6")]
	public const int DiamondMinecartRight = 243;

	[Cpp2IlInjected.Token(Token = "0x40034B7")]
	public const int DiamondMinecartLeft = 244;

	[Cpp2IlInjected.Token(Token = "0x40034B8")]
	public const int AmberMinecartRight = 245;

	[Cpp2IlInjected.Token(Token = "0x40034B9")]
	public const int AmberMinecartLeft = 246;

	[Cpp2IlInjected.Token(Token = "0x40034BA")]
	public const int BeetleMinecartRight = 247;

	[Cpp2IlInjected.Token(Token = "0x40034BB")]
	public const int BeetleMinecartLeft = 248;

	[Cpp2IlInjected.Token(Token = "0x40034BC")]
	public const int MeowmereMinecartRight = 249;

	[Cpp2IlInjected.Token(Token = "0x40034BD")]
	public const int MeowmereMinecartLeft = 250;

	[Cpp2IlInjected.Token(Token = "0x40034BE")]
	public const int PartyMinecartRight = 251;

	[Cpp2IlInjected.Token(Token = "0x40034BF")]
	public const int PartyMinecartLeft = 252;

	[Cpp2IlInjected.Token(Token = "0x40034C0")]
	public const int PirateMinecartRight = 253;

	[Cpp2IlInjected.Token(Token = "0x40034C1")]
	public const int PirateMinecartLeft = 254;

	[Cpp2IlInjected.Token(Token = "0x40034C2")]
	public const int SteampunkMinecartRight = 255;

	[Cpp2IlInjected.Token(Token = "0x40034C3")]
	public const int SteampunkMinecartLeft = 256;

	[Cpp2IlInjected.Token(Token = "0x40034C4")]
	public const int Lucky = 257;

	[Cpp2IlInjected.Token(Token = "0x40034C5")]
	public const int LilHarpy = 258;

	[Cpp2IlInjected.Token(Token = "0x40034C6")]
	public const int FennecFox = 259;

	[Cpp2IlInjected.Token(Token = "0x40034C7")]
	public const int GlitteryButterfly = 260;

	[Cpp2IlInjected.Token(Token = "0x40034C8")]
	public const int BabyImp = 261;

	[Cpp2IlInjected.Token(Token = "0x40034C9")]
	public const int BabyRedPanda = 262;

	[Cpp2IlInjected.Token(Token = "0x40034CA")]
	public const int StormTiger = 263;

	[Cpp2IlInjected.Token(Token = "0x40034CB")]
	public const int Plantero = 264;

	[Cpp2IlInjected.Token(Token = "0x40034CC")]
	public const int Flamingo = 265;

	[Cpp2IlInjected.Token(Token = "0x40034CD")]
	public const int DynamiteKitten = 266;

	[Cpp2IlInjected.Token(Token = "0x40034CE")]
	public const int BabyWerewolf = 267;

	[Cpp2IlInjected.Token(Token = "0x40034CF")]
	public const int ShadowMimic = 268;

	[Cpp2IlInjected.Token(Token = "0x40034D0")]
	public const int CoffinMinecartRight = 269;

	[Cpp2IlInjected.Token(Token = "0x40034D1")]
	public const int CoffinMinecartLeft = 270;

	[Cpp2IlInjected.Token(Token = "0x40034D2")]
	public const int Smolstar = 271;

	[Cpp2IlInjected.Token(Token = "0x40034D3")]
	public const int DiggingMoleMinecartRight = 272;

	[Cpp2IlInjected.Token(Token = "0x40034D4")]
	public const int DiggingMoleMinecartLeft = 273;

	[Cpp2IlInjected.Token(Token = "0x40034D5")]
	public const int VoltBunny = 274;

	[Cpp2IlInjected.Token(Token = "0x40034D6")]
	public const int PaintedHorseMount = 275;

	[Cpp2IlInjected.Token(Token = "0x40034D7")]
	public const int MajesticHorseMount = 276;

	[Cpp2IlInjected.Token(Token = "0x40034D8")]
	public const int DarkHorseMount = 277;

	[Cpp2IlInjected.Token(Token = "0x40034D9")]
	public const int PogoStickMount = 278;

	[Cpp2IlInjected.Token(Token = "0x40034DA")]
	public const int PirateShipMount = 279;

	[Cpp2IlInjected.Token(Token = "0x40034DB")]
	public const int SpookyWoodMount = 280;

	[Cpp2IlInjected.Token(Token = "0x40034DC")]
	public const int SantankMount = 281;

	[Cpp2IlInjected.Token(Token = "0x40034DD")]
	public const int WallOfFleshGoatMount = 282;

	[Cpp2IlInjected.Token(Token = "0x40034DE")]
	public const int DarkMageBookMount = 283;

	[Cpp2IlInjected.Token(Token = "0x40034DF")]
	public const int KingSlimePet = 284;

	[Cpp2IlInjected.Token(Token = "0x40034E0")]
	public const int EyeOfCthulhuPet = 285;

	[Cpp2IlInjected.Token(Token = "0x40034E1")]
	public const int EaterOfWorldsPet = 286;

	[Cpp2IlInjected.Token(Token = "0x40034E2")]
	public const int BrainOfCthulhuPet = 287;

	[Cpp2IlInjected.Token(Token = "0x40034E3")]
	public const int SkeletronPet = 288;

	[Cpp2IlInjected.Token(Token = "0x40034E4")]
	public const int QueenBeePet = 289;

	[Cpp2IlInjected.Token(Token = "0x40034E5")]
	public const int DestroyerPet = 290;

	[Cpp2IlInjected.Token(Token = "0x40034E6")]
	public const int TwinsPet = 291;

	[Cpp2IlInjected.Token(Token = "0x40034E7")]
	public const int SkeletronPrimePet = 292;

	[Cpp2IlInjected.Token(Token = "0x40034E8")]
	public const int PlanteraPet = 293;

	[Cpp2IlInjected.Token(Token = "0x40034E9")]
	public const int GolemPet = 294;

	[Cpp2IlInjected.Token(Token = "0x40034EA")]
	public const int DukeFishronPet = 295;

	[Cpp2IlInjected.Token(Token = "0x40034EB")]
	public const int LunaticCultistPet = 296;

	[Cpp2IlInjected.Token(Token = "0x40034EC")]
	public const int MoonLordPet = 297;

	[Cpp2IlInjected.Token(Token = "0x40034ED")]
	public const int FairyQueenPet = 298;

	[Cpp2IlInjected.Token(Token = "0x40034EE")]
	public const int PumpkingPet = 299;

	[Cpp2IlInjected.Token(Token = "0x40034EF")]
	public const int EverscreamPet = 300;

	[Cpp2IlInjected.Token(Token = "0x40034F0")]
	public const int IceQueenPet = 301;

	[Cpp2IlInjected.Token(Token = "0x40034F1")]
	public const int MartianPet = 302;

	[Cpp2IlInjected.Token(Token = "0x40034F2")]
	public const int DD2OgrePet = 303;

	[Cpp2IlInjected.Token(Token = "0x40034F3")]
	public const int DD2BetsyPet = 304;

	[Cpp2IlInjected.Token(Token = "0x40034F4")]
	public const int LavaSharkMount = 305;

	[Cpp2IlInjected.Token(Token = "0x40034F5")]
	public const int TitaniumStorm = 306;

	[Cpp2IlInjected.Token(Token = "0x40034F6")]
	public const int BlandWhipEnemyDebuff = 307;

	[Cpp2IlInjected.Token(Token = "0x40034F7")]
	public const int SwordWhipPlayerBuff = 308;

	[Cpp2IlInjected.Token(Token = "0x40034F8")]
	public const int SwordWhipNPCDebuff = 309;

	[Cpp2IlInjected.Token(Token = "0x40034F9")]
	public const int ScytheWhipEnemyDebuff = 310;

	[Cpp2IlInjected.Token(Token = "0x40034FA")]
	public const int ScytheWhipPlayerBuff = 311;

	[Cpp2IlInjected.Token(Token = "0x40034FB")]
	public const int CoolWhipPlayerBuff = 312;

	[Cpp2IlInjected.Token(Token = "0x40034FC")]
	public const int FlameWhipEnemyDebuff = 313;

	[Cpp2IlInjected.Token(Token = "0x40034FD")]
	public const int ThornWhipPlayerBuff = 314;

	[Cpp2IlInjected.Token(Token = "0x40034FE")]
	public const int ThornWhipNPCDebuff = 315;

	[Cpp2IlInjected.Token(Token = "0x40034FF")]
	public const int RainbowWhipNPCDebuff = 316;

	[Cpp2IlInjected.Token(Token = "0x4003500")]
	public const int QueenSlimePet = 317;

	[Cpp2IlInjected.Token(Token = "0x4003501")]
	public const int QueenSlimeMount = 318;

	[Cpp2IlInjected.Token(Token = "0x4003502")]
	public const int MaceWhipNPCDebuff = 319;

	[Cpp2IlInjected.Token(Token = "0x4003503")]
	public const int GelBalloonBuff = 320;

	[Cpp2IlInjected.Token(Token = "0x4003504")]
	public const int BrainOfConfusionBuff = 321;

	[Cpp2IlInjected.Token(Token = "0x4003505")]
	public const int EmpressBlade = 322;

	[Cpp2IlInjected.Token(Token = "0x4003506")]
	public const int OnFire3 = 323;

	[Cpp2IlInjected.Token(Token = "0x4003507")]
	public const int Frostburn2 = 324;

	[Cpp2IlInjected.Token(Token = "0x4003508")]
	public const int FlinxMinion = 325;

	[Cpp2IlInjected.Token(Token = "0x4003509")]
	public const int BoneWhipNPCDebuff = 326;

	[Cpp2IlInjected.Token(Token = "0x400350A")]
	public const int BerniePet = 327;

	[Cpp2IlInjected.Token(Token = "0x400350B")]
	public const int GlommerPet = 328;

	[Cpp2IlInjected.Token(Token = "0x400350C")]
	public const int DeerclopsPet = 329;

	[Cpp2IlInjected.Token(Token = "0x400350D")]
	public const int PigPet = 330;

	[Cpp2IlInjected.Token(Token = "0x400350E")]
	public const int ChesterPet = 331;

	[Cpp2IlInjected.Token(Token = "0x400350F")]
	public const int NeutralHunger = 332;

	[Cpp2IlInjected.Token(Token = "0x4003510")]
	public const int Hunger = 333;

	[Cpp2IlInjected.Token(Token = "0x4003511")]
	public const int Starving = 334;

	[Cpp2IlInjected.Token(Token = "0x4003512")]
	public const int AbigailMinion = 335;

	[Cpp2IlInjected.Token(Token = "0x4003513")]
	public const int HeartyMeal = 336;

	[Cpp2IlInjected.Token(Token = "0x4003514")]
	public const int TentacleSpike = 337;

	[Cpp2IlInjected.Token(Token = "0x4003515")]
	public const int FartMinecartRight = 338;

	[Cpp2IlInjected.Token(Token = "0x4003516")]
	public const int FartMinecartLeft = 339;

	[Cpp2IlInjected.Token(Token = "0x4003517")]
	public const int CoolWhipNPCDebuff = 340;

	[Cpp2IlInjected.Token(Token = "0x4003518")]
	public const int DualSlimePet = 341;

	[Cpp2IlInjected.Token(Token = "0x4003519")]
	public const int WolfMount = 342;

	[Cpp2IlInjected.Token(Token = "0x400351A")]
	public const int BiomeSight = 343;

	[Cpp2IlInjected.Token(Token = "0x400351B")]
	public const int BloodButcherer = 344;

	[Cpp2IlInjected.Token(Token = "0x400351C")]
	public const int JunimoPet = 345;

	[Cpp2IlInjected.Token(Token = "0x400351D")]
	public const int TerraFartMinecartRight = 346;

	[Cpp2IlInjected.Token(Token = "0x400351E")]
	public const int TerraFartMinecartLeft = 347;

	[Cpp2IlInjected.Token(Token = "0x400351F")]
	public const int WarTable = 348;

	[Cpp2IlInjected.Token(Token = "0x4003520")]
	public const int BlueChickenPet = 349;

	[Cpp2IlInjected.Token(Token = "0x4003521")]
	public const int ShadowCandle = 350;

	[Cpp2IlInjected.Token(Token = "0x4003522")]
	public const int Spiffo = 351;

	[Cpp2IlInjected.Token(Token = "0x4003523")]
	public const int CavelingGardener = 352;

	[Cpp2IlInjected.Token(Token = "0x4003524")]
	public const int Shimmer = 353;

	[Cpp2IlInjected.Token(Token = "0x4003525")]
	public const int DirtiestBlock = 354;

	[Cpp2IlInjected.Token(Token = "0x4003526")]
	public const int Count = 355;

	[Cpp2IlInjected.Token(Token = "0x4003527")]
	public static readonly IdDictionary Search;

	[Cpp2IlInjected.Token(Token = "0x6003072")]
	[Cpp2IlInjected.Address(RVA = "0x140B53C", Offset = "0x140B53C", VA = "0x140B53C")]
	public BuffID()
	{
	}
}
