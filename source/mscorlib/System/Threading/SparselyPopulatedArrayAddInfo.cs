using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000182 RID: 386
	[global::Cpp2ILInjected.Token(Token = "0x20001DA")]
	internal struct SparselyPopulatedArrayAddInfo<T> where T : class
	{
		// Token: 0x06000FF4 RID: 4084 RVA: 0x00017231 File Offset: 0x00015431
		[global::Cpp2ILInjected.Token(Token = "0x6001132")]
		[global::Cpp2ILInjected.Address(RVA = "0x186EC90", Offset = "0x186EC90", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
		{
			throw null;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00017234 File Offset: 0x00015434
		[global::Cpp2ILInjected.Token(Token = "0x17000198")]
		internal SparselyPopulatedArrayFragment<T> Source
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001133")]
			[global::Cpp2ILInjected.Address(RVA = "0x186EC9C", Offset = "0x186EC9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00017237 File Offset: 0x00015437
		[global::Cpp2ILInjected.Token(Token = "0x17000199")]
		internal int Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001134")]
			[global::Cpp2ILInjected.Address(RVA = "0x186ECA4", Offset = "0x186ECA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400073E RID: 1854
		[global::Cpp2ILInjected.Token(Token = "0x4000945")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SparselyPopulatedArrayFragment<T> _source;

		// Token: 0x0400073F RID: 1855
		[global::Cpp2ILInjected.Token(Token = "0x4000946")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _index;
	}
}
