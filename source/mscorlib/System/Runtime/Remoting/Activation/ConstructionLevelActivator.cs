using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020002E2 RID: 738
	[global::Cpp2ILInjected.Token(Token = "0x2000386")]
	[global::System.Serializable]
	internal class ConstructionLevelActivator : IActivator
	{
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x00019121 File Offset: 0x00017321
		[global::Cpp2ILInjected.Token(Token = "0x17000379")]
		public IActivator NextActivator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B42280", Offset = "0x1B42280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00019124 File Offset: 0x00017324
		[global::Cpp2ILInjected.Token(Token = "0x6001D5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42288", Offset = "0x1B42288", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetServerContextSinkChain", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			throw null;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00019127 File Offset: 0x00017327
		[global::Cpp2ILInjected.Token(Token = "0x6001D5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4168C", Offset = "0x1B4168C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ConstructionLevelActivator()
		{
			throw null;
		}
	}
}
