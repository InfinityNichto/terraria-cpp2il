using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200004A RID: 74
	[global::Cpp2ILInjected.Token(Token = "0x200009B")]
	[StructLayout(0)]
	internal abstract class IOAsyncResult : IAsyncResult
	{
		// Token: 0x0600022D RID: 557 RVA: 0x0000344C File Offset: 0x0000164C
		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7318", Offset = "0x1EA7318", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected IOAsyncResult()
		{
			throw null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000344F File Offset: 0x0000164F
		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7320", Offset = "0x1EA7320", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Init", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		protected void Init(AsyncCallback async_callback, object async_state)
		{
			throw null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00003452 File Offset: 0x00001652
		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7340", Offset = "0x1EA7340", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(AsyncCallback),
			typeof(object),
			typeof(SocketOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected IOAsyncResult(AsyncCallback async_callback, object async_state)
		{
			throw null;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00003455 File Offset: 0x00001655
		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		public AsyncCallback AsyncCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA736C", Offset = "0x1EA736C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00003458 File Offset: 0x00001658
		[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
		public object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA7374", Offset = "0x1EA7374", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000345B File Offset: 0x0000165B
		[global::Cpp2ILInjected.Token(Token = "0x1700008F")]
		public WaitHandle AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA737C", Offset = "0x1EA737C", Length = "0x118")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new object[]
			{
				typeof(SocketAsyncResult),
				typeof(SocketAsyncEventArgs)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[]
			{
				typeof(IAsyncResult),
				typeof(ref SocketError)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000345E File Offset: 0x0000165E
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00003461 File Offset: 0x00001661
		[global::Cpp2ILInjected.Token(Token = "0x17000090")]
		public bool CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA7494", Offset = "0x1EA7494", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA749C", Offset = "0x1EA749C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00003464 File Offset: 0x00001664
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00003467 File Offset: 0x00001667
		[global::Cpp2ILInjected.Token(Token = "0x17000091")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA74A8", Offset = "0x1EA74A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA74B0", Offset = "0x1EA74B0", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06000237 RID: 567
		[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
		internal abstract void CompleteDisposed();

		// Token: 0x0400013F RID: 319
		[global::Cpp2ILInjected.Token(Token = "0x4000268")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private AsyncCallback async_callback;

		// Token: 0x04000140 RID: 320
		[global::Cpp2ILInjected.Token(Token = "0x4000269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object async_state;

		// Token: 0x04000141 RID: 321
		[global::Cpp2ILInjected.Token(Token = "0x400026A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ManualResetEvent wait_handle;

		// Token: 0x04000142 RID: 322
		[global::Cpp2ILInjected.Token(Token = "0x400026B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool completed_synchronously;

		// Token: 0x04000143 RID: 323
		[global::Cpp2ILInjected.Token(Token = "0x400026C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool completed;
	}
}
