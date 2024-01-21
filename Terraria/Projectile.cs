using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.WorldBuilding;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000322")]
public class Projectile : Entity
{
	[Cpp2IlInjected.Token(Token = "0x200084F")]
	private class NPCDistanceByIndexComparator : IComparer<Tuple<int, float>>
	{
		[Cpp2IlInjected.Token(Token = "0x60049F9")]
		[Cpp2IlInjected.Address(RVA = "0xC922EC", Offset = "0xC922EC", VA = "0xC922EC", Slot = "4")]
		public int Compare(Tuple<int, float> npcIndex1, Tuple<int, float> npcIndex2)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60049FA")]
		[Cpp2IlInjected.Address(RVA = "0xC92354", Offset = "0xC92354", VA = "0xC92354")]
		public NPCDistanceByIndexComparator()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000850")]
	public struct HallowBossPelletStormInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007EB8")]
		public float StartAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007EB9")]
		public float AnglePerBullet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007EBA")]
		public int BulletsInStorm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007EBB")]
		public float BulletsProgressInStormStartNormalized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007EBC")]
		public float BulletsProgressInStormBonusByIndexNormalized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007EBD")]
		public float StormTotalRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007EBE")]
		public Vector2 BulletSize;

		[Cpp2IlInjected.Token(Token = "0x60049FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF628", Offset = "0x2AF628", VA = "0x2AF628")]
		public float GetBulletProgress(int bulletIndex)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60049FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF644", Offset = "0x2AF644", VA = "0x2AF644")]
		public bool IsValid(int bulletIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60049FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF684", Offset = "0x2AF684", VA = "0x2AF684")]
		public Vector2 GetBulletPosition(int bulletIndex, Vector2 centerPoint)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60049FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6A8", Offset = "0x2AF6A8", VA = "0x2AF6A8")]
		public Rectangle GetBulletHitbox(int bulletIndex, Vector2 centerPoint)
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4002BFE")]
	private static readonly uint[] perIDStaticNPCImmunity;

	[Cpp2IlInjected.Token(Token = "0x4002BFF")]
	private static List<Tuple<int, float>> _medusaHeadTargetList;

	[Cpp2IlInjected.Token(Token = "0x4002C00")]
	private static List<int> _ai164_blacklistedTargets;

	[Cpp2IlInjected.Token(Token = "0x4002C01")]
	private static List<int> _ai158_blacklistedTargets;

	[Cpp2IlInjected.Token(Token = "0x4002C02")]
	private static List<int> _ai156_blacklistedTargets;

	[Cpp2IlInjected.Token(Token = "0x4002C03")]
	private static float[] _CompanionCubeScreamCooldown;

	[Cpp2IlInjected.Token(Token = "0x4002C04")]
	public const int SentryLifeTime = 36000;

	[Cpp2IlInjected.Token(Token = "0x4002C05")]
	public const int ArrowLifeTime = 1200;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4002C06")]
	public float ownerHitCheckDistance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4002C07")]
	public bool arrow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4002C08")]
	public int numHits;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4002C09")]
	public bool bobber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
	[Cpp2IlInjected.Token(Token = "0x4002C0A")]
	public bool netImportant;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
	[Cpp2IlInjected.Token(Token = "0x4002C0B")]
	public bool noDropItem;

	[Cpp2IlInjected.Token(Token = "0x4002C0C")]
	public static int maxAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5F")]
	[Cpp2IlInjected.Token(Token = "0x4002C0D")]
	public bool counterweight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4002C0E")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4002C0F")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4002C10")]
	public int type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4002C11")]
	public int alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4002C12")]
	public bool sentry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
	[Cpp2IlInjected.Token(Token = "0x4002C13")]
	public short glowMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4002C14")]
	public int owner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4002C15")]
	public FloatArray_3 ai;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4002C16")]
	public FloatArray_3 localAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4002C17")]
	public float gfxOffY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4002C18")]
	public float stepSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4002C19")]
	public int aiStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4002C1A")]
	public int timeLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4002C1B")]
	public int soundDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4002C1C")]
	public int damage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4002C1D")]
	public int originalDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4002C1E")]
	public int spriteDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4002C1F")]
	public bool hostile;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4002C20")]
	public bool reflected;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4002C21")]
	public float knockBack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4002C22")]
	public bool friendly;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4002C23")]
	public int penetrate;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4002C24")]
	private DictionaryIntArray localNPCImmunity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4002C25")]
	public bool usesLocalNPCImmunity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
	[Cpp2IlInjected.Token(Token = "0x4002C26")]
	public bool usesIDStaticNPCImmunity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
	[Cpp2IlInjected.Token(Token = "0x4002C27")]
	public bool appliesImmunityTimeOnSingleHits;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4002C28")]
	public int maxPenetrate;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4002C29")]
	public int identity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4002C2A")]
	public float light;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4002C2B")]
	public bool netUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
	[Cpp2IlInjected.Token(Token = "0x4002C2C")]
	public bool netUpdate2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4002C2D")]
	public int netSpam;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4002C2E")]
	public Vector2[] oldPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4002C2F")]
	public float[] oldRot;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4002C30")]
	public int[] oldSpriteDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4002C31")]
	public bool minion;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4002C32")]
	public float minionSlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4002C33")]
	public int minionPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4002C34")]
	public int restrikeDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4002C35")]
	public bool tileCollide;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4002C36")]
	public int extraUpdates;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4002C37")]
	public bool stopsDealingDamageAfterPenetrateHits;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4002C38")]
	public int numUpdates;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4002C39")]
	public bool ignoreWater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
	[Cpp2IlInjected.Token(Token = "0x4002C3A")]
	public bool isAPreviewDummy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10A")]
	[Cpp2IlInjected.Token(Token = "0x4002C3B")]
	public bool hide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10B")]
	[Cpp2IlInjected.Token(Token = "0x4002C3C")]
	public bool ownerHitCheck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4002C3D")]
	public bool usesOwnerMeleeHitCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4002C3E")]
	public DictionaryIntArray playerImmune;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4002C3F")]
	public string miscText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4002C40")]
	public bool melee;

