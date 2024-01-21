using Cpp2IlInjected;
using ReLogic.OS.Base;

namespace ReLogic.OS.Windows;

[Cpp2IlInjected.Token(Token = "0x2000728")]
internal class PathService : ReLogic.OS.Base.PathService
{
	[Cpp2IlInjected.Token(Token = "0x60046DA")]
	[Cpp2IlInjected.Address(RVA = "0xF92688", Offset = "0xF92688", VA = "0xF92688", Slot = "7")]
	public override string GetStoragePath()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60046DB")]
	[Cpp2IlInjected.Address(RVA = "0xF92720", Offset = "0xF92720", VA = "0xF92720")]
	public PathService()
	{
	}
}
