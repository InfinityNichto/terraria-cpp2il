using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001FF")]
	internal static class TimerThread
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28EBC", Offset = "0x1F28EBC", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "add_DomainUnload", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		static TimerThread()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2910C", Offset = "0x1F2910C", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread.TimerQueue), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddLast", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal static TimerThread.Queue CreateQueue(int durationMilliseconds)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F293F0", Offset = "0x1F293F0", Length = "0x8F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "get_TimerQueue", ReturnType = typeof(TimerThread.Queue))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread.TimerQueue), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddLast", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F29CE4", Offset = "0x1F29CE4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimerThread.TimerQueue), Member = "CreateTimer", MemberParameters = new object[]
		{
			typeof(TimerThread.Callback),
			typeof(object)
		}, ReturnType = typeof(TimerThread.Timer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void Prod()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F29DE8", Offset = "0x1F29DE8", Length = "0x710")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(LinkedListNode<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddLast", MemberParameters = new object[] { typeof(LinkedListNode<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread.TimerQueue), Member = "Fire", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(uint)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NclUtilities), Member = "IsFatal", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		private static void ThreadProc()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2A6DC", Offset = "0x1F2A6DC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimerThread), Member = "OnDomainUnload", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void StopTimerThread()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2A6B8", Offset = "0x1F2A6B8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsTickBetween(int start, int end, int comparand)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2A750", Offset = "0x1F2A750", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread), Member = "StopTimerThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void OnDomainUnload(object sender, EventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000ABA")]
		private const int c_ThreadIdleTimeoutMilliseconds = 30000;

		[global::Cpp2ILInjected.Token(Token = "0x4000ABB")]
		private const int c_CacheScanPerIterations = 32;

		[global::Cpp2ILInjected.Token(Token = "0x4000ABC")]
		private const int c_TickCountResolution = 15;

		[global::Cpp2ILInjected.Token(Token = "0x4000ABD")]
		private static LinkedList<WeakReference> s_Queues;

		[global::Cpp2ILInjected.Token(Token = "0x4000ABE")]
		private static LinkedList<WeakReference> s_NewQueues;

		[global::Cpp2ILInjected.Token(Token = "0x4000ABF")]
		private static int s_ThreadState;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC0")]
		private static AutoResetEvent s_ThreadReadyEvent;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC1")]
		private static ManualResetEvent s_ThreadShutdownEvent;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC2")]
		private static WaitHandle[] s_ThreadEvents;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC3")]
		private static int s_CacheScanIteration;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC4")]
		private static Hashtable s_QueuesCache;

		[global::Cpp2ILInjected.Token(Token = "0x2000200")]
		internal abstract class Queue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C90")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A814", Offset = "0x1F2A814", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Queue(int durationMilliseconds)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700028E")]
			internal int Duration
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C91")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2A83C", Offset = "0x1F2A83C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A844", Offset = "0x1F2A844", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal TimerThread.Timer CreateTimer()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C93")]
			internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);

			[global::Cpp2ILInjected.Token(Token = "0x4000AC5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly int m_DurationMilliseconds;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000201")]
		internal abstract class Timer : IDisposable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A858", Offset = "0x1F2A858", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			internal Timer(int durationMilliseconds)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700028F")]
			internal int Duration
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C95")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2A88C", Offset = "0x1F2A88C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000290")]
			internal int StartTime
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C96")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2A894", Offset = "0x1F2A894", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000291")]
			internal int Expiration
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C97")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2A89C", Offset = "0x1F2A89C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000292")]
			internal int TimeRemaining
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C98")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2A8A8", Offset = "0x1F2A8A8", Length = "0x114")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
				{
					typeof(uint),
					typeof(uint)
				}, ReturnType = typeof(uint))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C99")]
			internal abstract bool Cancel();

			[global::Cpp2ILInjected.Token(Token = "0x17000293")]
			internal abstract bool HasExpired
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C9A")]
				get;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A9BC", Offset = "0x1F2A9BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000AC6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly int m_StartTimeMilliseconds;

			[global::Cpp2ILInjected.Token(Token = "0x4000AC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private readonly int m_DurationMilliseconds;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000202")]
		internal delegate void Callback(TimerThread.Timer timer, int timeNoticed, object context);

		[global::Cpp2ILInjected.Token(Token = "0x2000203")]
		private enum TimerThreadState
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000AC9")]
			Idle,
			[global::Cpp2ILInjected.Token(Token = "0x4000ACA")]
			Running,
			[global::Cpp2ILInjected.Token(Token = "0x4000ACB")]
			Stopped
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000204")]
		private class TimerQueue : TimerThread.Queue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F29360", Offset = "0x1F29360", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimerThread), Member = "CreateQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TimerThread.Queue))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimerThread), Member = "GetOrCreateQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TimerThread.Queue))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal TimerQueue(int durationMilliseconds)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000CA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2ABE0", Offset = "0x1F2ABE0", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Net.TimerThread.TimerNode", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(TimerThread.Callback),
				typeof(object),
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(GCHandle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread), Member = "Prod", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000CA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A4F8", Offset = "0x1F2A4F8", Length = "0x1C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(GCHandle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Net.TimerThread.TimerNode", Member = "Fire", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			internal bool Fire(out int nextExpiration)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000ACC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private IntPtr m_ThisHandle;

			[global::Cpp2ILInjected.Token(Token = "0x4000ACD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private readonly TimerThread.TimerNode m_Timers;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000205")]
		private class InfiniteTimerQueue : TimerThread.Queue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F29340", Offset = "0x1F29340", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal InfiniteTimerQueue()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000CA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2B060", Offset = "0x1F2B060", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000206")]
		private class TimerNode : TimerThread.Timer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2ADB0", Offset = "0x1F2ADB0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.TimerQueue", Member = "CreateTimer", MemberParameters = new object[]
			{
				typeof(TimerThread.Callback),
				typeof(object)
			}, ReturnType = typeof(TimerThread.Timer))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			internal TimerNode(TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000CA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2ABB0", Offset = "0x1F2ABB0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			internal TimerNode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000294")]
			internal override bool HasExpired
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000CA7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2B0F4", Offset = "0x1F2B0F4", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000295")]
			internal TimerThread.TimerNode Next
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000CA8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2B104", Offset = "0x1F2B104", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000CA9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2B10C", Offset = "0x1F2B10C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000296")]
			internal TimerThread.TimerNode Prev
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000CAA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2B114", Offset = "0x1F2B114", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000CAB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2B11C", Offset = "0x1F2B11C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000CAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2B124", Offset = "0x1F2B124", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal override bool Cancel()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000CAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2AE08", Offset = "0x1F2AE08", Length = "0x258")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.TimerQueue", Member = "Fire", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NclUtilities), Member = "IsFatal", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			internal bool Fire()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000ACE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private TimerThread.TimerNode.TimerState m_TimerState;

			[global::Cpp2ILInjected.Token(Token = "0x4000ACF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private TimerThread.Callback m_Callback;

			[global::Cpp2ILInjected.Token(Token = "0x4000AD0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private object m_Context;

			[global::Cpp2ILInjected.Token(Token = "0x4000AD1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private object m_QueueLock;

			[global::Cpp2ILInjected.Token(Token = "0x4000AD2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private TimerThread.TimerNode next;

			[global::Cpp2ILInjected.Token(Token = "0x4000AD3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private TimerThread.TimerNode prev;

			[global::Cpp2ILInjected.Token(Token = "0x2000207")]
			private enum TimerState
			{
				[global::Cpp2ILInjected.Token(Token = "0x4000AD5")]
				Ready,
				[global::Cpp2ILInjected.Token(Token = "0x4000AD6")]
				Fired,
				[global::Cpp2ILInjected.Token(Token = "0x4000AD7")]
				Cancelled,
				[global::Cpp2ILInjected.Token(Token = "0x4000AD8")]
				Sentinel
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000208")]
		private class InfiniteTimer : TimerThread.Timer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2B0C8", Offset = "0x1F2B0C8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			internal InfiniteTimer()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000297")]
			internal override bool HasExpired
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000CAF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2B238", Offset = "0x1F2B238", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000CB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2B240", Offset = "0x1F2B240", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			internal override bool Cancel()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000AD9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int cancelled;
		}
	}
}
