using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Items;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000317")]
public class Item : Entity
{
	[Cpp2IlInjected.Token(Token = "0x40021C4")]
	public static int numberOfNewItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40021C5")]
	private string _nameOverride;

	[Cpp2IlInjected.Token(Token = "0x40021C6")]
	public const int luckPotionDuration1 = 18000;

	[Cpp2IlInjected.Token(Token = "0x40021C7")]
	public const int luckPotionDuration2 = 36000;

	[Cpp2IlInjected.Token(Token = "0x40021C8")]
	public const int luckPotionDuration3 = 54000;

	[Cpp2IlInjected.Token(Token = "0x40021C9")]
	public const int flaskTime = 72000;

	[Cpp2IlInjected.Token(Token = "0x40021CA")]
	public const int copper = 1;

	[Cpp2IlInjected.Token(Token = "0x40021CB")]
	public const int silver = 100;

	[Cpp2IlInjected.Token(Token = "0x40021CC")]
	public const int gold = 10000;

	[Cpp2IlInjected.Token(Token = "0x40021CD")]
	public const int platinum = 1000000;

	[Cpp2IlInjected.Token(Token = "0x40021CE")]
	public const int goldCritterRarityColor = 3;

	[Cpp2IlInjected.Token(Token = "0x40021CF")]
	private static readonly int shadowOrbPrice;

	[Cpp2IlInjected.Token(Token = "0x40021D0")]
	private static readonly int dungeonPrice;

	[Cpp2IlInjected.Token(Token = "0x40021D1")]
	private static readonly int queenBeePrice;

	[Cpp2IlInjected.Token(Token = "0x40021D2")]
	private static readonly int hellPrice;

	[Cpp2IlInjected.Token(Token = "0x40021D3")]
	private static readonly int eclipsePrice;

	[Cpp2IlInjected.Token(Token = "0x40021D4")]
	private static readonly int eclipsePostPlanteraPrice;

	[Cpp2IlInjected.Token(Token = "0x40021D5")]
	private static readonly int eclipseMothronPrice;

	[Cpp2IlInjected.Token(Token = "0x40021D6")]
	public static int CommonMaxStack;

	[Cpp2IlInjected.Token(Token = "0x40021D7")]
	public static int[] cachedItemSpawnsByType;

	[Cpp2IlInjected.Token(Token = "0x40021D8")]
	public static int potionDelay;

	[Cpp2IlInjected.Token(Token = "0x40021D9")]
	public static int restorationDelay;

	[Cpp2IlInjected.Token(Token = "0x40021DA")]
	public static int mushroomDelay;

	[Cpp2IlInjected.Token(Token = "0x40021DB")]
	public static int[] headType;

	[Cpp2IlInjected.Token(Token = "0x40021DC")]
	public static int[] bodyType;

	[Cpp2IlInjected.Token(Token = "0x40021DD")]
	public static int[] legType;

	[Cpp2IlInjected.Token(Token = "0x40021DE")]
	public static bool[] staff;

	[Cpp2IlInjected.Token(Token = "0x40021DF")]
	public static bool[] claw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40021E0")]
	public bool questItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
	[Cpp2IlInjected.Token(Token = "0x40021E1")]
	public bool flame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
	[Cpp2IlInjected.Token(Token = "0x40021E2")]
	public bool mech;

	[Cpp2IlInjected.FieldOffset(Offset = "0x57")]
	[Cpp2IlInjected.Token(Token = "0x40021E3")]
	public bool beingGrabbed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40021E4")]
	public bool wornArmor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x40021E5")]
	public bool expertOnly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x40021E6")]
	public bool expert;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5B")]
	[Cpp2IlInjected.Token(Token = "0x40021E7")]
	public bool isAShopItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40021E8")]
	public bool instanced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
	[Cpp2IlInjected.Token(Token = "0x40021E9")]
	public bool favorited;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
	[Cpp2IlInjected.Token(Token = "0x40021EA")]
	public bool channel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5F")]
	[Cpp2IlInjected.Token(Token = "0x40021EB")]
	public bool accessory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40021EC")]
	public bool potion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x40021ED")]
	public bool consumable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x40021EE")]
	public bool autoReuse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
	[Cpp2IlInjected.Token(Token = "0x40021EF")]
	public bool useTurn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40021F0")]
	public bool notAmmo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x40021F1")]
	public bool buyOnce;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x40021F2")]
	public bool noUseGraphic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x67")]
	[Cpp2IlInjected.Token(Token = "0x40021F3")]
	public bool noMelee;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40021F4")]
	public bool buy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
	[Cpp2IlInjected.Token(Token = "0x40021F5")]
	public bool reforge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
	[Cpp2IlInjected.Token(Token = "0x40021F6")]
	public bool social;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B")]
	[Cpp2IlInjected.Token(Token = "0x40021F7")]
	public bool vanity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40021F8")]
	public bool material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
	[Cpp2IlInjected.Token(Token = "0x40021F9")]
	public bool noWet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
	[Cpp2IlInjected.Token(Token = "0x40021FA")]
	public bool cartTrack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F")]
	[Cpp2IlInjected.Token(Token = "0x40021FB")]
	public bool uniqueStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40021FC")]
	public bool DD2Summon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
	[Cpp2IlInjected.Token(Token = "0x40021FD")]
	public bool melee;

