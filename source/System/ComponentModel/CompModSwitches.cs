using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D9")]
	internal static class CompModSwitches
	{
		[global::Cpp2ILInjected.Token(Token = "0x170005F5")]
		public static BooleanSwitch CommonDesignerServices
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E61EC4", Offset = "0x1E61EC4", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BooleanSwitch), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005F6")]
		public static TraceSwitch EventLog
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E61F90", Offset = "0x1E61F90", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceSwitch), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012F6")]
		private static BooleanSwitch commonDesignerServices;

		[global::Cpp2ILInjected.Token(Token = "0x40012F7")]
		private static TraceSwitch eventLog;
	}
}
