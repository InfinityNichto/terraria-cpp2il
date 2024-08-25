using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C8")]
	public class CorrelationManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000494")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC49DC", Offset = "0x1EC49DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CorrelationManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000C6")]
		public Stack LogicalOperationStack
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000495")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC49E4", Offset = "0x1EC49E4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000496")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC49E8", Offset = "0x1EC49E8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceEventCache), Member = "get_LogicalOperationStack", ReturnType = typeof(Stack))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new object[] { typeof(TraceEventCache) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Stack GetLogicalOperationStack()
		{
			throw null;
		}
	}
}
