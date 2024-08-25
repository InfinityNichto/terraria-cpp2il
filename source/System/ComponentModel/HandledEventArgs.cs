using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200037A")]
	public class HandledEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x600175B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4CD44", Offset = "0x1E4CD44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HandledEventArgs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600175C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4CD4C", Offset = "0x1E4CD4C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HandledEventArgs(bool defaultHandledValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700054E")]
		public bool Handled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600175D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4CDBC", Offset = "0x1E4CDBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600175E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4CDC4", Offset = "0x1E4CDC4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400122B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <Handled>k__BackingField;
	}
}
