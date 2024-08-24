using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000608 RID: 1544
	[global::Cpp2ILInjected.Token(Token = "0x200090C")]
	public class GraniteHouseBuilder : HouseBuilder
	{
		// Token: 0x06003DE2 RID: 15842 RVA: 0x0002D0DA File Offset: 0x0002B2DA
		[global::Cpp2ILInjected.Token(Token = "0x6004684")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DBD34", Offset = "0x7DBD34", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "CreateBuilder", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(HouseBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HouseType),
			typeof(IEnumerable<Rectangle>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GraniteHouseBuilder(IEnumerable<Rectangle> rooms)
		{
			throw null;
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x0002D0DD File Offset: 0x0002B2DD
		[global::Cpp2ILInjected.Token(Token = "0x6004685")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DBDDC", Offset = "0x7DBDDC", Length = "0x6D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Dither), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Blotches), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.OnlyTiles), Member = ".ctor", MemberParameters = new object[] { typeof(ushort[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetTileKeepWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Modifiers.Offset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActionStalagtite), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.PlaceWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		protected override void AgeRoom(Rectangle room)
		{
			throw null;
		}
	}
}
