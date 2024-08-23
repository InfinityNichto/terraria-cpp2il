using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200049D RID: 1181
	[global::Cpp2ILInjected.Token(Token = "0x2000573")]
	internal static class MonoLinqHelper
	{
		// Token: 0x060026EB RID: 9963 RVA: 0x0001B164 File Offset: 0x00019364
		[global::Cpp2ILInjected.Token(Token = "0x6002A08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593A2C", Offset = "0x1593A2C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetDirectories", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static T[] ToArray<T>(this global::System.Collections.Generic.IEnumerable<T> source)
		{
			throw null;
		}
	}
}
