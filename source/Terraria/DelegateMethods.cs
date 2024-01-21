using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Enums;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200032A")]
public static class DelegateMethods
{
	[Cpp2IlInjected.Token(Token = "0x2000852")]
	public static class CharacterPreview
	{
		[Cpp2IlInjected.Token(Token = "0x60049FF")]
		[Cpp2IlInjected.Address(RVA = "0x1236E88", Offset = "0x1236E88", VA = "0x1236E88")]
		public static void EtsyPet(Projectile proj, bool walking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A00")]
		[Cpp2IlInjected.Address(RVA = "0x123707C", Offset = "0x123707C", VA = "0x123707C")]
		public static void CompanionCubePet(Projectile proj, bool walking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A01")]
		[Cpp2IlInjected.Address(RVA = "0x1237238", Offset = "0x1237238", VA = "0x1237238")]
		public static void BerniePet(Projectile proj, bool walking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A02")]
		[Cpp2IlInjected.Address(RVA = "0x1237250", Offset = "0x1237250", VA = "0x1237250")]
		public static void SlimePet(Projectile proj, bool walking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A03")]
		[Cpp2IlInjected.Address(RVA = "0x1237388", Offset = "0x1237388", VA = "0x1237388")]
		public static void WormPet(Projectile proj, bool walking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A04")]
		[Cpp2IlInjected.Address(RVA = "0x12376D0", Offset = "0x12376D0", VA = "0x12376D0")]
		public static void FloatAndSpinWhenWalking(Projectile proj, bool walking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A05")]
		[Cpp2IlInjected.Address(RVA = "0x12377A0", Offset = "0x12377A0", VA = "0x12377A0")]
		public static void FloatAndRotateForwardWhenWalking(Projectile proj, bool walking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A06")]
		[Cpp2IlInjected.Address(RVA = "0x1236F70", Offset = "0x1236F70", VA = "0x1236F70")]
		public static void Float(Projectile proj, bool walking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A07")]
		[Cpp2IlInjected.Address(RVA = "0x12377D8", Offset = "0x12377D8", VA = "0x12377D8")]
		public static void RotateForwardWhenWalking(Projectile proj, bool walking)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000853")]
	public static class Mount
	{
		[Cpp2IlInjected.Token(Token = "0x6004A08")]
		[Cpp2IlInjected.Address(RVA = "0x131F938", Offset = "0x131F938", VA = "0x131F938")]
		public static bool NoHandPosition(Player player, out Vector2? position)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A09")]
		[Cpp2IlInjected.Address(RVA = "0x131F950", Offset = "0x131F950", VA = "0x131F950")]
		public static bool WolfMouthPosition(Player player, out Vector2? position)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000854")]
	public static class Minecart
	{
		[Cpp2IlInjected.Token(Token = "0x4007EC2")]
		public static Vector2 rotationOrigin;

		[Cpp2IlInjected.Token(Token = "0x4007EC3")]
		public static float rotation;

		[Cpp2IlInjected.Token(Token = "0x6004A0A")]
		[Cpp2IlInjected.Address(RVA = "0x12377F8", Offset = "0x12377F8", VA = "0x12377F8")]
		public static void Sparks(Vector2 dustPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A0B")]
		[Cpp2IlInjected.Address(RVA = "0x1237C94", Offset = "0x1237C94", VA = "0x1237C94")]
		public static void JumpingSound(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A0C")]
		[Cpp2IlInjected.Address(RVA = "0x1237C98", Offset = "0x1237C98", VA = "0x1237C98")]
		public static void LandingSound(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A0D")]
		[Cpp2IlInjected.Address(RVA = "0x1237D50", Offset = "0x1237D50", VA = "0x1237D50")]
		public static void BumperSound(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A0E")]
		[Cpp2IlInjected.Address(RVA = "0x1237E08", Offset = "0x1237E08", VA = "0x1237E08")]
		public static void SpawnFartCloud(Player Player, Vector2 Position, int Width, int Height, bool useDelay = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A0F")]
		[Cpp2IlInjected.Address(RVA = "0x1238AD4", Offset = "0x1238AD4", VA = "0x1238AD4")]
		public static void JumpingSoundFart(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A10")]
		[Cpp2IlInjected.Address(RVA = "0x1238BB8", Offset = "0x1238BB8", VA = "0x1238BB8")]
		public static void LandingSoundFart(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A11")]
		[Cpp2IlInjected.Address(RVA = "0x1238CC0", Offset = "0x1238CC0", VA = "0x1238CC0")]
		public static void BumperSoundFart(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A12")]
		[Cpp2IlInjected.Address(RVA = "0x1238DC8", Offset = "0x1238DC8", VA = "0x1238DC8")]
		public static void SparksFart(Vector2 dustPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A13")]
		[Cpp2IlInjected.Address(RVA = "0x12392DC", Offset = "0x12392DC", VA = "0x12392DC")]
		public static void SparksTerraFart(Vector2 dustPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A14")]
		[Cpp2IlInjected.Address(RVA = "0x12398E0", Offset = "0x12398E0", VA = "0x12398E0")]
		public static void SparksMech(Vector2 dustPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A15")]
		[Cpp2IlInjected.Address(RVA = "0x1239D7C", Offset = "0x1239D7C", VA = "0x1239D7C")]
		public static void SparksMeow(Vector2 dustPosition)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4002CB9")]
	public static Vector3 v3_1;

	[Cpp2IlInjected.Token(Token = "0x4002CBA")]
	public static Vector2 v2_1;

	[Cpp2IlInjected.Token(Token = "0x4002CBB")]
	public static float f_1;

	[Cpp2IlInjected.Token(Token = "0x4002CBC")]
	public static Color c_1;

	[Cpp2IlInjected.Token(Token = "0x4002CBD")]
	public static int i_1;

	[Cpp2IlInjected.Token(Token = "0x4002CBE")]
	public static bool CheckResultOut;

	[Cpp2IlInjected.Token(Token = "0x4002CBF")]
	public static TileCuttingContext tilecut_0;

	[Cpp2IlInjected.Token(Token = "0x4002CC0")]
	public static bool[] tileCutIgnore;

	[Cpp2IlInjected.Token(Token = "0x4002CC1")]
	public static Utils.TileActionAttempt CastLight;

	[Cpp2IlInjected.Token(Token = "0x4002CC2")]
	public static Utils.TileActionAttempt CastLightOpen;

	[Cpp2IlInjected.Token(Token = "0x4002CC3")]
	public static Utils.TileActionAttempt SearchAvoidedByNPCs;

	[Cpp2IlInjected.Token(Token = "0x60025F0")]
	[Cpp2IlInjected.Address(RVA = "0x1232024", Offset = "0x1232024", VA = "0x1232024")]
	public static Color ColorLerp_BlackToWhite(float percent)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F1")]
	[Cpp2IlInjected.Address(RVA = "0x12320B0", Offset = "0x12320B0", VA = "0x12320B0")]
	public static Color ColorLerp_HSL_H(float percent)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F2")]
	[Cpp2IlInjected.Address(RVA = "0x1232144", Offset = "0x1232144", VA = "0x1232144")]
	public static Color ColorLerp_HSL_S(float percent)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F3")]
	[Cpp2IlInjected.Address(RVA = "0x1232220", Offset = "0x1232220", VA = "0x1232220")]
	public static Color ColorLerp_HSL_L(float percent)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F4")]
	[Cpp2IlInjected.Address(RVA = "0x1232314", Offset = "0x1232314", VA = "0x1232314")]
	public static Color ColorLerp_HSL_O(float percent)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F5")]
	[Cpp2IlInjected.Address(RVA = "0x1232444", Offset = "0x1232444", VA = "0x1232444")]
	public static bool SpreadDirt(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F6")]
	[Cpp2IlInjected.Address(RVA = "0x1233104", Offset = "0x1233104", VA = "0x1233104")]
	public static bool SpreadWater(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F7")]
	[Cpp2IlInjected.Address(RVA = "0x12334C8", Offset = "0x12334C8", VA = "0x12334C8")]
	public static bool SpreadHoney(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F8")]
	[Cpp2IlInjected.Address(RVA = "0x1233838", Offset = "0x1233838", VA = "0x1233838")]
	public static bool SpreadLava(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025F9")]
	[Cpp2IlInjected.Address(RVA = "0x1233B78", Offset = "0x1233B78", VA = "0x1233B78")]
	public static bool SpreadDry(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025FA")]
	[Cpp2IlInjected.Address(RVA = "0x1233EB8", Offset = "0x1233EB8", VA = "0x1233EB8")]
	public static bool SpreadTest(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025FB")]
	[Cpp2IlInjected.Address(RVA = "0x1233FD8", Offset = "0x1233FD8", VA = "0x1233FD8")]
	public static bool TestDust(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025FC")]
	[Cpp2IlInjected.Address(RVA = "0x1234218", Offset = "0x1234218", VA = "0x1234218")]
	public static bool CastLightFunc(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025FD")]
	[Cpp2IlInjected.Address(RVA = "0x12343FC", Offset = "0x12343FC", VA = "0x12343FC")]
	public static bool CastLightOpenFunc(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025FE")]
	[Cpp2IlInjected.Address(RVA = "0x12346FC", Offset = "0x12346FC", VA = "0x12346FC")]
	public static bool CheckStopForSolids(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60025FF")]
	[Cpp2IlInjected.Address(RVA = "0x123499C", Offset = "0x123499C", VA = "0x123499C")]
	public static bool CastLightOpen_StopForSolids_ScaleWithDistance(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002600")]
	[Cpp2IlInjected.Address(RVA = "0x1234DC0", Offset = "0x1234DC0", VA = "0x1234DC0")]
	public static bool CastLightOpen_StopForSolids(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002601")]
	[Cpp2IlInjected.Address(RVA = "0x12350E8", Offset = "0x12350E8", VA = "0x12350E8")]
	public static bool SpreadLightOpen_StopForSolids(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002602")]
	[Cpp2IlInjected.Address(RVA = "0x1235448", Offset = "0x1235448", VA = "0x1235448")]
	public static bool EmitGolfCartDust_StopForSolids(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002603")]
	[Cpp2IlInjected.Address(RVA = "0x1235820", Offset = "0x1235820", VA = "0x1235820")]
	public static bool NotDoorStand(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002604")]
	[Cpp2IlInjected.Address(RVA = "0x1235A00", Offset = "0x1235A00", VA = "0x1235A00")]
	public static bool CutTiles(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002605")]
	[Cpp2IlInjected.Address(RVA = "0x1235D1C", Offset = "0x1235D1C", VA = "0x1235D1C")]
	public static bool SearchAvoidedByNPCsImp(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002606")]
	[Cpp2IlInjected.Address(RVA = "0x1235ED8", Offset = "0x1235ED8", VA = "0x1235ED8")]
	public static void RainbowLaserDraw(int stage, out float distCovered, out Rectangle frame, out Vector2 origin, out Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002607")]
	[Cpp2IlInjected.Address(RVA = "0x12362C0", Offset = "0x12362C0", VA = "0x12362C0")]
	public static void TurretLaserDraw(int stage, out float distCovered, out Rectangle frame, out Vector2 origin, out Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002608")]
	[Cpp2IlInjected.Address(RVA = "0x1236704", Offset = "0x1236704", VA = "0x1236704")]
	public static void LightningLaserDraw(int stage, out float distCovered, out Rectangle frame, out Vector2 origin, out Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002609")]
	[Cpp2IlInjected.Address(RVA = "0x1236B44", Offset = "0x1236B44", VA = "0x1236B44")]
	public static int CompareYReverse(Point a, Point b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600260A")]
	[Cpp2IlInjected.Address(RVA = "0x1236B68", Offset = "0x1236B68", VA = "0x1236B68")]
	public static int CompareDrawSorterByYScale(DrawData a, DrawData b)
	{
		return default(int);
	}
}
