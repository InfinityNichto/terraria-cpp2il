using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BC RID: 188
	[global::Cpp2ILInjected.Token(Token = "0x200011A")]
	internal static class X509Helper2
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x00003F4A File Offset: 0x0000214A
		[MonoTODO("Investigate replacement; see comments in source.")]
		[global::Cpp2ILInjected.Token(Token = "0x60006A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD42C", Offset = "0x1EDD42C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "IsSignedWith", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(AsymmetricAlgorithm)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_RawData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00003F4D File Offset: 0x0000214D
		[global::Cpp2ILInjected.Token(Token = "0x60006A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD4F4", Offset = "0x1EDD4F4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Create", ReturnType = typeof(X509Chain))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static X509ChainImpl CreateChainImpl(bool useMachineContext)
		{
			throw null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00003F50 File Offset: 0x00002150
		[global::Cpp2ILInjected.Token(Token = "0x60006AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD550", Offset = "0x1EDD550", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool IsValid(X509ChainImpl impl)
		{
			throw null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00003F53 File Offset: 0x00002153
		[global::Cpp2ILInjected.Token(Token = "0x60006AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD564", Offset = "0x1EDD564", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "Verify", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "get_Impl", ReturnType = typeof(X509ChainImpl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "get_ChainPolicy", ReturnType = typeof(X509ChainPolicy))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowIfContextInvalid(X509ChainImpl impl)
		{
			throw null;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00003F56 File Offset: 0x00002156
		[global::Cpp2ILInjected.Token(Token = "0x60006AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD5A4", Offset = "0x1EDD5A4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static Exception GetInvalidChainContextException()
		{
			throw null;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00003F59 File Offset: 0x00002159
		[Obsolete("This is only used by Mono.Security's X509Store and will be replaced shortly.")]
		[global::Cpp2ILInjected.Token(Token = "0x60006AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD624", Offset = "0x1EDD624", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "ImportNewFormat", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "RemoveNewFormat", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static long GetSubjectNameHash(X509Certificate certificate)
		{
			throw null;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00003F5C File Offset: 0x0000215C
		[Obsolete("This is only used by Mono.Security's X509Store and will be replaced shortly.")]
		[global::Cpp2ILInjected.Token(Token = "0x60006AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD65C", Offset = "0x1EDD65C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "ImportNewFormat", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void ExportAsPEM(X509Certificate certificate, Stream stream, bool includeHumanReadableForm)
		{
			throw null;
		}
	}
}
