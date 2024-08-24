using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x020006B0 RID: 1712
	[global::Cpp2ILInjected.Token(Token = "0x2000A88")]
	public struct ResourceDrawSettings
	{
		// Token: 0x06004376 RID: 17270 RVA: 0x0002E10F File Offset: 0x0002C30F
		[global::Cpp2ILInjected.Token(Token = "0x6004FA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x90002C", Offset = "0x90002C", Length = "0x41C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "DrawLifeBar", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "DrawManaBar", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void Draw(SpriteBatch spriteBatch, ref bool isHovered)
		{
			throw null;
		}

		// Token: 0x04006F6C RID: 28524
		[global::Cpp2ILInjected.Token(Token = "0x4008890")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector2 TopLeftAnchor;

		// Token: 0x04006F6D RID: 28525
		[global::Cpp2ILInjected.Token(Token = "0x4008891")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int ElementCount;

		// Token: 0x04006F6E RID: 28526
		[global::Cpp2ILInjected.Token(Token = "0x4008892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int ElementIndexOffset;

		// Token: 0x04006F6F RID: 28527
		[global::Cpp2ILInjected.Token(Token = "0x4008893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ResourceDrawSettings.TextureGetter GetTextureMethod;

		// Token: 0x04006F70 RID: 28528
		[global::Cpp2ILInjected.Token(Token = "0x4008894")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Vector2 OffsetPerDraw;

		// Token: 0x04006F71 RID: 28529
		[global::Cpp2ILInjected.Token(Token = "0x4008895")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Vector2 OffsetPerDrawByTexturePercentile;

		// Token: 0x04006F72 RID: 28530
		[global::Cpp2ILInjected.Token(Token = "0x4008896")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Vector2 OffsetSpriteAnchor;

		// Token: 0x04006F73 RID: 28531
		[global::Cpp2ILInjected.Token(Token = "0x4008897")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Vector2 OffsetSpriteAnchorByTexturePercentile;

		// Token: 0x02000AB4 RID: 2740
		// (Invoke) Token: 0x0600525E RID: 21086
		[global::Cpp2ILInjected.Token(Token = "0x2000A89")]
		public delegate void TextureGetter(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> texture, out Vector2 drawOffset, out float drawScale, out Rectangle? sourceRect);
	}
}
