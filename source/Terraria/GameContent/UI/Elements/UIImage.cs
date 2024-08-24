using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006D5 RID: 1749
	[global::Cpp2ILInjected.Token(Token = "0x2000AB9")]
	public class UIImage : UIElement
	{
		// Token: 0x06004491 RID: 17553 RVA: 0x0002E454 File Offset: 0x0002C654
		[global::Cpp2ILInjected.Token(Token = "0x60050E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x929BAC", Offset = "0x929BAC", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCPortraitInfoElement), Member = "CreateStarsContainer", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCStatsReportInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "AddIndication", MemberParameters = new object[]
		{
			typeof(UIPanel),
			typeof(float),
			typeof(string),
			typeof(string),
			typeof(UIElement.ElementEvent),
			typeof(UIElement.MouseEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Achievement),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DropRateInfo),
			typeof(BestiaryUICollectionInfo),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryNPCEntryPortrait), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(Asset<Texture2D>),
			typeof(Color),
			typeof(List<IBestiaryBackgroundOverlayAndColorProvider>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSymetricalCogsPair", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(Vector2),
			typeof(string),
			typeof(List<UIImage>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public UIImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x0002E457 File Offset: 0x0002C657
		[global::Cpp2ILInjected.Token(Token = "0x60050E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x929D24", Offset = "0x929D24", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x0002E45A File Offset: 0x0002C65A
		[global::Cpp2ILInjected.Token(Token = "0x60050E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x929DC8", Offset = "0x929DC8", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0400705B RID: 28763
		[global::Cpp2ILInjected.Token(Token = "0x40089A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400705C RID: 28764
		[global::Cpp2ILInjected.Token(Token = "0x40089A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public float ImageScale;

		// Token: 0x0400705D RID: 28765
		[global::Cpp2ILInjected.Token(Token = "0x40089A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		public float Rotation;

		// Token: 0x0400705E RID: 28766
		[global::Cpp2ILInjected.Token(Token = "0x40089A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public bool ScaleToFit;

		// Token: 0x0400705F RID: 28767
		[global::Cpp2ILInjected.Token(Token = "0x40089A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
		public Color Color;

		// Token: 0x04007060 RID: 28768
		[global::Cpp2ILInjected.Token(Token = "0x40089A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public Vector2 NormalizedOrigin;

		// Token: 0x04007061 RID: 28769
		[global::Cpp2ILInjected.Token(Token = "0x40089A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public bool RemoveFloatingPointsFromDrawPosition;
	}
}
