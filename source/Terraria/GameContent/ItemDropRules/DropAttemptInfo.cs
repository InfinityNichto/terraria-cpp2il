using System;
using Cpp2ILInjected;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005C1 RID: 1473
	[global::Cpp2ILInjected.Token(Token = "0x200086D")]
	public struct DropAttemptInfo
	{
		// Token: 0x04006B87 RID: 27527
		[global::Cpp2ILInjected.Token(Token = "0x40081A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public NPC npc;

		// Token: 0x04006B88 RID: 27528
		[global::Cpp2ILInjected.Token(Token = "0x40081AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Player player;

		// Token: 0x04006B89 RID: 27529
		[global::Cpp2ILInjected.Token(Token = "0x40081AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public UnifiedRandom rng;

		// Token: 0x04006B8A RID: 27530
		[global::Cpp2ILInjected.Token(Token = "0x40081AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool IsInSimulation;

		// Token: 0x04006B8B RID: 27531
		[global::Cpp2ILInjected.Token(Token = "0x40081AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool IsExpertMode;

		// Token: 0x04006B8C RID: 27532
		[global::Cpp2ILInjected.Token(Token = "0x40081AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		public bool IsMasterMode;
	}
}
