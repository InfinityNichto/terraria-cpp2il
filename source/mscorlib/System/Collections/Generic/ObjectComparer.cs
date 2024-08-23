using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000536 RID: 1334
	[global::Cpp2ILInjected.Token(Token = "0x2000654")]
	[global::System.Serializable]
	internal class ObjectComparer<T> : Comparer<T>
	{
		// Token: 0x06002CE8 RID: 11496 RVA: 0x0001C217 File Offset: 0x0001A417
		[global::Cpp2ILInjected.Token(Token = "0x6003179")]
		[global::Cpp2ILInjected.Address(RVA = "0x17FF068", Offset = "0x17FF068", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int Compare(T x, T y)
		{
			throw null;
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x0001C21A File Offset: 0x0001A41A
		[global::Cpp2ILInjected.Token(Token = "0x600317A")]
		[global::Cpp2ILInjected.Address(RVA = "0x17FF158", Offset = "0x17FF158", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x0001C21D File Offset: 0x0001A41D
		[global::Cpp2ILInjected.Token(Token = "0x600317B")]
		[global::Cpp2ILInjected.Address(RVA = "0x17FF1B4", Offset = "0x17FF1B4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x0001C220 File Offset: 0x0001A420
		[global::Cpp2ILInjected.Token(Token = "0x600317C")]
		[global::Cpp2ILInjected.Address(RVA = "0x17FF1DC", Offset = "0x17FF1DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ObjectComparer()
		{
			throw null;
		}
	}
}
