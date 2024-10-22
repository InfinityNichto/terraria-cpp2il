﻿using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Activation
{
	[global::Cpp2ILInjected.Token(Token = "0x2000386")]
	[global::System.Serializable]
	internal class ConstructionLevelActivator : IActivator
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000379")]
		public IActivator NextActivator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B42280", Offset = "0x1B42280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42288", Offset = "0x1B42288", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetServerContextSinkChain", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4168C", Offset = "0x1B4168C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ConstructionLevelActivator()
		{
			throw null;
		}
	}
}
