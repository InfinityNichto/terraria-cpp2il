using System;
using Cpp2ILInjected;

namespace System.Buffers
{
	[global::Cpp2ILInjected.Token(Token = "0x200065F")]
	public delegate void SpanAction<T, in TArg>(global::System.Span<T> span, TArg arg);
}
