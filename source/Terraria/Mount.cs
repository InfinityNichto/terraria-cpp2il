using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000338")]
public class Mount
{
	[Cpp2IlInjected.Token(Token = "0x200085D")]
	private class DrillBeam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007F14")]
		public Point16 curTileTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007F15")]
		public int cooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007F16")]
		public int lastPurpose;

		[Cpp2IlInjected.Token(Token = "0x6004A96")]
		[Cpp2IlInjected.Address(RVA = "0x678868", Offset = "0x678868", VA = "0x678868")]
		public DrillBeam()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200085E")]
	private class DrillMountData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007F17")]
		public float diodeRotationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007F18")]
		public float diodeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007F19")]
		public float outerRingRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007F1A")]
		public DrillBeam[] beams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007F1B")]
		public int beamCooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007F1C")]
		public Vector2 crosshairPosition;

		[Cpp2IlInjected.Token(Token = "0x6004A97")]
		[Cpp2IlInjected.Address(RVA = "0x678900", Offset = "0x678900", VA = "0x678900")]
		public DrillMountData()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200085F")]
	private class BooleanMountData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007F1D")]
		public bool boolean;

		[Cpp2IlInjected.Token(Token = "0x6004A98")]
		[Cpp2IlInjected.Address(RVA = "0x678848", Offset = "0x678848", VA = "0x678848")]
		public BooleanMountData()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000860")]
	private class ExtraFrameMountData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007F1E")]
		public int frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007F1F")]
		public float frameCounter;

		[Cpp2IlInjected.Token(Token = "0x6004A99")]
		[Cpp2IlInjected.Address(RVA = "0x6789E4", Offset = "0x6789E4", VA = "0x6789E4")]
		public ExtraFrameMountData()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000861")]
	public class MountDelegatesData
	{
		[Cpp2IlInjected.Token(Token = "0x2000B53")]
		public delegate bool OverridePositionMethod(Player player, out Vector2? position);

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007F20")]
		public Action<Vector2> MinecartDust;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007F21")]
		public Action<Player, Vector2, int, int> MinecartJumpingSound;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007F22")]
		public Action<Player, Vector2, int, int> MinecartLandingSound;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007F23")]
		public Action<Player, Vector2, int, int> MinecartBumperSound;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007F24")]
		public OverridePositionMethod MouthPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007F25")]
		public OverridePositionMethod HandPosition;

		[Cpp2IlInjected.Token(Token = "0x6004A9A")]
		[Cpp2IlInjected.Address(RVA = "0x678BA8", Offset = "0x678BA8", VA = "0x678BA8")]
		public MountDelegatesData()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000862")]
	private class MountData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007F26")]
		public Asset<Texture2D> backTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007F27")]
		public Asset<Texture2D> backTextureGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007F28")]
		public Asset<Texture2D> backTextureExtra;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007F29")]
		public Asset<Texture2D> backTextureExtraGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007F2A")]
		public Asset<Texture2D> frontTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007F2B")]
		public Asset<Texture2D> frontTextureGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007F2C")]
		public Asset<Texture2D> frontTextureExtra;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007F2D")]
		public Asset<Texture2D> frontTextureExtraGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007F2E")]
		public int textureWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007F2F")]
		public int textureHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007F30")]
		public int xOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007F31")]
		public int yOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4007F32")]
		public int[] playerYOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4007F33")]
		public int bodyFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4007F34")]
		public int playerHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4007F35")]
		public int heightBoost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4007F36")]
		public int buff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4007F37")]
		public int extraBuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4007F38")]
		public int flightTimeMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4007F39")]
		public bool usesHover;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4007F3A")]
		public float runSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4007F3B")]
		public float dashSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4007F3C")]
		public float swimSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4007F3D")]
		public float acceleration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4007F3E")]
		public float jumpSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4007F3F")]
		public int jumpHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4007F40")]
		public float fallDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4007F41")]
		public int fatigueMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4007F42")]
		public bool constantJump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4007F43")]
		public bool blockExtraJumps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4007F44")]
		public int abilityChargeMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4007F45")]
		public int abilityDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4007F46")]
		public int abilityCooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4007F47")]
		public int spawnDust;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4007F48")]
		public bool spawnDustNoGravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4007F49")]
		public int totalFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4007F4A")]
		public int standingFrameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4007F4B")]
		public int standingFrameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4007F4C")]
		public int standingFrameDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4007F4D")]
		public int runningFrameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4007F4E")]
		public int runningFrameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4007F4F")]
		public int runningFrameDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4007F50")]
		public int flyingFrameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4007F51")]
		public int flyingFrameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4007F52")]
		public int flyingFrameDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4007F53")]
		public int inAirFrameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4007F54")]
		public int inAirFrameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4007F55")]
		public int inAirFrameDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4007F56")]
		public int idleFrameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4007F57")]
		public int idleFrameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4007F58")]
		public int idleFrameDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4007F59")]
		public bool idleFrameLoop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4007F5A")]
		public int swimFrameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4007F5B")]
		public int swimFrameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4007F5C")]
		public int swimFrameDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4007F5D")]
		public int dashingFrameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4007F5E")]
		public int dashingFrameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4007F5F")]
		public int dashingFrameDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4007F60")]
		public bool Minecart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x4007F61")]
		public bool MinecartDirectional;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4007F62")]
		public Vector3 lightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4007F63")]
		public bool emitsLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4007F64")]
		public MountDelegatesData delegations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4007F65")]
		public int playerXOffset;

