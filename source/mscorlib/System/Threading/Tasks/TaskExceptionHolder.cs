using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001CA RID: 458
	[global::Cpp2ILInjected.Token(Token = "0x200024B")]
	internal class TaskExceptionHolder
	{
		// Token: 0x06001270 RID: 4720 RVA: 0x000178CD File Offset: 0x00015ACD
		[global::Cpp2ILInjected.Token(Token = "0x6001423")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA7430", Offset = "0x1CA7430", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal TaskExceptionHolder(Task task)
		{
			throw null;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x000178D0 File Offset: 0x00015AD0
		[global::Cpp2ILInjected.Token(Token = "0x6001424")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CADCB8", Offset = "0x1CADCB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool ShouldFailFastOnUnobservedException()
		{
			throw null;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000178D3 File Offset: 0x00015AD3
		[global::Cpp2ILInjected.Token(Token = "0x6001425")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CADCC0", Offset = "0x1CADCC0", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Collections.Generic.IEnumerable<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnobservedTaskExceptionEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.AggregateException) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskScheduler), Member = "PublishUnobservedTaskException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(UnobservedTaskExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000178D6 File Offset: 0x00015AD6
		[global::Cpp2ILInjected.Token(Token = "0x170001F6")]
		internal bool ContainsFaultList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001426")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA705C", Offset = "0x1CA705C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x000178D9 File Offset: 0x00015AD9
		[global::Cpp2ILInjected.Token(Token = "0x6001427")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA7458", Offset = "0x1CA7458", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "SetCancellationException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		internal void Add(object exceptionObject, bool representsCancellation)
		{
			throw null;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000178DC File Offset: 0x00015ADC
		[global::Cpp2ILInjected.Token(Token = "0x6001428")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE044", Offset = "0x1CAE044", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskExceptionHolder), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "MarkAsHandled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetCancellationException(object exceptionObject)
		{
			throw null;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x000178DF File Offset: 0x00015ADF
		[global::Cpp2ILInjected.Token(Token = "0x6001429")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE100", Offset = "0x1CAE100", Length = "0x4D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskExceptionHolder), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelListWithIList<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "AddRange", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private void AddFaultException(object exceptionObject)
		{
			throw null;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x000178E2 File Offset: 0x00015AE2
		[global::Cpp2ILInjected.Token(Token = "0x600142A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE5D4", Offset = "0x1CAE5D4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "ReRegisterForFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void MarkAsUnhandled()
		{
			throw null;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000178E5 File Offset: 0x00015AE5
		[global::Cpp2ILInjected.Token(Token = "0x600142B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA7230", Offset = "0x1CA7230", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskExceptionHolder), Member = "SetCancellationException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Exception)
		}, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskExceptionHolder), Member = "GetExceptionDispatchInfos", ReturnType = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void MarkAsHandled(bool calledFromFinalizer)
		{
			throw null;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x000178E8 File Offset: 0x00015AE8
		[global::Cpp2ILInjected.Token(Token = "0x600142C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA7464", Offset = "0x1CA7464", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Task), Member = "AddExceptionsFromChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "MarkAsHandled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal global::System.AggregateException CreateExceptionObject(bool calledFromFinalizer, global::System.Exception includeThisException)
		{
			throw null;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000178EB File Offset: 0x00015AEB
		[global::Cpp2ILInjected.Token(Token = "0x600142D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA76EC", Offset = "0x1CA76EC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskExceptionHolder), Member = "MarkAsHandled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			throw null;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000178EE File Offset: 0x00015AEE
		[global::Cpp2ILInjected.Token(Token = "0x600142E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE644", Offset = "0x1CAE644", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal global::System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			throw null;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x000178F1 File Offset: 0x00015AF1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600142F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAE64C", Offset = "0x1CAE64C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static TaskExceptionHolder()
		{
			throw null;
		}

		// Token: 0x0400084A RID: 2122
		[global::Cpp2ILInjected.Token(Token = "0x4000AB4")]
		private static readonly bool s_failFastOnUnobservedException;

		// Token: 0x0400084B RID: 2123
		[global::Cpp2ILInjected.Token(Token = "0x4000AB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Task m_task;

		// Token: 0x0400084C RID: 2124
		[global::Cpp2ILInjected.Token(Token = "0x4000AB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Collections.Generic.LowLevelListWithIList<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo> m_faultExceptions;

		// Token: 0x0400084D RID: 2125
		[global::Cpp2ILInjected.Token(Token = "0x4000AB7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Runtime.ExceptionServices.ExceptionDispatchInfo m_cancellationException;

		// Token: 0x0400084E RID: 2126
		[global::Cpp2ILInjected.Token(Token = "0x4000AB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_isHandled;
	}
}
