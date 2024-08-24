using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x020005A1 RID: 1441
	[global::Cpp2ILInjected.Token(Token = "0x200083F")]
	public struct HelperInfo
	{
		// Token: 0x04006B39 RID: 27449
		[global::Cpp2ILInjected.Token(Token = "0x4008136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Player player;

		// Token: 0x04006B3A RID: 27450
		[global::Cpp2ILInjected.Token(Token = "0x4008137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public NPC npc;

		// Token: 0x04006B3B RID: 27451
		[global::Cpp2ILInjected.Token(Token = "0x4008138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<NPC> NearbyNPCs;

		// Token: 0x04006B3C RID: 27452
		[global::Cpp2ILInjected.Token(Token = "0x4008139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool[] nearbyNPCsByType;
	}
}
