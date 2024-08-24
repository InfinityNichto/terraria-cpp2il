using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020005EF RID: 1519
	[global::Cpp2ILInjected.Token(Token = "0x20008E1")]
	public class CampsiteBiome : MicroBiome
	{
		// Token: 0x06003D52 RID: 15698 RVA: 0x0002CF2A File Offset: 0x0002B12A
		[global::Cpp2ILInjected.Token(Token = "0x60045C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1F38", Offset = "0x7C1F38", Length = "0xF30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Circle), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Scanner), Member = ".ctor", MemberParameters = new object[] { typeof(Ref<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Slime), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Blotches), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "Output", MemberParameters = new object[] { typeof(ShapeData) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Offset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.OnlyTiles), Member = ".ctor", MemberParameters = new object[] { typeof(ushort[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetTile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.OnlyWalls), Member = ".ctor", MemberParameters = new object[] { typeof(ushort[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.PlaceWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ModShapes.All), Member = ".ctor", MemberParameters = new object[] { typeof(ShapeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.ClearTile), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetLiquid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetFrames), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Down), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches), Member = "Chain", MemberParameters = new object[]
		{
			typeof(GenSearch),
			typeof(GenCondition[])
		}, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "AddProtectedStructure", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 93)]
		public override bool Place(Point origin, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x0002CF2D File Offset: 0x0002B12D
		[global::Cpp2ILInjected.Token(Token = "0x60045C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C2E68", Offset = "0x7C2E68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MicroBiome), Member = ".ctor", ReturnType = typeof(void))]
		public CampsiteBiome()
		{
			throw null;
		}
	}
}
