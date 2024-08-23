using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200004B RID: 75
	[global::Cpp2ILInjected.Token(Token = "0x200009C")]
	[StructLayout(0)]
	internal class IOSelectorJob : IThreadPoolWorkItem
	{
		// Token: 0x06000238 RID: 568 RVA: 0x0000346A File Offset: 0x0000166A
		[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7588", Offset = "0x1EA7588", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "AcceptAsync", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginAccept", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new object[]
		{
			typeof(SocketAsyncResult),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state)
		{
			throw null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000346D File Offset: 0x0000166D
		[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA75C4", Offset = "0x1EA75C4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		{
			throw null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003470 File Offset: 0x00001670
		[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA75D8", Offset = "0x1EA75D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
			throw null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00003473 File Offset: 0x00001673
		[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA75DC", Offset = "0x1EA75DC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c__DisplayClass355_0", Member = "<QueueIOSelectorJob>b__0", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(IntPtr),
			typeof(IOSelectorJob)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void MarkDisposed()
		{
			throw null;
		}

		// Token: 0x04000144 RID: 324
		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IOOperation operation;

		// Token: 0x04000145 RID: 325
		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IOAsyncCallback callback;

		// Token: 0x04000146 RID: 326
		[global::Cpp2ILInjected.Token(Token = "0x400026F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IOAsyncResult state;
	}
}
