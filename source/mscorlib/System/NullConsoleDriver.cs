using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000186")]
	internal class NullConsoleDriver : global::System.IConsoleDriver
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82138", Offset = "0x1C82138", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8213C", Offset = "0x1C8213C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public string ReadLine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82144", Offset = "0x1C82144", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B870", Offset = "0x1C7B870", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public NullConsoleDriver()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000F32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C821A0", Offset = "0x1C821A0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleKeyInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(global::System.ConsoleKey),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static NullConsoleDriver()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400068B")]
		private static readonly global::System.ConsoleKeyInfo EmptyConsoleKeyInfo;
	}
}
