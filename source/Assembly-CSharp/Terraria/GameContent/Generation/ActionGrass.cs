using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020005E3 RID: 1507
	[global::Cpp2ILInjected.Token(Token = "0x20008D0")]
	public class ActionGrass : GenAction
	{
		// Token: 0x06003D21 RID: 15649 RVA: 0x0002CEA3 File Offset: 0x0002B0A3
		[global::Cpp2ILInjected.Token(Token = "0x6004593")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC384", Offset = "0x7BC384", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "SelectRandom", MemberTypeParameters = new object[] { typeof(ushort) }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(ushort[])
		}, ReturnType = "T")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = "UnitApply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x0002CEA6 File Offset: 0x0002B0A6
		[global::Cpp2ILInjected.Token(Token = "0x6004594")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC5A8", Offset = "0x7BC5A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = ".ctor", ReturnType = typeof(void))]
		public ActionGrass()
		{
			throw null;
		}
	}
}
