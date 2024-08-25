using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Contexts
{
	[global::Cpp2ILInjected.Token(Token = "0x2000369")]
	internal class CrossContextChannel : global::System.Runtime.Remoting.Messaging.IMessageSink
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3C6A4", Offset = "0x1B3C6A4", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalSetContext", MemberParameters = new object[] { typeof(Context) }, ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "NotifyDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "GetServerContextSinkChain", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public global::System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3CA58", Offset = "0x1B3CA58", Length = "0x420")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalSetContext", MemberParameters = new object[] { typeof(Context) }, ReturnType = typeof(Context))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "NotifyDynamicSinks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public global::System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg, global::System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3CEB4", Offset = "0x1B3CEB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CrossContextChannel()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200036A")]
		private class ContextRestoreSink : global::System.Runtime.Remoting.Messaging.IMessageSink
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3CE78", Offset = "0x1B3CE78", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ContextRestoreSink(global::System.Runtime.Remoting.Messaging.IMessageSink next, Context context, global::System.Runtime.Remoting.Messaging.IMessage call)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3CEBC", Offset = "0x1B3CEBC", Length = "0x2A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(Context))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Context), Member = "NotifyDynamicSinks", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "InternalSetContext", MemberParameters = new object[] { typeof(Context) }, ReturnType = typeof(Context))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Exception),
				typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
			public global::System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3D160", Offset = "0x1B3D160", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public global::System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(global::System.Runtime.Remoting.Messaging.IMessage msg, global::System.Runtime.Remoting.Messaging.IMessageSink replySink)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000EB3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.Runtime.Remoting.Messaging.IMessageSink _next;

			[global::Cpp2ILInjected.Token(Token = "0x4000EB4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Context _context;

			[global::Cpp2ILInjected.Token(Token = "0x4000EB5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private global::System.Runtime.Remoting.Messaging.IMessage _call;
		}
	}
}
