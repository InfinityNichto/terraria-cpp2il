using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000127")]
	[global::System.Serializable]
	public sealed class ConsoleCancelEventArgs : global::System.EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54D20", Offset = "0x1C54D20", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "DoConsoleCancelEvent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ConsoleCancelEventArgs(global::System.ConsoleSpecialKey type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000101")]
		public bool Cancel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C54D8C", Offset = "0x1C54D8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54D94", Offset = "0x1C54D94", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ConsoleCancelEventArgs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400041C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.ConsoleSpecialKey _type;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400041D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool <Cancel>k__BackingField;
	}
}
