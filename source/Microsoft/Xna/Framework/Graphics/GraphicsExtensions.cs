using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002B1 RID: 689
	[global::Cpp2ILInjected.Token(Token = "0x200037C")]
	internal static class GraphicsExtensions
	{
		// Token: 0x0600163D RID: 5693 RVA: 0x00025D3F File Offset: 0x00023F3F
		[global::Cpp2ILInjected.Token(Token = "0x60017AD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB36A4", Offset = "0xAB36A4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int GetSyncInterval(this PresentInterval interval)
		{
			throw null;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00025D42 File Offset: 0x00023F42
		[global::Cpp2ILInjected.Token(Token = "0x60017AE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB36B8", Offset = "0xAB36B8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsCompressedFormat(this SurfaceFormat format)
		{
			throw null;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00025D45 File Offset: 0x00023F45
		[global::Cpp2ILInjected.Token(Token = "0x60017AF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB371C", Offset = "0xAB371C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "GetPitch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int GetSize(this SurfaceFormat surfaceFormat)
		{
			throw null;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00025D48 File Offset: 0x00023F48
		[global::Cpp2ILInjected.Token(Token = "0x60017B0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB37AC", Offset = "0xAB37AC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void GetBlockSize(this SurfaceFormat surfaceFormat, out int width, out int height)
		{
			throw null;
		}
	}
}
