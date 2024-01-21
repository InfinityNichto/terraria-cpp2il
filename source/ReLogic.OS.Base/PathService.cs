using Cpp2IlInjected;

namespace ReLogic.OS.Base;

[Cpp2IlInjected.Token(Token = "0x2000732")]
internal abstract class PathService : IPathService
{
	[Cpp2IlInjected.Token(Token = "0x6004703")]
	[Cpp2IlInjected.Address(RVA = "0xF917BC", Offset = "0xF917BC", VA = "0xF917BC", Slot = "6")]
	public string ExpandPathVariables(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004704")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GetStoragePath();

	[Cpp2IlInjected.Token(Token = "0x6004705")]
	[Cpp2IlInjected.Address(RVA = "0xF917C8", Offset = "0xF917C8", VA = "0xF917C8", Slot = "5")]
	public string GetStoragePath(string subfolder)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004706")]
	[Cpp2IlInjected.Address(RVA = "0xF91864", Offset = "0xF91864", VA = "0xF91864")]
	protected PathService()
	{
	}
}
