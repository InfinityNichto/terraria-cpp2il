using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x020002A5 RID: 677
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000343")]
	public static class RemotingConfiguration
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00018D64 File Offset: 0x00016F64
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x00018D67 File Offset: 0x00016F67
		[global::Cpp2ILInjected.Token(Token = "0x1700033A")]
		public static string ApplicationName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B26378", Offset = "0x1B26378", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001BE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B263D0", Offset = "0x1B263D0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00018D6A File Offset: 0x00016F6A
		[global::Cpp2ILInjected.Token(Token = "0x1700033B")]
		public static string ProcessId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B2642C", Offset = "0x1B2642C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainData), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainChannel), Member = "CreateMessageSink", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(ref string)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00018D6D File Offset: 0x00016F6D
		[global::Cpp2ILInjected.Token(Token = "0x6001BEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B264D4", Offset = "0x1B264D4", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Xml.SmallXmlParser), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetMachineConfigPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfigHandler), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Xml.SmallXmlParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextReader),
			typeof(Mono.Xml.SmallXmlParser.IContentHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		internal static void LoadDefaultDelayedChannels()
		{
			throw null;
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00018D70 File Offset: 0x00016F70
		[global::Cpp2ILInjected.Token(Token = "0x6001BEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B268D4", Offset = "0x1B268D4", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.RemoteActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool IsActivationAllowed(global::System.Type svrType)
		{
			throw null;
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00018D73 File Offset: 0x00016F73
		[global::Cpp2ILInjected.Token(Token = "0x6001BEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B26A0C", Offset = "0x1B26A0C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateProxyForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(global::System.Type svrType)
		{
			throw null;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00018D76 File Offset: 0x00016F76
		[global::Cpp2ILInjected.Token(Token = "0x6001BED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B26B8C", Offset = "0x1B26B8C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateProxyForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static WellKnownClientTypeEntry IsWellKnownClientType(global::System.Type svrType)
		{
			throw null;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00018D79 File Offset: 0x00016F79
		[global::Cpp2ILInjected.Token(Token = "0x6001BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B26D0C", Offset = "0x1B26D0C", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "EnableProxyActivation", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
			throw null;
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00018D7C File Offset: 0x00016F7C
		[global::Cpp2ILInjected.Token(Token = "0x6001BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B26F54", Offset = "0x1B26F54", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
			throw null;
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00018D7F File Offset: 0x00016F7F
		[global::Cpp2ILInjected.Token(Token = "0x6001BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B27084", Offset = "0x1B27084", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "EnableProxyActivation", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
			throw null;
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00018D82 File Offset: 0x00016F82
		[global::Cpp2ILInjected.Token(Token = "0x6001BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B272CC", Offset = "0x1B272CC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "CreateWellKnownServerIdentity", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(WellKnownObjectMode)
		}, ReturnType = typeof(ServerIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
			throw null;
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00018D85 File Offset: 0x00016F85
		[global::Cpp2ILInjected.Token(Token = "0x6001BF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B27550", Offset = "0x1B27550", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadChannel", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void RegisterChannelTemplate(ChannelData channel)
		{
			throw null;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00018D88 File Offset: 0x00016F88
		[global::Cpp2ILInjected.Token(Token = "0x6001BF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B275C0", Offset = "0x1B275C0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void RegisterClientProviderTemplate(ProviderData prov)
		{
			throw null;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00018D8B File Offset: 0x00016F8B
		[global::Cpp2ILInjected.Token(Token = "0x6001BF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B27630", Offset = "0x1B27630", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void RegisterServerProviderTemplate(ProviderData prov)
		{
			throw null;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00018D8E File Offset: 0x00016F8E
		[global::Cpp2ILInjected.Token(Token = "0x6001BF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B276A0", Offset = "0x1B276A0", Length = "0xBAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "OnEndParsing", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_ServerProviders", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProviderData), Member = "CopyFrom", MemberParameters = new object[] { typeof(ProviderData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_ClientProviders", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 68)]
		internal static void RegisterChannels(global::System.Collections.ArrayList channels, bool onlyDelayed)
		{
			throw null;
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00018D91 File Offset: 0x00016F91
		[global::Cpp2ILInjected.Token(Token = "0x6001BF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29240", Offset = "0x1B29240", Length = "0x50C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "OnEndParsing", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownServiceType", MemberParameters = new object[] { typeof(WellKnownServiceTypeEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterActivatedClientType", MemberParameters = new object[] { typeof(ActivatedClientTypeEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterActivatedServiceType", MemberParameters = new object[] { typeof(ActivatedServiceTypeEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownClientType", MemberParameters = new object[] { typeof(WellKnownClientTypeEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal static void RegisterTypes(global::System.Collections.ArrayList types)
		{
			throw null;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00018D94 File Offset: 0x00016F94
		[global::Cpp2ILInjected.Token(Token = "0x6001BF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2974C", Offset = "0x1B2974C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "CheckReturnMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			throw null;
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00018D97 File Offset: 0x00016F97
		[global::Cpp2ILInjected.Token(Token = "0x6001BF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B297E0", Offset = "0x1B297E0", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal static void SetCustomErrorsMode(string mode)
		{
			throw null;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00018D9A File Offset: 0x00016F9A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B29A2C", Offset = "0x1B29A2C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static RemotingConfiguration()
		{
			throw null;
		}

		// Token: 0x04000B52 RID: 2898
		[global::Cpp2ILInjected.Token(Token = "0x4000E32")]
		private static string applicationID;

		// Token: 0x04000B53 RID: 2899
		[global::Cpp2ILInjected.Token(Token = "0x4000E33")]
		private static string applicationName;

		// Token: 0x04000B54 RID: 2900
		[global::Cpp2ILInjected.Token(Token = "0x4000E34")]
		private static string processGuid;

		// Token: 0x04000B55 RID: 2901
		[global::Cpp2ILInjected.Token(Token = "0x4000E35")]
		private static bool defaultConfigRead;

		// Token: 0x04000B56 RID: 2902
		[global::Cpp2ILInjected.Token(Token = "0x4000E36")]
		private static bool defaultDelayedConfigRead;

		// Token: 0x04000B57 RID: 2903
		[global::Cpp2ILInjected.Token(Token = "0x4000E37")]
		private static CustomErrorsModes _errorMode;

		// Token: 0x04000B58 RID: 2904
		[global::Cpp2ILInjected.Token(Token = "0x4000E38")]
		private static global::System.Collections.Hashtable wellKnownClientEntries;

		// Token: 0x04000B59 RID: 2905
		[global::Cpp2ILInjected.Token(Token = "0x4000E39")]
		private static global::System.Collections.Hashtable activatedClientEntries;

		// Token: 0x04000B5A RID: 2906
		[global::Cpp2ILInjected.Token(Token = "0x4000E3A")]
		private static global::System.Collections.Hashtable wellKnownServiceEntries;

		// Token: 0x04000B5B RID: 2907
		[global::Cpp2ILInjected.Token(Token = "0x4000E3B")]
		private static global::System.Collections.Hashtable activatedServiceEntries;

		// Token: 0x04000B5C RID: 2908
		[global::Cpp2ILInjected.Token(Token = "0x4000E3C")]
		private static global::System.Collections.Hashtable channelTemplates;

		// Token: 0x04000B5D RID: 2909
		[global::Cpp2ILInjected.Token(Token = "0x4000E3D")]
		private static global::System.Collections.Hashtable clientProviderTemplates;

		// Token: 0x04000B5E RID: 2910
		[global::Cpp2ILInjected.Token(Token = "0x4000E3E")]
		private static global::System.Collections.Hashtable serverProviderTemplates;
	}
}
