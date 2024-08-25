using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F7")]
	internal class ThreadHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CC08", Offset = "0x1C9CC08", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ThreadHelper(global::System.Delegate start)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CC30", Offset = "0x1C9CC30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetExecutionContextHelper(ExecutionContext ec)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CC38", Offset = "0x1C9CC38", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void ThreadStart_Context(object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CD2C", Offset = "0x1C9CD2C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void ThreadStart(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CE28", Offset = "0x1C9CE28", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void ThreadStart()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60011E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CF18", Offset = "0x1C9CF18", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ThreadHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400099C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Delegate _start;

		[global::Cpp2ILInjected.Token(Token = "0x400099D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _startArg;

		[global::Cpp2ILInjected.Token(Token = "0x400099E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ExecutionContext _executionContext;

		[global::Cpp2ILInjected.Token(Token = "0x400099F")]
		internal static ContextCallback _ccb;
	}
}
