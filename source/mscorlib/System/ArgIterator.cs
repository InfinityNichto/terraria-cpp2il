using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200016A")]
	[StructLayout(3)]
	public struct ArgIterator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79D40", Offset = "0x1C79D40", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79D8C", Offset = "0x1C79D8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400064A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.IntPtr sig;

		[global::Cpp2ILInjected.Token(Token = "0x400064B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private global::System.IntPtr args;

		[global::Cpp2ILInjected.Token(Token = "0x400064C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int next_arg;

		[global::Cpp2ILInjected.Token(Token = "0x400064D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int num_args;
	}
}
