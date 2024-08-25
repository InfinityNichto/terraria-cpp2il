using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200028A")]
	internal class WebOperation
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700041F")]
		public HttpWebRequest Request
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13B88", Offset = "0x1E13B88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000420")]
		public WebConnection Connection
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13B90", Offset = "0x1E13B90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13B98", Offset = "0x1E13B98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000421")]
		public ServicePoint ServicePoint
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13BA0", Offset = "0x1E13BA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13BA8", Offset = "0x1E13BA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000422")]
		public BufferOffsetSize WriteBuffer
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13BB0", Offset = "0x1E13BB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000423")]
		public bool IsNtlmChallenge
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13BB8", Offset = "0x1E13BB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000424")]
		internal string ME
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13BC0", Offset = "0x1E13BC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E13BC8", Offset = "0x1E13BC8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BufferOffsetSize),
			typeof(CancellationToken)
		}, ReturnType = typeof(WebOperation))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "HandleNtlmAuth", MemberParameters = new object[]
		{
			typeof(WebResponseStream),
			typeof(HttpWebResponse),
			typeof(BufferOffsetSize),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTuple<WebOperation, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(CancellationTokenSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<>), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000425")]
		public bool Aborted
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13D58", Offset = "0x1E13D58", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "get_Closed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "CheckDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(ExceptionDispatchInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<>c__DisplayClass41_0", Member = "<ProcessRead>b__2", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new object[]
			{
				typeof(WebExceptionStatus),
				typeof(Exception),
				typeof(string)
			}, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000426")]
		public bool Closed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E13DA0", Offset = "0x1E13DA0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E13DCC", Offset = "0x1E13DCC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<>c__DisplayClass41_0", Member = "<ProcessRead>b__1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new object[] { typeof(ref ExceptionDispatchInfo) }, ReturnType = typeof(ValueTuple<ExceptionDispatchInfo, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Close", ReturnType = typeof(void))]
		public void Abort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E13FB4", Offset = "0x1E13FB4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new object[] { typeof(ref ExceptionDispatchInfo) }, ReturnType = typeof(ValueTuple<ExceptionDispatchInfo, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E13EF4", Offset = "0x1E13EF4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation.<Run>d__58), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetCanceled", MemberParameters = new object[] { typeof(OperationCanceledException) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void SetCanceled()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14280", Offset = "0x1E14280", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation.<Run>d__58), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new object[]
		{
			typeof(WebRequestStream),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetError(Exception error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E13E0C", Offset = "0x1E13E0C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "CheckThrowDisposed", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ref ExceptionDispatchInfo)
		}, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "<RegisterRequest>b__48_0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1431C", Offset = "0x1E1431C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CheckThrowDisposed", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ref ExceptionDispatchInfo)
		}, ReturnType = typeof(ExceptionDispatchInfo))]
		internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E143B8", Offset = "0x1E143B8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "get_WriteStream", ReturnType = typeof(WebRequestStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ThrowIfDisposed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14418", Offset = "0x1E14418", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebReadStream.<ReadAsync>d__28", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebReadStream), Member = "FinishReading", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CheckThrowDisposed", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ref ExceptionDispatchInfo)
		}, ReturnType = typeof(ExceptionDispatchInfo))]
		internal void ThrowIfDisposed(CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001200")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1445C", Offset = "0x1E1445C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation.<Run>d__58), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebReadStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebReadStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ThrowIfClosedOrDisposed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001201")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E144BC", Offset = "0x1E144BC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<InitConnection>d__19", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<FinishWriting>d__31", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<ProcessWrite>d__34", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<Initialize>d__36", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<SetHeadersAsync>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer_inner>d__39", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<InitReadAsync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CheckThrowDisposed", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ref ExceptionDispatchInfo)
		}, ReturnType = typeof(ExceptionDispatchInfo))]
		internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001202")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14368", Offset = "0x1E14368", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "CheckDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new object[] { typeof(ref ExceptionDispatchInfo) }, ReturnType = typeof(ValueTuple<ExceptionDispatchInfo, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001203")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14508", Offset = "0x1E14508", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001204")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14740", Offset = "0x1E14740", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "HandleNtlmAuth", MemberParameters = new object[]
		{
			typeof(WebResponseStream),
			typeof(HttpWebResponse),
			typeof(BufferOffsetSize),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTuple<WebOperation, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void SetPriorityRequest(WebOperation operation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001205")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E148BC", Offset = "0x1E148BC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebOperation.<GetRequestStream>d__50) }, MemberParameters = new object[] { typeof(ref WebOperation.<GetRequestStream>d__50) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Task<Stream> GetRequestStream()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001206")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E149AC", Offset = "0x1E149AC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "WaitForCompletion", ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Task<WebRequestStream> GetRequestStreamInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001207")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E149F4", Offset = "0x1E149F4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "WaitForCompletion", ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task WaitUntilRequestWritten()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000427")]
		public WebRequestStream WriteStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001208")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E14A3C", Offset = "0x1E14A3C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001209")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14A54", Offset = "0x1E14A54", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "WaitForCompletion", ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task<WebResponseStream> GetResponseStream()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000428")]
		internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished
		{
			[global::Cpp2ILInjected.Token(Token = "0x600120A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E14A9C", Offset = "0x1E14A9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600120B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14AA4", Offset = "0x1E14AA4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebOperation.<Run>d__58) }, MemberParameters = new object[] { typeof(ref WebOperation.<Run>d__58) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void Run()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600120C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14B38", Offset = "0x1E14B38", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<FinishWriting>d__31", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "CheckWriteOverflow", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "Close_internal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetCompleted", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void CompleteRequestWritten(WebRequestStream stream, Exception error = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600120D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14060", Offset = "0x1E14060", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Close_internal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<, >), Member = ".ctor", MemberParameters = new object[] { "T1", "T2" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<>), Member = "TrySetCompleted", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal void Finish(bool ok, Exception error = null)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600120E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E14BB0", Offset = "0x1E14BB0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new object[] { typeof(ref ExceptionDispatchInfo) }, ReturnType = typeof(ValueTuple<ExceptionDispatchInfo, bool>))]
		private void <RegisterRequest>b__48_0()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly HttpWebRequest <Request>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private WebConnection <Connection>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DF0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ServicePoint <ServicePoint>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly BufferOffsetSize <WriteBuffer>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly bool <IsNtlmChallenge>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal readonly int ID;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private CancellationTokenSource cts;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private WebCompletionSource<WebRequestStream> requestTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private WebCompletionSource<WebRequestStream> requestWrittenTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private WebCompletionSource<WebResponseStream> responseTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private WebRequestStream writeStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000DFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private WebResponseStream responseStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000DFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ExceptionDispatchInfo disposedInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000DFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ExceptionDispatchInfo closedInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000DFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private WebOperation priorityRequest;

		[global::Cpp2ILInjected.Token(Token = "0x4000DFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int requestSent;

		[global::Cpp2ILInjected.Token(Token = "0x4000DFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int finished;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200028B")]
		[StructLayout(3)]
		private struct <GetRequestStream>d__50 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x600120F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E14BC4", Offset = "0x1E14BC4", Length = "0x1FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "WaitForCompletion", ReturnType = "System.Threading.Tasks.Task`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(WebOperation.<GetRequestStream>d__50)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref WebOperation.<GetRequestStream>d__50)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001210")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E14DC0", Offset = "0x1E14DC0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000E00")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000E01")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Stream> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000E02")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebOperation <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000E03")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter <>u__1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200028C")]
		[StructLayout(3)]
		private struct <Run>d__58 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001211")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E14E18", Offset = "0x1E14E18", Length = "0x4DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "InitConnection", MemberParameters = new object[]
			{
				typeof(WebOperation),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task<WebRequestStream>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "Initialize", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetCompleted", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = ".ctor", MemberParameters = new object[] { typeof(WebRequestStream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "InitReadAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebOperation.<Run>d__58)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebOperation.<Run>d__58)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(WebOperation.<Run>d__58)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref WebOperation.<Run>d__58)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001212")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E15524", Offset = "0x1E15524", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000E04")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000E05")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000E06")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebOperation <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000E07")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private WebRequestStream <requestStream>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000E08")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private WebResponseStream <stream>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x4000E09")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000E0A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
