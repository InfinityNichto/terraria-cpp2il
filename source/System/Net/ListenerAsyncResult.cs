using System;
using System.Collections.Specialized;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000261")]
	internal class ListenerAsyncResult : IAsyncResult
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00F50", Offset = "0x1E00F50", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void InvokeCallback(object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01080", Offset = "0x1E01080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "RegisterContext", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void Complete(HttpListenerContext context)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01508", Offset = "0x1E01508", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal HttpListenerContext GetContext()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000CE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ManualResetEvent handle;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool synch;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool completed;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private AsyncCallback cb;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object state;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Exception exception;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private HttpListenerContext context;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object locker;

		[global::Cpp2ILInjected.Token(Token = "0x4000CEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ListenerAsyncResult forward;

		[global::Cpp2ILInjected.Token(Token = "0x4000CEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal bool EndCalled;

		[global::Cpp2ILInjected.Token(Token = "0x4000CEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		internal bool InGet;

		[global::Cpp2ILInjected.Token(Token = "0x4000CED")]
		private static WaitCallback InvokeCB;
	}
}
