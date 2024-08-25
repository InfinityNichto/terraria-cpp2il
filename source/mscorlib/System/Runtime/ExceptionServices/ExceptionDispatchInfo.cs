using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Runtime.ExceptionServices
{
	[global::Cpp2ILInjected.Token(Token = "0x200045C")]
	public sealed class ExceptionDispatchInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x60021E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72D48", Offset = "0x1B72D48", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.StackTrace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private ExceptionDispatchInfo(global::System.Exception exception)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000460")]
		internal object BinaryStackTraceArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x60021E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72E54", Offset = "0x1B72E54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60021E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7292C", Offset = "0x1B7292C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Runtime.Augments.RuntimeAugments), Member = "ReportUnhandledException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "SetCancellationException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.ICustomMarshaler))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Threading.SynchronizationContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.SynchronousAsyncResult", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<StartOperation>d__23", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<ProcessAuthentication>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<StartOperation>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "InternalRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "InternalWrite", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "ProcessHandshake", MemberParameters = new object[]
		{
			"Mono.Net.Security.AsyncOperationStatus",
			typeof(bool)
		}, ReturnType = "Mono.Net.Security.AsyncOperationStatus")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "TrySetCanceled", MemberParameters = new object[] { typeof(global::System.OperationCanceledException) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "TrySetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "SetDisposed", MemberParameters = new object[] { typeof(ref ExceptionDispatchInfo) }, ReturnType = "System.ValueTuple`2<ExceptionDispatchInfo, Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static ExceptionDispatchInfo Capture(global::System.Exception source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000461")]
		public global::System.Exception SourceException
		{
			[global::Cpp2ILInjected.Token(Token = "0x60021EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72E5C", Offset = "0x1B72E5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60021EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B729EC", Offset = "0x1B729EC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Runtime.Augments.RuntimeAugments), Member = "ReportUnhandledException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.RendezvousAwaitable<>), Member = "GetResult", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.ICustomMarshaler))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.AsyncMethodBuilderCore.<>c", Member = "<ThrowAsync>b__7_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.AsyncMethodBuilderCore.<>c", Member = "<ThrowAsync>b__7_1", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.SynchronousAsyncResult", Member = "ThrowIfError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.SynchronousAsyncResult", Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.SynchronousAsyncResult", Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<ProcessAuthentication>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<StartOperation>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "CheckThrow", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "ProcessHandshake", MemberParameters = new object[]
		{
			"Mono.Net.Security.AsyncOperationStatus",
			typeof(bool)
		}, ReturnType = "Mono.Net.Security.AsyncOperationStatus")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "ProcessRead", MemberParameters = new object[] { "Mono.Net.Security.BufferOffsetSize" }, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "ProcessWrite", MemberParameters = new object[] { "Mono.Net.Security.BufferOffsetSize" }, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "get_InternalLocalCertificate", ReturnType = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebCompletionSource`1.<WaitForCompletion>d__15", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "ThrowOnError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "CheckThrowDisposed", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ref ExceptionDispatchInfo)
		}, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "RestoreExceptionDispatchInfo", MemberParameters = new object[] { typeof(ExceptionDispatchInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Throw()
		{
			throw null;
		}

		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60021EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72E64", Offset = "0x1B72E64", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpDataStream", Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "EndGetResponse", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = "System.Net.WebResponse")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetRequestStream", ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "TimedSubmitRequestHelper", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "DataStreamClosed", MemberParameters = new object[] { "System.Net.CloseExState" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		public static void Throw(global::System.Exception source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Exception m_Exception;

		[global::Cpp2ILInjected.Token(Token = "0x4001296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object m_stackTrace;
	}
}