	[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
	[Cpp2IlInjected.Token(Token = "0x4002C41")]
	public bool ranged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11A")]
	[Cpp2IlInjected.Token(Token = "0x4002C42")]
	public bool magic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11B")]
	[Cpp2IlInjected.Token(Token = "0x4002C43")]
	public bool coldDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4002C44")]
	public bool noEnchantments;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x4002C45")]
	public bool noEnchantmentVisuals;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
	[Cpp2IlInjected.Token(Token = "0x4002C46")]
	public bool trap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11F")]
	[Cpp2IlInjected.Token(Token = "0x4002C47")]
	public bool npcProj;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4002C48")]
	public bool originatedFromActivableTile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4002C49")]
	public int frameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4002C4A")]
	public int frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4002C4B")]
	public bool manualDirectionChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4002C4C")]
	public int projUUID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4002C4D")]
	public bool decidesManualFallThrough;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x4002C4E")]
	public bool shouldFallThrough;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4002C4F")]
	public int localNPCHitCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x4002C50")]
	public int idStaticNPCHitCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4002C51")]
	public int bannerIdToRespondTo;

	[Cpp2IlInjected.Token(Token = "0x4002C52")]
	private static Conditions.IsSolid _cachedConditions_solid;

	[Cpp2IlInjected.Token(Token = "0x4002C53")]
	private static Conditions.NotNull _cachedConditions_notNull;

	[Cpp2IlInjected.Token(Token = "0x4002C54")]
	private static int[] npcCrystalDartList;

	[Cpp2IlInjected.Token(Token = "0x4002C55")]
	private static Point[] StardustCellMinionShotJavelins;

	[Cpp2IlInjected.Token(Token = "0x4002C56")]
	private static Point[] DaybreakJavelins;

	[Cpp2IlInjected.Token(Token = "0x4002C57")]
	private static Point[] BoneJavelinJavelins;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4002C58")]
	public List<Vector2> WhipPointsForCollision;

	[Cpp2IlInjected.Token(Token = "0x4002C59")]
	private static Rectangle _lanceHitboxBounds;

	[Cpp2IlInjected.Token(Token = "0x4002C5A")]
	private static NPCDistanceByIndexComparator _medusaTargetComparer;

	[Cpp2IlInjected.Token(Token = "0x4002C5B")]
	public static List<int> ai92Projectiles;

	[Cpp2IlInjected.Token(Token = "0x17000522")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6002449")]
		[Cpp2IlInjected.Address(RVA = "0x86965C", Offset = "0x86965C", VA = "0x86965C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000523")]
	public bool WipableTurret
	{
		[Cpp2IlInjected.Token(Token = "0x600244D")]
		[Cpp2IlInjected.Address(RVA = "0x869918", Offset = "0x869918", VA = "0x869918")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000524")]
	public float Opacity
	{
		[Cpp2IlInjected.Token(Token = "0x600244F")]
		[Cpp2IlInjected.Address(RVA = "0x869A6C", Offset = "0x869A6C", VA = "0x869A6C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6002450")]
		[Cpp2IlInjected.Address(RVA = "0x869A90", Offset = "0x869A90", VA = "0x869A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000525")]
	public int MaxUpdates
	{
		[Cpp2IlInjected.Token(Token = "0x6002451")]
		[Cpp2IlInjected.Address(RVA = "0x869ADC", Offset = "0x869ADC", VA = "0x869ADC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002452")]
		[Cpp2IlInjected.Address(RVA = "0x869AE8", Offset = "0x869AE8", VA = "0x869AE8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000526")]
	public NPC OwnerMinionAttackTargetNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6002453")]
		[Cpp2IlInjected.Address(RVA = "0x869AF4", Offset = "0x869AF4", VA = "0x869AF4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600244A")]
	[Cpp2IlInjected.Address(RVA = "0x8696E0", Offset = "0x8696E0", VA = "0x8696E0")]
	public static void InitializeStaticThings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600244B")]
	[Cpp2IlInjected.Address(RVA = "0x869764", Offset = "0x869764", VA = "0x869764")]
	public static void ResetImmunity()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600244C")]
	[Cpp2IlInjected.Address(RVA = "0x8697F0", Offset = "0x8697F0", VA = "0x8697F0")]
	public static bool IsNPCIndexImmuneToProjectileType(int projectileType, int npcIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600244E")]
	[Cpp2IlInjected.Address(RVA = "0x8699BC", Offset = "0x8699BC", VA = "0x8699BC")]
	public bool TurretShouldPersist()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002454")]
	[Cpp2IlInjected.Address(RVA = "0x869BD4", Offset = "0x869BD4", VA = "0x869BD4")]
	public void SetDefaults(int Type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002455")]
	[Cpp2IlInjected.Address(RVA = "0x8732E8", Offset = "0x8732E8", VA = "0x8732E8")]
	public void DefaultToSpray()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002456")]
	[Cpp2IlInjected.Address(RVA = "0x8732A0", Offset = "0x8732A0", VA = "0x8732A0")]
	public void DefaultToWhip()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002457")]
	[Cpp2IlInjected.Address(RVA = "0x87332C", Offset = "0x87332C", VA = "0x87332C")]
	public static int GetNextSlot()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002458")]
	[Cpp2IlInjected.Address(RVA = "0x8733DC", Offset = "0x8733DC", VA = "0x8733DC")]
	public static int NewProjectile(IEntitySource spawnSource, Vector2 position, Vector2 velocity, int Type, int Damage, float KnockBack, int Owner = -1, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002459")]
	[Cpp2IlInjected.Address(RVA = "0x874288", Offset = "0x874288", VA = "0x874288")]
	public static int FindOldestProjectile()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600245A")]
	[Cpp2IlInjected.Address(RVA = "0x8734D0", Offset = "0x8734D0", VA = "0x8734D0")]
	public static int NewProjectile(IEntitySource spawnSource, float X, float Y, float SpeedX, float SpeedY, int Type, int Damage, float KnockBack, int Owner = -1, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600245B")]
	[Cpp2IlInjected.Address(RVA = "0x87439C", Offset = "0x87439C", VA = "0x87439C")]
	private static void FindBannerToAssociateTo(IEntitySource spawnSource, Projectile next)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600245C")]
	[Cpp2IlInjected.Address(RVA = "0x8C2E08", Offset = "0x8C2E08", VA = "0x8C2E08")]
	public static Color GetGolfTrailColor(Projectile proj)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600245D")]
	[Cpp2IlInjected.Address(RVA = "0x8C30A4", Offset = "0x8C30A4", VA = "0x8C30A4")]
	public void StatusNPC(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600245E")]
	[Cpp2IlInjected.Address(RVA = "0x8C53D0", Offset = "0x8C53D0", VA = "0x8C53D0")]
	public void StatusPvP(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600245F")]
	[Cpp2IlInjected.Address(RVA = "0x8C6850", Offset = "0x8C6850", VA = "0x8C6850")]
	public void ghostHurt(int dmg, Vector2 Position, Entity victim)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002460")]
	[Cpp2IlInjected.Address(RVA = "0x8C6EC4", Offset = "0x8C6EC4", VA = "0x8C6EC4")]
	public void ghostHeal(int dmg, Vector2 Position, Entity victim)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002461")]
	[Cpp2IlInjected.Address(RVA = "0x8C72D8", Offset = "0x8C72D8", VA = "0x8C72D8")]
	public void vampireHeal(int dmg, Vector2 Position, Entity victim)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002462")]
	[Cpp2IlInjected.Address(RVA = "0x8C7490", Offset = "0x8C7490", VA = "0x8C7490")]
	public void StatusPlayer(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002463")]
	[Cpp2IlInjected.Address(RVA = "0x8C9014", Offset = "0x8C9014", VA = "0x8C9014")]
	public bool CanHitWithMeleeWeapon(Entity ent)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002464")]
	[Cpp2IlInjected.Address(RVA = "0x8C9658", Offset = "0x8C9658", VA = "0x8C9658")]
	public bool CanHitWithOwnBody(Entity ent)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002465")]
	[Cpp2IlInjected.Address(RVA = "0x8CA088", Offset = "0x8CA088", VA = "0x8CA088")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3907B8", Offset = "0x3907B8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3907B8", Offset = "0x3907B8")]
	public void Damage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002466")]
	[Cpp2IlInjected.Address(RVA = "0x8D52E4", Offset = "0x8D52E4", VA = "0x8D52E4")]
	private Rectangle Damage_GetHitbox()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002467")]
	[Cpp2IlInjected.Address(RVA = "0x8D549C", Offset = "0x8D549C", VA = "0x8D549C")]
	private void BombsHurtPlayers(Rectangle projRectangle, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002468")]
	[Cpp2IlInjected.Address(RVA = "0x8DC4C0", Offset = "0x8DC4C0", VA = "0x8DC4C0")]
	public bool IsDamageDodgable()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002469")]
	[Cpp2IlInjected.Address(RVA = "0x8DC514", Offset = "0x8DC514", VA = "0x8DC514")]
	public static void KillOldestJavelin(int protectedProjectileIndex, int projectileType, int targetNPCIndex, Point[] bufferForScan)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600246A")]
	[Cpp2IlInjected.Address(RVA = "0x8DB15C", Offset = "0x8DB15C", VA = "0x8DB15C")]
	private int CountEnemiesWhoAreImmuneToMeRightNow(int cap)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600246B")]
	[Cpp2IlInjected.Address(RVA = "0x8DB1EC", Offset = "0x8DB1EC", VA = "0x8DB1EC")]
	private static void EmitBlackLightningParticles(NPC targetNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600246C")]
	[Cpp2IlInjected.Address(RVA = "0x8DB5E0", Offset = "0x8DB5E0", VA = "0x8DB5E0")]
	private void TryDoingOnHitEffects(Entity entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600246D")]
	[Cpp2IlInjected.Address(RVA = "0x8DC1E4", Offset = "0x8DC1E4", VA = "0x8DC1E4")]
	private void SummonSuperStarSlash(Vector2 target)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600246E")]
	[Cpp2IlInjected.Address(RVA = "0x8DBC20", Offset = "0x8DBC20", VA = "0x8DBC20")]
	private void SummonMonkGhast()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600246F")]
	[Cpp2IlInjected.Address(RVA = "0x8D5A1C", Offset = "0x8D5A1C", VA = "0x8D5A1C")]
	private void CutTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002470")]
	[Cpp2IlInjected.Address(RVA = "0x8DD244", Offset = "0x8DD244", VA = "0x8DD244")]
	private void CutTilesAt(Vector2 boxPosition, int boxWidth, int boxHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002471")]
	[Cpp2IlInjected.Address(RVA = "0x8DC838", Offset = "0x8DC838", VA = "0x8DC838")]
	private bool CanCutTiles()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002472")]
	[Cpp2IlInjected.Address(RVA = "0x8D6C34", Offset = "0x8D6C34", VA = "0x8D6C34")]
	public bool Colliding(Rectangle myRect, Rectangle targetRect)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002473")]
	[Cpp2IlInjected.Address(RVA = "0x8DDE68", Offset = "0x8DDE68", VA = "0x8DDE68")]
	public void ProjLight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002474")]
	[Cpp2IlInjected.Address(RVA = "0x8DED84", Offset = "0x8DED84", VA = "0x8DED84")]
	public Rectangle getRect()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002475")]
	[Cpp2IlInjected.Address(RVA = "0x8DEDD0", Offset = "0x8DEDD0", VA = "0x8DEDD0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39086C", Offset = "0x39086C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39086C", Offset = "0x39086C")]
	public void Update(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002476")]
	[Cpp2IlInjected.Address(RVA = "0x924A1C", Offset = "0x924A1C", VA = "0x924A1C")]
	private bool AutomaticallyChangesDirection()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002477")]
	[Cpp2IlInjected.Address(RVA = "0x8E2A5C", Offset = "0x8E2A5C", VA = "0x8E2A5C")]
	private void UpdateEnchantmentVisuals()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002478")]
	[Cpp2IlInjected.Address(RVA = "0x924B1C", Offset = "0x924B1C", VA = "0x924B1C")]
	public void EmitEnchantmentVisualsAt(Vector2 boxPosition, int boxWidth, int boxHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002479")]
	[Cpp2IlInjected.Address(RVA = "0x91C150", Offset = "0x91C150", VA = "0x91C150")]
	private void HandleMovement(Vector2 wetVelocity, out int overrideWidth, out int overrideHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600247A")]
	[Cpp2IlInjected.Address(RVA = "0x8DB2B0", Offset = "0x8DB2B0", VA = "0x8DB2B0")]
	private void LightDisc_Bounce(Vector2 hitPoint, Vector2 normal)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600247B")]
	[Cpp2IlInjected.Address(RVA = "0x926C5C", Offset = "0x926C5C", VA = "0x926C5C")]
	private void AI_149_GolfBall()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600247C")]
	[Cpp2IlInjected.Address(RVA = "0x926524", Offset = "0x926524", VA = "0x926524")]
	private void MakeBoulderOfEarthExplosion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600247D")]
	[Cpp2IlInjected.Address(RVA = "0x9268CC", Offset = "0x9268CC", VA = "0x9268CC")]
	private void UpdatePosition(Vector2 wetVelocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600247E")]
	[Cpp2IlInjected.Address(RVA = "0x927CA0", Offset = "0x927CA0", VA = "0x927CA0")]
	public void FishingCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600247F")]
	[Cpp2IlInjected.Address(RVA = "0x929760", Offset = "0x929760", VA = "0x929760")]
	private void FishingCheck_RollEnemySpawns(ref FishingAttempt fisher)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002480")]
	[Cpp2IlInjected.Address(RVA = "0x929AB4", Offset = "0x929AB4", VA = "0x929AB4")]
	private void FishingCheck_RollItemDrop(ref FishingAttempt fisher)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002481")]
	[Cpp2IlInjected.Address(RVA = "0x929630", Offset = "0x929630", VA = "0x929630")]
	private void FishingCheck_ProbeForQuestFish(ref FishingAttempt fisher)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002482")]
	[Cpp2IlInjected.Address(RVA = "0x92932C", Offset = "0x92932C", VA = "0x92932C")]
	private void FishingCheck_RollDropLevels(int fishingLevel, out bool common, out bool uncommon, out bool rare, out bool veryrare, out bool legendary, out bool crate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002483")]
	[Cpp2IlInjected.Address(RVA = "0x928FC4", Offset = "0x928FC4", VA = "0x928FC4")]
	private static void GetFishingPondState(int x, int y, out bool lava, out bool honey, out int numWaters, out int chumCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002484")]
	[Cpp2IlInjected.Address(RVA = "0x92BCEC", Offset = "0x92BCEC", VA = "0x92BCEC")]
	private static void GetFishingPondWidth(int x, int y, out int minX, out int maxX)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002485")]
	[Cpp2IlInjected.Address(RVA = "0x8DB0DC", Offset = "0x8DB0DC", VA = "0x8DB0DC")]
	public bool CanBeReflected()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002486")]
	[Cpp2IlInjected.Address(RVA = "0x92BF54", Offset = "0x92BF54", VA = "0x92BF54")]
	public Color GetFairyQueenWeaponsColor(float alphaChannelMultiplier = 1f, float lerpToWhite = 0f, [Optional] float? rawHueOverride)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002487")]
	[Cpp2IlInjected.Address(RVA = "0x92D910", Offset = "0x92D910", VA = "0x92D910")]
	public float GetLastPrismHue(float laserIndex, ref float laserLuminance, ref float laserAlphaMultiplier)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002488")]
	[Cpp2IlInjected.Address(RVA = "0x8E2DA4", Offset = "0x8E2DA4", VA = "0x8E2DA4")]
	public static int GetByUUID(int owner, float uuid)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002489")]
	[Cpp2IlInjected.Address(RVA = "0x92F930", Offset = "0x92F930", VA = "0x92F930")]
	public static int GetByUUID(int owner, int uuid)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600248A")]
	[Cpp2IlInjected.Address(RVA = "0x92FA2C", Offset = "0x92FA2C", VA = "0x92FA2C")]
	public void ProjectileFixDesperation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600248B")]
	[Cpp2IlInjected.Address(RVA = "0x91B3B8", Offset = "0x91B3B8", VA = "0x91B3B8")]
	public bool ShouldUseWindPhysics()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600248C")]
	[Cpp2IlInjected.Address(RVA = "0x92FBDC", Offset = "0x92FBDC", VA = "0x92FBDC")]
	private void AI_151_SuperStar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600248D")]
	[Cpp2IlInjected.Address(RVA = "0x930300", Offset = "0x930300", VA = "0x930300")]
	public bool IsInterruptible(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600248E")]
	[Cpp2IlInjected.Address(RVA = "0x930314", Offset = "0x930314", VA = "0x930314")]
	public void Interrupt(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600248F")]
	[Cpp2IlInjected.Address(RVA = "0x930348", Offset = "0x930348", VA = "0x930348")]
	public static IEntitySource GetNoneSource()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002490")]
	[Cpp2IlInjected.Address(RVA = "0x930350", Offset = "0x930350", VA = "0x930350")]
	public IEntitySource GetNPCSource_FromThis()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002491")]
	[Cpp2IlInjected.Address(RVA = "0x8DB180", Offset = "0x8DB180", VA = "0x8DB180")]
	public IEntitySource GetProjectileSource_FromThis()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002492")]
	[Cpp2IlInjected.Address(RVA = "0x9303BC", Offset = "0x9303BC", VA = "0x9303BC")]
	public IEntitySource GetItemSource_DropAsItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002493")]
	[Cpp2IlInjected.Address(RVA = "0x930428", Offset = "0x930428", VA = "0x930428")]
	public IEntitySource GetItemSource_FromThis()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002494")]
	[Cpp2IlInjected.Address(RVA = "0x8C6E38", Offset = "0x8C6E38", VA = "0x8C6E38")]
	public IEntitySource GetProjectileSource_OnHit(Entity victim, int projectileSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002495")]
	[Cpp2IlInjected.Address(RVA = "0x8DB6F4", Offset = "0x8DB6F4", VA = "0x8DB6F4")]
	public IEntitySource GetItemSource_OnHit(Entity victim, int itemSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002496")]
	[Cpp2IlInjected.Address(RVA = "0x930494", Offset = "0x930494", VA = "0x930494")]
	public static IEntitySource InheritSource(Projectile projectile)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002497")]
	[Cpp2IlInjected.Address(RVA = "0x9304A4", Offset = "0x9304A4", VA = "0x9304A4")]
	private void AI_152_SuperStarSlash()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002498")]
	[Cpp2IlInjected.Address(RVA = "0x93112C", Offset = "0x93112C", VA = "0x93112C")]
	public void Resize(int newWidth, int newHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002499")]
	[Cpp2IlInjected.Address(RVA = "0x91B564", Offset = "0x91B564", VA = "0x91B564")]
	private void Shimmer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600249A")]
	[Cpp2IlInjected.Address(RVA = "0x8E2E38", Offset = "0x8E2E38", VA = "0x8E2E38")]
	public void AI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600249B")]
	[Cpp2IlInjected.Address(RVA = "0x9EE588", Offset = "0x9EE588", VA = "0x9EE588")]
	private void AI_195_JimsDrone()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600249C")]
	[Cpp2IlInjected.Address(RVA = "0x9EF7DC", Offset = "0x9EF7DC", VA = "0x9EF7DC")]
	public static void UseGasTrapInChest(int chestIndex, Chest theChest, int gasTrapIndex, int gasOffsetX, int gasOffsetY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600249D")]
	[Cpp2IlInjected.Address(RVA = "0x9BB36C", Offset = "0x9BB36C", VA = "0x9BB36C")]
	private void AI_111_DryadsWard()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600249E")]
	[Cpp2IlInjected.Address(RVA = "0x9EFD10", Offset = "0x9EFD10", VA = "0x9EFD10")]
	public static bool GasTrapCheck(int x, int y, Player user)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600249F")]
	[Cpp2IlInjected.Address(RVA = "0x9EE0CC", Offset = "0x9EE0CC", VA = "0x9EE0CC")]
	private void AI_194_HorsemanPumpkin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A0")]
	[Cpp2IlInjected.Address(RVA = "0x9ED700", Offset = "0x9ED700", VA = "0x9ED700")]
	private void AI_193_Flamethrower()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A1")]
	[Cpp2IlInjected.Address(RVA = "0x98F304", Offset = "0x98F304", VA = "0x98F304")]
	private void AI_047_MagnetSphere()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A2")]
	[Cpp2IlInjected.Address(RVA = "0x9F01D8", Offset = "0x9F01D8", VA = "0x9F01D8")]
	private void AI_047_MagnetSphere_TryAttacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A3")]
	[Cpp2IlInjected.Address(RVA = "0x9F0754", Offset = "0x9F0754", VA = "0x9F0754")]
	public static void AI_192_GetJuminoFall(Projectile proj, out float timeSinceFall, out float fall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A4")]
	[Cpp2IlInjected.Address(RVA = "0x9EBBB4", Offset = "0x9EBBB4", VA = "0x9EBBB4")]
	private void AI_192_JuminoAnimation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A5")]
	[Cpp2IlInjected.Address(RVA = "0x9E98D0", Offset = "0x9E98D0", VA = "0x9E98D0")]
	private void AI_191_TrueNightsEdge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A6")]
	[Cpp2IlInjected.Address(RVA = "0x9E762C", Offset = "0x9E762C", VA = "0x9E762C")]
	private void AI_190_NightsEdge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A7")]
	[Cpp2IlInjected.Address(RVA = "0x9E60D4", Offset = "0x9E60D4", VA = "0x9E60D4")]
	private void AI_188_LightsBane()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A8")]
	[Cpp2IlInjected.Address(RVA = "0x9E65BC", Offset = "0x9E65BC", VA = "0x9E65BC")]
	private void AI_189_Volcano()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024A9")]
	[Cpp2IlInjected.Address(RVA = "0x9F07C4", Offset = "0x9F07C4", VA = "0x9F07C4")]
	private void AI_066_TryInterceptingTarget(Vector2 targetDir, Vector2 targetVelocity, float speed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024AA")]
	[Cpp2IlInjected.Address(RVA = "0x9F0980", Offset = "0x9F0980", VA = "0x9F0980")]
	public static void RandomizeInsanityShadowFor(Entity targetEntity, bool isHostile, out Vector2 spawnposition, out Vector2 spawnvelocity, out float ai0, out float ai1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024AB")]
	[Cpp2IlInjected.Address(RVA = "0x9E5830", Offset = "0x9E5830", VA = "0x9E5830")]
	private void AI_187_ShadowHand()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024AC")]
	[Cpp2IlInjected.Address(RVA = "0x9F13C4", Offset = "0x9F13C4", VA = "0x9F13C4")]
	private void AI_187_ShadowHand_GetVariation(out int variation, out float fakeCounter, out float counterMax)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024AD")]
	[Cpp2IlInjected.Address(RVA = "0x9E426C", Offset = "0x9E426C", VA = "0x9E426C")]
	private void AI_185_LifeDrain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024AE")]
	[Cpp2IlInjected.Address(RVA = "0x9E4564", Offset = "0x9E4564", VA = "0x9E4564")]
	private void AI_186_PrincessWeapon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024AF")]
	[Cpp2IlInjected.Address(RVA = "0x9E3D78", Offset = "0x9E3D78", VA = "0x9E3D78")]
	private void AI_184_BadTorchLuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B0")]
	[Cpp2IlInjected.Address(RVA = "0x9BED28", Offset = "0x9BED28", VA = "0x9BED28")]
	private void AI_121_StardustDragon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B1")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B68", Offset = "0x8D6B68", VA = "0x8D6B68")]
	private Projectile FindStardustDragonHeadOfOwner()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60024B2")]
	[Cpp2IlInjected.Address(RVA = "0x9E3C64", Offset = "0x9E3C64", VA = "0x9E3C64")]
	private void AI_183_ZoologistStrike()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B3")]
	[Cpp2IlInjected.Address(RVA = "0x9E3004", Offset = "0x9E3004", VA = "0x9E3004")]
	private void AI_182_FinalFractal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B4")]
	[Cpp2IlInjected.Address(RVA = "0x9E2D78", Offset = "0x9E2D78", VA = "0x9E2D78")]
	private void AI_181_FairyQueenRangedItemShot()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B5")]
	[Cpp2IlInjected.Address(RVA = "0x956FF8", Offset = "0x956FF8", VA = "0x956FF8")]
	private void AI_009_MagicMissiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B6")]
	[Cpp2IlInjected.Address(RVA = "0x9F1518", Offset = "0x9F1518", VA = "0x9F1518")]
	private void AI_009_MagicMissiles_Old()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B7")]
	[Cpp2IlInjected.Address(RVA = "0x925F8C", Offset = "0x925F8C", VA = "0x925F8C")]
	private void AI_015_HandleMovementCollision(ref Vector2 wetVelocity, ref Vector2 lastVelocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B8")]
	[Cpp2IlInjected.Address(RVA = "0x873294", Offset = "0x873294", VA = "0x873294")]
	private void ResetLocalNPCHitImmunity()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024B9")]
	[Cpp2IlInjected.Address(RVA = "0x95F9D4", Offset = "0x95F9D4", VA = "0x95F9D4")]
	private void AI_015_Flails()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024BA")]
	[Cpp2IlInjected.Address(RVA = "0x9F4B7C", Offset = "0x9F4B7C", VA = "0x9F4B7C")]
	private void AI_015_HandleMovementCollision_Old(ref Vector2 wetVelocity, ref Vector2 lastVelocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024BB")]
	[Cpp2IlInjected.Address(RVA = "0x9F4DCC", Offset = "0x9F4DCC", VA = "0x9F4DCC")]
	private void AI_015_Flails_Old()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024BC")]
	[Cpp2IlInjected.Address(RVA = "0x9F40AC", Offset = "0x9F40AC", VA = "0x9F40AC")]
	private void AI_015_Flails_Dust(bool doFastThrowDust)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024BD")]
	[Cpp2IlInjected.Address(RVA = "0x9B9E34", Offset = "0x9B9E34", VA = "0x9B9E34")]
	private void AI_100_Medusa()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024BE")]
	[Cpp2IlInjected.Address(RVA = "0x9BCB78", Offset = "0x9BCB78", VA = "0x9BCB78")]
	private void AI_120_StardustGuardian()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024BF")]
	[Cpp2IlInjected.Address(RVA = "0x9F5B54", Offset = "0x9F5B54", VA = "0x9F5B54")]
	private void AI_120_StardustGuardian_FindTarget(float lookupRange, ref int targetNPCIndex, ref float distanceToClosestTarget)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C0")]
	[Cpp2IlInjected.Address(RVA = "0x9E2698", Offset = "0x9E2698", VA = "0x9E2698")]
	private void AI_180_FairyQueenSunDance()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C1")]
	[Cpp2IlInjected.Address(RVA = "0x9E22B8", Offset = "0x9E22B8", VA = "0x9E22B8")]
	private void AI_179_FairyQueenLance()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C2")]
	[Cpp2IlInjected.Address(RVA = "0x9DFA58", Offset = "0x9DFA58", VA = "0x9DFA58")]
	private void AI_176_EdgyLightning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C3")]
	[Cpp2IlInjected.Address(RVA = "0x9F5F54", Offset = "0x9F5F54", VA = "0x9F5F54")]
	public NPC FindTargetWithinRange(float maxRange, bool checkCanHit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60024C4")]
	[Cpp2IlInjected.Address(RVA = "0x9DFD68", Offset = "0x9DFD68", VA = "0x9DFD68")]
	private void AI_177_IceWhipSlicer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C5")]
	[Cpp2IlInjected.Address(RVA = "0x9E0EF4", Offset = "0x9E0EF4", VA = "0x9E0EF4")]
	private void AI_178_FireExplosion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C6")]
	[Cpp2IlInjected.Address(RVA = "0x9DF690", Offset = "0x9DF690", VA = "0x9DF690")]
	private void AI_175_TitaniumStormShards()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C7")]
	[Cpp2IlInjected.Address(RVA = "0x9DEDF4", Offset = "0x9DEDF4", VA = "0x9DEDF4")]
	private void AI_174_MultisegmentPet()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C8")]
	[Cpp2IlInjected.Address(RVA = "0x9DEBE0", Offset = "0x9DEBE0", VA = "0x9DEBE0")]
	private void AI_173_HallowBossRainbowTrail()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024C9")]
	[Cpp2IlInjected.Address(RVA = "0x9F6288", Offset = "0x9F6288", VA = "0x9F6288")]
	public Color AI_173_GetColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60024CA")]
	[Cpp2IlInjected.Address(RVA = "0x9DDD54", Offset = "0x9DDD54", VA = "0x9DDD54")]
	private void AI_171_HallowBossRainbowStreak()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024CB")]
	[Cpp2IlInjected.Address(RVA = "0x9F5CF4", Offset = "0x9F5CF4", VA = "0x9F5CF4")]
	public Color AI_171_GetColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60024CC")]
	[Cpp2IlInjected.Address(RVA = "0x9DE848", Offset = "0x9DE848", VA = "0x9DE848")]
	private void AI_172_HallowBossRainbowPelletStorm()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024CD")]
	[Cpp2IlInjected.Address(RVA = "0x8DD6AC", Offset = "0x8DD6AC", VA = "0x8DD6AC")]
	public int AI_172_GetPelletStormsCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60024CE")]
	[Cpp2IlInjected.Address(RVA = "0x8DD6B4", Offset = "0x8DD6B4", VA = "0x8DD6B4")]
	public HallowBossPelletStormInfo AI_172_GetPelletStormInfo(int stormIndex)
	{
		return default(HallowBossPelletStormInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x60024CF")]
	[Cpp2IlInjected.Address(RVA = "0x8DB780", Offset = "0x8DB780", VA = "0x8DB780")]
	public int FindTargetWithLineOfSight(float maxRange = 800f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60024D0")]
	[Cpp2IlInjected.Address(RVA = "0x9DD628", Offset = "0x9DD628", VA = "0x9DD628")]
	private void AI_170_FairyGlowstick()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024D1")]
	[Cpp2IlInjected.Address(RVA = "0x9DC340", Offset = "0x9DC340", VA = "0x9DC340")]
	private void AI_169_Smolstars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024D2")]
	[Cpp2IlInjected.Address(RVA = "0x9675E8", Offset = "0x9675E8", VA = "0x9675E8")]
	private void AI_019_Spears()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024D3")]
	[Cpp2IlInjected.Address(RVA = "0x8DCF84", Offset = "0x8DCF84", VA = "0x8DCF84")]
	public bool AI_019_Spears_GetExtensionHitbox(out Rectangle extensionBox)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60024D4")]
	[Cpp2IlInjected.Address(RVA = "0x9F6748", Offset = "0x9F6748", VA = "0x9F6748")]
	private void AI_019_Spears_Old()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024D5")]
	[Cpp2IlInjected.Address(RVA = "0x9DBD8C", Offset = "0x9DBD8C", VA = "0x9DBD8C")]
	private void AI_168_FirstFractal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024D6")]
	[Cpp2IlInjected.Address(RVA = "0x9DB9D8", Offset = "0x9DB9D8", VA = "0x9DB9D8")]
	private void AI_167_SparkleGuitar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024D7")]
	[Cpp2IlInjected.Address(RVA = "0x9D80C0", Offset = "0x9D80C0", VA = "0x9D80C0")]
	private void AI_164_StormTigerGem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024D8")]
	[Cpp2IlInjected.Address(RVA = "0x9F8490", Offset = "0x9F8490", VA = "0x9F8490")]
	public static Vector2 AI_164_GetHomeLocation(Player master, int stackedIndex, int totalIndexes)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60024D9")]
	[Cpp2IlInjected.Address(RVA = "0x9D6588", Offset = "0x9D6588", VA = "0x9D6588")]
	private void AI_162_TigerPounce()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024DA")]
	[Cpp2IlInjected.Address(RVA = "0x9F8878", Offset = "0x9F8878", VA = "0x9F8878")]
	private void PrepareBombToBlow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024DB")]
	[Cpp2IlInjected.Address(RVA = "0x961920", Offset = "0x961920", VA = "0x961920")]
	private void AI_016()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024DC")]
	[Cpp2IlInjected.Address(RVA = "0x9DB568", Offset = "0x9DB568", VA = "0x9DB568")]
	private void AI_166_Dove()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024DD")]
	[Cpp2IlInjected.Address(RVA = "0x9D6220", Offset = "0x9D6220", VA = "0x9D6220")]
	private void AI_161_RapierStabs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024DE")]
	[Cpp2IlInjected.Address(RVA = "0x9D8354", Offset = "0x9D8354", VA = "0x9D8354")]
	private void AI_165_Whip()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024DF")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9C4", Offset = "0x8DC9C4", VA = "0x8DC9C4")]
	public static void FillWhipControlPoints(Projectile proj, List<Vector2> controlPoints)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024E0")]
	[Cpp2IlInjected.Address(RVA = "0x9F8D00", Offset = "0x9F8D00", VA = "0x9F8D00")]
	public static void GetWhipSettings(Projectile proj, out float timeToFlyOut, out int segments, out float rangeMultiplier)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024E1")]
	[Cpp2IlInjected.Address(RVA = "0x9D51F8", Offset = "0x9D51F8", VA = "0x9D51F8")]
	private void AI_160_Kites()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024E2")]
	[Cpp2IlInjected.Address(RVA = "0x9D4700", Offset = "0x9D4700", VA = "0x9D4700")]
	private void AI_159_PaperAirplanes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024E3")]
	[Cpp2IlInjected.Address(RVA = "0x9D34D8", Offset = "0x9D34D8", VA = "0x9D34D8")]
	private void AI_158_BabyBird()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024E4")]
	[Cpp2IlInjected.Address(RVA = "0x9F8EC8", Offset = "0x9F8EC8", VA = "0x9F8EC8")]
	public static Vector2 AI_158_GetHomeLocation(Player master, int stackedIndex)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60024E5")]
	[Cpp2IlInjected.Address(RVA = "0x9F64EC", Offset = "0x9F64EC", VA = "0x9F64EC")]
	public void Minion_FindTargetInRange(int startAttackRange, ref int attackTarget, bool skipIfCannotHitWithOwnBody, [Optional] Func<Entity, int, bool> customEliminationCheck)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024E6")]
	[Cpp2IlInjected.Address(RVA = "0x9F94D4", Offset = "0x9F94D4", VA = "0x9F94D4")]
	private bool AI_067_CustomEliminationCheck_Pirates(Entity otherEntity, int currentTarget)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60024E7")]
	[Cpp2IlInjected.Address(RVA = "0x9F94DC", Offset = "0x9F94DC", VA = "0x9F94DC")]
	private bool AI_067_TigerSpecialAttack()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60024E8")]
	[Cpp2IlInjected.Address(RVA = "0x9A3168", Offset = "0x9A3168", VA = "0x9A3168")]
	private void AI_067_FreakingPirates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024E9")]
	[Cpp2IlInjected.Address(RVA = "0x9D25AC", Offset = "0x9D25AC", VA = "0x9D25AC")]
	private void AI_157_SharpTears()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024EA")]
	[Cpp2IlInjected.Address(RVA = "0x9F92B8", Offset = "0x9F92B8", VA = "0x9F92B8")]
	public bool IsInRangeOfMeOrMyOwner(Entity entity, float maxDistance, out float myDistance, out float playerDistance, out bool closerIsMe)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60024EB")]
	[Cpp2IlInjected.Address(RVA = "0x9D21E8", Offset = "0x9D21E8", VA = "0x9D21E8")]
	private void AI_156_BatOfLight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024EC")]
	[Cpp2IlInjected.Address(RVA = "0x9F9FD4", Offset = "0x9F9FD4", VA = "0x9F9FD4")]
	public Color AI_156_GetColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60024ED")]
	[Cpp2IlInjected.Address(RVA = "0x9FA0CC", Offset = "0x9FA0CC", VA = "0x9FA0CC")]
	private void AI_156_Think(List<int> blacklist)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024EE")]
	[Cpp2IlInjected.Address(RVA = "0x9FC7A0", Offset = "0x9FC7A0", VA = "0x9FC7A0")]
	private void AI_156_StartAttack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024EF")]
	[Cpp2IlInjected.Address(RVA = "0x9FC514", Offset = "0x9FC514", VA = "0x9FC514")]
	private int AI_156_TryAttackingNPCs(List<int> blackListedTargets, bool skipBodyCheck = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60024F0")]
	[Cpp2IlInjected.Address(RVA = "0x9F6138", Offset = "0x9F6138", VA = "0x9F6138")]
	private void AI_GetMyGroupIndexAndFillBlackList(List<int> blackListedTargets, out int index, out int totalIndexesInGroup)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024F1")]
	[Cpp2IlInjected.Address(RVA = "0x9FBFAC", Offset = "0x9FBFAC", VA = "0x9FBFAC")]
	private void AI_156_GetIdlePosition(int stackedIndex, int totalIndexes, out Vector2 idleSpot, out float idleRotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024F2")]
	[Cpp2IlInjected.Address(RVA = "0x9D0BE0", Offset = "0x9D0BE0", VA = "0x9D0BE0")]
	private void AI_155_MysticSnakeCoil()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024F3")]
	[Cpp2IlInjected.Address(RVA = "0x9FC7AC", Offset = "0x9FC7AC", VA = "0x9FC7AC")]
	private void AI_155_RemoveRope(Point start, Point end)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024F4")]
	[Cpp2IlInjected.Address(RVA = "0x9FC990", Offset = "0x9FC990", VA = "0x9FC990")]
	private void AI_155_SpawnRopeIn(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024F5")]
	[Cpp2IlInjected.Address(RVA = "0x9D0890", Offset = "0x9D0890", VA = "0x9D0890")]
	private void AI_154_VoidLens()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024F6")]
	[Cpp2IlInjected.Address(RVA = "0x9D03CC", Offset = "0x9D03CC", VA = "0x9D03CC")]
	private void AI_153_ToiletPop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024F7")]
	[Cpp2IlInjected.Address(RVA = "0x9CF358", Offset = "0x9CF358", VA = "0x9CF358")]
	private void AI_150_GolfClubHelper()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024F8")]
	[Cpp2IlInjected.Address(RVA = "0x9FCFAC", Offset = "0x9FCFAC", VA = "0x9FCFAC")]
	public Color GetCeleb2Color()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60024F9")]
	[Cpp2IlInjected.Address(RVA = "0x954030", Offset = "0x954030", VA = "0x954030")]
	private void AI_007_GrapplingHooks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024FA")]
	[Cpp2IlInjected.Address(RVA = "0x9FD210", Offset = "0x9FD210", VA = "0x9FD210")]
	private bool AI_007_GrapplingHooks_CanTileBeLatchedOnTo(Tile theTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60024FB")]
	[Cpp2IlInjected.Address(RVA = "0x9CD9B0", Offset = "0x9CD9B0", VA = "0x9CD9B0")]
	private void AI_147_Celeb2Rocket()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024FC")]
	[Cpp2IlInjected.Address(RVA = "0x9CEEF0", Offset = "0x9CEEF0", VA = "0x9CEEF0")]
	private void AI_148_StarSpawner()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024FD")]
	[Cpp2IlInjected.Address(RVA = "0x9FD364", Offset = "0x9FD364", VA = "0x9FD364")]
	private void AI_147_Explosion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024FE")]
	[Cpp2IlInjected.Address(RVA = "0x9271CC", Offset = "0x9271CC", VA = "0x9271CC")]
	private void CreateGroundExplosion(float MAX_SPREAD, int fluff, int distFluff, int layerStart, int layerEnd, int layerJump)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60024FF")]
	[Cpp2IlInjected.Address(RVA = "0xA00998", Offset = "0xA00998", VA = "0xA00998")]
	public void CheckUsability(Player player, ref bool currentlyUsable)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002500")]
	[Cpp2IlInjected.Address(RVA = "0x9D70C8", Offset = "0x9D70C8", VA = "0x9D70C8")]
	private void AI_163_Chum()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002501")]
	[Cpp2IlInjected.Address(RVA = "0xA00BEC", Offset = "0xA00BEC", VA = "0xA00BEC")]
	private void ReduceRemainingChumsInPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002502")]
	[Cpp2IlInjected.Address(RVA = "0x996528", Offset = "0x996528", VA = "0x996528")]
	private void AI_061_FishingBobber()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002503")]
	[Cpp2IlInjected.Address(RVA = "0xA009AC", Offset = "0xA009AC", VA = "0xA009AC")]
	private float AI_061_FishingBobber_GetWaterLine(int X, int Y)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002504")]
	[Cpp2IlInjected.Address(RVA = "0xA0129C", Offset = "0xA0129C", VA = "0xA0129C")]
	private void AI_061_FishingBobber_DoASplash()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002505")]
	[Cpp2IlInjected.Address(RVA = "0xA014A0", Offset = "0xA014A0", VA = "0xA014A0")]
	private void AI_061_FishingBobber_GiveItemToPlayer(Player thePlayer, int itemType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002506")]
	[Cpp2IlInjected.Address(RVA = "0x9CD9AC", Offset = "0x9CD9AC", VA = "0x9CD9AC")]
	private void AI_146_DD2Victory()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002507")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9B8", Offset = "0x8DB9B8", VA = "0x8DB9B8")]
	private void BetsySharpnel(int npcIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002508")]
	[Cpp2IlInjected.Address(RVA = "0xA01B9C", Offset = "0xA01B9C", VA = "0xA01B9C")]
	private void CopyLocalNPCImmunityTimes(Projectile p)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002509")]
	[Cpp2IlInjected.Address(RVA = "0x931188", Offset = "0x931188", VA = "0x931188")]
	private void AI_001()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600250A")]
	[Cpp2IlInjected.Address(RVA = "0xA01BE8", Offset = "0xA01BE8", VA = "0xA01BE8")]
	private void AI_002()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600250B")]
	[Cpp2IlInjected.Address(RVA = "0x94D254", Offset = "0x94D254", VA = "0x94D254")]
	private void AI_003()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600250C")]
	[Cpp2IlInjected.Address(RVA = "0x94FF04", Offset = "0x94FF04", VA = "0x94FF04")]
	private void AI_004()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600250D")]
	[Cpp2IlInjected.Address(RVA = "0x950DCC", Offset = "0x950DCC", VA = "0x950DCC")]
	private void AI_005()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600250E")]
	[Cpp2IlInjected.Address(RVA = "0x952FAC", Offset = "0x952FAC", VA = "0x952FAC")]
	private void AI_006()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600250F")]
	[Cpp2IlInjected.Address(RVA = "0x9563A4", Offset = "0x9563A4", VA = "0x9563A4")]
	private void AI_008()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002510")]
	[Cpp2IlInjected.Address(RVA = "0x9593D0", Offset = "0x9593D0", VA = "0x9593D0")]
	private void AI_010()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002511")]
	[Cpp2IlInjected.Address(RVA = "0x95AA5C", Offset = "0x95AA5C", VA = "0x95AA5C")]
	private void AI_011()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002512")]
	[Cpp2IlInjected.Address(RVA = "0x95B3F0", Offset = "0x95B3F0", VA = "0x95B3F0")]
	private void AI_012()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002513")]
	[Cpp2IlInjected.Address(RVA = "0x95BE5C", Offset = "0x95BE5C", VA = "0x95BE5C")]
	private void AI_013()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002514")]
	[Cpp2IlInjected.Address(RVA = "0x95C778", Offset = "0x95C778", VA = "0x95C778")]
	private void AI_014()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002515")]
	[Cpp2IlInjected.Address(RVA = "0x966D5C", Offset = "0x966D5C", VA = "0x966D5C")]
	private void AI_017()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002516")]
	[Cpp2IlInjected.Address(RVA = "0x967204", Offset = "0x967204", VA = "0x967204")]
	private void AI_018()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002517")]
	[Cpp2IlInjected.Address(RVA = "0x9697A0", Offset = "0x9697A0", VA = "0x9697A0")]
	private void AI_020()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002518")]
	[Cpp2IlInjected.Address(RVA = "0x96A0D4", Offset = "0x96A0D4", VA = "0x96A0D4")]
	private void AI_021()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002519")]
	[Cpp2IlInjected.Address(RVA = "0x96A38C", Offset = "0x96A38C", VA = "0x96A38C")]
	private void AI_022()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600251A")]
	[Cpp2IlInjected.Address(RVA = "0x96C1A4", Offset = "0x96C1A4", VA = "0x96C1A4")]
	private void AI_023()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600251B")]
	[Cpp2IlInjected.Address(RVA = "0x96C818", Offset = "0x96C818", VA = "0x96C818")]
	private void AI_024()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600251C")]
	[Cpp2IlInjected.Address(RVA = "0x96CBD0", Offset = "0x96CBD0", VA = "0x96CBD0")]
	private void AI_025()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600251D")]
	[Cpp2IlInjected.Address(RVA = "0x96D3C8", Offset = "0x96D3C8", VA = "0x96D3C8")]
	private void AI_026()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600251E")]
	[Cpp2IlInjected.Address(RVA = "0x98419C", Offset = "0x98419C", VA = "0x98419C")]
	private void AI_027()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600251F")]
	[Cpp2IlInjected.Address(RVA = "0x984F20", Offset = "0x984F20", VA = "0x984F20")]
	private void AI_028()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002520")]
	[Cpp2IlInjected.Address(RVA = "0x985D2C", Offset = "0x985D2C", VA = "0x985D2C")]
	private void AI_029()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002521")]
	[Cpp2IlInjected.Address(RVA = "0x9878A0", Offset = "0x9878A0", VA = "0x9878A0")]
	private void AI_030()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002522")]
	[Cpp2IlInjected.Address(RVA = "0xA05314", Offset = "0xA05314", VA = "0xA05314")]
	private void AI_031()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002523")]
	[Cpp2IlInjected.Address(RVA = "0x988758", Offset = "0x988758", VA = "0x988758")]
	private void AI_032()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002524")]
	[Cpp2IlInjected.Address(RVA = "0xA05800", Offset = "0xA05800", VA = "0xA05800")]
	private void AI_033()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002525")]
	[Cpp2IlInjected.Address(RVA = "0x988F6C", Offset = "0x988F6C", VA = "0x988F6C")]
	private void AI_034()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002526")]
	[Cpp2IlInjected.Address(RVA = "0x989AEC", Offset = "0x989AEC", VA = "0x989AEC")]
	private void AI_035()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002527")]
	[Cpp2IlInjected.Address(RVA = "0x98A4D4", Offset = "0x98A4D4", VA = "0x98A4D4")]
	private void AI_036()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002528")]
	[Cpp2IlInjected.Address(RVA = "0x98AE88", Offset = "0x98AE88", VA = "0x98AE88")]
	private void AI_037()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002529")]
	[Cpp2IlInjected.Address(RVA = "0x98B2A8", Offset = "0x98B2A8", VA = "0x98B2A8")]
	private void AI_038()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600252A")]
	[Cpp2IlInjected.Address(RVA = "0x98B480", Offset = "0x98B480", VA = "0x98B480")]
	private void AI_039()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600252B")]
	[Cpp2IlInjected.Address(RVA = "0x98C734", Offset = "0x98C734", VA = "0x98C734")]
	private void AI_040()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600252C")]
	[Cpp2IlInjected.Address(RVA = "0x98CAA0", Offset = "0x98CAA0", VA = "0x98CAA0")]
	private void AI_041()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600252D")]
	[Cpp2IlInjected.Address(RVA = "0x98CB7C", Offset = "0x98CB7C", VA = "0x98CB7C")]
	private void AI_042()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600252E")]
	[Cpp2IlInjected.Address(RVA = "0x98D36C", Offset = "0x98D36C", VA = "0x98D36C")]
	private void AI_043()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600252F")]
	[Cpp2IlInjected.Address(RVA = "0x98DC54", Offset = "0x98DC54", VA = "0x98DC54")]
	private void AI_044()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002530")]
	[Cpp2IlInjected.Address(RVA = "0x98E0A0", Offset = "0x98E0A0", VA = "0x98E0A0")]
	private void AI_045()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002531")]
	[Cpp2IlInjected.Address(RVA = "0x98EC48", Offset = "0x98EC48", VA = "0x98EC48")]
	private void AI_046()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002532")]
	[Cpp2IlInjected.Address(RVA = "0x98F648", Offset = "0x98F648", VA = "0x98F648")]
	private void AI_048()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002533")]
	[Cpp2IlInjected.Address(RVA = "0x990458", Offset = "0x990458", VA = "0x990458")]
	private void AI_049()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002534")]
	[Cpp2IlInjected.Address(RVA = "0x990DEC", Offset = "0x990DEC", VA = "0x990DEC")]
	private void AI_050()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002535")]
	[Cpp2IlInjected.Address(RVA = "0x991844", Offset = "0x991844", VA = "0x991844")]
	private void AI_051()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002536")]
	[Cpp2IlInjected.Address(RVA = "0x99222C", Offset = "0x99222C", VA = "0x99222C")]
	private void AI_052()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002537")]
	[Cpp2IlInjected.Address(RVA = "0xA05CA4", Offset = "0xA05CA4", VA = "0xA05CA4")]
	private void AI_053()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002538")]
	[Cpp2IlInjected.Address(RVA = "0x992AD0", Offset = "0x992AD0", VA = "0x992AD0")]
	private void AI_054()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002539")]
	[Cpp2IlInjected.Address(RVA = "0x993AF8", Offset = "0x993AF8", VA = "0x993AF8")]
	private void AI_055()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600253A")]
	[Cpp2IlInjected.Address(RVA = "0x99423C", Offset = "0x99423C", VA = "0x99423C")]
	private void AI_056()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600253B")]
	[Cpp2IlInjected.Address(RVA = "0x99442C", Offset = "0x99442C", VA = "0x99442C")]
	private void AI_057()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600253C")]
	[Cpp2IlInjected.Address(RVA = "0x994820", Offset = "0x994820", VA = "0x994820")]
	private void AI_058()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600253D")]
	[Cpp2IlInjected.Address(RVA = "0x9949E8", Offset = "0x9949E8", VA = "0x9949E8")]
	private void AI_059()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600253E")]
	[Cpp2IlInjected.Address(RVA = "0x995098", Offset = "0x995098", VA = "0x995098")]
	private void AI_060()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600253F")]
	[Cpp2IlInjected.Address(RVA = "0xA05248", Offset = "0xA05248", VA = "0xA05248")]
	private bool Chester_IsAnyPlayerTrackingThisProjectile()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002540")]
	[Cpp2IlInjected.Address(RVA = "0x99735C", Offset = "0x99735C", VA = "0x99735C")]
	private void AI_062()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002541")]
	[Cpp2IlInjected.Address(RVA = "0x99E8D4", Offset = "0x99E8D4", VA = "0x99E8D4")]
	private void AI_063()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002542")]
	[Cpp2IlInjected.Address(RVA = "0x99EE30", Offset = "0x99EE30", VA = "0x99EE30")]
	private void AI_064()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002543")]
	[Cpp2IlInjected.Address(RVA = "0x99F710", Offset = "0x99F710", VA = "0x99F710")]
	private void AI_065()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002544")]
	[Cpp2IlInjected.Address(RVA = "0x99FF4C", Offset = "0x99FF4C", VA = "0x99FF4C")]
	private void AI_066()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002545")]
	[Cpp2IlInjected.Address(RVA = "0x9A9394", Offset = "0x9A9394", VA = "0x9A9394")]
	private void AI_068()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002546")]
	[Cpp2IlInjected.Address(RVA = "0x9A9D48", Offset = "0x9A9D48", VA = "0x9A9D48")]
	private void AI_069()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002547")]
	[Cpp2IlInjected.Address(RVA = "0x9AA544", Offset = "0x9AA544", VA = "0x9AA544")]
	private void AI_070()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002548")]
	[Cpp2IlInjected.Address(RVA = "0x9AACC0", Offset = "0x9AACC0", VA = "0x9AACC0")]
	private void AI_075()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002549")]
	[Cpp2IlInjected.Address(RVA = "0x9B5050", Offset = "0x9B5050", VA = "0x9B5050")]
	private void AI_092()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600254A")]
	[Cpp2IlInjected.Address(RVA = "0x9B61A8", Offset = "0x9B61A8", VA = "0x9B61A8")]
	private void AI_099_1()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600254B")]
	[Cpp2IlInjected.Address(RVA = "0x9B7DA8", Offset = "0x9B7DA8", VA = "0x9B7DA8")]
	private void AI_099_2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600254C")]
	[Cpp2IlInjected.Address(RVA = "0x9C0620", Offset = "0x9C0620", VA = "0x9C0620")]
	private void AI_130_FlameBurstTower()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600254D")]
	[Cpp2IlInjected.Address(RVA = "0xA06F0C", Offset = "0xA06F0C", VA = "0xA06F0C")]
	private int AI_130_FlameBurstTower_FindTarget(float shot_range, float angleRatioMax, Vector2 shootingSpot, bool canChangeDirection = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600254E")]
	[Cpp2IlInjected.Address(RVA = "0xA07608", Offset = "0xA07608", VA = "0xA07608")]
	private int AI_134_Ballista_FindTarget(float shot_range, float deadBottomAngle, Vector2 shootingSpot)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600254F")]
	[Cpp2IlInjected.Address(RVA = "0x9C2544", Offset = "0x9C2544", VA = "0x9C2544")]
	private void AI_131_FlameBurstShot()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002550")]
	[Cpp2IlInjected.Address(RVA = "0x9C28F4", Offset = "0x9C28F4", VA = "0x9C28F4")]
	private void AI_134_Ballista()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002551")]
	[Cpp2IlInjected.Address(RVA = "0xA07C84", Offset = "0xA07C84", VA = "0xA07C84")]
	public static int GetBallistraShotDelay(Player player)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002552")]
	[Cpp2IlInjected.Address(RVA = "0x9C3488", Offset = "0x9C3488", VA = "0x9C3488")]
	private void AI_135_OgreStomp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002553")]
	[Cpp2IlInjected.Address(RVA = "0x9C47A8", Offset = "0x9C47A8", VA = "0x9C47A8")]
	private void AI_136_BetsyBreath()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002554")]
	[Cpp2IlInjected.Address(RVA = "0x9C5978", Offset = "0x9C5978", VA = "0x9C5978")]
	private void AI_137_LightningAura()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002555")]
	[Cpp2IlInjected.Address(RVA = "0x9C6C84", Offset = "0x9C6C84", VA = "0x9C6C84")]
	private void AI_138_ExplosiveTrap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002556")]
	[Cpp2IlInjected.Address(RVA = "0xA07CB0", Offset = "0xA07CB0", VA = "0xA07CB0")]
	public static int GetExplosiveTrapCooldown(Player player)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002557")]
	[Cpp2IlInjected.Address(RVA = "0x9C72B8", Offset = "0x9C72B8", VA = "0x9C72B8")]
	private void AI_139_ExplosiveTrapExplosion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002558")]
	[Cpp2IlInjected.Address(RVA = "0x9C74BC", Offset = "0x9C74BC", VA = "0x9C74BC")]
	private void AI_140_MonkStaffT1()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002559")]
	[Cpp2IlInjected.Address(RVA = "0x9C90D0", Offset = "0x9C90D0", VA = "0x9C90D0")]
	private void AI_141_MonkStaffT1Explosion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600255A")]
	[Cpp2IlInjected.Address(RVA = "0x9F32C4", Offset = "0x9F32C4", VA = "0x9F32C4")]
	private void CreateImpactExplosion(int dustAmountMultiplier, Vector2 explosionOrigin, ref Point scanAreaStart, ref Point scanAreaEnd, int explosionRange, out bool causedShockwaves)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600255B")]
	[Cpp2IlInjected.Address(RVA = "0xA07CD0", Offset = "0xA07CD0", VA = "0xA07CD0")]
	private void CreateImpactExplosion2_SleepyOctopod(Vector2 explosionOrigin, bool causedShockwaves)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600255C")]
	[Cpp2IlInjected.Address(RVA = "0x9F3918", Offset = "0x9F3918", VA = "0x9F3918")]
	private void CreateImpactExplosion2_FlailTileCollision(Vector2 explosionOrigin, bool causedShockwaves, Vector2 velocityBeforeCollision)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600255D")]
	[Cpp2IlInjected.Address(RVA = "0x9C9290", Offset = "0x9C9290", VA = "0x9C9290")]
	private void AI_142_MonkStaffT2And3()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600255E")]
	[Cpp2IlInjected.Address(RVA = "0x9CAB2C", Offset = "0x9CAB2C", VA = "0x9CAB2C")]
	private void AI_143_MonkStaffT2Ghast()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600255F")]
	[Cpp2IlInjected.Address(RVA = "0x9CB2C0", Offset = "0x9CB2C0", VA = "0x9CB2C0")]
	private void AI_144_DD2Pet()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002560")]
	[Cpp2IlInjected.Address(RVA = "0x9CC7B8", Offset = "0x9CC7B8", VA = "0x9CC7B8")]
	private void AI_145_BookStaffStorm()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002561")]
	[Cpp2IlInjected.Address(RVA = "0x8DD804", Offset = "0x8DD804", VA = "0x8DD804")]
	public bool AI_137_CanHit(Vector2 targetPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002562")]
	[Cpp2IlInjected.Address(RVA = "0x9F8B70", Offset = "0x9F8B70", VA = "0x9F8B70")]
	private Point GetScarabBombDigDirectionSnap8()
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002563")]
	[Cpp2IlInjected.Address(RVA = "0x9F83E8", Offset = "0x9F83E8", VA = "0x9F83E8")]
	public Color GetFirstFractalColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002564")]
	[Cpp2IlInjected.Address(RVA = "0xA08260", Offset = "0xA08260", VA = "0xA08260")]
	public void Kill_DirtAndFluidProjectiles_RunDelegateMethodPushUpForHalfBricks(Point pt, float size, Utils.TileActionAttempt plot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002565")]
	[Cpp2IlInjected.Address(RVA = "0xA0846C", Offset = "0xA0846C", VA = "0xA0846C")]
	public bool IsAttachedTo(NPC npc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002566")]
	[Cpp2IlInjected.Address(RVA = "0xA084E8", Offset = "0xA084E8", VA = "0xA084E8")]
	private void BoulderExplosion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002567")]
	[Cpp2IlInjected.Address(RVA = "0xA087A8", Offset = "0xA087A8", VA = "0xA087A8")]
	private void SpawnWebs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002568")]
	[Cpp2IlInjected.Address(RVA = "0x8744F0", Offset = "0x8744F0", VA = "0x8744F0")]
	public void Kill()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002569")]
	[Cpp2IlInjected.Address(RVA = "0xA08C5C", Offset = "0xA08C5C", VA = "0xA08C5C")]
	private void DropGeodeGems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600256A")]
	[Cpp2IlInjected.Address(RVA = "0xA08BC8", Offset = "0xA08BC8", VA = "0xA08BC8")]
	private void TryGettingHitByOtherPlayersExplosives()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600256B")]
	[Cpp2IlInjected.Address(RVA = "0x9BC390", Offset = "0x9BC390", VA = "0x9BC390")]
	private void DoRainbowCrystalStaffExplosion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600256C")]
	[Cpp2IlInjected.Address(RVA = "0xA0910C", Offset = "0xA0910C", VA = "0xA0910C")]
	public bool ShouldWallExplode(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600256D")]
	[Cpp2IlInjected.Address(RVA = "0xA09D3C", Offset = "0xA09D3C", VA = "0xA09D3C")]
	public Color GetFloatingDaggerMinionGlowColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600256E")]
	[Cpp2IlInjected.Address(RVA = "0xA09E64", Offset = "0xA09E64", VA = "0xA09E64")]
	public bool CanExplodeTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600256F")]
	[Cpp2IlInjected.Address(RVA = "0xA092F4", Offset = "0xA092F4", VA = "0xA092F4")]
	public void ExplodeTiles(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ, bool wallSplode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002570")]
	[Cpp2IlInjected.Address(RVA = "0xA098F4", Offset = "0xA098F4", VA = "0xA098F4")]
	public void ExplodeCrackedTiles(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002571")]
	[Cpp2IlInjected.Address(RVA = "0xA0A2A8", Offset = "0xA0A2A8", VA = "0xA0A2A8")]
	public bool TryGetContainerIndex(out int containerIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002572")]
	[Cpp2IlInjected.Address(RVA = "0xA0A2E8", Offset = "0xA0A2E8", VA = "0xA0A2E8")]
	public bool IsInteractible()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002573")]
	[Cpp2IlInjected.Address(RVA = "0xA0A318", Offset = "0xA0A318", VA = "0xA0A318")]
	public Color GetAlpha(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002574")]
	[Cpp2IlInjected.Address(RVA = "0xA0CB00", Offset = "0xA0CB00", VA = "0xA0CB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002575")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF40", Offset = "0xA0CF40", VA = "0xA0CF40")]
	public Projectile()
	{
	}
}
