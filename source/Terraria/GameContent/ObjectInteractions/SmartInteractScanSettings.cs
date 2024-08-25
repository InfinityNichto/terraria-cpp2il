using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	[global::Cpp2ILInjected.Token(Token = "0x2000847")]
	public struct SmartInteractScanSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x4008143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Player player;

		[global::Cpp2ILInjected.Token(Token = "0x4008144")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public bool DemandOnlyZeroDistanceTargets;

		[global::Cpp2ILInjected.Token(Token = "0x4008145")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
		public bool FullInteraction;

		[global::Cpp2ILInjected.Token(Token = "0x4008146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Vector2 mousevec;

		[global::Cpp2ILInjected.Token(Token = "0x4008147")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int LX;

		[global::Cpp2ILInjected.Token(Token = "0x4008148")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int HX;

		[global::Cpp2ILInjected.Token(Token = "0x4008149")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int LY;

		[global::Cpp2ILInjected.Token(Token = "0x400814A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int HY;
	}
}
