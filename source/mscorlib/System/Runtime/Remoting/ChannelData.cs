using System;
using System.Collections;
using System.Runtime.Remoting.Channels;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x020002A7 RID: 679
	[global::Cpp2ILInjected.Token(Token = "0x2000345")]
	internal class ChannelData
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x00018DE5 File Offset: 0x00016FE5
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00018DE8 File Offset: 0x00016FE8
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

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x00018DEB File Offset: 0x00016FEB
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

		// Token: 0x060019F2 RID: 6642 RVA: 0x00018DEE File Offset: 0x00016FEE
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

		// Token: 0x060019F3 RID: 6643 RVA: 0x00018DF1 File Offset: 0x00016FF1
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

		// Token: 0x04000B67 RID: 2919
		[global::Cpp2ILInjected.Token(Token = "0x4000E47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string Ref;

		// Token: 0x04000B68 RID: 2920
		[global::Cpp2ILInjected.Token(Token = "0x4000E48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string Type;

		// Token: 0x04000B69 RID: 2921
		[global::Cpp2ILInjected.Token(Token = "0x4000E49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string Id;

		// Token: 0x04000B6A RID: 2922
		[global::Cpp2ILInjected.Token(Token = "0x4000E4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string DelayLoadAsClientChannel;

		// Token: 0x04000B6B RID: 2923
		[global::Cpp2ILInjected.Token(Token = "0x4000E4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Collections.ArrayList _serverProviders;

		// Token: 0x04000B6C RID: 2924
		[global::Cpp2ILInjected.Token(Token = "0x4000E4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Collections.ArrayList _clientProviders;

		// Token: 0x04000B6D RID: 2925
		[global::Cpp2ILInjected.Token(Token = "0x4000E4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Collections.Hashtable _customProperties;
	}
}
