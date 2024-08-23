using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Buffers
{
	// Token: 0x02000547 RID: 1351
	[global::Cpp2ILInjected.Token(Token = "0x2000666")]
	internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T>
	{
		// Token: 0x06002D3E RID: 11582 RVA: 0x0001C2FE File Offset: 0x0001A4FE
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

		// Token: 0x06002D3F RID: 11583 RVA: 0x0001C301 File Offset: 0x0001A501
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

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x0001C304 File Offset: 0x0001A504
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

		// Token: 0x06002D41 RID: 11585 RVA: 0x0001C307 File Offset: 0x0001A507
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

		// Token: 0x06002D42 RID: 11586 RVA: 0x0001C30A File Offset: 0x0001A50A
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

		// Token: 0x06002D43 RID: 11587 RVA: 0x0001C30D File Offset: 0x0001A50D
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

		// Token: 0x06002D44 RID: 11588 RVA: 0x0001C310 File Offset: 0x0001A510
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

		// Token: 0x06002D45 RID: 11589 RVA: 0x0001C313 File Offset: 0x0001A513
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

		// Token: 0x06002D46 RID: 11590 RVA: 0x0001C316 File Offset: 0x0001A516
		[global::Cpp2ILInjected.Token(Token = "0x60031D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x187FDEC", Offset = "0x187FDEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool GetTrimBuffers()
		{
			throw null;
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x0001C319 File Offset: 0x0001A519
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

		// Token: 0x0400163F RID: 5695
		[global::Cpp2ILInjected.Token(Token = "0x4001AB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int[] _bucketArraySizes;

		// Token: 0x04001640 RID: 5696
		[global::Cpp2ILInjected.Token(Token = "0x4001AB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks[] _buckets;

		// Token: 0x04001641 RID: 5697
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4001AB4")]
		private static T[][] t_tlsBuckets;

		// Token: 0x04001642 RID: 5698
		[global::Cpp2ILInjected.Token(Token = "0x4001AB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _callbackCreated;

		// Token: 0x04001643 RID: 5699
		[global::Cpp2ILInjected.Token(Token = "0x4001AB6")]
		private static readonly bool s_trimBuffers;

		// Token: 0x04001644 RID: 5700
		[global::Cpp2ILInjected.Token(Token = "0x4001AB7")]
		private static readonly global::System.Runtime.CompilerServices.ConditionalWeakTable<T[][], object> s_allTlsBuckets;

		// Token: 0x02000665 RID: 1637
		[global::Cpp2ILInjected.Token(Token = "0x2000667")]
		private enum MemoryPressure
		{
			// Token: 0x04001AEB RID: 6891
			[global::Cpp2ILInjected.Token(Token = "0x4001AB9")]
			Low,
			// Token: 0x04001AEC RID: 6892
			[global::Cpp2ILInjected.Token(Token = "0x4001ABA")]
			Medium,
			// Token: 0x04001AED RID: 6893
			[global::Cpp2ILInjected.Token(Token = "0x4001ABB")]
			High
		}

		// Token: 0x02000666 RID: 1638
		[global::Cpp2ILInjected.Token(Token = "0x2000668")]
		private sealed class PerCoreLockedStacks
		{
			// Token: 0x06004355 RID: 17237 RVA: 0x00020453 File Offset: 0x0001E653
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

			// Token: 0x06004356 RID: 17238 RVA: 0x00020456 File Offset: 0x0001E656
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

			// Token: 0x06004357 RID: 17239 RVA: 0x00020459 File Offset: 0x0001E659
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

			// Token: 0x06004358 RID: 17240 RVA: 0x0002045C File Offset: 0x0001E65C
			[global::Cpp2ILInjected.Token(Token = "0x60031DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1819800", Offset = "0x1819800", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int[] bucketSizes)
			{
				throw null;
			}

			// Token: 0x04001AEE RID: 6894
			[global::Cpp2ILInjected.Token(Token = "0x4001ABC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] _perCoreStacks;
		}

		// Token: 0x02000667 RID: 1639
		[global::Cpp2ILInjected.Token(Token = "0x2000669")]
		private sealed class LockedStack
		{
			// Token: 0x06004359 RID: 17241 RVA: 0x0002045F File Offset: 0x0001E65F
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

			// Token: 0x0600435A RID: 17242 RVA: 0x00020462 File Offset: 0x0001E662
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

			// Token: 0x0600435B RID: 17243 RVA: 0x00020465 File Offset: 0x0001E665
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

			// Token: 0x0600435C RID: 17244 RVA: 0x00020468 File Offset: 0x0001E668
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

			// Token: 0x04001AEF RID: 6895
			[global::Cpp2ILInjected.Token(Token = "0x4001ABD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly T[][] _arrays;

			// Token: 0x04001AF0 RID: 6896
			[global::Cpp2ILInjected.Token(Token = "0x4001ABE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _count;

			// Token: 0x04001AF1 RID: 6897
			[global::Cpp2ILInjected.Token(Token = "0x4001ABF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private uint _firstStackItemMS;
		}
	}
}
