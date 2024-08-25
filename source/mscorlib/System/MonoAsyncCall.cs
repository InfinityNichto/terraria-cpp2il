using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000180")]
	[StructLayout(0)]
	internal class MonoAsyncCall
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DED4", Offset = "0x1C7DED4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MonoAsyncCall()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400067D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object msg;

		[global::Cpp2ILInjected.Token(Token = "0x400067E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr cb_method;

		[global::Cpp2ILInjected.Token(Token = "0x400067F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object cb_target;

		[global::Cpp2ILInjected.Token(Token = "0x4000680")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object state;

		[global::Cpp2ILInjected.Token(Token = "0x4000681")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object res;

		[global::Cpp2ILInjected.Token(Token = "0x4000682")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object out_args;
	}
}
