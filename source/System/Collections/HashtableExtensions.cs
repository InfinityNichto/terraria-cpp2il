using System;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x02000303 RID: 771
	[global::Cpp2ILInjected.Token(Token = "0x2000416")]
	internal static class HashtableExtensions
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x00007520 File Offset: 0x00005720
		[global::Cpp2ILInjected.Token(Token = "0x6001C1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B388", Offset = "0x158B388", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "GroupNameFromNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "GroupNumberFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryGetValue<T>(this Hashtable table, object key, out T value)
		{
			throw null;
		}
	}
}
