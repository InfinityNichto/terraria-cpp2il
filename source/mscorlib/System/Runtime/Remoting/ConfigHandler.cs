using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Lifetime;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x020002A6 RID: 678
	[global::Cpp2ILInjected.Token(Token = "0x2000344")]
	internal class ConfigHandler : Mono.Xml.SmallXmlParser.IContentHandler
	{
		// Token: 0x060019D7 RID: 6615 RVA: 0x00018D9D File Offset: 0x00016F9D
		[global::Cpp2ILInjected.Token(Token = "0x6001BFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2682C", Offset = "0x1B2682C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ConfigHandler(bool onlyDelayedChannels)
		{
			throw null;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00018DA0 File Offset: 0x00016FA0
		[global::Cpp2ILInjected.Token(Token = "0x6001BFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29B80", Offset = "0x1B29B80", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "CheckPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ValidatePath(string element, params string[] paths)
		{
			throw null;
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00018DA3 File Offset: 0x00016FA3
		[global::Cpp2ILInjected.Token(Token = "0x6001BFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29C44", Offset = "0x1B29C44", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ValidatePath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool CheckPath(string path)
		{
			throw null;
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00018DA6 File Offset: 0x00016FA6
		[global::Cpp2ILInjected.Token(Token = "0x6001BFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29D18", Offset = "0x1B29D18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnStartParsing(Mono.Xml.SmallXmlParser parser)
		{
			throw null;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00018DA9 File Offset: 0x00016FA9
		[global::Cpp2ILInjected.Token(Token = "0x6001BFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29D1C", Offset = "0x1B29D1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00018DAC File Offset: 0x00016FAC
		[global::Cpp2ILInjected.Token(Token = "0x6001BFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29D20", Offset = "0x1B29D20", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnIgnorableWhitespace(string s)
		{
			throw null;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00018DAF File Offset: 0x00016FAF
		[global::Cpp2ILInjected.Token(Token = "0x6001C00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29D24", Offset = "0x1B29D24", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void OnStartElement(string name, Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00018DB2 File Offset: 0x00016FB2
		[global::Cpp2ILInjected.Token(Token = "0x6001C01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29EC0", Offset = "0x1B29EC0", Length = "0xF78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "OnStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadCustomProviderData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ValidatePath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "CheckPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadClientWellKnown", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(ProviderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_ServerProviders", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadLifetine", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadInteropXml", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadClientActivated", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadPreload", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadServiceWellKnown", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_ClientProviders", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadChannel", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ReadServiceActivated", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "SetCustomErrorsMode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterServerProviderTemplate", MemberParameters = new object[] { typeof(ProviderData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterClientProviderTemplate", MemberParameters = new object[] { typeof(ProviderData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 81)]
		public void ParseElement(string name, Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00018DB5 File Offset: 0x00016FB5
		[global::Cpp2ILInjected.Token(Token = "0x6001C02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2C628", Offset = "0x1B2C628", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public void OnEndElement(string name)
		{
			throw null;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00018DB8 File Offset: 0x00016FB8
		[global::Cpp2ILInjected.Token(Token = "0x6001C03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2AE40", Offset = "0x1B2AE40", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.SinkProviderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void ReadCustomProviderData(string name, Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00018DBB File Offset: 0x00016FBB
		[global::Cpp2ILInjected.Token(Token = "0x6001C04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2B168", Offset = "0x1B2B168", Length = "0x51C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Lifetime.LifetimeServices), Member = "set_LeaseManagerPollTime", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void ReadLifetine(Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00018DBE File Offset: 0x00016FBE
		[global::Cpp2ILInjected.Token(Token = "0x6001C05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2C698", Offset = "0x1B2C698", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadLifetine", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromHours", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromMinutes", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private global::System.TimeSpan ParseTime(string s)
		{
			throw null;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00018DC1 File Offset: 0x00016FC1
		[global::Cpp2ILInjected.Token(Token = "0x6001C06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2B684", Offset = "0x1B2B684", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_CustomProperties", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterChannelTemplate", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void ReadChannel(Mono.Xml.SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			throw null;
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00018DC4 File Offset: 0x00016FC4
		[global::Cpp2ILInjected.Token(Token = "0x6001C07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2B9E8", Offset = "0x1B2B9E8", Length = "0x3A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProviderData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.SinkProviderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Stack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private ProviderData ReadProvider(string name, Mono.Xml.SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			throw null;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00018DC7 File Offset: 0x00016FC7
		[global::Cpp2ILInjected.Token(Token = "0x6001C08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2C048", Offset = "0x1B2C048", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "GetNotNull", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ExtractAssembly", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActivatedClientTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ReadClientActivated(Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00018DCA File Offset: 0x00016FCA
		[global::Cpp2ILInjected.Token(Token = "0x6001C09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2C17C", Offset = "0x1B2C17C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "GetNotNull", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ExtractAssembly", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActivatedServiceTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ReadServiceActivated(Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00018DCD File Offset: 0x00016FCD
		[global::Cpp2ILInjected.Token(Token = "0x6001C0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2BD88", Offset = "0x1B2BD88", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "GetNotNull", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ExtractAssembly", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WellKnownClientTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ReadClientWellKnown(Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00018DD0 File Offset: 0x00016FD0
		[global::Cpp2ILInjected.Token(Token = "0x6001C0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2BE70", Offset = "0x1B2BE70", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "GetNotNull", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "ExtractAssembly", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WellKnownServiceTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(WellKnownObjectMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void ReadServiceWellKnown(Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00018DD3 File Offset: 0x00016FD3
		[global::Cpp2ILInjected.Token(Token = "0x6001C0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2C238", Offset = "0x1B2C238", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = "GetNotNull", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "RegisterInteropXmlElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "RegisterInteropXmlType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void ReadInteropXml(Mono.Xml.SmallXmlParser.IAttrList attrs, bool isElement)
		{
			throw null;
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00018DD6 File Offset: 0x00016FD6
		[global::Cpp2ILInjected.Token(Token = "0x6001C0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2C3B0", Offset = "0x1B2C3B0", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void ReadPreload(Mono.Xml.SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00018DD9 File Offset: 0x00016FD9
		[global::Cpp2ILInjected.Token(Token = "0x6001C0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CBD0", Offset = "0x1B2CBD0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientActivated", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceActivated", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientWellKnown", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceWellKnown", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadInteropXml", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private string GetNotNull(Mono.Xml.SmallXmlParser.IAttrList attrs, string name)
		{
			throw null;
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00018DDC File Offset: 0x00016FDC
		[global::Cpp2ILInjected.Token(Token = "0x6001C0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CD00", Offset = "0x1B2CD00", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientActivated", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceActivated", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientWellKnown", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceWellKnown", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string ExtractAssembly(ref string type)
		{
			throw null;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00018DDF File Offset: 0x00016FDF
		[global::Cpp2ILInjected.Token(Token = "0x6001C10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CDA8", Offset = "0x1B2CDA8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnChars(string ch)
		{
			throw null;
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00018DE2 File Offset: 0x00016FE2
		[global::Cpp2ILInjected.Token(Token = "0x6001C11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CDAC", Offset = "0x1B2CDAC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new object[]
		{
			typeof(global::System.Collections.ArrayList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void OnEndParsing(Mono.Xml.SmallXmlParser parser)
		{
			throw null;
		}

		// Token: 0x04000B5F RID: 2911
		[global::Cpp2ILInjected.Token(Token = "0x4000E3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.ArrayList typeEntries;

		// Token: 0x04000B60 RID: 2912
		[global::Cpp2ILInjected.Token(Token = "0x4000E40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Collections.ArrayList channelInstances;

		// Token: 0x04000B61 RID: 2913
		[global::Cpp2ILInjected.Token(Token = "0x4000E41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ChannelData currentChannel;

		// Token: 0x04000B62 RID: 2914
		[global::Cpp2ILInjected.Token(Token = "0x4000E42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Collections.Stack currentProviderData;

		// Token: 0x04000B63 RID: 2915
		[global::Cpp2ILInjected.Token(Token = "0x4000E43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string currentClientUrl;

		// Token: 0x04000B64 RID: 2916
		[global::Cpp2ILInjected.Token(Token = "0x4000E44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string appName;

		// Token: 0x04000B65 RID: 2917
		[global::Cpp2ILInjected.Token(Token = "0x4000E45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string currentXmlPath;

		// Token: 0x04000B66 RID: 2918
		[global::Cpp2ILInjected.Token(Token = "0x4000E46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool onlyDelayedChannels;
	}
}
