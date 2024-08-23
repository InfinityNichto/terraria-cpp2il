using System;
using Cpp2ILInjected;

namespace System.Threading
{
	// Token: 0x02000194 RID: 404
	[global::Cpp2ILInjected.Token(Token = "0x20001F9")]
	[global::System.Serializable]
	internal enum StackCrawlMark
	{
		// Token: 0x04000786 RID: 1926
		[global::Cpp2ILInjected.Token(Token = "0x40009B0")]
		LookForMe,
		// Token: 0x04000787 RID: 1927
		[global::Cpp2ILInjected.Token(Token = "0x40009B1")]
		LookForMyCaller,
		// Token: 0x04000788 RID: 1928
		[global::Cpp2ILInjected.Token(Token = "0x40009B2")]
		LookForMyCallersCaller,
		// Token: 0x04000789 RID: 1929
		[global::Cpp2ILInjected.Token(Token = "0x40009B3")]
		LookForThread
	}
}
