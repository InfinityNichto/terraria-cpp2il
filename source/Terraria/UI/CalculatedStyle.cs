using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.GameContent.UI.Elements;

namespace Terraria.UI
{
	// Token: 0x020004BD RID: 1213
	[global::Cpp2ILInjected.Token(Token = "0x20006DB")]
	public struct CalculatedStyle
	{
		// Token: 0x06003572 RID: 13682 RVA: 0x0002B8DD File Offset: 0x00029ADD
		[global::Cpp2ILInjected.Token(Token = "0x6003AF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1473058", Offset = "0x1473058", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "GetDimensions", ReturnType = typeof(CalculatedStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public CalculatedStyle(float x, float y, float width, float height)
		{
			throw null;
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x0002B8E0 File Offset: 0x00029AE0
		[global::Cpp2ILInjected.Token(Token = "0x6003AF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1473064", Offset = "0x1473064", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Rectangle ToRectangle()
		{
			throw null;
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x0002B8E3 File Offset: 0x00029AE3
		[global::Cpp2ILInjected.Token(Token = "0x6003AF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x14730D0", Offset = "0x14730D0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SnapPoint), Member = "Calculate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "DrawDebugHitbox", MemberParameters = new object[]
		{
			typeof(BasicDebugDrawer),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoLine<>), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredImageButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "GetSnapPoints", ReturnType = typeof(List<SnapPoint>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHorizontalSeparator), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIImage), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIImageButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIImageFramed), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIList.UIInnerList", Member = "DrawChildren", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextPanel<>), Member = "DrawText", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector2 Position()
		{
			throw null;
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x0002B8E6 File Offset: 0x00029AE6
		[global::Cpp2ILInjected.Token(Token = "0x6003AF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14730F4", Offset = "0x14730F4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryIcon), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemSlot), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemIcon), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector2 Center()
		{
			throw null;
		}

		// Token: 0x04006683 RID: 26243
		[global::Cpp2ILInjected.Token(Token = "0x4007ADC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float X;

		// Token: 0x04006684 RID: 26244
		[global::Cpp2ILInjected.Token(Token = "0x4007ADD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float Y;

		// Token: 0x04006685 RID: 26245
		[global::Cpp2ILInjected.Token(Token = "0x4007ADE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float Width;

		// Token: 0x04006686 RID: 26246
		[global::Cpp2ILInjected.Token(Token = "0x4007ADF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float Height;
	}
}
