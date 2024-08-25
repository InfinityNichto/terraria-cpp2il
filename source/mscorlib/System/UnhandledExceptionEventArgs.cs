using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000118")]
	[global::System.Serializable]
	public class UnhandledExceptionEventArgs : global::System.EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53040", Offset = "0x1C53040", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnhandledExceptionEventArgs(object exception, bool isTerminating)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		public object ExceptionObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C530B4", Offset = "0x1C530B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		public bool IsTerminating
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C530BC", Offset = "0x1C530BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _exception;

		[global::Cpp2ILInjected.Token(Token = "0x4000400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _isTerminating;
	}
}
