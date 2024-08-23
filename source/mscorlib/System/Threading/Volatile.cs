using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x020001A8 RID: 424
	[global::Cpp2ILInjected.Token(Token = "0x2000213")]
	public static class Volatile
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x00017579 File Offset: 0x00015779
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA34F8", Offset = "0x1CA34F8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool Read(ref bool location)
		{
			throw null;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0001757C File Offset: 0x0001577C
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3510", Offset = "0x1CA3510", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int Read(ref int location)
		{
			throw null;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0001757F File Offset: 0x0001577F
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3528", Offset = "0x1CA3528", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Write(ref int location, int value)
		{
			throw null;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00017582 File Offset: 0x00015782
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A44FC", Offset = "0x15A44FC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static T Read<T>(ref T location) where T : class
		{
			throw null;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00017585 File Offset: 0x00015785
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4514", Offset = "0x15A4514", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Write<T>(ref T location, T value) where T : class
		{
			throw null;
		}

		// Token: 0x020005B8 RID: 1464
		[global::Cpp2ILInjected.Token(Token = "0x2000214")]
		private struct VolatileBoolean
		{
			// Token: 0x040018C3 RID: 6339
			[global::Cpp2ILInjected.Token(Token = "0x4000A18")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public bool Value;
		}

		// Token: 0x020005B9 RID: 1465
		[global::Cpp2ILInjected.Token(Token = "0x2000215")]
		private struct VolatileInt32
		{
			// Token: 0x040018C4 RID: 6340
			[global::Cpp2ILInjected.Token(Token = "0x4000A19")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Value;
		}

		// Token: 0x020005BA RID: 1466
		[global::Cpp2ILInjected.Token(Token = "0x2000216")]
		private struct VolatileObject
		{
			// Token: 0x040018C5 RID: 6341
			[global::Cpp2ILInjected.Token(Token = "0x4000A1A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public object Value;
		}
	}
}
