using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020005F8 RID: 1528
	[global::Cpp2ILInjected.Token(Token = "0x20008F1")]
	public class HoneyPatchBiome : MicroBiome
	{
		// Token: 0x06003D9B RID: 15771 RVA: 0x0002D005 File Offset: 0x0002B205
		[global::Cpp2ILInjected.Token(Token = "0x6004622")]
		[global::Cpp2ILInjected.Address(RVA = "0x7CC65C", Offset = "0x7CC65C", Length = "0x814")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Circle), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Scanner), Member = ".ctor", MemberParameters = new object[] { typeof(Ref<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.RadialDither), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetTile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Circle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Blotches), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.ClearTile), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.RectangleMask), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "Output", MemberParameters = new object[] { typeof(ShapeData) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetLiquid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ModShapes.InnerOutline), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ShapeData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.IsEmpty), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "AddProtectedStructure", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 64)]
		public override bool Place(Point origin, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x0002D008 File Offset: 0x0002B208
		[global::Cpp2ILInjected.Token(Token = "0x6004623")]
		[global::Cpp2ILInjected.Address(RVA = "0x7CCE70", Offset = "0x7CCE70", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MicroBiome), Member = ".ctor", ReturnType = typeof(void))]
		public HoneyPatchBiome()
		{
			throw null;
		}
	}
}
