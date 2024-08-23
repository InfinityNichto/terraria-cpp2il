using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200035E RID: 862
	[global::Cpp2ILInjected.Token(Token = "0x20004CE")]
	public static class Passes
	{
		// Token: 0x020008C3 RID: 2243
		[global::Cpp2ILInjected.Token(Token = "0x20004CF")]
		public class Clear : GenPass
		{
			// Token: 0x06004B95 RID: 19349 RVA: 0x0002F654 File Offset: 0x0002D854
			[global::Cpp2ILInjected.Token(Token = "0x6003027")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9064", Offset = "0x12F9064", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public Clear()
			{
				throw null;
			}

			// Token: 0x06004B96 RID: 19350 RVA: 0x0002F657 File Offset: 0x0002D857
			[global::Cpp2ILInjected.Token(Token = "0x6003028")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F90BC", Offset = "0x12F90BC", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearEverything", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
			{
				throw null;
			}
		}

		// Token: 0x020008C4 RID: 2244
		[global::Cpp2ILInjected.Token(Token = "0x20004D0")]
		public class ScatterCustom : GenPass
		{
			// Token: 0x06004B97 RID: 19351 RVA: 0x0002F65A File Offset: 0x0002D85A
			[global::Cpp2ILInjected.Token(Token = "0x6003029")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F91DC", Offset = "0x12F91DC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ScatterCustom(string name, double loadWeight, int count, GenBase.CustomPerUnitAction perUnit = null)
			{
				throw null;
			}

			// Token: 0x06004B98 RID: 19352 RVA: 0x0002F65D File Offset: 0x0002D85D
			[global::Cpp2ILInjected.Token(Token = "0x600302A")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F922C", Offset = "0x12F922C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetCustomAction(GenBase.CustomPerUnitAction perUnit)
			{
				throw null;
			}

			// Token: 0x06004B99 RID: 19353 RVA: 0x0002F660 File Offset: 0x0002D860
			[global::Cpp2ILInjected.Token(Token = "0x600302B")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F9234", Offset = "0x12F9234", Length = "0x188")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
			{
				throw null;
			}

			// Token: 0x040080AA RID: 32938
			[global::Cpp2ILInjected.Token(Token = "0x40039CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private GenBase.CustomPerUnitAction _perUnit;

			// Token: 0x040080AB RID: 32939
			[global::Cpp2ILInjected.Token(Token = "0x40039CD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _count;
		}
	}
}
