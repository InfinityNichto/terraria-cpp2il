using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x2000568")]
	internal class FileStreamAsyncResult : global::System.IAsyncResult
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4001648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object state;

		[global::Cpp2ILInjected.Token(Token = "0x4001649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool completed;

		[global::Cpp2ILInjected.Token(Token = "0x400164A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Threading.ManualResetEvent wh;

		[global::Cpp2ILInjected.Token(Token = "0x400164B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.AsyncCallback cb;

		[global::Cpp2ILInjected.Token(Token = "0x400164C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool completedSynch;

		[global::Cpp2ILInjected.Token(Token = "0x400164D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int Count;

		[global::Cpp2ILInjected.Token(Token = "0x400164E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int OriginalCount;

		[global::Cpp2ILInjected.Token(Token = "0x400164F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int BytesRead;

		[global::Cpp2ILInjected.Token(Token = "0x4001650")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.AsyncCallback realcb;
	}
}
