using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200018D RID: 397
	[global::Cpp2ILInjected.Token(Token = "0x20001EC")]
	[global::System.Serializable]
	public sealed class ExecutionContext : global::System.IDisposable, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x000172FA File Offset: 0x000154FA
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x000172FD File Offset: 0x000154FD
		[global::Cpp2ILInjected.Token(Token = "0x170001A2")]
		internal bool isNewCapture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001182")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9ADD8", Offset = "0x1C9ADD8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001183")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9ADEC", Offset = "0x1C9ADEC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00017300 File Offset: 0x00015500
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x00017303 File Offset: 0x00015503
		[global::Cpp2ILInjected.Token(Token = "0x170001A3")]
		internal bool isFlowSuppressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001184")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9AE08", Offset = "0x1C9AE08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001185")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9AE14", Offset = "0x1C9AE14", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00017306 File Offset: 0x00015506
		[global::Cpp2ILInjected.Token(Token = "0x170001A4")]
		internal bool IsPreAllocatedDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001186")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9AE30", Offset = "0x1C9AE30", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(ref global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner)
			}, ReturnType = typeof(global::System.Action))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00017309 File Offset: 0x00015509
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001187")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9AE3C", Offset = "0x1C9AE3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ExecutionContext()
		{
			throw null;
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0001730C File Offset: 0x0001550C
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6001188")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9AE44", Offset = "0x1C9AE44", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ExecutionContext(bool isPreAllocatedDefault)
		{
			throw null;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0001730F File Offset: 0x0001550F
		[global::Cpp2ILInjected.Token(Token = "0x6001189")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9AE74", Offset = "0x1C9AE74", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncLocal<>), Member = "set_Value", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IDictionary<object, object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications)
		{
			throw null;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00017312 File Offset: 0x00015512
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		[global::Cpp2ILInjected.Token(Token = "0x600118A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A96C", Offset = "0x1C9A96C", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "SetExecutionContext", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(ExecutionContextSwitcher))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "FailFast", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
		{
			throw null;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00017315 File Offset: 0x00015515
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00017318 File Offset: 0x00015518
		[global::Cpp2ILInjected.Token(Token = "0x170001A5")]
		internal global::System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x600118B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B1A0", Offset = "0x1C9B1A0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext.Reader), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext.Reader))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new object[]
			{
				typeof(ref StackCrawlMark),
				typeof(ExecutionContext.CaptureOptions)
			}, ReturnType = typeof(ExecutionContext))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600118C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B204", Offset = "0x1C9B204", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0001731B File Offset: 0x0001551B
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x0001731E File Offset: 0x0001551E
		[global::Cpp2ILInjected.Token(Token = "0x170001A6")]
		internal global::System.Runtime.Remoting.Messaging.IllogicalCallContext IllogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x600118D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B20C", Offset = "0x1C9B20C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CallContext), Member = "LogicalSetData", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.IllogicalCallContext), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600118E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B270", Offset = "0x1C9B270", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x00017321 File Offset: 0x00015521
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x00017324 File Offset: 0x00015524
		[global::Cpp2ILInjected.Token(Token = "0x170001A7")]
		internal SynchronizationContext SynchronizationContext
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x600118F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B278", Offset = "0x1C9B278", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6001190")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B280", Offset = "0x1C9B280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x00017327 File Offset: 0x00015527
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0001732A File Offset: 0x0001552A
		[global::Cpp2ILInjected.Token(Token = "0x170001A8")]
		internal SynchronizationContext SynchronizationContextNoFlow
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6001191")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B288", Offset = "0x1C9B288", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6001192")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B290", Offset = "0x1C9B290", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0001732D File Offset: 0x0001552D
		[global::Cpp2ILInjected.Token(Token = "0x6001193")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B298", Offset = "0x1C9B298", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00017330 File Offset: 0x00015530
		[global::Cpp2ILInjected.Token(Token = "0x6001194")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97DD4", Offset = "0x1C97DD4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationCallbackInfo), Member = "ExecuteCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadHelper), Member = "ThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadHelper), Member = "ThreadStart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.AwaitTaskContinuation), Member = "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ContextAwareResult", Member = "Complete", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate),
			"System.Security.Cryptography.X509Certificates.X509Chain",
			"System.Net.Security.SslPolicyErrors"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new object[] { "System.Net.Sockets.SocketAsyncEventArgs" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void Run(ExecutionContext executionContext, ContextCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00017333 File Offset: 0x00015533
		[global::System.Runtime.CompilerServices.FriendAccessAllowed]
		[global::Cpp2ILInjected.Token(Token = "0x6001195")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B29C", Offset = "0x1C9B29C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "ExecuteWithThreadLocal", MemberParameters = new object[] { typeof(ref global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
		{
			throw null;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00017336 File Offset: 0x00015536
		[global::Cpp2ILInjected.Token(Token = "0x6001196")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B4F8", Offset = "0x1C9B4F8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.ReadWriteTask", Member = "System.Threading.Tasks.ITaskCompletionAction.Invoke", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00017339 File Offset: 0x00015539
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		[global::Cpp2ILInjected.Token(Token = "0x6001197")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B318", Offset = "0x1C9B318", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "IsDefaultFTContext", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "SetExecutionContext", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(ExecutionContextSwitcher))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
		{
			throw null;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0001733C File Offset: 0x0001553C
		[global::Cpp2ILInjected.Token(Token = "0x6001198")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B77C", Offset = "0x1C9B77C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new object[] { "TStateMachine" }, MemberParameters = new object[] { "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new object[] { "TStateMachine" }, MemberParameters = new object[] { "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), Member = "Start", MemberTypeParameters = new object[] { "TStateMachine" }, MemberParameters = new object[] { "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
		{
			throw null;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0001733F File Offset: 0x0001553F
		[global::Cpp2ILInjected.Token(Token = "0x6001199")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B5FC", Offset = "0x1C9B5FC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
		{
			throw null;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00017342 File Offset: 0x00015542
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		[global::Cpp2ILInjected.Token(Token = "0x600119A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B620", Offset = "0x1C9B620", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "OnAsyncLocalContextChanged", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ExecutionContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContextSwitcher), Member = "UndoNoThrow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		[MethodImpl(8)]
		internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
		{
			throw null;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00017345 File Offset: 0x00015545
		[global::Cpp2ILInjected.Token(Token = "0x600119B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B85C", Offset = "0x1C9B85C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate),
			"System.Security.Cryptography.X509Certificates.X509Chain",
			"System.Net.Security.SslPolicyErrors"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public ExecutionContext CreateCopy()
		{
			throw null;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00017348 File Offset: 0x00015548
		[global::Cpp2ILInjected.Token(Token = "0x600119C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B988", Offset = "0x1C9B988", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "get_IllogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IllogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.IllogicalCallContext), Member = "CreateCopy", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IllogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal ExecutionContext CreateMutableCopy()
		{
			throw null;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0001734B File Offset: 0x0001554B
		[global::Cpp2ILInjected.Token(Token = "0x600119D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BA70", Offset = "0x1C9BA70", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(bool),
			typeof(ref StackCrawlMark)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "GetRequestStreamAsync", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "GetResponseAsync", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		public static bool IsFlowSuppressed()
		{
			throw null;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0001734E File Offset: 0x0001554E
		[global::Cpp2ILInjected.Token(Token = "0x600119E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94954", Offset = "0x1C94954", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "TaskConstructorCore", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(object),
			typeof(CancellationToken),
			typeof(global::System.Threading.Tasks.TaskCreationOptions),
			typeof(global::System.Threading.Tasks.InternalTaskOptions),
			typeof(global::System.Threading.Tasks.TaskScheduler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.AwaitTaskContinuation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.ReadWriteTask", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(global::System.Func<object, int>),
			typeof(object),
			typeof(global::System.IO.Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ContextAwareResult", Member = "CaptureOrComplete", MemberParameters = new object[]
		{
			typeof(ref ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = ".ctor", MemberParameters = new object[] { "System.Net.Security.RemoteCertificateValidationCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new object[]
		{
			"System.Action`1<Object>",
			typeof(object),
			typeof(short),
			typeof(global::System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new object[]
		{
			typeof(ref StackCrawlMark),
			typeof(ExecutionContext.CaptureOptions)
		}, ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		public static ExecutionContext Capture()
		{
			throw null;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00017351 File Offset: 0x00015551
		[global::System.Runtime.CompilerServices.FriendAccessAllowed]
		[global::Cpp2ILInjected.Token(Token = "0x600119F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BBFC", Offset = "0x1C9BBFC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(ref global::System.Runtime.CompilerServices.AsyncMethodBuilderCore.MoveNextRunner)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new object[]
		{
			typeof(ref StackCrawlMark),
			typeof(ExecutionContext.CaptureOptions)
		}, ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		internal static ExecutionContext FastCapture()
		{
			throw null;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00017354 File Offset: 0x00015554
		[global::Cpp2ILInjected.Token(Token = "0x60011A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BA98", Offset = "0x1C9BA98", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "FastCapture", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "Start", MemberParameters = new object[] { typeof(ref StackCrawlMark) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(bool),
			typeof(ref StackCrawlMark)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext.Reader), Member = "get_HasInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext.Reader), Member = "Clone", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options)
		{
			throw null;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00017357 File Offset: 0x00015557
		[global::Cpp2ILInjected.Token(Token = "0x60011A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BC64", Offset = "0x1C9BC64", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0001735A File Offset: 0x0001555A
		[global::Cpp2ILInjected.Token(Token = "0x60011A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BD70", Offset = "0x1C9BD70", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private ExecutionContext(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0001735D File Offset: 0x0001555D
		[global::Cpp2ILInjected.Token(Token = "0x60011A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9B584", Offset = "0x1C9B584", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.IllogicalCallContext), Member = "get_HasUserData", ReturnType = typeof(bool))]
		internal bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			throw null;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00017360 File Offset: 0x00015560
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60011A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9BE60", Offset = "0x1C9BE60", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ExecutionContext()
		{
			throw null;
		}

		// Token: 0x0400075E RID: 1886
		[global::Cpp2ILInjected.Token(Token = "0x400097A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SynchronizationContext _syncContext;

		// Token: 0x0400075F RID: 1887
		[global::Cpp2ILInjected.Token(Token = "0x400097B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SynchronizationContext _syncContextNoFlow;

		// Token: 0x04000760 RID: 1888
		[global::Cpp2ILInjected.Token(Token = "0x400097C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Runtime.Remoting.Messaging.LogicalCallContext _logicalCallContext;

		// Token: 0x04000761 RID: 1889
		[global::Cpp2ILInjected.Token(Token = "0x400097D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Runtime.Remoting.Messaging.IllogicalCallContext _illogicalCallContext;

		// Token: 0x04000762 RID: 1890
		[global::Cpp2ILInjected.Token(Token = "0x400097E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ExecutionContext.Flags _flags;

		// Token: 0x04000763 RID: 1891
		[global::Cpp2ILInjected.Token(Token = "0x400097F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Collections.Generic.Dictionary<IAsyncLocal, object> _localValues;

		// Token: 0x04000764 RID: 1892
		[global::Cpp2ILInjected.Token(Token = "0x4000980")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Collections.Generic.List<IAsyncLocal> _localChangeNotifications;

		// Token: 0x04000765 RID: 1893
		[global::Cpp2ILInjected.Token(Token = "0x4000981")]
		private static readonly ExecutionContext s_dummyDefaultEC;

		// Token: 0x04000766 RID: 1894
		[global::Cpp2ILInjected.Token(Token = "0x4000982")]
		internal static readonly ExecutionContext Default;

		// Token: 0x020005AC RID: 1452
		[global::Cpp2ILInjected.Token(Token = "0x20001ED")]
		private enum Flags
		{
			// Token: 0x040018A7 RID: 6311
			[global::Cpp2ILInjected.Token(Token = "0x4000984")]
			None,
			// Token: 0x040018A8 RID: 6312
			[global::Cpp2ILInjected.Token(Token = "0x4000985")]
			IsNewCapture,
			// Token: 0x040018A9 RID: 6313
			[global::Cpp2ILInjected.Token(Token = "0x4000986")]
			IsFlowSuppressed,
			// Token: 0x040018AA RID: 6314
			[global::Cpp2ILInjected.Token(Token = "0x4000987")]
			IsPreAllocatedDefault = 4
		}

		// Token: 0x020005AD RID: 1453
		[global::Cpp2ILInjected.Token(Token = "0x20001EE")]
		internal struct Reader
		{
			// Token: 0x06004026 RID: 16422 RVA: 0x0001FB29 File Offset: 0x0001DD29
			[global::Cpp2ILInjected.Token(Token = "0x60011A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9BEE4", Offset = "0x1C9BEE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public Reader(ExecutionContext ec)
			{
				throw null;
			}

			// Token: 0x06004027 RID: 16423 RVA: 0x0001FB2C File Offset: 0x0001DD2C
			[global::Cpp2ILInjected.Token(Token = "0x60011A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9BEEC", Offset = "0x1C9BEEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public ExecutionContext DangerousGetRawExecutionContext()
			{
				throw null;
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06004028 RID: 16424 RVA: 0x0001FB2F File Offset: 0x0001DD2F
			[global::Cpp2ILInjected.Token(Token = "0x170001A9")]
			public bool IsNull
			{
				[global::Cpp2ILInjected.Token(Token = "0x60011A7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C9B568", Offset = "0x1C9B568", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004029 RID: 16425 RVA: 0x0001FB32 File Offset: 0x0001DD32
			[global::Cpp2ILInjected.Token(Token = "0x60011A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B578", Offset = "0x1C9B578", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool IsDefaultFTContext(bool ignoreSyncCtx)
			{
				throw null;
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x0600402A RID: 16426 RVA: 0x0001FB35 File Offset: 0x0001DD35
			[global::Cpp2ILInjected.Token(Token = "0x170001AA")]
			public bool IsFlowSuppressed
			{
				[global::Cpp2ILInjected.Token(Token = "0x60011A9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C9BEF4", Offset = "0x1C9BEF4", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[MethodImpl(256)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x0600402B RID: 16427 RVA: 0x0001FB38 File Offset: 0x0001DD38
			[global::Cpp2ILInjected.Token(Token = "0x170001AB")]
			public SynchronizationContext SynchronizationContext
			{
				[global::Cpp2ILInjected.Token(Token = "0x60011AA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C9B818", Offset = "0x1C9B818", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x0600402C RID: 16428 RVA: 0x0001FB3B File Offset: 0x0001DD3B
			[global::Cpp2ILInjected.Token(Token = "0x170001AC")]
			public SynchronizationContext SynchronizationContextNoFlow
			{
				[global::Cpp2ILInjected.Token(Token = "0x60011AB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C9B830", Offset = "0x1C9B830", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x0600402D RID: 16429 RVA: 0x0001FB3E File Offset: 0x0001DD3E
			[global::Cpp2ILInjected.Token(Token = "0x170001AD")]
			public global::System.Runtime.Remoting.Messaging.LogicalCallContext.Reader LogicalCallContext
			{
				[global::Cpp2ILInjected.Token(Token = "0x60011AC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C9BC4C", Offset = "0x1C9BC4C", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "SerializeCallData", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(byte[]))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CallContext), Member = "LogicalGetData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600402E RID: 16430 RVA: 0x0001FB41 File Offset: 0x0001DD41
			[global::Cpp2ILInjected.Token(Token = "0x60011AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9B5D4", Offset = "0x1C9B5D4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool HasSameLocalValues(ExecutionContext other)
			{
				throw null;
			}

			// Token: 0x040018AB RID: 6315
			[global::Cpp2ILInjected.Token(Token = "0x4000988")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ExecutionContext m_ec;
		}

		// Token: 0x020005AE RID: 1454
		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x20001EF")]
		internal enum CaptureOptions
		{
			// Token: 0x040018AD RID: 6317
			[global::Cpp2ILInjected.Token(Token = "0x400098A")]
			None = 0,
			// Token: 0x040018AE RID: 6318
			[global::Cpp2ILInjected.Token(Token = "0x400098B")]
			IgnoreSyncCtx = 1,
			// Token: 0x040018AF RID: 6319
			[global::Cpp2ILInjected.Token(Token = "0x400098C")]
			OptimizeDefaultCase = 2
		}
	}
}
