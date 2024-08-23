using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x02000206 RID: 518
	[global::Cpp2ILInjected.Token(Token = "0x20002EB")]
	public class Socket : IDisposable
	{
		// Token: 0x0600112E RID: 4398 RVA: 0x00005F81 File Offset: 0x00004181
		[global::Cpp2ILInjected.Token(Token = "0x6001327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E24048", Offset = "0x1E24048", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "Reserve", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncEventArgs), Member = "SetBuffer", MemberParameters = new object[] { typeof(Memory<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ReceiveAsync", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ReceiveAsyncApm", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(SocketFlags)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new object[] { "System.ExceptionArgument" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00005F84 File Offset: 0x00004184
		[global::Cpp2ILInjected.Token(Token = "0x6001328")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E24FD0", Offset = "0x1E24FD0", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(SocketFlags),
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Memory`1<T>" }, ReturnType = "System.ReadOnlyMemory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple[]), Member = "Create", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(Memory<byte>),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(object),
			typeof(Memory<byte>),
			typeof(object)
		}, ReturnType = "System.Tuple`3<T1, T2, T3>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
		{
			throw null;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00005F87 File Offset: 0x00004187
		[global::Cpp2ILInjected.Token(Token = "0x6001329")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2485C", Offset = "0x1E2485C", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "Reserve", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal), Member = "AsMemory", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>" }, ReturnType = "System.Memory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncEventArgs), Member = "SetBuffer", MemberParameters = new object[] { typeof(Memory<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "SendAsyncForNetworkStream", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SendAsyncApm", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(SocketFlags)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new object[] { "System.ExceptionArgument" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00005F8A File Offset: 0x0000418A
		[global::Cpp2ILInjected.Token(Token = "0x600132A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E25378", Offset = "0x1E25378", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(SocketFlags),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyMemory<>), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple[]), Member = "Create", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = "System.Tuple`2<T1, T2>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
		{
			throw null;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00005F8D File Offset: 0x0000418D
		[global::Cpp2ILInjected.Token(Token = "0x600132B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E25778", Offset = "0x1E25778", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SocketAsyncEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.TaskSocketAsyncEventArgs<object>), Member = "GetCompletionResponsibility", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "GetException", MemberParameters = new object[]
		{
			typeof(SocketError),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			throw null;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00005F90 File Offset: 0x00004190
		[global::Cpp2ILInjected.Token(Token = "0x600132C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E259AC", Offset = "0x1E259AC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_1", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SocketAsyncEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_2", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SocketAsyncEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.TaskSocketAsyncEventArgs<>), Member = "GetCompletionResponsibility", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "GetException", MemberParameters = new object[]
		{
			typeof(SocketError),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			throw null;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00005F93 File Offset: 0x00004193
		[global::Cpp2ILInjected.Token(Token = "0x600132D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E258CC", Offset = "0x1E258CC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "CompleteAccept", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(Socket.TaskSocketAsyncEventArgs<Socket>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "CompleteSendReceive", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(Socket.Int32TaskSocketAsyncEventArgs),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
		{
			throw null;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00005F96 File Offset: 0x00004196
		[global::Cpp2ILInjected.Token(Token = "0x600132E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E25AFC", Offset = "0x1E25AFC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			throw null;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00005F99 File Offset: 0x00004199
		[global::Cpp2ILInjected.Token(Token = "0x600132F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E25898", Offset = "0x1E25898", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			throw null;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00005F9C File Offset: 0x0000419C
		[global::Cpp2ILInjected.Token(Token = "0x6001330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E25B3C", Offset = "0x1E25B3C", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpDataSocket", MemberParameters = new object[]
		{
			typeof(FtpWebRequest),
			typeof(Socket)
		}, ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListener),
			typeof(IPAddress),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "createClientSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetIPProtectionLevel", MemberParameters = new object[] { typeof(IPProtectionLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SocketDefaults", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		{
			throw null;
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00005F9F File Offset: 0x0000419F
		[global::Cpp2ILInjected.Token(Token = "0x1700046F")]
		public static bool OSSupportsIPv4
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001331")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E26188", Offset = "0x1E26188", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string[]),
				typeof(string[])
			}, ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00005FA2 File Offset: 0x000041A2
		[global::Cpp2ILInjected.Token(Token = "0x17000470")]
		public static bool OSSupportsIPv6
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001332")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E261EC", Offset = "0x1E261EC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string[]),
				typeof(string[])
			}, ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00005FA5 File Offset: 0x000041A5
		[global::Cpp2ILInjected.Token(Token = "0x17000471")]
		public IntPtr Handle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001333")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E26250", Offset = "0x1E26250", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x00005FA8 File Offset: 0x000041A8
		[global::Cpp2ILInjected.Token(Token = "0x17000472")]
		public AddressFamily AddressFamily
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001334")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2625C", Offset = "0x1E2625C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x00005FAB File Offset: 0x000041AB
		[global::Cpp2ILInjected.Token(Token = "0x17000473")]
		public SocketType SocketType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001335")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E26264", Offset = "0x1E26264", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x00005FAE File Offset: 0x000041AE
		[global::Cpp2ILInjected.Token(Token = "0x17000474")]
		public ProtocolType ProtocolType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001336")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2626C", Offset = "0x1E2626C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x00005FB1 File Offset: 0x000041B1
		[global::Cpp2ILInjected.Token(Token = "0x17000475")]
		public bool ExclusiveAddressUse
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001337")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E26274", Offset = "0x1E26274", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x00005FB4 File Offset: 0x000041B4
		[global::Cpp2ILInjected.Token(Token = "0x17000476")]
		public int SendTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001338")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E26408", Offset = "0x1E26408", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x00005FB7 File Offset: 0x000041B7
		[global::Cpp2ILInjected.Token(Token = "0x17000477")]
		public bool DontFragment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001339")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E26470", Offset = "0x1E26470", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SocketDefaults", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00005FBA File Offset: 0x000041BA
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x00005FBD File Offset: 0x000041BD
		[global::Cpp2ILInjected.Token(Token = "0x17000478")]
		public bool DualMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600133A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E264EC", Offset = "0x1E264EC", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_IsDualMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "CanTryAddressFamily", MemberParameters = new object[] { typeof(AddressFamily) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(IPEndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600133B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E265C4", Offset = "0x1E265C4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SocketDefaults", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TcpListener))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x00005FC0 File Offset: 0x000041C0
		[global::Cpp2ILInjected.Token(Token = "0x17000479")]
		private bool IsDualMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600133C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E26644", Offset = "0x1E26644", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_DualMode", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00005FC3 File Offset: 0x000041C3
		[global::Cpp2ILInjected.Token(Token = "0x600133D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2665C", Offset = "0x1E2665C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_DualMode", ReturnType = typeof(bool))]
		internal bool CanTryAddressFamily(AddressFamily family)
		{
			throw null;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00005FC6 File Offset: 0x000041C6
		[global::Cpp2ILInjected.Token(Token = "0x600133E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E26694", Offset = "0x1E26694", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_16", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(IList<ArraySegment<byte>>),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			throw null;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00005FC9 File Offset: 0x000041C9
		[global::Cpp2ILInjected.Token(Token = "0x600133F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E22BF8", Offset = "0x1E22BF8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(IPEndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			throw null;
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00005FCC File Offset: 0x000041CC
		[global::Cpp2ILInjected.Token(Token = "0x6001340")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2250C", Offset = "0x1E2250C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			throw null;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00005FCF File Offset: 0x000041CF
		[global::Cpp2ILInjected.Token(Token = "0x6001341")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E26ECC", Offset = "0x1E26ECC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_12", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(IList<ArraySegment<byte>>),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			throw null;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00005FD2 File Offset: 0x000041D2
		[global::Cpp2ILInjected.Token(Token = "0x6001342")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E27458", Offset = "0x1E27458", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "KeepAliveSetup", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			throw null;
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00005FD5 File Offset: 0x000041D5
		[global::Cpp2ILInjected.Token(Token = "0x6001343")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E25FD0", Offset = "0x1E25FD0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
		{
			typeof(SocketOptionLevel),
			typeof(SocketOptionName),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void SetIPProtectionLevel(IPProtectionLevel level)
		{
			throw null;
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00005FD8 File Offset: 0x000041D8
		[global::Cpp2ILInjected.Token(Token = "0x6001344")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E23A10", Offset = "0x1E23A10", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendAsyncApm", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(SocketFlags)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00005FDB File Offset: 0x000041DB
		[global::Cpp2ILInjected.Token(Token = "0x6001345")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E23C6C", Offset = "0x1E23C6C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "EndWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<SendAsyncApm>b__23_0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<SendAsyncApm>b__23_1", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_15", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int EndSend(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00005FDE File Offset: 0x000041DE
		[global::Cpp2ILInjected.Token(Token = "0x6001346")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E23474", Offset = "0x1E23474", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveAsyncApm", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(SocketFlags)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00005FE1 File Offset: 0x000041E1
		[global::Cpp2ILInjected.Token(Token = "0x6001347")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E236D0", Offset = "0x1E236D0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<ReceiveAsyncApm>b__15_0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_10", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int EndReceive(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00005FE4 File Offset: 0x000041E4
		[global::Cpp2ILInjected.Token(Token = "0x1700047A")]
		private static object InternalSyncObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001348")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E27B24", Offset = "0x1E27B24", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00005FE7 File Offset: 0x000041E7
		[global::Cpp2ILInjected.Token(Token = "0x1700047B")]
		internal bool CleanedUp
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001349")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E27BF0", Offset = "0x1E27BF0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c__DisplayClass355_0), Member = "<QueueIOSelectorJob>b__0", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00005FEA File Offset: 0x000041EA
		[global::Cpp2ILInjected.Token(Token = "0x600134A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E25D7C", Offset = "0x1E25D7C", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_OSSupportsIPv4", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_OSSupportsIPv6", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType),
			typeof(SafeSocketHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "IsProtocolSupported", MemberParameters = new object[] { typeof(NetworkInterfaceComponent) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal static void InitializeSockets()
		{
			throw null;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00005FED File Offset: 0x000041ED
		[global::Cpp2ILInjected.Token(Token = "0x600134B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E27C54", Offset = "0x1E27C54", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Close", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00005FF0 File Offset: 0x000041F0
		[global::Cpp2ILInjected.Token(Token = "0x600134C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E27CC0", Offset = "0x1E27CC0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00005FF3 File Offset: 0x000041F3
		[global::Cpp2ILInjected.Token(Token = "0x600134D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E23060", Offset = "0x1E23060", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "FreeResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Shutdown_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketShutdown),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void InternalShutdown(SocketShutdown how)
		{
			throw null;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00005FF6 File Offset: 0x000041F6
		[global::Cpp2ILInjected.Token(Token = "0x600134E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E24E14", Offset = "0x1E24E14", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "SetSocketTimeoutOption", MemberParameters = new object[]
		{
			typeof(SocketShutdown),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketOptionLevel),
			typeof(SocketOptionName),
			typeof(object),
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
			throw null;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00005FF9 File Offset: 0x000041F9
		[global::Cpp2ILInjected.Token(Token = "0x600134F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E27FA0", Offset = "0x1E27FA0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_3", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
		{
			throw null;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00005FFC File Offset: 0x000041FC
		[global::Cpp2ILInjected.Token(Token = "0x6001350")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E260B4", Offset = "0x1E260B4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_DontFragment", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_DualMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void SocketDefaults()
		{
			throw null;
		}

		// Token: 0x06001158 RID: 4440
		[global::Cpp2ILInjected.Token(Token = "0x6001351")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E25FCC", Offset = "0x1E25FCC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error);

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00005FFF File Offset: 0x000041FF
		[global::Cpp2ILInjected.Token(Token = "0x1700047C")]
		public int Available
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001352")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E22060", Offset = "0x1E22060", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "get_DataAvailable", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Available_internal", MemberParameters = new object[]
			{
				typeof(SafeSocketHandle),
				typeof(ref int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00006002 File Offset: 0x00004202
		[global::Cpp2ILInjected.Token(Token = "0x6001353")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28140", Offset = "0x1E28140", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_Available", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static int Available_internal(SafeSocketHandle safeHandle, out int error)
		{
			throw null;
		}

		// Token: 0x0600115B RID: 4443
		[global::Cpp2ILInjected.Token(Token = "0x6001354")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28250", Offset = "0x1E28250", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int Available_icall(IntPtr socket, out int error);

		// Token: 0x17000455 RID: 1109
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x00006005 File Offset: 0x00004205
		[global::Cpp2ILInjected.Token(Token = "0x1700047D")]
		public bool EnableBroadcast
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001355")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E28254", Offset = "0x1E28254", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "set_EnableBroadcast", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x00006008 File Offset: 0x00004208
		[global::Cpp2ILInjected.Token(Token = "0x1700047E")]
		public bool IsBound
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001356")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E282C8", Offset = "0x1E282C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0000600B File Offset: 0x0000420B
		[global::Cpp2ILInjected.Token(Token = "0x1700047F")]
		public EndPoint LocalEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001357")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E282D0", Offset = "0x1E282D0", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream),
				typeof(ref bool)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "LocalEndPoint_internal", MemberParameters = new object[]
			{
				typeof(SafeSocketHandle),
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(SocketAddress))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0000600E File Offset: 0x0000420E
		[global::Cpp2ILInjected.Token(Token = "0x6001358")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E283B4", Offset = "0x1E283B4", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			throw null;
		}

		// Token: 0x06001160 RID: 4448
		[global::Cpp2ILInjected.Token(Token = "0x6001359")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E284CC", Offset = "0x1E284CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error);

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00006011 File Offset: 0x00004211
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x00006014 File Offset: 0x00004214
		[global::Cpp2ILInjected.Token(Token = "0x17000480")]
		public bool Blocking
		{
			[global::Cpp2ILInjected.Token(Token = "0x600135A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E284D0", Offset = "0x1E284D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600135B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E284D8", Offset = "0x1E284D8", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Accept", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Blocking_internal", MemberParameters = new object[]
			{
				typeof(SafeSocketHandle),
				typeof(bool),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00006017 File Offset: 0x00004217
		[global::Cpp2ILInjected.Token(Token = "0x600135C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E285A0", Offset = "0x1E285A0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
		{
			throw null;
		}

		// Token: 0x06001164 RID: 4452
		[global::Cpp2ILInjected.Token(Token = "0x600135D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E286A8", Offset = "0x1E286A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSocketHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void Blocking_icall(IntPtr socket, bool block, out int error);

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0000601A File Offset: 0x0000421A
		[global::Cpp2ILInjected.Token(Token = "0x17000481")]
		public bool Connected
		{
			[global::Cpp2ILInjected.Token(Token = "0x600135E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E286B0", Offset = "0x1E286B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0000601D File Offset: 0x0000421D
		[global::Cpp2ILInjected.Token(Token = "0x17000482")]
		public bool NoDelay
		{
			[global::Cpp2ILInjected.Token(Token = "0x600135F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E28090", Offset = "0x1E28090", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SocketDefaults", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfUdp", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName),
				typeof(int)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x00006020 File Offset: 0x00004220
		[global::Cpp2ILInjected.Token(Token = "0x17000483")]
		public EndPoint RemoteEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001360")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E28708", Offset = "0x1E28708", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "NextConnectionId", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "GetClientAddress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream),
				typeof(ref bool)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStreamWrapper), Member = "get_ServerAddress", ReturnType = typeof(IPAddress))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "get_RemoteEndPoint", ReturnType = typeof(IPEndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "RemoteEndPoint_internal", MemberParameters = new object[]
			{
				typeof(SafeSocketHandle),
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(SocketAddress))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00006023 File Offset: 0x00004223
		[global::Cpp2ILInjected.Token(Token = "0x6001361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E287F4", Offset = "0x1E287F4", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			throw null;
		}

		// Token: 0x06001169 RID: 4457
		[global::Cpp2ILInjected.Token(Token = "0x6001362")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2890C", Offset = "0x1E2890C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error);

		// Token: 0x0600116A RID: 4458 RVA: 0x00006026 File Offset: 0x00004226
		[global::Cpp2ILInjected.Token(Token = "0x6001363")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28910", Offset = "0x1E28910", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "CanReuse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "CheckReusable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Poll_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SelectMode),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new object[]
		{
			typeof(SocketOptionLevel),
			typeof(SocketOptionName)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public bool Poll(int microSeconds, SelectMode mode)
		{
			throw null;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00006029 File Offset: 0x00004229
		[global::Cpp2ILInjected.Token(Token = "0x6001364")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28A9C", Offset = "0x1E28A9C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Poll", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SelectMode)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
		{
			throw null;
		}

		// Token: 0x0600116C RID: 4460
		[global::Cpp2ILInjected.Token(Token = "0x6001365")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28BC4", Offset = "0x1E28BC4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error);

		// Token: 0x0600116D RID: 4461 RVA: 0x0000602C File Offset: 0x0000422C
		[global::Cpp2ILInjected.Token(Token = "0x6001366")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28BC8", Offset = "0x1E28BC8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_4", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_5", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "AcceptTcpClient", ReturnType = typeof(TcpClient))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SafeSocketHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType),
			typeof(SafeSocketHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Socket Accept()
		{
			throw null;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0000602F File Offset: 0x0000422F
		[global::Cpp2ILInjected.Token(Token = "0x6001367")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28E24", Offset = "0x1E28E24", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_4", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_5", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SafeSocketHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void Accept(Socket acceptSocket)
		{
			throw null;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00006032 File Offset: 0x00004232
		[global::Cpp2ILInjected.Token(Token = "0x6001368")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28F30", Offset = "0x1E28F30", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(SocketAsyncEventArgs),
			typeof(ref Socket)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new object[]
		{
			typeof(SocketAsyncEventArgs),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public bool AcceptAsync(SocketAsyncEventArgs e)
		{
			throw null;
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00006035 File Offset: 0x00004235
		[global::Cpp2ILInjected.Token(Token = "0x6001369")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E292F0", Offset = "0x1E292F0", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public IAsyncResult BeginAccept(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00006038 File Offset: 0x00004238
		[global::Cpp2ILInjected.Token(Token = "0x600136A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2944C", Offset = "0x1E2944C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_3", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new object[]
		{
			typeof(ref byte[]),
			typeof(ref int),
			typeof(IAsyncResult)
		}, ReturnType = typeof(Socket))]
		public Socket EndAccept(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0000603B File Offset: 0x0000423B
		[global::Cpp2ILInjected.Token(Token = "0x600136B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29474", Offset = "0x1E29474", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(SocketAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0000603E File Offset: 0x0000423E
		[global::Cpp2ILInjected.Token(Token = "0x600136C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E28CEC", Offset = "0x1E28CEC", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Accept", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
		{
			throw null;
		}

		// Token: 0x06001174 RID: 4468
		[global::Cpp2ILInjected.Token(Token = "0x600136D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29694", Offset = "0x1E29694", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern IntPtr Accept_icall(IntPtr sock, out int error, bool blocking);

		// Token: 0x06001175 RID: 4469 RVA: 0x00006041 File Offset: 0x00004241
		[global::Cpp2ILInjected.Token(Token = "0x600136E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2969C", Offset = "0x1E2969C", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListener),
			typeof(IPAddress),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "CallEndPointDelegate", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(IPEndPoint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(AddressFamily)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Bind_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketAddress),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Bind(EndPoint localEP)
		{
			throw null;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00006044 File Offset: 0x00004244
		[global::Cpp2ILInjected.Token(Token = "0x600136F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E298B8", Offset = "0x1E298B8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Bind", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
		{
			throw null;
		}

		// Token: 0x06001177 RID: 4471
		[global::Cpp2ILInjected.Token(Token = "0x6001370")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E299C0", Offset = "0x1E299C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Bind_icall(IntPtr sock, SocketAddress sa, out int error);

		// Token: 0x06001178 RID: 4472 RVA: 0x00006047 File Offset: 0x00004247
		[global::Cpp2ILInjected.Token(Token = "0x6001371")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E299C4", Offset = "0x1E299C4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListener),
			typeof(IPAddress),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Listen_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Listen(int backlog)
		{
			throw null;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0000604A File Offset: 0x0000424A
		[global::Cpp2ILInjected.Token(Token = "0x6001372")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29AAC", Offset = "0x1E29AAC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
		{
			throw null;
		}

		// Token: 0x0600117A RID: 4474
		[global::Cpp2ILInjected.Token(Token = "0x6001373")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29BB4", Offset = "0x1E29BB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Listen_icall(IntPtr sock, int backlog, out int error);

		// Token: 0x0600117B RID: 4475 RVA: 0x0000604D File Offset: 0x0000424D
		[global::Cpp2ILInjected.Token(Token = "0x6001374")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29BB8", Offset = "0x1E29BB8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Connect(IPAddress address, int port)
		{
			throw null;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00006050 File Offset: 0x00004250
		[global::Cpp2ILInjected.Token(Token = "0x6001375")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29C2C", Offset = "0x1E29C2C", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Connect_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Connect(EndPoint remoteEP)
		{
			throw null;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00006053 File Offset: 0x00004253
		[global::Cpp2ILInjected.Token(Token = "0x6001376")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2A060", Offset = "0x1E2A060", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "BeginConnect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.<>c__DisplayClass240_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostAddressesAsync", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Task<IPAddress[]>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(Action<Task<object>>),
			typeof(TaskScheduler)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00006056 File Offset: 0x00004256
		[global::Cpp2ILInjected.Token(Token = "0x6001377")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2A344", Offset = "0x1E2A344", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<>c", Member = "<Connect>b__16_0", MemberParameters = new object[]
		{
			typeof(IPEndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00006059 File Offset: 0x00004259
		[global::Cpp2ILInjected.Token(Token = "0x6001378")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2A880", Offset = "0x1E2A880", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_7", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c__DisplayClass240_0), Member = "<BeginConnect>b__0", MemberParameters = new object[] { typeof(Task<IPAddress[]>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_DualMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static bool BeginMConnect(SocketAsyncResult sockares)
		{
			throw null;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0000605C File Offset: 0x0000425C
		[global::Cpp2ILInjected.Token(Token = "0x6001379")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2A474", Offset = "0x1E2A474", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new object[]
		{
			typeof(EndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_DualMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Connect_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private static bool BeginSConnect(SocketAsyncResult sockares)
		{
			throw null;
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0000605F File Offset: 0x0000425F
		[global::Cpp2ILInjected.Token(Token = "0x600137A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2AA60", Offset = "0x1E2AA60", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "ConnectCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<>c", Member = "<Connect>b__16_1", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_6", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "EndConnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(SocketAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void EndConnect(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00006062 File Offset: 0x00004262
		[global::Cpp2ILInjected.Token(Token = "0x600137B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29F58", Offset = "0x1E29F58", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Connect", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
		{
			throw null;
		}

		// Token: 0x06001183 RID: 4483
		[global::Cpp2ILInjected.Token(Token = "0x600137C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2AB04", Offset = "0x1E2AB04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking);

		// Token: 0x06001184 RID: 4484 RVA: 0x00006065 File Offset: 0x00004265
		[global::Cpp2ILInjected.Token(Token = "0x600137D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2AB0C", Offset = "0x1E2AB0C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_9", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Disconnect_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Disconnect(bool reuseSocket)
		{
			throw null;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00006068 File Offset: 0x00004268
		[global::Cpp2ILInjected.Token(Token = "0x600137E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2ACFC", Offset = "0x1E2ACFC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_8", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(SocketAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void EndDisconnect(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0000606B File Offset: 0x0000426B
		[global::Cpp2ILInjected.Token(Token = "0x600137F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2ABF4", Offset = "0x1E2ABF4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Disconnect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
		{
			throw null;
		}

		// Token: 0x06001187 RID: 4487
		[global::Cpp2ILInjected.Token(Token = "0x6001380")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2ADA0", Offset = "0x1E2ADA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Disconnect_icall(IntPtr sock, bool reuse, out int error);

		// Token: 0x06001188 RID: 4488 RVA: 0x0000606E File Offset: 0x0000426E
		[global::Cpp2ILInjected.Token(Token = "0x6001381")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E26DC0", Offset = "0x1E26DC0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(Span<byte>),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferNull", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00006071 File Offset: 0x00004271
		[global::Cpp2ILInjected.Token(Token = "0x6001382")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2B040", Offset = "0x1E2B040", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_5", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "Pin", ReturnType = typeof(MemoryHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private unsafe int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00006074 File Offset: 0x00004274
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001383")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E26F2C", Offset = "0x1E26F2C", Length = "0x52C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(IList<ArraySegment<byte>>),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(GCHandleType)
		}, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(Socket.WSABUF*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00006077 File Offset: 0x00004277
		[global::Cpp2ILInjected.Token(Token = "0x6001384")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E227A8", Offset = "0x1E227A8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "Read", MemberParameters = new object[] { typeof(Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0000607A File Offset: 0x0000427A
		[global::Cpp2ILInjected.Token(Token = "0x6001385")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E22E94", Offset = "0x1E22E94", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "Write", MemberParameters = new object[] { typeof(ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0000607D File Offset: 0x0000427D
		[global::Cpp2ILInjected.Token(Token = "0x6001386")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2B378", Offset = "0x1E2B378", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ReceiveAsync", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "Equals", MemberParameters = new object[] { "System.Memory`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new object[]
		{
			typeof(SocketAsyncEventArgs),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			throw null;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00006080 File Offset: 0x00004280
		[global::Cpp2ILInjected.Token(Token = "0x6001387")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E278BC", Offset = "0x1E278BC", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferNull", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Memory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00006083 File Offset: 0x00004283
		[global::Cpp2ILInjected.Token(Token = "0x6001388")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E27A40", Offset = "0x1E27A40", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(SocketAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_ErrorCode", ReturnType = typeof(SocketError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00006086 File Offset: 0x00004286
		[global::Cpp2ILInjected.Token(Token = "0x6001389")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2B250", Offset = "0x1E2B250", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(IList<ArraySegment<byte>>),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			throw null;
		}

		// Token: 0x06001191 RID: 4497
		[global::Cpp2ILInjected.Token(Token = "0x600138A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2B55C", Offset = "0x1E2B55C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x06001192 RID: 4498 RVA: 0x00006089 File Offset: 0x00004289
		[global::Cpp2ILInjected.Token(Token = "0x600138B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2AF18", Offset = "0x1E2AF18", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_11", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			throw null;
		}

		// Token: 0x06001193 RID: 4499
		[global::Cpp2ILInjected.Token(Token = "0x600138C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2B564", Offset = "0x1E2B564", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x06001194 RID: 4500 RVA: 0x0000608C File Offset: 0x0000428C
		[global::Cpp2ILInjected.Token(Token = "0x600138D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2B56C", Offset = "0x1E2B56C", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_14", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "Pin", ReturnType = typeof(MemoryHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ReceiveFrom_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private unsafe int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0000608F File Offset: 0x0000428F
		[global::Cpp2ILInjected.Token(Token = "0x600138E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2B920", Offset = "0x1E2B920", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferNull", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Memory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00006092 File Offset: 0x00004292
		[global::Cpp2ILInjected.Token(Token = "0x600138F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2BAF8", Offset = "0x1E2BAF8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref IPEndPoint)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(SocketAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)
		{
			throw null;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00006095 File Offset: 0x00004295
		[global::Cpp2ILInjected.Token(Token = "0x6001390")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2BC00", Offset = "0x1E2BC00", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_13", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
		{
			throw null;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00006098 File Offset: 0x00004298
		[global::Cpp2ILInjected.Token(Token = "0x6001391")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2B7E8", Offset = "0x1E2B7E8", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveFrom", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref EndPoint),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			throw null;
		}

		// Token: 0x06001199 RID: 4505
		[global::Cpp2ILInjected.Token(Token = "0x6001392")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2BCBC", Offset = "0x1E2BCBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking);

		// Token: 0x0600119A RID: 4506 RVA: 0x0000609B File Offset: 0x0000429B
		[global::Cpp2ILInjected.Token(Token = "0x6001393")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E26C7C", Offset = "0x1E26C7C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<byte>),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferNull", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0000609E File Offset: 0x0000429E
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001394")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E266F4", Offset = "0x1E266F4", Length = "0x588")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(IList<ArraySegment<byte>>),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(GCHandleType)
		}, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(Socket.WSABUF*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000060A1 File Offset: 0x000042A1
		[global::Cpp2ILInjected.Token(Token = "0x6001395")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2BF14", Offset = "0x1E2BF14", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "SendAsyncForNetworkStream", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "Equals", MemberParameters = new object[] { "System.Memory`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new object[]
		{
			typeof(SocketAsyncEventArgs),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public bool SendAsync(SocketAsyncEventArgs e)
		{
			throw null;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000060A4 File Offset: 0x000042A4
		[global::Cpp2ILInjected.Token(Token = "0x6001396")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E275CC", Offset = "0x1E275CC", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferNull", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Memory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000060A7 File Offset: 0x000042A7
		[global::Cpp2ILInjected.Token(Token = "0x6001397")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C1C8", Offset = "0x1E2C1C8", Length = "0x370")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<SendAsync>b__295_0", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<BeginSend>b__297_0", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c__DisplayClass298_0), Member = "<BeginSendCallback>b__0", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.<>c__DisplayClass298_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "Pin", ReturnType = typeof(MemoryHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IOOperation),
			typeof(IOAsyncCallback),
			typeof(IOAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private unsafe static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			throw null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x000060AA File Offset: 0x000042AA
		[global::Cpp2ILInjected.Token(Token = "0x6001398")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E277D8", Offset = "0x1E277D8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(SocketAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "get_ErrorCode", ReturnType = typeof(SocketError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			throw null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000060AD File Offset: 0x000042AD
		[global::Cpp2ILInjected.Token(Token = "0x6001399")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2BDEC", Offset = "0x1E2BDEC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(IList<ArraySegment<byte>>),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			throw null;
		}

		// Token: 0x060011A1 RID: 4513
		[global::Cpp2ILInjected.Token(Token = "0x600139A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C538", Offset = "0x1E2C538", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x060011A2 RID: 4514 RVA: 0x000060B0 File Offset: 0x000042B0
		[global::Cpp2ILInjected.Token(Token = "0x600139B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2BCC4", Offset = "0x1E2BCC4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
		{
			typeof(SocketAsyncResult),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			throw null;
		}

		// Token: 0x060011A3 RID: 4515
		[global::Cpp2ILInjected.Token(Token = "0x600139C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C540", Offset = "0x1E2C540", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x060011A4 RID: 4516 RVA: 0x000060B3 File Offset: 0x000042B3
		[global::Cpp2ILInjected.Token(Token = "0x600139D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C548", Offset = "0x1E2C548", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(IPEndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferNull", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SendTo_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(byte*),
			typeof(int),
			typeof(SocketFlags),
			typeof(SocketAddress),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public unsafe int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			throw null;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x000060B6 File Offset: 0x000042B6
		[global::Cpp2ILInjected.Token(Token = "0x600139E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C81C", Offset = "0x1E2C81C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_17", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(SocketAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int EndSendTo(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x000060B9 File Offset: 0x000042B9
		[global::Cpp2ILInjected.Token(Token = "0x600139F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C6E4", Offset = "0x1E2C6E4", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendTo", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(EndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private unsafe static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking)
		{
			throw null;
		}

		// Token: 0x060011A7 RID: 4519
		[global::Cpp2ILInjected.Token(Token = "0x60013A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C8C8", Offset = "0x1E2C8C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking);

		// Token: 0x060011A8 RID: 4520 RVA: 0x000060BC File Offset: 0x000042BC
		[global::Cpp2ILInjected.Token(Token = "0x60013A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21AF4", Offset = "0x1E21AF4", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "get_ReadTimeout", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "get_WriteTimeout", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.<>c), Member = "<.cctor>b__367_7", MemberParameters = new object[] { typeof(IOAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "get_DualMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Poll", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SelectMode)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "GetSocketOption_obj_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketOptionLevel),
			typeof(SocketOptionName),
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			throw null;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000060BF File Offset: 0x000042BF
		[global::Cpp2ILInjected.Token(Token = "0x60013A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C8D0", Offset = "0x1E2C8D0", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new object[]
		{
			typeof(SocketOptionLevel),
			typeof(SocketOptionName)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error)
		{
			throw null;
		}

		// Token: 0x060011AA RID: 4522
		[global::Cpp2ILInjected.Token(Token = "0x60013A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C9F0", Offset = "0x1E2C9F0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error);

		// Token: 0x060011AB RID: 4523 RVA: 0x000060C2 File Offset: 0x000042C2
		[global::Cpp2ILInjected.Token(Token = "0x60013A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E262EC", Offset = "0x1E262EC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "set_SendTimeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "set_DontFragment", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "set_DualMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SetIPProtectionLevel", MemberParameters = new object[] { typeof(IPProtectionLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "set_EnableBroadcast", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "set_SendTimeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "CheckForBroadcast", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketOptionLevel),
			typeof(SocketOptionName),
			typeof(object),
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			throw null;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000060C5 File Offset: 0x000042C5
		[global::Cpp2ILInjected.Token(Token = "0x60013A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E27E68", Offset = "0x1E27E68", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
		{
			typeof(SocketOptionLevel),
			typeof(SocketOptionName),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
		{
			typeof(SocketOptionLevel),
			typeof(SocketOptionName),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error)
		{
			throw null;
		}

		// Token: 0x060011AD RID: 4525
		[global::Cpp2ILInjected.Token(Token = "0x60013A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C9F4", Offset = "0x1E2C9F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error);

		// Token: 0x060011AE RID: 4526 RVA: 0x000060C8 File Offset: 0x000042C8
		[global::Cpp2ILInjected.Token(Token = "0x60013A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2745C", Offset = "0x1E2745C", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "IOControl_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(int),
			typeof(byte[]),
			typeof(byte[]),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			throw null;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000060CB File Offset: 0x000042CB
		[global::Cpp2ILInjected.Token(Token = "0x60013A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2C9F8", Offset = "0x1E2C9F8", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "IOControl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error)
		{
			throw null;
		}

		// Token: 0x060011B0 RID: 4528
		[global::Cpp2ILInjected.Token(Token = "0x60013A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CB28", Offset = "0x1E2CB28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error);

		// Token: 0x060011B1 RID: 4529 RVA: 0x000060CE File Offset: 0x000042CE
		[global::Cpp2ILInjected.Token(Token = "0x60013AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CB2C", Offset = "0x1E2CB2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AbortConnect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(SocketAsyncEventArgs),
			typeof(ref Socket)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "FreeResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Dispose", ReturnType = typeof(void))]
		public void Close()
		{
			throw null;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000060D1 File Offset: 0x000042D1
		[global::Cpp2ILInjected.Token(Token = "0x60013AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E230E8", Offset = "0x1E230E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Dispose", ReturnType = typeof(void))]
		public void Close(int timeout)
		{
			throw null;
		}

		// Token: 0x060011B3 RID: 4531
		[global::Cpp2ILInjected.Token(Token = "0x60013AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CB34", Offset = "0x1E2CB34", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSocketHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void Close_icall(IntPtr socket, out int error);

		// Token: 0x060011B4 RID: 4532 RVA: 0x000060D4 File Offset: 0x000042D4
		[global::Cpp2ILInjected.Token(Token = "0x60013AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CB38", Offset = "0x1E2CB38", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Shutdown_internal", MemberParameters = new object[]
		{
			typeof(SafeSocketHandle),
			typeof(SocketShutdown),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Shutdown(SocketShutdown how)
		{
			throw null;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x000060D7 File Offset: 0x000042D7
		[global::Cpp2ILInjected.Token(Token = "0x60013AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E27D60", Offset = "0x1E27D60", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "InternalShutdown", MemberParameters = new object[] { typeof(SocketShutdown) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Shutdown", MemberParameters = new object[] { typeof(SocketShutdown) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
		{
			throw null;
		}

		// Token: 0x060011B6 RID: 4534
		[global::Cpp2ILInjected.Token(Token = "0x60013AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CC40", Offset = "0x1E2CC40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSocketHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error);

		// Token: 0x060011B7 RID: 4535 RVA: 0x000060DA File Offset: 0x000042DA
		[global::Cpp2ILInjected.Token(Token = "0x60013B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CC44", Offset = "0x1E2CC44", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Linger", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x000060DD File Offset: 0x000042DD
		[global::Cpp2ILInjected.Token(Token = "0x60013B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CC9C", Offset = "0x1E2CC9C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LingerOption), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void Linger(IntPtr handle)
		{
			throw null;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x000060E0 File Offset: 0x000042E0
		[global::Cpp2ILInjected.Token(Token = "0x60013B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E280C8", Offset = "0x1E280C8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ThrowIfDisposedAndClosed()
		{
			throw null;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000060E3 File Offset: 0x000042E3
		[global::Cpp2ILInjected.Token(Token = "0x60013B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2ADA8", Offset = "0x1E2ADA8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref EndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendTo", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(EndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ThrowIfBufferNull(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x000060E6 File Offset: 0x000042E6
		[global::Cpp2ILInjected.Token(Token = "0x60013B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2ADFC", Offset = "0x1E2ADFC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref EndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendTo", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(EndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x000060E9 File Offset: 0x000042E9
		[global::Cpp2ILInjected.Token(Token = "0x60013B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E286B8", Offset = "0x1E286B8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ThrowIfUdp()
		{
			throw null;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x000060EC File Offset: 0x000042EC
		[global::Cpp2ILInjected.Token(Token = "0x60013B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2955C", Offset = "0x1E2955C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new object[]
		{
			typeof(ref byte[]),
			typeof(ref int),
			typeof(IAsyncResult)
		}, ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref EndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			throw null;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000060EF File Offset: 0x000042EF
		[global::Cpp2ILInjected.Token(Token = "0x60013B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E291C8", Offset = "0x1E291C8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "AcceptAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginAccept", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref EndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref SocketError),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.<>c__DisplayClass355_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = "MarkDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new object[] { typeof(Action<Task>) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
		{
			throw null;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x000060F2 File Offset: 0x000042F2
		[global::Cpp2ILInjected.Token(Token = "0x60013B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29158", Offset = "0x1E29158", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "AcceptAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Init", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SocketOperationToSocketAsyncOperation", MemberParameters = new object[] { typeof(SocketOperation) }, ReturnType = typeof(SocketAsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncEventArgs), Member = "SetLastOperation", MemberParameters = new object[] { typeof(SocketAsyncOperation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncEventArgs), Member = "SetBytesTransferred", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation)
		{
			throw null;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000060F5 File Offset: 0x000042F5
		[global::Cpp2ILInjected.Token(Token = "0x60013B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CE00", Offset = "0x1E2CE00", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new object[]
		{
			typeof(SocketAsyncEventArgs),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
		{
			throw null;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000060F8 File Offset: 0x000042F8
		[global::Cpp2ILInjected.Token(Token = "0x60013BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E29804", Offset = "0x1E29804", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Bind", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Connect", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_DualMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "MapToIPv6", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			throw null;
		}

		// Token: 0x060011C2 RID: 4546
		[global::Cpp2ILInjected.Token(Token = "0x60013BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CEA4", Offset = "0x1E2CEA4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSocketHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void cancel_blocking_socket_operation(Thread thread);

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x000060FB File Offset: 0x000042FB
		[global::Cpp2ILInjected.Token(Token = "0x17000484")]
		internal static int FamilyHint
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2CEA8", Offset = "0x1E2CEA8", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv4", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv6", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011C4 RID: 4548
		[global::Cpp2ILInjected.Token(Token = "0x60013BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CF30", Offset = "0x1E2CF30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface);

		// Token: 0x060011C5 RID: 4549 RVA: 0x000060FE File Offset: 0x000042FE
		[global::Cpp2ILInjected.Token(Token = "0x60013BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E27C00", Offset = "0x1E27C00", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
		{
			throw null;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00006101 File Offset: 0x00004301
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60013BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2CF34", Offset = "0x1E2CF34", Length = "0x1698")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandler<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.TaskSocketAsyncEventArgs<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.Int32TaskSocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task[]), Member = "FromResult", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOAsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		static Socket()
		{
			throw null;
		}

		// Token: 0x04000BBD RID: 3005
		[global::Cpp2ILInjected.Token(Token = "0x4000F91")]
		private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler;

		// Token: 0x04000BBE RID: 3006
		[global::Cpp2ILInjected.Token(Token = "0x4000F92")]
		private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler;

		// Token: 0x04000BBF RID: 3007
		[global::Cpp2ILInjected.Token(Token = "0x4000F93")]
		private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler;

		// Token: 0x04000BC0 RID: 3008
		[global::Cpp2ILInjected.Token(Token = "0x4000F94")]
		private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel;

		// Token: 0x04000BC1 RID: 3009
		[global::Cpp2ILInjected.Token(Token = "0x4000F95")]
		private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel;

		// Token: 0x04000BC2 RID: 3010
		[global::Cpp2ILInjected.Token(Token = "0x4000F96")]
		private static readonly Task<int> s_zeroTask;

		// Token: 0x04000BC3 RID: 3011
		[global::Cpp2ILInjected.Token(Token = "0x4000F97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Socket.CachedEventArgs _cachedTaskEventArgs;

		// Token: 0x04000BC4 RID: 3012
		[global::Cpp2ILInjected.Token(Token = "0x4000F98")]
		private static object s_InternalSyncObject;

		// Token: 0x04000BC5 RID: 3013
		[global::Cpp2ILInjected.Token(Token = "0x4000F99")]
		internal static bool s_SupportsIPv4;

		// Token: 0x04000BC6 RID: 3014
		[global::Cpp2ILInjected.Token(Token = "0x4000F9A")]
		internal static bool s_SupportsIPv6;

		// Token: 0x04000BC7 RID: 3015
		[global::Cpp2ILInjected.Token(Token = "0x4000F9B")]
		internal static bool s_OSSupportsIPv6;

		// Token: 0x04000BC8 RID: 3016
		[global::Cpp2ILInjected.Token(Token = "0x4000F9C")]
		internal static bool s_Initialized;

		// Token: 0x04000BC9 RID: 3017
		[global::Cpp2ILInjected.Token(Token = "0x4000F9D")]
		private static bool s_LoggingEnabled;

		// Token: 0x04000BCA RID: 3018
		[global::Cpp2ILInjected.Token(Token = "0x4000F9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool is_closed;

		// Token: 0x04000BCB RID: 3019
		[global::Cpp2ILInjected.Token(Token = "0x4000F9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool is_listening;

		// Token: 0x04000BCC RID: 3020
		[global::Cpp2ILInjected.Token(Token = "0x4000FA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int linger_timeout;

		// Token: 0x04000BCD RID: 3021
		[global::Cpp2ILInjected.Token(Token = "0x4000FA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private AddressFamily addressFamily;

		// Token: 0x04000BCE RID: 3022
		[global::Cpp2ILInjected.Token(Token = "0x4000FA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private SocketType socketType;

		// Token: 0x04000BCF RID: 3023
		[global::Cpp2ILInjected.Token(Token = "0x4000FA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ProtocolType protocolType;

		// Token: 0x04000BD0 RID: 3024
		[global::Cpp2ILInjected.Token(Token = "0x4000FA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal SafeSocketHandle m_Handle;

		// Token: 0x04000BD1 RID: 3025
		[global::Cpp2ILInjected.Token(Token = "0x4000FA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal EndPoint seed_endpoint;

		// Token: 0x04000BD2 RID: 3026
		[global::Cpp2ILInjected.Token(Token = "0x4000FA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal SemaphoreSlim ReadSem;

		// Token: 0x04000BD3 RID: 3027
		[global::Cpp2ILInjected.Token(Token = "0x4000FA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal SemaphoreSlim WriteSem;

		// Token: 0x04000BD4 RID: 3028
		[global::Cpp2ILInjected.Token(Token = "0x4000FA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal bool is_blocking;

		// Token: 0x04000BD5 RID: 3029
		[global::Cpp2ILInjected.Token(Token = "0x4000FA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		internal bool is_bound;

		// Token: 0x04000BD6 RID: 3030
		[global::Cpp2ILInjected.Token(Token = "0x4000FAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x52")]
		internal bool is_connected;

		// Token: 0x04000BD7 RID: 3031
		[global::Cpp2ILInjected.Token(Token = "0x4000FAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int m_IntCleanedUp;

		// Token: 0x04000BD8 RID: 3032
		[global::Cpp2ILInjected.Token(Token = "0x4000FAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal bool connect_in_progress;

		// Token: 0x04000BD9 RID: 3033
		[global::Cpp2ILInjected.Token(Token = "0x4000FAD")]
		private static AsyncCallback AcceptAsyncCallback;

		// Token: 0x04000BDA RID: 3034
		[global::Cpp2ILInjected.Token(Token = "0x4000FAE")]
		private static IOAsyncCallback BeginAcceptCallback;

		// Token: 0x04000BDB RID: 3035
		[global::Cpp2ILInjected.Token(Token = "0x4000FAF")]
		private static IOAsyncCallback BeginAcceptReceiveCallback;

		// Token: 0x04000BDC RID: 3036
		[global::Cpp2ILInjected.Token(Token = "0x4000FB0")]
		private static AsyncCallback ConnectAsyncCallback;

		// Token: 0x04000BDD RID: 3037
		[global::Cpp2ILInjected.Token(Token = "0x4000FB1")]
		private static IOAsyncCallback BeginConnectCallback;

		// Token: 0x04000BDE RID: 3038
		[global::Cpp2ILInjected.Token(Token = "0x4000FB2")]
		private static AsyncCallback DisconnectAsyncCallback;

		// Token: 0x04000BDF RID: 3039
		[global::Cpp2ILInjected.Token(Token = "0x4000FB3")]
		private static IOAsyncCallback BeginDisconnectCallback;

		// Token: 0x04000BE0 RID: 3040
		[global::Cpp2ILInjected.Token(Token = "0x4000FB4")]
		private static AsyncCallback ReceiveAsyncCallback;

		// Token: 0x04000BE1 RID: 3041
		[global::Cpp2ILInjected.Token(Token = "0x4000FB5")]
		private static IOAsyncCallback BeginReceiveCallback;

		// Token: 0x04000BE2 RID: 3042
		[global::Cpp2ILInjected.Token(Token = "0x4000FB6")]
		private static IOAsyncCallback BeginReceiveGenericCallback;

		// Token: 0x04000BE3 RID: 3043
		[global::Cpp2ILInjected.Token(Token = "0x4000FB7")]
		private static AsyncCallback ReceiveFromAsyncCallback;

		// Token: 0x04000BE4 RID: 3044
		[global::Cpp2ILInjected.Token(Token = "0x4000FB8")]
		private static IOAsyncCallback BeginReceiveFromCallback;

		// Token: 0x04000BE5 RID: 3045
		[global::Cpp2ILInjected.Token(Token = "0x4000FB9")]
		private static AsyncCallback SendAsyncCallback;

		// Token: 0x04000BE6 RID: 3046
		[global::Cpp2ILInjected.Token(Token = "0x4000FBA")]
		private static IOAsyncCallback BeginSendGenericCallback;

		// Token: 0x04000BE7 RID: 3047
		[global::Cpp2ILInjected.Token(Token = "0x4000FBB")]
		private static AsyncCallback SendToAsyncCallback;

		// Token: 0x02000448 RID: 1096
		[global::Cpp2ILInjected.Token(Token = "0x20002EC")]
		private sealed class CachedEventArgs
		{
			// Token: 0x06001E95 RID: 7829 RVA: 0x0000843E File Offset: 0x0000663E
			[global::Cpp2ILInjected.Token(Token = "0x60013C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2E5CC", Offset = "0x1E2E5CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CachedEventArgs()
			{
				throw null;
			}

			// Token: 0x0400135B RID: 4955
			[global::Cpp2ILInjected.Token(Token = "0x4000FBC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Socket.TaskSocketAsyncEventArgs<Socket> TaskAccept;

			// Token: 0x0400135C RID: 4956
			[global::Cpp2ILInjected.Token(Token = "0x4000FBD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Socket.Int32TaskSocketAsyncEventArgs TaskReceive;

			// Token: 0x0400135D RID: 4957
			[global::Cpp2ILInjected.Token(Token = "0x4000FBE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Socket.Int32TaskSocketAsyncEventArgs TaskSend;

			// Token: 0x0400135E RID: 4958
			[global::Cpp2ILInjected.Token(Token = "0x4000FBF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;

			// Token: 0x0400135F RID: 4959
			[global::Cpp2ILInjected.Token(Token = "0x4000FC0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;
		}

		// Token: 0x02000449 RID: 1097
		[global::Cpp2ILInjected.Token(Token = "0x20002ED")]
		private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
		{
			// Token: 0x06001E96 RID: 7830 RVA: 0x00008441 File Offset: 0x00006641
			[global::Cpp2ILInjected.Token(Token = "0x60013C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1875874", Offset = "0x1875874", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			internal TaskSocketAsyncEventArgs()
			{
				throw null;
			}

			// Token: 0x06001E97 RID: 7831 RVA: 0x00008444 File Offset: 0x00006644
			[global::Cpp2ILInjected.Token(Token = "0x60013C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1875880", Offset = "0x1875880", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "CompleteSendReceive", MemberParameters = new object[]
			{
				typeof(Socket),
				"System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
			{
				throw null;
			}

			// Token: 0x04001360 RID: 4960
			[global::Cpp2ILInjected.Token(Token = "0x4000FC1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal AsyncTaskMethodBuilder<TResult> _builder;

			// Token: 0x04001361 RID: 4961
			[global::Cpp2ILInjected.Token(Token = "0x4000FC2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal bool _accessed;
		}

		// Token: 0x0200044A RID: 1098
		[global::Cpp2ILInjected.Token(Token = "0x20002EE")]
		private sealed class Int32TaskSocketAsyncEventArgs : Socket.TaskSocketAsyncEventArgs<int>
		{
			// Token: 0x06001E98 RID: 7832 RVA: 0x00008447 File Offset: 0x00006647
			[global::Cpp2ILInjected.Token(Token = "0x60013C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2E5D4", Offset = "0x1E2E5D4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Net.Sockets.Socket.TaskSocketAsyncEventArgs`1", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public Int32TaskSocketAsyncEventArgs()
			{
				throw null;
			}

			// Token: 0x04001362 RID: 4962
			[global::Cpp2ILInjected.Token(Token = "0x4000FC3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
			internal bool _wrapExceptionsInIOExceptions;
		}

		// Token: 0x0200044B RID: 1099
		[global::Cpp2ILInjected.Token(Token = "0x20002EF")]
		internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int>
		{
			// Token: 0x06001E99 RID: 7833 RVA: 0x0000844A File Offset: 0x0000664A
			[global::Cpp2ILInjected.Token(Token = "0x60013C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2E61C", Offset = "0x1E2E61C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<ReceiveAsync>b__14_1", ReturnType = typeof(Socket.AwaitableSocketAsyncEventArgs))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<SendAsyncForNetworkStream>b__22_1", ReturnType = typeof(Socket.AwaitableSocketAsyncEventArgs))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public AwaitableSocketAsyncEventArgs()
			{
				throw null;
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06001E9A RID: 7834 RVA: 0x0000844D File Offset: 0x0000664D
			// (set) Token: 0x06001E9B RID: 7835 RVA: 0x00008450 File Offset: 0x00006650
			[global::Cpp2ILInjected.Token(Token = "0x17000485")]
			public bool WrapExceptionsInIOExceptions
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60013C5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E2E710", Offset = "0x1E2E710", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60013C6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E2E718", Offset = "0x1E2E718", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06001E9C RID: 7836 RVA: 0x00008453 File Offset: 0x00006653
			[global::Cpp2ILInjected.Token(Token = "0x60013C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2E724", Offset = "0x1E2E724", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[]
			{
				typeof(Memory<byte>),
				typeof(SocketFlags),
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = typeof(ValueTask<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
			{
				typeof(ReadOnlyMemory<byte>),
				typeof(SocketFlags),
				typeof(CancellationToken)
			}, ReturnType = typeof(ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool Reserve()
			{
				throw null;
			}

			// Token: 0x06001E9D RID: 7837 RVA: 0x00008456 File Offset: 0x00006656
			[global::Cpp2ILInjected.Token(Token = "0x60013C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2E7A4", Offset = "0x1E2E7A4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ReceiveAsync", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(ValueTask<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "SendAsyncForNetworkStream", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "GetResult", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "System.Threading.Tasks.Sources.IValueTaskSource.GetResult", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Release()
			{
				throw null;
			}

			// Token: 0x06001E9E RID: 7838 RVA: 0x00008459 File Offset: 0x00006659
			[global::Cpp2ILInjected.Token(Token = "0x60013C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2E814", Offset = "0x1E2E814", Length = "0x218")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple[]), Member = "Create", MemberTypeParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(object)
			}, MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(object)
			}, ReturnType = "System.Tuple`3<T1, T2, T3>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
			{
				typeof(ExecutionContext),
				typeof(ContextCallback),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			protected override void OnCompleted(SocketAsyncEventArgs _)
			{
				throw null;
			}

			// Token: 0x06001E9F RID: 7839 RVA: 0x0000845C File Offset: 0x0000665C
			[global::Cpp2ILInjected.Token(Token = "0x60013CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2ED10", Offset = "0x1E2ED10", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[]
			{
				typeof(Memory<byte>),
				typeof(SocketFlags),
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = typeof(ValueTask<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new object[] { "System.ExceptionArgument" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(Exception) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public ValueTask<int> ReceiveAsync(Socket socket)
			{
				throw null;
			}

			// Token: 0x06001EA0 RID: 7840 RVA: 0x0000845F File Offset: 0x0000665F
			[global::Cpp2ILInjected.Token(Token = "0x60013CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2EF18", Offset = "0x1E2EF18", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
			{
				typeof(ReadOnlyMemory<byte>),
				typeof(SocketFlags),
				typeof(CancellationToken)
			}, ReturnType = typeof(ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new object[] { "System.ExceptionArgument" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public ValueTask SendAsyncForNetworkStream(Socket socket)
			{
				throw null;
			}

			// Token: 0x06001EA1 RID: 7841 RVA: 0x00008462 File Offset: 0x00006662
			[global::Cpp2ILInjected.Token(Token = "0x60013CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2EFF4", Offset = "0x1E2EFF4", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ThrowIncorrectTokenException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public ValueTaskSourceStatus GetStatus(short token)
			{
				throw null;
			}

			// Token: 0x06001EA2 RID: 7842 RVA: 0x00008465 File Offset: 0x00006665
			[global::Cpp2ILInjected.Token(Token = "0x60013CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F0D4", Offset = "0x1E2F0D4", Length = "0x210")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "InvokeContinuation", MemberParameters = new object[]
			{
				typeof(Action<object>),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ThrowIncorrectTokenException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ThrowMultipleContinuationsException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				throw null;
			}

			// Token: 0x06001EA3 RID: 7843 RVA: 0x00008468 File Offset: 0x00006668
			[global::Cpp2ILInjected.Token(Token = "0x60013CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2EA2C", Offset = "0x1E2EA2C", Length = "0x2E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs.<>c), Member = "<OnCompleted>b__14_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "OnCompleted", MemberParameters = new object[]
			{
				typeof(Action<object>),
				typeof(object),
				typeof(short),
				typeof(ValueTaskSourceOnCompletedFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new object[]
			{
				typeof(Action<object>),
				typeof(object),
				typeof(CancellationToken),
				typeof(TaskCreationOptions),
				typeof(TaskScheduler)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberTypeParameters = new object[] { "TState" }, MemberParameters = new object[]
			{
				"System.Action`1<TState>",
				"TState",
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendOrPostCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple[]), Member = "Create", MemberTypeParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = "System.Tuple`2<T1, T2>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync)
			{
				throw null;
			}

			// Token: 0x06001EA4 RID: 7844 RVA: 0x0000846B File Offset: 0x0000666B
			[global::Cpp2ILInjected.Token(Token = "0x60013CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F330", Offset = "0x1E2F330", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ThrowIncorrectTokenException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ThrowException", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
			public int GetResult(short token)
			{
				throw null;
			}

			// Token: 0x06001EA5 RID: 7845 RVA: 0x0000846E File Offset: 0x0000666E
			[global::Cpp2ILInjected.Token(Token = "0x60013D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F39C", Offset = "0x1E2F39C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ThrowIncorrectTokenException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ThrowException", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
			private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token)
			{
				throw null;
			}

			// Token: 0x06001EA6 RID: 7846 RVA: 0x00008471 File Offset: 0x00006671
			[global::Cpp2ILInjected.Token(Token = "0x60013D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F088", Offset = "0x1E2F088", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "GetStatus", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(ValueTaskSourceStatus))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "OnCompleted", MemberParameters = new object[]
			{
				typeof(Action<object>),
				typeof(object),
				typeof(short),
				typeof(ValueTaskSourceOnCompletedFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "GetResult", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "System.Threading.Tasks.Sources.IValueTaskSource.GetResult", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void ThrowIncorrectTokenException()
			{
				throw null;
			}

			// Token: 0x06001EA7 RID: 7847 RVA: 0x00008474 File Offset: 0x00006674
			[global::Cpp2ILInjected.Token(Token = "0x60013D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F2E4", Offset = "0x1E2F2E4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "OnCompleted", MemberParameters = new object[]
			{
				typeof(Action<object>),
				typeof(object),
				typeof(short),
				typeof(ValueTaskSourceOnCompletedFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void ThrowMultipleContinuationsException()
			{
				throw null;
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x00008477 File Offset: 0x00006677
			[global::Cpp2ILInjected.Token(Token = "0x60013D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F378", Offset = "0x1E2F378", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "GetResult", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "System.Threading.Tasks.Sources.IValueTaskSource.GetResult", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void ThrowException(SocketError error)
			{
				throw null;
			}

			// Token: 0x06001EA9 RID: 7849 RVA: 0x0000847A File Offset: 0x0000667A
			[global::Cpp2ILInjected.Token(Token = "0x60013D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2EE34", Offset = "0x1E2EE34", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ReceiveAsync", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(ValueTask<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "SendAsyncForNetworkStream", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "ThrowException", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private Exception CreateException(SocketError error)
			{
				throw null;
			}

			// Token: 0x06001EAA RID: 7850 RVA: 0x0000847D File Offset: 0x0000667D
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60013D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F3E4", Offset = "0x1E2F3E4", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static AwaitableSocketAsyncEventArgs()
			{
				throw null;
			}

			// Token: 0x04001363 RID: 4963
			[global::Cpp2ILInjected.Token(Token = "0x4000FC4")]
			internal static readonly Socket.AwaitableSocketAsyncEventArgs Reserved;

			// Token: 0x04001364 RID: 4964
			[global::Cpp2ILInjected.Token(Token = "0x4000FC5")]
			private static readonly Action<object> s_completedSentinel;

			// Token: 0x04001365 RID: 4965
			[global::Cpp2ILInjected.Token(Token = "0x4000FC6")]
			private static readonly Action<object> s_availableSentinel;

			// Token: 0x04001366 RID: 4966
			[global::Cpp2ILInjected.Token(Token = "0x4000FC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			private Action<object> _continuation;

			// Token: 0x04001367 RID: 4967
			[global::Cpp2ILInjected.Token(Token = "0x4000FC8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private ExecutionContext _executionContext;

			// Token: 0x04001368 RID: 4968
			[global::Cpp2ILInjected.Token(Token = "0x4000FC9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			private object _scheduler;

			// Token: 0x04001369 RID: 4969
			[global::Cpp2ILInjected.Token(Token = "0x4000FCA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			private short _token;

			// Token: 0x0400136A RID: 4970
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000FCB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA2")]
			private bool <WrapExceptionsInIOExceptions>k__BackingField;

			// Token: 0x020004BB RID: 1211
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20002F0")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600200D RID: 8205 RVA: 0x000087D4 File Offset: 0x000069D4
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x60013D6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E2F518", Offset = "0x1E2F518", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x0600200E RID: 8206 RVA: 0x000087D7 File Offset: 0x000069D7
				[global::Cpp2ILInjected.Token(Token = "0x60013D7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E2F574", Offset = "0x1E2F574", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x0600200F RID: 8207 RVA: 0x000087DA File Offset: 0x000069DA
				[global::Cpp2ILInjected.Token(Token = "0x60013D8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E2F57C", Offset = "0x1E2F57C", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = "InvokeContinuation", MemberParameters = new object[]
				{
					typeof(Action<object>),
					typeof(object),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				internal void <OnCompleted>b__14_0(object runState)
				{
					throw null;
				}

				// Token: 0x06002010 RID: 8208 RVA: 0x000087DD File Offset: 0x000069DD
				[global::Cpp2ILInjected.Token(Token = "0x60013D9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E2F624", Offset = "0x1E2F624", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				internal void <InvokeContinuation>b__20_0(object s)
				{
					throw null;
				}

				// Token: 0x06002011 RID: 8209 RVA: 0x000087E0 File Offset: 0x000069E0
				[global::Cpp2ILInjected.Token(Token = "0x60013DA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E2F6C4", Offset = "0x1E2F6C4", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				internal void <.cctor>b__27_0(object state)
				{
					throw null;
				}

				// Token: 0x06002012 RID: 8210 RVA: 0x000087E3 File Offset: 0x000069E3
				[global::Cpp2ILInjected.Token(Token = "0x60013DB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E2F710", Offset = "0x1E2F710", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				internal void <.cctor>b__27_1(object state)
				{
					throw null;
				}

				// Token: 0x04001444 RID: 5188
				[global::Cpp2ILInjected.Token(Token = "0x4000FCC")]
				public static readonly Socket.AwaitableSocketAsyncEventArgs.<>c <>9;

				// Token: 0x04001445 RID: 5189
				[global::Cpp2ILInjected.Token(Token = "0x4000FCD")]
				public static ContextCallback <>9__14_0;

				// Token: 0x04001446 RID: 5190
				[global::Cpp2ILInjected.Token(Token = "0x4000FCE")]
				public static SendOrPostCallback <>9__20_0;
			}
		}

		// Token: 0x0200044C RID: 1100
		[global::Cpp2ILInjected.Token(Token = "0x20002F1")]
		private struct WSABUF
		{
			// Token: 0x0400136B RID: 4971
			[global::Cpp2ILInjected.Token(Token = "0x4000FCF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int len;

			// Token: 0x0400136C RID: 4972
			[global::Cpp2ILInjected.Token(Token = "0x4000FD0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public IntPtr buf;
		}

		// Token: 0x0200044D RID: 1101
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002F2")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001EAB RID: 7851 RVA: 0x00008480 File Offset: 0x00006680
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60013DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F75C", Offset = "0x1E2F75C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06001EAC RID: 7852 RVA: 0x00008483 File Offset: 0x00006683
			[global::Cpp2ILInjected.Token(Token = "0x60013DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F7B8", Offset = "0x1E2F7B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06001EAD RID: 7853 RVA: 0x00008486 File Offset: 0x00006686
			[global::Cpp2ILInjected.Token(Token = "0x60013DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F7C0", Offset = "0x1E2F7C0", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Socket.CachedEventArgs <ReceiveAsync>b__14_0()
			{
				throw null;
			}

			// Token: 0x06001EAE RID: 7854 RVA: 0x00008489 File Offset: 0x00006689
			[global::Cpp2ILInjected.Token(Token = "0x60013DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F814", Offset = "0x1E2F814", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1()
			{
				throw null;
			}

			// Token: 0x06001EAF RID: 7855 RVA: 0x0000848C File Offset: 0x0000668C
			[global::Cpp2ILInjected.Token(Token = "0x60013E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2F864", Offset = "0x1E2F864", Length = "0x214")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = "TrySetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x06001EB0 RID: 7856 RVA: 0x0000848F File Offset: 0x0000668F
			[global::Cpp2ILInjected.Token(Token = "0x60013E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2FA78", Offset = "0x1E2FA78", Length = "0x3BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = "TrySetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
			internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x06001EB1 RID: 7857 RVA: 0x00008492 File Offset: 0x00006692
			[global::Cpp2ILInjected.Token(Token = "0x60013E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2FE34", Offset = "0x1E2FE34", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0()
			{
				throw null;
			}

			// Token: 0x06001EB2 RID: 7858 RVA: 0x00008495 File Offset: 0x00006695
			[global::Cpp2ILInjected.Token(Token = "0x60013E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2FE88", Offset = "0x1E2FE88", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket.AwaitableSocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1()
			{
				throw null;
			}

			// Token: 0x06001EB3 RID: 7859 RVA: 0x00008498 File Offset: 0x00006698
			[global::Cpp2ILInjected.Token(Token = "0x60013E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E2FED8", Offset = "0x1E2FED8", Length = "0x214")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = "TrySetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			internal void <SendAsyncApm>b__23_0(IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x06001EB4 RID: 7860 RVA: 0x0000849B File Offset: 0x0000669B
			[global::Cpp2ILInjected.Token(Token = "0x60013E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E300EC", Offset = "0x1E300EC", Length = "0x2BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = "TrySetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<int>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			internal void <SendAsyncApm>b__23_1(IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x06001EB5 RID: 7861 RVA: 0x0000849E File Offset: 0x0000669E
			[global::Cpp2ILInjected.Token(Token = "0x60013E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E303A8", Offset = "0x1E303A8", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
			{
				typeof(SocketAsyncResult),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void <SendAsync>b__295_0(IOAsyncResult s)
			{
				throw null;
			}

			// Token: 0x06001EB6 RID: 7862 RVA: 0x000084A1 File Offset: 0x000066A1
			[global::Cpp2ILInjected.Token(Token = "0x60013E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3043C", Offset = "0x1E3043C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
			{
				typeof(SocketAsyncResult),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void <BeginSend>b__297_0(IOAsyncResult s)
			{
				throw null;
			}

			// Token: 0x06001EB7 RID: 7863 RVA: 0x000084A4 File Offset: 0x000066A4
			[global::Cpp2ILInjected.Token(Token = "0x60013E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E304D0", Offset = "0x1E304D0", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "CompleteAccept", MemberParameters = new object[]
			{
				typeof(Socket),
				typeof(Socket.TaskSocketAsyncEventArgs<Socket>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e)
			{
				throw null;
			}

			// Token: 0x06001EB8 RID: 7864 RVA: 0x000084A7 File Offset: 0x000066A7
			[global::Cpp2ILInjected.Token(Token = "0x60013E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E305C8", Offset = "0x1E305C8", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "CompleteSendReceive", MemberParameters = new object[]
			{
				typeof(Socket),
				"System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e)
			{
				throw null;
			}

			// Token: 0x06001EB9 RID: 7865 RVA: 0x000084AA File Offset: 0x000066AA
			[global::Cpp2ILInjected.Token(Token = "0x60013EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E306A8", Offset = "0x1E306A8", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "CompleteSendReceive", MemberParameters = new object[]
			{
				typeof(Socket),
				"System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e)
			{
				throw null;
			}

			// Token: 0x06001EBA RID: 7866 RVA: 0x000084AD File Offset: 0x000066AD
			[global::Cpp2ILInjected.Token(Token = "0x60013EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E30788", Offset = "0x1E30788", Length = "0x314")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Socket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(AddressFamily),
				typeof(SocketType),
				typeof(ProtocolType),
				typeof(SafeSocketHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
			internal void <.cctor>b__367_3(IAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EBB RID: 7867 RVA: 0x000084B0 File Offset: 0x000066B0
			[global::Cpp2ILInjected.Token(Token = "0x60013EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E30AA4", Offset = "0x1E30AA4", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Accept", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal void <.cctor>b__367_4(IOAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EBC RID: 7868 RVA: 0x000084B3 File Offset: 0x000066B3
			[global::Cpp2ILInjected.Token(Token = "0x60013ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E30BBC", Offset = "0x1E30BBC", Length = "0x1F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Accept", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
			{
				typeof(Memory<byte>),
				typeof(int),
				typeof(int),
				typeof(SocketFlags),
				typeof(ref SocketError)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			internal void <.cctor>b__367_5(IOAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EBD RID: 7869 RVA: 0x000084B6 File Offset: 0x000066B6
			[global::Cpp2ILInjected.Token(Token = "0x60013EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E30DBC", Offset = "0x1E30DBC", Length = "0x274")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			internal void <.cctor>b__367_6(IAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EBE RID: 7870 RVA: 0x000084B9 File Offset: 0x000066B9
			[global::Cpp2ILInjected.Token(Token = "0x60013EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E31030", Offset = "0x1E31030", Length = "0x24C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			internal void <.cctor>b__367_7(IOAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EBF RID: 7871 RVA: 0x000084BC File Offset: 0x000066BC
			[global::Cpp2ILInjected.Token(Token = "0x60013F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E31448", Offset = "0x1E31448", Length = "0x274")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			internal void <.cctor>b__367_8(IAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC0 RID: 7872 RVA: 0x000084BF File Offset: 0x000066BF
			[global::Cpp2ILInjected.Token(Token = "0x60013F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E316BC", Offset = "0x1E316BC", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Disconnect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal void <.cctor>b__367_9(IOAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC1 RID: 7873 RVA: 0x000084C2 File Offset: 0x000066C2
			[global::Cpp2ILInjected.Token(Token = "0x60013F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E317A4", Offset = "0x1E317A4", Length = "0x278")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			internal void <.cctor>b__367_10(IAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC2 RID: 7874 RVA: 0x000084C5 File Offset: 0x000066C5
			[global::Cpp2ILInjected.Token(Token = "0x60013F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E31A24", Offset = "0x1E31A24", Length = "0x28C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Memory<>), Member = "Pin", ReturnType = typeof(MemoryHandle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new object[]
			{
				typeof(SafeSocketHandle),
				typeof(byte*),
				typeof(int),
				typeof(SocketFlags),
				typeof(ref int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			internal unsafe void <.cctor>b__367_11(IOAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC3 RID: 7875 RVA: 0x000084C8 File Offset: 0x000066C8
			[global::Cpp2ILInjected.Token(Token = "0x60013F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E31CB8", Offset = "0x1E31CB8", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
			{
				typeof(IList<ArraySegment<byte>>),
				typeof(SocketFlags)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal void <.cctor>b__367_12(IOAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC4 RID: 7876 RVA: 0x000084CB File Offset: 0x000066CB
			[global::Cpp2ILInjected.Token(Token = "0x60013F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E31DA8", Offset = "0x1E31DA8", Length = "0x294")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new object[]
			{
				typeof(SocketAsyncResult),
				typeof(SocketAsyncEventArgs)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
			internal void <.cctor>b__367_13(IAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC5 RID: 7877 RVA: 0x000084CE File Offset: 0x000066CE
			[global::Cpp2ILInjected.Token(Token = "0x60013F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3203C", Offset = "0x1E3203C", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ReceiveFrom", MemberParameters = new object[]
			{
				typeof(Memory<byte>),
				typeof(int),
				typeof(int),
				typeof(SocketFlags),
				typeof(ref EndPoint),
				typeof(ref SocketError)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			internal void <.cctor>b__367_14(IOAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC6 RID: 7878 RVA: 0x000084D1 File Offset: 0x000066D1
			[global::Cpp2ILInjected.Token(Token = "0x60013F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32198", Offset = "0x1E32198", Length = "0x278")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			internal void <.cctor>b__367_15(IAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC7 RID: 7879 RVA: 0x000084D4 File Offset: 0x000066D4
			[global::Cpp2ILInjected.Token(Token = "0x60013F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32410", Offset = "0x1E32410", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
			{
				typeof(IList<ArraySegment<byte>>),
				typeof(SocketFlags)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal void <.cctor>b__367_16(IOAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x06001EC8 RID: 7880 RVA: 0x000084D7 File Offset: 0x000066D7
			[global::Cpp2ILInjected.Token(Token = "0x60013F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32500", Offset = "0x1E32500", Length = "0x278")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			internal void <.cctor>b__367_17(IAsyncResult ares)
			{
				throw null;
			}

			// Token: 0x0400136D RID: 4973
			[global::Cpp2ILInjected.Token(Token = "0x4000FD1")]
			public static readonly Socket.<>c <>9;

			// Token: 0x0400136E RID: 4974
			[global::Cpp2ILInjected.Token(Token = "0x4000FD2")]
			public static Func<Socket.CachedEventArgs> <>9__14_0;

			// Token: 0x0400136F RID: 4975
			[global::Cpp2ILInjected.Token(Token = "0x4000FD3")]
			public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__14_1;

			// Token: 0x04001370 RID: 4976
			[global::Cpp2ILInjected.Token(Token = "0x4000FD4")]
			public static AsyncCallback <>9__15_0;

			// Token: 0x04001371 RID: 4977
			[global::Cpp2ILInjected.Token(Token = "0x4000FD5")]
			public static AsyncCallback <>9__15_1;

			// Token: 0x04001372 RID: 4978
			[global::Cpp2ILInjected.Token(Token = "0x4000FD6")]
			public static Func<Socket.CachedEventArgs> <>9__22_0;

			// Token: 0x04001373 RID: 4979
			[global::Cpp2ILInjected.Token(Token = "0x4000FD7")]
			public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__22_1;

			// Token: 0x04001374 RID: 4980
			[global::Cpp2ILInjected.Token(Token = "0x4000FD8")]
			public static AsyncCallback <>9__23_0;

			// Token: 0x04001375 RID: 4981
			[global::Cpp2ILInjected.Token(Token = "0x4000FD9")]
			public static AsyncCallback <>9__23_1;

			// Token: 0x04001376 RID: 4982
			[global::Cpp2ILInjected.Token(Token = "0x4000FDA")]
			public static IOAsyncCallback <>9__295_0;

			// Token: 0x04001377 RID: 4983
			[global::Cpp2ILInjected.Token(Token = "0x4000FDB")]
			public static IOAsyncCallback <>9__297_0;
		}

		// Token: 0x0200044E RID: 1102
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002F3")]
		private sealed class <>c__DisplayClass240_0
		{
			// Token: 0x06001EC9 RID: 7881 RVA: 0x000084DA File Offset: 0x000066DA
			[global::Cpp2ILInjected.Token(Token = "0x60013FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32778", Offset = "0x1E32778", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass240_0()
			{
				throw null;
			}

			// Token: 0x06001ECA RID: 7882 RVA: 0x000084DD File Offset: 0x000066DD
			[global::Cpp2ILInjected.Token(Token = "0x60013FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32780", Offset = "0x1E32780", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsFaulted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Exception", ReturnType = typeof(AggregateException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCanceled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Result", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <BeginConnect>b__0(Task<IPAddress[]> t)
			{
				throw null;
			}

			// Token: 0x04001378 RID: 4984
			[global::Cpp2ILInjected.Token(Token = "0x4000FDC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public SocketAsyncResult sockares;
		}

		// Token: 0x0200044F RID: 1103
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002F4")]
		private sealed class <>c__DisplayClass298_0
		{
			// Token: 0x06001ECB RID: 7883 RVA: 0x000084E0 File Offset: 0x000066E0
			[global::Cpp2ILInjected.Token(Token = "0x60013FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32890", Offset = "0x1E32890", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
			{
				typeof(SocketAsyncResult),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass298_0()
			{
				throw null;
			}

			// Token: 0x06001ECC RID: 7884 RVA: 0x000084E3 File Offset: 0x000066E3
			[global::Cpp2ILInjected.Token(Token = "0x60013FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32898", Offset = "0x1E32898", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
			{
				typeof(SocketAsyncResult),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void <BeginSendCallback>b__0(IOAsyncResult s)
			{
				throw null;
			}

			// Token: 0x04001379 RID: 4985
			[global::Cpp2ILInjected.Token(Token = "0x4000FDD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int sent_so_far;
		}

		// Token: 0x02000450 RID: 1104
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002F5")]
		private sealed class <>c__DisplayClass355_0
		{
			// Token: 0x06001ECD RID: 7885 RVA: 0x000084E6 File Offset: 0x000066E6
			[global::Cpp2ILInjected.Token(Token = "0x60013FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3293C", Offset = "0x1E3293C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
			{
				typeof(SemaphoreSlim),
				typeof(IntPtr),
				typeof(IOSelectorJob)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass355_0()
			{
				throw null;
			}

			// Token: 0x06001ECE RID: 7886 RVA: 0x000084E9 File Offset: 0x000066E9
			[global::Cpp2ILInjected.Token(Token = "0x60013FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32944", Offset = "0x1E32944", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_CleanedUp", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelectorJob), Member = "MarkDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IOSelectorJob)
			}, ReturnType = typeof(void))]
			internal void <QueueIOSelectorJob>b__0(Task t)
			{
				throw null;
			}

			// Token: 0x0400137A RID: 4986
			[global::Cpp2ILInjected.Token(Token = "0x4000FDE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Socket <>4__this;

			// Token: 0x0400137B RID: 4987
			[global::Cpp2ILInjected.Token(Token = "0x4000FDF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public IOSelectorJob job;

			// Token: 0x0400137C RID: 4988
			[global::Cpp2ILInjected.Token(Token = "0x4000FE0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public IntPtr handle;
		}
	}
}
