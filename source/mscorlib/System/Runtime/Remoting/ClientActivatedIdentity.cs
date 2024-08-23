using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002AD RID: 685
	[global::Cpp2ILInjected.Token(Token = "0x200034C")]
	internal class ClientActivatedIdentity : ServerIdentity
	{
		// Token: 0x06001A31 RID: 6705 RVA: 0x00018E9F File Offset: 0x0001709F
		[global::Cpp2ILInjected.Token(Token = "0x6001C55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30DB4", Offset = "0x1B30DB4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateContextBoundObjectIdentity", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(ClientActivatedIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(ClientActivatedIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Runtime.Remoting.Contexts.Context),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		public ClientActivatedIdentity(string objectUri, global::System.Type objectType)
		{
			throw null;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00018EA2 File Offset: 0x000170A2
		[global::Cpp2ILInjected.Token(Token = "0x6001C56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30DC4", Offset = "0x1B30DC4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.MarshalByRefObject GetServerObject()
		{
			throw null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00018EA5 File Offset: 0x000170A5
		[global::Cpp2ILInjected.Token(Token = "0x6001C57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30DCC", Offset = "0x1B30DCC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetClientProxy(global::System.MarshalByRefObject obj)
		{
			throw null;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00018EA8 File Offset: 0x000170A8
		[global::Cpp2ILInjected.Token(Token = "0x6001C58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30DD4", Offset = "0x1B30DD4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = "OnLifetimeExpired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "DisposeIdentity", MemberParameters = new object[] { typeof(Identity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void OnLifetimeExpired()
		{
			throw null;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00018EAB File Offset: 0x000170AB
		[global::Cpp2ILInjected.Token(Token = "0x6001C59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30E38", Offset = "0x1B30E38", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "CreateServerObjectSinkChain", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override global::System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00018EAE File Offset: 0x000170AE
		[global::Cpp2ILInjected.Token(Token = "0x6001C5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B310B8", Offset = "0x1B310B8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "CreateServerObjectSinkChain", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override global::System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg, global::System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x04000B80 RID: 2944
		[global::Cpp2ILInjected.Token(Token = "0x4000E62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.MarshalByRefObject _targetThis;
	}
}
