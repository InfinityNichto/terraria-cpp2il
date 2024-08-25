using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200007F")]
	public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
}
