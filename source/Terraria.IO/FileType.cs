using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003C7")]
public enum FileType : byte
{
	[Cpp2IlInjected.Token(Token = "0x4003289")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400328A")]
	Map,
	[Cpp2IlInjected.Token(Token = "0x400328B")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400328C")]
	Player
}
