using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Physics;

namespace Terraria.GameContent.Golf;

[Cpp2IlInjected.Token(Token = "0x200067B")]
public static class GolfHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000A61")]
	public struct ClubProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E65")]
		public readonly Vector2 MinimumStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E66")]
		public readonly Vector2 MaximumStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E67")]
		public readonly float RoughLandResistance;

		[Cpp2IlInjected.Token(Token = "0x60050E8")]
		[Cpp2IlInjected.Address(RVA = "0x39A194", Offset = "0x39A194", VA = "0x39A194")]
		public ClubProperties(Vector2 minimumStrength, Vector2 maximumStrength, float roughLandResistance)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A62")]
	public struct ShotStrength
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E68")]
		public readonly float AbsoluteStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008E69")]
		public readonly float RelativeStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E6A")]
		public readonly float RoughLandResistance;

		[Cpp2IlInjected.Token(Token = "0x60050E9")]
		[Cpp2IlInjected.Address(RVA = "0x39A1B4", Offset = "0x39A1B4", VA = "0x39A1B4")]
		public ShotStrength(float absoluteStrength, float relativeStrength, float roughLandResistance)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A63")]
	public class ContactListener : IBallContactListener
	{
		[Cpp2IlInjected.Token(Token = "0x60050EA")]
		[Cpp2IlInjected.Address(RVA = "0xE6DA90", Offset = "0xE6DA90", VA = "0xE6DA90", Slot = "4")]
		public void OnCollision(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref BallCollisionEvent collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050EB")]
		[Cpp2IlInjected.Address(RVA = "0xE6E12C", Offset = "0xE6E12C", VA = "0xE6E12C")]
		public void PutBallInCup(Projectile proj, BallCollisionEvent collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050EC")]
		[Cpp2IlInjected.Address(RVA = "0xE6E738", Offset = "0xE6E738", VA = "0xE6E738")]
		public static void PutBallInCup_TextAndEffects(Point hitLocation, int plr, int numberOfHits, int projid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050ED")]
		[Cpp2IlInjected.Address(RVA = "0xE6FAEC", Offset = "0xE6FAEC", VA = "0xE6FAEC", Slot = "5")]
		public void OnPassThrough(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref float angularVelocity, ref BallPassThroughEvent collision)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050EE")]
		[Cpp2IlInjected.Address(RVA = "0xE6FD04", Offset = "0xE6FD04", VA = "0xE6FD04")]
		public static void EmitGolfballExplosion_Old(Vector2 Center)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050EF")]
		[Cpp2IlInjected.Address(RVA = "0xE6EDB4", Offset = "0xE6EDB4", VA = "0xE6EDB4")]
		public static void EmitGolfballExplosion(Vector2 Center)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050F0")]
		[Cpp2IlInjected.Address(RVA = "0xE6FD08", Offset = "0xE6FD08", VA = "0xE6FD08")]
		private static void EmitGolfballExplosion_v1(Vector2 Center)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050F1")]
		[Cpp2IlInjected.Address(RVA = "0xE6DA88", Offset = "0xE6DA88", VA = "0xE6DA88")]
		public ContactListener()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006D9B")]
	private static FancyGolfPredictionLine _predictionLine;

	[Cpp2IlInjected.Token(Token = "0x4006D9C")]
	public const int PointsNeededForLevel1 = 500;

	[Cpp2IlInjected.Token(Token = "0x4006D9D")]
	public const int PointsNeededForLevel2 = 1000;

	[Cpp2IlInjected.Token(Token = "0x4006D9E")]
	public const int PointsNeededForLevel3 = 2000;

	[Cpp2IlInjected.Token(Token = "0x4006D9F")]
	public static readonly PhysicsProperties PhysicsProperties;

	[Cpp2IlInjected.Token(Token = "0x4006DA0")]
	public static readonly ContactListener Listener;

	[Cpp2IlInjected.Token(Token = "0x6004162")]
	[Cpp2IlInjected.Address(RVA = "0xE6B450", Offset = "0xE6B450", VA = "0xE6B450")]
	public static BallStepResult StepGolfBall(Entity entity, ref float angularVelocity)
	{
		return default(BallStepResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6004163")]
	[Cpp2IlInjected.Address(RVA = "0xE6C430", Offset = "0xE6C430", VA = "0xE6C430")]
	public static Vector2 FindVectorOnOval(Vector2 vector, Vector2 radius)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6004164")]
	[Cpp2IlInjected.Address(RVA = "0xE6C628", Offset = "0xE6C628", VA = "0xE6C628")]
	public static ShotStrength CalculateShotStrength(Vector2 shotVector, ClubProperties clubProperties)
	{
		return default(ShotStrength);
	}

	[Cpp2IlInjected.Token(Token = "0x6004165")]
	[Cpp2IlInjected.Address(RVA = "0xE6C82C", Offset = "0xE6C82C", VA = "0xE6C82C")]
	public static bool IsPlayerHoldingClub(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004166")]
	[Cpp2IlInjected.Address(RVA = "0xE6C8A8", Offset = "0xE6C8A8", VA = "0xE6C8A8")]
	public static ShotStrength CalculateShotStrength(Projectile golfHelper, Entity golfBall)
	{
		return default(ShotStrength);
	}

	[Cpp2IlInjected.Token(Token = "0x6004167")]
	[Cpp2IlInjected.Address(RVA = "0xE6CA8C", Offset = "0xE6CA8C", VA = "0xE6CA8C")]
	public static ClubProperties GetClubPropertiesFromGolfHelper(Projectile golfHelper)
	{
		return default(ClubProperties);
	}

	[Cpp2IlInjected.Token(Token = "0x6004168")]
	[Cpp2IlInjected.Address(RVA = "0xE6CB60", Offset = "0xE6CB60", VA = "0xE6CB60")]
	public static ClubProperties GetClubProperties(short itemId)
	{
		return default(ClubProperties);
	}

	[Cpp2IlInjected.Token(Token = "0x6004169")]
	[Cpp2IlInjected.Address(RVA = "0xE6CF0C", Offset = "0xE6CF0C", VA = "0xE6CF0C")]
	public static Projectile FindHelperFromGolfBall(Projectile golfBall)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600416A")]
	[Cpp2IlInjected.Address(RVA = "0xE6D00C", Offset = "0xE6D00C", VA = "0xE6D00C")]
	public static Projectile FindGolfBallForHelper(Projectile golfHelper)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600416B")]
	[Cpp2IlInjected.Address(RVA = "0xE6D530", Offset = "0xE6D530", VA = "0xE6D530")]
	public static bool IsGolfBallResting(Projectile golfBall)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600416C")]
	[Cpp2IlInjected.Address(RVA = "0xE6D618", Offset = "0xE6D618", VA = "0xE6D618")]
	public static bool IsGolfShotValid(Entity golfBall, Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600416D")]
	[Cpp2IlInjected.Address(RVA = "0xE6D264", Offset = "0xE6D264", VA = "0xE6D264")]
	public static bool ValidateShot(Entity golfBall, Player player, ref Vector2 shotVector)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600416E")]
	[Cpp2IlInjected.Address(RVA = "0xE6B144", Offset = "0xE6B144", VA = "0xE6B144")]
	public static void HitGolfBall(Entity entity, Vector2 velocity, float roughLandResistance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600416F")]
	[Cpp2IlInjected.Address(RVA = "0xE6D84C", Offset = "0xE6D84C", VA = "0xE6D84C")]
	public static void DrawPredictionLine(Entity golfBall, Vector2 impactVelocity, float chargeProgress, float roughLandResistance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004170")]
	[Cpp2IlInjected.Address(RVA = "0xE6D9D0", Offset = "0xE6D9D0", VA = "0xE6D9D0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x396874", Offset = "0x396874")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x396874", Offset = "0x396874")]
	public static void UpdateDebugDraw(Vector2 position)
	{
	}
}
