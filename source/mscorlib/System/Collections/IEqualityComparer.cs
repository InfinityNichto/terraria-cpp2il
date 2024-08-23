using System;
using Cpp2ILInjected;

namespace System.Collections
{
	// Token: 0x020004F5 RID: 1269
	[global::Cpp2ILInjected.Token(Token = "0x20005E9")]
	public interface IEqualityComparer
	{
		// Token: 0x06002A56 RID: 10838
		[global::Cpp2ILInjected.Token(Token = "0x6002DBA")]
		bool Equals(object x, object y);

		// Token: 0x06002A57 RID: 10839
		[global::Cpp2ILInjected.Token(Token = "0x6002DBB")]
		int GetHashCode(object obj);
	}
}
