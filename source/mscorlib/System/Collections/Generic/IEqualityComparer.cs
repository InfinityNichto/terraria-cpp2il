using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200051A RID: 1306
	[global::Cpp2ILInjected.Token(Token = "0x2000632")]
	public interface IEqualityComparer<in T>
	{
		// Token: 0x06002C20 RID: 11296
		[global::Cpp2ILInjected.Token(Token = "0x6003091")]
		bool Equals(T x, T y);

		// Token: 0x06002C21 RID: 11297
		[global::Cpp2ILInjected.Token(Token = "0x6003092")]
		int GetHashCode(T obj);
	}
}
