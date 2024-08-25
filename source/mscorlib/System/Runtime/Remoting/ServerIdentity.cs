using System;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	[global::Cpp2ILInjected.Token(Token = "0x200034B")]
	internal abstract class ServerIdentity : Identity
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30B34", Offset = "0x1B30B34", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClientActivatedIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingletonIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Runtime.Remoting.Contexts.Context),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingleCallIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Runtime.Remoting.Contexts.Context),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ServerIdentity(string objectUri, global::System.Runtime.Remoting.Contexts.Context context, global::System.Type objectType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700033F")]
		public global::System.Type ObjectType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B30B74", Offset = "0x1B30B74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2E898", Offset = "0x1B2E898", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(ClientActivatedIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(global::System.MarshalByRefObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Lifetime.Lease), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Lifetime.LifetimeServices), Member = "TrackLifetime", MemberParameters = new object[] { typeof(ServerIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void StartTrackingLifetime(global::System.Runtime.Remoting.Lifetime.ILease lease)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30B7C", Offset = "0x1B30B7C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClientActivatedIdentity), Member = "OnLifetimeExpired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual void OnLifetimeExpired()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30C00", Offset = "0x1B30C00", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = "UpdateChannelInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeInfo), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override ObjRef CreateObjRef(global::System.Type requestedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2FFC0", Offset = "0x1B2FFC0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(ClientActivatedIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(global::System.MarshalByRefObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AttachServerObject(global::System.MarshalByRefObject serverObject, global::System.Runtime.Remoting.Contexts.Context context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000340")]
		public global::System.Runtime.Remoting.Lifetime.Lease Lease
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B30D9C", Offset = "0x1B30D9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000341")]
		public global::System.Runtime.Remoting.Contexts.Context Context
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B30DA4", Offset = "0x1B30DA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C51")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B30DAC", Offset = "0x1B30DAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C52")]
		public abstract global::System.Runtime.Remoting.Messaging.IMessage SyncObjectProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg);

		[global::Cpp2ILInjected.Token(Token = "0x6001C53")]
		public abstract global::System.Runtime.Remoting.Messaging.IMessageCtrl AsyncObjectProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg, global::System.Runtime.Remoting.Messaging.IMessageSink replySink);

		[global::Cpp2ILInjected.Token(Token = "0x6001C54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B30B80", Offset = "0x1B30B80", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = "set_ObjectIdentity", MemberParameters = new object[] { typeof(ServerIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Services.TrackingServices), Member = "NotifyDisconnectedObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void DisposeServerObject()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected global::System.Type _objectType;

		[global::Cpp2ILInjected.Token(Token = "0x4000E5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected global::System.MarshalByRefObject _serverObject;

		[global::Cpp2ILInjected.Token(Token = "0x4000E5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected global::System.Runtime.Remoting.Messaging.IMessageSink _serverSink;

		[global::Cpp2ILInjected.Token(Token = "0x4000E60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		protected global::System.Runtime.Remoting.Contexts.Context _context;

		[global::Cpp2ILInjected.Token(Token = "0x4000E61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		protected global::System.Runtime.Remoting.Lifetime.Lease _lease;
	}
}
