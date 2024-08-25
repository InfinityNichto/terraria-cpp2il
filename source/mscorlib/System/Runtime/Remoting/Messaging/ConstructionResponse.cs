using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20003A5")]
	[global::System.Serializable]
	public class ConstructionResponse : MethodResponse, global::System.Runtime.Remoting.Activation.IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001DF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B378EC", Offset = "0x1B378EC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(LogicalCallContext),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(void))]
		internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4227C", Offset = "0x1B4227C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(void))]
		internal ConstructionResponse(global::System.Exception e, IMethodCallMessage msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B49FD4", Offset = "0x1B49FD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal ConstructionResponse(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003AC")]
		public override global::System.Collections.IDictionary Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A044", Offset = "0x1B4A044", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
