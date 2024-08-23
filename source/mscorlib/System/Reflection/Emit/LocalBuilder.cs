using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Reflection.Emit
{
	// Token: 0x0200045C RID: 1116
	[global::Cpp2ILInjected.Token(Token = "0x2000521")]
	[StructLayout(0)]
	public sealed class LocalBuilder : LocalVariableInfo
	{
		// Token: 0x040011F8 RID: 4600
		[global::Cpp2ILInjected.Token(Token = "0x4001516")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x040011F9 RID: 4601
		[global::Cpp2ILInjected.Token(Token = "0x4001517")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal ILGenerator ilgen;

		// Token: 0x040011FA RID: 4602
		[global::Cpp2ILInjected.Token(Token = "0x4001518")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int startOffset;

		// Token: 0x040011FB RID: 4603
		[global::Cpp2ILInjected.Token(Token = "0x4001519")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int endOffset;
	}
}
