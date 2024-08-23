using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020002E0 RID: 736
	[global::Cpp2ILInjected.Token(Token = "0x2000384")]
	internal class ActivationServices
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x00019106 File Offset: 0x00017306
		[global::Cpp2ILInjected.Token(Token = "0x17000377")]
		private static IActivator ConstructionActivator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B41600", Offset = "0x1B41600", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00019109 File Offset: 0x00017309
		[global::Cpp2ILInjected.Token(Token = "0x6001D50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B37C4C", Offset = "0x1B37C4C", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "ActivateRemoteObject", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMethodMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActivationServices), Member = "RemoteActivate", MemberParameters = new object[] { typeof(IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "AttachIdentity", MemberParameters = new object[] { typeof(Identity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetClientContextSinkChain", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static global::System.Runtime.Remoting.Messaging.IMessage Activate(global::System.Runtime.Remoting.Proxies.RemotingProxy proxy, global::System.Runtime.Remoting.Messaging.ConstructionCall ctorCall)
		{
			throw null;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0001910C File Offset: 0x0001730C
		[global::Cpp2ILInjected.Token(Token = "0x6001D51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41694", Offset = "0x1B41694", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy),
			typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static global::System.Runtime.Remoting.Messaging.IMessage RemoteActivate(IConstructionCallMessage ctorCall)
		{
			throw null;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0001910F File Offset: 0x0001730F
		[global::Cpp2ILInjected.Token(Token = "0x6001D52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B363F8", Offset = "0x1B363F8", Length = "0x988")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.ProxyAttribute), Member = "CreateInstance", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.MarshalByRefObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActivationServices), Member = "get_ConstructionActivator", ReturnType = typeof(IActivator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		public static global::System.Runtime.Remoting.Messaging.ConstructionCall CreateConstructionCall(global::System.Type type, string activationUrl, object[] activationAttributes)
		{
			throw null;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00019112 File Offset: 0x00017312
		[global::Cpp2ILInjected.Token(Token = "0x6001D53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4189C", Offset = "0x1B4189C", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Runtime.Remoting.Contexts.Context)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "AttachIdentity", MemberParameters = new object[] { typeof(Identity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static global::System.Runtime.Remoting.Messaging.IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
		{
			throw null;
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00019115 File Offset: 0x00017315
		[global::Cpp2ILInjected.Token(Token = "0x6001D54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41C88", Offset = "0x1B41C88", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "IsRemotelyActivatedClientType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(ActivatedClientTypeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new object[]
		{
			typeof(ActivatedClientTypeEntry),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "IsWellKnownClientType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(WellKnownClientTypeEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new object[] { typeof(WellKnownClientTypeEntry) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static object CreateProxyForType(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001B28 RID: 6952
		[global::Cpp2ILInjected.Token(Token = "0x6001D55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41C84", Offset = "0x1B41C84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetUninitializedObject", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "nativeGetUninitializedObject", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern object AllocateUninitializedClassInstance(global::System.Type type);

		// Token: 0x06001B29 RID: 6953
		[global::Cpp2ILInjected.Token(Token = "0x6001D56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41DC0", Offset = "0x1B41DC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterActivatedClientType", MemberParameters = new object[] { typeof(ActivatedClientTypeEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownClientType", MemberParameters = new object[] { typeof(WellKnownClientTypeEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void EnableProxyActivation(global::System.Type type, bool enable);

		// Token: 0x04000BDE RID: 3038
		[global::Cpp2ILInjected.Token(Token = "0x4000EC9")]
		private static IActivator _constructionActivator;
	}
}
