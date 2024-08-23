﻿using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020002E1 RID: 737
	[global::Cpp2ILInjected.Token(Token = "0x2000385")]
	internal class AppDomainLevelActivator : IActivator
	{
		// Token: 0x06001B2A RID: 6954 RVA: 0x00019118 File Offset: 0x00017318
		[global::Cpp2ILInjected.Token(Token = "0x6001D57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41848", Offset = "0x1B41848", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AppDomainLevelActivator(string activationUrl, IActivator next)
		{
			throw null;
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0001911B File Offset: 0x0001731B
		[global::Cpp2ILInjected.Token(Token = "0x17000378")]
		public IActivator NextActivator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D58")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B41DC8", Offset = "0x1B41DC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0001911E File Offset: 0x0001731E
		[global::Cpp2ILInjected.Token(Token = "0x6001D59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41DD0", Offset = "0x1B41DD0", Length = "0x4AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "Connect", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(ClientIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "SetMessageTargetIdentity", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(Identity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			throw null;
		}

		// Token: 0x04000BDF RID: 3039
		[global::Cpp2ILInjected.Token(Token = "0x4000ECA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _activationUrl;

		// Token: 0x04000BE0 RID: 3040
		[global::Cpp2ILInjected.Token(Token = "0x4000ECB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IActivator _next;
	}
}