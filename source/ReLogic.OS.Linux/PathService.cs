using Cpp2IlInjected;
using ReLogic.OS.Base;

namespace ReLogic.OS.Linux;

[Cpp2IlInjected.Token(Token = "0x200072F")]
internal class PathService : ReLogic.OS.Base.PathService
{
	[Cpp2IlInjected.Token(Token = "0x60046F4")]
	[Cpp2IlInjected.Address(RVA = "0xF91FBC", Offset = "0xF91FBC", VA = "0xF91FBC", Slot = "7")]
	public override string GetStoragePath()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60046F5")]
	[Cpp2IlInjected.Address(RVA = "0xF92088", Offset = "0xF92088", VA = "0xF92088")]
	public PathService()
	{
	}
}
