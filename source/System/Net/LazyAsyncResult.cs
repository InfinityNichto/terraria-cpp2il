using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200015C RID: 348
	[global::Cpp2ILInjected.Token(Token = "0x20001EF")]
	internal class LazyAsyncResult : IAsyncResult
	{
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00004D21 File Offset: 0x00002F21
		[global::Cpp2ILInjected.Token(Token = "0x1700027A")]
		private static LazyAsyncResult.ThreadContext CurrentThreadContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F26018", Offset = "0x1F26018", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LazyAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00004D24 File Offset: 0x00002F24
		[global::Cpp2ILInjected.Token(Token = "0x6000C14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F260AC", Offset = "0x1F260AC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.ReadAsyncResult", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Base64Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Base64Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack)
		{
			throw null;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00004D27 File Offset: 0x00002F27
		[global::Cpp2ILInjected.Token(Token = "0x6000C15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2613C", Offset = "0x1F2613C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack, object result)
		{
			throw null;
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00004D2A File Offset: 0x00002F2A
		[global::Cpp2ILInjected.Token(Token = "0x1700027B")]
		internal object AsyncObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F261A8", Offset = "0x1F261A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00004D2D File Offset: 0x00002F2D
		[global::Cpp2ILInjected.Token(Token = "0x1700027C")]
		public object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F261B0", Offset = "0x1F261B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00004D30 File Offset: 0x00002F30
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00004D33 File Offset: 0x00002F33
		[global::Cpp2ILInjected.Token(Token = "0x1700027D")]
		protected AsyncCallback AsyncCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C18")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F261B8", Offset = "0x1F261B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000C19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F261C0", Offset = "0x1F261C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00004D36 File Offset: 0x00002F36
		[global::Cpp2ILInjected.Token(Token = "0x1700027E")]
		public WaitHandle AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F261C8", Offset = "0x1F261C8", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "LazilyCreateEvent", MemberParameters = new object[] { typeof(ref ManualResetEvent) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00004D39 File Offset: 0x00002F39
		[global::Cpp2ILInjected.Token(Token = "0x6000C1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2626C", Offset = "0x1F2626C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LazyAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LazyAsyncResult), Member = "WaitForCompletion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private bool LazilyCreateEvent(out ManualResetEvent waitHandle)
		{
			throw null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2640C", Offset = "0x1F2640C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void DebugProtectState(bool protect)
		{
			throw null;
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00004D3F File Offset: 0x00002F3F
		[global::Cpp2ILInjected.Token(Token = "0x1700027F")]
		public bool CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F26410", Offset = "0x1F26410", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new object[]
			{
				typeof(ref ExecutionContext),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "Complete", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00004D42 File Offset: 0x00002F42
		[global::Cpp2ILInjected.Token(Token = "0x17000280")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F26440", Offset = "0x1F26440", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.ReadAsyncResult", Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "OnWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "AsyncReadCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00004D45 File Offset: 0x00002F45
		[global::Cpp2ILInjected.Token(Token = "0x17000281")]
		internal bool InternalPeekCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F263FC", Offset = "0x1F263FC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "get_ContextCopy", ReturnType = typeof(ExecutionContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new object[]
			{
				typeof(ref ExecutionContext),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
			{
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00004D48 File Offset: 0x00002F48
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00004D4B File Offset: 0x00002F4B
		[global::Cpp2ILInjected.Token(Token = "0x17000282")]
		internal object Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F26470", Offset = "0x1F26470", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000C21")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F264E4", Offset = "0x1F264E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00004D4E File Offset: 0x00002F4E
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00004D51 File Offset: 0x00002F51
		[global::Cpp2ILInjected.Token(Token = "0x17000283")]
		internal bool EndCalled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F264EC", Offset = "0x1F264EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000C23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F264F4", Offset = "0x1F264F4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00004D54 File Offset: 0x00002F54
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00004D57 File Offset: 0x00002F57
		[global::Cpp2ILInjected.Token(Token = "0x17000284")]
		internal int ErrorCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F26500", Offset = "0x1F26500", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000C25")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F26508", Offset = "0x1F26508", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00004D5A File Offset: 0x00002F5A
		[global::Cpp2ILInjected.Token(Token = "0x6000C26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26510", Offset = "0x1F26510", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		protected void ProtectedInvokeCallback(object result, IntPtr userToken)
		{
			throw null;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00004D5D File Offset: 0x00002F5D
		[global::Cpp2ILInjected.Token(Token = "0x6000C27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F266E4", Offset = "0x1F266E4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.ReadAsyncResult", Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "OnWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "AsyncReadCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetResponseCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "ProtectedInvokeCallback", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InvokeCallback(object result)
		{
			throw null;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00004D60 File Offset: 0x00002F60
		[global::Cpp2ILInjected.Token(Token = "0x6000C28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26744", Offset = "0x1F26744", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.ReadAsyncResult", Member = "CompleteRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "Write", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "ProtectedInvokeCallback", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InvokeCallback()
		{
			throw null;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00004D63 File Offset: 0x00002F63
		[global::Cpp2ILInjected.Token(Token = "0x6000C29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26798", Offset = "0x1F26798", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new object[]
		{
			typeof(ref ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "Complete", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "CompleteCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_CurrentThreadContext", ReturnType = typeof(LazyAsyncResult.ThreadContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[] { typeof(WaitCallback) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected virtual void Complete(IntPtr userToken)
		{
			throw null;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00004D66 File Offset: 0x00002F66
		[global::Cpp2ILInjected.Token(Token = "0x6000C2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F268F4", Offset = "0x1F268F4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void WorkerThreadComplete(object state)
		{
			throw null;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00004D69 File Offset: 0x00002F69
		[global::Cpp2ILInjected.Token(Token = "0x6000C2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26998", Offset = "0x1F26998", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void Cleanup()
		{
			throw null;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00004D6C File Offset: 0x00002F6C
		[global::Cpp2ILInjected.Token(Token = "0x6000C2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2699C", Offset = "0x1F2699C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.ReadAsyncResult", Member = "End", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "End", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "DataStreamClosed", MemberParameters = new object[] { typeof(CloseExState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		internal object InternalWaitForCompletion()
		{
			throw null;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00004D6F File Offset: 0x00002F6F
		[global::Cpp2ILInjected.Token(Token = "0x6000C2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F269A4", Offset = "0x1F269A4", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "EndGetResponse", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "LazilyCreateEvent", MemberParameters = new object[] { typeof(ref ManualResetEvent) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "SpinWait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private object WaitForCompletion(bool snap)
		{
			throw null;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00004D72 File Offset: 0x00002F72
		[global::Cpp2ILInjected.Token(Token = "0x6000C2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26C40", Offset = "0x1F26C40", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InternalCleanup()
		{
			throw null;
		}

		// Token: 0x0400083F RID: 2111
		[global::Cpp2ILInjected.Token(Token = "0x4000A83")]
		private const int c_HighBit = -2147483648;

		// Token: 0x04000840 RID: 2112
		[global::Cpp2ILInjected.Token(Token = "0x4000A84")]
		private const int c_ForceAsyncCount = 50;

		// Token: 0x04000841 RID: 2113
		[ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000A85")]
		private static LazyAsyncResult.ThreadContext t_ThreadContext;

		// Token: 0x04000842 RID: 2114
		[global::Cpp2ILInjected.Token(Token = "0x4000A86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object m_AsyncObject;

		// Token: 0x04000843 RID: 2115
		[global::Cpp2ILInjected.Token(Token = "0x4000A87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object m_AsyncState;

		// Token: 0x04000844 RID: 2116
		[global::Cpp2ILInjected.Token(Token = "0x4000A88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private AsyncCallback m_AsyncCallback;

		// Token: 0x04000845 RID: 2117
		[global::Cpp2ILInjected.Token(Token = "0x4000A89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object m_Result;

		// Token: 0x04000846 RID: 2118
		[global::Cpp2ILInjected.Token(Token = "0x4000A8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int m_ErrorCode;

		// Token: 0x04000847 RID: 2119
		[global::Cpp2ILInjected.Token(Token = "0x4000A8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int m_IntCompleted;

		// Token: 0x04000848 RID: 2120
		[global::Cpp2ILInjected.Token(Token = "0x4000A8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool m_EndCalled;

		// Token: 0x04000849 RID: 2121
		[global::Cpp2ILInjected.Token(Token = "0x4000A8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		private bool m_UserEvent;

		// Token: 0x0400084A RID: 2122
		[global::Cpp2ILInjected.Token(Token = "0x4000A8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object m_Event;

		// Token: 0x020003FB RID: 1019
		[global::Cpp2ILInjected.Token(Token = "0x20001F0")]
		private class ThreadContext
		{
			// Token: 0x06001DCF RID: 7631 RVA: 0x00008255 File Offset: 0x00006455
			[global::Cpp2ILInjected.Token(Token = "0x6000C2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F260A4", Offset = "0x1F260A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ThreadContext()
			{
				throw null;
			}

			// Token: 0x040011F5 RID: 4597
			[global::Cpp2ILInjected.Token(Token = "0x4000A8F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal int m_NestedIOCount;
		}
	}
}
