using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200010F RID: 271
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000147")]
	[global::System.Serializable]
	public abstract class ContextBoundObject : global::System.MarshalByRefObject
	{
		// Token: 0x06000C2E RID: 3118 RVA: 0x00016856 File Offset: 0x00014A56
		[global::Cpp2ILInjected.Token(Token = "0x6000CFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C608AC", Offset = "0x1C608AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "DoCallBack", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Contexts.CrossContextDelegate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.ContextCallbackObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected ContextBoundObject()
		{
			throw null;
		}
	}
}
