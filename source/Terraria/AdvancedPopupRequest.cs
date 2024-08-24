using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria
{
	// Token: 0x0200033D RID: 829
	[global::Cpp2ILInjected.Token(Token = "0x2000451")]
	public struct AdvancedPopupRequest
	{
		// Token: 0x04002ED9 RID: 11993
		[global::Cpp2ILInjected.Token(Token = "0x400369E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string Text;

		// Token: 0x04002EDA RID: 11994
		[global::Cpp2ILInjected.Token(Token = "0x400369F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Color Color;

		// Token: 0x04002EDB RID: 11995
		[global::Cpp2ILInjected.Token(Token = "0x40036A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int DurationInFrames;

		// Token: 0x04002EDC RID: 11996
		[global::Cpp2ILInjected.Token(Token = "0x40036A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 Velocity;
	}
}
