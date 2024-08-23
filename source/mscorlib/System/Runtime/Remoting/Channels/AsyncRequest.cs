using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020002D7 RID: 727
	[global::Cpp2ILInjected.Token(Token = "0x200037B")]
	internal class AsyncRequest
	{
		// Token: 0x06001B16 RID: 6934 RVA: 0x000190FA File Offset: 0x000172FA
		[global::Cpp2ILInjected.Token(Token = "0x6001D43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B410B0", Offset = "0x1B410B0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AsyncRequest(global::System.Runtime.Remoting.Messaging.IMessage msgRequest, global::System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x04000BD9 RID: 3033
		[global::Cpp2ILInjected.Token(Token = "0x4000EC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.Runtime.Remoting.Messaging.IMessageSink ReplySink;

		// Token: 0x04000BDA RID: 3034
		[global::Cpp2ILInjected.Token(Token = "0x4000EC5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Runtime.Remoting.Messaging.IMessage MsgRequest;
	}
}
