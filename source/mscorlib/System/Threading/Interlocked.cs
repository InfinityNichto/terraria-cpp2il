using System;
using System.Buffers;
using System.Collections;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x020001A1 RID: 417
	[global::Cpp2ILInjected.Token(Token = "0x200020A")]
	public static class Interlocked
	{
		// Token: 0x06001121 RID: 4385
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600128C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E85C", Offset = "0x1C9E85C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern int CompareExchange(ref int location1, int value, int comparand);

		// Token: 0x06001122 RID: 4386
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600128D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA198C", Offset = "0x1CA198C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded);

		// Token: 0x06001123 RID: 4387
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600128E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1990", Offset = "0x1CA1990", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result);

		// Token: 0x06001124 RID: 4388 RVA: 0x00017534 File Offset: 0x00015734
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600128F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1994", Offset = "0x1CA1994", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LazyInitializer), Member = "EnsureLockInitialized", MemberParameters = new object[] { typeof(ref object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "EnsureLockObjectCreated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Queue), Member = "get_SyncRoot", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_InitializeLock", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NclUtilities", Member = "get_LocalAddressesLock", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.LazyAsyncResult", Member = "LazilyCreateEvent", MemberParameters = new object[] { typeof(ref ManualResetEvent) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Configuration.DefaultProxySectionInternal", Member = "get_ClassSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.ListDictionary", Member = "get_SyncRoot", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.CollectionWrapper`1", Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DictionaryWrapper`2", Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static object CompareExchange(ref object location1, object value, object comparand)
		{
			throw null;
		}

		// Token: 0x06001125 RID: 4389
		[global::Cpp2ILInjected.Token(Token = "0x6001290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA19C0", Offset = "0x1CA19C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngineInternal.MathfInternal", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern float CompareExchange(ref float location1, float value, float comparand);

		// Token: 0x06001126 RID: 4390
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA19C4", Offset = "0x1CA19C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern int Decrement(ref int location);

		// Token: 0x06001127 RID: 4391
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA19C8", Offset = "0x1CA19C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern int Increment(ref int location);

		// Token: 0x06001128 RID: 4392
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9FA8C", Offset = "0x1C9FA8C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task<>), Member = "TrySetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.TlsOverPerCoreLockedStacksArrayPool<>), Member = "Return", MemberParameters = new object[]
		{
			"T[]",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<InnerRead>d__25", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "InternalWrite", MemberParameters = new object[]
		{
			"Mono.Net.Security.AsyncProtocolRequest",
			"Mono.Net.Security.BufferOffsetSize2",
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.ExclusiveReference", Member = "Get", ReturnType = "System.Text.RegularExpressions.RegexRunner")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.ExclusiveReference", Member = "Release", MemberParameters = new object[] { "System.Text.RegularExpressions.RegexRunner" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.InfiniteTimer", Member = "Cancel", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = "StopTimerThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_3", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_6", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_8", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_10", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_13", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_15", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_17", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketAsyncEventArgs", Member = "SetLastOperation", MemberParameters = new object[] { "System.Net.Sockets.SocketAsyncOperation" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern int Exchange(ref int location1, int value);

		// Token: 0x06001129 RID: 4393
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001294")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA19CC", Offset = "0x1CA19CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Exchange(ref object location1, ref object value, ref object result);

		// Token: 0x0600112A RID: 4394 RVA: 0x00017537 File Offset: 0x00015737
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001295")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA19D0", Offset = "0x1CA19D0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static object Exchange(ref object location1, object value)
		{
			throw null;
		}

		// Token: 0x0600112B RID: 4395
		[global::Cpp2ILInjected.Token(Token = "0x6001296")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA19F4", Offset = "0x1CA19F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern float Exchange(ref float location1, float value);

		// Token: 0x0600112C RID: 4396
		[global::Cpp2ILInjected.Token(Token = "0x6001297")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA19F8", Offset = "0x1CA19F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern long CompareExchange(ref long location1, long value, long comparand);

		// Token: 0x0600112D RID: 4397
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA19FC", Offset = "0x1CA19FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern global::System.IntPtr CompareExchange(ref global::System.IntPtr location1, global::System.IntPtr value, global::System.IntPtr comparand);

		// Token: 0x0600112E RID: 4398
		[global::Cpp2ILInjected.Token(Token = "0x6001299")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A00", Offset = "0x1CA1A00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double CompareExchange(ref double location1, double value, double comparand);

		// Token: 0x0600112F RID: 4399 RVA: 0x0001753A File Offset: 0x0001573A
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600129A")]
		public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
		{
			throw null;
		}

		// Token: 0x06001130 RID: 4400
		[global::Cpp2ILInjected.Token(Token = "0x600129B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A04", Offset = "0x1CA1A04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "set_Position", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "Seek", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.IO.SeekOrigin)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern long Exchange(ref long location1, long value);

		// Token: 0x06001131 RID: 4401
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600129C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A08", Offset = "0x1CA1A08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "CloseDirectoryHandle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern global::System.IntPtr Exchange(ref global::System.IntPtr location1, global::System.IntPtr value);

		// Token: 0x06001132 RID: 4402
		[global::Cpp2ILInjected.Token(Token = "0x600129D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A0C", Offset = "0x1CA1A0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Exchange(ref double location1, double value);

		// Token: 0x06001133 RID: 4403 RVA: 0x0001753D File Offset: 0x0001573D
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x600129E")]
		public static T Exchange<T>(ref T location1, T value) where T : class
		{
			throw null;
		}

		// Token: 0x06001134 RID: 4404
		[global::Cpp2ILInjected.Token(Token = "0x600129F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A10", Offset = "0x1CA1A10", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "get_Length", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "get_Position", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "get_PositionPointer", ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "Seek", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.IO.SeekOrigin)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public unsafe static extern long Read(ref long location);

		// Token: 0x06001135 RID: 4405
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60012A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A14", Offset = "0x1CA1A14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern int Add(ref int location1, int value);

		// Token: 0x06001136 RID: 4406 RVA: 0x00017540 File Offset: 0x00015740
		[global::Cpp2ILInjected.Token(Token = "0x60012A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A18", Offset = "0x1CA1A18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
		public static void MemoryBarrier()
		{
			throw null;
		}
	}
}
