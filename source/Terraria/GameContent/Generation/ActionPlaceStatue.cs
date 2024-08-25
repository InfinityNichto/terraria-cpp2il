using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	[global::Cpp2ILInjected.Token(Token = "0x20008D1")]
	public class ActionPlaceStatue : GenAction
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004595")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC5B0", Offset = "0x7BC5B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenAction), Member = ".ctor", ReturnType = typeof(void))]
		public ActionPlaceStatue(int index = -1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004596")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC5D8", Offset = "0x7BC5D8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008202")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _statueIndex;
	}
}
