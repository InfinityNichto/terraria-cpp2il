using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Collections.Concurrent
{
	// Token: 0x02000506 RID: 1286
	[global::System.Diagnostics.DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000614")]
	[StructLayout(2, Pack = 1, Size = 384)]
	internal struct PaddedHeadAndTail
	{
		// Token: 0x040015ED RID: 5613
		[global::Cpp2ILInjected.Token(Token = "0x4001A28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		[global::System.Runtime.InteropServices.FieldOffset(128)]
		public int Head;

		// Token: 0x040015EE RID: 5614
		[global::Cpp2ILInjected.Token(Token = "0x4001A29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		[global::System.Runtime.InteropServices.FieldOffset(256)]
		public int Tail;
	}
}
