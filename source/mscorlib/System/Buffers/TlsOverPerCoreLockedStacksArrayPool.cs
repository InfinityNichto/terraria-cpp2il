using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Buffers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000666")]
	internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x187EB68", Offset = "0x187EB68", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public TlsOverPerCoreLockedStacksArrayPool()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x187EC4C", Offset = "0x187EC4C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks CreatePerCoreLockedStacks(int bucketIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007FC")]
		private int Id
		{
			[global::Cpp2ILInjected.Token(Token = "0x60031D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x187ECCC", Offset = "0x187ECCC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x187ECD8", Offset = "0x187ECD8", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferRented", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferAllocated", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ArrayPoolEventSource.BufferAllocatedReason)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override T[] Rent(int minimumLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x187F014", Offset = "0x187F014", Length = "0x47C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Gen2GcCallback), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Func<object, bool>),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferReturned", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public override void Return(T[] array, bool clearArray = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x187F490", Offset = "0x187F490", Length = "0x7AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimPoll", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public bool Trim()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x187FC3C", Offset = "0x187FC3C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool Gen2GcCallbackFunc(object target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x187FD34", Offset = "0x187FD34", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "GetMemoryInfo", MemberParameters = new object[]
		{
			typeof(ref uint),
			typeof(ref ulong),
			typeof(ref uint),
			typeof(ref global::System.UIntPtr),
			typeof(ref global::System.UIntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure GetMemoryPressure()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x187FDEC", Offset = "0x187FDEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool GetTrimBuffers()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60031D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x187FDF4", Offset = "0x187FDF4", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static TlsOverPerCoreLockedStacksArrayPool()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001AB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int[] _bucketArraySizes;

		[global::Cpp2ILInjected.Token(Token = "0x4001AB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks[] _buckets;

		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4001AB4")]
		private static T[][] t_tlsBuckets;

		[global::Cpp2ILInjected.Token(Token = "0x4001AB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _callbackCreated;

		[global::Cpp2ILInjected.Token(Token = "0x4001AB6")]
		private static readonly bool s_trimBuffers;

		[global::Cpp2ILInjected.Token(Token = "0x4001AB7")]
		private static readonly global::System.Runtime.CompilerServices.ConditionalWeakTable<T[][], object> s_allTlsBuckets;

		[global::Cpp2ILInjected.Token(Token = "0x2000667")]
		private enum MemoryPressure
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001AB9")]
			Low,
			[global::Cpp2ILInjected.Token(Token = "0x4001ABA")]
			Medium,
			[global::Cpp2ILInjected.Token(Token = "0x4001ABB")]
			High
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000668")]
		private sealed class PerCoreLockedStacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60031D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1819534", Offset = "0x1819534", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public PerCoreLockedStacks()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60031DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x181967C", Offset = "0x181967C", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "GetCurrentProcessorId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(256)]
			public void TryPush(T[] array)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60031DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1819740", Offset = "0x1819740", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "GetCurrentProcessorId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(256)]
			public T[] TryPop()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60031DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1819800", Offset = "0x1819800", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int[] bucketSizes)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001ABC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] _perCoreStacks;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000669")]
		private sealed class LockedStack
		{
			[global::Cpp2ILInjected.Token(Token = "0x60031DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C6254", Offset = "0x17C6254", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			[MethodImpl(256)]
			public bool TryPush(T[] array)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60031DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C6344", Offset = "0x17C6344", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[MethodImpl(256)]
			public T[] TryPop()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60031DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C639C", Offset = "0x17C639C", Length = "0x228")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public void Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int bucketSize)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60031E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C65C4", Offset = "0x17C65C4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public LockedStack()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001ABD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly T[][] _arrays;

			[global::Cpp2ILInjected.Token(Token = "0x4001ABE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _count;

			[global::Cpp2ILInjected.Token(Token = "0x4001ABF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private uint _firstStackItemMS;
		}
	}
}
