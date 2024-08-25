using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	[global::Cpp2ILInjected.Token(Token = "0x2000346")]
	internal class ProviderData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B28B40", Offset = "0x1B28B40", Length = "0x69C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new object[]
		{
			typeof(global::System.Collections.ArrayList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public void CopyFrom(ProviderData other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CB70", Offset = "0x1B2CB70", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(ProviderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ProviderData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string Ref;

		[global::Cpp2ILInjected.Token(Token = "0x4000E4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string Type;

		[global::Cpp2ILInjected.Token(Token = "0x4000E50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string Id;

		[global::Cpp2ILInjected.Token(Token = "0x4000E51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal global::System.Collections.Hashtable CustomProperties;

		[global::Cpp2ILInjected.Token(Token = "0x4000E52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal global::System.Collections.IList CustomData;
	}
}
