using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000464")]
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder
	{
		[global::Cpp2ILInjected.Token(Token = "0x40012A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private AsyncTaskMethodBuilder _methodBuilder;

		[global::Cpp2ILInjected.Token(Token = "0x40012A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _haveResult;

		[global::Cpp2ILInjected.Token(Token = "0x40012A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool _useBuilder;
	}
}
