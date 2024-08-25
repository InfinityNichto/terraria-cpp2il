using System;
using Cpp2ILInjected;

namespace System.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x200056C")]
	internal struct MonoIOStat
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001675")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public FileAttributes fileAttributes;

		[global::Cpp2ILInjected.Token(Token = "0x4001676")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public long Length;

		[global::Cpp2ILInjected.Token(Token = "0x4001677")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public long CreationTime;

		[global::Cpp2ILInjected.Token(Token = "0x4001678")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public long LastAccessTime;

		[global::Cpp2ILInjected.Token(Token = "0x4001679")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public long LastWriteTime;
	}
}
