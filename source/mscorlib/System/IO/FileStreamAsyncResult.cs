using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000493 RID: 1171
	[global::Cpp2ILInjected.Token(Token = "0x2000568")]
	internal class FileStreamAsyncResult : global::System.IAsyncResult
	{
		// Token: 0x06002686 RID: 9862 RVA: 0x0001B07A File Offset: 0x0001927A
		[global::Cpp2ILInjected.Token(Token = "0x600299F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCD164", Offset = "0x1BCD164", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public FileStreamAsyncResult(global::System.AsyncCallback cb, object state)
		{
			throw null;
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x0001B07D File Offset: 0x0001927D
		[global::Cpp2ILInjected.Token(Token = "0x60029A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE10C", Offset = "0x1BCE10C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AsyncCallback), Member = "BeginInvoke", MemberParameters = new object[]
		{
			typeof(global::System.IAsyncResult),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void CBWrapper(global::System.IAsyncResult ares)
		{
			throw null;
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0001B080 File Offset: 0x00019280
		[global::Cpp2ILInjected.Token(Token = "0x170005FB")]
		public object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE198", Offset = "0x1BCE198", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x0001B083 File Offset: 0x00019283
		[global::Cpp2ILInjected.Token(Token = "0x170005FC")]
		public bool CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE1A0", Offset = "0x1BCE1A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x0001B086 File Offset: 0x00019286
		[global::Cpp2ILInjected.Token(Token = "0x170005FD")]
		public global::System.Threading.WaitHandle AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE1A8", Offset = "0x1BCE1A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x0001B089 File Offset: 0x00019289
		[global::Cpp2ILInjected.Token(Token = "0x170005FE")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x60029A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BCE1B0", Offset = "0x1BCE1B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040012FC RID: 4860
		[global::Cpp2ILInjected.Token(Token = "0x4001648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object state;

		// Token: 0x040012FD RID: 4861
		[global::Cpp2ILInjected.Token(Token = "0x4001649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool completed;

		// Token: 0x040012FE RID: 4862
		[global::Cpp2ILInjected.Token(Token = "0x400164A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Threading.ManualResetEvent wh;

		// Token: 0x040012FF RID: 4863
		[global::Cpp2ILInjected.Token(Token = "0x400164B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.AsyncCallback cb;

		// Token: 0x04001300 RID: 4864
		[global::Cpp2ILInjected.Token(Token = "0x400164C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool completedSynch;

		// Token: 0x04001301 RID: 4865
		[global::Cpp2ILInjected.Token(Token = "0x400164D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int Count;

		// Token: 0x04001302 RID: 4866
		[global::Cpp2ILInjected.Token(Token = "0x400164E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int OriginalCount;

		// Token: 0x04001303 RID: 4867
		[global::Cpp2ILInjected.Token(Token = "0x400164F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int BytesRead;

		// Token: 0x04001304 RID: 4868
		[global::Cpp2ILInjected.Token(Token = "0x4001650")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.AsyncCallback realcb;
	}
}
