using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Channels
{
	[global::Cpp2ILInjected.Token(Token = "0x2000377")]
	[global::System.Serializable]
	internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40044", Offset = "0x1B40044", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "RegisterInternalChannels", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new object[] { typeof(IChannel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void RegisterCrossAppDomainChannel()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036B")]
		public virtual string ChannelName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B40184", Offset = "0x1B40184", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036C")]
		public virtual int ChannelPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B401C4", Offset = "0x1B401C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036D")]
		public virtual object ChannelData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B401CC", Offset = "0x1B401CC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetDomainID", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrossAppDomainData), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40230", Offset = "0x1B40230", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void StartListening(object data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40234", Offset = "0x1B40234", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "get_ProcessId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual global::System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object data, out string uri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4017C", Offset = "0x1B4017C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CrossAppDomainChannel()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001D34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40624", Offset = "0x1B40624", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static CrossAppDomainChannel()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000EBE")]
		private static object s_lock;
	}
}