		[Cpp2IlInjected.Token(Token = "0x6004A9B")]
		[Cpp2IlInjected.Address(RVA = "0x678A08", Offset = "0x678A08", VA = "0x678A08")]
		public MountData()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4002E76")]
	public static int currentShader;

	[Cpp2IlInjected.Token(Token = "0x4002E77")]
	public const int FrameStanding = 0;

	[Cpp2IlInjected.Token(Token = "0x4002E78")]
	public const int FrameRunning = 1;

	[Cpp2IlInjected.Token(Token = "0x4002E79")]
	public const int FrameInAir = 2;

	[Cpp2IlInjected.Token(Token = "0x4002E7A")]
	public const int FrameFlying = 3;

	[Cpp2IlInjected.Token(Token = "0x4002E7B")]
	public const int FrameSwimming = 4;

	[Cpp2IlInjected.Token(Token = "0x4002E7C")]
	public const int FrameDashing = 5;

	[Cpp2IlInjected.Token(Token = "0x4002E7D")]
	public const int DrawBack = 0;

	[Cpp2IlInjected.Token(Token = "0x4002E7E")]
	public const int DrawBackExtra = 1;

	[Cpp2IlInjected.Token(Token = "0x4002E7F")]
	public const int DrawFront = 2;

	[Cpp2IlInjected.Token(Token = "0x4002E80")]
	public const int DrawFrontExtra = 3;

	[Cpp2IlInjected.Token(Token = "0x4002E81")]
	private static MountData[] mounts;

	[Cpp2IlInjected.Token(Token = "0x4002E82")]
	private static Vector2[] scutlixEyePositions;

	[Cpp2IlInjected.Token(Token = "0x4002E83")]
	private static Vector2 scutlixTextureSize;

	[Cpp2IlInjected.Token(Token = "0x4002E84")]
	public const int scutlixBaseDamage = 50;

	[Cpp2IlInjected.Token(Token = "0x4002E85")]
	public static Vector2 drillDiodePoint1;

	[Cpp2IlInjected.Token(Token = "0x4002E86")]
	public static Vector2 drillDiodePoint2;

	[Cpp2IlInjected.Token(Token = "0x4002E87")]
	public static Vector2 drillTextureSize;

	[Cpp2IlInjected.Token(Token = "0x4002E88")]
	public const int drillTextureWidth = 80;

	[Cpp2IlInjected.Token(Token = "0x4002E89")]
	public const float drillRotationChange = (float)Math.PI / 60f;

	[Cpp2IlInjected.Token(Token = "0x4002E8A")]
	public static int drillPickPower;

	[Cpp2IlInjected.Token(Token = "0x4002E8B")]
	public static int drillPickTime;

	[Cpp2IlInjected.Token(Token = "0x4002E8C")]
	public static int amountOfBeamsAtOnce;

	[Cpp2IlInjected.Token(Token = "0x4002E8D")]
	public const float maxDrillLength = 48f;

