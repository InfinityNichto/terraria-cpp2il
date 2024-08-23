using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Animations
{
	// Token: 0x0200064A RID: 1610
	[global::Cpp2ILInjected.Token(Token = "0x2000992")]
	public struct GameAnimationSegment
	{
		// Token: 0x04006C95 RID: 27797
		[global::Cpp2ILInjected.Token(Token = "0x4008400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public SpriteBatch SpriteBatch;

		// Token: 0x04006C96 RID: 27798
		[global::Cpp2ILInjected.Token(Token = "0x4008401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector2 AnchorPositionOnScreen;

		// Token: 0x04006C97 RID: 27799
		[global::Cpp2ILInjected.Token(Token = "0x4008402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int TimeInAnimation;

		// Token: 0x04006C98 RID: 27800
		[global::Cpp2ILInjected.Token(Token = "0x4008403")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float DisplayOpacity;
	}
}
