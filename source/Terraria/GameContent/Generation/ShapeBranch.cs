using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020005EA RID: 1514
	[global::Cpp2ILInjected.Token(Token = "0x20008D7")]
	public class ShapeBranch : GenShape
	{
		// Token: 0x06003D32 RID: 15666 RVA: 0x0002CECA File Offset: 0x0002B0CA
		[global::Cpp2ILInjected.Token(Token = "0x60045A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BE9D0", Offset = "0x7BE9D0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public ShapeBranch()
		{
			throw null;
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x0002CECD File Offset: 0x0002B0CD
		[global::Cpp2ILInjected.Token(Token = "0x60045A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BEA10", Offset = "0x7BEA10", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = ".ctor", ReturnType = typeof(void))]
		public ShapeBranch(Point offset)
		{
			throw null;
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x0002CED0 File Offset: 0x0002B0D0
		[global::Cpp2ILInjected.Token(Token = "0x60045A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BEA38", Offset = "0x7BEA38", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ShapeBranch(double angle, double distance)
		{
			throw null;
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x0002CED3 File Offset: 0x0002B0D3
		[global::Cpp2ILInjected.Token(Token = "0x60045A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BEB04", Offset = "0x7BEB04", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils.TileActionAttempt), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool PerformSegment(Point origin, GenAction action, Point start, Point end, int size)
		{
			throw null;
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x0002CED6 File Offset: 0x0002B0D6
		[global::Cpp2ILInjected.Token(Token = "0x60045A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BECE8", Offset = "0x7BECE8", Length = "0x438")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Length", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeBranch), Member = "PerformSegment", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction),
			typeof(Point),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Perform(Point origin, GenAction action)
		{
			throw null;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x0002CED9 File Offset: 0x0002B0D9
		[global::Cpp2ILInjected.Token(Token = "0x60045A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BF120", Offset = "0x7BF120", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public ShapeBranch OutputEndpoints(List<Point> endpoints)
		{
			throw null;
		}

		// Token: 0x04006BD4 RID: 27604
		[global::Cpp2ILInjected.Token(Token = "0x400820B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Point _offset;

		// Token: 0x04006BD5 RID: 27605
		[global::Cpp2ILInjected.Token(Token = "0x400820C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<Point> _endPoints;

		// Token: 0x020009F7 RID: 2551
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20008D8")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004F44 RID: 20292 RVA: 0x0002FFFC File Offset: 0x0002E1FC
			[global::Cpp2ILInjected.Token(Token = "0x60045AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7BECE0", Offset = "0x7BECE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

			// Token: 0x06004F45 RID: 20293 RVA: 0x0002FFFF File Offset: 0x0002E1FF
			[global::Cpp2ILInjected.Token(Token = "0x60045AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7BF128", Offset = "0x7BF128", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenShape), Member = "UnitApply", MemberParameters = new object[]
			{
				typeof(GenAction),
				typeof(Point),
				typeof(int),
				typeof(int),
				typeof(object[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal bool <PerformSegment>b__0(int tileX, int tileY)
			{
				throw null;
			}

			// Token: 0x04008CEA RID: 36074
			[global::Cpp2ILInjected.Token(Token = "0x400820D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ShapeBranch <>4__this;

			// Token: 0x04008CEB RID: 36075
			[global::Cpp2ILInjected.Token(Token = "0x400820E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public GenAction action;

			// Token: 0x04008CEC RID: 36076
			[global::Cpp2ILInjected.Token(Token = "0x400820F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Point origin;

			// Token: 0x04008CED RID: 36077
			[global::Cpp2ILInjected.Token(Token = "0x4008210")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Utils.TileActionAttempt <>9__0;
		}
	}
}
