using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000395")]
public abstract class PlatformSocialModule : ISocialModule
{
	[Cpp2IlInjected.Token(Token = "0x6002DCA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6002DCB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void Shutdown();

	[Cpp2IlInjected.Token(Token = "0x6002DCC")]
	[Cpp2IlInjected.Address(RVA = "0x14DFCA8", Offset = "0x14DFCA8", VA = "0x14DFCA8")]
	protected PlatformSocialModule()
	{
	}
}
