using System;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000138")]
	internal class ClosableStream : DelegatedStream
	{
		[global::Cpp2ILInjected.Token(Token = "0x600075F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7640", Offset = "0x1EE7640", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatedStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		internal ClosableStream(Stream stream, EventHandler onClose)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40005E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly EventHandler _onClose;

		[global::Cpp2ILInjected.Token(Token = "0x40005EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _closed;
	}
}
