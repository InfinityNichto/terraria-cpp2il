using System;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001DD")]
	public class Lock
	{
		[global::Cpp2ILInjected.Token(Token = "0x600113D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97F40", Offset = "0x1C97F40", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskScheduler), Member = "PublishUnobservedTaskException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Threading.Tasks.UnobservedTaskExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Acquire()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600113E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97F54", Offset = "0x1C97F54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskScheduler), Member = "PublishUnobservedTaskException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Threading.Tasks.UnobservedTaskExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Release()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600113F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97F64", Offset = "0x1C97F64", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskScheduler), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Lock()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400094C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _lock;
	}
}
