using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200033E")]
public enum PlayerSpawnContext
{
	[Cpp2IlInjected.Token(Token = "0x4002ED3")]
	ReviveFromDeath,
	[Cpp2IlInjected.Token(Token = "0x4002ED4")]
	SpawningIntoWorld,
	[Cpp2IlInjected.Token(Token = "0x4002ED5")]
	RecallFromItem
}
