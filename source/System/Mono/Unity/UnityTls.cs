using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Unity
{
	// Token: 0x0200000B RID: 11
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	internal static class UnityTls
	{
		// Token: 0x06000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D41C34", Offset = "0x1D41C34", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern IntPtr GetUnityTlsInterface();

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002EA6 File Offset: 0x000010A6
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002EA9 File Offset: 0x000010A9
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public static UnityTls.unitytls_interface_struct NativeInterface
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D41994", Offset = "0x1D41994", Length = "0xE4")]
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

		// Token: 0x04000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		private static UnityTls.unitytls_interface_struct marshalledInterface;

		// Token: 0x0200038B RID: 907
		[global::Cpp2ILInjected.Token(Token = "0x2000011")]
		public enum unitytls_error_code : uint
		{
			// Token: 0x04000FD8 RID: 4056
			[global::Cpp2ILInjected.Token(Token = "0x4000030")]
			UNITYTLS_SUCCESS,
			// Token: 0x04000FD9 RID: 4057
			[global::Cpp2ILInjected.Token(Token = "0x4000031")]
			UNITYTLS_INVALID_ARGUMENT,
			// Token: 0x04000FDA RID: 4058
			[global::Cpp2ILInjected.Token(Token = "0x4000032")]
			UNITYTLS_INVALID_FORMAT,
			// Token: 0x04000FDB RID: 4059
			[global::Cpp2ILInjected.Token(Token = "0x4000033")]
			UNITYTLS_INVALID_PASSWORD,
			// Token: 0x04000FDC RID: 4060
			[global::Cpp2ILInjected.Token(Token = "0x4000034")]
			UNITYTLS_INVALID_STATE,
			// Token: 0x04000FDD RID: 4061
			[global::Cpp2ILInjected.Token(Token = "0x4000035")]
			UNITYTLS_BUFFER_OVERFLOW,
			// Token: 0x04000FDE RID: 4062
			[global::Cpp2ILInjected.Token(Token = "0x4000036")]
			UNITYTLS_OUT_OF_MEMORY,
			// Token: 0x04000FDF RID: 4063
			[global::Cpp2ILInjected.Token(Token = "0x4000037")]
			UNITYTLS_INTERNAL_ERROR,
			// Token: 0x04000FE0 RID: 4064
			[global::Cpp2ILInjected.Token(Token = "0x4000038")]
			UNITYTLS_NOT_SUPPORTED,
			// Token: 0x04000FE1 RID: 4065
			[global::Cpp2ILInjected.Token(Token = "0x4000039")]
			UNITYTLS_ENTROPY_SOURCE_FAILED,
			// Token: 0x04000FE2 RID: 4066
			[global::Cpp2ILInjected.Token(Token = "0x400003A")]
			UNITYTLS_STREAM_CLOSED,
			// Token: 0x04000FE3 RID: 4067
			[global::Cpp2ILInjected.Token(Token = "0x400003B")]
			UNITYTLS_USER_CUSTOM_ERROR_START = 1048576U,
			// Token: 0x04000FE4 RID: 4068
			[global::Cpp2ILInjected.Token(Token = "0x400003C")]
			UNITYTLS_USER_WOULD_BLOCK,
			// Token: 0x04000FE5 RID: 4069
			[global::Cpp2ILInjected.Token(Token = "0x400003D")]
			UNITYTLS_USER_READ_FAILED,
			// Token: 0x04000FE6 RID: 4070
			[global::Cpp2ILInjected.Token(Token = "0x400003E")]
			UNITYTLS_USER_WRITE_FAILED,
			// Token: 0x04000FE7 RID: 4071
			[global::Cpp2ILInjected.Token(Token = "0x400003F")]
			UNITYTLS_USER_UNKNOWN_ERROR,
			// Token: 0x04000FE8 RID: 4072
			[global::Cpp2ILInjected.Token(Token = "0x4000040")]
			UNITYTLS_USER_CUSTOM_ERROR_END = 2097152U
		}

		// Token: 0x0200038C RID: 908
		[global::Cpp2ILInjected.Token(Token = "0x2000012")]
		public struct unitytls_errorstate
		{
			// Token: 0x04000FE9 RID: 4073
			[global::Cpp2ILInjected.Token(Token = "0x4000041")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private uint magic;

			// Token: 0x04000FEA RID: 4074
			[global::Cpp2ILInjected.Token(Token = "0x4000042")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public UnityTls.unitytls_error_code code;

			// Token: 0x04000FEB RID: 4075
			[global::Cpp2ILInjected.Token(Token = "0x4000043")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private ulong reserved;
		}

		// Token: 0x0200038D RID: 909
		[global::Cpp2ILInjected.Token(Token = "0x2000013")]
		public struct unitytls_key
		{
		}

		// Token: 0x0200038E RID: 910
		[global::Cpp2ILInjected.Token(Token = "0x2000014")]
		public struct unitytls_key_ref
		{
			// Token: 0x04000FEC RID: 4076
			[global::Cpp2ILInjected.Token(Token = "0x4000044")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		// Token: 0x0200038F RID: 911
		[global::Cpp2ILInjected.Token(Token = "0x2000015")]
		public struct unitytls_x509_ref
		{
			// Token: 0x04000FED RID: 4077
			[global::Cpp2ILInjected.Token(Token = "0x4000045")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		// Token: 0x02000390 RID: 912
		[global::Cpp2ILInjected.Token(Token = "0x2000016")]
		public struct unitytls_x509list
		{
		}

		// Token: 0x02000391 RID: 913
		[global::Cpp2ILInjected.Token(Token = "0x2000017")]
		public struct unitytls_x509list_ref
		{
			// Token: 0x04000FEE RID: 4078
			[global::Cpp2ILInjected.Token(Token = "0x4000046")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		// Token: 0x02000392 RID: 914
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000018")]
		public enum unitytls_x509verify_result : uint
		{
			// Token: 0x04000FF0 RID: 4080
			[global::Cpp2ILInjected.Token(Token = "0x4000048")]
			UNITYTLS_X509VERIFY_SUCCESS = 0U,
			// Token: 0x04000FF1 RID: 4081
			[global::Cpp2ILInjected.Token(Token = "0x4000049")]
			UNITYTLS_X509VERIFY_NOT_DONE = 2147483648U,
			// Token: 0x04000FF2 RID: 4082
			[global::Cpp2ILInjected.Token(Token = "0x400004A")]
			UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295U,
			// Token: 0x04000FF3 RID: 4083
			[global::Cpp2ILInjected.Token(Token = "0x400004B")]
			UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1U,
			// Token: 0x04000FF4 RID: 4084
			[global::Cpp2ILInjected.Token(Token = "0x400004C")]
			UNITYTLS_X509VERIFY_FLAG_REVOKED = 2U,
			// Token: 0x04000FF5 RID: 4085
			[global::Cpp2ILInjected.Token(Token = "0x400004D")]
			UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4U,
			// Token: 0x04000FF6 RID: 4086
			[global::Cpp2ILInjected.Token(Token = "0x400004E")]
			UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8U,
			// Token: 0x04000FF7 RID: 4087
			[global::Cpp2ILInjected.Token(Token = "0x400004F")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536U,
			// Token: 0x04000FF8 RID: 4088
			[global::Cpp2ILInjected.Token(Token = "0x4000050")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072U,
			// Token: 0x04000FF9 RID: 4089
			[global::Cpp2ILInjected.Token(Token = "0x4000051")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144U,
			// Token: 0x04000FFA RID: 4090
			[global::Cpp2ILInjected.Token(Token = "0x4000052")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288U,
			// Token: 0x04000FFB RID: 4091
			[global::Cpp2ILInjected.Token(Token = "0x4000053")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576U,
			// Token: 0x04000FFC RID: 4092
			[global::Cpp2ILInjected.Token(Token = "0x4000054")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152U,
			// Token: 0x04000FFD RID: 4093
			[global::Cpp2ILInjected.Token(Token = "0x4000055")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304U,
			// Token: 0x04000FFE RID: 4094
			[global::Cpp2ILInjected.Token(Token = "0x4000056")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608U,
			// Token: 0x04000FFF RID: 4095
			[global::Cpp2ILInjected.Token(Token = "0x4000057")]
			UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728U
		}

		// Token: 0x02000393 RID: 915
		// (Invoke) Token: 0x06001CF7 RID: 7415
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000019")]
		public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x02000394 RID: 916
		[global::Cpp2ILInjected.Token(Token = "0x200001A")]
		public struct unitytls_tlsctx
		{
		}

		// Token: 0x02000395 RID: 917
		[global::Cpp2ILInjected.Token(Token = "0x200001B")]
		public struct unitytls_x509name
		{
		}

		// Token: 0x02000396 RID: 918
		[global::Cpp2ILInjected.Token(Token = "0x200001C")]
		public enum unitytls_ciphersuite : uint
		{
			// Token: 0x04001001 RID: 4097
			[global::Cpp2ILInjected.Token(Token = "0x4000059")]
			UNITYTLS_CIPHERSUITE_INVALID = 16777215U
		}

		// Token: 0x02000397 RID: 919
		[global::Cpp2ILInjected.Token(Token = "0x200001D")]
		public enum unitytls_protocol : uint
		{
			// Token: 0x04001003 RID: 4099
			[global::Cpp2ILInjected.Token(Token = "0x400005B")]
			UNITYTLS_PROTOCOL_TLS_1_0,
			// Token: 0x04001004 RID: 4100
			[global::Cpp2ILInjected.Token(Token = "0x400005C")]
			UNITYTLS_PROTOCOL_TLS_1_1,
			// Token: 0x04001005 RID: 4101
			[global::Cpp2ILInjected.Token(Token = "0x400005D")]
			UNITYTLS_PROTOCOL_TLS_1_2,
			// Token: 0x04001006 RID: 4102
			[global::Cpp2ILInjected.Token(Token = "0x400005E")]
			UNITYTLS_PROTOCOL_INVALID
		}

		// Token: 0x02000398 RID: 920
		[global::Cpp2ILInjected.Token(Token = "0x200001E")]
		public struct unitytls_tlsctx_protocolrange
		{
			// Token: 0x04001007 RID: 4103
			[global::Cpp2ILInjected.Token(Token = "0x400005F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public UnityTls.unitytls_protocol min;

			// Token: 0x04001008 RID: 4104
			[global::Cpp2ILInjected.Token(Token = "0x4000060")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public UnityTls.unitytls_protocol max;
		}

		// Token: 0x02000399 RID: 921
		// (Invoke) Token: 0x06001CF9 RID: 7417
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200001F")]
		public unsafe delegate IntPtr unitytls_tlsctx_write_callback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x0200039A RID: 922
		// (Invoke) Token: 0x06001CFB RID: 7419
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		public unsafe delegate IntPtr unitytls_tlsctx_read_callback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x0200039B RID: 923
		// (Invoke) Token: 0x06001CFD RID: 7421
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000021")]
		public unsafe delegate void unitytls_tlsctx_trace_callback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen);

		// Token: 0x0200039C RID: 924
		// (Invoke) Token: 0x06001CFF RID: 7423
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000022")]
		public unsafe delegate void unitytls_tlsctx_certificate_callback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x0200039D RID: 925
		// (Invoke) Token: 0x06001D01 RID: 7425
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000023")]
		public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_tlsctx_x509verify_callback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x0200039E RID: 926
		[global::Cpp2ILInjected.Token(Token = "0x2000024")]
		public struct unitytls_tlsctx_callbacks
		{
			// Token: 0x04001009 RID: 4105
			[global::Cpp2ILInjected.Token(Token = "0x4000061")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public UnityTls.unitytls_tlsctx_read_callback read;

			// Token: 0x0400100A RID: 4106
			[global::Cpp2ILInjected.Token(Token = "0x4000062")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public UnityTls.unitytls_tlsctx_write_callback write;

			// Token: 0x0400100B RID: 4107
			[global::Cpp2ILInjected.Token(Token = "0x4000063")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public unsafe void* data;
		}

		// Token: 0x0200039F RID: 927
		[global::Cpp2ILInjected.Token(Token = "0x2000025")]
		[StructLayout(0)]
		public class unitytls_interface_struct
		{
			// Token: 0x06001D02 RID: 7426 RVA: 0x00007FFA File Offset: 0x000061FA
			[global::Cpp2ILInjected.Token(Token = "0x600004C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D421E0", Offset = "0x1D421E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public unitytls_interface_struct()
			{
				throw null;
			}

			// Token: 0x0400100C RID: 4108
			[global::Cpp2ILInjected.Token(Token = "0x4000064")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly ulong UNITYTLS_INVALID_HANDLE;

			// Token: 0x0400100D RID: 4109
			[global::Cpp2ILInjected.Token(Token = "0x4000065")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;

			// Token: 0x0400100E RID: 4110
			[global::Cpp2ILInjected.Token(Token = "0x4000066")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create;

			// Token: 0x0400100F RID: 4111
			[global::Cpp2ILInjected.Token(Token = "0x4000067")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error;

			// Token: 0x04001010 RID: 4112
			[global::Cpp2ILInjected.Token(Token = "0x4000068")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref;

			// Token: 0x04001011 RID: 4113
			[global::Cpp2ILInjected.Token(Token = "0x4000069")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der;

			// Token: 0x04001012 RID: 4114
			[global::Cpp2ILInjected.Token(Token = "0x400006A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem;

			// Token: 0x04001013 RID: 4115
			[global::Cpp2ILInjected.Token(Token = "0x400006B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free;

			// Token: 0x04001014 RID: 4116
			[global::Cpp2ILInjected.Token(Token = "0x400006C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der;

			// Token: 0x04001015 RID: 4117
			[global::Cpp2ILInjected.Token(Token = "0x400006D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref;

			// Token: 0x04001016 RID: 4118
			[global::Cpp2ILInjected.Token(Token = "0x400006E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509;

			// Token: 0x04001017 RID: 4119
			[global::Cpp2ILInjected.Token(Token = "0x400006F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create;

			// Token: 0x04001018 RID: 4120
			[global::Cpp2ILInjected.Token(Token = "0x4000070")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append;

			// Token: 0x04001019 RID: 4121
			[global::Cpp2ILInjected.Token(Token = "0x4000071")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der;

			// Token: 0x0400101A RID: 4122
			[global::Cpp2ILInjected.Token(Token = "0x4000072")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem;

			// Token: 0x0400101B RID: 4123
			[global::Cpp2ILInjected.Token(Token = "0x4000073")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free;

			// Token: 0x0400101C RID: 4124
			[global::Cpp2ILInjected.Token(Token = "0x4000074")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			public UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca;

			// Token: 0x0400101D RID: 4125
			[global::Cpp2ILInjected.Token(Token = "0x4000075")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			public UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca;

			// Token: 0x0400101E RID: 4126
			[global::Cpp2ILInjected.Token(Token = "0x4000076")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server;

			// Token: 0x0400101F RID: 4127
			[global::Cpp2ILInjected.Token(Token = "0x4000077")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client;

			// Token: 0x04001020 RID: 4128
			[global::Cpp2ILInjected.Token(Token = "0x4000078")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication;

			// Token: 0x04001021 RID: 4129
			[global::Cpp2ILInjected.Token(Token = "0x4000079")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback;

			// Token: 0x04001022 RID: 4130
			[global::Cpp2ILInjected.Token(Token = "0x400007A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback;

			// Token: 0x04001023 RID: 4131
			[global::Cpp2ILInjected.Token(Token = "0x400007B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback;

			// Token: 0x04001024 RID: 4132
			[global::Cpp2ILInjected.Token(Token = "0x400007C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites;

			// Token: 0x04001025 RID: 4133
			[global::Cpp2ILInjected.Token(Token = "0x400007D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite;

			// Token: 0x04001026 RID: 4134
			[global::Cpp2ILInjected.Token(Token = "0x400007E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol;

			// Token: 0x04001027 RID: 4135
			[global::Cpp2ILInjected.Token(Token = "0x400007F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake;

			// Token: 0x04001028 RID: 4136
			[global::Cpp2ILInjected.Token(Token = "0x4000080")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read;

			// Token: 0x04001029 RID: 4137
			[global::Cpp2ILInjected.Token(Token = "0x4000081")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write;

			// Token: 0x0400102A RID: 4138
			[global::Cpp2ILInjected.Token(Token = "0x4000082")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close;

			// Token: 0x0400102B RID: 4139
			[global::Cpp2ILInjected.Token(Token = "0x4000083")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free;

			// Token: 0x0400102C RID: 4140
			[global::Cpp2ILInjected.Token(Token = "0x4000084")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
			public UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes;

			// Token: 0x02000498 RID: 1176
			// (Invoke) Token: 0x06001FCA RID: 8138
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000026")]
			public delegate UnityTls.unitytls_errorstate unitytls_errorstate_create_t();

			// Token: 0x02000499 RID: 1177
			// (Invoke) Token: 0x06001FCC RID: 8140
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000027")]
			public unsafe delegate void unitytls_errorstate_raise_error_t(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode);

			// Token: 0x0200049A RID: 1178
			// (Invoke) Token: 0x06001FCE RID: 8142
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000028")]
			public unsafe delegate UnityTls.unitytls_key_ref unitytls_key_get_ref_t(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200049B RID: 1179
			// (Invoke) Token: 0x06001FD0 RID: 8144
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000029")]
			public unsafe delegate UnityTls.unitytls_key* unitytls_key_parse_der_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200049C RID: 1180
			// (Invoke) Token: 0x06001FD2 RID: 8146
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002A")]
			public unsafe delegate UnityTls.unitytls_key* unitytls_key_parse_pem_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200049D RID: 1181
			// (Invoke) Token: 0x06001FD4 RID: 8148
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002B")]
			public unsafe delegate void unitytls_key_free_t(UnityTls.unitytls_key* key);

			// Token: 0x0200049E RID: 1182
			// (Invoke) Token: 0x06001FD6 RID: 8150
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002C")]
			public unsafe delegate IntPtr unitytls_x509_export_der_t(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200049F RID: 1183
			// (Invoke) Token: 0x06001FD8 RID: 8152
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002D")]
			public unsafe delegate UnityTls.unitytls_x509list_ref unitytls_x509list_get_ref_t(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A0 RID: 1184
			// (Invoke) Token: 0x06001FDA RID: 8154
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002E")]
			public unsafe delegate UnityTls.unitytls_x509_ref unitytls_x509list_get_x509_t(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A1 RID: 1185
			// (Invoke) Token: 0x06001FDC RID: 8156
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200002F")]
			public unsafe delegate UnityTls.unitytls_x509list* unitytls_x509list_create_t(UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A2 RID: 1186
			// (Invoke) Token: 0x06001FDE RID: 8158
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000030")]
			public unsafe delegate void unitytls_x509list_append_t(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A3 RID: 1187
			// (Invoke) Token: 0x06001FE0 RID: 8160
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000031")]
			public unsafe delegate void unitytls_x509list_append_der_t(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A4 RID: 1188
			// (Invoke) Token: 0x06001FE2 RID: 8162
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000032")]
			public unsafe delegate void unitytls_x509list_free_t(UnityTls.unitytls_x509list* list);

			// Token: 0x020004A5 RID: 1189
			// (Invoke) Token: 0x06001FE4 RID: 8164
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000033")]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_default_ca_t(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A6 RID: 1190
			// (Invoke) Token: 0x06001FE6 RID: 8166
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000034")]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_explicit_ca_t(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A7 RID: 1191
			// (Invoke) Token: 0x06001FE8 RID: 8168
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000035")]
			public unsafe delegate UnityTls.unitytls_tlsctx* unitytls_tlsctx_create_server_t(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A8 RID: 1192
			// (Invoke) Token: 0x06001FEA RID: 8170
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000036")]
			public unsafe delegate UnityTls.unitytls_tlsctx* unitytls_tlsctx_create_client_t(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004A9 RID: 1193
			// (Invoke) Token: 0x06001FEC RID: 8172
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000037")]
			public unsafe delegate void unitytls_tlsctx_server_require_client_authentication_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004AA RID: 1194
			// (Invoke) Token: 0x06001FEE RID: 8174
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000038")]
			public unsafe delegate void unitytls_tlsctx_set_certificate_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004AB RID: 1195
			// (Invoke) Token: 0x06001FF0 RID: 8176
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000039")]
			public unsafe delegate void unitytls_tlsctx_set_trace_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004AC RID: 1196
			// (Invoke) Token: 0x06001FF2 RID: 8178
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003A")]
			public unsafe delegate void unitytls_tlsctx_set_x509verify_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004AD RID: 1197
			// (Invoke) Token: 0x06001FF4 RID: 8180
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003B")]
			public unsafe delegate void unitytls_tlsctx_set_supported_ciphersuites_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004AE RID: 1198
			// (Invoke) Token: 0x06001FF6 RID: 8182
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003C")]
			public unsafe delegate UnityTls.unitytls_ciphersuite unitytls_tlsctx_get_ciphersuite_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004AF RID: 1199
			// (Invoke) Token: 0x06001FF8 RID: 8184
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003D")]
			public unsafe delegate UnityTls.unitytls_protocol unitytls_tlsctx_get_protocol_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004B0 RID: 1200
			// (Invoke) Token: 0x06001FFA RID: 8186
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003E")]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_tlsctx_process_handshake_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004B1 RID: 1201
			// (Invoke) Token: 0x06001FFC RID: 8188
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x200003F")]
			public unsafe delegate IntPtr unitytls_tlsctx_read_t(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004B2 RID: 1202
			// (Invoke) Token: 0x06001FFE RID: 8190
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000040")]
			public unsafe delegate IntPtr unitytls_tlsctx_write_t(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004B3 RID: 1203
			// (Invoke) Token: 0x06002000 RID: 8192
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000041")]
			public unsafe delegate void unitytls_tlsctx_notify_close_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x020004B4 RID: 1204
			// (Invoke) Token: 0x06002002 RID: 8194
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000042")]
			public unsafe delegate void unitytls_tlsctx_free_t(UnityTls.unitytls_tlsctx* ctx);

			// Token: 0x020004B5 RID: 1205
			// (Invoke) Token: 0x06002004 RID: 8196
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[global::Cpp2ILInjected.Token(Token = "0x2000043")]
			public unsafe delegate void unitytls_random_generate_bytes_t(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);
		}
	}
}
