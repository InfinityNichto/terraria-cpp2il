using System;
using Cpp2ILInjected;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001CC")]
	public struct NativeOverlapped
	{
		[global::Cpp2ILInjected.Token(Token = "0x400091F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.IntPtr InternalLow;

		[global::Cpp2ILInjected.Token(Token = "0x4000920")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public global::System.IntPtr InternalHigh;

		[global::Cpp2ILInjected.Token(Token = "0x4000921")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int OffsetLow;

		[global::Cpp2ILInjected.Token(Token = "0x4000922")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int OffsetHigh;

		[global::Cpp2ILInjected.Token(Token = "0x4000923")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public global::System.IntPtr EventHandle;
	}
}
