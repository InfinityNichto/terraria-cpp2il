using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000362 RID: 866
	[global::Cpp2ILInjected.Token(Token = "0x20004D9")]
	public abstract class GenShape : GenBase
	{
		// Token: 0x06002C4B RID: 11339
		[global::Cpp2ILInjected.Token(Token = "0x600303E")]
		public abstract bool Perform(Point origin, GenAction action);

		// Token: 0x06002C4C RID: 11340 RVA: 0x00029F0C File Offset: 0x0002810C
		[global::Cpp2ILInjected.Token(Token = "0x600303F")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F8854", Offset = "0x12F8854", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ModShapes.All), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ModShapes.OuterOutline), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ModShapes.InnerOutline), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Circle), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.HalfCircle), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Slime), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Rectangle), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.Shapes.Tail.<>c__DisplayClass3_0", Member = "<Perform>b__0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Mound), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Generation.ShapeBranch.<>c__DisplayClass5_0", Member = "<PerformSegment>b__0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeFloodFill), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRoot), Member = "DoRoot", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected bool UnitApply(GenAction action, Point origin, int x, int y, params object[] args)
		{
			throw null;
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x00029F0F File Offset: 0x0002810F
		[global::Cpp2ILInjected.Token(Token = "0x6003040")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9B8C", Offset = "0x12F9B8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public GenShape Output(ShapeData outputData)
		{
			throw null;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x00029F12 File Offset: 0x00028112
		[global::Cpp2ILInjected.Token(Token = "0x6003041")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9B94", Offset = "0x12F9B94", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public GenShape QuitOnFail(bool value = true)
		{
			throw null;
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00029F15 File Offset: 0x00028115
		[global::Cpp2ILInjected.Token(Token = "0x6003042")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F8638", Offset = "0x12F8638", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = ".ctor", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeFloodFill), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRoot), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int),
			typeof(Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GenShape()
		{
			throw null;
		}

		// Token: 0x040030D1 RID: 12497
		[global::Cpp2ILInjected.Token(Token = "0x40039D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ShapeData _outputData;

		// Token: 0x040030D2 RID: 12498
		[global::Cpp2ILInjected.Token(Token = "0x40039DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected bool _quitOnFail;
	}
}
