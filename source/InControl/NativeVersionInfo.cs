using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000043")]
	public struct NativeVersionInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public uint major;

		[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint minor;

		[global::Cpp2ILInjected.Token(Token = "0x40002E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public uint patch;

		[global::Cpp2ILInjected.Token(Token = "0x40002E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public uint build;
	}
}
