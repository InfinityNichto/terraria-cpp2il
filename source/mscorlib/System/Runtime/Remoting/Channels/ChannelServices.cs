using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020002D2 RID: 722
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000375")]
	public sealed class ChannelServices
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00019088 File Offset: 0x00017288
		[global::Cpp2ILInjected.Token(Token = "0x17000368")]
		internal static global::System.Runtime.Remoting.Contexts.CrossContextChannel CrossContextChannel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3D268", Offset = "0x1B3D268", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0001908B File Offset: 0x0001728B
		[global::Cpp2ILInjected.Token(Token = "0x6001D1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3D2C0", Offset = "0x1B3D2C0", Length = "0x808")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "GetClientChannelSinkChain", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new object[]
		{
			typeof(IChannelSender),
			typeof(string),
			typeof(object[]),
			typeof(ref string)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new object[] { typeof(IChannel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		internal static global::System.Runtime.Remoting.Messaging.IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri)
		{
			throw null;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0001908E File Offset: 0x0001728E
		[global::Cpp2ILInjected.Token(Token = "0x6001D1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3DAC8", Offset = "0x1B3DAC8", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static global::System.Runtime.Remoting.Messaging.IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri)
		{
			throw null;
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00019091 File Offset: 0x00017291
		[global::System.Obsolete("Use RegisterChannel(IChannel,Boolean)")]
		[global::Cpp2ILInjected.Token(Token = "0x6001D20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3DCB4", Offset = "0x1B3DCB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageSink))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrossAppDomainChannel), Member = "RegisterCrossAppDomainChannel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void RegisterChannel(IChannel chnl)
		{
			throw null;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00019094 File Offset: 0x00017294
		[global::Cpp2ILInjected.Token(Token = "0x6001D21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3DD0C", Offset = "0x1B3DD0C", Length = "0x81C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
		{
			throw null;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00019097 File Offset: 0x00017297
		[global::Cpp2ILInjected.Token(Token = "0x6001D22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3E528", Offset = "0x1B3E528", Length = "0xB08")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new object[]
		{
			typeof(global::System.Collections.ArrayList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_ServerProviders", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelServices), Member = "CreateProvider", MemberParameters = new object[] { typeof(ProviderData) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_ClientProviders", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelData), Member = "get_CustomProperties", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ConstructorInfo),
			typeof(global::System.Reflection.ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "Invoke", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new object[] { typeof(IChannel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 83)]
		internal static void RegisterChannelConfig(ChannelData channel)
		{
			throw null;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0001909A File Offset: 0x0001729A
		[global::Cpp2ILInjected.Token(Token = "0x6001D23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3F030", Offset = "0x1B3F030", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new object[] { typeof(ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private static object CreateProvider(ProviderData prov)
		{
			throw null;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0001909D File Offset: 0x0001729D
		[global::Cpp2ILInjected.Token(Token = "0x6001D24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3F30C", Offset = "0x1B3F30C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage),
			typeof(ref byte[]),
			typeof(ref global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelServices), Member = "CheckIncomingMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelServices), Member = "CheckReturnMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.Runtime.Remoting.Messaging.IMessage SyncDispatchMessage(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000190A0 File Offset: 0x000172A0
		[global::Cpp2ILInjected.Token(Token = "0x6001D25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3F3A0", Offset = "0x1B3F3A0", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "SetMessageTargetIdentity", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(Identity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static global::System.Runtime.Remoting.Messaging.ReturnMessage CheckIncomingMessage(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			throw null;
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000190A3 File Offset: 0x000172A3
		[global::Cpp2ILInjected.Token(Token = "0x6001D26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3F648", Offset = "0x1B3F648", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "CustomErrorsEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static global::System.Runtime.Remoting.Messaging.IMessage CheckReturnMessage(global::System.Runtime.Remoting.Messaging.IMessage callMsg, global::System.Runtime.Remoting.Messaging.IMessage retMsg)
		{
			throw null;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000190A6 File Offset: 0x000172A6
		[global::Cpp2ILInjected.Token(Token = "0x6001D27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3F80C", Offset = "0x1B3F80C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsLocalCall(global::System.Runtime.Remoting.Messaging.IMessage callMsg)
		{
			throw null;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000190A9 File Offset: 0x000172A9
		[global::Cpp2ILInjected.Token(Token = "0x6001D28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3F928", Offset = "0x1B3F928", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChannelInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal static object[] GetCurrentChannelInfo()
		{
			throw null;
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000190AC File Offset: 0x000172AC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001D29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3FDF8", Offset = "0x1B3FDF8", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static ChannelServices()
		{
			throw null;
		}

		// Token: 0x04000BCD RID: 3021
		[global::Cpp2ILInjected.Token(Token = "0x4000EB6")]
		private static global::System.Collections.ArrayList registeredChannels;

		// Token: 0x04000BCE RID: 3022
		[global::Cpp2ILInjected.Token(Token = "0x4000EB7")]
		private static global::System.Collections.ArrayList delayedClientChannels;

		// Token: 0x04000BCF RID: 3023
		[global::Cpp2ILInjected.Token(Token = "0x4000EB8")]
		private static global::System.Runtime.Remoting.Contexts.CrossContextChannel _crossContextSink;

		// Token: 0x04000BD0 RID: 3024
		[global::Cpp2ILInjected.Token(Token = "0x4000EB9")]
		internal static string CrossContextUrl;

		// Token: 0x04000BD1 RID: 3025
		[global::Cpp2ILInjected.Token(Token = "0x4000EBA")]
		private static global::System.Collections.IList oldStartModeTypes;
	}
}
