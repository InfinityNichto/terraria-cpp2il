using Cpp2IlInjected;
using Terraria.Net;

namespace Terraria.Social.Discord;

[Cpp2IlInjected.Token(Token = "0x200038C")]
public class JoinRequestSocialModule : ISocialModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031CD")]
	private NetGroupInfo _infoAboutNetGroup;

	[Cpp2IlInjected.Token(Token = "0x6002D81")]
	[Cpp2IlInjected.Address(RVA = "0x14E45A8", Offset = "0x14E45A8", VA = "0x14E45A8", Slot = "4")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D82")]
	[Cpp2IlInjected.Address(RVA = "0x14E4718", Offset = "0x14E4718", VA = "0x14E4718", Slot = "5")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D83")]
	[Cpp2IlInjected.Address(RVA = "0x14E4864", Offset = "0x14E4864", VA = "0x14E4864")]
	private void ReceiveJoinRequest(ref DiscordRpc.DiscordUser request)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D84")]
	[Cpp2IlInjected.Address(RVA = "0x14E49CC", Offset = "0x14E49CC", VA = "0x14E49CC")]
	private void ReceiveJoinCallback(string secret)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D85")]
	[Cpp2IlInjected.Address(RVA = "0x14E49D0", Offset = "0x14E49D0", VA = "0x14E49D0")]
	private void TestSecretIsWhatWeExpectItToBe(string secret)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D86")]
	[Cpp2IlInjected.Address(RVA = "0x14E4A00", Offset = "0x14E4A00", VA = "0x14E4A00")]
	private bool CanJoinGame()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D87")]
	[Cpp2IlInjected.Address(RVA = "0x14E4A74", Offset = "0x14E4A74", VA = "0x14E4A74")]
	public JoinRequestSocialModule()
	{
	}
}
