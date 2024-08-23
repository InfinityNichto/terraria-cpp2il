using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200031A RID: 794
	[global::Cpp2ILInjected.Token(Token = "0x20003C0")]
	internal class ServerObjectReplySink : IMessageSink
	{
		// Token: 0x06001C79 RID: 7289 RVA: 0x000194AB File Offset: 0x000176AB
		[global::Cpp2ILInjected.Token(Token = "0x6001EB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4FFC8", Offset = "0x1B4FFC8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x000194AE File Offset: 0x000176AE
		[global::Cpp2ILInjected.Token(Token = "0x6001EB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4FFF4", Offset = "0x1B4FFF4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Identity), Member = "NotifyServerDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x000194B1 File Offset: 0x000176B1
		[global::Cpp2ILInjected.Token(Token = "0x6001EB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B500B8", Offset = "0x1B500B8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x04000C80 RID: 3200
		[global::Cpp2ILInjected.Token(Token = "0x4000F6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IMessageSink _replySink;

		// Token: 0x04000C81 RID: 3201
		[global::Cpp2ILInjected.Token(Token = "0x4000F70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ServerIdentity _identity;
	}
}
