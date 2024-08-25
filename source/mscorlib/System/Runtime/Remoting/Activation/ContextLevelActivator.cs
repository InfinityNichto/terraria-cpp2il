using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Activation
{
	[global::Cpp2ILInjected.Token(Token = "0x2000387")]
	[global::System.Serializable]
	internal class ContextLevelActivator : IActivator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41874", Offset = "0x1B41874", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ContextLevelActivator(IActivator next)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700037A")]
		public IActivator NextActivator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4236C", Offset = "0x1B4236C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42374", Offset = "0x1B42374", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "CreateContextBoundObjectIdentity", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(ClientActivatedIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "SetMessageTargetIdentity", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(Identity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "CreateNewContext", MemberParameters = new object[] { typeof(IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalSetContext", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Contexts.Context) }, ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000ECC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IActivator m_NextActivator;
	}
}
