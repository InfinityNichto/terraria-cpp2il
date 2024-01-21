using Cpp2IlInjected;

namespace ReLogic.OS;

[Cpp2IlInjected.Token(Token = "0x2000725")]
public interface IPathService
{
	[Cpp2IlInjected.Token(Token = "0x60046D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GetStoragePath();

	[Cpp2IlInjected.Token(Token = "0x60046D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GetStoragePath(string subfolder);

	[Cpp2IlInjected.Token(Token = "0x60046D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string ExpandPathVariables(string path);
}
