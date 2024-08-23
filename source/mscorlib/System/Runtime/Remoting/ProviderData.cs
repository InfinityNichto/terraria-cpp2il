using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x020002A8 RID: 680
	[global::Cpp2ILInjected.Token(Token = "0x2000346")]
	internal class ProviderData
	{
		// Token: 0x060019F4 RID: 6644 RVA: 0x00018DF4 File Offset: 0x00016FF4
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

		// Token: 0x060019F5 RID: 6645 RVA: 0x00018DF7 File Offset: 0x00016FF7
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

		// Token: 0x04000B6E RID: 2926
		[global::Cpp2ILInjected.Token(Token = "0x4000E4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string Ref;

		// Token: 0x04000B6F RID: 2927
		[global::Cpp2ILInjected.Token(Token = "0x4000E4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string Type;

		// Token: 0x04000B70 RID: 2928
		[global::Cpp2ILInjected.Token(Token = "0x4000E50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string Id;

		// Token: 0x04000B71 RID: 2929
		[global::Cpp2ILInjected.Token(Token = "0x4000E51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal global::System.Collections.Hashtable CustomProperties;

		// Token: 0x04000B72 RID: 2930
		[global::Cpp2ILInjected.Token(Token = "0x4000E52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal global::System.Collections.IList CustomData;
	}
}
