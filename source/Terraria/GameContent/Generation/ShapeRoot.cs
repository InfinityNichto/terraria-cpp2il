using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	[global::Cpp2ILInjected.Token(Token = "0x20008DA")]
	public class ShapeRoot : GenShape
	{
		[global::Cpp2ILInjected.Token(Token = "0x60045AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BF9B4", Offset = "0x7BF9B4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = ".ctor", ReturnType = typeof(void))]
		public ShapeRoot(double angle, double distance = 10.0, double startingSize = 4.0, double endingSize = 1.0)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BF9F4", Offset = "0x7BF9F4", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRoot), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Clamp", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T", "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
		{
			typeof(GenAction),
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool DoRoot(Point origin, GenAction action, double angle, double distance, double startingSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BFD74", Offset = "0x7BFD74", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeRoot), Member = "DoRoot", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(bool))]
		public override bool Perform(Point origin, GenAction action)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008213")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private double _angle;

		[global::Cpp2ILInjected.Token(Token = "0x4008214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private double _startingSize;

		[global::Cpp2ILInjected.Token(Token = "0x4008215")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private double _endingSize;

		[global::Cpp2ILInjected.Token(Token = "0x4008216")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private double _distance;
	}
}
