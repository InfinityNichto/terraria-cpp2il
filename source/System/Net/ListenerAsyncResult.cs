using System;
using System.Collections.Specialized;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001A3 RID: 419
	[global::Cpp2ILInjected.Token(Token = "0x2000261")]
	internal class ListenerAsyncResult : IAsyncResult
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x00005885 File Offset: 0x00003A85
		[global::Cpp2ILInjected.Token(Token = "0x6001062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00CEC", Offset = "0x1E00CEC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ListenerAsyncResult(AsyncCallback cb, object state)
		{
			throw null;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00005888 File Offset: 0x00003A88
		[global::Cpp2ILInjected.Token(Token = "0x6001063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00D64", Offset = "0x1E00D64", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Cleanup", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void Complete(Exception exc)
		{
			throw null;
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0000588B File Offset: 0x00003A8B
		[global::Cpp2ILInjected.Token(Token = "0x6001064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00F50", Offset = "0x1E00F50", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void InvokeCallback(object o)
		{
			throw null;
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0000588E File Offset: 0x00003A8E
		[global::Cpp2ILInjected.Token(Token = "0x6001065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01080", Offset = "0x1E01080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "RegisterContext", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void Complete(HttpListenerContext context)
		{
			throw null;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00005891 File Offset: 0x00003A91
		[global::Cpp2ILInjected.Token(Token = "0x6001066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01088", Offset = "0x1E01088", Length = "0x480")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "SelectAuthenticationScheme", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(AuthenticationSchemes))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "get_OutputStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal void Complete(HttpListenerContext context, bool synch)
		{
			throw null;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00005894 File Offset: 0x00003A94
		[global::Cpp2ILInjected.Token(Token = "0x6001067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01508", Offset = "0x1E01508", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal HttpListenerContext GetContext()
		{
			throw null;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00005897 File Offset: 0x00003A97
		[global::Cpp2ILInjected.Token(Token = "0x170003A8")]
		public object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001068")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01544", Offset = "0x1E01544", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0000589A File Offset: 0x00003A9A
		[global::Cpp2ILInjected.Token(Token = "0x170003A9")]
		public WaitHandle AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001069")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01558", Offset = "0x1E01558", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(HttpListenerContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0000589D File Offset: 0x00003A9D
		[global::Cpp2ILInjected.Token(Token = "0x170003AA")]
		public bool CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x600106A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01684", Offset = "0x1E01684", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x000058A0 File Offset: 0x00003AA0
		[global::Cpp2ILInjected.Token(Token = "0x170003AB")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600106B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01698", Offset = "0x1E01698", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(HttpListenerContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000058A3 File Offset: 0x00003AA3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600106C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01778", Offset = "0x1E01778", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ListenerAsyncResult()
		{
			throw null;
		}

		// Token: 0x040009F8 RID: 2552
		[global::Cpp2ILInjected.Token(Token = "0x4000CE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ManualResetEvent handle;

		// Token: 0x040009F9 RID: 2553
		[global::Cpp2ILInjected.Token(Token = "0x4000CE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool synch;

		// Token: 0x040009FA RID: 2554
		[global::Cpp2ILInjected.Token(Token = "0x4000CE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool completed;

		// Token: 0x040009FB RID: 2555
		[global::Cpp2ILInjected.Token(Token = "0x4000CE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private AsyncCallback cb;

		// Token: 0x040009FC RID: 2556
		[global::Cpp2ILInjected.Token(Token = "0x4000CE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object state;

		// Token: 0x040009FD RID: 2557
		[global::Cpp2ILInjected.Token(Token = "0x4000CE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Exception exception;

		// Token: 0x040009FE RID: 2558
		[global::Cpp2ILInjected.Token(Token = "0x4000CE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private HttpListenerContext context;

		// Token: 0x040009FF RID: 2559
		[global::Cpp2ILInjected.Token(Token = "0x4000CE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object locker;

		// Token: 0x04000A00 RID: 2560
		[global::Cpp2ILInjected.Token(Token = "0x4000CEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ListenerAsyncResult forward;

		// Token: 0x04000A01 RID: 2561
		[global::Cpp2ILInjected.Token(Token = "0x4000CEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal bool EndCalled;

		// Token: 0x04000A02 RID: 2562
		[global::Cpp2ILInjected.Token(Token = "0x4000CEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		internal bool InGet;

		// Token: 0x04000A03 RID: 2563
		[global::Cpp2ILInjected.Token(Token = "0x4000CED")]
		private static WaitCallback InvokeCB;
	}
}
