using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000040 RID: 64
[global::Cpp2ILInjected.Token(Token = "0x2000065")]
public class ManagedThread
{
	// Token: 0x06000183 RID: 387 RVA: 0x00022001 File Offset: 0x00020201
	[global::Cpp2ILInjected.Token(Token = "0x6000216")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B3DC", Offset = "0x70B3DC", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "Run", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "RunForUser", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object),
		typeof(LocalUser)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "RunForUserCritical", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object),
		typeof(LocalUser)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public ManagedThread(ParameterizedThreadStart callBack, object state)
	{
		throw null;
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00022004 File Offset: 0x00020204
	[global::Cpp2ILInjected.Token(Token = "0x6000217")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B4A4", Offset = "0x70B4A4", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "Run", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "RunForUser", MemberParameters = new object[]
	{
		typeof(ThreadStart),
		typeof(LocalUser)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "RunCritical", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public ManagedThread(ThreadStart callBack)
	{
		throw null;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00022007 File Offset: 0x00020207
	[global::Cpp2ILInjected.Token(Token = "0x6000218")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B568", Offset = "0x70B568", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "Run", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "Run", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "RunForUser", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object),
		typeof(LocalUser)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "RunForUser", MemberParameters = new object[]
	{
		typeof(ThreadStart),
		typeof(LocalUser)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Run()
	{
		throw null;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0002200A File Offset: 0x0002020A
	[global::Cpp2ILInjected.Token(Token = "0x6000219")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B59C", Offset = "0x70B59C", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "RunForUserCritical", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object),
		typeof(LocalUser)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadManager), Member = "RunCritical", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_Priority", MemberParameters = new object[] { typeof(ThreadPriority) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void RunCritical()
	{
		throw null;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0002200D File Offset: 0x0002020D
	[global::Cpp2ILInjected.Token(Token = "0x600021A")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B5D0", Offset = "0x70B5D0", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	private void ThreadExecute()
	{
		throw null;
	}

	// Token: 0x04000107 RID: 263
	[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private ParameterizedThreadStart ParameterizedThreadStartCallBack;

	// Token: 0x04000108 RID: 264
	[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private object ParameterizedThreadStartCallbackState;

	// Token: 0x04000109 RID: 265
	[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private ThreadStart ThreadStartCallBack;

	// Token: 0x0400010A RID: 266
	[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public LocalUser User;

	// Token: 0x0400010B RID: 267
	[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Thread ActiveThread;

	// Token: 0x0400010C RID: 268
	[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool IsAlive;
}
