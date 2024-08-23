using System;
using Cpp2ILInjected;

namespace System.Globalization
{
	// Token: 0x020004C9 RID: 1225
	[global::Cpp2ILInjected.Token(Token = "0x20005B7")]
	internal interface ISimpleCollator
	{
		// Token: 0x06002938 RID: 10552
		[global::Cpp2ILInjected.Token(Token = "0x6002C97")]
		SortKey GetSortKey(string source, CompareOptions options);

		// Token: 0x06002939 RID: 10553
		[global::Cpp2ILInjected.Token(Token = "0x6002C98")]
		int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

		// Token: 0x0600293A RID: 10554
		[global::Cpp2ILInjected.Token(Token = "0x6002C99")]
		bool IsPrefix(string src, string target, CompareOptions opt);

		// Token: 0x0600293B RID: 10555
		[global::Cpp2ILInjected.Token(Token = "0x6002C9A")]
		bool IsSuffix(string src, string target, CompareOptions opt);

		// Token: 0x0600293C RID: 10556
		[global::Cpp2ILInjected.Token(Token = "0x6002C9B")]
		int IndexOf(string s, string target, int start, int length, CompareOptions opt);

		// Token: 0x0600293D RID: 10557
		[global::Cpp2ILInjected.Token(Token = "0x6002C9C")]
		int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);
	}
}
