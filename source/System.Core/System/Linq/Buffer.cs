using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Linq
{
	// Token: 0x02000014 RID: 20
	[global::Cpp2ILInjected.Token(Token = "0x200002B")]
	internal struct Buffer<TElement>
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000445A File Offset: 0x0000265A
		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E9398", Offset = "0x18E9398", Length = "0x5A0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Linq.OrderedEnumerable`1.<GetEnumerator>d__1", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		internal Buffer(IEnumerable<TElement> source)
		{
			throw null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000445D File Offset: 0x0000265D
		[global::Cpp2ILInjected.Token(Token = "0x600012C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E9938", Offset = "0x18E9938", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal TElement[] ToArray()
		{
			throw null;
		}

		// Token: 0x04000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal TElement[] items;

		// Token: 0x04000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal int count;
	}
}
