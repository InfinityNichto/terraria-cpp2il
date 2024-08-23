using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200019D RID: 413
	[global::Cpp2ILInjected.Token(Token = "0x2000254")]
	internal class HttpStreamAsyncResult : IAsyncResult
	{
		// Token: 0x06000DF8 RID: 3576 RVA: 0x00005627 File Offset: 0x00003827
		[global::Cpp2ILInjected.Token(Token = "0x6000F82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3FE28", Offset = "0x1F3FE28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStreamAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		public void Complete(Exception e)
		{
			throw null;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0000562A File Offset: 0x0000382A
		[global::Cpp2ILInjected.Token(Token = "0x6000F83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3F804", Offset = "0x1F3F804", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpStreamAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RequestStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = "BeginInvoke", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Complete()
		{
			throw null;
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x0000562D File Offset: 0x0000382D
		[global::Cpp2ILInjected.Token(Token = "0x17000357")]
		public object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F518F0", Offset = "0x1F518F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00005630 File Offset: 0x00003830
		[global::Cpp2ILInjected.Token(Token = "0x17000358")]
		public WaitHandle AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F85")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F518F8", Offset = "0x1F518F8", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00005633 File Offset: 0x00003833
		[global::Cpp2ILInjected.Token(Token = "0x17000359")]
		public bool CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51A28", Offset = "0x1F51A28", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00005636 File Offset: 0x00003836
		[global::Cpp2ILInjected.Token(Token = "0x1700035A")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51A3C", Offset = "0x1F51A3C", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		// Token: 0x06000DFE RID: 3582 RVA: 0x00005639 File Offset: 0x00003839
		[global::Cpp2ILInjected.Token(Token = "0x6000F88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3F7A4", Offset = "0x1F3F7A4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RequestStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HttpStreamAsyncResult()
		{
			throw null;
		}

		// Token: 0x040009A3 RID: 2467
		[global::Cpp2ILInjected.Token(Token = "0x4000C5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object locker;

		// Token: 0x040009A4 RID: 2468
		[global::Cpp2ILInjected.Token(Token = "0x4000C5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ManualResetEvent handle;

		// Token: 0x040009A5 RID: 2469
		[global::Cpp2ILInjected.Token(Token = "0x4000C5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool completed;

		// Token: 0x040009A6 RID: 2470
		[global::Cpp2ILInjected.Token(Token = "0x4000C5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal byte[] Buffer;

		// Token: 0x040009A7 RID: 2471
		[global::Cpp2ILInjected.Token(Token = "0x4000C5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int Offset;

		// Token: 0x040009A8 RID: 2472
		[global::Cpp2ILInjected.Token(Token = "0x4000C5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal int Count;

		// Token: 0x040009A9 RID: 2473
		[global::Cpp2ILInjected.Token(Token = "0x4000C60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal AsyncCallback Callback;

		// Token: 0x040009AA RID: 2474
		[global::Cpp2ILInjected.Token(Token = "0x4000C61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal object State;

		// Token: 0x040009AB RID: 2475
		[global::Cpp2ILInjected.Token(Token = "0x4000C62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int SynchRead;

		// Token: 0x040009AC RID: 2476
		[global::Cpp2ILInjected.Token(Token = "0x4000C63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal Exception Error;
	}
}
