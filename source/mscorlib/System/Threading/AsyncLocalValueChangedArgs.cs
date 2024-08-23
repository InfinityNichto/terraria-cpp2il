using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000166 RID: 358
	[global::Cpp2ILInjected.Token(Token = "0x20001B8")]
	public readonly struct AsyncLocalValueChangedArgs<T>
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x000170D5 File Offset: 0x000152D5
		[global::Cpp2ILInjected.Token(Token = "0x17000186")]
		public T CurrentValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60010AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F5624", Offset = "0x17F5624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000170D8 File Offset: 0x000152D8
		[global::Cpp2ILInjected.Token(Token = "0x60010AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F562C", Offset = "0x17F562C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
		{
			throw null;
		}

		// Token: 0x040006FD RID: 1789
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40008FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T <PreviousValue>k__BackingField;

		// Token: 0x040006FE RID: 1790
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40008FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T <CurrentValue>k__BackingField;

		// Token: 0x040006FF RID: 1791
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40008FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly bool <ThreadContextChanged>k__BackingField;
	}
}
