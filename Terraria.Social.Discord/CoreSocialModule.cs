using Cpp2IlInjected;

namespace Terraria.Social.Discord;

[Cpp2IlInjected.Token(Token = "0x2000389")]
public class CoreSocialModule : ISocialModule
{
	[Cpp2IlInjected.Token(Token = "0x40031C2")]
	private const string TERRARIA_STEAM_APPLICATION_ID = "105600";

	[Cpp2IlInjected.Token(Token = "0x40031C3")]
	private const string TERRARIA_DISCORD_APPLICATION_ID = "356943499456937984";

	[Cpp2IlInjected.Token(Token = "0x40031C4")]
	private const bool AUTO_REGISTER_STEAM = false;

	[Cpp2IlInjected.Token(Token = "0x40031C5")]
	public static DiscordHooks Hooks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031C6")]
	private DiscordRpc.EventHandlers _handlers;

	[Cpp2IlInjected.Token(Token = "0x6002D6B")]
	[Cpp2IlInjected.Address(RVA = "0x14E15D0", Offset = "0x14E15D0", VA = "0x14E15D0", Slot = "4")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D6C")]
	[Cpp2IlInjected.Address(RVA = "0x14E1C84", Offset = "0x14E1C84", VA = "0x14E1C84", Slot = "5")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D6D")]
	[Cpp2IlInjected.Address(RVA = "0x14E2200", Offset = "0x14E2200", VA = "0x14E2200")]
	private void Pulse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D6E")]
	[Cpp2IlInjected.Address(RVA = "0x14E22A0", Offset = "0x14E22A0", VA = "0x14E22A0")]
	public CoreSocialModule()
	{
	}
}