	[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
	[Cpp2IlInjected.Token(Token = "0x40021FE")]
	public bool magic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x73")]
	[Cpp2IlInjected.Token(Token = "0x40021FF")]
	public bool ranged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4002200")]
	public bool summon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x75")]
	[Cpp2IlInjected.Token(Token = "0x4002201")]
	public bool sentry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x76")]
	[Cpp2IlInjected.Token(Token = "0x4002202")]
	public bool newAndShiny;

	[Cpp2IlInjected.FieldOffset(Offset = "0x77")]
	[Cpp2IlInjected.Token(Token = "0x4002203")]
	public bool canBePlacedInVanityRegardlessOfConditions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4002204")]
	private bool frozen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4002205")]
	private byte frozenCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4002206")]
	public int noGrabDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4002207")]
	public int timeSinceItemSpawned;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4002208")]
	public int tileWand;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4002209")]
	public int tooltipContext;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400220A")]
	public byte dye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400220B")]
	public int fishingPole;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400220C")]
	public int bait;

	[Cpp2IlInjected.Token(Token = "0x400220D")]
	public const int coinGrabRange = 350;

	[Cpp2IlInjected.Token(Token = "0x400220E")]
	public const int manaGrabRange = 300;

	[Cpp2IlInjected.Token(Token = "0x400220F")]
	public const int lifeGrabRange = 250;

	[Cpp2IlInjected.Token(Token = "0x4002210")]
	public const int treasureGrabRange = 150;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4002211")]
	public short makeNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x4002212")]
	public short hairDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4002213")]
	public byte paint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4002214")]
	public byte paintCoating;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4002215")]
	public int ownIgnore;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4002216")]
	public int ownTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4002217")]
	public int keepTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4002218")]
	public int timeLeftInWhichTheItemCannotBeTakenByEnemies;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4002219")]
	public int type;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400221A")]
	public byte holdStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB5")]
	[Cpp2IlInjected.Token(Token = "0x400221B")]
	public byte useStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400221C")]
	public int useAnimation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400221D")]
	public int useTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400221E")]
	public int stack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400221F")]
	public int maxStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4002220")]
	public int pick;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4002221")]
	public int axe;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4002222")]
	public int hammer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4002223")]
	public int tileBoost;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4002224")]
	public int createTile;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4002225")]
	public int createWall;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4002226")]
	public int placeStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4002227")]
	public int damage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4002228")]
	public float knockBack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4002229")]
	public int healLife;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400222A")]
	public int healMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400222B")]
	public Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400222C")]
	public int alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400222D")]
	public short glowMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400222E")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400222F")]
	public LegacySoundStyle UseSound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4002230")]
	public int defense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4002231")]
	public int headSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4002232")]
	public int bodySlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4002233")]
	public int legSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4002234")]
	public sbyte handOnSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
	[Cpp2IlInjected.Token(Token = "0x4002235")]
	public sbyte handOffSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11A")]
	[Cpp2IlInjected.Token(Token = "0x4002236")]
	public sbyte backSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11B")]
	[Cpp2IlInjected.Token(Token = "0x4002237")]
	public sbyte frontSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4002238")]
	public sbyte shoeSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x4002239")]
	public sbyte waistSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
	[Cpp2IlInjected.Token(Token = "0x400223A")]
	public sbyte wingSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11F")]
	[Cpp2IlInjected.Token(Token = "0x400223B")]
	public sbyte shieldSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400223C")]
	public sbyte neckSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
	[Cpp2IlInjected.Token(Token = "0x400223D")]
	public sbyte faceSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x122")]
	[Cpp2IlInjected.Token(Token = "0x400223E")]
	public sbyte balloonSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x123")]
	[Cpp2IlInjected.Token(Token = "0x400223F")]
	public sbyte beardSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4002240")]
	public int stringColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4002241")]
	public ItemTooltip ToolTip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4002242")]
	public string BestiaryNotes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4002243")]
	public int playerIndexTheItemIsReservedFor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4002244")]
	public int rare;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x4002246")]
	public int shoot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4002247")]
	public float shootSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4002248")]
	public int ammo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4002249")]
	public int useAmmo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x400224A")]
	public int lifeRegen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400224B")]
	public int manaIncrease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x400224C")]
	public int mana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400224D")]
	public int timeSinceTheItemHasBeenReservedForSomeone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x400224E")]
	public int value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400224F")]
	public int buffType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x4002250")]
	public int buffTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4002251")]
	public int mountType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4002252")]
	public int shopSpecialCurrency;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4002253")]
	public int? shopCustomPrice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4002254")]
	public bool shootsEveryUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x179")]
	[Cpp2IlInjected.Token(Token = "0x4002255")]
	public bool chlorophyteExtractinatorConsumable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4002256")]
	public int netID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4002257")]
	public int crit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4002258")]
	public byte prefix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4002259")]
	public int reuseDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x400225A")]
	[Old]
	public bool hasVanityEffects;

	[Cpp2IlInjected.Token(Token = "0x400225B")]
	private const int foodWidth = 22;

	[Cpp2IlInjected.Token(Token = "0x400225C")]
	private const int foodHeight = 22;

	[Cpp2IlInjected.Token(Token = "0x400225D")]
	public const int WALL_PLACEMENT_USETIME = 7;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18D")]
	[Cpp2IlInjected.Token(Token = "0x400225E")]
	public bool shimmered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400225F")]
	public float shimmerTime;

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x60019A0")]
		[Cpp2IlInjected.Address(RVA = "0xD016C8", Offset = "0xD016C8", VA = "0xD016C8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public string HoverName
	{
		[Cpp2IlInjected.Token(Token = "0x60019A1")]
		[Cpp2IlInjected.Address(RVA = "0xD01754", Offset = "0xD01754", VA = "0xD01754")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public bool PaintOrCoating
	{
		[Cpp2IlInjected.Token(Token = "0x60019A6")]
		[Cpp2IlInjected.Address(RVA = "0xD028CC", Offset = "0xD028CC", VA = "0xD028CC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public bool FitsAccessoryVanitySlot
	{
		[Cpp2IlInjected.Token(Token = "0x60019A7")]
		[Cpp2IlInjected.Address(RVA = "0xD028F0", Offset = "0xD028F0", VA = "0xD028F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public int OriginalRarity
	{
		[Cpp2IlInjected.Token(Token = "0x60019A8")]
		[Cpp2IlInjected.Address(RVA = "0xD028F8", Offset = "0xD028F8", VA = "0xD028F8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public int OriginalDamage
	{
		[Cpp2IlInjected.Token(Token = "0x60019A9")]
		[Cpp2IlInjected.Address(RVA = "0xD02990", Offset = "0xD02990", VA = "0xD02990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public int OriginalDefense
	{
		[Cpp2IlInjected.Token(Token = "0x60019AA")]
		[Cpp2IlInjected.Address(RVA = "0xD02A28", Offset = "0xD02A28", VA = "0xD02A28")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public ItemVariant Variant
	{
		[Cpp2IlInjected.Token(Token = "0x60019AB")]
		[Cpp2IlInjected.Address(RVA = "0xD02AC0", Offset = "0xD02AC0", VA = "0xD02AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60019AC")]
		[Cpp2IlInjected.Address(RVA = "0xD02AC8", Offset = "0xD02AC8", VA = "0xD02AC8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public bool IsACoin
	{
		[Cpp2IlInjected.Token(Token = "0x60019CD")]
		[Cpp2IlInjected.Address(RVA = "0xD62D00", Offset = "0xD62D00", VA = "0xD62D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public bool IsAir
	{
		[Cpp2IlInjected.Token(Token = "0x6001A13")]
		[Cpp2IlInjected.Address(RVA = "0xD71664", Offset = "0xD71664", VA = "0xD71664")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000360")]
	public bool IsCurrency
	{
		[Cpp2IlInjected.Token(Token = "0x6001A19")]
		[Cpp2IlInjected.Address(RVA = "0xD718B8", Offset = "0xD718B8", VA = "0xD718B8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	public bool CanBeQuickUsed
	{
		[Cpp2IlInjected.Token(Token = "0x6001A1C")]
		[Cpp2IlInjected.Address(RVA = "0xD71A24", Offset = "0xD71A24", VA = "0xD71A24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60019A2")]
	[Cpp2IlInjected.Address(RVA = "0xD01A34", Offset = "0xD01A34", VA = "0xD01A34")]
	public static void StartCachingType(int t)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019A3")]
	[Cpp2IlInjected.Address(RVA = "0xD01AF8", Offset = "0xD01AF8", VA = "0xD01AF8")]
	public static void DropCache(IEntitySource reason, Vector2 pos, Vector2 spread, int t, bool stopCaching = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019A4")]
	[Cpp2IlInjected.Address(RVA = "0xD027EC", Offset = "0xD027EC", VA = "0xD027EC")]
	public IEntitySource GetNPCSource_FromThis()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60019A5")]
	[Cpp2IlInjected.Address(RVA = "0xD02858", Offset = "0xD02858", VA = "0xD02858")]
	public IEntitySource GetItemSource_Misc(int itemSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60019AD")]
	[Cpp2IlInjected.Address(RVA = "0xD02AD0", Offset = "0xD02AD0", VA = "0xD02AD0")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019AE")]
	[Cpp2IlInjected.Address(RVA = "0xD02C6C", Offset = "0xD02C6C", VA = "0xD02C6C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60019AF")]
	[Cpp2IlInjected.Address(RVA = "0xD02D24", Offset = "0xD02D24", VA = "0xD02D24")]
	private bool CanHavePrefixes()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019B0")]
	[Cpp2IlInjected.Address(RVA = "0xD02D68", Offset = "0xD02D68", VA = "0xD02D68")]
	public bool Prefix(int prefixWeWant)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019B1")]
	[Cpp2IlInjected.Address(RVA = "0xD04100", Offset = "0xD04100", VA = "0xD04100")]
	public bool CanRollPrefix(int prefix)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019B2")]
	[Cpp2IlInjected.Address(RVA = "0xD04500", Offset = "0xD04500", VA = "0xD04500")]
	public bool CanApplyPrefix(int prefix)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019B3")]
	[Cpp2IlInjected.Address(RVA = "0xD036D4", Offset = "0xD036D4", VA = "0xD036D4")]
	private bool TryGetPrefixStatMultipliersForItem(int rolledPrefix, out float dmg, out float kb, out float spd, out float size, out float shtspd, out float mcst, out int crt)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019B4")]
	[Cpp2IlInjected.Address(RVA = "0xD0418C", Offset = "0xD0418C", VA = "0xD0418C")]
	public int[] GetRollablePrefixes()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60019B5")]
	[Cpp2IlInjected.Address(RVA = "0xD03688", Offset = "0xD03688", VA = "0xD03688")]
	private bool RollAPrefix(UnifiedRandom random, ref int rolledPrefix)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019B6")]
	[Cpp2IlInjected.Address(RVA = "0xD045B0", Offset = "0xD045B0", VA = "0xD045B0")]
	public bool IsAPrefixableAccessory()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019B7")]
	[Cpp2IlInjected.Address(RVA = "0xD018EC", Offset = "0xD018EC", VA = "0xD018EC")]
	public string AffixName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60019B8")]
	[Cpp2IlInjected.Address(RVA = "0xD0465C", Offset = "0xD0465C", VA = "0xD0465C")]
	public void RebuildTooltip()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019B9")]
	[Cpp2IlInjected.Address(RVA = "0xD046EC", Offset = "0xD046EC", VA = "0xD046EC")]
	public Rectangle getRect()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60019BA")]
	[Cpp2IlInjected.Address(RVA = "0xD04738", Offset = "0xD04738", VA = "0xD04738")]
	public bool checkMat()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019BB")]
	[Cpp2IlInjected.Address(RVA = "0xD049E4", Offset = "0xD049E4", VA = "0xD049E4")]
	public void netDefaults(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019BC")]
	[Cpp2IlInjected.Address(RVA = "0xD04C64", Offset = "0xD04C64", VA = "0xD04C64")]
	public static int BannerToItem(int banner)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60019BD")]
	[Cpp2IlInjected.Address(RVA = "0xD04D20", Offset = "0xD04D20", VA = "0xD04D20")]
	public static int NPCtoBanner(int i)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60019BE")]
	[Cpp2IlInjected.Address(RVA = "0xD04D48", Offset = "0xD04D48", VA = "0xD04D48")]
	public static int BannerToNPC(int i)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60019BF")]
	[Cpp2IlInjected.Address(RVA = "0xD04D6C", Offset = "0xD04D6C", VA = "0xD04D6C")]
	public bool FitsAmmoSlot()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019C0")]
	[Cpp2IlInjected.Address(RVA = "0xD04DDC", Offset = "0xD04DDC", VA = "0xD04DDC")]
	public bool CanFillEmptyAmmoSlot()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019C1")]
	[Cpp2IlInjected.Address(RVA = "0xD04E90", Offset = "0xD04E90", VA = "0xD04E90")]
	public void SetDefaults1(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019C2")]
	[Cpp2IlInjected.Address(RVA = "0xD1F3CC", Offset = "0xD1F3CC", VA = "0xD1F3CC")]
	public void SetDefaults2(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019C3")]
	[Cpp2IlInjected.Address(RVA = "0xD316A8", Offset = "0xD316A8", VA = "0xD316A8")]
	public void SetDefaults3(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019C4")]
	[Cpp2IlInjected.Address(RVA = "0xD3FE58", Offset = "0xD3FE58", VA = "0xD3FE58")]
	public void DefaultToQuestFish()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019C5")]
	[Cpp2IlInjected.Address(RVA = "0xD3FFCC", Offset = "0xD3FFCC", VA = "0xD3FFCC")]
	public void SetDefaults4(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019C6")]
	[Cpp2IlInjected.Address(RVA = "0xD511F0", Offset = "0xD511F0", VA = "0xD511F0")]
	public void DefaultToGolfBall(int projid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019C7")]
	[Cpp2IlInjected.Address(RVA = "0xD51300", Offset = "0xD51300", VA = "0xD51300")]
	public void SetDefaults5(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019C8")]
	[Cpp2IlInjected.Address(RVA = "0xD62BE8", Offset = "0xD62BE8", VA = "0xD62BE8")]
	public void DefaultToSolution(int projectileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019C9")]
	[Cpp2IlInjected.Address(RVA = "0xD629B8", Offset = "0xD629B8", VA = "0xD629B8")]
	public void DefaultToWhip(int projectileId, int dmg, float kb, float shootspeed, int animationTotalTime = 30)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019CA")]
	[Cpp2IlInjected.Address(RVA = "0xD6281C", Offset = "0xD6281C", VA = "0xD6281C")]
	public void DefaultTokite(int projId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019CB")]
	[Cpp2IlInjected.Address(RVA = "0xD62CD4", Offset = "0xD62CD4", VA = "0xD62CD4")]
	public void ChangeItemType(int to)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019CC")]
	[Cpp2IlInjected.Address(RVA = "0xD62720", Offset = "0xD62720", VA = "0xD62720")]
	public void DefaultToVanitypet(int projId, int buffID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019CE")]
	[Cpp2IlInjected.Address(RVA = "0xD62D18", Offset = "0xD62D18", VA = "0xD62D18")]
	public static bool IsAGolfingItem(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019CF")]
	[Cpp2IlInjected.Address(RVA = "0xD3FE80", Offset = "0xD3FE80", VA = "0xD3FE80")]
	private void DefaultToSeaShell()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D0")]
	[Cpp2IlInjected.Address(RVA = "0xD62508", Offset = "0xD62508", VA = "0xD62508")]
	public void DefaultToCapturedCritter(short npcIdToSpawnOnUse)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D1")]
	[Cpp2IlInjected.Address(RVA = "0xD62424", Offset = "0xD62424", VA = "0xD62424")]
	public void DefaultToStaff(int projType, float pushForwardSpeed, int singleShotTime, int manaPerShot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D2")]
	[Cpp2IlInjected.Address(RVA = "0xD62350", Offset = "0xD62350", VA = "0xD62350")]
	public void DefaultToSpear(int projType, float pushForwardSpeed, int animationTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D3")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD62DE0", VA = "0xD62DE0")]
	private void SetFoodDefaults(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D4")]
	[Cpp2IlInjected.Address(RVA = "0xD624F4", Offset = "0xD624F4", VA = "0xD624F4")]
	public void DefaultToMount(int mount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D5")]
	[Cpp2IlInjected.Address(RVA = "0xD62118", Offset = "0xD62118", VA = "0xD62118")]
	public void DefaultToPlaceableWall(ushort wallToPlace)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D6")]
	[Cpp2IlInjected.Address(RVA = "0xD62300", Offset = "0xD62300", VA = "0xD62300")]
	public void SetWeaponValues(int dmg, float knockback, int bonusCritChance = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D7")]
	[Cpp2IlInjected.Address(RVA = "0xD621F8", Offset = "0xD621F8", VA = "0xD621F8")]
	public void DefaultToBow(int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D8")]
	[Cpp2IlInjected.Address(RVA = "0xD626E0", Offset = "0xD626E0", VA = "0xD626E0")]
	public void DefaultToMagicWeapon(int projType, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019D9")]
	[Cpp2IlInjected.Address(RVA = "0xD62310", Offset = "0xD62310", VA = "0xD62310")]
	public void DefaultToRangedWeapon(int baseProjType, int ammoID, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019DA")]
	[Cpp2IlInjected.Address(RVA = "0xD62620", Offset = "0xD62620", VA = "0xD62620")]
	public void DefaultToThrownWeapon(int baseProjType, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019DB")]
	[Cpp2IlInjected.Address(RVA = "0xD628E0", Offset = "0xD628E0", VA = "0xD628E0")]
	private void DefaultToTorch(int tileStyleToPlace, bool allowWaterPlacement = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019DC")]
	[Cpp2IlInjected.Address(RVA = "0xD62718", Offset = "0xD62718", VA = "0xD62718")]
	public void DefaultToPlaceableTile(int tileIDToPlace, int tileStyleToPlace = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019DD")]
	[Cpp2IlInjected.Address(RVA = "0xD61FB0", Offset = "0xD61FB0", VA = "0xD61FB0")]
	public void DefaultToPlaceableTile(ushort tileIDToPlace, int tileStyleToPlace = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019DE")]
	[Cpp2IlInjected.Address(RVA = "0xD1F3A8", Offset = "0xD1F3A8", VA = "0xD1F3A8")]
	public void MakeUsableWithChlorophyteExtractinator()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019DF")]
	[Cpp2IlInjected.Address(RVA = "0xD61F64", Offset = "0xD61F64", VA = "0xD61F64")]
	public void DefaultToGolfClub(int newwidth, int newheight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E0")]
	[Cpp2IlInjected.Address(RVA = "0xD6206C", Offset = "0xD6206C", VA = "0xD6206C")]
	public void DefaultToLawnMower(int newwidth, int newheight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E1")]
	[Cpp2IlInjected.Address(RVA = "0xD62A98", Offset = "0xD62A98", VA = "0xD62A98")]
	public void DefaultToFood(int newwidth, int newheight, int foodbuff, int foodbuffduration, bool useGulpSound = false, int animationTime = 17)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E2")]
	[Cpp2IlInjected.Address(RVA = "0xD63D58", Offset = "0xD63D58", VA = "0xD63D58")]
	public void DefaultToHealingPotion(int newwidth, int newheight, int healingAmount, int animationTime = 17)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E3")]
	[Cpp2IlInjected.Address(RVA = "0xD1F39C", Offset = "0xD1F39C", VA = "0xD1F39C")]
	public void SetShopValues(ItemRarityColor rarity, int coinValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E4")]
	[Cpp2IlInjected.Address(RVA = "0xD61F48", Offset = "0xD61F48", VA = "0xD61F48")]
	public void DefaultToHeadgear(int newwidth, int newheight, int helmetArtID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E5")]
	[Cpp2IlInjected.Address(RVA = "0xD61F30", Offset = "0xD61F30", VA = "0xD61F30")]
	public void DefaultToAccessory(int newwidth = 24, int newheight = 24)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E6")]
	[Cpp2IlInjected.Address(RVA = "0xD621CC", Offset = "0xD621CC", VA = "0xD621CC")]
	public void DefaultToGuitar(int newwidth = 24, int newheight = 24)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E7")]
	[Cpp2IlInjected.Address(RVA = "0xD625C0", Offset = "0xD625C0", VA = "0xD625C0")]
	public void DefaultToMusicBox(int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E8")]
	[Cpp2IlInjected.Address(RVA = "0xD01DBC", Offset = "0xD01DBC", VA = "0xD01DBC")]
	public void SetDefaults(int Type = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019E9")]
	[Cpp2IlInjected.Address(RVA = "0xD63E60", Offset = "0xD63E60", VA = "0xD63E60")]
	public void SetDefaults(int Type, bool noMatCheck = false, [Optional] ItemVariant variant)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019EA")]
	[Cpp2IlInjected.Address(RVA = "0xD65138", Offset = "0xD65138", VA = "0xD65138")]
	public void OnCreated(ItemCreationContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019EB")]
	[Cpp2IlInjected.Address(RVA = "0xD64F48", Offset = "0xD64F48", VA = "0xD64F48")]
	public void ResetStats(int Type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019EC")]
	[Cpp2IlInjected.Address(RVA = "0xD6516C", Offset = "0xD6516C", VA = "0xD6516C")]
	public Color GetAlphaFaded(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60019ED")]
	[Cpp2IlInjected.Address(RVA = "0xD65214", Offset = "0xD65214", VA = "0xD65214")]
	public Color GetAlpha(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60019EE")]
	[Cpp2IlInjected.Address(RVA = "0xD65B08", Offset = "0xD65B08", VA = "0xD65B08")]
	public Color GetColor(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60019EF")]
	[Cpp2IlInjected.Address(RVA = "0xD65BA8", Offset = "0xD65BA8", VA = "0xD65BA8")]
	public static bool MechSpawn(float x, float y, int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019F0")]
	[Cpp2IlInjected.Address(RVA = "0xCFBE68", Offset = "0xCFBE68", VA = "0xCFBE68")]
	public static int buyPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60019F1")]
	[Cpp2IlInjected.Address(RVA = "0xD1F374", Offset = "0xD1F374", VA = "0xD1F374")]
	public static int sellPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60019F2")]
	[Cpp2IlInjected.Address(RVA = "0xD65DA8", Offset = "0xD65DA8", VA = "0xD65DA8")]
	public bool CanShimmer()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60019F3")]
	[Cpp2IlInjected.Address(RVA = "0xD66150", Offset = "0xD66150", VA = "0xD66150")]
	private void Shimmering()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019F4")]
	[Cpp2IlInjected.Address(RVA = "0xD66094", Offset = "0xD66094", VA = "0xD66094")]
	private int FindDecraftAmount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60019F5")]
	[Cpp2IlInjected.Address(RVA = "0xD65FC0", Offset = "0xD65FC0", VA = "0xD65FC0")]
	private int GetShimmerEquivalentType()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60019F6")]
	[Cpp2IlInjected.Address(RVA = "0xD66414", Offset = "0xD66414", VA = "0xD66414")]
	private void GetShimmered()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019F7")]
	[Cpp2IlInjected.Address(RVA = "0xD67790", Offset = "0xD67790", VA = "0xD67790")]
	public static void ShimmerEffect(Vector2 shimmerPositon)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019F8")]
	[Cpp2IlInjected.Address(RVA = "0xD67A50", Offset = "0xD67A50", VA = "0xD67A50")]
	public void FixAgainstExploit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019F9")]
	[Cpp2IlInjected.Address(RVA = "0xD67B68", Offset = "0xD67B68", VA = "0xD67B68")]
	public void UpdateItem(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019FA")]
	[Cpp2IlInjected.Address(RVA = "0xD6B970", Offset = "0xD6B970", VA = "0xD6B970")]
	private void DespawnIfMeetingConditions(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019FB")]
	[Cpp2IlInjected.Address(RVA = "0xD69460", Offset = "0xD69460", VA = "0xD69460")]
	public void TryCombiningIntoNearbyItems(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019FC")]
	[Cpp2IlInjected.Address(RVA = "0xD6FF68", Offset = "0xD6FF68", VA = "0xD6FF68")]
	public FlexibleTileWand GetFlexibleTileWand()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60019FD")]
	[Cpp2IlInjected.Address(RVA = "0xD6B250", Offset = "0xD6B250", VA = "0xD6B250")]
	private void CheckLavaDeath(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019FE")]
	[Cpp2IlInjected.Address(RVA = "0xD695A8", Offset = "0xD695A8", VA = "0xD695A8")]
	private void MoveInWorld(float gravity, float maxFallSpeed, ref Vector2 wetVelocity, int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60019FF")]
	[Cpp2IlInjected.Address(RVA = "0xD68C5C", Offset = "0xD68C5C", VA = "0xD68C5C")]
	private void GetPickedUpByMonsters_Special(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A00")]
	[Cpp2IlInjected.Address(RVA = "0xD68ED8", Offset = "0xD68ED8", VA = "0xD68ED8")]
	private void GetPickedUpByMonsters_Money(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A01")]
	[Cpp2IlInjected.Address(RVA = "0xD6F900", Offset = "0xD6F900", VA = "0xD6F900")]
	private void CombineWithNearbyItems(int myItemIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A02")]
	[Cpp2IlInjected.Address(RVA = "0xD70088", Offset = "0xD70088", VA = "0xD70088")]
	public bool CanCombineStackInWorld()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A03")]
	[Cpp2IlInjected.Address(RVA = "0xD6C220", Offset = "0xD6C220", VA = "0xD6C220")]
	private void UpdateItem_VisualEffects()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A04")]
	[Cpp2IlInjected.Address(RVA = "0xD70140", Offset = "0xD70140", VA = "0xD70140")]
	public static Rectangle GetDrawHitbox(int type, Player user)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A05")]
	[Cpp2IlInjected.Address(RVA = "0xD7058C", Offset = "0xD7058C", VA = "0xD7058C")]
	public static int NewItem(Vector2 pos, Vector2 randomBox, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A06")]
	[Cpp2IlInjected.Address(RVA = "0xD70694", Offset = "0xD70694", VA = "0xD70694")]
	public static int NewItem(int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, bool noGrabDelay = false, bool reverseLookup = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A07")]
	[Cpp2IlInjected.Address(RVA = "0xD70778", Offset = "0xD70778", VA = "0xD70778")]
	public static int NewItem(IEntitySource source, Vector2 pos, Vector2 randomBox, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A08")]
	[Cpp2IlInjected.Address(RVA = "0xD70888", Offset = "0xD70888", VA = "0xD70888")]
	public static int NewItem(IEntitySource source, Vector2 pos, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A09")]
	[Cpp2IlInjected.Address(RVA = "0xD01DDC", Offset = "0xD01DDC", VA = "0xD01DDC")]
	public static int NewItem(IEntitySource source, int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, bool noGrabDelay = false, bool reverseLookup = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A0A")]
	[Cpp2IlInjected.Address(RVA = "0xD70980", Offset = "0xD70980", VA = "0xD70980")]
	private static int PickAnItemSlotToSpawnItemOn(bool reverseLookup, int nextItem)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A0B")]
	[Cpp2IlInjected.Address(RVA = "0xD70C2C", Offset = "0xD70C2C", VA = "0xD70C2C")]
	public void FindOwner(int whoAmI, bool ignoreDistance = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A0C")]
	[Cpp2IlInjected.Address(RVA = "0xD713F4", Offset = "0xD713F4", VA = "0xD713F4")]
	public Item Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001A0D")]
	[Cpp2IlInjected.Address(RVA = "0xD71498", Offset = "0xD71498", VA = "0xD71498")]
	public Item clientClone(Item cloneDestination)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001A0E")]
	[Cpp2IlInjected.Address(RVA = "0xD71540", Offset = "0xD71540", VA = "0xD71540")]
	public Item DeepClone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001A0F")]
	[Cpp2IlInjected.Address(RVA = "0xD715E4", Offset = "0xD715E4", VA = "0xD715E4")]
	public bool IsTheSameAs(Item compareItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A10")]
	[Cpp2IlInjected.Address(RVA = "0xD71614", Offset = "0xD71614", VA = "0xD71614")]
	public bool IsNotTheSameAs(Item compareItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A11")]
	[Cpp2IlInjected.Address(RVA = "0xD71650", Offset = "0xD71650", VA = "0xD71650")]
	public void SetNameOverride(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A12")]
	[Cpp2IlInjected.Address(RVA = "0xD71658", Offset = "0xD71658", VA = "0xD71658")]
	public void ClearNameOverride()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A14")]
	[Cpp2IlInjected.Address(RVA = "0xD71688", Offset = "0xD71688", VA = "0xD71688")]
	public void TurnToAir(bool fullReset = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A15")]
	[Cpp2IlInjected.Address(RVA = "0xD716DC", Offset = "0xD716DC", VA = "0xD716DC")]
	public void OnPurchase(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A16")]
	[Cpp2IlInjected.Address(RVA = "0xD7173C", Offset = "0xD7173C", VA = "0xD7173C")]
	public int GetStoreValue()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A17")]
	[Cpp2IlInjected.Address(RVA = "0xD717AC", Offset = "0xD717AC", VA = "0xD717AC")]
	public void Serialize(BinaryWriter writer, ItemSerializationContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A18")]
	[Cpp2IlInjected.Address(RVA = "0xD71810", Offset = "0xD71810", VA = "0xD71810")]
	public void DeserializeFrom(BinaryReader reader, ItemSerializationContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A1A")]
	[Cpp2IlInjected.Address(RVA = "0xD67B4C", Offset = "0xD67B4C", VA = "0xD67B4C")]
	public void ResetPrefix()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A1B")]
	[Cpp2IlInjected.Address(RVA = "0xD7194C", Offset = "0xD7194C", VA = "0xD7194C")]
	public void Refresh(bool onlyIfVariantChanged = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A1D")]
	[Cpp2IlInjected.Address(RVA = "0xD01CD4", Offset = "0xD01CD4", VA = "0xD01CD4")]
	public Item()
	{
	}
}
