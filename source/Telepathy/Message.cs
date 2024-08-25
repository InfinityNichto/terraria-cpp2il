using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Telepathy
{
	[global::Cpp2ILInjected.Token(Token = "0x2000315")]
	public struct Message
	{
		[global::Cpp2ILInjected.Token(Token = "0x600126D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA78A00", Offset = "0xA78A00", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Message(int connectionId, EventType eventType, byte[] data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002205")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly int connectionId;

		[global::Cpp2ILInjected.Token(Token = "0x4002206")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly EventType eventType;

		[global::Cpp2ILInjected.Token(Token = "0x4002207")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly byte[] data;
	}
}
