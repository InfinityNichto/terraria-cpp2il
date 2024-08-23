﻿using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace Internal.Threading.Tasks.Tracing
{
	// Token: 0x02000045 RID: 69
	[global::Cpp2ILInjected.Token(Token = "0x2000060")]
	internal static class TaskTrace
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00014B07 File Offset: 0x00012D07
		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		public static bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000225")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC6BF4", Offset = "0x1AC6BF4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "InternalWait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(global::System.Threading.CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter.<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.Action),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00014B0A File Offset: 0x00012D0A
		[global::Cpp2ILInjected.Token(Token = "0x6000226")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6C54", Offset = "0x1AC6C54", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Action)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			throw null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00014B0D File Offset: 0x00012D0D
		[global::Cpp2ILInjected.Token(Token = "0x6000227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6CD8", Offset = "0x1AC6CD8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "InternalWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			throw null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00014B10 File Offset: 0x00012D10
		[global::Cpp2ILInjected.Token(Token = "0x6000228")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6D5C", Offset = "0x1AC6D5C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "InternalWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter.<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
			throw null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00014B13 File Offset: 0x00012D13
		[global::Cpp2ILInjected.Token(Token = "0x6000229")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6DE0", Offset = "0x1AC6DE0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions)
		{
			throw null;
		}

		// Token: 0x040000DC RID: 220
		[global::Cpp2ILInjected.Token(Token = "0x400018F")]
		private static Internal.Runtime.Augments.TaskTraceCallbacks s_callbacks;
	}
}