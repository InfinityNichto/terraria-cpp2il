using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Reflection.Emit
{
	[global::Cpp2ILInjected.Token(Token = "0x2000521")]
	[StructLayout(0)]
	public sealed class LocalBuilder : LocalVariableInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001516")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string name;

		[global::Cpp2ILInjected.Token(Token = "0x4001517")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal ILGenerator ilgen;

		[global::Cpp2ILInjected.Token(Token = "0x4001518")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int startOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4001519")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int endOffset;
	}
}
