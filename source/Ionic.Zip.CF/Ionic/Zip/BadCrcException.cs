using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x02000012 RID: 18
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00009")]
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	[Serializable]
	public class BadCrcException : ZipException
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00004F78 File Offset: 0x00003178
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A459FC", Offset = "0x1A459FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", ReturnType = typeof(void))]
		public BadCrcException()
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004F7B File Offset: 0x0000317B
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45A00", Offset = "0x1A45A00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "VerifyCrcAfterExtract", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public BadCrcException(string message)
		{
			throw null;
		}
	}
}
