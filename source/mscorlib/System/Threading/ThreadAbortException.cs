using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000195 RID: 405
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20001FA")]
	[global::System.Serializable]
	public sealed class ThreadAbortException : global::System.SystemException
	{
		// Token: 0x060010D5 RID: 4309 RVA: 0x0001747D File Offset: 0x0001567D
		[global::Cpp2ILInjected.Token(Token = "0x600122E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E158", Offset = "0x1C9E158", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetMessageFromNativeResources", MemberParameters = new object[] { typeof(global::System.Exception.ExceptionMessageKind) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ThreadAbortException()
		{
			throw null;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00017480 File Offset: 0x00015680
		[global::Cpp2ILInjected.Token(Token = "0x600122F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E1D4", Offset = "0x1C9E1D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal ThreadAbortException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
