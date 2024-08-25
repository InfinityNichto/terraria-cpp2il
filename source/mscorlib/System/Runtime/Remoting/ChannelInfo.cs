using System;
using System.Runtime.Remoting.Channels;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	[global::Cpp2ILInjected.Token(Token = "0x2000337")]
	[global::System.Serializable]
	internal class ChannelInfo : IChannelInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24990", Offset = "0x1B24990", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjRef), Member = "UpdateChannelInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "GetCurrentChannelInfo", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ChannelInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B249F8", Offset = "0x1B249F8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ChannelInfo(object remoteChannelData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000322")]
		public object[] ChannelData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24A8C", Offset = "0x1B24A8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object[] channelData;
	}
}
