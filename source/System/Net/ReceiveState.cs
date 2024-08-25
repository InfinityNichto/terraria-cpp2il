using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000148")]
	internal class ReceiveState
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000800")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EECBB0", Offset = "0x1EECBB0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseDescription), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal ReceiveState(CommandStream connection)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000672")]
		private const int bufferSize = 1024;

		[global::Cpp2ILInjected.Token(Token = "0x4000673")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ResponseDescription Resp;

		[global::Cpp2ILInjected.Token(Token = "0x4000674")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int ValidThrough;

		[global::Cpp2ILInjected.Token(Token = "0x4000675")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal byte[] Buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000676")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal CommandStream Connection;
	}
}
