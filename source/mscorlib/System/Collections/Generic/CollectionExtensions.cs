using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000528 RID: 1320
	[global::Cpp2ILInjected.Token(Token = "0x2000643")]
	public static class CollectionExtensions
	{
		// Token: 0x06002C86 RID: 11398 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
		[global::Cpp2ILInjected.Token(Token = "0x6003102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1576C40", Offset = "0x1576C40", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStoreMgr), Member = "GetNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
		{
			throw null;
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x0001C0F7 File Offset: 0x0001A2F7
		[global::Cpp2ILInjected.Token(Token = "0x6003103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1576C54", Offset = "0x1576C54", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			throw null;
		}
	}
}
