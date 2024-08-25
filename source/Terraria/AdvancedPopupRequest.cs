using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x2000451")]
	public struct AdvancedPopupRequest
	{
		[global::Cpp2ILInjected.Token(Token = "0x400369E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string Text;

		[global::Cpp2ILInjected.Token(Token = "0x400369F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Color Color;

		[global::Cpp2ILInjected.Token(Token = "0x40036A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int DurationInFrames;

		[global::Cpp2ILInjected.Token(Token = "0x40036A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 Velocity;
	}
}
