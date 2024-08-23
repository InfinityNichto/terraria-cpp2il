using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000D8 RID: 216
	[global::Cpp2ILInjected.Token(Token = "0x200013E")]
	public class HttpVersion
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x000041AE File Offset: 0x000023AE
		[global::Cpp2ILInjected.Token(Token = "0x600078E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE85A0", Offset = "0x1EE85A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HttpVersion()
		{
			throw null;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000041B1 File Offset: 0x000023B1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600078F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE85A8", Offset = "0x1EE85A8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static HttpVersion()
		{
			throw null;
		}

		// Token: 0x040004AF RID: 1199
		[global::Cpp2ILInjected.Token(Token = "0x4000635")]
		public static readonly Version Unknown;

		// Token: 0x040004B0 RID: 1200
		[global::Cpp2ILInjected.Token(Token = "0x4000636")]
		public static readonly Version Version10;

		// Token: 0x040004B1 RID: 1201
		[global::Cpp2ILInjected.Token(Token = "0x4000637")]
		public static readonly Version Version11;

		// Token: 0x040004B2 RID: 1202
		[global::Cpp2ILInjected.Token(Token = "0x4000638")]
		public static readonly Version Version20;
	}
}
