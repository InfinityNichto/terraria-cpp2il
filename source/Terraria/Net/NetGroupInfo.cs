using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;
using Terraria.Social.Discord;

namespace Terraria.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20006A1")]
	public class NetGroupInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003890")]
		[global::Cpp2ILInjected.Address(RVA = "0x143CB3C", Offset = "0x143CB3C", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoinRequestSocialModule), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RichPresenceSocialModule), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public NetGroupInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003891")]
		[global::Cpp2ILInjected.Address(RVA = "0x143CDA8", Offset = "0x143CDA8", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RichPresenceSocialModule), Member = "PublishPresence", MemberParameters = new object[] { typeof(RichPresenceState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RichPresenceSocialModule), Member = "GetJoinSecret", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetGroupInfo), Member = "ConvertToSafeInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public string ComposeInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003892")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D1A8", Offset = "0x143D1A8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoinRequestSocialModule), Member = "TestSecretIsWhatWeExpectItToBe", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetGroupInfo), Member = "ConvertFromSafeInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "set_Item", MemberParameters = new object[]
		{
			"System.Int32Enum",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Dictionary<NetGroupInfo.InfoProviderId, string> DecomposeInfo(string info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003893")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D150", Offset = "0x143D150", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetGroupInfo), Member = "ComposeInfo", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EscapeDataString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string ConvertToSafeInfo(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003894")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D2D4", Offset = "0x143D2D4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetGroupInfo), Member = "DecomposeInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Dictionary<NetGroupInfo.InfoProviderId, string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "UnescapeDataString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string ConvertFromSafeInfo(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007948")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string[] _separatorBetweenInfos;

		[global::Cpp2ILInjected.Token(Token = "0x4007949")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string[] _separatorBetweenIdAndInfo;

		[global::Cpp2ILInjected.Token(Token = "0x400794A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<NetGroupInfo.INetGroupInfoProvider> _infoProviders;

		[global::Cpp2ILInjected.Token(Token = "0x20006A2")]
		public enum InfoProviderId
		{
			[global::Cpp2ILInjected.Token(Token = "0x400794C")]
			IPAddress,
			[global::Cpp2ILInjected.Token(Token = "0x400794D")]
			Steam
		}

		[global::Cpp2ILInjected.Token(Token = "0x20006A3")]
		private interface INetGroupInfoProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x170006CF")]
			NetGroupInfo.InfoProviderId Id
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003895")]
				get;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170006D0")]
			bool HasValidInfo
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003896")]
				get;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003897")]
			string ProvideInfoNeededToJoin();
		}

		[global::Cpp2ILInjected.Token(Token = "0x20006A4")]
		private class IPAddressInfoProvider : NetGroupInfo.INetGroupInfoProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x170006D1")]
			public NetGroupInfo.InfoProviderId Id
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003898")]
				[global::Cpp2ILInjected.Address(RVA = "0x143D32C", Offset = "0x143D32C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170006D2")]
			public bool HasValidInfo
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003899")]
				[global::Cpp2ILInjected.Address(RVA = "0x143D334", Offset = "0x143D334", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x600389A")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D33C", Offset = "0x143D33C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string ProvideInfoNeededToJoin()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600389B")]
			[global::Cpp2ILInjected.Address(RVA = "0x143CD98", Offset = "0x143CD98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IPAddressInfoProvider()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20006A5")]
		private class SteamLobbyInfoProvider : NetGroupInfo.INetGroupInfoProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x170006D3")]
			public NetGroupInfo.InfoProviderId Id
			{
				[global::Cpp2ILInjected.Token(Token = "0x600389C")]
				[global::Cpp2ILInjected.Address(RVA = "0x143D37C", Offset = "0x143D37C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170006D4")]
			public bool HasValidInfo
			{
				[global::Cpp2ILInjected.Token(Token = "0x600389D")]
				[global::Cpp2ILInjected.Address(RVA = "0x143D384", Offset = "0x143D384", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x600389E")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D3E4", Offset = "0x143D3E4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public string ProvideInfoNeededToJoin()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600389F")]
			[global::Cpp2ILInjected.Address(RVA = "0x143CDA0", Offset = "0x143CDA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SteamLobbyInfoProvider()
			{
				throw null;
			}
		}
	}
}
