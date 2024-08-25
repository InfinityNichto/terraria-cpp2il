using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Collections.Concurrent
{
	[global::System.Diagnostics.DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000614")]
	[StructLayout(2, Pack = 1, Size = 384)]
	internal struct PaddedHeadAndTail
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001A28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		[global::System.Runtime.InteropServices.FieldOffset(128)]
		public int Head;

		[global::Cpp2ILInjected.Token(Token = "0x4001A29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		[global::System.Runtime.InteropServices.FieldOffset(256)]
		public int Tail;
	}
}
