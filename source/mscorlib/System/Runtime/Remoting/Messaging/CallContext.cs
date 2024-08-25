using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000392")]
	[global::System.Serializable]
	public sealed class CallContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B433C4", Offset = "0x1B433C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private CallContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B433CC", Offset = "0x1B433CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static object SetCurrentCallContext(LogicalCallContext ctx)
		{
			throw null;
		}

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
