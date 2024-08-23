using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000169 RID: 361
	[global::Cpp2ILInjected.Token(Token = "0x20001FF")]
	internal static class TimerThread
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x00004E62 File Offset: 0x00003062
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

		// Token: 0x06000B56 RID: 2902 RVA: 0x00004E65 File Offset: 0x00003065
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

		// Token: 0x06000B57 RID: 2903 RVA: 0x00004E68 File Offset: 0x00003068
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

		// Token: 0x06000B58 RID: 2904 RVA: 0x00004E6B File Offset: 0x0000306B
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

		// Token: 0x06000B59 RID: 2905 RVA: 0x00004E6E File Offset: 0x0000306E
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

		// Token: 0x06000B5A RID: 2906 RVA: 0x00004E71 File Offset: 0x00003071
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

		// Token: 0x06000B5B RID: 2907 RVA: 0x00004E74 File Offset: 0x00003074
		[global::Cpp2ILInjected.Token(Token = "0x6000C8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2A6B8", Offset = "0x1F2A6B8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsTickBetween(int start, int end, int comparand)
		{
			throw null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00004E77 File Offset: 0x00003077
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

		// Token: 0x0400086E RID: 2158
		[global::Cpp2ILInjected.Token(Token = "0x4000ABA")]
		private const int c_ThreadIdleTimeoutMilliseconds = 30000;

		// Token: 0x0400086F RID: 2159
		[global::Cpp2ILInjected.Token(Token = "0x4000ABB")]
		private const int c_CacheScanPerIterations = 32;

		// Token: 0x04000870 RID: 2160
		[global::Cpp2ILInjected.Token(Token = "0x4000ABC")]
		private const int c_TickCountResolution = 15;

		// Token: 0x04000871 RID: 2161
		[global::Cpp2ILInjected.Token(Token = "0x4000ABD")]
		private static LinkedList<WeakReference> s_Queues;

		// Token: 0x04000872 RID: 2162
		[global::Cpp2ILInjected.Token(Token = "0x4000ABE")]
		private static LinkedList<WeakReference> s_NewQueues;

		// Token: 0x04000873 RID: 2163
		[global::Cpp2ILInjected.Token(Token = "0x4000ABF")]
		private static int s_ThreadState;

		// Token: 0x04000874 RID: 2164
		[global::Cpp2ILInjected.Token(Token = "0x4000AC0")]
		private static AutoResetEvent s_ThreadReadyEvent;

		// Token: 0x04000875 RID: 2165
		[global::Cpp2ILInjected.Token(Token = "0x4000AC1")]
		private static ManualResetEvent s_ThreadShutdownEvent;

		// Token: 0x04000876 RID: 2166
		[global::Cpp2ILInjected.Token(Token = "0x4000AC2")]
		private static WaitHandle[] s_ThreadEvents;

		// Token: 0x04000877 RID: 2167
		[global::Cpp2ILInjected.Token(Token = "0x4000AC3")]
		private static int s_CacheScanIteration;

		// Token: 0x04000878 RID: 2168
		[global::Cpp2ILInjected.Token(Token = "0x4000AC4")]
		private static Hashtable s_QueuesCache;

		// Token: 0x020003FE RID: 1022
		[global::Cpp2ILInjected.Token(Token = "0x2000200")]
		internal abstract class Queue
		{
			// Token: 0x06001DD7 RID: 7639 RVA: 0x0000826D File Offset: 0x0000646D
			[global::Cpp2ILInjected.Token(Token = "0x6000C90")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A814", Offset = "0x1F2A814", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Queue(int durationMilliseconds)
			{
				throw null;
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00008270 File Offset: 0x00006470
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

			// Token: 0x06001DD9 RID: 7641 RVA: 0x00008273 File Offset: 0x00006473
			[global::Cpp2ILInjected.Token(Token = "0x6000C92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A844", Offset = "0x1F2A844", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal TimerThread.Timer CreateTimer()
			{
				throw null;
			}

			// Token: 0x06001DDA RID: 7642
			[global::Cpp2ILInjected.Token(Token = "0x6000C93")]
			internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);

			// Token: 0x040011FD RID: 4605
			[global::Cpp2ILInjected.Token(Token = "0x4000AC5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x020003FF RID: 1023
		[global::Cpp2ILInjected.Token(Token = "0x2000201")]
		internal abstract class Timer : IDisposable
		{
			// Token: 0x06001DDB RID: 7643 RVA: 0x00008276 File Offset: 0x00006476
			[global::Cpp2ILInjected.Token(Token = "0x6000C94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A858", Offset = "0x1F2A858", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			internal Timer(int durationMilliseconds)
			{
				throw null;
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00008279 File Offset: 0x00006479
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

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0000827C File Offset: 0x0000647C
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

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06001DDE RID: 7646 RVA: 0x0000827F File Offset: 0x0000647F
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

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00008282 File Offset: 0x00006482
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

			// Token: 0x06001DE0 RID: 7648
			[global::Cpp2ILInjected.Token(Token = "0x6000C99")]
			internal abstract bool Cancel();

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06001DE1 RID: 7649
			[global::Cpp2ILInjected.Token(Token = "0x17000293")]
			internal abstract bool HasExpired
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C9A")]
				get;
			}

			// Token: 0x06001DE2 RID: 7650 RVA: 0x00008285 File Offset: 0x00006485
			[global::Cpp2ILInjected.Token(Token = "0x6000C9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2A9BC", Offset = "0x1F2A9BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x040011FE RID: 4606
			[global::Cpp2ILInjected.Token(Token = "0x4000AC6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly int m_StartTimeMilliseconds;

			// Token: 0x040011FF RID: 4607
			[global::Cpp2ILInjected.Token(Token = "0x4000AC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x02000400 RID: 1024
		// (Invoke) Token: 0x06001DE4 RID: 7652
		[global::Cpp2ILInjected.Token(Token = "0x2000202")]
		internal delegate void Callback(TimerThread.Timer timer, int timeNoticed, object context);

		// Token: 0x02000401 RID: 1025
		[global::Cpp2ILInjected.Token(Token = "0x2000203")]
		private enum TimerThreadState
		{
			// Token: 0x04001201 RID: 4609
			[global::Cpp2ILInjected.Token(Token = "0x4000AC9")]
			Idle,
			// Token: 0x04001202 RID: 4610
			[global::Cpp2ILInjected.Token(Token = "0x4000ACA")]
			Running,
			// Token: 0x04001203 RID: 4611
			[global::Cpp2ILInjected.Token(Token = "0x4000ACB")]
			Stopped
		}

		// Token: 0x02000402 RID: 1026
		[global::Cpp2ILInjected.Token(Token = "0x2000204")]
		private class TimerQueue : TimerThread.Queue
		{
			// Token: 0x06001DE7 RID: 7655 RVA: 0x00008288 File Offset: 0x00006488
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

			// Token: 0x06001DE8 RID: 7656 RVA: 0x0000828B File Offset: 0x0000648B
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

			// Token: 0x06001DE9 RID: 7657 RVA: 0x0000828E File Offset: 0x0000648E
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

			// Token: 0x04001204 RID: 4612
			[global::Cpp2ILInjected.Token(Token = "0x4000ACC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private IntPtr m_ThisHandle;

			// Token: 0x04001205 RID: 4613
			[global::Cpp2ILInjected.Token(Token = "0x4000ACD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private readonly TimerThread.TimerNode m_Timers;
		}

		// Token: 0x02000403 RID: 1027
		[global::Cpp2ILInjected.Token(Token = "0x2000205")]
		private class InfiniteTimerQueue : TimerThread.Queue
		{
			// Token: 0x06001DEA RID: 7658 RVA: 0x00008291 File Offset: 0x00006491
			[global::Cpp2ILInjected.Token(Token = "0x6000CA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F29340", Offset = "0x1F29340", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal InfiniteTimerQueue()
			{
				throw null;
			}

			// Token: 0x06001DEB RID: 7659 RVA: 0x00008294 File Offset: 0x00006494
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

		// Token: 0x02000404 RID: 1028
		[global::Cpp2ILInjected.Token(Token = "0x2000206")]
		private class TimerNode : TimerThread.Timer
		{
			// Token: 0x06001DEC RID: 7660 RVA: 0x00008297 File Offset: 0x00006497
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

			// Token: 0x06001DED RID: 7661 RVA: 0x0000829A File Offset: 0x0000649A
			[global::Cpp2ILInjected.Token(Token = "0x6000CA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2ABB0", Offset = "0x1F2ABB0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			internal TimerNode()
			{
				throw null;
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0000829D File Offset: 0x0000649D
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

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x06001DEF RID: 7663 RVA: 0x000082A0 File Offset: 0x000064A0
			// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x000082A3 File Offset: 0x000064A3
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

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x000082A6 File Offset: 0x000064A6
			// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x000082A9 File Offset: 0x000064A9
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

			// Token: 0x06001DF3 RID: 7667 RVA: 0x000082AC File Offset: 0x000064AC
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

			// Token: 0x06001DF4 RID: 7668 RVA: 0x000082AF File Offset: 0x000064AF
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

			// Token: 0x04001206 RID: 4614
			[global::Cpp2ILInjected.Token(Token = "0x4000ACE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private TimerThread.TimerNode.TimerState m_TimerState;

			// Token: 0x04001207 RID: 4615
			[global::Cpp2ILInjected.Token(Token = "0x4000ACF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private TimerThread.Callback m_Callback;

			// Token: 0x04001208 RID: 4616
			[global::Cpp2ILInjected.Token(Token = "0x4000AD0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private object m_Context;

			// Token: 0x04001209 RID: 4617
			[global::Cpp2ILInjected.Token(Token = "0x4000AD1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private object m_QueueLock;

			// Token: 0x0400120A RID: 4618
			[global::Cpp2ILInjected.Token(Token = "0x4000AD2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private TimerThread.TimerNode next;

			// Token: 0x0400120B RID: 4619
			[global::Cpp2ILInjected.Token(Token = "0x4000AD3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private TimerThread.TimerNode prev;

			// Token: 0x020004B6 RID: 1206
			[global::Cpp2ILInjected.Token(Token = "0x2000207")]
			private enum TimerState
			{
				// Token: 0x0400141B RID: 5147
				[global::Cpp2ILInjected.Token(Token = "0x4000AD5")]
				Ready,
				// Token: 0x0400141C RID: 5148
				[global::Cpp2ILInjected.Token(Token = "0x4000AD6")]
				Fired,
				// Token: 0x0400141D RID: 5149
				[global::Cpp2ILInjected.Token(Token = "0x4000AD7")]
				Cancelled,
				// Token: 0x0400141E RID: 5150
				[global::Cpp2ILInjected.Token(Token = "0x4000AD8")]
				Sentinel
			}
		}

		// Token: 0x02000405 RID: 1029
		[global::Cpp2ILInjected.Token(Token = "0x2000208")]
		private class InfiniteTimer : TimerThread.Timer
		{
			// Token: 0x06001DF5 RID: 7669 RVA: 0x000082B2 File Offset: 0x000064B2
			[global::Cpp2ILInjected.Token(Token = "0x6000CAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2B0C8", Offset = "0x1F2B0C8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			internal InfiniteTimer()
			{
				throw null;
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x000082B5 File Offset: 0x000064B5
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

			// Token: 0x06001DF7 RID: 7671 RVA: 0x000082B8 File Offset: 0x000064B8
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

			// Token: 0x0400120C RID: 4620
			[global::Cpp2ILInjected.Token(Token = "0x4000AD9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int cancelled;
		}
	}
}
