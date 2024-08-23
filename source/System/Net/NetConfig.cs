using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001A8 RID: 424
	[global::Cpp2ILInjected.Token(Token = "0x200026A")]
	internal class NetConfig : ICloneable
	{
		// Token: 0x06000EF7 RID: 3831 RVA: 0x00005918 File Offset: 0x00003B18
		[global::Cpp2ILInjected.Token(Token = "0x6001099")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E038EC", Offset = "0x1E038EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal NetConfig()
		{
			throw null;
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0000591B File Offset: 0x00003B1B
		[global::Cpp2ILInjected.Token(Token = "0x600109A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E038FC", Offset = "0x1E038FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		private object System.ICloneable.Clone()
		{
			throw null;
		}

		// Token: 0x04000A1B RID: 2587
		[global::Cpp2ILInjected.Token(Token = "0x4000D1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool ipv6Enabled;

		// Token: 0x04000A1C RID: 2588
		[global::Cpp2ILInjected.Token(Token = "0x4000D1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int MaxResponseHeadersLength;
	}
}
