using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Ambience
{
	// Token: 0x0200070A RID: 1802
	[global::Cpp2ILInjected.Token(Token = "0x2000AF8")]
	public class AmbientSkyDrawCache
	{
		// Token: 0x060045C7 RID: 17863 RVA: 0x0002E7C9 File Offset: 0x0002C9C9
		[global::Cpp2ILInjected.Token(Token = "0x600523A")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B7EC", Offset = "0x93B7EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetUnderworldInfo(int drawIndex, float scale)
		{
			throw null;
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x0002E7CC File Offset: 0x0002C9CC
		[global::Cpp2ILInjected.Token(Token = "0x600523B")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B7FC", Offset = "0x93B7FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateOceanWaterLineForAmbience", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetOceanLineInfo(float yScreenPosition, float oceanOpacity)
		{
			throw null;
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x0002E7CF File Offset: 0x0002C9CF
		[global::Cpp2ILInjected.Token(Token = "0x600523C")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B804", Offset = "0x93B804", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSkyDrawCache), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AmbientSkyDrawCache()
		{
			throw null;
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x0002E7D2 File Offset: 0x0002C9D2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600523D")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B85C", Offset = "0x93B85C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSkyDrawCache), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static AmbientSkyDrawCache()
		{
			throw null;
		}

		// Token: 0x0400712B RID: 28971
		[global::Cpp2ILInjected.Token(Token = "0x4008A7D")]
		public static AmbientSkyDrawCache Instance;

		// Token: 0x0400712C RID: 28972
		[global::Cpp2ILInjected.Token(Token = "0x4008A7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public AmbientSkyDrawCache.UnderworldCache[] Underworld;

		// Token: 0x0400712D RID: 28973
		[global::Cpp2ILInjected.Token(Token = "0x4008A7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public AmbientSkyDrawCache.OceanLineCache OceanLineInfo;

		// Token: 0x02000ACA RID: 2762
		[global::Cpp2ILInjected.Token(Token = "0x2000AF9")]
		public struct UnderworldCache
		{
			// Token: 0x04008F5E RID: 36702
			[global::Cpp2ILInjected.Token(Token = "0x4008A80")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float Scale;
		}

		// Token: 0x02000ACB RID: 2763
		[global::Cpp2ILInjected.Token(Token = "0x2000AFA")]
		public struct OceanLineCache
		{
			// Token: 0x04008F5F RID: 36703
			[global::Cpp2ILInjected.Token(Token = "0x4008A81")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float YScreenPosition;

			// Token: 0x04008F60 RID: 36704
			[global::Cpp2ILInjected.Token(Token = "0x4008A82")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public float OceanOpacity;
		}
	}
}
