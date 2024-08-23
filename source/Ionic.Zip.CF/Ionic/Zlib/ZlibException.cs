using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x02000042 RID: 66
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000E")]
	[global::Cpp2ILInjected.Token(Token = "0x2000051")]
	public class ZlibException : Exception
	{
		// Token: 0x06000383 RID: 899 RVA: 0x00005902 File Offset: 0x00003B02
		[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74500", Offset = "0x1A74500", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZlibException()
		{
			throw null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00005905 File Offset: 0x00003B05
		[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D07C", Offset = "0x1A6D07C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZlibException(string s)
		{
			throw null;
		}
	}
}
