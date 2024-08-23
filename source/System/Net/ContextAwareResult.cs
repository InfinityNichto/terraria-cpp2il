using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000C0 RID: 192
	[global::Cpp2ILInjected.Token(Token = "0x200011E")]
	internal class ContextAwareResult : LazyAsyncResult
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00003FB9 File Offset: 0x000021B9
		[global::Cpp2ILInjected.Token(Token = "0x60006CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF82C", Offset = "0x1EDF82C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SafeCaptureIdentity()
		{
			throw null;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00003FBC File Offset: 0x000021BC
		[global::Cpp2ILInjected.Token(Token = "0x60006CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF830", Offset = "0x1EDF830", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void CleanupInternal()
		{
			throw null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00003FBF File Offset: 0x000021BF
		[global::Cpp2ILInjected.Token(Token = "0x60006CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF834", Offset = "0x1EDF834", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack)
		{
			throw null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00003FC2 File Offset: 0x000021C2
		[global::Cpp2ILInjected.Token(Token = "0x60006D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF83C", Offset = "0x1EDF83C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack)
		{
			throw null;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00003FC5 File Offset: 0x000021C5
		[global::Cpp2ILInjected.Token(Token = "0x60006D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF88C", Offset = "0x1EDF88C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack)
		{
			throw null;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00003FC8 File Offset: 0x000021C8
		[global::Cpp2ILInjected.Token(Token = "0x17000178")]
		internal ExecutionContext ContextCopy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDF904", Offset = "0x1EDF904", Length = "0x274")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00003FCB File Offset: 0x000021CB
		[global::Cpp2ILInjected.Token(Token = "0x60006D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDFC3C", Offset = "0x1EDFC3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal object StartPostingAsyncOp()
		{
			throw null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00003FCE File Offset: 0x000021CE
		[global::Cpp2ILInjected.Token(Token = "0x60006D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDFC44", Offset = "0x1EDFC44", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal object StartPostingAsyncOp(bool lockCapture)
		{
			throw null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00003FD1 File Offset: 0x000021D1
		[global::Cpp2ILInjected.Token(Token = "0x60006D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDFD34", Offset = "0x1EDFD34", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new object[]
		{
			typeof(ref ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		internal bool FinishPostingAsyncOp()
		{
			throw null;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00003FD4 File Offset: 0x000021D4
		[global::Cpp2ILInjected.Token(Token = "0x60006D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE013C", Offset = "0x1EE013C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new object[]
		{
			typeof(ref ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool FinishPostingAsyncOp(ref CallbackClosure closure)
		{
			throw null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00003FD7 File Offset: 0x000021D7
		[global::Cpp2ILInjected.Token(Token = "0x60006D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE02A0", Offset = "0x1EE02A0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void Cleanup()
		{
			throw null;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00003FDA File Offset: 0x000021DA
		[global::Cpp2ILInjected.Token(Token = "0x60006D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDFD78", Offset = "0x1EDFD78", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "FinishPostingAsyncOp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "FinishPostingAsyncOp", MemberParameters = new object[] { typeof(ref CallbackClosure) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_CompletedSynchronously", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext)
		{
			throw null;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00003FDD File Offset: 0x000021DD
		[global::Cpp2ILInjected.Token(Token = "0x60006D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0548", Offset = "0x1EE0548", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_CompletedSynchronously", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		protected override void Complete(IntPtr userToken)
		{
			throw null;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00003FE0 File Offset: 0x000021E0
		[global::Cpp2ILInjected.Token(Token = "0x60006DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE080C", Offset = "0x1EE080C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult.<>c), Member = "<Complete>b__17_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CompleteCallback()
		{
			throw null;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00003FE3 File Offset: 0x000021E3
		[global::Cpp2ILInjected.Token(Token = "0x17000179")]
		internal virtual EndPoint RemoteEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE08DC", Offset = "0x1EE08DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040003D4 RID: 980
		[global::Cpp2ILInjected.Token(Token = "0x400053E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ExecutionContext _context;

		// Token: 0x040003D5 RID: 981
		[global::Cpp2ILInjected.Token(Token = "0x400053F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private object _lock;

		// Token: 0x040003D6 RID: 982
		[global::Cpp2ILInjected.Token(Token = "0x4000540")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ContextAwareResult.StateFlags _flags;

		// Token: 0x020003C6 RID: 966
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200011F")]
		private enum StateFlags : byte
		{
			// Token: 0x0400111C RID: 4380
			[global::Cpp2ILInjected.Token(Token = "0x4000542")]
			None = 0,
			// Token: 0x0400111D RID: 4381
			[global::Cpp2ILInjected.Token(Token = "0x4000543")]
			CaptureIdentity = 1,
			// Token: 0x0400111E RID: 4382
			[global::Cpp2ILInjected.Token(Token = "0x4000544")]
			CaptureContext = 2,
			// Token: 0x0400111F RID: 4383
			[global::Cpp2ILInjected.Token(Token = "0x4000545")]
			ThreadSafeContextCopy = 4,
			// Token: 0x04001120 RID: 4384
			[global::Cpp2ILInjected.Token(Token = "0x4000546")]
			PostBlockStarted = 8,
			// Token: 0x04001121 RID: 4385
			[global::Cpp2ILInjected.Token(Token = "0x4000547")]
			PostBlockFinished = 16
		}

		// Token: 0x020003C7 RID: 967
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000120")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001D4F RID: 7503 RVA: 0x000080E1 File Offset: 0x000062E1
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60006DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE08E4", Offset = "0x1EE08E4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06001D50 RID: 7504 RVA: 0x000080E4 File Offset: 0x000062E4
			[global::Cpp2ILInjected.Token(Token = "0x60006DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE0940", Offset = "0x1EE0940", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06001D51 RID: 7505 RVA: 0x000080E7 File Offset: 0x000062E7
			[global::Cpp2ILInjected.Token(Token = "0x60006DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE0948", Offset = "0x1EE0948", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = "CompleteCallback", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <Complete>b__17_0(object s)
			{
				throw null;
			}

			// Token: 0x04001122 RID: 4386
			[global::Cpp2ILInjected.Token(Token = "0x4000548")]
			public static readonly ContextAwareResult.<>c <>9;

			// Token: 0x04001123 RID: 4387
			[global::Cpp2ILInjected.Token(Token = "0x4000549")]
			public static ContextCallback <>9__17_0;
		}
	}
}
