using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200051E RID: 1310
	[global::Cpp2ILInjected.Token(Token = "0x2000636")]
	public interface IReadOnlyList<out T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x170006E0 RID: 1760
		[global::Cpp2ILInjected.Token(Token = "0x170007D3")]
		T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600309A")]
			get;
		}
	}
}
