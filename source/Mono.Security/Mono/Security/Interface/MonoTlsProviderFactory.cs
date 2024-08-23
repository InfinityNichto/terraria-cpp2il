using System;
using System.IO;
using System.Net;
using System.Net.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Interface
{
	// Token: 0x02000032 RID: 50
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	public static class MonoTlsProviderFactory
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00003420 File Offset: 0x00001620
		[global::Cpp2ILInjected.Token(Token = "0x6000202")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B698", Offset = "0x1A9B698", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback)
		}, ReturnType = typeof(SslStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = "GetProvider", ReturnType = "Mono.Net.Security.MobileTlsProvider")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.Net.Security.NoReflectionHelper", Member = "GetProvider", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static MonoTlsProvider GetProvider()
		{
			throw null;
		}
	}
}
