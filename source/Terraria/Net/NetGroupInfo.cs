using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;
using Terraria.Social.Discord;

namespace Terraria.Net
{
	// Token: 0x02000498 RID: 1176
	[global::Cpp2ILInjected.Token(Token = "0x20006A1")]
	public class NetGroupInfo
	{
		// Token: 0x06003355 RID: 13141 RVA: 0x0002B2D7 File Offset: 0x000294D7
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

		// Token: 0x06003356 RID: 13142 RVA: 0x0002B2DA File Offset: 0x000294DA
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

		// Token: 0x06003357 RID: 13143 RVA: 0x0002B2DD File Offset: 0x000294DD
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

		// Token: 0x06003358 RID: 13144 RVA: 0x0002B2E0 File Offset: 0x000294E0
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

		// Token: 0x06003359 RID: 13145 RVA: 0x0002B2E3 File Offset: 0x000294E3
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

		// Token: 0x04006549 RID: 25929
		[global::Cpp2ILInjected.Token(Token = "0x4007948")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string[] _separatorBetweenInfos;

		// Token: 0x0400654A RID: 25930
		[global::Cpp2ILInjected.Token(Token = "0x4007949")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string[] _separatorBetweenIdAndInfo;

		// Token: 0x0400654B RID: 25931
		[global::Cpp2ILInjected.Token(Token = "0x400794A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<NetGroupInfo.INetGroupInfoProvider> _infoProviders;

		// Token: 0x0200093E RID: 2366
		[global::Cpp2ILInjected.Token(Token = "0x20006A2")]
		public enum InfoProviderId
		{
			// Token: 0x04008ADF RID: 35551
			[global::Cpp2ILInjected.Token(Token = "0x400794C")]
			IPAddress,
			// Token: 0x04008AE0 RID: 35552
			[global::Cpp2ILInjected.Token(Token = "0x400794D")]
			Steam
		}

		// Token: 0x0200093F RID: 2367
		[global::Cpp2ILInjected.Token(Token = "0x20006A3")]
		private interface INetGroupInfoProvider
		{
			// Token: 0x170008A1 RID: 2209
			// (get) Token: 0x06004CB0 RID: 19632
			[global::Cpp2ILInjected.Token(Token = "0x170006CF")]
			NetGroupInfo.InfoProviderId Id
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003895")]
				get;
			}

			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06004CB1 RID: 19633
			[global::Cpp2ILInjected.Token(Token = "0x170006D0")]
			bool HasValidInfo
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003896")]
				get;
			}

			// Token: 0x06004CB2 RID: 19634
			[global::Cpp2ILInjected.Token(Token = "0x6003897")]
			string ProvideInfoNeededToJoin();
		}

		// Token: 0x02000940 RID: 2368
		[global::Cpp2ILInjected.Token(Token = "0x20006A4")]
		private class IPAddressInfoProvider : NetGroupInfo.INetGroupInfoProvider
		{
			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x0002F8FA File Offset: 0x0002DAFA
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

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x0002F8FD File Offset: 0x0002DAFD
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

			// Token: 0x06004CB5 RID: 19637 RVA: 0x0002F900 File Offset: 0x0002DB00
			[global::Cpp2ILInjected.Token(Token = "0x600389A")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D33C", Offset = "0x143D33C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string ProvideInfoNeededToJoin()
			{
				throw null;
			}

			// Token: 0x06004CB6 RID: 19638 RVA: 0x0002F903 File Offset: 0x0002DB03
			[global::Cpp2ILInjected.Token(Token = "0x600389B")]
			[global::Cpp2ILInjected.Address(RVA = "0x143CD98", Offset = "0x143CD98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IPAddressInfoProvider()
			{
				throw null;
			}
		}

		// Token: 0x02000941 RID: 2369
		[global::Cpp2ILInjected.Token(Token = "0x20006A5")]
		private class SteamLobbyInfoProvider : NetGroupInfo.INetGroupInfoProvider
		{
			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06004CB7 RID: 19639 RVA: 0x0002F906 File Offset: 0x0002DB06
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

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x0002F909 File Offset: 0x0002DB09
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

			// Token: 0x06004CB9 RID: 19641 RVA: 0x0002F90C File Offset: 0x0002DB0C
			[global::Cpp2ILInjected.Token(Token = "0x600389E")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D3E4", Offset = "0x143D3E4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public string ProvideInfoNeededToJoin()
			{
				throw null;
			}

			// Token: 0x06004CBA RID: 19642 RVA: 0x0002F90F File Offset: 0x0002DB0F
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
