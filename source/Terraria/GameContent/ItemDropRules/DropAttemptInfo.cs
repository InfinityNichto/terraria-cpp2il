using System;
using Cpp2ILInjected;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x200086D")]
	public struct DropAttemptInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x40081A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public NPC npc;

		[global::Cpp2ILInjected.Token(Token = "0x40081AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Player player;

		[global::Cpp2ILInjected.Token(Token = "0x40081AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public UnifiedRandom rng;

		[global::Cpp2ILInjected.Token(Token = "0x40081AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool IsInSimulation;

		[global::Cpp2ILInjected.Token(Token = "0x40081AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool IsExpertMode;

		[global::Cpp2ILInjected.Token(Token = "0x40081AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		public bool IsMasterMode;
	}
}
