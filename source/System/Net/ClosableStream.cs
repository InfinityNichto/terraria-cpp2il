using System;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000D3 RID: 211
	[global::Cpp2ILInjected.Token(Token = "0x2000138")]
	internal class ClosableStream : DelegatedStream
	{
		// Token: 0x0600069E RID: 1694 RVA: 0x0000412D File Offset: 0x0000232D
		[global::Cpp2ILInjected.Token(Token = "0x600075F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7640", Offset = "0x1EE7640", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatedStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		internal ClosableStream(Stream stream, EventHandler onClose)
		{
			throw null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00004130 File Offset: 0x00002330
		[global::Cpp2ILInjected.Token(Token = "0x6000760")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7664", Offset = "0x1EE7664", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04000463 RID: 1123
		[global::Cpp2ILInjected.Token(Token = "0x40005E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly EventHandler _onClose;

		// Token: 0x04000464 RID: 1124
		[global::Cpp2ILInjected.Token(Token = "0x40005EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _closed;
	}
}
