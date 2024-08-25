using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Net;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	[global::Cpp2ILInjected.Token(Token = "0x2000523")]
	public class JoinRequestSocialModule : ISocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x600319F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13299D0", Offset = "0x13299D0", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetGroupInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnRequestInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnJoinInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1329B64", Offset = "0x1329B64", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnJoinInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnRequestInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Shutdown()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1329CCC", Offset = "0x1329CCC", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordJoinToServerRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserJoinToServerRequest), Member = "add_OnAccepted", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserJoinToServerRequest), Member = "add_OnRejected", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestsManager), Member = "Add", MemberParameters = new object[] { typeof(UserJoinToServerRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ReceiveJoinRequest(ref DiscordRpc.DiscordUser request)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A200", Offset = "0x132A200", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ReceiveJoinCallback(string secret)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A204", Offset = "0x132A204", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JoinRequestSocialModule), Member = "CanJoinGame", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetGroupInfo), Member = "DecomposeInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Dictionary<NetGroupInfo.InfoProviderId, string>))]
		private void TestSecretIsWhatWeExpectItToBe(string secret)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A240", Offset = "0x132A240", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoinRequestSocialModule), Member = "TestSecretIsWhatWeExpectItToBe", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool CanJoinGame()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A290", Offset = "0x132A290", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public JoinRequestSocialModule()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003B56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NetGroupInfo _infoAboutNetGroup;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000524")]
		private sealed class <>c__DisplayClass3_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60031A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1329E24", Offset = "0x1329E24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass3_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60031A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x132A298", Offset = "0x132A298", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc), Member = "Respond", MemberParameters = new object[]
			{
				typeof(string),
				typeof(DiscordRpc.Reply)
			}, ReturnType = typeof(void))]
			internal void <ReceiveJoinRequest>b__0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60031A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x132A2A4", Offset = "0x132A2A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc), Member = "Respond", MemberParameters = new object[]
			{
				typeof(string),
				typeof(DiscordRpc.Reply)
			}, ReturnType = typeof(void))]
			internal void <ReceiveJoinRequest>b__1()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4003B57")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string userId;
		}
	}
}
