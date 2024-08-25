using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001B8")]
	public readonly struct AsyncLocalValueChangedArgs<T>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60010AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F562C", Offset = "0x17F562C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40008FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T <PreviousValue>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40008FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T <CurrentValue>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40008FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly bool <ThreadContextChanged>k__BackingField;
	}
}
