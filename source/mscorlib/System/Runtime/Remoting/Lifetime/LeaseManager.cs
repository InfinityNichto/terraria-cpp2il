using System;
using System.Collections;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x020002C0 RID: 704
	[global::Cpp2ILInjected.Token(Token = "0x2000361")]
	internal class LeaseManager
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x00018FC5 File Offset: 0x000171C5
		[global::Cpp2ILInjected.Token(Token = "0x6001CC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B38E44", Offset = "0x1B38E44", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LifetimeServices), Member = "set_LeaseManagerPollTime", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void SetPollTime(global::System.TimeSpan timeSpan)
		{
			throw null;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00018FC8 File Offset: 0x000171C8
		[global::Cpp2ILInjected.Token(Token = "0x6001CC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B38F34", Offset = "0x1B38F34", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LifetimeServices), Member = "TrackLifetime", MemberParameters = new object[] { typeof(ServerIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeaseManager), Member = "StartManager", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void TrackLifetime(ServerIdentity identity)
		{
			throw null;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00018FCB File Offset: 0x000171CB
		[global::Cpp2ILInjected.Token(Token = "0x6001CC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3903C", Offset = "0x1B3903C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LeaseManager), Member = "TrackLifetime", MemberParameters = new object[] { typeof(ServerIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.TimerCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Timer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Threading.TimerCallback),
			typeof(object),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void StartManager()
		{
			throw null;
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00018FCE File Offset: 0x000171CE
		[global::Cpp2ILInjected.Token(Token = "0x6001CCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39190", Offset = "0x1B39190", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Timer), Member = "Dispose", ReturnType = typeof(void))]
		public void StopManager()
		{
			throw null;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00018FD1 File Offset: 0x000171D1
		[global::Cpp2ILInjected.Token(Token = "0x6001CCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B391AC", Offset = "0x1B391AC", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lease), Member = "UpdateState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Timer), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void ManageLeases(object state)
		{
			throw null;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00018FD4 File Offset: 0x000171D4
		[global::Cpp2ILInjected.Token(Token = "0x6001CCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B393B0", Offset = "0x1B393B0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LifetimeServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LeaseManager()
		{
			throw null;
		}

		// Token: 0x04000BAF RID: 2991
		[global::Cpp2ILInjected.Token(Token = "0x4000E93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.ArrayList _objects;

		// Token: 0x04000BB0 RID: 2992
		[global::Cpp2ILInjected.Token(Token = "0x4000E94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Threading.Timer _timer;
	}
}
