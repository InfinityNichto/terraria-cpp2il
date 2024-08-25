using System;
using Cpp2ILInjected;

namespace Terraria.GameContent
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20007C6")]
	public enum GameNotificationType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4007E46")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4007E47")]
		Damage = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4007E48")]
		SpawnOrDeath = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4007E49")]
		WorldGen = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4007E4A")]
		All = 7
	}
}
