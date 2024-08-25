using System;
using System.Diagnostics.Tracing;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Buffers
{
	[global::System.Diagnostics.Tracing.EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
	[global::Cpp2ILInjected.Token(Token = "0x2000661")]
	internal sealed class ArrayPoolEventSource : global::System.Diagnostics.Tracing.EventSource
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C154E4", Offset = "0x1C154E4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayPoolEventSource), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private ArrayPoolEventSource()
		{
			throw null;
		}

		[global::System.Diagnostics.Tracing.Event(1, Level = global::System.Diagnostics.Tracing.EventLevel.Verbose)]
		[global::Cpp2ILInjected.Token(Token = "0x60031C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15590", Offset = "0x1C15590", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool<>), Member = "Rent", MemberParameters = new object[] { typeof(int) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId)
		{
			throw null;
		}

		[global::System.Diagnostics.Tracing.Event(2, Level = global::System.Diagnostics.Tracing.EventLevel.Informational)]
		[global::Cpp2ILInjected.Token(Token = "0x60031C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1567C", Offset = "0x1C1567C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool<>), Member = "Rent", MemberParameters = new object[] { typeof(int) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason)
		{
			throw null;
		}

		[global::System.Diagnostics.Tracing.Event(3, Level = global::System.Diagnostics.Tracing.EventLevel.Verbose)]
		[global::Cpp2ILInjected.Token(Token = "0x60031C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15784", Offset = "0x1C15784", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool<>), Member = "Return", MemberParameters = new object[]
		{
			"T[]",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void BufferReturned(int bufferId, int bufferSize, int poolId)
		{
			throw null;
		}

		[global::System.Diagnostics.Tracing.Event(4, Level = global::System.Diagnostics.Tracing.EventLevel.Informational)]
		[global::Cpp2ILInjected.Token(Token = "0x60031C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15794", Offset = "0x1C15794", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1.LockedStack", Member = "Trim", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(int),
			"MemoryPressure<T>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool<>), Member = "Trim", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void BufferTrimmed(int bufferId, int bufferSize, int poolId)
		{
			throw null;
		}

		[global::System.Diagnostics.Tracing.Event(5, Level = global::System.Diagnostics.Tracing.EventLevel.Informational)]
		[global::Cpp2ILInjected.Token(Token = "0x60031C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C157A4", Offset = "0x1C157A4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool<>), Member = "Trim", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void BufferTrimPoll(int milliseconds, int pressure)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60031C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C157B0", Offset = "0x1C157B0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayPoolEventSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ArrayPoolEventSource()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001AAA")]
		internal static readonly ArrayPoolEventSource Log;

		[global::Cpp2ILInjected.Token(Token = "0x2000662")]
		internal enum BufferAllocatedReason
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001AAC")]
			Pooled,
			[global::Cpp2ILInjected.Token(Token = "0x4001AAD")]
			OverMaximumSize,
			[global::Cpp2ILInjected.Token(Token = "0x4001AAE")]
			PoolExhausted
		}
	}
}
