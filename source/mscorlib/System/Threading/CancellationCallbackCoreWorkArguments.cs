using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200017F RID: 383
	[global::Cpp2ILInjected.Token(Token = "0x20001D6")]
	internal struct CancellationCallbackCoreWorkArguments
	{
		// Token: 0x06000FED RID: 4077 RVA: 0x0001721C File Offset: 0x0001541C
		[global::Cpp2ILInjected.Token(Token = "0x600112A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C973AC", Offset = "0x1C973AC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
		{
			throw null;
		}

		// Token: 0x04000735 RID: 1845
		[global::Cpp2ILInjected.Token(Token = "0x400093B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment;

		// Token: 0x04000736 RID: 1846
		[global::Cpp2ILInjected.Token(Token = "0x400093C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal int _currArrayIndex;
	}
}
