using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200018E RID: 398
	[global::Cpp2ILInjected.Token(Token = "0x20001F0")]
	public static class Monitor
	{
		// Token: 0x0600105C RID: 4188
		[global::Cpp2ILInjected.Token(Token = "0x60011AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97F5C", Offset = "0x1C97F5C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "SteamTickLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.TextureManager", Member = "Run", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1.LockedStack", Member = "TryPush", MemberParameters = new object[] { "T[]" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1.LockedStack", Member = "TryPop", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ThreadSafeStore`2", Member = "AddValue", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new object[]
		{
			"System.Diagnostics.TraceLevel",
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "ResolveContract", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "Newtonsoft.Json.Serialization.JsonContract")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "CreateProperties", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			"Newtonsoft.Json.MemberSerialization"
		}, ReturnType = "System.Collections.Generic.IList`1<JsonProperty>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.BeforeRenderHelper", Member = "Invoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "Send", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "Post", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "Exec", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "TraceWriteLine", MemberParameters = new object[]
		{
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "OnZipErrorSaving", MemberParameters = new object[]
		{
			"Ionic.Zip.ZipEntry",
			typeof(global::System.Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void Enter(object obj);

		// Token: 0x0600105D RID: 4189 RVA: 0x00017363 File Offset: 0x00015563
		[global::Cpp2ILInjected.Token(Token = "0x60011AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C956AC", Offset = "0x1C956AC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 540)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
		public static void Enter(object obj, ref bool lockTaken)
		{
			throw null;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00017366 File Offset: 0x00015566
		[global::Cpp2ILInjected.Token(Token = "0x60011B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BF10", Offset = "0x1C9BF10", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void ThrowLockTakenException()
		{
			throw null;
		}

		// Token: 0x0600105F RID: 4191
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60011B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97F60", Offset = "0x1C97F60", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1094)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void Exit(object obj);

		// Token: 0x06001060 RID: 4192 RVA: 0x00017369 File Offset: 0x00015569
		[global::Cpp2ILInjected.Token(Token = "0x60011B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BF88", Offset = "0x1C9BF88", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "PulseSteamTick", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "PulseSteamCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "SaveWorld", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			"Terraria.IO.WorldFile.WorldSaveContext"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "SaveMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		public static bool TryEnter(object obj)
		{
			throw null;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0001736C File Offset: 0x0001556C
		[global::Cpp2ILInjected.Token(Token = "0x60011B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BFA8", Offset = "0x1C9BFA8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
		public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken)
		{
			throw null;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0001736F File Offset: 0x0001556F
		[global::Cpp2ILInjected.Token(Token = "0x60011B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C054", Offset = "0x1C9C054", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitUntilCountOrTimeout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
		{
			throw null;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00017372 File Offset: 0x00015572
		[global::Cpp2ILInjected.Token(Token = "0x60011B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95E50", Offset = "0x1C95E50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		public static bool Wait(object obj, int millisecondsTimeout)
		{
			throw null;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00017375 File Offset: 0x00015575
		[global::Cpp2ILInjected.Token(Token = "0x60011B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C160", Offset = "0x1C9C160", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "SteamTickLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.TextureManager", Member = "Run", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = "InvokeAndWait", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		public static bool Wait(object obj)
		{
			throw null;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00017378 File Offset: 0x00015578
		[global::Cpp2ILInjected.Token(Token = "0x60011B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98FBC", Offset = "0x1C98FBC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "PulseSteamTick", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "PulseSteamCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = "TaskThreadStart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "ObjPulse", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Pulse(object obj)
		{
			throw null;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0001737B File Offset: 0x0001557B
		[global::Cpp2ILInjected.Token(Token = "0x60011B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C958C4", Offset = "0x1C958C4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Set", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "CancellationTokenCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "CancellationTokenCanceledEventHandler", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "ObjPulseAll", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void PulseAll(object obj)
		{
			throw null;
		}

		// Token: 0x06001067 RID: 4199
		[global::Cpp2ILInjected.Token(Token = "0x60011B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C22C", Offset = "0x1C9C22C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool Monitor_test_synchronised(object obj);

		// Token: 0x06001068 RID: 4200
		[global::Cpp2ILInjected.Token(Token = "0x60011BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C230", Offset = "0x1C9C230", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Monitor_pulse(object obj);

		// Token: 0x06001069 RID: 4201 RVA: 0x0001737E File Offset: 0x0001557E
		[global::Cpp2ILInjected.Token(Token = "0x60011BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C16C", Offset = "0x1C9C16C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "Pulse", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void ObjPulse(object obj)
		{
			throw null;
		}

		// Token: 0x0600106A RID: 4202
		[global::Cpp2ILInjected.Token(Token = "0x60011BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C234", Offset = "0x1C9C234", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Monitor_pulse_all(object obj);

		// Token: 0x0600106B RID: 4203 RVA: 0x00017381 File Offset: 0x00015581
		[global::Cpp2ILInjected.Token(Token = "0x60011BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C1CC", Offset = "0x1C9C1CC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void ObjPulseAll(object obj)
		{
			throw null;
		}

		// Token: 0x0600106C RID: 4204
		[global::Cpp2ILInjected.Token(Token = "0x60011BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C238", Offset = "0x1C9C238", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool Monitor_wait(object obj, int ms);

		// Token: 0x0600106D RID: 4205 RVA: 0x00017384 File Offset: 0x00015584
		[global::Cpp2ILInjected.Token(Token = "0x60011BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C0B0", Offset = "0x1C9C0B0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj)
		{
			throw null;
		}

		// Token: 0x0600106E RID: 4206
		[global::Cpp2ILInjected.Token(Token = "0x60011C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C23C", Offset = "0x1C9C23C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken);

		// Token: 0x0600106F RID: 4207 RVA: 0x00017387 File Offset: 0x00015587
		[global::Cpp2ILInjected.Token(Token = "0x60011C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BFC0", Offset = "0x1C9BFC0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Monitor), Member = "ReliableEnter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken)
		{
			throw null;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0001738A File Offset: 0x0001558A
		[global::Cpp2ILInjected.Token(Token = "0x60011C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BF7C", Offset = "0x1C9BF7C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		private static void ReliableEnter(object obj, ref bool lockTaken)
		{
			throw null;
		}
	}
}