	[Cpp2IlInjected.Token(Token = "0x4002E8E")]
	private static Vector2 santankTextureSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002E8F")]
	private MountData _data;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002E90")]
	private int _type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002E91")]
	private bool _flipDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002E92")]
	private int _frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002E93")]
	private float _frameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002E94")]
	private int _frameExtra;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002E95")]
	private float _frameExtraCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002E96")]
	private int _frameState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002E97")]
	private int _flyTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002E98")]
	private int _idleTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002E99")]
	private int _idleTimeNext;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002E9A")]
	private float _fatigue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002E9B")]
	private float _fatigueMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4002E9C")]
	private bool _abilityCharging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002E9D")]
	private int _abilityCharge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4002E9E")]
	private int _abilityCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4002E9F")]
	private int _abilityDuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4002EA0")]
	private bool _abilityActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
	[Cpp2IlInjected.Token(Token = "0x4002EA1")]
	private bool _aiming;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
	[Cpp2IlInjected.Token(Token = "0x4002EA2")]
	private bool _shouldSuperCart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4002EA3")]
	public List<DrillDebugDraw> _debugDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4002EA4")]
	private object _mountSpecificData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4002EA5")]
	private bool _active;

	[Cpp2IlInjected.Token(Token = "0x4002EA6")]
	public static float SuperCartRunSpeed;

	[Cpp2IlInjected.Token(Token = "0x4002EA7")]
	public static float SuperCartDashSpeed;

	[Cpp2IlInjected.Token(Token = "0x4002EA8")]
	public static float SuperCartAcceleration;

	[Cpp2IlInjected.Token(Token = "0x4002EA9")]
	public static int SuperCartJumpHeight;

	[Cpp2IlInjected.Token(Token = "0x4002EAA")]
	public static float SuperCartJumpSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4002EAB")]
	private MountDelegatesData _defaultDelegatesData;

	[Cpp2IlInjected.Token(Token = "0x4002EAC")]
	private static DrillMountData DrillSmartCursor_BlocksPlotData;

	[Cpp2IlInjected.Token(Token = "0x4002EAD")]
	private static int DrillSmartCursor_BlocksPlotX;

	[Cpp2IlInjected.Token(Token = "0x4002EAE")]
	private static int DrillSmartCursor_BlocksPlotY;

	[Cpp2IlInjected.Token(Token = "0x4002EAF")]
	private static Utils.TileActionAttempt DrillSmartCursor_BlocksPlotInstance;

