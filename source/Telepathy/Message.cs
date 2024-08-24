using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Telepathy
{
	// Token: 0x02000257 RID: 599
	[global::Cpp2ILInjected.Token(Token = "0x2000315")]
	public struct Message
	{
		// Token: 0x06001116 RID: 4374 RVA: 0x00024E24 File Offset: 0x00023024
		[global::Cpp2ILInjected.Token(Token = "0x600126D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA78A00", Offset = "0xA78A00", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Message(int connectionId, EventType eventType, byte[] data)
		{
			throw null;
		}

		// Token: 0x04001C35 RID: 7221
		[global::Cpp2ILInjected.Token(Token = "0x4002205")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly int connectionId;

		// Token: 0x04001C36 RID: 7222
		[global::Cpp2ILInjected.Token(Token = "0x4002206")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly EventType eventType;

		// Token: 0x04001C37 RID: 7223
		[global::Cpp2ILInjected.Token(Token = "0x4002207")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly byte[] data;
	}
}
