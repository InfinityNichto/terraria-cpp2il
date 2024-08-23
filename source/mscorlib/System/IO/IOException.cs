using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000472 RID: 1138
	[global::Cpp2ILInjected.Token(Token = "0x2000538")]
	[global::System.Serializable]
	public class IOException : global::System.SystemException
	{
		// Token: 0x060024A5 RID: 9381 RVA: 0x0001AAFB File Offset: 0x00018CFB
		[global::Cpp2ILInjected.Token(Token = "0x6002749")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9669C", Offset = "0x1B9669C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsyncInner>d__47", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IOException()
		{
			throw null;
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0001AAFE File Offset: 0x00018CFE
		[global::Cpp2ILInjected.Token(Token = "0x600274A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95A38", Offset = "0x1B95A38", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public IOException(string message)
		{
			throw null;
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0001AB01 File Offset: 0x00018D01
		[global::Cpp2ILInjected.Token(Token = "0x600274B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B966F8", Offset = "0x1B966F8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetIOException", MemberParameters = new object[] { typeof(global::Interop.ErrorInfo) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new object[] { typeof(MonoIOError) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(MonoIOError)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public IOException(string message, int hresult)
		{
			throw null;
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0001AB04 File Offset: 0x00018D04
		[global::Cpp2ILInjected.Token(Token = "0x600274C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96720", Offset = "0x1B96720", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryReader), Member = "ReadDecimal", ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "GetIOException", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(string)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new object[] { "System.Span`1<Byte>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new object[] { "System.ReadOnlySpan`1<Byte>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "BeginRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "BeginWrite", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			"System.ReadOnlyMemory`1<Byte>",
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "CreateException", MemberParameters = new object[] { "System.Net.Sockets.SocketError" }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "GetException", MemberParameters = new object[]
		{
			"System.Net.Sockets.SocketError",
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public IOException(string message, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0001AB07 File Offset: 0x00018D07
		[global::Cpp2ILInjected.Token(Token = "0x600274D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95A88", Offset = "0x1B95A88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected IOException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
