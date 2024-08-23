using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002AE RID: 686
	[global::Cpp2ILInjected.Token(Token = "0x200034D")]
	internal class SingletonIdentity : ServerIdentity
	{
		// Token: 0x06001A37 RID: 6711 RVA: 0x00018EB1 File Offset: 0x000170B1
		[global::Cpp2ILInjected.Token(Token = "0x6001C5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3119C", Offset = "0x1B3119C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateWellKnownServerIdentity", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(WellKnownObjectMode)
		}, ReturnType = typeof(ServerIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Runtime.Remoting.Contexts.Context),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		public SingletonIdentity(string objectUri, global::System.Runtime.Remoting.Contexts.Context context, global::System.Type objectType)
		{
			throw null;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00018EB4 File Offset: 0x000170B4
		[global::Cpp2ILInjected.Token(Token = "0x6001C5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B311A4", Offset = "0x1B311A4", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingletonIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingletonIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalGetDefaultContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = "StartTrackingLifetime", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Lifetime.ILease) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public global::System.MarshalByRefObject GetServerObject()
		{
			throw null;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00018EB7 File Offset: 0x000170B7
		[global::Cpp2ILInjected.Token(Token = "0x6001C5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B313A0", Offset = "0x1B313A0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(global::System.MarshalByRefObject))]
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

		// Token: 0x06001A3A RID: 6714 RVA: 0x00018EBA File Offset: 0x000170BA
		[global::Cpp2ILInjected.Token(Token = "0x6001C5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3146C", Offset = "0x1B3146C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(global::System.MarshalByRefObject))]
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
	}
}
