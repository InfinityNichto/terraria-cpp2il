using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x0200015A RID: 346
	[global::Cpp2ILInjected.Token(Token = "0x20001A6")]
	internal struct InputRecord
	{
		// Token: 0x040006D1 RID: 1745
		[global::Cpp2ILInjected.Token(Token = "0x40008AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public short EventType;

		// Token: 0x040006D2 RID: 1746
		[global::Cpp2ILInjected.Token(Token = "0x40008AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public bool KeyDown;

		// Token: 0x040006D3 RID: 1747
		[global::Cpp2ILInjected.Token(Token = "0x40008AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public short RepeatCount;

		// Token: 0x040006D4 RID: 1748
		[global::Cpp2ILInjected.Token(Token = "0x40008AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
		public short VirtualKeyCode;

		// Token: 0x040006D5 RID: 1749
		[global::Cpp2ILInjected.Token(Token = "0x40008B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public short VirtualScanCode;

		// Token: 0x040006D6 RID: 1750
		[global::Cpp2ILInjected.Token(Token = "0x40008B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		public char Character;

		// Token: 0x040006D7 RID: 1751
		[global::Cpp2ILInjected.Token(Token = "0x40008B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int ControlKeyState;

		// Token: 0x040006D8 RID: 1752
		[global::Cpp2ILInjected.Token(Token = "0x40008B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int pad1;

		// Token: 0x040006D9 RID: 1753
		[global::Cpp2ILInjected.Token(Token = "0x40008B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool pad2;
	}
}
