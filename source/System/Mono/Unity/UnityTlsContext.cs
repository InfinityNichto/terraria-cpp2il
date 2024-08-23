using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Cryptography;
using Mono.Security.Interface;
using Mono.Util;

namespace Mono.Unity
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	internal class UnityTlsContext : MobileTlsContext
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002EAC File Offset: 0x000010AC
		[global::Cpp2ILInjected.Token(Token = "0x6000089")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44038", Offset = "0x1D44038", Length = "0x6B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsStream), Member = "CreateContext", MemberParameters = new object[] { typeof(MonoSslAuthenticationOptions) }, ReturnType = typeof(MobileTlsContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileTlsContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(MonoSslAuthenticationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls.unitytls_tlsctx_read_callback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls.unitytls_tlsctx_write_callback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(UnityTls.unitytls_errorstate*),
			typeof(ref UnityTls.unitytls_x509list*),
			typeof(ref UnityTls.unitytls_key*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls.unitytls_tlsctx_certificate_callback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls.unitytls_tlsctx_x509verify_callback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public unsafe UnityTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002EAF File Offset: 0x000010AF
		[global::Cpp2ILInjected.Token(Token = "0x600008A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44880", Offset = "0x1D44880", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(MonoSslAuthenticationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_tlsctx*),
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509name*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509list_ref*),
			typeof(UnityTls.unitytls_key_ref*),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list*),
			typeof(X509Certificate),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private unsafe static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey)
		{
			throw null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002EB2 File Offset: 0x000010B2
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public override bool IsAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D44B64", Offset = "0x1D44B64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002EB5 File Offset: 0x000010B5
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		internal override X509Certificate LocalClientCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D44B6C", Offset = "0x1D44B6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002EB8 File Offset: 0x000010B8
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public override X509Certificate2 RemoteCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D44B74", Offset = "0x1D44B74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002EBB File Offset: 0x000010BB
		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44B7C", Offset = "0x1D44B7C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<int, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002EBE File Offset: 0x000010BE
		[global::Cpp2ILInjected.Token(Token = "0x600008F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44D0C", Offset = "0x1D44D0C", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<int, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002EC1 File Offset: 0x000010C1
		[global::Cpp2ILInjected.Token(Token = "0x6000090")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44E94", Offset = "0x1D44E94", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Renegotiate()
		{
			throw null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002EC4 File Offset: 0x000010C4
		[global::Cpp2ILInjected.Token(Token = "0x6000091")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44ECC", Offset = "0x1D44ECC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool PendingRenegotiation()
		{
			throw null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002EC7 File Offset: 0x000010C7
		[global::Cpp2ILInjected.Token(Token = "0x6000092")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44ED4", Offset = "0x1D44ED4", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		public override void Shutdown()
		{
			throw null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002ECA File Offset: 0x000010CA
		[global::Cpp2ILInjected.Token(Token = "0x6000093")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44FA8", Offset = "0x1D44FA8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002ECD File Offset: 0x000010CD
		[global::Cpp2ILInjected.Token(Token = "0x6000094")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45020", Offset = "0x1D45020", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void StartHandshake()
		{
			throw null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002ED0 File Offset: 0x000010D0
		[global::Cpp2ILInjected.Token(Token = "0x6000095")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45160", Offset = "0x1D45160", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileTlsContext), Member = "ValidateCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Chain)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AlertDescription),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(UnityTls.unitytls_x509verify_result),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool ProcessHandshake()
		{
			throw null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002ED3 File Offset: 0x000010D3
		[global::Cpp2ILInjected.Token(Token = "0x6000096")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45304", Offset = "0x1D45304", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsConnectionInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void FinishHandshake()
		{
			throw null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002ED6 File Offset: 0x000010D6
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
		[global::Cpp2ILInjected.Token(Token = "0x6000097")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D43D40", Offset = "0x1D43D40", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTlsContext), Member = "WriteCallback", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002ED9 File Offset: 0x000010D9
		[global::Cpp2ILInjected.Token(Token = "0x6000098")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45428", Offset = "0x1D45428", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "WriteCallback", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private unsafe IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002EDC File Offset: 0x000010DC
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
		[global::Cpp2ILInjected.Token(Token = "0x6000099")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D43E04", Offset = "0x1D43E04", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTlsContext), Member = "ReadCallback", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002EDF File Offset: 0x000010DF
		[global::Cpp2ILInjected.Token(Token = "0x600009A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45848", Offset = "0x1D45848", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ReadCallback", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private unsafe IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002EE2 File Offset: 0x000010E2
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
		[global::Cpp2ILInjected.Token(Token = "0x600009B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D43EC8", Offset = "0x1D43EC8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(UnityTls.unitytls_x509verify_result))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002EE5 File Offset: 0x000010E5
		[global::Cpp2ILInjected.Token(Token = "0x600009C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45C08", Offset = "0x1D45C08", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(UnityTls.unitytls_x509verify_result))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplUnityTls), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileTlsContext), Member = "ValidateCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Chain)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private unsafe UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002EE8 File Offset: 0x000010E8
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D43F74", Offset = "0x1D43F74", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_tlsctx*),
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509name*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509list_ref*),
			typeof(UnityTls.unitytls_key_ref*),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002EEB File Offset: 0x000010EB
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D46084", Offset = "0x1D46084", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(UnityTls.unitytls_tlsctx*),
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509name*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509list_ref*),
			typeof(UnityTls.unitytls_key_ref*),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(UnityTls.unitytls_errorstate*),
			typeof(ref UnityTls.unitytls_x509list*),
			typeof(ref UnityTls.unitytls_key*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AlertDescription),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private unsafe void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
			throw null;
		}

		// Token: 0x04000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x4000085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private unsafe UnityTls.unitytls_tlsctx* tlsContext;

		// Token: 0x0400000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x4000086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private unsafe UnityTls.unitytls_x509list* requestedClientCertChain;

		// Token: 0x0400000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x4000087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private unsafe UnityTls.unitytls_key* requestedClientKey;

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x4000088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private UnityTls.unitytls_tlsctx_read_callback readCallback;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x4000089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private UnityTls.unitytls_tlsctx_write_callback writeCallback;

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x400008A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback;

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x400008B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback;

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x400008C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private X509Certificate localClientCertificate;

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x400008D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private X509Certificate2 remoteCertificate;

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x400008E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private MonoTlsConnectionInfo connectioninfo;

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x400008F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool isAuthenticated;

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000090")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		private bool hasContext;

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x4000091")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAA")]
		private bool closedGraceful;

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x4000092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private byte[] writeBuffer;

		// Token: 0x04000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x4000093")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private byte[] readBuffer;

		// Token: 0x04000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x4000094")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private GCHandle handle;

		// Token: 0x04000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x4000095")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private Exception lastException;
	}
}
