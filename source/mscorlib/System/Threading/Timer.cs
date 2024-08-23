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
	// Token: 0x020001A6 RID: 422
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200020F")]
	public sealed class Timer : global::System.MarshalByRefObject, global::System.IDisposable
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0001755E File Offset: 0x0001575E
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

		// Token: 0x06001146 RID: 4422 RVA: 0x00017561 File Offset: 0x00015761
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

		// Token: 0x06001147 RID: 4423 RVA: 0x00017564 File Offset: 0x00015764
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

		// Token: 0x06001148 RID: 4424 RVA: 0x00017567 File Offset: 0x00015767
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

		// Token: 0x06001149 RID: 4425 RVA: 0x0001756A File Offset: 0x0001576A
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

		// Token: 0x0600114A RID: 4426 RVA: 0x0001756D File Offset: 0x0001576D
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

		// Token: 0x0600114B RID: 4427 RVA: 0x00017570 File Offset: 0x00015770
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

		// Token: 0x0600114C RID: 4428 RVA: 0x00017573 File Offset: 0x00015773
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

		// Token: 0x0600114D RID: 4429 RVA: 0x00017576 File Offset: 0x00015776
		[global::Cpp2ILInjected.Token(Token = "0x60012B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2A0C", Offset = "0x1CA2A0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void KeepRootedWhileScheduled()
		{
			throw null;
		}

		// Token: 0x0600114E RID: 4430
		[global::Cpp2ILInjected.Token(Token = "0x60012B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA2884", Offset = "0x1CA2884", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern long GetTimeMonotonic();

		// Token: 0x040007D7 RID: 2007
		[global::Cpp2ILInjected.Token(Token = "0x4000A0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TimerCallback callback;

		// Token: 0x040007D8 RID: 2008
		[global::Cpp2ILInjected.Token(Token = "0x4000A0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object state;

		// Token: 0x040007D9 RID: 2009
		[global::Cpp2ILInjected.Token(Token = "0x4000A0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long due_time_ms;

		// Token: 0x040007DA RID: 2010
		[global::Cpp2ILInjected.Token(Token = "0x4000A0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long period_ms;

		// Token: 0x040007DB RID: 2011
		[global::Cpp2ILInjected.Token(Token = "0x4000A0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long next_run;

		// Token: 0x040007DC RID: 2012
		[global::Cpp2ILInjected.Token(Token = "0x4000A10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool disposed;

		// Token: 0x040007DD RID: 2013
		[global::Cpp2ILInjected.Token(Token = "0x4000A11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool is_dead;

		// Token: 0x040007DE RID: 2014
		[global::Cpp2ILInjected.Token(Token = "0x4000A12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		private bool is_added;

		// Token: 0x020005B6 RID: 1462
		[global::Cpp2ILInjected.Token(Token = "0x2000210")]
		private struct TimerComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<Timer>
		{
			// Token: 0x06004048 RID: 16456 RVA: 0x0001FB89 File Offset: 0x0001DD89
			[global::Cpp2ILInjected.Token(Token = "0x60012BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2A10", Offset = "0x1CA2A10", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private int System.Collections.IComparer.Compare(object x, object y)
			{
				throw null;
			}

			// Token: 0x06004049 RID: 16457 RVA: 0x0001FB8C File Offset: 0x0001DD8C
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

		// Token: 0x020005B7 RID: 1463
		[global::Cpp2ILInjected.Token(Token = "0x2000211")]
		private sealed class Scheduler
		{
			// Token: 0x0600404A RID: 16458 RVA: 0x0001FB8F File Offset: 0x0001DD8F
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

			// Token: 0x0600404B RID: 16459 RVA: 0x0001FB92 File Offset: 0x0001DD92
			[global::Cpp2ILInjected.Token(Token = "0x60012BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA2C08", Offset = "0x1CA2C08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
			private void WakeupScheduler()
			{
				throw null;
			}

			// Token: 0x0600404C RID: 16460 RVA: 0x0001FB95 File Offset: 0x0001DD95
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

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x0600404D RID: 16461 RVA: 0x0001FB98 File Offset: 0x0001DD98
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

			// Token: 0x0600404E RID: 16462 RVA: 0x0001FB9B File Offset: 0x0001DD9B
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

			// Token: 0x0600404F RID: 16463 RVA: 0x0001FB9E File Offset: 0x0001DD9E
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

			// Token: 0x06004050 RID: 16464 RVA: 0x0001FBA1 File Offset: 0x0001DDA1
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

			// Token: 0x06004051 RID: 16465 RVA: 0x0001FBA4 File Offset: 0x0001DDA4
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

			// Token: 0x06004052 RID: 16466 RVA: 0x0001FBA7 File Offset: 0x0001DDA7
			[global::Cpp2ILInjected.Token(Token = "0x60012C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3130", Offset = "0x1CA3130", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void InternalRemove(Timer timer)
			{
				throw null;
			}

			// Token: 0x06004053 RID: 16467 RVA: 0x0001FBAA File Offset: 0x0001DDAA
			[global::Cpp2ILInjected.Token(Token = "0x60012C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA323C", Offset = "0x1CA323C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private static void TimerCB(object o)
			{
				throw null;
			}

			// Token: 0x06004054 RID: 16468 RVA: 0x0001FBAD File Offset: 0x0001DDAD
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

			// Token: 0x06004055 RID: 16469 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
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

			// Token: 0x06004056 RID: 16470 RVA: 0x0001FBB3 File Offset: 0x0001DDB3
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

			// Token: 0x040018BE RID: 6334
			[global::Cpp2ILInjected.Token(Token = "0x4000A13")]
			private static readonly Timer.Scheduler instance;

			// Token: 0x040018BF RID: 6335
			[global::Cpp2ILInjected.Token(Token = "0x4000A14")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private bool needReSort;

			// Token: 0x040018C0 RID: 6336
			[global::Cpp2ILInjected.Token(Token = "0x4000A15")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private global::System.Collections.Generic.List<Timer> list;

			// Token: 0x040018C1 RID: 6337
			[global::Cpp2ILInjected.Token(Token = "0x4000A16")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private long current_next_run;

			// Token: 0x040018C2 RID: 6338
			[global::Cpp2ILInjected.Token(Token = "0x4000A17")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ManualResetEvent changed;
		}
	}
}
