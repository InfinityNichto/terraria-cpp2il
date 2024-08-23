using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002EE RID: 750
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000392")]
	[global::System.Serializable]
	public sealed class CallContext
	{
		// Token: 0x06001B56 RID: 6998 RVA: 0x00019184 File Offset: 0x00017384
		[global::Cpp2ILInjected.Token(Token = "0x6001D83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B433C4", Offset = "0x1B433C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private CallContext()
		{
			throw null;
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00019187 File Offset: 0x00017387
		[global::Cpp2ILInjected.Token(Token = "0x6001D84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B433CC", Offset = "0x1B433CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static object SetCurrentCallContext(LogicalCallContext ctx)
		{
			throw null;
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0001918A File Offset: 0x0001738A
		[global::Cpp2ILInjected.Token(Token = "0x6001D85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B433D4", Offset = "0x1B433D4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(IMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
		internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
		{
			throw null;
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0001918D File Offset: 0x0001738D
		[global::Cpp2ILInjected.Token(Token = "0x6001D86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4340C", Offset = "0x1B4340C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "GetLogicalOperationStack", ReturnType = typeof(global::System.Collections.Stack))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetExecutionContextReader", ReturnType = typeof(global::System.Threading.ExecutionContext.Reader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext.Reader), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext.Reader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		public static object LogicalGetData(string name)
		{
			throw null;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00019190 File Offset: 0x00017390
		[global::Cpp2ILInjected.Token(Token = "0x6001D87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B43494", Offset = "0x1B43494", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "GetLogicalOperationStack", ReturnType = typeof(global::System.Collections.Stack))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_IllogicalCallContext", ReturnType = typeof(IllogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IllogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "SetData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		public static void LogicalSetData(string name, object data)
		{
			throw null;
		}
	}
}
