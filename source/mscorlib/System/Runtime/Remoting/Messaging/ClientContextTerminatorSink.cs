using System;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002FC RID: 764
	[global::Cpp2ILInjected.Token(Token = "0x20003A1")]
	internal class ClientContextTerminatorSink : IMessageSink
	{
		// Token: 0x06001BA9 RID: 7081 RVA: 0x0001927A File Offset: 0x0001747A
		[global::Cpp2ILInjected.Token(Token = "0x6001DDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3B5F4", Offset = "0x1B3B5F4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ClientContextTerminatorSink(global::System.Runtime.Remoting.Contexts.Context ctx)
		{
			throw null;
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0001927D File Offset: 0x0001747D
		[global::Cpp2ILInjected.Token(Token = "0x6001DDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B478D4", Offset = "0x1B478D4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "NotifyDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "RemoteActivate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00019280 File Offset: 0x00017480
		[global::Cpp2ILInjected.Token(Token = "0x6001DDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47A98", Offset = "0x1B47A98", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "get_HasGlobalDynamicSinks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "NotifyDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x04000C2A RID: 3114
		[global::Cpp2ILInjected.Token(Token = "0x4000F16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Runtime.Remoting.Contexts.Context _context;
	}
}
