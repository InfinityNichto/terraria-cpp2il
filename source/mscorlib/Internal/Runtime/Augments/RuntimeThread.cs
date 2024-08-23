using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Internal.Runtime.Augments
{
	// Token: 0x0200004A RID: 74
	[global::Cpp2ILInjected.Token(Token = "0x2000065")]
	internal sealed class RuntimeThread
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x00014B25 File Offset: 0x00012D25
		[global::Cpp2ILInjected.Token(Token = "0x6000234")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6FBC", Offset = "0x1AC6FBC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private RuntimeThread(global::System.Threading.Thread t)
		{
			throw null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00014B28 File Offset: 0x00012D28
		[global::Cpp2ILInjected.Token(Token = "0x6000235")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6FE4", Offset = "0x1AC6FE4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Threading.ParameterizedThreadStart),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static RuntimeThread Create(global::System.Threading.ParameterizedThreadStart start, int maxStackSize)
		{
			throw null;
		}

		// Token: 0x17000035 RID: 53
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00014B2B File Offset: 0x00012D2B
		[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
		public bool IsBackground
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000236")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC707C", Offset = "0x1AC707C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00014B2E File Offset: 0x00012D2E
		[global::Cpp2ILInjected.Token(Token = "0x6000237")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC708C", Offset = "0x1AC708C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "Start", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public void Start(object state)
		{
			throw null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00014B31 File Offset: 0x00012D31
		[global::Cpp2ILInjected.Token(Token = "0x6000238")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7098", Offset = "0x1AC7098", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public static void Sleep(int millisecondsTimeout)
		{
			throw null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00014B34 File Offset: 0x00012D34
		[global::Cpp2ILInjected.Token(Token = "0x6000239")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC70A0", Offset = "0x1AC70A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "Yield", ReturnType = typeof(bool))]
		public static bool Yield()
		{
			throw null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00014B37 File Offset: 0x00012D37
		[global::Cpp2ILInjected.Token(Token = "0x600023A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC70A8", Offset = "0x1AC70A8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "SpinWait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public static bool SpinWait(int iterations)
		{
			throw null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00014B3A File Offset: 0x00012D3A
		[global::Cpp2ILInjected.Token(Token = "0x600023B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC70C0", Offset = "0x1AC70C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1.PerCoreLockedStacks", Member = "TryPush", MemberParameters = new object[] { "T[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1.PerCoreLockedStacks", Member = "TryPop", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static int GetCurrentProcessorId()
		{
			throw null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00014B3D File Offset: 0x00012D3D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600023C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC70C8", Offset = "0x1AC70C8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static RuntimeThread()
		{
			throw null;
		}

		// Token: 0x040000E3 RID: 227
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		internal static readonly int OptimalMaxSpinWaitsPerSpinIteration;

		// Token: 0x040000E4 RID: 228
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Threading.Thread thread;
	}
}
