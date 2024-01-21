using Cpp2IlInjected;
using ReLogic.OS.Base;

namespace ReLogic.OS.OSX;

[Cpp2IlInjected.Token(Token = "0x200072C")]
internal class PathService : ReLogic.OS.Base.PathService
{
	[Cpp2IlInjected.Token(Token = "0x60046E8")]
	[Cpp2IlInjected.Address(RVA = "0xF925B8", Offset = "0xF925B8", VA = "0xF925B8", Slot = "7")]
	public override string GetStoragePath()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60046E9")]
	[Cpp2IlInjected.Address(RVA = "0xF92654", Offset = "0xF92654", VA = "0xF92654")]
	public PathService()
	{
	}
}
