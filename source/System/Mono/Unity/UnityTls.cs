using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;

namespace Mono.Unity
{
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	internal static class UnityTls
	{
		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D41C34", Offset = "0x1D41C34", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern IntPtr GetUnityTlsInterface();

		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public static bool IsSupported
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D41C38", Offset = "0x1D41C38", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public unsafe static UnityTls.unitytls_interface_struct NativeInterface
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D41994", Offset = "0x1D41994", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new object[]
			{
				typeof(UnityTls.unitytls_x509list*),
				typeof(X509Certificate),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTls), Member = "get_IsSupported", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(MobileAuthenticatedStream),
				typeof(MonoSslAuthenticationOptions)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				typeof(UnityTls.unitytls_errorstate*),
				typeof(ref UnityTls.unitytls_x509list*),
				typeof(ref UnityTls.unitytls_key*)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "Read", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(ValueTuple<int, bool>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "Write", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(ValueTuple<int, bool>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "Shutdown", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "FinishHandshake", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "WriteCallback", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(IntPtr),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ReadCallback", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(IntPtr),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(IntPtr))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsProvider), Member = "x509verify_callback", MemberParameters = new object[]
			{
				typeof(void*),
				typeof(UnityTls.unitytls_x509_ref),
				typeof(UnityTls.unitytls_x509verify_result),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(UnityTls.unitytls_x509verify_result))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new object[]
			{
				typeof(ChainValidationHelper),
				typeof(string),
				typeof(bool),
				typeof(X509CertificateCollection),
				typeof(bool),
				typeof(ref X509Chain),
				typeof(ref SslPolicyErrors),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_IsValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "Reset", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "InitializeProviderRegistration", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "CreateDefaultProviderImpl", ReturnType = typeof(MobileTlsProvider))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 79)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		private static UnityTls.unitytls_interface_struct marshalledInterface;

		[global::Cpp2ILInjected.Token(Token = "0x2000011")]
		public enum unitytls_error_code : uint
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000030")]
			UNITYTLS_SUCCESS,
			[global::Cpp2ILInjected.Token(Token = "0x4000031")]
			UNITYTLS_INVALID_ARGUMENT,
			[global::Cpp2ILInjected.Token(Token = "0x4000032")]
			UNITYTLS_INVALID_FORMAT,
			[global::Cpp2ILInjected.Token(Token = "0x4000033")]
			UNITYTLS_INVALID_PASSWORD,
			[global::Cpp2ILInjected.Token(Token = "0x4000034")]
			UNITYTLS_INVALID_STATE,
			[global::Cpp2ILInjected.Token(Token = "0x4000035")]
			UNITYTLS_BUFFER_OVERFLOW,
			[global::Cpp2ILInjected.Token(Token = "0x4000036")]
			UNITYTLS_OUT_OF_MEMORY,
			[global::Cpp2ILInjected.Token(Token = "0x4000037")]
			UNITYTLS_INTERNAL_ERROR,
			[global::Cpp2ILInjected.Token(Token = "0x4000038")]
			UNITYTLS_NOT_SUPPORTED,
			[global::Cpp2ILInjected.Token(Token = "0x4000039")]
			UNITYTLS_ENTROPY_SOURCE_FAILED,
			[global::Cpp2ILInjected.Token(Token = "0x400003A")]
			UNITYTLS_STREAM_CLOSED,
			[global::Cpp2ILInjected.Token(Token = "0x400003B")]
			UNITYTLS_USER_CUSTOM_ERROR_START = 1048576U,
			[global::Cpp2ILInjected.Token(Token = "0x400003C")]
			UNITYTLS_USER_WOULD_BLOCK,
			[global::Cpp2ILInjected.Token(Token = "0x400003D")]
			UNITYTLS_USER_READ_FAILED,
			[global::Cpp2ILInjected.Token(Token = "0x400003E")]
			UNITYTLS_USER_WRITE_FAILED,
			[global::Cpp2ILInjected.Token(Token = "0x400003F")]
			UNITYTLS_USER_UNKNOWN_ERROR,
			[global::Cpp2ILInjected.Token(Token = "0x4000040")]
			UNITYTLS_USER_CUSTOM_ERROR_END = 2097152U
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000012")]
		public struct unitytls_errorstate
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000041")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private uint magic;

			[global::Cpp2ILInjected.Token(Token = "0x4000042")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public UnityTls.unitytls_error_code code;

			[global::Cpp2ILInjected.Token(Token = "0x4000043")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private ulong reserved;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000013")]
		public struct unitytls_key
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000014")]
		public struct unitytls_key_ref
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000044")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000015")]
		public struct unitytls_x509_ref
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000045")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000016")]
		public struct unitytls_x509list
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000017")]
		public struct unitytls_x509list_ref
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000046")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000018")]
		public enum unitytls_x509verify_result : uint
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000048")]
			UNITYTLS_X509VERIFY_SUCCESS = 0U,
			[global::Cpp2ILInjected.Token(Token = "0x4000049")]
			UNITYTLS_X509VERIFY_NOT_DONE = 2147483648U,
			[global::Cpp2ILInjected.Token(Token = "0x400004A")]
			UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295U,
			[global::Cpp2ILInjected.Token(Token = "0x400004B")]
			UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1U,
			[global::Cpp2ILInjected.Token(Token = "0x400004C")]
			UNITYTLS_X509VERIFY_FLAG_REVOKED = 2U,
			[global::Cpp2ILInjected.Token(Token = "0x400004D")]
			UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4U,
			[global::Cpp2ILInjected.Token(Token = "0x400004E")]
			UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8U,
			[global::Cpp2ILInjected.Token(Token = "0x400004F")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536U,
			[global::Cpp2ILInjected.Token(Token = "0x4000050")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072U,
			[global::Cpp2ILInjected.Token(Token = "0x4000051")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144U,
			[global::Cpp2ILInjected.Token(Token = "0x4000052")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288U,
			[global::Cpp2ILInjected.Token(Token = "0x4000053")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576U,
			[global::Cpp2ILInjected.Token(Token = "0x4000054")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152U,
			[global::Cpp2ILInjected.Token(Token = "0x4000055")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304U,
			[global::Cpp2ILInjected.Token(Token = "0x4000056")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608U,
			[global::Cpp2ILInjected.Token(Token = "0x4000057")]
			UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728U
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000019")]
		public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState);

		[global::Cpp2ILInjected.Token(Token = "0x200001A")]
		public struct unitytls_tlsctx
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x200001B")]
		public struct unitytls_x509name
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x200001C")]
		public enum unitytls_ciphersuite : uint
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000059")]
			UNITYTLS_CIPHERSUITE_INVALID = 16777215U
		}

		[global::Cpp2ILInjected.Token(Token = "0x200001D")]
		public enum unitytls_protocol : uint
		{
			[global::Cpp2ILInjected.Token(Token = "0x400005B")]
			UNITYTLS_PROTOCOL_TLS_1_0,
			[global::Cpp2ILInjected.Token(Token = "0x400005C")]
			UNITYTLS_PROTOCOL_TLS_1_1,
			[global::Cpp2ILInjected.Token(Token = "0x400005D")]
			UNITYTLS_PROTOCOL_TLS_1_2,
			[global::Cpp2ILInjected.Token(Token = "0x400005E")]
			UNITYTLS_PROTOCOL_INVALID
		}

		[global::Cpp2ILInjected.Token(Token = "0x200001E")]
		public struct unitytls_tlsctx_protocolrange
		{
			[global::Cpp2ILInjected.Token(Token = "0x400005F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public UnityTls.unitytls_protocol min;

			[global::Cpp2ILInjected.Token(Token = "0x4000060")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public UnityTls.unitytls_protocol max;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200001F")]
		public unsafe delegate IntPtr unitytls_tlsctx_write_callback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		public unsafe delegate IntPtr unitytls_tlsctx_read_callback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000021")]
		public unsafe delegate void unitytls_tlsctx_trace_callback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000022")]
		public unsafe delegate void unitytls_tlsctx_certificate_callback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000023")]
		public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_tlsctx_x509verify_callback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState);

		[global::Cpp2ILInjected.Token(Token = "0x2000024")]
		public struct unitytls_tlsctx_callbacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000061")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public UnityTls.unitytls_tlsctx_read_callback read;

			[global::Cpp2ILInjected.Token(Token = "0x4000062")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public UnityTls.unitytls_tlsctx_write_callback write;

			[global::Cpp2ILInjected.Token(Token = "0x4000063")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public unsafe void* data;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000025")]
		[StructLayout(0)]
		public class unitytls_interface_struct
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D421E0", Offset = "0x1D421E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public unitytls_interface_struct()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000064")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly ulong UNITYTLS_INVALID_HANDLE;

			[global::Cpp2ILInjected.Token(Token = "0x4000065")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;

			[global::Cpp2ILInjected.Token(Token = "0x4000066")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create;

			[global::Cpp2ILInjected.Token(Token = "0x4000067")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error;

			[global::Cpp2ILInjected.Token(Token = "0x4000068")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref;

			[global::Cpp2ILInjected.Token(Token = "0x4000069")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der;

			[global::Cpp2ILInjected.Token(Token = "0x400006A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem;

			[global::Cpp2ILInjected.Token(Token = "0x400006B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free;

			[global::Cpp2ILInjected.Token(Token = "0x400006C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der;

			[global::Cpp2ILInjected.Token(Token = "0x400006D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref;

			[global::Cpp2ILInjected.Token(Token = "0x400006E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509;

			[global::Cpp2ILInjected.Token(Token = "0x400006F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create;

			[global::Cpp2ILInjected.Token(Token = "0x4000070")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append;

			[global::Cpp2ILInjected.Token(Token = "0x4000071")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der;

			[global::Cpp2ILInjected.Token(Token = "0x4000072")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem;

			[global::Cpp2ILInjected.Token(Token = "0x4000073")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free;

			[global::Cpp2ILInjected.Token(Token = "0x4000074")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			public UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca;

			[global::Cpp2ILInjected.Token(Token = "0x4000075")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			public UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca;

			[global::Cpp2ILInjected.Token(Token = "0x4000076")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server;

			[global::Cpp2ILInjected.Token(Token = "0x4000077")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client;

			[global::Cpp2ILInjected.Token(Token = "0x4000078")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication;

			[global::Cpp2ILInjected.Token(Token = "0x4000079")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback;

			[global::Cpp2ILInjected.Token(Token = "0x400007A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback;

			[global::Cpp2ILInjected.Token(Token = "0x400007B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback;

			[global::Cpp2ILInjected.Token(Token = "0x400007C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites;

			[global::Cpp2ILInjected.Token(Token = "0x400007D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite;

			[global::Cpp2ILInjected.Token(Token = "0x400007E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol;

			[global::Cpp2ILInjected.Token(Token = "0x400007F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake;

			[global::Cpp2ILInjected.Token(Token = "0x4000080")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read;

			[global::Cpp2ILInjected.Token(Token = "0x4000081")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write;

			[global::Cpp2ILInjected.Token(Token = "0x4000082")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close;

			[global::Cpp2ILInjected.Token(Token = "0x4000083")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free;

			[global::Cpp2ILInjected.Token(Token = "0x4000084")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
			public UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000026")]
			public delegate UnityTls.unitytls_errorstate unitytls_errorstate_create_t();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000027")]
			public unsafe delegate void unitytls_errorstate_raise_error_t(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000028")]
			public unsafe delegate UnityTls.unitytls_key_ref unitytls_key_get_ref_t(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000029")]
			public unsafe delegate UnityTls.unitytls_key* unitytls_key_parse_der_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002A")]
			public unsafe delegate UnityTls.unitytls_key* unitytls_key_parse_pem_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002B")]
			public unsafe delegate void unitytls_key_free_t(UnityTls.unitytls_key* key);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002C")]
			public unsafe delegate IntPtr unitytls_x509_export_der_t(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002D")]
			public unsafe delegate UnityTls.unitytls_x509list_ref unitytls_x509list_get_ref_t(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002E")]
			public unsafe delegate UnityTls.unitytls_x509_ref unitytls_x509list_get_x509_t(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002F")]
			public unsafe delegate UnityTls.unitytls_x509list* unitytls_x509list_create_t(UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000030")]
			public unsafe delegate void unitytls_x509list_append_t(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000031")]
			public unsafe delegate void unitytls_x509list_append_der_t(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000032")]
			public unsafe delegate void unitytls_x509list_free_t(UnityTls.unitytls_x509list* list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000033")]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_default_ca_t(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000034")]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_explicit_ca_t(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000035")]
			public unsafe delegate UnityTls.unitytls_tlsctx* unitytls_tlsctx_create_server_t(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000036")]
			public unsafe delegate UnityTls.unitytls_tlsctx* unitytls_tlsctx_create_client_t(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000037")]
			public unsafe delegate void unitytls_tlsctx_server_require_client_authentication_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000038")]
			public unsafe delegate void unitytls_tlsctx_set_certificate_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000039")]
			public unsafe delegate void unitytls_tlsctx_set_trace_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003A")]
			public unsafe delegate void unitytls_tlsctx_set_x509verify_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003B")]
			public unsafe delegate void unitytls_tlsctx_set_supported_ciphersuites_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003C")]
			public unsafe delegate UnityTls.unitytls_ciphersuite unitytls_tlsctx_get_ciphersuite_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003D")]
			public unsafe delegate UnityTls.unitytls_protocol unitytls_tlsctx_get_protocol_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003E")]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_tlsctx_process_handshake_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003F")]
			public unsafe delegate IntPtr unitytls_tlsctx_read_t(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000040")]
			public unsafe delegate IntPtr unitytls_tlsctx_write_t(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000041")]
			public unsafe delegate void unitytls_tlsctx_notify_close_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000042")]
			public unsafe delegate void unitytls_tlsctx_free_t(UnityTls.unitytls_tlsctx* ctx);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000043")]
			public unsafe delegate void unitytls_random_generate_bytes_t(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);
		}
	}
}
