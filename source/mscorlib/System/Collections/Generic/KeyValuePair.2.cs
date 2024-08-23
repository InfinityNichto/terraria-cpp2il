using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000521 RID: 1313
	[global::Cpp2ILInjected.Token(Token = "0x2000639")]
	[global::System.Serializable]
	public readonly struct KeyValuePair<TKey, TValue>
	{
		// Token: 0x06002C2E RID: 11310 RVA: 0x0001BFEC File Offset: 0x0001A1EC
		[global::Cpp2ILInjected.Token(Token = "0x600309F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1723D60", Offset = "0x1723D60", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >), Member = "CopyTo", MemberParameters = new object[]
		{
			"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public KeyValuePair(TKey key, TValue value)
		{
			throw null;
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x0001BFEF File Offset: 0x0001A1EF
		[global::Cpp2ILInjected.Token(Token = "0x170007D4")]
		public TKey Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723D6C", Offset = "0x1723D6C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x0001BFF2 File Offset: 0x0001A1F2
		[global::Cpp2ILInjected.Token(Token = "0x170007D5")]
		public TValue Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723D78", Offset = "0x1723D78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x0001BFF5 File Offset: 0x0001A1F5
		[global::Cpp2ILInjected.Token(Token = "0x60030A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1723D80", Offset = "0x1723D80", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair), Member = "PairToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001611 RID: 5649
		[global::Cpp2ILInjected.Token(Token = "0x4001A6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly TKey key;

		// Token: 0x04001612 RID: 5650
		[global::Cpp2ILInjected.Token(Token = "0x4001A6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly TValue value;
	}
}
