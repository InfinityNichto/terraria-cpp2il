using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000209")]
	[StructLayout(0)]
	public abstract class WaitHandle : global::System.MarshalByRefObject, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001274")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0968", Offset = "0x1CA0968", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(EventResetMode),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.ProcessWaitHandle", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Win32.SafeHandles.SafeProcessHandle" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Semaphore", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected WaitHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001275")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0984", Offset = "0x1CA0984", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Init()
		{
			throw null;
		}

		[global::System.Obsolete("Use the SafeWaitHandle property instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x170001C1")]
		public virtual global::System.IntPtr Handle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001276")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA09F0", Offset = "0x1CA09F0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001277")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA0A68", Offset = "0x1CA0A68", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C2")]
		public Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
			[global::Cpp2ILInjected.Token(Token = "0x6001278")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA0B48", Offset = "0x1CA0B48", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new object[]
			{
				typeof(WaitHandle[]),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6001279")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA0BF8", Offset = "0x1CA0BF8", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.ProcessWaitHandle", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Win32.SafeHandles.SafeProcessHandle" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600127A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0C80", Offset = "0x1CA0C80", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(EventResetMode),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600127B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0CAC", Offset = "0x1CA0CAC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600127C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0DAC", Offset = "0x1CA0DAC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool WaitOne()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600127D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0DC0", Offset = "0x1CA0DC0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool WaitOne(int millisecondsTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600127E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0D2C", Offset = "0x1CA0D2C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "InternalWaitOne", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(long),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool WaitOne(long timeout, bool exitContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600127F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0DD0", Offset = "0x1CA0DD0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitOne", MemberParameters = new object[]
		{
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(uint),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static bool InternalWaitOne(global::System.Runtime.InteropServices.SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6001280")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1088", Offset = "0x1CA1088", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "KeepAlive", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", MemberParameters = new object[]
		{
			typeof(int),
			typeof(WaitHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6001281")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA16A0", Offset = "0x1CA16A0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static int WaitAny(WaitHandle[] waitHandles, global::System.TimeSpan timeout, bool exitContext)
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6001282")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA17A8", Offset = "0x1CA17A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ThreadedRenderManager", Member = "WaitAndProcess", MemberParameters = new object[]
		{
			"ThreadedRenderManager.BatchProcessCallback",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001283")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1050", Offset = "0x1CA1050", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "InternalWaitOne", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(long),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AbandonedMutexException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void ThrowAbandonedMutexException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001284")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1654", Offset = "0x1CA1654", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AbandonedMutexException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(WaitHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void ThrowAbandonedMutexException(int location, WaitHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001285")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1810", Offset = "0x1CA1810", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1880", Offset = "0x1CA1880", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void Dispose(bool explicitDisposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001287")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA18C0", Offset = "0x1CA18C0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001288")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0EBC", Offset = "0x1CA0EBC", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "InternalWaitOne", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(long),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "IsWaitNotificationRequired", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static int WaitOneNative(global::System.Runtime.InteropServices.SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001289")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1340", Offset = "0x1CA1340", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "get_SafeWaitHandle", ReturnType = typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "IsWaitNotificationRequired", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600128A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1930", Offset = "0x1CA1930", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SynchronizationContext), Member = "WaitHelper", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr[]),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern int Wait_internal(global::System.IntPtr* handles, int numHandles, bool waitAll, int ms);

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600128B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1938", Offset = "0x1CA1938", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static WaitHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40009CE")]
		public const int WaitTimeout = 258;

		[global::Cpp2ILInjected.Token(Token = "0x40009CF")]
		private const int MAX_WAITHANDLES = 64;

		[global::Cpp2ILInjected.Token(Token = "0x40009D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr waitHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40009D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal Microsoft.Win32.SafeHandles.SafeWaitHandle safeWaitHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40009D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal bool hasThreadAffinity;

		[global::Cpp2ILInjected.Token(Token = "0x40009D3")]
		private const int WAIT_OBJECT_0 = 0;

		[global::Cpp2ILInjected.Token(Token = "0x40009D4")]
		private const int WAIT_ABANDONED = 128;

		[global::Cpp2ILInjected.Token(Token = "0x40009D5")]
		private const int WAIT_FAILED = 2147483647;

		[global::Cpp2ILInjected.Token(Token = "0x40009D6")]
		private const int ERROR_TOO_MANY_POSTS = 298;

		[global::Cpp2ILInjected.Token(Token = "0x40009D7")]
		private const int ERROR_NOT_OWNED_BY_CALLER = 299;

		[global::Cpp2ILInjected.Token(Token = "0x40009D8")]
		protected static readonly global::System.IntPtr InvalidHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40009D9")]
		internal const int MaxWaitHandles = 64;
	}
}
