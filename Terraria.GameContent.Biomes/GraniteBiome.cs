using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005F9")]
public class GraniteBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x20009F9")]
	private struct Magma
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D00")]
		public readonly double Pressure;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D01")]
		public readonly double Resistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008D02")]
		public readonly bool IsActive;

		[Cpp2IlInjected.Token(Token = "0x6004F8C")]
		[Cpp2IlInjected.Address(RVA = "0x39F2A0", Offset = "0x39F2A0", VA = "0x39F2A0")]
		private Magma(double pressure, double resistance, bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8D")]
		[Cpp2IlInjected.Address(RVA = "0x39F2C0", Offset = "0x39F2C0", VA = "0x39F2C0")]
		public Magma ToFlow()
		{
			return default(Magma);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8E")]
		[Cpp2IlInjected.Address(RVA = "0x14627BC", Offset = "0x14627BC", VA = "0x14627BC")]
		public static Magma CreateFlow(double pressure, double resistance = 0.0)
		{
			return default(Magma);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8F")]
		[Cpp2IlInjected.Address(RVA = "0x1462758", Offset = "0x1462758", VA = "0x1462758")]
		public static Magma CreateEmpty(double resistance = 0.0)
		{
			return default(Magma);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006BFC")]
	private const int MAX_MAGMA_ITERATIONS = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BFD")]
	private Magma[,] _sourceMagmaMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BFE")]
	private Magma[,] _targetMagmaMap;

	[Cpp2IlInjected.Token(Token = "0x4006BFF")]
	private static Vector2D[] _normalisedVectors;

	[Cpp2IlInjected.Token(Token = "0x6003DC3")]
	[Cpp2IlInjected.Address(RVA = "0x1460BE0", Offset = "0x1460BE0", VA = "0x1460BE0")]
	public static bool CanPlace(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DC4")]
	[Cpp2IlInjected.Address(RVA = "0x1460D10", Offset = "0x1460D10", VA = "0x1460D10", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DC5")]
	[Cpp2IlInjected.Address(RVA = "0x1460EB8", Offset = "0x1460EB8", VA = "0x1460EB8")]
	private void BuildMagmaMap(Point tileOrigin)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DC6")]
	[Cpp2IlInjected.Address(RVA = "0x1461098", Offset = "0x1461098", VA = "0x1461098")]
	private void SimulatePressure(out Rectangle effectedMapArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DC7")]
	[Cpp2IlInjected.Address(RVA = "0x1462800", Offset = "0x1462800", VA = "0x1462800")]
	private bool ShouldUseLava(Point tileOrigin)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DC8")]
	[Cpp2IlInjected.Address(RVA = "0x1461870", Offset = "0x1461870", VA = "0x1461870")]
	private void PlaceGranite(Point tileOrigin, Rectangle magmaMapArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DC9")]
	[Cpp2IlInjected.Address(RVA = "0x1461D64", Offset = "0x1461D64", VA = "0x1461D64")]
	private void CleanupTiles(Point tileOrigin, Rectangle magmaMapArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DCA")]
	[Cpp2IlInjected.Address(RVA = "0x14621A0", Offset = "0x14621A0", VA = "0x14621A0")]
	private void PlaceDecorations(Point tileOrigin, Rectangle magmaMapArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DCB")]
	[Cpp2IlInjected.Address(RVA = "0x1462A48", Offset = "0x1462A48", VA = "0x1462A48")]
	public GraniteBiome()
	{
	}
}
