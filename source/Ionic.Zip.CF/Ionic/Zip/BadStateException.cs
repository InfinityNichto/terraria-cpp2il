using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x02000014 RID: 20
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00007")]
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	[Serializable]
	public class BadStateException : ZipException
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00004F84 File Offset: 0x00003184
		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45A0C", Offset = "0x1A45A0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", ReturnType = typeof(void))]
		public BadStateException()
		{
			throw null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004F87 File Offset: 0x00003187
		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45A10", Offset = "0x1A45A10", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughOneEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public BadStateException(string message)
		{
			throw null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004F8A File Offset: 0x0000318A
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45A14", Offset = "0x1A45A14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public BadStateException(string message, Exception innerException)
		{
			throw null;
		}
	}
}
