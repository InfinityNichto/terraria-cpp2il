using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000520 RID: 1312
	[global::Cpp2ILInjected.Token(Token = "0x2000638")]
	public static class KeyValuePair
	{
		// Token: 0x06002C2D RID: 11309 RVA: 0x0001BFE9 File Offset: 0x0001A1E9
		[global::Cpp2ILInjected.Token(Token = "0x600309E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C14FC8", Offset = "0x1C14FC8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePair<, >), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static string PairToString(object key, object value)
		{
			throw null;
		}
	}
}
