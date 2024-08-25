using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	[global::Cpp2ILInjected.Token(Token = "0x200033B")]
	[global::System.Serializable]
	internal class EnvoyInfo : IEnvoyInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24D20", Offset = "0x1B24D20", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EnvoyInfo(global::System.Runtime.Remoting.Messaging.IMessageSink sinks)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000327")]
		public global::System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24D48", Offset = "0x1B24D48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Runtime.Remoting.Messaging.IMessageSink envoySinks;
	}
}
