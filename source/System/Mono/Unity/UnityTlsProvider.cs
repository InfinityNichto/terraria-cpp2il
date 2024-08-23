using System;
using System.Collections;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Util;

namespace Mono.Unity
{
	// Token: 0x0200000E RID: 14
	[global::Cpp2ILInjected.Token(Token = "0x2000046")]
	internal class UnityTlsProvider : MobileTlsProvider
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002F00 File Offset: 0x00001100
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D46824", Offset = "0x1D46824", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002F03 File Offset: 0x00001103
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		public override Guid ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D46864", Offset = "0x1D46864", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002F06 File Offset: 0x00001106
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public override bool SupportsSslStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D468BC", Offset = "0x1D468BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002F09 File Offset: 0x00001109
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		public override bool SupportsMonoExtensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D468C4", Offset = "0x1D468C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002F0C File Offset: 0x0000110C
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public override bool SupportsConnectionInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D468CC", Offset = "0x1D468CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002F0F File Offset: 0x0000110F
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		internal override bool SupportsCleanShutdown
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D468D4", Offset = "0x1D468D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002F12 File Offset: 0x00001112
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public override SslProtocols SupportedProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D468DC", Offset = "0x1D468DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002F15 File Offset: 0x00001115
		[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D468E4", Offset = "0x1D468E4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTlsStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(SslStream),
			typeof(MonoTlsSettings),
			typeof(MobileTlsProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002F18 File Offset: 0x00001118
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
		[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D467CC", Offset = "0x1D467CC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		private unsafe static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002F1B File Offset: 0x0000111B
		[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D46A00", Offset = "0x1D46A00", Length = "0x80C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "get_Impl", ReturnType = typeof(X509ChainImpl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list*),
			typeof(X509CertificateCollection),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls.unitytls_x509verify_callback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplUnityTls), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		internal unsafe override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002F1E File Offset: 0x0000111E
		[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4720C", Offset = "0x1D4720C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProvider), Member = ".ctor", ReturnType = typeof(void))]
		public UnityTlsProvider()
		{
			throw null;
		}
	}
}
