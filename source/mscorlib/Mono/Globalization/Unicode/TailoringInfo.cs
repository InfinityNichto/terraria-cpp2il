using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000021 RID: 33
	[global::Cpp2ILInjected.Token(Token = "0x2000032")]
	internal class TailoringInfo
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00014708 File Offset: 0x00012908
		[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADB8C", Offset = "0x1AADB8C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort)
		{
			throw null;
		}

		// Token: 0x04000042 RID: 66
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int LCID;

		// Token: 0x04000043 RID: 67
		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly int TailoringIndex;

		// Token: 0x04000044 RID: 68
		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int TailoringCount;

		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public readonly bool FrenchSort;
	}
}
