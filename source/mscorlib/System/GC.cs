using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000116 RID: 278
	[global::Cpp2ILInjected.Token(Token = "0x2000155")]
	public static class GC
	{
		// Token: 0x06000CA6 RID: 3238
		[global::Cpp2ILInjected.Token(Token = "0x6000D7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6ABEC", Offset = "0x1C6ABEC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int GetCollectionCount(int generation);

		// Token: 0x06000CA7 RID: 3239
		[global::Cpp2ILInjected.Token(Token = "0x6000D7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6ABF0", Offset = "0x1C6ABF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void InternalCollect(int generation);

		// Token: 0x06000CA8 RID: 3240
		[global::Cpp2ILInjected.Token(Token = "0x6000D80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6ABF4", Offset = "0x1C6ABF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "Rehash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void register_ephemeron_array(global::System.Runtime.CompilerServices.Ephemeron[] array);

		// Token: 0x06000CA9 RID: 3241
		[global::Cpp2ILInjected.Token(Token = "0x6000D81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6ABF8", Offset = "0x1C6ABF8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern object get_ephemeron_tombstone();

		// Token: 0x06000CAA RID: 3242 RVA: 0x000169A6 File Offset: 0x00014BA6
		[global::Cpp2ILInjected.Token(Token = "0x6000D82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6ABFC", Offset = "0x1C6ABFC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.TlsOverPerCoreLockedStacksArrayPool<>), Member = "GetMemoryPressure", ReturnType = "MemoryPressure<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out global::System.UIntPtr lastRecordedHeapSize, out global::System.UIntPtr lastRecordedFragmentation)
		{
			throw null;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x000169A9 File Offset: 0x00014BA9
		[global::Cpp2ILInjected.Token(Token = "0x6000D83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AC94", Offset = "0x1C6AC94", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.InteropServices.HandleCollector", Member = "Add", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Collect(int generation)
		{
			throw null;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000169AC File Offset: 0x00014BAC
		[global::Cpp2ILInjected.Token(Token = "0x6000D84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6ACEC", Offset = "0x1C6ACEC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Collect(int generation, global::System.GCCollectionMode mode)
		{
			throw null;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000169AF File Offset: 0x00014BAF
		[global::Cpp2ILInjected.Token(Token = "0x6000D85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AD54", Offset = "0x1C6AD54", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Collect(int generation, global::System.GCCollectionMode mode, bool blocking)
		{
			throw null;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000169B2 File Offset: 0x00014BB2
		[global::Cpp2ILInjected.Token(Token = "0x6000D86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6ADC4", Offset = "0x1C6ADC4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void Collect(int generation, global::System.GCCollectionMode mode, bool blocking, bool compacting)
		{
			throw null;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000169B5 File Offset: 0x00014BB5
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AEC4", Offset = "0x1C6AEC4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.InteropServices.HandleCollector", Member = "Add", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.InteropServices.HandleCollector", Member = "Remove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Switch", Member = "_pruneCachedSwitches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static int CollectionCount(int generation)
		{
			throw null;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x000169B8 File Offset: 0x00014BB8
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AF80", Offset = "0x1C6AF80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(global::System.Threading.WaitHandle[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRegistry", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[MethodImpl(8)]
		public static void KeepAlive(object obj)
		{
			throw null;
		}

		// Token: 0x06000CB1 RID: 3249
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AF84", Offset = "0x1C6AF84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void _SuppressFinalize(object o);

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000169BB File Offset: 0x00014BBB
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AF88", Offset = "0x1C6AF88", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 67)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void SuppressFinalize(object obj)
		{
			throw null;
		}

		// Token: 0x06000CB3 RID: 3251
		[global::Cpp2ILInjected.Token(Token = "0x6000D8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B028", Offset = "0x1C6B028", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void _ReRegisterForFinalize(object o);

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000169BE File Offset: 0x00014BBE
		[global::Cpp2ILInjected.Token(Token = "0x6000D8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B02C", Offset = "0x1C6B02C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "MarkAsUnhandled", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void ReRegisterForFinalize(object obj)
		{
			throw null;
		}

		// Token: 0x06000CB5 RID: 3253
		[global::Cpp2ILInjected.Token(Token = "0x6000D8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B0CC", Offset = "0x1C6B0CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.WeakHashtable", Member = "ScavengeKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern long GetTotalMemory(bool forceFullCollection);

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000169C1 File Offset: 0x00014BC1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000D8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B0D4", Offset = "0x1C6B0D4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static GC()
		{
			throw null;
		}

		// Token: 0x040003B0 RID: 944
		[global::Cpp2ILInjected.Token(Token = "0x4000539")]
		internal static readonly object EPHEMERON_TOMBSTONE;
	}
}
