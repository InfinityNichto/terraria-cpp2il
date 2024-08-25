using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Physics;

namespace Terraria.GameContent.Golf
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A0A")]
	public class GolfState
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004BD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1C08", Offset = "0x8B1C08", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void UpdateScoreTime()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1C20", Offset = "0x8B1C20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(BallCollisionEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void ResetScoreTime()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1C28", Offset = "0x8B1C28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Spawn", MemberParameters = new object[] { typeof(PlayerSpawnContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(BallCollisionEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void SetScoreTime()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700086D")]
		public float ScoreAdjustment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004BD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B1C34", Offset = "0x8B1C34", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700086E")]
		public bool ShouldScoreHole
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004BD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B1C48", Offset = "0x8B1C48", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(BallCollisionEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700086F")]
		public bool IsTrackingBall
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004BD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B1C5C", Offset = "0x8B1C5C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "IsPlayerSafe", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "GetLastHitBall", ReturnType = typeof(Projectile))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000870")]
		public bool ShouldCameraTrackBallLastKnownLocation
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004BD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B1D84", Offset = "0x8B1D84", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "IsPlayerSafe", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "GetLastHitBall", ReturnType = typeof(Projectile))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1E2C", Offset = "0x8B1E2C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Vector2? GetLastBallLocation()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1E3C", Offset = "0x8B1E3C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void WorldClear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1E50", Offset = "0x8B1E50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<>c", Member = "<Initialize>b__1845_1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void CancelBallTracking()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1E58", Offset = "0x8B1E58", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "HitGolfBall", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfBallTrackRecord), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfBallTrackRecord), Member = "RecordHit", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void RecordSwing(Projectile golfBall)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1F4C", Offset = "0x8B1F4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int GetGolfBallId(Projectile golfBall)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1C80", Offset = "0x8B1C80", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_GolfBallIndicator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMapIcons_LastGolfballHit", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(float),
			typeof(float),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "get_IsTrackingBall", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "get_ShouldCameraTrackBallLastKnownLocation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "RecordBallInfo", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "ResetGolfBall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Projectile GetLastHitBall()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1F54", Offset = "0x8B1F54", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "GetLastHitBall", ReturnType = typeof(Projectile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_HeldItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsAGolfingItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B2088", Offset = "0x8B2088", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(BallCollisionEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "GetLastHitBall", ReturnType = typeof(Projectile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void RecordBallInfo(Projectile golfBall)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B2170", Offset = "0x8B2170", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(BallCollisionEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfBallTrackRecord), Member = "RecordHit", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		public void LandBall(Projectile golfBall)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B2190", Offset = "0x8B2190", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(BallCollisionEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfBallTrackRecord), Member = "GetTrackInfo", MemberParameters = new object[]
		{
			typeof(ref double),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		public int GetGolfBallScore(Projectile golfBall)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B2230", Offset = "0x8B2230", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_OwnerOnlyCode", MemberParameters = new object[]
		{
			typeof(ref Player.ItemCheckContext),
			typeof(Item),
			typeof(int),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "GetLastHitBall", ReturnType = typeof(Projectile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void ResetGolfBall()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B2388", Offset = "0x8B2388", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<>c", Member = "<Initialize>b__1845_0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GolfState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400860C")]
		private const int BALL_RETURN_PENALTY = 1;

		[global::Cpp2ILInjected.Token(Token = "0x400860D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int golfScoreTime;

		[global::Cpp2ILInjected.Token(Token = "0x400860E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int golfScoreTimeMax;

		[global::Cpp2ILInjected.Token(Token = "0x400860F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int golfScoreDelay;

		[global::Cpp2ILInjected.Token(Token = "0x4008610")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private double _lastRecordedBallTime;

		[global::Cpp2ILInjected.Token(Token = "0x4008611")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Vector2? _lastRecordedBallLocation;

		[global::Cpp2ILInjected.Token(Token = "0x4008612")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool _waitingForBallToSettle;

		[global::Cpp2ILInjected.Token(Token = "0x4008613")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Vector2 _lastSwingPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4008614")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Projectile _lastHitGolfBall;

		[global::Cpp2ILInjected.Token(Token = "0x4008615")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _lastRecordedSwingCount;

		[global::Cpp2ILInjected.Token(Token = "0x4008616")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private GolfBallTrackRecord[] _hitRecords;
	}
}
