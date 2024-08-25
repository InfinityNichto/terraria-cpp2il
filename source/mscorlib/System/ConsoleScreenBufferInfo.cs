using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20001A9")]
	internal struct ConsoleScreenBufferInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x40008BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.Coord Size;

		[global::Cpp2ILInjected.Token(Token = "0x40008BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public global::System.Coord CursorPosition;

		[global::Cpp2ILInjected.Token(Token = "0x40008BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public short Attribute;

		[global::Cpp2ILInjected.Token(Token = "0x40008BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		public global::System.SmallRect Window;

		[global::Cpp2ILInjected.Token(Token = "0x40008BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		public global::System.Coord MaxWindowSize;
	}
}
