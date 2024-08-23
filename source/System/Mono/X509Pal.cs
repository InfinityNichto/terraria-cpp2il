using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	internal static class X509Pal
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002E70 File Offset: 0x00001070
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public static X509PalImpl Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000028")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D40F50", Offset = "0x1D40F50", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "GetCertContentType", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509ContentType))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(X509Extension))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemDependencyProvider), Member = "get_Instance", ReturnType = typeof(SystemDependencyProvider))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
