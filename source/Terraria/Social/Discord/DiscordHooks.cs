using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Discord
{
	// Token: 0x02000387 RID: 903
	[global::Cpp2ILInjected.Token(Token = "0x2000516")]
	public class DiscordHooks
	{
		// Token: 0x06002D37 RID: 11575 RVA: 0x0002A1C4 File Offset: 0x000283C4
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

		// Token: 0x06002D38 RID: 11576 RVA: 0x0002A1C7 File Offset: 0x000283C7
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

		// Token: 0x06002D39 RID: 11577 RVA: 0x0002A1CA File Offset: 0x000283CA
		[global::Cpp2ILInjected.Token(Token = "0x6003172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328D9C", Offset = "0x1328D9C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnReadyInfo(ref DiscordRpc.DiscordUser connectedUser)
		{
			throw null;
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0002A1CD File Offset: 0x000283CD
		[global::Cpp2ILInjected.Token(Token = "0x6003173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328DB8", Offset = "0x1328DB8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnDisconnectedInfo(int errorCode, string message)
		{
			throw null;
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x0002A1D0 File Offset: 0x000283D0
		[global::Cpp2ILInjected.Token(Token = "0x6003174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328DD4", Offset = "0x1328DD4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnErrorInfo(int errorCode, string message)
		{
			throw null;
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x0002A1D3 File Offset: 0x000283D3
		[global::Cpp2ILInjected.Token(Token = "0x6003175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328DF0", Offset = "0x1328DF0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnJoinInfo(string secret)
		{
			throw null;
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x0002A1D6 File Offset: 0x000283D6
		[global::Cpp2ILInjected.Token(Token = "0x6003176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328E0C", Offset = "0x1328E0C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnSpectateInfo(string secret)
		{
			throw null;
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x0002A1D9 File Offset: 0x000283D9
		[global::Cpp2ILInjected.Token(Token = "0x6003177")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328E28", Offset = "0x1328E28", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnRequestInfo(ref DiscordRpc.DiscordUser request)
		{
			throw null;
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x0002A1DC File Offset: 0x000283DC
		[global::Cpp2ILInjected.Token(Token = "0x6003178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1327F9C", Offset = "0x1327F9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DiscordHooks()
		{
			throw null;
		}

		// Token: 0x040031C6 RID: 12742
		[global::Cpp2ILInjected.Token(Token = "0x4003B22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public DiscordRpc.OnReadyInfo readyCallback;

		// Token: 0x040031C7 RID: 12743
		[global::Cpp2ILInjected.Token(Token = "0x4003B23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

		// Token: 0x040031C8 RID: 12744
		[global::Cpp2ILInjected.Token(Token = "0x4003B24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public DiscordRpc.OnErrorInfo errorCallback;

		// Token: 0x040031C9 RID: 12745
		[global::Cpp2ILInjected.Token(Token = "0x4003B25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public DiscordRpc.OnJoinInfo joinCallback;

		// Token: 0x040031CA RID: 12746
		[global::Cpp2ILInjected.Token(Token = "0x4003B26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public DiscordRpc.OnSpectateInfo spectateCallback;

		// Token: 0x040031CB RID: 12747
		[global::Cpp2ILInjected.Token(Token = "0x4003B27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public DiscordRpc.OnRequestInfo requestCallback;
	}
}
