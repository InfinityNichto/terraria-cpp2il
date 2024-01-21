using Cpp2IlInjected;

namespace Terraria.Social.Discord;

[Cpp2IlInjected.Token(Token = "0x200038A")]
public class DiscordHooks
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031C7")]
	public DiscordRpc.OnReadyInfo readyCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031C8")]
	public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40031C9")]
	public DiscordRpc.OnErrorInfo errorCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40031CA")]
	public DiscordRpc.OnJoinInfo joinCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40031CB")]
	public DiscordRpc.OnSpectateInfo spectateCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40031CC")]
	public DiscordRpc.OnRequestInfo requestCallback;

	[Cpp2IlInjected.Token(Token = "0x6002D6F")]
	[Cpp2IlInjected.Address(RVA = "0x14E1724", Offset = "0x14E1724", VA = "0x14E1724")]
	public void RegisterTo(ref DiscordRpc.EventHandlers handlers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D70")]
	[Cpp2IlInjected.Address(RVA = "0x14E1D5C", Offset = "0x14E1D5C", VA = "0x14E1D5C")]
	public void UnRegisterFrom(ref DiscordRpc.EventHandlers handlers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D71")]
	[Cpp2IlInjected.Address(RVA = "0x14E2320", Offset = "0x14E2320", VA = "0x14E2320")]
	private void OnReadyInfo(ref DiscordRpc.DiscordUser connectedUser)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D72")]
	[Cpp2IlInjected.Address(RVA = "0x14E25C8", Offset = "0x14E25C8", VA = "0x14E25C8")]
	private void OnDisconnectedInfo(int errorCode, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D73")]
	[Cpp2IlInjected.Address(RVA = "0x14E28AC", Offset = "0x14E28AC", VA = "0x14E28AC")]
	private void OnErrorInfo(int errorCode, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D74")]
	[Cpp2IlInjected.Address(RVA = "0x14E2B90", Offset = "0x14E2B90", VA = "0x14E2B90")]
	private void OnJoinInfo(string secret)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D75")]
	[Cpp2IlInjected.Address(RVA = "0x14E2FC4", Offset = "0x14E2FC4", VA = "0x14E2FC4")]
	private void OnSpectateInfo(string secret)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D76")]
	[Cpp2IlInjected.Address(RVA = "0x14E33F8", Offset = "0x14E33F8", VA = "0x14E33F8")]
	private void OnRequestInfo(ref DiscordRpc.DiscordUser request)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D77")]
	[Cpp2IlInjected.Address(RVA = "0x14E171C", Offset = "0x14E171C", VA = "0x14E171C")]
	public DiscordHooks()
	{
	}
}
