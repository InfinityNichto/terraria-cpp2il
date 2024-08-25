using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::System.Diagnostics.DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
	[global::Cpp2ILInjected.Token(Token = "0x20001C9")]
	public readonly struct CancellationToken
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000187")]
		public static CancellationToken None
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94604", Offset = "0x1C94604", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "BeginRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "BeginWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.ReadWriteTask", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(global::System.Func<object, int>),
				typeof(object),
				typeof(global::System.IO.Stream),
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "ReadAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "AuthenticateAsClient", MemberParameters = new object[]
			{
				typeof(string),
				"System.Security.Cryptography.X509Certificates.X509CertificateCollection",
				"System.Security.Authentication.SslProtocols",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "AuthenticateAsServer", MemberParameters = new object[]
			{
				typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate),
				typeof(bool),
				"System.Security.Authentication.SslProtocols",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "AuthenticateAsClientAsync", MemberParameters = new object[]
			{
				typeof(string),
				"System.Security.Cryptography.X509Certificates.X509CertificateCollection",
				"System.Security.Authentication.SslProtocols",
				typeof(bool)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "Read", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "Write", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.AsyncManualResetEvent", Member = "Set", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "Read", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "BeginRead", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "BeginWrite", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfClosedOrDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebReadStream", Member = "Read", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebReadStream", Member = "BeginRead", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "InvokeContinuation", MemberParameters = new object[]
			{
				"System.Action`1<Object>",
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BackgroundWorker", Member = "RunWorkerAsync", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "Take", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "BeginRead", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "BeginWrite", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000188")]
		public bool IsCancellationRequested
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9460C", Offset = "0x1C9460C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.DelayPromise", Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AssignCancellationToken", MemberParameters = new object[]
			{
				typeof(CancellationToken),
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.Threading.Tasks.TaskContinuation)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "ContinueWithCore", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.Threading.Tasks.TaskScheduler),
				typeof(CancellationToken),
				typeof(global::System.Threading.Tasks.TaskContinuationOptions)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCancellation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCancellation", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Run", MemberParameters = new object[]
			{
				typeof(global::System.Func<global::System.Threading.Tasks.Task>),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Run", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[]
			{
				"System.Func`1<Task`1<TResult>>",
				typeof(CancellationToken)
			}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Delay", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
			{
				typeof(global::System.Memory<byte>),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlyMemory<byte>),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new object[]
			{
				typeof(global::System.Memory<byte>),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlyMemory<byte>),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.NullStream", Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.NullStream", Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.NullStream", Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlyMemory<byte>),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "ReadAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "FlushAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "CheckDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream", Member = "WriteAsync", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "ProcessRead", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new object[]
			{
				"System.Memory`1<Byte>",
				"System.Net.Sockets.SocketFlags",
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
			{
				"System.ReadOnlyMemory`1<Byte>",
				"System.Net.Sockets.SocketFlags",
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryAddWithNoTimeValidation", MemberParameters = new object[]
			{
				"T",
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryTakeWithNoTimeValidation", MemberParameters = new object[]
			{
				"T&",
				typeof(int),
				typeof(CancellationToken),
				typeof(CancellationTokenSource)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.ChunkedMemoryStream", Member = "WriteAsync", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000189")]
		public bool CanBeCanceled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94654", Offset = "0x1C94654", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "TaskConstructorCore", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(object),
				typeof(CancellationToken),
				typeof(global::System.Threading.Tasks.TaskCreationOptions),
				typeof(global::System.Threading.Tasks.InternalTaskOptions),
				typeof(global::System.Threading.Tasks.TaskScheduler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "InternalWait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "ContinueWithCore", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.Threading.Tasks.TaskScheduler),
				typeof(CancellationToken),
				typeof(global::System.Threading.Tasks.TaskContinuationOptions)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Delay", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94664", Offset = "0x1C94664", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal CancellationToken(CancellationTokenSource source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9466C", Offset = "0x1C9466C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ValueTask), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask`1.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ValueTask<>), Member = "GetTaskForValueTaskSource", MemberParameters = new object[] { "System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>" }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CancellationToken(bool canceled)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C946E0", Offset = "0x1C946E0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new object[] { "System.Net.ServicePoint", "System.Net.WebConnection" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public CancellationTokenRegistration Register(global::System.Action callback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C948F4", Offset = "0x1C948F4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AssignCancellationToken", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Threading.Tasks.TaskContinuation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Delay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		internal CancellationTokenRegistration InternalRegisterWithoutEC(global::System.Action<object> callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C947C8", Offset = "0x1C947C8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.CancellationTokenSource.Linked1CancellationTokenSource", Member = ".ctor", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.CancellationTokenSource.Linked2CancellationTokenSource", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(SynchronizationContext),
			typeof(ExecutionContext)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		[MethodImpl(8)]
		public CancellationTokenRegistration Register(global::System.Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94C28", Offset = "0x1C94C28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(CancellationToken other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94C38", Offset = "0x1C94C38", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94CB0", Offset = "0x1C94CB0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94D1C", Offset = "0x1C94D1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "HandleException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(CancellationToken left, CancellationToken right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94D28", Offset = "0x1C94D28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "RecordInternalCancellationRequest", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator !=(CancellationToken left, CancellationToken right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94D34", Offset = "0x1C94D34", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitUntilCountOrTimeout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<InnerRead>d__66", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<InnerWrite>d__67", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.BufferedReadStream.<ProcessReadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FixedSizeReadStream.<ProcessReadAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsyncInner>d__47", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryAddWithNoTimeValidation", MemberParameters = new object[]
		{
			"T",
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryTakeWithNoTimeValidation", MemberParameters = new object[]
		{
			"T&",
			typeof(int),
			typeof(CancellationToken),
			typeof(CancellationTokenSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ThrowIfCancellationRequested()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94D6C", Offset = "0x1C94D6C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OperationCanceledException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ThrowOperationCanceledException()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60010DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94DC4", Offset = "0x1C94DC4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static CancellationToken()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000918")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly CancellationTokenSource _source;

		[global::Cpp2ILInjected.Token(Token = "0x4000919")]
		private static readonly global::System.Action<object> s_actionToActionObjShunt;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20001CA")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60010DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94E88", Offset = "0x1C94E88", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60010DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94EE4", Offset = "0x1C94EE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60010E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94EEC", Offset = "0x1C94EEC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <.cctor>b__26_0(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400091A")]
			public static readonly CancellationToken.<>c <>9;
		}
	}
}
