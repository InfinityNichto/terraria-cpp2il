using System;
using Cpp2ILInjected;

namespace System.Collections
{
	// Token: 0x02000504 RID: 1284
	[global::System.Obsolete("Please use IEqualityComparer instead.")]
	[global::Cpp2ILInjected.Token(Token = "0x200060F")]
	public interface IHashCodeProvider
	{
		// Token: 0x06002B31 RID: 11057
		[global::Cpp2ILInjected.Token(Token = "0x6002F56")]
		int GetHashCode(object obj);
	}
}
