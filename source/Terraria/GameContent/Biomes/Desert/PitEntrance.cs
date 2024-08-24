using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000604 RID: 1540
	[global::Cpp2ILInjected.Token(Token = "0x2000907")]
	public static class PitEntrance
	{
		// Token: 0x06003DD6 RID: 15830 RVA: 0x0002D0B6 File Offset: 0x0002B2B6
		[global::Cpp2ILInjected.Token(Token = "0x6004678")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DA494", Offset = "0x7DA494", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PitEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Place(DesertDescription description)
		{
			throw null;
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x0002D0B9 File Offset: 0x0002B2B9
		[global::Cpp2ILInjected.Token(Token = "0x6004679")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DA54C", Offset = "0x7DA54C", Length = "0x488")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PitEntrance), Member = "Place", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Clamp", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T", "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PitEntrance), Member = "SmootherStep", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SquareWallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void PlaceAt(DesertDescription description, Point position, int holeRadius)
		{
			throw null;
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		[global::Cpp2ILInjected.Token(Token = "0x600467A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DA9D4", Offset = "0x7DA9D4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PitEntrance), Member = "SmootherStep", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(double))]
		private static double GetHoleRadiusScaleAt(double yProgress)
		{
			throw null;
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x0002D0BF File Offset: 0x0002B2BF
		[global::Cpp2ILInjected.Token(Token = "0x600467B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DAA28", Offset = "0x7DAA28", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PitEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PitEntrance), Member = "GetHoleRadiusScaleAt", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Clamp", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T", "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static double SmootherStep(double delta)
		{
			throw null;
		}
	}
}
