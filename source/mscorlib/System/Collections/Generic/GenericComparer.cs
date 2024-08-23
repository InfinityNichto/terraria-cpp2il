using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000534 RID: 1332
	[global::Cpp2ILInjected.Token(Token = "0x2000652")]
	[global::System.Serializable]
	internal class GenericComparer<T> : Comparer<T> where T : global::System.IComparable<T>
	{
		// Token: 0x06002CE0 RID: 11488 RVA: 0x0001C1FF File Offset: 0x0001A3FF
		[global::Cpp2ILInjected.Token(Token = "0x6003171")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A8C48", Offset = "0x16A8C48", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "CompareTo", MemberParameters = new object[] { "System.ValueTuple`1<T1>" }, ReturnType = typeof(int))]
		public override int Compare(T x, T y)
		{
			throw null;
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x0001C202 File Offset: 0x0001A402
		[global::Cpp2ILInjected.Token(Token = "0x6003172")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A8C74", Offset = "0x16A8C74", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x0001C205 File Offset: 0x0001A405
		[global::Cpp2ILInjected.Token(Token = "0x6003173")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A8CD0", Offset = "0x16A8CD0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x0001C208 File Offset: 0x0001A408
		[global::Cpp2ILInjected.Token(Token = "0x6003174")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A8CF8", Offset = "0x16A8CF8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GenericComparer()
		{
			throw null;
		}
	}
}
