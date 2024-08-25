using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::Cpp2ILInjected.Token(Token = "0x20000D5")]
	internal class AsyncStreamReader
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC7400", Offset = "0x1EC7400", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC7410", Offset = "0x1EC7410", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "Cancel", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(ref MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC7750", Offset = "0x1EC7750", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void CancelOperation()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC775C", Offset = "0x1EC775C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void WaitUtilEOF()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Stream stream;

		[global::Cpp2ILInjected.Token(Token = "0x40003C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Encoding encoding;

		[global::Cpp2ILInjected.Token(Token = "0x40003C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Decoder decoder;

		[global::Cpp2ILInjected.Token(Token = "0x40003C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] byteBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x40003C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private char[] charBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x40003C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool cancelOperation;

		[global::Cpp2ILInjected.Token(Token = "0x40003C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ManualResetEvent eofEvent;

		[global::Cpp2ILInjected.Token(Token = "0x40003C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private object syncObject;

		[global::Cpp2ILInjected.Token(Token = "0x40003C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private IAsyncResult asyncReadResult;
	}
}
