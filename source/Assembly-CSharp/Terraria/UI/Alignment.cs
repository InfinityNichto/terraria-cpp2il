using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Map;

namespace Terraria.UI
{
	// Token: 0x020004BC RID: 1212
	[global::Cpp2ILInjected.Token(Token = "0x20006DA")]
	public struct Alignment
	{
		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600356F RID: 13679 RVA: 0x0002B8D4 File Offset: 0x00029AD4
		[global::Cpp2ILInjected.Token(Token = "0x17000756")]
		public Vector2 OffsetMultiplier
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003AF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1472F68", Offset = "0x1472F68", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(SpriteFrame),
				typeof(Alignment)
			}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Color),
				typeof(SpriteFrame),
				typeof(float),
				typeof(float),
				typeof(Alignment)
			}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x0002B8D7 File Offset: 0x00029AD7
		[global::Cpp2ILInjected.Token(Token = "0x6003AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1472F8C", Offset = "0x1472F8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private Alignment(float horizontal, float vertical)
		{
			throw null;
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x0002B8DA File Offset: 0x00029ADA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003AF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1472F94", Offset = "0x1472F94", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Alignment()
		{
			throw null;
		}

		// Token: 0x04006678 RID: 26232
		[global::Cpp2ILInjected.Token(Token = "0x4007AD1")]
		public static readonly Alignment TopLeft;

		// Token: 0x04006679 RID: 26233
		[global::Cpp2ILInjected.Token(Token = "0x4007AD2")]
		public static readonly Alignment Top;

		// Token: 0x0400667A RID: 26234
		[global::Cpp2ILInjected.Token(Token = "0x4007AD3")]
		public static readonly Alignment TopRight;

		// Token: 0x0400667B RID: 26235
		[global::Cpp2ILInjected.Token(Token = "0x4007AD4")]
		public static readonly Alignment Left;

		// Token: 0x0400667C RID: 26236
		[global::Cpp2ILInjected.Token(Token = "0x4007AD5")]
		public static readonly Alignment Center;

		// Token: 0x0400667D RID: 26237
		[global::Cpp2ILInjected.Token(Token = "0x4007AD6")]
		public static readonly Alignment Right;

		// Token: 0x0400667E RID: 26238
		[global::Cpp2ILInjected.Token(Token = "0x4007AD7")]
		public static readonly Alignment BottomLeft;

		// Token: 0x0400667F RID: 26239
		[global::Cpp2ILInjected.Token(Token = "0x4007AD8")]
		public static readonly Alignment Bottom;

		// Token: 0x04006680 RID: 26240
		[global::Cpp2ILInjected.Token(Token = "0x4007AD9")]
		public static readonly Alignment BottomRight;

		// Token: 0x04006681 RID: 26241
		[global::Cpp2ILInjected.Token(Token = "0x4007ADA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly float VerticalOffsetMultiplier;

		// Token: 0x04006682 RID: 26242
		[global::Cpp2ILInjected.Token(Token = "0x4007ADB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly float HorizontalOffsetMultiplier;
	}
}
