using Cpp2IlInjected;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x2000600")]
public class TerrainPass : GenPass
{
	[Cpp2IlInjected.Token(Token = "0x20009FD")]
	private enum TerrainFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4008D06")]
		Plateau,
		[Cpp2IlInjected.Token(Token = "0x4008D07")]
		Hill,
		[Cpp2IlInjected.Token(Token = "0x4008D08")]
		Dale,
		[Cpp2IlInjected.Token(Token = "0x4008D09")]
		Mountain,
		[Cpp2IlInjected.Token(Token = "0x4008D0A")]
		Valley
	}

	[Cpp2IlInjected.Token(Token = "0x20009FE")]
	[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x385BF4", Offset = "0x385BF4")]
	private class SurfaceHistory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D0B")]
		private readonly double[] _heights;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008D0C")]
		private int _index;

		[Cpp2IlInjected.Token(Token = "0x170008CF")]
		public double Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004F9F")]
			[Cpp2IlInjected.Address(RVA = "0x107CF60", Offset = "0x107CF60", VA = "0x107CF60")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6004FA0")]
			[Cpp2IlInjected.Address(RVA = "0x107CF8C", Offset = "0x107CF8C", VA = "0x107CF8C")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D0")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6004FA1")]
			[Cpp2IlInjected.Address(RVA = "0x107CF54", Offset = "0x107CF54", VA = "0x107CF54")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA2")]
		[Cpp2IlInjected.Address(RVA = "0x107C1B4", Offset = "0x107C1B4", VA = "0x107C1B4")]
		public SurfaceHistory(int size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA3")]
		[Cpp2IlInjected.Address(RVA = "0x107C950", Offset = "0x107C950", VA = "0x107C950")]
		public void Record(double height)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006C03")]
	private uint skyDefinition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006C04")]
	private uint dirtDefinition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006C05")]
	private uint rockDefinition;

	[Cpp2IlInjected.Token(Token = "0x6003DEB")]
	[Cpp2IlInjected.Address(RVA = "0x107B1A8", Offset = "0x107B1A8", VA = "0x107B1A8")]
	public TerrainPass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DEC")]
	[Cpp2IlInjected.Address(RVA = "0x107B228", Offset = "0x107B228", VA = "0x107B228", Slot = "4")]
	protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DED")]
	[Cpp2IlInjected.Address(RVA = "0x107C990", Offset = "0x107C990", VA = "0x107C990")]
	private void FillColumn(int x, double worldSurface, double rockLayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DEE")]
	[Cpp2IlInjected.Address(RVA = "0x107CD48", Offset = "0x107CD48", VA = "0x107CD48")]
	private static void RetargetColumn(int x, double worldSurface)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DEF")]
	[Cpp2IlInjected.Address(RVA = "0x107C224", Offset = "0x107C224", VA = "0x107C224")]
	private static double GenerateWorldSurfaceOffset(TerrainFeatureType featureType)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DF0")]
	[Cpp2IlInjected.Address(RVA = "0x107CBFC", Offset = "0x107CBFC", VA = "0x107CBFC")]
	private static void RetargetSurfaceHistory(SurfaceHistory history, int targetX, double targetHeight)
	{
	}
}
