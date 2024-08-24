using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020005ED RID: 1517
	[global::Cpp2ILInjected.Token(Token = "0x20008DB")]
	public class ShapeRunner : GenShape
	{
		// Token: 0x06003D3E RID: 15678 RVA: 0x0002CEEE File Offset: 0x0002B0EE
		[global::Cpp2ILInjected.Token(Token = "0x60045B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BFD80", Offset = "0x7BFD80", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = ".ctor", ReturnType = typeof(void))]
		public ShapeRunner(double strength, int steps, Vector2D velocity)
		{
			throw null;
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x0002CEF1 File Offset: 0x0002B0F1
		[global::Cpp2ILInjected.Token(Token = "0x60045B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BFDCC", Offset = "0x7BFDCC", Length = "0x644")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomVector2D", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
		{
			typeof(GenAction),
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2D) }, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public override bool Perform(Point origin, GenAction action)
		{
			throw null;
		}

		// Token: 0x04006BDC RID: 27612
		[global::Cpp2ILInjected.Token(Token = "0x4008217")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private double _startStrength;

		// Token: 0x04006BDD RID: 27613
		[global::Cpp2ILInjected.Token(Token = "0x4008218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _steps;

		// Token: 0x04006BDE RID: 27614
		[global::Cpp2ILInjected.Token(Token = "0x4008219")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Vector2D _startVelocity;
	}
}
