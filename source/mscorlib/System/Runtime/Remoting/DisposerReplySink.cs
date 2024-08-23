using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002B0 RID: 688
	[global::Cpp2ILInjected.Token(Token = "0x200034F")]
	internal class DisposerReplySink : global::System.Runtime.Remoting.Messaging.IMessageSink
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x00018EC6 File Offset: 0x000170C6
		[global::Cpp2ILInjected.Token(Token = "0x6001C62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31900", Offset = "0x1B31900", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DisposerReplySink(global::System.Runtime.Remoting.Messaging.IMessageSink next, global::System.IDisposable disposable)
		{
			throw null;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00018EC9 File Offset: 0x000170C9
		[global::Cpp2ILInjected.Token(Token = "0x6001C63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3192C", Offset = "0x1B3192C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public global::System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00018ECC File Offset: 0x000170CC
		[global::Cpp2ILInjected.Token(Token = "0x6001C64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31A44", Offset = "0x1B31A44", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public global::System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg, global::System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x04000B81 RID: 2945
		[global::Cpp2ILInjected.Token(Token = "0x4000E63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Runtime.Remoting.Messaging.IMessageSink _next;

		// Token: 0x04000B82 RID: 2946
		[global::Cpp2ILInjected.Token(Token = "0x4000E64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IDisposable _disposable;
	}
}
