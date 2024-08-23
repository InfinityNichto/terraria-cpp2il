using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005A8 RID: 1448
	[global::Cpp2ILInjected.Token(Token = "0x2000847")]
	public struct SmartInteractScanSettings
	{
		// Token: 0x04006B42 RID: 27458
		[global::Cpp2ILInjected.Token(Token = "0x4008143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Player player;

		// Token: 0x04006B43 RID: 27459
		[global::Cpp2ILInjected.Token(Token = "0x4008144")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public bool DemandOnlyZeroDistanceTargets;

		// Token: 0x04006B44 RID: 27460
		[global::Cpp2ILInjected.Token(Token = "0x4008145")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
		public bool FullInteraction;

		// Token: 0x04006B45 RID: 27461
		[global::Cpp2ILInjected.Token(Token = "0x4008146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Vector2 mousevec;

		// Token: 0x04006B46 RID: 27462
		[global::Cpp2ILInjected.Token(Token = "0x4008147")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int LX;

		// Token: 0x04006B47 RID: 27463
		[global::Cpp2ILInjected.Token(Token = "0x4008148")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int HX;

		// Token: 0x04006B48 RID: 27464
		[global::Cpp2ILInjected.Token(Token = "0x4008149")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int LY;

		// Token: 0x04006B49 RID: 27465
		[global::Cpp2ILInjected.Token(Token = "0x400814A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int HY;
	}
}
