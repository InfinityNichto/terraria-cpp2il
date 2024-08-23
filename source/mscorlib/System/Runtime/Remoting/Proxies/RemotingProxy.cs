﻿using System;
using System.Reflection;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x020002BC RID: 700
	[global::Cpp2ILInjected.Token(Token = "0x200035C")]
	internal class RemotingProxy : RealProxy, IRemotingTypeInfo
	{
		// Token: 0x06001A86 RID: 6790 RVA: 0x00018F8C File Offset: 0x0001718C
		[global::Cpp2ILInjected.Token(Token = "0x6001CAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B363BC", Offset = "0x1B363BC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(ClientIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ClientIdentity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClientIdentity), Member = "get_TargetUri", ReturnType = typeof(string))]
		internal RemotingProxy(global::System.Type type, ClientIdentity identity)
		{
			throw null;
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00018F8F File Offset: 0x0001718F
		[global::Cpp2ILInjected.Token(Token = "0x6001CAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33E9C", Offset = "0x1B33E9C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateConstructionCall", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall))]
		internal RemotingProxy(global::System.Type type, string activationUrl, object[] activationAttributes)
		{
			throw null;
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00018F92 File Offset: 0x00017192
		[global::Cpp2ILInjected.Token(Token = "0x6001CAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B36D80", Offset = "0x1B36D80", Length = "0x5A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Identity), Member = "NotifyClientDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetClientContextSinkChain", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = "get_CallType", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.CallType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(int),
			typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override global::System.Runtime.Remoting.Messaging.IMessage Invoke(global::System.Runtime.Remoting.Messaging.IMessage request)
		{
			throw null;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00018F95 File Offset: 0x00017195
		[global::Cpp2ILInjected.Token(Token = "0x6001CAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B376C4", Offset = "0x1B376C4", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "Activate", MemberParameters = new object[]
		{
			typeof(RemotingProxy),
			typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClientIdentity), Member = "set_ClientProxy", MemberParameters = new object[] { typeof(global::System.MarshalByRefObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClientIdentity), Member = "get_TargetUri", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void AttachIdentity(Identity identity)
		{
			throw null;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00018F98 File Offset: 0x00017198
		[global::Cpp2ILInjected.Token(Token = "0x6001CAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B353D4", Offset = "0x1B353D4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(RealProxy),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "CopyFrom", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMethodMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "Activate", MemberParameters = new object[]
		{
			typeof(RemotingProxy),
			typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal global::System.Runtime.Remoting.Messaging.IMessage ActivateRemoteObject(global::System.Runtime.Remoting.Messaging.IMethodMessage request)
		{
			throw null;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00018F9B File Offset: 0x0001719B
		[global::Cpp2ILInjected.Token(Token = "0x17000351")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B37E58", Offset = "0x1B37E58", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00018F9E File Offset: 0x0001719E
		[global::Cpp2ILInjected.Token(Token = "0x6001CB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B37F80", Offset = "0x1B37F80", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = "get_IsReferenceToWellKnow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool CanCastTo(global::System.Type fromType, object o)
		{
			throw null;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00018FA1 File Offset: 0x000171A1
		[global::Cpp2ILInjected.Token(Token = "0x6001CB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B38188", Offset = "0x1B38188", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "DisposeIdentity", MemberParameters = new object[] { typeof(Identity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00018FA4 File Offset: 0x000171A4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001CB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B382A4", Offset = "0x1B382A4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static RemotingProxy()
		{
			throw null;
		}

		// Token: 0x04000BA2 RID: 2978
		[global::Cpp2ILInjected.Token(Token = "0x4000E86")]
		private static global::System.Reflection.MethodInfo _cache_GetTypeMethod;

		// Token: 0x04000BA3 RID: 2979
		[global::Cpp2ILInjected.Token(Token = "0x4000E87")]
		private static global::System.Reflection.MethodInfo _cache_GetHashCodeMethod;

		// Token: 0x04000BA4 RID: 2980
		[global::Cpp2ILInjected.Token(Token = "0x4000E88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.Runtime.Remoting.Messaging.IMessageSink _sink;

		// Token: 0x04000BA5 RID: 2981
		[global::Cpp2ILInjected.Token(Token = "0x4000E89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool _hasEnvoySink;

		// Token: 0x04000BA6 RID: 2982
		[global::Cpp2ILInjected.Token(Token = "0x4000E8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Runtime.Remoting.Messaging.ConstructionCall _ctorCall;
	}
}