using Cpp2IlInjected;
using Terraria.Social.Base;

namespace Terraria.Social.Steam;

[Cpp2IlInjected.Token(Token = "0x2000387")]
public class PlatformSocialModule : Terraria.Social.Base.PlatformSocialModule
{
	[Cpp2IlInjected.Token(Token = "0x6002D67")]
	[Cpp2IlInjected.Address(RVA = "0x14E5990", Offset = "0x14E5990", VA = "0x14E5990", Slot = "6")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D68")]
	[Cpp2IlInjected.Address(RVA = "0x14E5994", Offset = "0x14E5994", VA = "0x14E5994", Slot = "7")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D69")]
	[Cpp2IlInjected.Address(RVA = "0x14E5998", Offset = "0x14E5998", VA = "0x14E5998")]
	public PlatformSocialModule()
	{
	}
}
