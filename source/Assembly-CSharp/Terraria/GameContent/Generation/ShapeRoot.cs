using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020005EC RID: 1516
	[global::Cpp2ILInjected.Token(Token = "0x20008DA")]
	public class ShapeRoot : GenShape
	{
		// Token: 0x06003D3B RID: 15675 RVA: 0x0002CEE5 File Offset: 0x0002B0E5
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

		// Token: 0x06003D3C RID: 15676 RVA: 0x0002CEE8 File Offset: 0x0002B0E8
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

		// Token: 0x06003D3D RID: 15677 RVA: 0x0002CEEB File Offset: 0x0002B0EB
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

		// Token: 0x04006BD8 RID: 27608
		[global::Cpp2ILInjected.Token(Token = "0x4008213")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private double _angle;

		// Token: 0x04006BD9 RID: 27609
		[global::Cpp2ILInjected.Token(Token = "0x4008214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private double _startingSize;

		// Token: 0x04006BDA RID: 27610
		[global::Cpp2ILInjected.Token(Token = "0x4008215")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private double _endingSize;

		// Token: 0x04006BDB RID: 27611
		[global::Cpp2ILInjected.Token(Token = "0x4008216")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private double _distance;
	}
}
