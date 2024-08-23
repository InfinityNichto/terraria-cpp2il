using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Terraria.GameContent.Biomes;

namespace Terraria.Utilities
{
	// Token: 0x02000375 RID: 885
	[global::Cpp2ILInjected.Token(Token = "0x20004FA")]
	public struct IntRange
	{
		// Token: 0x06002CD1 RID: 11473 RVA: 0x0002A098 File Offset: 0x00028298
		[global::Cpp2ILInjected.Token(Token = "0x60030E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x130167C", Offset = "0x130167C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public IntRange(int minimum, int maximum)
		{
			throw null;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0002A09B File Offset: 0x0002829B
		[global::Cpp2ILInjected.Token(Token = "0x60030E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1301684", Offset = "0x1301684", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IntRange operator *(IntRange range, float scale)
		{
			throw null;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x0002A09E File Offset: 0x0002829E
		[global::Cpp2ILInjected.Token(Token = "0x60030E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x13016CC", Offset = "0x13016CC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IntRange operator *(float scale, IntRange range)
		{
			throw null;
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x0002A0A1 File Offset: 0x000282A1
		[global::Cpp2ILInjected.Token(Token = "0x60030E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1301714", Offset = "0x1301714", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IntRange operator /(IntRange range, float scale)
		{
			throw null;
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x0002A0A4 File Offset: 0x000282A4
		[global::Cpp2ILInjected.Token(Token = "0x60030E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x130175C", Offset = "0x130175C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IntRange operator /(float scale, IntRange range)
		{
			throw null;
		}

		// Token: 0x0400318D RID: 12685
		[JsonProperty("Min")]
		[global::Cpp2ILInjected.Token(Token = "0x4003ACD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly int Minimum;

		// Token: 0x0400318E RID: 12686
		[JsonProperty("Max")]
		[global::Cpp2ILInjected.Token(Token = "0x4003ACE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly int Maximum;
	}
}
