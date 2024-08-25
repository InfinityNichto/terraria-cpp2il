using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001BE")]
	[StructLayout(0, CharSet = CharSet.Unicode)]
	internal struct hostent
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000974")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public IntPtr h_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000975")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public IntPtr h_aliases;

		[global::Cpp2ILInjected.Token(Token = "0x4000976")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public short h_addrtype;

		[global::Cpp2ILInjected.Token(Token = "0x4000977")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		public short h_length;

		[global::Cpp2ILInjected.Token(Token = "0x4000978")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr h_addr_list;
	}
}
