using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001D6")]
	internal struct CancellationCallbackCoreWorkArguments
	{
		[global::Cpp2ILInjected.Token(Token = "0x600112A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C973AC", Offset = "0x1C973AC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400093B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment;

		[global::Cpp2ILInjected.Token(Token = "0x400093C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal int _currArrayIndex;
	}
}
