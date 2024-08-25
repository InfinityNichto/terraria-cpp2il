using System;
using System.Collections;
using System.Runtime.Remoting.Channels;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	[global::Cpp2ILInjected.Token(Token = "0x2000345")]
	internal class ChannelData
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700033C")]
		internal global::System.Collections.ArrayList ServerProviders
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C12")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B28ADC", Offset = "0x1B28ADC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new object[]
			{
				typeof(global::System.Collections.ArrayList),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Mono.Xml.SmallXmlParser.IAttrList)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700033D")]
		public global::System.Collections.ArrayList ClientProviders
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B291DC", Offset = "0x1B291DC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new object[]
			{
				typeof(global::System.Collections.ArrayList),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Mono.Xml.SmallXmlParser.IAttrList)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700033E")]
		public global::System.Collections.Hashtable CustomProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B2CB08", Offset = "0x1B2CB08", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadChannel", MemberParameters = new object[]
			{
				typeof(Mono.Xml.SmallXmlParser.IAttrList),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2824C", Offset = "0x1B2824C", Length = "0x890")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new object[]
		{
			typeof(global::System.Collections.ArrayList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_CustomProperties", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProviderData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProviderData), Member = "CopyFrom", MemberParameters = new object[] { typeof(ProviderData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_ClientProviders", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_ServerProviders", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public void CopyFrom(ChannelData other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CA5C", Offset = "0x1B2CA5C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadChannel", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ChannelData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string Ref;

		[global::Cpp2ILInjected.Token(Token = "0x4000E48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string Type;

		[global::Cpp2ILInjected.Token(Token = "0x4000E49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string Id;

		[global::Cpp2ILInjected.Token(Token = "0x4000E4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string DelayLoadAsClientChannel;

		[global::Cpp2ILInjected.Token(Token = "0x4000E4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Collections.ArrayList _serverProviders;

		[global::Cpp2ILInjected.Token(Token = "0x4000E4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Collections.ArrayList _clientProviders;

		[global::Cpp2ILInjected.Token(Token = "0x4000E4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Collections.Hashtable _customProperties;
	}
}
