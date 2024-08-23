using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000020 RID: 32
	[global::Cpp2ILInjected.Token(Token = "0x2000030")]
	internal class CodePointIndexer
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00014702 File Offset: 0x00012902
		[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADA08", Offset = "0x1AADA08", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTableUtil), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NormalizationTableUtil), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CodePointIndexer(int[] starts, int[] ends, int defaultIndex, int defaultCP)
		{
			throw null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00014705 File Offset: 0x00012905
		[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADB34", Offset = "0x1AADB34", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level2", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NormalizationTableUtil), Member = "PropIdx", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NormalizationTableUtil), Member = "MapIdx", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType"
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Normalization), Member = "GetCombiningClass", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Normalization), Member = "GetPrimaryCompositeFromMapIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Normalization), Member = "GetPrimaryCompositeHelperIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public int ToIndex(int cp)
		{
			throw null;
		}

		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly CodePointIndexer.TableRange[] ranges;

		// Token: 0x0400003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int TotalCount;

		// Token: 0x04000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int defaultIndex;

		// Token: 0x04000041 RID: 65
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int defaultCP;

		// Token: 0x02000565 RID: 1381
		[global::Cpp2ILInjected.Token(Token = "0x2000031")]
		[global::System.Serializable]
		internal struct TableRange
		{
			// Token: 0x06003F2B RID: 16171 RVA: 0x0001F853 File Offset: 0x0001DA53
			[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AADB1C", Offset = "0x1AADB1C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TableRange(int start, int end, int indexStart)
			{
				throw null;
			}

			// Token: 0x04001739 RID: 5945
			[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly int Start;

			// Token: 0x0400173A RID: 5946
			[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly int End;

			// Token: 0x0400173B RID: 5947
			[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly int Count;

			// Token: 0x0400173C RID: 5948
			[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public readonly int IndexStart;

			// Token: 0x0400173D RID: 5949
			[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly int IndexEnd;
		}
	}
}
