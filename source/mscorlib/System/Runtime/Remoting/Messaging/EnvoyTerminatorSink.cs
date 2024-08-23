using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000301 RID: 769
	[global::Cpp2ILInjected.Token(Token = "0x20003A6")]
	[global::System.Serializable]
	internal class EnvoyTerminatorSink : IMessageSink
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x000192D7 File Offset: 0x000174D7
		[global::Cpp2ILInjected.Token(Token = "0x6001DFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4A0D4", Offset = "0x1B4A0D4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000192DA File Offset: 0x000174DA
		[global::Cpp2ILInjected.Token(Token = "0x6001DFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4A17C", Offset = "0x1B4A17C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000192DD File Offset: 0x000174DD
		[global::Cpp2ILInjected.Token(Token = "0x6001DFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4A238", Offset = "0x1B4A238", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EnvoyTerminatorSink()
		{
			throw null;
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x000192E0 File Offset: 0x000174E0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001DFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4A240", Offset = "0x1B4A240", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static EnvoyTerminatorSink()
		{
			throw null;
		}

		// Token: 0x04000C35 RID: 3125
		[global::Cpp2ILInjected.Token(Token = "0x4000F21")]
		public static EnvoyTerminatorSink Instance;
	}
}
