using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Security.Principal;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Threading
{
	// Token: 0x02000193 RID: 403
	[global::Cpp2ILInjected.Token(Token = "0x20001F8")]
	[StructLayout(0)]
	public sealed class Thread : global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject
	{
		// Token: 0x0600108E RID: 4238 RVA: 0x000173DE File Offset: 0x000155DE
		[global::Cpp2ILInjected.Token(Token = "0x60011E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CFA8", Offset = "0x1C9CFA8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<global::System.Globalization.CultureInfo> args)
		{
			throw null;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000173E1 File Offset: 0x000155E1
		[global::Cpp2ILInjected.Token(Token = "0x60011E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D008", Offset = "0x1C9D008", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<global::System.Globalization.CultureInfo> args)
		{
			throw null;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x000173E4 File Offset: 0x000155E4
		[global::Cpp2ILInjected.Token(Token = "0x60011E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D068", Offset = "0x1C9D068", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ManagedThread", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ParameterizedThreadStart),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ManagedThread", Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationFinder", Member = "StartSearching", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.StartListening", MemberParameters = new object[] { "Terraria.Net.Sockets.SocketConnectionAccepted" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Timer.Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = "Prod", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Thread(ThreadStart start)
		{
			throw null;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x000173E7 File Offset: 0x000155E7
		[global::Cpp2ILInjected.Token(Token = "0x60011EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D20C", Offset = "0x1C9D20C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Thread(ParameterizedThreadStart start)
		{
			throw null;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000173EA File Offset: 0x000155EA
		[global::Cpp2ILInjected.Token(Token = "0x60011EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D288", Offset = "0x1C9D288", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "Create", MemberParameters = new object[]
		{
			typeof(ParameterizedThreadStart),
			typeof(int)
		}, ReturnType = typeof(Internal.Runtime.Augments.RuntimeThread))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public Thread(ParameterizedThreadStart start, int maxStackSize)
		{
			throw null;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x000173ED File Offset: 0x000155ED
		[global::Cpp2ILInjected.Token(Token = "0x60011EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D370", Offset = "0x1C9D370", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ManagedThread", Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ManagedThread", Member = "RunCritical", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationFinder", Member = "StartSearching", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.StartListening", MemberParameters = new object[] { "Terraria.Net.Sockets.SocketConnectionAccepted" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Timer.Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = "Prod", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", MemberParameters = new object[] { typeof(ref StackCrawlMark) }, ReturnType = typeof(void))]
		[MethodImpl(8)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000173F0 File Offset: 0x000155F0
		[global::Cpp2ILInjected.Token(Token = "0x60011ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D43C", Offset = "0x1C9D43C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "Start", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", MemberParameters = new object[] { typeof(ref StackCrawlMark) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		[MethodImpl(8)]
		public void Start(object parameter)
		{
			throw null;
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x000173F3 File Offset: 0x000155F3
		[global::Cpp2ILInjected.Token(Token = "0x60011EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D384", Offset = "0x1C9D384", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "Start", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new object[]
		{
			typeof(ref StackCrawlMark),
			typeof(ExecutionContext.CaptureOptions)
		}, ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "StartInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref StackCrawlMark)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Start(ref StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x000173F6 File Offset: 0x000155F6
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60011EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A950", Offset = "0x1C9A950", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "SerializeCallData", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CallContext), Member = "LogicalGetData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal ExecutionContext.Reader GetExecutionContextReader()
		{
			throw null;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x000173F9 File Offset: 0x000155F9
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x000173FC File Offset: 0x000155FC
		[global::Cpp2ILInjected.Token(Token = "0x170001B1")]
		internal bool ExecutionContextBelongsToCurrentScope
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B7F8", Offset = "0x1C9B7F8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60011F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B808", Offset = "0x1C9B808", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x000173FF File Offset: 0x000155FF
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x60011F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B11C", Offset = "0x1C9B11C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "SetLocalValue", MemberParameters = new object[]
		{
			typeof(IAsyncLocal),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new object[] { typeof(SynchronizationContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "DeserializeCallData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CallContext), Member = "SetLogicalCallContext", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CallContext), Member = "LogicalSetData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ExecutionContext GetMutableExecutionContext()
		{
			throw null;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00017402 File Offset: 0x00015602
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60011F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B848", Offset = "0x1C9B848", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
			throw null;
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00017405 File Offset: 0x00015605
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60011F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A958", Offset = "0x1C9A958", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
			throw null;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00017408 File Offset: 0x00015608
		[global::Cpp2ILInjected.Token(Token = "0x60011F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D56C", Offset = "0x1C9D56C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Disconnect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server.<>c__DisplayClass8_0", Member = "<Listen>b__1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Interrupt()
		{
			throw null;
		}

		// Token: 0x0600109D RID: 4253
		[global::Cpp2ILInjected.Token(Token = "0x60011F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D570", Offset = "0x1C9D570", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern void InterruptInternal();

		// Token: 0x17000177 RID: 375
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0001740B File Offset: 0x0001560B
		[global::Cpp2ILInjected.Token(Token = "0x170001B2")]
		public ThreadPriority Priority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9D574", Offset = "0x1C9D574", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ManagedThread", Member = "RunCritical", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600109F RID: 4255
		[global::Cpp2ILInjected.Token(Token = "0x60011F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D578", Offset = "0x1C9D578", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern void SetPriorityNative(int priority);

		// Token: 0x060010A0 RID: 4256
		[global::Cpp2ILInjected.Token(Token = "0x60011F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D57C", Offset = "0x1C9D57C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool JoinInternal(int millisecondsTimeout);

		// Token: 0x060010A1 RID: 4257 RVA: 0x0001740E File Offset: 0x0001560E
		[global::Cpp2ILInjected.Token(Token = "0x60011FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D580", Offset = "0x1C9D580", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Disconnect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Join()
		{
			throw null;
		}

		// Token: 0x060010A2 RID: 4258
		[global::Cpp2ILInjected.Token(Token = "0x60011FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D588", Offset = "0x1C9D588", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void SleepInternal(int millisecondsTimeout);

		// Token: 0x060010A3 RID: 4259 RVA: 0x00017411 File Offset: 0x00015611
		[global::Cpp2ILInjected.Token(Token = "0x60011FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A2B0", Offset = "0x1C9A2B0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void Sleep(int millisecondsTimeout)
		{
			throw null;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00017414 File Offset: 0x00015614
		[global::Cpp2ILInjected.Token(Token = "0x60011FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D58C", Offset = "0x1C9D58C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sleep(global::System.TimeSpan timeout)
		{
			throw null;
		}

		// Token: 0x060010A5 RID: 4261
		[global::Cpp2ILInjected.Token(Token = "0x60011FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D640", Offset = "0x1C9D640", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool YieldInternal();

		// Token: 0x060010A6 RID: 4262 RVA: 0x00017417 File Offset: 0x00015617
		[global::Cpp2ILInjected.Token(Token = "0x60011FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A328", Offset = "0x1C9A328", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "Yield", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool Yield()
		{
			throw null;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0001741A File Offset: 0x0001561A
		[global::Cpp2ILInjected.Token(Token = "0x6001200")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D0E4", Offset = "0x1C9D0E4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ParameterizedThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ParameterizedThreadStart),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "GetProcessDefaultStackSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterizedThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void SetStartHelper(global::System.Delegate start, int maxStackSize)
		{
			throw null;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0001741D File Offset: 0x0001561D
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x00017420 File Offset: 0x00015620
		[global::Cpp2ILInjected.Token(Token = "0x170001B3")]
		public global::System.Globalization.CultureInfo CurrentUICulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001201")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9D724", Offset = "0x1C9D724", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001202")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9D7FC", Offset = "0x1C9D7FC", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "SetLanguage", MemberParameters = new object[] { "Terraria.Localization.GameCulture" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "VerifyCultureName", MemberParameters = new object[]
			{
				typeof(global::System.Globalization.CultureInfo),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "nativeInitCultureAccessors", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncLocal<>), Member = ".ctor", MemberParameters = new object[] { "System.Action`1<AsyncLocalValueChangedArgs`1<T>>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncLocal<>), Member = "set_Value", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00017423 File Offset: 0x00015623
		[global::Cpp2ILInjected.Token(Token = "0x6001203")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D750", Offset = "0x1C9D750", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_DefaultThreadCurrentUICulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_UserDefaultUICulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal global::System.Globalization.CultureInfo GetCurrentUICultureNoAppX()
		{
			throw null;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00017426 File Offset: 0x00015626
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00017429 File Offset: 0x00015629
		[global::Cpp2ILInjected.Token(Token = "0x170001B4")]
		public global::System.Globalization.CultureInfo CurrentCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001204")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DAAC", Offset = "0x1C9DAAC", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.SpriteFont", Member = "CreateWrappedText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(float)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher.<>c", Member = "<Inititialize>b__18_0", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher.<>c", Member = "<Inititialize>b__18_1", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.UnhandledExceptionEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001205")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DB84", Offset = "0x1C9DB84", Length = "0x1E4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "SetLanguage", MemberParameters = new object[] { "Terraria.Localization.GameCulture" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "nativeInitCultureAccessors", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncLocal<>), Member = ".ctor", MemberParameters = new object[] { "System.Action`1<AsyncLocalValueChangedArgs`1<T>>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncLocal<>), Member = "set_Value", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0001742C File Offset: 0x0001562C
		[global::Cpp2ILInjected.Token(Token = "0x6001206")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DAD8", Offset = "0x1C9DAD8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_DefaultThreadCurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_UserDefaultCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private global::System.Globalization.CultureInfo GetCurrentCultureNoAppX()
		{
			throw null;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0001742F File Offset: 0x0001562F
		[global::Cpp2ILInjected.Token(Token = "0x6001207")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DA08", Offset = "0x1C9DA08", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "set_CurrentUICulture", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "set_CurrentCulture", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "ConstructCurrentUICulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void nativeInitCultureAccessors()
		{
			throw null;
		}

		// Token: 0x060010AF RID: 4271
		[global::Cpp2ILInjected.Token(Token = "0x6001208")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DD68", Offset = "0x1C9DD68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlCharType", Member = "InitInstance", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XHashtable`1.XHashtableState", Member = "TryAdd", MemberParameters = new object[] { "TValue", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XHashtable`1", Member = "Add", MemberParameters = new object[] { "TValue" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void MemoryBarrier();

		// Token: 0x060010B0 RID: 4272
		[global::Cpp2ILInjected.Token(Token = "0x6001209")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DD6C", Offset = "0x1C9DD6C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern void ConstructInternalThread();

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00017432 File Offset: 0x00015632
		[global::Cpp2ILInjected.Token(Token = "0x170001B5")]
		private InternalThread Internal
		{
			[global::Cpp2ILInjected.Token(Token = "0x600120A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DD70", Offset = "0x1C9DD70", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00017435 File Offset: 0x00015635
		[global::Cpp2ILInjected.Token(Token = "0x170001B6")]
		public static global::System.Runtime.Remoting.Contexts.Context CurrentContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x600120B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DD94", Offset = "0x1C9DD94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetData", MemberParameters = new object[] { typeof(global::System.LocalDataStoreSlot) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "SetData", MemberParameters = new object[]
			{
				typeof(global::System.LocalDataStoreSlot),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel.ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "Activate", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy),
				typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateConstructionCall", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ConstructionLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.EnvoyTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.EnvoyTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalGetContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060010B3 RID: 4275
		[global::Cpp2ILInjected.Token(Token = "0x600120C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DD9C", Offset = "0x1C9DD9C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void GetCurrentThread_icall(ref Thread thread);

		// Token: 0x060010B4 RID: 4276 RVA: 0x00017438 File Offset: 0x00015638
		[global::Cpp2ILInjected.Token(Token = "0x600120D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DDA0", Offset = "0x1C9DDA0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static Thread GetCurrentThread()
		{
			throw null;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0001743B File Offset: 0x0001563B
		[global::Cpp2ILInjected.Token(Token = "0x170001B7")]
		public static Thread CurrentThread
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
			[global::Cpp2ILInjected.Token(Token = "0x600120E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9A32C", Offset = "0x1C9A32C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 96)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060010B6 RID: 4278
		[global::Cpp2ILInjected.Token(Token = "0x600120F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DDBC", Offset = "0x1C9DDBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "IsFinalizingForUnload", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "getDomainID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainChannel), Member = "get_ChannelData", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "MarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern int GetDomainID();

		// Token: 0x060010B7 RID: 4279
		[global::Cpp2ILInjected.Token(Token = "0x6001210")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DDC0", Offset = "0x1C9DDC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool Thread_internal(global::System.MulticastDelegate start);

		// Token: 0x060010B8 RID: 4280 RVA: 0x0001743E File Offset: 0x0001563E
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001211")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DDC4", Offset = "0x1C9DDC4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00017441 File Offset: 0x00015641
		[global::Cpp2ILInjected.Token(Token = "0x170001B8")]
		public bool IsThreadPoolThread
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001212")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DDCC", Offset = "0x1C9DDCC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "get_IsThreadPoolThread", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00017444 File Offset: 0x00015644
		[global::Cpp2ILInjected.Token(Token = "0x170001B9")]
		internal bool IsThreadPoolThreadInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001213")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DDF0", Offset = "0x1C9DDF0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00017447 File Offset: 0x00015647
		[global::Cpp2ILInjected.Token(Token = "0x170001BA")]
		public bool IsAlive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001214")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DE14", Offset = "0x1C9DE14", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ThreadManager", Member = "TerminateAll", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "get_Active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0001744A File Offset: 0x0001564A
		[global::Cpp2ILInjected.Token(Token = "0x170001BB")]
		public bool IsBackground
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001215")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DE5C", Offset = "0x1C9DE5C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ManagedThread", Member = "Run", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.StartListening", MemberParameters = new object[] { "Terraria.Net.Sockets.SocketConnectionAccepted" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Start", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Timer.Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "ValidateThreadState", ReturnType = typeof(ThreadState))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060010BD RID: 4285
		[global::Cpp2ILInjected.Token(Token = "0x6001216")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DF1C", Offset = "0x1C9DF1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string GetName_internal(InternalThread thread);

		// Token: 0x060010BE RID: 4286
		[global::Cpp2ILInjected.Token(Token = "0x6001217")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DF20", Offset = "0x1C9DF20", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void SetName_icall(InternalThread thread, char* name, int nameLength);

		// Token: 0x060010BF RID: 4287 RVA: 0x0001744D File Offset: 0x0001564D
		[global::Cpp2ILInjected.Token(Token = "0x6001218")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DF24", Offset = "0x1C9DF24", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void SetName_internal(InternalThread thread, string name)
		{
			throw null;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x00017450 File Offset: 0x00015650
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00017453 File Offset: 0x00015653
		[global::Cpp2ILInjected.Token(Token = "0x170001BC")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001219")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DF64", Offset = "0x1C9DF64", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher.<>c", Member = "<Inititialize>b__18_0", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher.<>c", Member = "<Inititialize>b__18_1", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.UnhandledExceptionEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600121A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DF88", Offset = "0x1C9DF88", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "LaunchGame", MemberParameters = new object[]
			{
				"System.String[]",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.StartListening", MemberParameters = new object[] { "Terraria.Net.Sockets.SocketConnectionAccepted" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Start", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Timer.Scheduler", Member = "SchedulerThread", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "SetName_internal", MemberParameters = new object[]
			{
				typeof(InternalThread),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00017456 File Offset: 0x00015656
		[global::Cpp2ILInjected.Token(Token = "0x170001BD")]
		public ThreadState ThreadState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600121B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9DFBC", Offset = "0x1C9DFBC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "TrySetApartmentState", MemberParameters = new object[] { typeof(ApartmentState) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060010C3 RID: 4291
		[global::Cpp2ILInjected.Token(Token = "0x600121C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DFE0", Offset = "0x1C9DFE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void Abort_internal(InternalThread thread, object stateInfo);

		// Token: 0x060010C4 RID: 4292 RVA: 0x00017459 File Offset: 0x00015659
		[global::Cpp2ILInjected.Token(Token = "0x600121D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DFE4", Offset = "0x1C9DFE4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ThreadManager", Member = "TerminateAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationFinder", Member = "StopSearching", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Abort()
		{
			throw null;
		}

		// Token: 0x060010C5 RID: 4293
		[global::Cpp2ILInjected.Token(Token = "0x600121E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E00C", Offset = "0x1C9E00C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void SpinWait_nop();

		// Token: 0x060010C6 RID: 4294 RVA: 0x0001745C File Offset: 0x0001565C
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600121F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A288", Offset = "0x1C9A288", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Runtime.Augments.RuntimeThread), Member = "SpinWait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.LazyAsyncResult", Member = "WaitForCompletion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void SpinWait(int iterations)
		{
			throw null;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0001745F File Offset: 0x0001565F
		[global::Cpp2ILInjected.Token(Token = "0x6001220")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D504", Offset = "0x1C9D504", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "Start", MemberParameters = new object[] { typeof(ref StackCrawlMark) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void StartInternal(object principal, ref StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x060010C8 RID: 4296
		[global::Cpp2ILInjected.Token(Token = "0x6001221")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DF14", Offset = "0x1C9DF14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void SetState(InternalThread thread, ThreadState set);

		// Token: 0x060010C9 RID: 4297
		[global::Cpp2ILInjected.Token(Token = "0x6001222")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DF18", Offset = "0x1C9DF18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void ClrState(InternalThread thread, ThreadState clr);

		// Token: 0x060010CA RID: 4298
		[global::Cpp2ILInjected.Token(Token = "0x6001223")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DE58", Offset = "0x1C9DE58", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern ThreadState GetState(InternalThread thread);

		// Token: 0x060010CB RID: 4299
		[global::Cpp2ILInjected.Token(Token = "0x6001224")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E010", Offset = "0x1C9E010", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int SystemMaxStackStize();

		// Token: 0x060010CC RID: 4300 RVA: 0x00017462 File Offset: 0x00015662
		[global::Cpp2ILInjected.Token(Token = "0x6001225")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D644", Offset = "0x1C9D644", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetPageSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static int GetProcessDefaultStackSize(int maxStackSize)
		{
			throw null;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00017465 File Offset: 0x00015665
		[global::Cpp2ILInjected.Token(Token = "0x6001226")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9D6F0", Offset = "0x1C9D6F0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetStart(global::System.MulticastDelegate start, int maxStackSize)
		{
			throw null;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x00017468 File Offset: 0x00015668
		[global::Cpp2ILInjected.Token(Token = "0x170001BE")]
		public int ManagedThreadId
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6001227")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9A388", Offset = "0x1C9A388", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0001746B File Offset: 0x0001566B
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6001228")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C99B50", Offset = "0x1C99B50", Length = "0x40")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void BeginCriticalRegion()
		{
			throw null;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0001746E File Offset: 0x0001566E
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001229")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A0A4", Offset = "0x1C9A0A4", Length = "0x40")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void EndCriticalRegion()
		{
			throw null;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00017471 File Offset: 0x00015671
		[global::Cpp2ILInjected.Token(Token = "0x600122A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E014", Offset = "0x1C9E014", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "TrySetApartmentState", MemberParameters = new object[] { typeof(ApartmentState) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetApartmentState(ApartmentState state)
		{
			throw null;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00017474 File Offset: 0x00015674
		[global::Cpp2ILInjected.Token(Token = "0x600122B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E070", Offset = "0x1C9E070", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "SetApartmentState", MemberParameters = new object[] { typeof(ApartmentState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ThreadState", ReturnType = typeof(ThreadState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStateException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool TrySetApartmentState(ApartmentState state)
		{
			throw null;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00017477 File Offset: 0x00015677
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600122C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E134", Offset = "0x1C9E134", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0001747A File Offset: 0x0001567A
		[global::Cpp2ILInjected.Token(Token = "0x600122D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9DEA4", Offset = "0x1C9DEA4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStateException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private ThreadState ValidateThreadState()
		{
			throw null;
		}

		// Token: 0x04000776 RID: 1910
		[global::Cpp2ILInjected.Token(Token = "0x40009A0")]
		private static global::System.LocalDataStoreMgr s_LocalDataStoreMgr;

		// Token: 0x04000777 RID: 1911
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40009A1")]
		private static global::System.LocalDataStoreHolder s_LocalDataStore;

		// Token: 0x04000778 RID: 1912
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40009A2")]
		internal static global::System.Globalization.CultureInfo m_CurrentCulture;

		// Token: 0x04000779 RID: 1913
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40009A3")]
		internal static global::System.Globalization.CultureInfo m_CurrentUICulture;

		// Token: 0x0400077A RID: 1914
		[global::Cpp2ILInjected.Token(Token = "0x40009A4")]
		private static AsyncLocal<global::System.Globalization.CultureInfo> s_asyncLocalCurrentCulture;

		// Token: 0x0400077B RID: 1915
		[global::Cpp2ILInjected.Token(Token = "0x40009A5")]
		private static AsyncLocal<global::System.Globalization.CultureInfo> s_asyncLocalCurrentUICulture;

		// Token: 0x0400077C RID: 1916
		[global::Cpp2ILInjected.Token(Token = "0x40009A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InternalThread internal_thread;

		// Token: 0x0400077D RID: 1917
		[global::Cpp2ILInjected.Token(Token = "0x40009A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object m_ThreadStartArg;

		// Token: 0x0400077E RID: 1918
		[global::Cpp2ILInjected.Token(Token = "0x40009A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object pending_exception;

		// Token: 0x0400077F RID: 1919
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40009A9")]
		private static Thread current_thread;

		// Token: 0x04000780 RID: 1920
		[global::Cpp2ILInjected.Token(Token = "0x40009AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.MulticastDelegate m_Delegate;

		// Token: 0x04000781 RID: 1921
		[global::Cpp2ILInjected.Token(Token = "0x40009AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ExecutionContext m_ExecutionContext;

		// Token: 0x04000782 RID: 1922
		[global::Cpp2ILInjected.Token(Token = "0x40009AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool m_ExecutionContextBelongsToOuterScope;

		// Token: 0x04000783 RID: 1923
		[global::Cpp2ILInjected.Token(Token = "0x40009AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Security.Principal.IPrincipal principal;

		// Token: 0x04000784 RID: 1924
		[global::Cpp2ILInjected.Token(Token = "0x40009AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int principal_version;
	}
}
