using System;
using Cpp2ILInjected;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x20005B7")]
	internal interface ISimpleCollator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002C97")]
		SortKey GetSortKey(string source, CompareOptions options);

		[global::Cpp2ILInjected.Token(Token = "0x6002C98")]
		int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

		[global::Cpp2ILInjected.Token(Token = "0x6002C99")]
		bool IsPrefix(string src, string target, CompareOptions opt);

		[global::Cpp2ILInjected.Token(Token = "0x6002C9A")]
		bool IsSuffix(string src, string target, CompareOptions opt);

		[global::Cpp2ILInjected.Token(Token = "0x6002C9B")]
		int IndexOf(string s, string target, int start, int length, CompareOptions opt);

		[global::Cpp2ILInjected.Token(Token = "0x6002C9C")]
		int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);
	}
}
