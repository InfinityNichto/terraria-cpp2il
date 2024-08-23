using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x0200015D RID: 349
	[global::Cpp2ILInjected.Token(Token = "0x20001A9")]
	internal struct ConsoleScreenBufferInfo
	{
		// Token: 0x040006E0 RID: 1760
		[global::Cpp2ILInjected.Token(Token = "0x40008BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.Coord Size;

		// Token: 0x040006E1 RID: 1761
		[global::Cpp2ILInjected.Token(Token = "0x40008BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public global::System.Coord CursorPosition;

		// Token: 0x040006E2 RID: 1762
		[global::Cpp2ILInjected.Token(Token = "0x40008BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public short Attribute;

		// Token: 0x040006E3 RID: 1763
		[global::Cpp2ILInjected.Token(Token = "0x40008BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		public global::System.SmallRect Window;

		// Token: 0x040006E4 RID: 1764
		[global::Cpp2ILInjected.Token(Token = "0x40008BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		public global::System.Coord MaxWindowSize;
	}
}
