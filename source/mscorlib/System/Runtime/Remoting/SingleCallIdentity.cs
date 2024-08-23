using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002AF RID: 687
	[global::Cpp2ILInjected.Token(Token = "0x200034E")]
	internal class SingleCallIdentity : ServerIdentity
	{
		// Token: 0x06001A3B RID: 6715 RVA: 0x00018EBD File Offset: 0x000170BD
		[global::Cpp2ILInjected.Token(Token = "0x6001C5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31544", Offset = "0x1B31544", Length = "0x8")]
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
		public SingleCallIdentity(string objectUri, global::System.Runtime.Remoting.Contexts.Context context, global::System.Type objectType)
		{
			throw null;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00018EC0 File Offset: 0x000170C0
		[global::Cpp2ILInjected.Token(Token = "0x6001C60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3154C", Offset = "0x1B3154C", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = "get_ObjectIdentity", ReturnType = typeof(ServerIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = "set_ObjectIdentity", MemberParameters = new object[] { typeof(ServerIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "CreateServerObjectSinkChain", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override global::System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00018EC3 File Offset: 0x000170C3
		[global::Cpp2ILInjected.Token(Token = "0x6001C61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31750", Offset = "0x1B31750", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "CreateServerObjectSinkChain", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(bool)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override global::System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg, global::System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			throw null;
		}
	}
}
