using System;
using System.Buffers;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x020003A5 RID: 933
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200044F")]
	public struct GCHandle
	{
		// Token: 0x06001F53 RID: 8019 RVA: 0x00019CE5 File Offset: 0x00017EE5
		[global::Cpp2ILInjected.Token(Token = "0x6002194")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70ABC", Offset = "0x1B70ABC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private GCHandle(global::System.IntPtr h)
		{
			throw null;
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00019CE8 File Offset: 0x00017EE8
		[global::Cpp2ILInjected.Token(Token = "0x6002195")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70AC4", Offset = "0x1B70AC4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private GCHandle(object obj)
		{
			throw null;
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00019CEB File Offset: 0x00017EEB
		[global::Cpp2ILInjected.Token(Token = "0x6002196")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70B2C", Offset = "0x1B70B2C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal GCHandle(object value, GCHandleType type)
		{
			throw null;
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00019CEE File Offset: 0x00017EEE
		[global::Cpp2ILInjected.Token(Token = "0x1700045C")]
		public bool IsAllocated
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002197")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B70BA4", Offset = "0x1B70BA4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = "get_Target", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = "TryGetTarget", MemberParameters = new object[] { "T&" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GCHandle), Member = "get_Target", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.PinnedBufferMemoryStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
			{
				"System.Char*",
				typeof(int),
				typeof(int),
				"System.UriComponents"
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new object[] { "System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new object[] { "System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00019CF1 File Offset: 0x00017EF1
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00019CF4 File Offset: 0x00017EF4
		[global::Cpp2ILInjected.Token(Token = "0x1700045D")]
		public object Target
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002198")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B70BF8", Offset = "0x1B70BF8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = "get_Target", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = "TryGetTarget", MemberParameters = new object[] { "T&" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = "InvocationEntry", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "WriteCallback", MemberParameters = new object[]
			{
				"System.Void*",
				"System.Byte*",
				typeof(global::System.IntPtr),
				"unitytls_errorstate*"
			}, ReturnType = typeof(global::System.IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ReadCallback", MemberParameters = new object[]
			{
				"System.Void*",
				"System.Byte*",
				typeof(global::System.IntPtr),
				"unitytls_errorstate*"
			}, ReturnType = typeof(global::System.IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "VerifyCallback", MemberParameters = new object[] { "System.Void*", "Mono.Unity.UnityTls.unitytls_x509list_ref", "unitytls_errorstate*" }, ReturnType = "Mono.Unity.UnityTls.unitytls_x509verify_result")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "CertificateCallback", MemberParameters = new object[]
			{
				"System.Void*",
				"unitytls_tlsctx*",
				"System.Byte*",
				typeof(global::System.IntPtr),
				"unitytls_x509name*",
				typeof(global::System.IntPtr),
				"unitytls_x509list_ref*",
				"unitytls_key_ref*",
				"unitytls_errorstate*"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "UnmanagedRead", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(int),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "UnmanagedWrite", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(int),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002199")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B70C60", Offset = "0x1B70C60", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = "set_Target", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = "SetTarget", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00019CF7 File Offset: 0x00017EF7
		[global::Cpp2ILInjected.Token(Token = "0x600219A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70C88", Offset = "0x1B70C88", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AutoPinner", Member = "op_Implicit", MemberParameters = new object[] { "AutoPinner" }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.UriComponents"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "Copy", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			"Unity.Collections.NativeArray`1<T>",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public global::System.IntPtr AddrOfPinnedObject()
		{
			throw null;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00019CFA File Offset: 0x00017EFA
		[global::Cpp2ILInjected.Token(Token = "0x600219B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70D6C", Offset = "0x1B70D6C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = "Post", MemberParameters = new object[]
		{
			typeof(global::System.Threading.SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = ".ctor", MemberParameters = new object[] { "Mono.Net.Security.MobileAuthenticatedStream", "Mono.Net.Security.MonoSslAuthenticationOptions" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.TimerQueue", Member = "CreateTimer", MemberParameters = new object[]
		{
			"System.Net.TimerThread.Callback",
			typeof(object)
		}, ReturnType = "System.Net.TimerThread.Timer")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			"System.IO.Compression.CompressionMode",
			typeof(bool)
		}, ReturnType = "System.IO.Compression.DeflateStreamNative")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidReflection", Member = "SetNativeExceptionOnProxy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidJNIHelper", Member = "CreateJavaProxy", MemberParameters = new object[] { "UnityEngine.AndroidJavaProxy" }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static GCHandle Alloc(object value)
		{
			throw null;
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00019CFD File Offset: 0x00017EFD
		[global::Cpp2ILInjected.Token(Token = "0x600219C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70DC0", Offset = "0x1B70DC0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AutoPinner", Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Func<object, bool>),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = "Setup", MemberParameters = new object[]
		{
			typeof(global::System.Func<object, bool>),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Memory<>), Member = "Pin", ReturnType = typeof(global::System.Buffers.MemoryHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = "AllocateHandle", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.PinnedBufferMemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.UriComponents"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new object[] { "System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new object[] { "System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "Copy", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			"Unity.Collections.NativeArray`1<T>",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static GCHandle Alloc(object value, GCHandleType type)
		{
			throw null;
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00019D00 File Offset: 0x00017F00
		[global::Cpp2ILInjected.Token(Token = "0x600219D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70E28", Offset = "0x1B70E28", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AutoPinner", Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = "InvocationEntry", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.PinnedBufferMemoryStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.UriComponents"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.TimerQueue", Member = "Fire", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new object[] { "System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new object[] { "System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "Copy", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			"Unity.Collections.NativeArray`1<T>",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidJNIHelper", Member = "CreateJavaProxy", MemberParameters = new object[] { "UnityEngine.AndroidJavaProxy" }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Free()
		{
			throw null;
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00019D03 File Offset: 0x00017F03
		[global::Cpp2ILInjected.Token(Token = "0x600219E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70F04", Offset = "0x1B70F04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static explicit operator global::System.IntPtr(GCHandle value)
		{
			throw null;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00019D06 File Offset: 0x00017F06
		[global::Cpp2ILInjected.Token(Token = "0x600219F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70F08", Offset = "0x1B70F08", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GCHandle), Member = "FromIntPtr", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "WriteCallback", MemberParameters = new object[]
		{
			"System.Void*",
			"System.Byte*",
			typeof(global::System.IntPtr),
			"unitytls_errorstate*"
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ReadCallback", MemberParameters = new object[]
		{
			"System.Void*",
			"System.Byte*",
			typeof(global::System.IntPtr),
			"unitytls_errorstate*"
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "VerifyCallback", MemberParameters = new object[] { "System.Void*", "Mono.Unity.UnityTls.unitytls_x509list_ref", "unitytls_errorstate*" }, ReturnType = "Mono.Unity.UnityTls.unitytls_x509verify_result")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "CertificateCallback", MemberParameters = new object[]
		{
			"System.Void*",
			"unitytls_tlsctx*",
			"System.Byte*",
			typeof(global::System.IntPtr),
			"unitytls_x509name*",
			typeof(global::System.IntPtr),
			"unitytls_x509list_ref*",
			"unitytls_key_ref*",
			"unitytls_errorstate*"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.TimerQueue", Member = "Fire", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static explicit operator GCHandle(global::System.IntPtr value)
		{
			throw null;
		}

		// Token: 0x06001F5F RID: 8031
		[global::Cpp2ILInjected.Token(Token = "0x60021A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70FF0", Offset = "0x1B70FF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool CheckCurrentDomain(global::System.IntPtr handle);

		// Token: 0x06001F60 RID: 8032
		[global::Cpp2ILInjected.Token(Token = "0x60021A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70C5C", Offset = "0x1B70C5C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern object GetTarget(global::System.IntPtr handle);

		// Token: 0x06001F61 RID: 8033
		[global::Cpp2ILInjected.Token(Token = "0x60021A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70BA0", Offset = "0x1B70BA0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.IntPtr GetTargetHandle(object obj, global::System.IntPtr handle, GCHandleType type);

		// Token: 0x06001F62 RID: 8034
		[global::Cpp2ILInjected.Token(Token = "0x60021A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70F00", Offset = "0x1B70F00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void FreeHandle(global::System.IntPtr handle);

		// Token: 0x06001F63 RID: 8035
		[global::Cpp2ILInjected.Token(Token = "0x60021A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70D68", Offset = "0x1B70D68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.IntPtr GetAddrOfPinnedObject(global::System.IntPtr handle);

		// Token: 0x06001F64 RID: 8036 RVA: 0x00019D09 File Offset: 0x00017F09
		[global::Cpp2ILInjected.Token(Token = "0x60021A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70FF4", Offset = "0x1B70FF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		public static bool operator ==(GCHandle a, GCHandle b)
		{
			throw null;
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00019D0C File Offset: 0x00017F0C
		[global::Cpp2ILInjected.Token(Token = "0x60021A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70FFC", Offset = "0x1B70FFC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00019D0F File Offset: 0x00017F0F
		[global::Cpp2ILInjected.Token(Token = "0x60021A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7107C", Offset = "0x1B7107C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00019D12 File Offset: 0x00017F12
		[global::Cpp2ILInjected.Token(Token = "0x60021A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71084", Offset = "0x1B71084", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = "InvocationEntry", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "UnmanagedRead", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "UnmanagedWrite", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(GCHandle))]
		public static GCHandle FromIntPtr(global::System.IntPtr value)
		{
			throw null;
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00019D15 File Offset: 0x00017F15
		[global::Cpp2ILInjected.Token(Token = "0x60021A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71088", Offset = "0x1B71088", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = "Post", MemberParameters = new object[]
		{
			typeof(global::System.Threading.SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			"System.IO.Compression.CompressionMode",
			typeof(bool)
		}, ReturnType = "System.IO.Compression.DeflateStreamNative")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidReflection", Member = "SetNativeExceptionOnProxy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidJNIHelper", Member = "CreateJavaProxy", MemberParameters = new object[] { "UnityEngine.AndroidJavaProxy" }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static global::System.IntPtr ToIntPtr(GCHandle value)
		{
			throw null;
		}

		// Token: 0x04000F8E RID: 3982
		[global::Cpp2ILInjected.Token(Token = "0x4001283")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.IntPtr handle;
	}
}
