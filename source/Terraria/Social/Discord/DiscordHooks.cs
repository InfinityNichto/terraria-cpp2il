using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Discord
{
	[global::Cpp2ILInjected.Token(Token = "0x2000516")]
	public class DiscordHooks
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003170")]
		[global::Cpp2ILInjected.Address(RVA = "0x1327FA4", Offset = "0x1327FA4", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoreSocialModule), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnJoinInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnReadyInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnRequestInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnSpectateInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnErrorInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnDisconnectedInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void RegisterTo(ref DiscordRpc.EventHandlers handlers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003171")]
		[global::Cpp2ILInjected.Address(RVA = "0x13284B4", Offset = "0x13284B4", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoreSocialModule), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnReadyInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnRequestInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnSpectateInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnErrorInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.OnDisconnectedInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void UnRegisterFrom(ref DiscordRpc.EventHandlers handlers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328D9C", Offset = "0x1328D9C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnReadyInfo(ref DiscordRpc.DiscordUser connectedUser)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328DB8", Offset = "0x1328DB8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnDisconnectedInfo(int errorCode, string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328DD4", Offset = "0x1328DD4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnErrorInfo(int errorCode, string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328DF0", Offset = "0x1328DF0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnJoinInfo(string secret)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328E0C", Offset = "0x1328E0C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnSpectateInfo(string secret)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003177")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328E28", Offset = "0x1328E28", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnRequestInfo(ref DiscordRpc.DiscordUser request)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1327F9C", Offset = "0x1327F9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DiscordHooks()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003B22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public DiscordRpc.OnReadyInfo readyCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4003B23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4003B24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public DiscordRpc.OnErrorInfo errorCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4003B25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public DiscordRpc.OnJoinInfo joinCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4003B26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public DiscordRpc.OnSpectateInfo spectateCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4003B27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public DiscordRpc.OnRequestInfo requestCallback;
	}
}
