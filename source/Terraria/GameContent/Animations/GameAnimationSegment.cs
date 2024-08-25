using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Animations
{
	[global::Cpp2ILInjected.Token(Token = "0x2000992")]
	public struct GameAnimationSegment
	{
		[global::Cpp2ILInjected.Token(Token = "0x4008400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public SpriteBatch SpriteBatch;

		[global::Cpp2ILInjected.Token(Token = "0x4008401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector2 AnchorPositionOnScreen;

		[global::Cpp2ILInjected.Token(Token = "0x4008402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int TimeInAnimation;

		[global::Cpp2ILInjected.Token(Token = "0x4008403")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float DisplayOpacity;
	}
}
