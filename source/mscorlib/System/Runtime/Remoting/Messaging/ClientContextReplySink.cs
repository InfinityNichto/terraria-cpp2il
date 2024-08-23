using System;
using System.Runtime.Remoting.Contexts;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002FD RID: 765
	[global::Cpp2ILInjected.Token(Token = "0x20003A2")]
	internal class ClientContextReplySink : IMessageSink
	{
		// Token: 0x06001BAC RID: 7084 RVA: 0x00019283 File Offset: 0x00017483
		[global::Cpp2ILInjected.Token(Token = "0x6001DDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47CD8", Offset = "0x1B47CD8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ClientContextReplySink(global::System.Runtime.Remoting.Contexts.Context ctx, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00019286 File Offset: 0x00017486
		[global::Cpp2ILInjected.Token(Token = "0x6001DDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47D04", Offset = "0x1B47D04", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "NotifyDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00019289 File Offset: 0x00017489
		[global::Cpp2ILInjected.Token(Token = "0x6001DE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47DFC", Offset = "0x1B47DFC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x04000C2B RID: 3115
		[global::Cpp2ILInjected.Token(Token = "0x4000F17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IMessageSink _replySink;

		// Token: 0x04000C2C RID: 3116
		[global::Cpp2ILInjected.Token(Token = "0x4000F18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Runtime.Remoting.Contexts.Context _context;
	}
}
