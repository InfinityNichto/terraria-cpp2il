using System;
using Cpp2ILInjected;

namespace System.Collections
{
	// Token: 0x020004F8 RID: 1272
	[global::Cpp2ILInjected.Token(Token = "0x20005EC")]
	public interface IStructuralEquatable
	{
		// Token: 0x06002A64 RID: 10852
		[global::Cpp2ILInjected.Token(Token = "0x6002DC8")]
		bool Equals(object other, IEqualityComparer comparer);

		// Token: 0x06002A65 RID: 10853
		[global::Cpp2ILInjected.Token(Token = "0x6002DC9")]
		int GetHashCode(IEqualityComparer comparer);
	}
}
