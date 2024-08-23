using System;
using System.Runtime.Remoting.Activation;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000318 RID: 792
	[global::Cpp2ILInjected.Token(Token = "0x20003BE")]
	internal class ServerContextTerminatorSink : IMessageSink
	{
		// Token: 0x06001C73 RID: 7283 RVA: 0x00019499 File Offset: 0x00017699
		[global::Cpp2ILInjected.Token(Token = "0x6001EAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4EAB4", Offset = "0x1B4EAB4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0001949C File Offset: 0x0001769C
		[global::Cpp2ILInjected.Token(Token = "0x6001EAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4EBB4", Offset = "0x1B4EBB4", Length = "0x10B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0001949F File Offset: 0x0001769F
		[global::Cpp2ILInjected.Token(Token = "0x6001EAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B5EC", Offset = "0x1B3B5EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ServerContextTerminatorSink()
		{
			throw null;
		}
	}
}