	[Cpp2IlInjected.Token(Token = "0x1700053C")]
	public bool Active
	{
		[Cpp2IlInjected.Token(Token = "0x60026AF")]
		[Cpp2IlInjected.Address(RVA = "0xFE4748", Offset = "0xFE4748", VA = "0xFE4748")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700053D")]
	public int Type
	{
		[Cpp2IlInjected.Token(Token = "0x60026B0")]
		[Cpp2IlInjected.Address(RVA = "0xFE4750", Offset = "0xFE4750", VA = "0xFE4750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700053E")]
	public int FlyTime
	{
		[Cpp2IlInjected.Token(Token = "0x60026B1")]
		[Cpp2IlInjected.Address(RVA = "0xFE4758", Offset = "0xFE4758", VA = "0xFE4758")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700053F")]
	public int BuffType
	{
		[Cpp2IlInjected.Token(Token = "0x60026B2")]
		[Cpp2IlInjected.Address(RVA = "0xFE4760", Offset = "0xFE4760", VA = "0xFE4760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000540")]
	public int BodyFrame
	{
		[Cpp2IlInjected.Token(Token = "0x60026B3")]
		[Cpp2IlInjected.Address(RVA = "0xFE476C", Offset = "0xFE476C", VA = "0xFE476C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000541")]
	public int XOffset
	{
		[Cpp2IlInjected.Token(Token = "0x60026B4")]
		[Cpp2IlInjected.Address(RVA = "0xFE4778", Offset = "0xFE4778", VA = "0xFE4778")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000542")]
	public int YOffset
	{
		[Cpp2IlInjected.Token(Token = "0x60026B5")]
		[Cpp2IlInjected.Address(RVA = "0xFE4784", Offset = "0xFE4784", VA = "0xFE4784")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000543")]
	public int PlayerXOFfset
	{
		[Cpp2IlInjected.Token(Token = "0x60026B6")]
		[Cpp2IlInjected.Address(RVA = "0xFE4790", Offset = "0xFE4790", VA = "0xFE4790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000544")]
	public int PlayerOffset
	{
		[Cpp2IlInjected.Token(Token = "0x60026B7")]
		[Cpp2IlInjected.Address(RVA = "0xFE479C", Offset = "0xFE479C", VA = "0xFE479C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000545")]
	public int PlayerOffsetHitbox
	{
		[Cpp2IlInjected.Token(Token = "0x60026B8")]
		[Cpp2IlInjected.Address(RVA = "0xFE47D0", Offset = "0xFE47D0", VA = "0xFE47D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000546")]
	public int PlayerHeadOffset
	{
		[Cpp2IlInjected.Token(Token = "0x60026B9")]
		[Cpp2IlInjected.Address(RVA = "0xFE4810", Offset = "0xFE4810", VA = "0xFE4810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000547")]
	public int HeightBoost
	{
		[Cpp2IlInjected.Token(Token = "0x60026BA")]
		[Cpp2IlInjected.Address(RVA = "0xFE4828", Offset = "0xFE4828", VA = "0xFE4828")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000548")]
	public float RunSpeed
	{
		[Cpp2IlInjected.Token(Token = "0x60026BC")]
		[Cpp2IlInjected.Address(RVA = "0xFE490C", Offset = "0xFE490C", VA = "0xFE490C")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000549")]
	public float DashSpeed
	{
		[Cpp2IlInjected.Token(Token = "0x60026BD")]
		[Cpp2IlInjected.Address(RVA = "0xFE4A8C", Offset = "0xFE4A8C", VA = "0xFE4A8C")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700054A")]
	public float Acceleration
	{
		[Cpp2IlInjected.Token(Token = "0x60026BE")]
		[Cpp2IlInjected.Address(RVA = "0xFE4B24", Offset = "0xFE4B24", VA = "0xFE4B24")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700054B")]
	public float FallDamage
	{
		[Cpp2IlInjected.Token(Token = "0x60026BF")]
		[Cpp2IlInjected.Address(RVA = "0xFE4BBC", Offset = "0xFE4BBC", VA = "0xFE4BBC")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700054C")]
	public bool AutoJump
	{
		[Cpp2IlInjected.Token(Token = "0x60026C2")]
		[Cpp2IlInjected.Address(RVA = "0xFE4E34", Offset = "0xFE4E34", VA = "0xFE4E34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700054D")]
	public bool BlockExtraJumps
	{
		[Cpp2IlInjected.Token(Token = "0x60026C3")]
		[Cpp2IlInjected.Address(RVA = "0xFE4E40", Offset = "0xFE4E40", VA = "0xFE4E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700054E")]
	public bool IsConsideredASlimeMount
	{
		[Cpp2IlInjected.Token(Token = "0x60026C4")]
		[Cpp2IlInjected.Address(RVA = "0xFE4E4C", Offset = "0xFE4E4C", VA = "0xFE4E4C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700054F")]
	public bool Cart
	{
		[Cpp2IlInjected.Token(Token = "0x60026C5")]
		[Cpp2IlInjected.Address(RVA = "0xFE4E70", Offset = "0xFE4E70", VA = "0xFE4E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000550")]
	public bool Directional
	{
		[Cpp2IlInjected.Token(Token = "0x60026C6")]
		[Cpp2IlInjected.Address(RVA = "0xFE4EA0", Offset = "0xFE4EA0", VA = "0xFE4EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000551")]
	public MountDelegatesData Delegations
	{
		[Cpp2IlInjected.Token(Token = "0x60026C7")]
		[Cpp2IlInjected.Address(RVA = "0xFE4EC0", Offset = "0xFE4EC0", VA = "0xFE4EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000552")]
	public Vector2 Origin
	{
		[Cpp2IlInjected.Token(Token = "0x60026C8")]
		[Cpp2IlInjected.Address(RVA = "0xFE4ED8", Offset = "0xFE4ED8", VA = "0xFE4ED8")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000553")]
	public bool AbilityCharging
	{
		[Cpp2IlInjected.Token(Token = "0x60026CB")]
		[Cpp2IlInjected.Address(RVA = "0xFE4FA0", Offset = "0xFE4FA0", VA = "0xFE4FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000554")]
	public bool AbilityActive
	{
		[Cpp2IlInjected.Token(Token = "0x60026CC")]
		[Cpp2IlInjected.Address(RVA = "0xFE4FA8", Offset = "0xFE4FA8", VA = "0xFE4FA8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000555")]
	public float AbilityCharge
	{
		[Cpp2IlInjected.Token(Token = "0x60026CD")]
		[Cpp2IlInjected.Address(RVA = "0xFE4FB0", Offset = "0xFE4FB0", VA = "0xFE4FB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000556")]
	public bool AllowDirectionChange
	{
		[Cpp2IlInjected.Token(Token = "0x60026D5")]
		[Cpp2IlInjected.Address(RVA = "0xFE52F4", Offset = "0xFE52F4", VA = "0xFE52F4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60026A8")]
	[Cpp2IlInjected.Address(RVA = "0xFDD124", Offset = "0xFDD124", VA = "0xFDD124")]
	private static void MeowcartLandingSound(Player Player, Vector2 Position, int Width, int Height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026A9")]
	[Cpp2IlInjected.Address(RVA = "0xFDD180", Offset = "0xFDD180", VA = "0xFDD180")]
	private static void MeowcartBumperSound(Player Player, Vector2 Position, int Width, int Height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026AA")]
	[Cpp2IlInjected.Address(RVA = "0xFDD1DC", Offset = "0xFDD1DC", VA = "0xFDD1DC")]
	public Mount()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026AB")]
	[Cpp2IlInjected.Address(RVA = "0xFDD2C0", Offset = "0xFDD2C0", VA = "0xFDD2C0")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026AC")]
	[Cpp2IlInjected.Address(RVA = "0xFDD300", Offset = "0xFDD300", VA = "0xFDD300")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026AD")]
	[Cpp2IlInjected.Address(RVA = "0xFE4490", Offset = "0xFE4490", VA = "0xFE4490")]
	private static void SetAsHorse(MountData newMount, int buff, Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026AE")]
	[Cpp2IlInjected.Address(RVA = "0xFE41D0", Offset = "0xFE41D0", VA = "0xFE41D0")]
	private static void SetAsMinecart(MountData newMount, int buffToLeft, int buffToRight, Asset<Texture2D> texture, int verticalOffset = 0, int playerVerticalOffset = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026BB")]
	[Cpp2IlInjected.Address(RVA = "0xFE4834", Offset = "0xFE4834", VA = "0xFE4834")]
	public static int GetHeightBoost(int MountType)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60026C0")]
	[Cpp2IlInjected.Address(RVA = "0xFE4BC8", Offset = "0xFE4BC8", VA = "0xFE4BC8")]
	public int JumpHeight(float xVelocity)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60026C1")]
	[Cpp2IlInjected.Address(RVA = "0xFE4D24", Offset = "0xFE4D24", VA = "0xFE4D24")]
	public float JumpSpeed(float xVelocity)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60026C9")]
	[Cpp2IlInjected.Address(RVA = "0xFE4F2C", Offset = "0xFE4F2C", VA = "0xFE4F2C")]
	public bool CanFly()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026CA")]
	[Cpp2IlInjected.Address(RVA = "0xFE4F5C", Offset = "0xFE4F5C", VA = "0xFE4F5C")]
	public bool CanHover()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026CE")]
	[Cpp2IlInjected.Address(RVA = "0xFE4FD0", Offset = "0xFE4FD0", VA = "0xFE4FD0")]
	public IEntitySource GetProjectileSpawnSource(Player mountedPlayer)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60026CF")]
	[Cpp2IlInjected.Address(RVA = "0xFE5048", Offset = "0xFE5048", VA = "0xFE5048")]
	public void StartAbilityCharge(Player mountedPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026D0")]
	[Cpp2IlInjected.Address(RVA = "0xFE51FC", Offset = "0xFE51FC", VA = "0xFE51FC")]
	public void StopAbilityCharge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026D1")]
	[Cpp2IlInjected.Address(RVA = "0xFE522C", Offset = "0xFE522C", VA = "0xFE522C")]
	public bool CheckBuff(int buffID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026D2")]
	[Cpp2IlInjected.Address(RVA = "0xFE5250", Offset = "0xFE5250", VA = "0xFE5250")]
	public void AbilityRecovery()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026D3")]
	[Cpp2IlInjected.Address(RVA = "0xFE52AC", Offset = "0xFE52AC", VA = "0xFE52AC")]
	public void FatigueRecovery()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026D4")]
	[Cpp2IlInjected.Address(RVA = "0xFE52D8", Offset = "0xFE52D8", VA = "0xFE52D8")]
	public bool Flight()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026D6")]
	[Cpp2IlInjected.Address(RVA = "0xFE5328", Offset = "0xFE5328", VA = "0xFE5328")]
	public void UpdateDrill(Player mountedPlayer, bool controlUp, bool controlDown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026D7")]
	[Cpp2IlInjected.Address(RVA = "0xFE5488", Offset = "0xFE5488", VA = "0xFE5488")]
	public void UseDrill(Player mountedPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026D8")]
	[Cpp2IlInjected.Address(RVA = "0xFE67E8", Offset = "0xFE67E8", VA = "0xFE67E8")]
	private static bool DrillSmartCursor_BlocksPlot(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026D9")]
	[Cpp2IlInjected.Address(RVA = "0xFE60D8", Offset = "0xFE60D8", VA = "0xFE60D8")]
	private Point16 DrillSmartCursor_Blocks(Player mountedPlayer, DrillMountData data)
	{
		return default(Point16);
	}

	[Cpp2IlInjected.Token(Token = "0x60026DA")]
	[Cpp2IlInjected.Address(RVA = "0xFE6464", Offset = "0xFE6464", VA = "0xFE6464")]
	private Point16 DrillSmartCursor_Walls(Player mountedPlayer, DrillMountData data)
	{
		return default(Point16);
	}

	[Cpp2IlInjected.Token(Token = "0x60026DB")]
	[Cpp2IlInjected.Address(RVA = "0xFE6984", Offset = "0xFE6984", VA = "0xFE6984")]
	public void UseAbility(Player mountedPlayer, Vector2 mousePosition, bool toggleOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026DC")]
	[Cpp2IlInjected.Address(RVA = "0xFE7810", Offset = "0xFE7810", VA = "0xFE7810")]
	public bool Hover(Player mountedPlayer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026DD")]
	[Cpp2IlInjected.Address(RVA = "0xFE806C", Offset = "0xFE806C", VA = "0xFE806C")]
	private bool DoesHoverIgnoresFatigue()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026DE")]
	[Cpp2IlInjected.Address(RVA = "0xFE80B0", Offset = "0xFE80B0", VA = "0xFE80B0")]
	private float GetWitchBroomTrinketRotation(Player player)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60026DF")]
	[Cpp2IlInjected.Address(RVA = "0xFE83D4", Offset = "0xFE83D4", VA = "0xFE83D4")]
	private Vector2 GetWitchBroomTrinketOriginOffset(Player player)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60026E0")]
	[Cpp2IlInjected.Address(RVA = "0xFE8418", Offset = "0xFE8418", VA = "0xFE8418")]
	public void UpdateFrame(Player mountedPlayer, int state, Vector2 velocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026E1")]
	[Cpp2IlInjected.Address(RVA = "0xFEC4A4", Offset = "0xFEC4A4", VA = "0xFEC4A4")]
	public void TryBeginningFlight(Player mountedPlayer, int state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026E2")]
	[Cpp2IlInjected.Address(RVA = "0xFEC748", Offset = "0xFEC748", VA = "0xFEC748")]
	public int GetIntendedGroundedFrame(Player mountedPlayer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60026E3")]
	[Cpp2IlInjected.Address(RVA = "0xFEC7A4", Offset = "0xFEC7A4", VA = "0xFEC7A4")]
	public void TryLanding(Player mountedPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026E4")]
	[Cpp2IlInjected.Address(RVA = "0xFEC138", Offset = "0xFEC138", VA = "0xFEC138")]
	private void UpdateFrame_GolfCart(Player mountedPlayer, int state, Vector2 velocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026E5")]
	[Cpp2IlInjected.Address(RVA = "0xFED04C", Offset = "0xFED04C", VA = "0xFED04C")]
	private static void EmitGolfCartSmoke(Player mountedPlayer, bool rushing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026E6")]
	[Cpp2IlInjected.Address(RVA = "0xFECDB8", Offset = "0xFECDB8", VA = "0xFECDB8")]
	private static void EmitGolfCartlight(Vector2 worldLocation, int playerDirection)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026E7")]
	[Cpp2IlInjected.Address(RVA = "0xFED37C", Offset = "0xFED37C", VA = "0xFED37C")]
	private static bool ShouldGolfCartEmitLight()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026E8")]
	[Cpp2IlInjected.Address(RVA = "0xFEC9FC", Offset = "0xFEC9FC", VA = "0xFEC9FC")]
	private static void EmitGolfCartWheelDust(Player mountedPlayer, Vector2 legSpot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026E9")]
	[Cpp2IlInjected.Address(RVA = "0xFED384", Offset = "0xFED384", VA = "0xFED384")]
	private void DoGemMinecartEffect(Player mountedPlayer, int dustType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026EA")]
	[Cpp2IlInjected.Address(RVA = "0xFED6C4", Offset = "0xFED6C4", VA = "0xFED6C4")]
	private void DoSteamMinecartEffect(Player mountedPlayer, int dustType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026EB")]
	[Cpp2IlInjected.Address(RVA = "0xFEDA44", Offset = "0xFEDA44", VA = "0xFEDA44")]
	private void DoExhaustMinecartEffect(Player mountedPlayer, int dustType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026EC")]
	[Cpp2IlInjected.Address(RVA = "0xFEDF70", Offset = "0xFEDF70", VA = "0xFEDF70")]
	private void DoConfettiMinecartEffect(Player mountedPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026ED")]
	[Cpp2IlInjected.Address(RVA = "0xFEE530", Offset = "0xFEE530", VA = "0xFEE530")]
	public void UpdateEffects(Player mountedPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026EE")]
	[Cpp2IlInjected.Address(RVA = "0xFF12FC", Offset = "0xFF12FC", VA = "0xFF12FC")]
	private void CastSuperCartLaser(Player mountedPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026EF")]
	[Cpp2IlInjected.Address(RVA = "0xFF21A8", Offset = "0xFF21A8", VA = "0xFF21A8")]
	public static Vector2 GetMinecartMechPoint(Player mountedPlayer, int offX, int offY)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60026F0")]
	[Cpp2IlInjected.Address(RVA = "0xFF2574", Offset = "0xFF2574", VA = "0xFF2574")]
	public void ResetFlightTime(float xVelocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026F1")]
	[Cpp2IlInjected.Address(RVA = "0xFF2634", Offset = "0xFF2634", VA = "0xFF2634")]
	public void CheckMountBuff(Player mountedPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026F2")]
	[Cpp2IlInjected.Address(RVA = "0xFF2180", Offset = "0xFF2180", VA = "0xFF2180")]
	public void ResetHeadPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026F3")]
	[Cpp2IlInjected.Address(RVA = "0xFE74BC", Offset = "0xFE74BC", VA = "0xFE74BC")]
	private Vector2 ClampToDeadZone(Player mountedPlayer, Vector2 position)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60026F4")]
	[Cpp2IlInjected.Address(RVA = "0xFF1918", Offset = "0xFF1918", VA = "0xFF1918")]
	public bool AimAbility(Player mountedPlayer, Vector2 mousePosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026F5")]
	[Cpp2IlInjected.Address(RVA = "0xFF2A44", Offset = "0xFF2A44", VA = "0xFF2A44")]
	public void Draw(ref PlayerDrawSet playerDrawData, int drawType, Player drawPlayer, Vector2 Position, Color drawColor, SpriteEffects playerEffect, float shadow)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026F6")]
	[Cpp2IlInjected.Address(RVA = "0xFF2728", Offset = "0xFF2728", VA = "0xFF2728")]
	public void Dismount(Player mountedPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026F7")]
	[Cpp2IlInjected.Address(RVA = "0xFF662C", Offset = "0xFF662C", VA = "0xFF662C")]
	public void SetMount(int m, Player mountedPlayer, bool faceLeft = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026F8")]
	[Cpp2IlInjected.Address(RVA = "0xFF5268", Offset = "0xFF5268", VA = "0xFF5268")]
	private void DoSpawnDust(Player mountedPlayer, bool isDismounting)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026F9")]
	[Cpp2IlInjected.Address(RVA = "0xFF6CA4", Offset = "0xFF6CA4", VA = "0xFF6CA4")]
	public bool CanMount(int m, Player mountingPlayer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60026FA")]
	[Cpp2IlInjected.Address(RVA = "0xFF6D3C", Offset = "0xFF6D3C", VA = "0xFF6D3C")]
	public bool FindTileHeight(Vector2 position, int maxTilesDown, out float tileHeight)
	{
		return default(bool);
	}
}
