using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000942")]
	public struct EntryIconDrawSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x400836B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public bool IsPortrait;

		[global::Cpp2ILInjected.Token(Token = "0x400836C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public bool IsHovered;

		[global::Cpp2ILInjected.Token(Token = "0x400836D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public Rectangle iconbox;
	}
}
