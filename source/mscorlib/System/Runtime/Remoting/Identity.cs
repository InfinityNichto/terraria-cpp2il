using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	[global::Cpp2ILInjected.Token(Token = "0x200033F")]
	internal abstract class Identity
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001BBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24D50", Offset = "0x1B24D50", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Identity(string objectUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BC0")]
		public abstract ObjRef CreateObjRef(global::System.Type requestedType);

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

		[global::Cpp2ILInjected.Token(Token = "0x4000E21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected string _objectUri;

		[global::Cpp2ILInjected.Token(Token = "0x4000E22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected global::System.Runtime.Remoting.Messaging.IMessageSink _channelSink;

		[global::Cpp2ILInjected.Token(Token = "0x4000E23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected global::System.Runtime.Remoting.Messaging.IMessageSink _envoySink;

		[global::Cpp2ILInjected.Token(Token = "0x4000E24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection _clientDynamicProperties;

		[global::Cpp2ILInjected.Token(Token = "0x4000E25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection _serverDynamicProperties;

		[global::Cpp2ILInjected.Token(Token = "0x4000E26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected ObjRef _objRef;

		[global::Cpp2ILInjected.Token(Token = "0x4000E27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _disposed;
	}
}
