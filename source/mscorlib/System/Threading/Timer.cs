using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200020F")]
	public sealed class Timer : global::System.MarshalByRefObject, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001C3")]
		private static Timer.Scheduler scheduler
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2364", Offset = "0x1CA2364", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
			{
				typeof(long),
				typeof(long),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA23EC", Offset = "0x1CA23EC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpConnection", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.Sockets.Socket",
			"System.Net.EndPointListener",
			typeof(bool),
			typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		public Timer(TimerCallback callback, object state, int dueTime, int period)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA24A8", Offset = "0x1CA24A8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LeaseManager), Member = "StartManager", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Init", MemberParameters = new object[]
		{
			typeof(TimerCallback),
			typeof(object),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		public Timer(TimerCallback callback, object state, global::System.TimeSpan dueTime, global::System.TimeSpan period)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2438", Offset = "0x1CA2438", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TimerCallback),
			typeof(object),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Delay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Init(TimerCallback callback, object state, long dueTime, long period)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA26F8", Offset = "0x1CA26F8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpConnection", Member = "BeginReadRequest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpConnection", Member = "OnReadInternal", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		public bool Change(int dueTime, int period)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2718", Offset = "0x1CA2718", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LeaseManager), Member = "SetPollTime", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		public bool Change(global::System.TimeSpan dueTime, global::System.TimeSpan period)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2790", Offset = "0x1CA2790", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.DelayPromise", Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LeaseManager), Member = "StopManager", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LeaseManager), Member = "ManageLeases", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "get_scheduler", ReturnType = typeof(Timer.Scheduler))]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2538", Offset = "0x1CA2538", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer), Member = "Init", MemberParameters = new object[]
		{
			typeof(TimerCallback),
			typeof(object),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "get_scheduler", ReturnType = typeof(Timer.Scheduler))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer.Scheduler), Member = "Change", MemberParameters = new object[]
		{
			typeof(Timer),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private bool Change(long dueTime, long period, bool first)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2A0C", Offset = "0x1CA2A0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void KeepRootedWhileScheduled()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2884", Offset = "0x1CA2884", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern long GetTimeMonotonic();

		[global::Cpp2ILInjected.Token(Token = "0x4000A0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TimerCallback callback;

		[global::Cpp2ILInjected.Token(Token = "0x4000A0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object state;

		[global::Cpp2ILInjected.Token(Token = "0x4000A0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long due_time_ms;

		[global::Cpp2ILInjected.Token(Token = "0x4000A0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long period_ms;

		[global::Cpp2ILInjected.Token(Token = "0x4000A0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long next_run;

		[global::Cpp2ILInjected.Token(Token = "0x4000A10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool disposed;

		[global::Cpp2ILInjected.Token(Token = "0x4000A11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool is_dead;

		[global::Cpp2ILInjected.Token(Token = "0x4000A12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		private bool is_added;

		[global::Cpp2ILInjected.Token(Token = "0x2000210")]
		private struct TimerComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<Timer>
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2A10", Offset = "0x1CA2A10", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private int System.Collections.IComparer.Compare(object x, object y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2AA8", Offset = "0x1CA2AA8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Sign", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public int Compare(Timer tx, Timer ty)
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000211")]
		private sealed class Scheduler
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2B14", Offset = "0x1CA2B14", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer.Scheduler), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private void InitScheduler()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2C08", Offset = "0x1CA2C08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
			private void WakeupScheduler()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2C14", Offset = "0x1CA2C14", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer.Scheduler), Member = "RunSchedulerLoop", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private void SchedulerThread()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170001C4")]
			public static Timer.Scheduler Instance
			{
				[global::Cpp2ILInjected.Token(Token = "0x60012BF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA303C", Offset = "0x1CA303C", Length = "0x58")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3094", Offset = "0x1CA3094", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer.Scheduler), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer.Scheduler), Member = "InitScheduler", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private Scheduler()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA27C0", Offset = "0x1CA27C0", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public void Remove(Timer timer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2888", Offset = "0x1CA2888", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
			{
				typeof(long),
				typeof(long),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer.Scheduler), Member = "Add", MemberParameters = new object[] { typeof(Timer) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public void Change(Timer timer, long new_next_run)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3158", Offset = "0x1CA3158", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer.Scheduler), Member = "Change", MemberParameters = new object[]
			{
				typeof(Timer),
				typeof(long)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Add(Timer timer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3130", Offset = "0x1CA3130", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void InternalRemove(Timer timer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA323C", Offset = "0x1CA323C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private static void TimerCB(object o)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA32A8", Offset = "0x1CA32A8", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer.Scheduler), Member = "RunSchedulerLoop", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new object[]
			{
				typeof(WaitCallback),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void FireTimer(Timer timer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60012C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2D30", Offset = "0x1CA2D30", Length = "0x30C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Timer.Scheduler), Member = "SchedulerThread", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Sort", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IComparer<object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer.Scheduler), Member = "FireTimer", MemberParameters = new object[] { typeof(Timer) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(long),
				typeof(long)
			}, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private int RunSchedulerLoop()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60012C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3360", Offset = "0x1CA3360", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer.Scheduler), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static Scheduler()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000A13")]
			private static readonly Timer.Scheduler instance;

			[global::Cpp2ILInjected.Token(Token = "0x4000A14")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private bool needReSort;

			[global::Cpp2ILInjected.Token(Token = "0x4000A15")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private global::System.Collections.Generic.List<Timer> list;

			[global::Cpp2ILInjected.Token(Token = "0x4000A16")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private long current_next_run;

			[global::Cpp2ILInjected.Token(Token = "0x4000A17")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ManualResetEvent changed;
		}
	}
}
