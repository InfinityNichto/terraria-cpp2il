using Cpp2IlInjected;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x2000746")]
public enum AssetRequestMode
{
	[Cpp2IlInjected.Token(Token = "0x4007366")]
	DoNotLoad,
	[Cpp2IlInjected.Token(Token = "0x4007367")]
	ImmediateLoad,
	[Cpp2IlInjected.Token(Token = "0x4007368")]
	AsyncLoad
}
