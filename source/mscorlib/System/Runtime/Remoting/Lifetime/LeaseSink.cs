using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x020002C1 RID: 705
	[global::Cpp2ILInjected.Token(Token = "0x2000362")]
	internal class LeaseSink : global::System.Runtime.Remoting.Messaging.IMessageSink
	{
		// Token: 0x06001AA4 RID: 6820 RVA: 0x00018FD7 File Offset: 0x000171D7
		[global::Cpp2ILInjected.Token(Token = "0x6001CCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39410", Offset = "0x1B39410", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LeaseSink(global::System.Runtime.Remoting.Messaging.IMessageSink nextSink)
		{
			throw null;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00018FDA File Offset: 0x000171DA
		[global::Cpp2ILInjected.Token(Token = "0x6001CCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39438", Offset = "0x1B39438", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeaseSink), Member = "RenewLease", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public global::System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00018FDD File Offset: 0x000171DD
		[global::Cpp2ILInjected.Token(Token = "0x6001CCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39774", Offset = "0x1B39774", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeaseSink), Member = "RenewLease", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public global::System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg, global::System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			throw null;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00018FE0 File Offset: 0x000171E0
		[global::Cpp2ILInjected.Token(Token = "0x6001CD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B394E8", Offset = "0x1B394E8", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LeaseSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LeaseSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void RenewLease(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		// Token: 0x04000BB1 RID: 2993
		[global::Cpp2ILInjected.Token(Token = "0x4000E95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Runtime.Remoting.Messaging.IMessageSink _nextSink;
	}
}
