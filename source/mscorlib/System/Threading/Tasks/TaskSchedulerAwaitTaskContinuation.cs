using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001C8 RID: 456
	[global::Cpp2ILInjected.Token(Token = "0x2000248")]
	internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06001262 RID: 4706 RVA: 0x000178A3 File Offset: 0x00015AA3
		[global::Cpp2ILInjected.Token(Token = "0x6001412")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA91FC", Offset = "0x1CA91FC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, global::System.Action action, bool flowExecutionContext)
		{
			throw null;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000178A6 File Offset: 0x00015AA6
		[global::Cpp2ILInjected.Token(Token = "0x6001413")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAD3B8", Offset = "0x1CAD3B8", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_IsThreadPoolThread", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = "CreateTask", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(TaskScheduler)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
		{
			throw null;
		}

		// Token: 0x04000846 RID: 2118
		[global::Cpp2ILInjected.Token(Token = "0x4000AAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly TaskScheduler m_scheduler;

		// Token: 0x020005CB RID: 1483
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000249")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06004087 RID: 16519 RVA: 0x0001FC46 File Offset: 0x0001DE46
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001414")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAD7B4", Offset = "0x1CAD7B4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004088 RID: 16520 RVA: 0x0001FC49 File Offset: 0x0001DE49
			[global::Cpp2ILInjected.Token(Token = "0x6001415")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAD810", Offset = "0x1CAD810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004089 RID: 16521 RVA: 0x0001FC4C File Offset: 0x0001DE4C
			[global::Cpp2ILInjected.Token(Token = "0x6001416")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAD818", Offset = "0x1CAD818", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal void <Run>b__2_0(object state)
			{
				throw null;
			}

			// Token: 0x040018F0 RID: 6384
			[global::Cpp2ILInjected.Token(Token = "0x4000AAF")]
			public static readonly TaskSchedulerAwaitTaskContinuation.<>c <>9;

			// Token: 0x040018F1 RID: 6385
			[global::Cpp2ILInjected.Token(Token = "0x4000AB0")]
			public static global::System.Action<object> <>9__2_0;
		}
	}
}
