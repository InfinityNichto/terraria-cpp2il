using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020002E8 RID: 744
	[global::Cpp2ILInjected.Token(Token = "0x200038C")]
	internal class RemoteActivator : global::System.MarshalByRefObject, IActivator
	{
		// Token: 0x06001B3E RID: 6974 RVA: 0x0001913C File Offset: 0x0001733C
		[global::Cpp2ILInjected.Token(Token = "0x6001D6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42A88", Offset = "0x1B42A88", Length = "0x454")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "IsActivationAllowed", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new object[] { typeof(global::System.MarshalByRefObject) }, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			throw null;
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x0001913F File Offset: 0x0001733F
		[global::Cpp2ILInjected.Token(Token = "0x17000381")]
		public IActivator NextActivator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B42EDC", Offset = "0x1B42EDC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}
	}
}
