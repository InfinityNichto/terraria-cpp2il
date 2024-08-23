using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x0200009C RID: 156
	[global::Cpp2ILInjected.Token(Token = "0x20000CC")]
	internal interface ISpanFormattable
	{
		// Token: 0x060006CB RID: 1739
		[global::Cpp2ILInjected.Token(Token = "0x6000770")]
		bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider);
	}
}
