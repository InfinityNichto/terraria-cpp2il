﻿using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200016F RID: 367
	[global::Cpp2ILInjected.Token(Token = "0x20001C1")]
	[global::System.Serializable]
	public class SynchronizationLockException : global::System.SystemException
	{
		// Token: 0x06000F8E RID: 3982 RVA: 0x00017105 File Offset: 0x00015305
		[global::Cpp2ILInjected.Token(Token = "0x60010C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9421C", Offset = "0x1C9421C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SynchronizationLockException()
		{
			throw null;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00017108 File Offset: 0x00015308
		[global::Cpp2ILInjected.Token(Token = "0x60010C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94278", Offset = "0x1C94278", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "ObjPulse", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "ObjPulseAll", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "ObjWait", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public SynchronizationLockException(string message)
		{
			throw null;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0001710B File Offset: 0x0001530B
		[global::Cpp2ILInjected.Token(Token = "0x60010C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9429C", Offset = "0x1C9429C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected SynchronizationLockException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}