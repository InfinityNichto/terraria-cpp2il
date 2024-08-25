using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.GameContent.Personalities
{
	[global::Cpp2ILInjected.Token(Token = "0x200083F")]
	public struct HelperInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x4008136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Player player;

		[global::Cpp2ILInjected.Token(Token = "0x4008137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public NPC npc;

		[global::Cpp2ILInjected.Token(Token = "0x4008138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<NPC> NearbyNPCs;

		[global::Cpp2ILInjected.Token(Token = "0x4008139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool[] nearbyNPCsByType;
	}
}
