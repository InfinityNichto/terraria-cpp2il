using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x0200029D RID: 669
	[global::Cpp2ILInjected.Token(Token = "0x200033B")]
	[global::System.Serializable]
	internal class EnvoyInfo : IEnvoyInfo
	{
		// Token: 0x06001996 RID: 6550 RVA: 0x00018CE9 File Offset: 0x00016EE9
		[global::Cpp2ILInjected.Token(Token = "0x6001BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24D20", Offset = "0x1B24D20", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EnvoyInfo(global::System.Runtime.Remoting.Messaging.IMessageSink sinks)
		{
			throw null;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00018CEC File Offset: 0x00016EEC
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

		// Token: 0x04000B40 RID: 2880
		[global::Cpp2ILInjected.Token(Token = "0x4000E20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Runtime.Remoting.Messaging.IMessageSink envoySinks;
	}
}
