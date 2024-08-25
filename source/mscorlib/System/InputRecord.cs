using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20001A6")]
	internal struct InputRecord
	{
		[global::Cpp2ILInjected.Token(Token = "0x40008AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public short EventType;

		[global::Cpp2ILInjected.Token(Token = "0x40008AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public bool KeyDown;

		[global::Cpp2ILInjected.Token(Token = "0x40008AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public short RepeatCount;

		[global::Cpp2ILInjected.Token(Token = "0x40008AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
		public short VirtualKeyCode;

		[global::Cpp2ILInjected.Token(Token = "0x40008B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public short VirtualScanCode;

		[global::Cpp2ILInjected.Token(Token = "0x40008B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		public char Character;

		[global::Cpp2ILInjected.Token(Token = "0x40008B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int ControlKeyState;

		[global::Cpp2ILInjected.Token(Token = "0x40008B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int pad1;

		[global::Cpp2ILInjected.Token(Token = "0x40008B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool pad2;
	}
}
