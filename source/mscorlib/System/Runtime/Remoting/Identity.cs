using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002A1 RID: 673
	[global::Cpp2ILInjected.Token(Token = "0x200033F")]
	internal abstract class Identity
	{
		// Token: 0x0600199C RID: 6556 RVA: 0x00018CEF File Offset: 0x00016EEF
		[global::Cpp2ILInjected.Token(Token = "0x6001BBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24D50", Offset = "0x1B24D50", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Identity(string objectUri)
		{
			throw null;
		}

		// Token: 0x0600199D RID: 6557
		[global::Cpp2ILInjected.Token(Token = "0x6001BC0")]
		public abstract ObjRef CreateObjRef(global::System.Type requestedType);

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x00018CF2 File Offset: 0x00016EF2
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x00018CF5 File Offset: 0x00016EF5
		[global::Cpp2ILInjected.Token(Token = "0x1700032B")]
		public global::System.Runtime.Remoting.Messaging.IMessageSink ChannelSink
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24D78", Offset = "0x1B24D78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001BC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24D80", Offset = "0x1B24D80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00018CF8 File Offset: 0x00016EF8
		[global::Cpp2ILInjected.Token(Token = "0x1700032C")]
		public global::System.Runtime.Remoting.Messaging.IMessageSink EnvoySink
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24D88", Offset = "0x1B24D88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x00018CFB File Offset: 0x00016EFB
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x00018CFE File Offset: 0x00016EFE
		[global::Cpp2ILInjected.Token(Token = "0x1700032D")]
		public string ObjectUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24D90", Offset = "0x1B24D90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001BC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24D98", Offset = "0x1B24D98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00018D01 File Offset: 0x00016F01
		[global::Cpp2ILInjected.Token(Token = "0x1700032E")]
		public bool IsConnected
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24DA0", Offset = "0x1B24DA0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00018D04 File Offset: 0x00016F04
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x00018D07 File Offset: 0x00016F07
		[global::Cpp2ILInjected.Token(Token = "0x1700032F")]
		public bool Disposed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24DB0", Offset = "0x1B24DB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001BC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24DB8", Offset = "0x1B24DB8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00018D0A File Offset: 0x00016F0A
		[global::Cpp2ILInjected.Token(Token = "0x17000330")]
		public global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection ClientDynamicProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BC9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24DC4", Offset = "0x1B24DC4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetDynamicPropertyCollection", MemberParameters = new object[]
			{
				typeof(global::System.ContextBoundObject),
				typeof(global::System.Runtime.Remoting.Contexts.Context)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x00018D0D File Offset: 0x00016F0D
		[global::Cpp2ILInjected.Token(Token = "0x17000331")]
		public bool HasServerDynamicSinks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BCA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24E28", Offset = "0x1B24E28", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = "get_HasProperties", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00018D10 File Offset: 0x00016F10
		[global::Cpp2ILInjected.Token(Token = "0x6001BCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24E3C", Offset = "0x1B24E3C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = "get_HasProperties", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void NotifyClientDynamicSinks(bool start, global::System.Runtime.Remoting.Messaging.IMessage req_msg, bool client_site, bool async)
		{
			throw null;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00018D13 File Offset: 0x00016F13
		[global::Cpp2ILInjected.Token(Token = "0x6001BCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24EA8", Offset = "0x1B24EA8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerObjectTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ServerObjectReplySink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = "get_HasProperties", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void NotifyServerDynamicSinks(bool start, global::System.Runtime.Remoting.Messaging.IMessage req_msg, bool client_site, bool async)
		{
			throw null;
		}

		// Token: 0x04000B41 RID: 2881
		[global::Cpp2ILInjected.Token(Token = "0x4000E21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected string _objectUri;

		// Token: 0x04000B42 RID: 2882
		[global::Cpp2ILInjected.Token(Token = "0x4000E22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected global::System.Runtime.Remoting.Messaging.IMessageSink _channelSink;

		// Token: 0x04000B43 RID: 2883
		[global::Cpp2ILInjected.Token(Token = "0x4000E23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected global::System.Runtime.Remoting.Messaging.IMessageSink _envoySink;

		// Token: 0x04000B44 RID: 2884
		[global::Cpp2ILInjected.Token(Token = "0x4000E24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection _clientDynamicProperties;

		// Token: 0x04000B45 RID: 2885
		[global::Cpp2ILInjected.Token(Token = "0x4000E25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection _serverDynamicProperties;

		// Token: 0x04000B46 RID: 2886
		[global::Cpp2ILInjected.Token(Token = "0x4000E26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected ObjRef _objRef;

		// Token: 0x04000B47 RID: 2887
		[global::Cpp2ILInjected.Token(Token = "0x4000E27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _disposed;
	}
}
