using System;
using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200054D")]
[Flags]
public enum GameNotificationType
{
	[Cpp2IlInjected.Token(Token = "0x40068E2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40068E3")]
	Damage = 1,
	[Cpp2IlInjected.Token(Token = "0x40068E4")]
	SpawnOrDeath = 2,
	[Cpp2IlInjected.Token(Token = "0x40068E5")]
	WorldGen = 4,
	[Cpp2IlInjected.Token(Token = "0x40068E6")]
	All = 7
}
