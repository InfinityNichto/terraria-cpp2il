using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000CC")]
	internal interface ISpanFormattable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000770")]
		bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider);
	}
}
