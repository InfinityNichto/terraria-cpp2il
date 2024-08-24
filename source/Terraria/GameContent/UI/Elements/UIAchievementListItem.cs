using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006B9 RID: 1721
	[global::Cpp2ILInjected.Token(Token = "0x2000A93")]
	public class UIAchievementListItem : UIPanel
	{
		// Token: 0x060043B1 RID: 17329 RVA: 0x0002E1BA File Offset: 0x0002C3BA
		[global::Cpp2ILInjected.Token(Token = "0x6004FEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x9031FC", Offset = "0x9031FC", Length = "0x71C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetIconIndex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIAchievementListItem), Member = "UpdateIconFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public UIAchievementListItem(Achievement achievement, bool largeForOtherLanguages)
		{
			throw null;
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x0002E1BD File Offset: 0x0002C3BD
		[global::Cpp2ILInjected.Token(Token = "0x6004FEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x903950", Offset = "0x903950", Length = "0xE30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIAchievementListItem), Member = "UpdateIconFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIAchievementListItem), Member = "GetTrackerValues", ReturnType = typeof(Tuple<decimal, decimal>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "get_ActiveCulture", ReturnType = typeof(GameCulture))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "CreateWrappedText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(CultureInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIAchievementListItem), Member = "DrawPanelTop", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIAchievementListItem), Member = "DrawPanelBottom", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGBA", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIAchievementListItem), Member = "DrawProgressBar", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(Color),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 59)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x0002E1C0 File Offset: 0x0002C3C0
		[global::Cpp2ILInjected.Token(Token = "0x6004FED")]
		[global::Cpp2ILInjected.Address(RVA = "0x903918", Offset = "0x903918", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Achievement),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = "SetFrame", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		private void UpdateIconFrame()
		{
			throw null;
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x0002E1C3 File Offset: 0x0002C3C3
		[global::Cpp2ILInjected.Token(Token = "0x6004FEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x904A40", Offset = "0x904A40", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void DrawPanelTop(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			throw null;
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x0002E1C6 File Offset: 0x0002C3C6
		[global::Cpp2ILInjected.Token(Token = "0x6004FEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x904D44", Offset = "0x904D44", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void DrawPanelBottom(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			throw null;
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x0002E1C9 File Offset: 0x0002C3C9
		[global::Cpp2ILInjected.Token(Token = "0x6004FF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x9058FC", Offset = "0x9058FC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x0002E1CC File Offset: 0x0002C3CC
		[global::Cpp2ILInjected.Token(Token = "0x6004FF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x905964", Offset = "0x905964", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x0002E1CF File Offset: 0x0002C3CF
		[global::Cpp2ILInjected.Token(Token = "0x6004FF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x905A48", Offset = "0x905A48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Achievement GetAchievement()
		{
			throw null;
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x0002E1D2 File Offset: 0x0002C3D2
		[global::Cpp2ILInjected.Token(Token = "0x6004FF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x904780", Offset = "0x904780", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "get_HasTracker", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new object[] { "T1", "T2" }, MemberParameters = new object[] { "T1", "T2" }, ReturnType = "System.Tuple`2<T1, T2>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private Tuple<decimal, decimal> GetTrackerValues()
		{
			throw null;
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x0002E1D5 File Offset: 0x0002C3D5
		[global::Cpp2ILInjected.Token(Token = "0x6004FF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x905048", Offset = "0x905048", Length = "0x8B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void DrawProgressBar(SpriteBatch spriteBatch, float progress, Vector2 spot, float Width = 169f, Color BackColor = default(Color), Color FillingColor = default(Color), Color BlipColor = default(Color))
		{
			throw null;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x0002E1D8 File Offset: 0x0002C3D8
		[global::Cpp2ILInjected.Token(Token = "0x6004FF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x905A50", Offset = "0x905A50", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x04006FA6 RID: 28582
		[global::Cpp2ILInjected.Token(Token = "0x40088CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private Achievement _achievement;

		// Token: 0x04006FA7 RID: 28583
		[global::Cpp2ILInjected.Token(Token = "0x40088CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private UIImageFramed _achievementIcon;

		// Token: 0x04006FA8 RID: 28584
		[global::Cpp2ILInjected.Token(Token = "0x40088D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private UIImage _achievementIconBorders;

		// Token: 0x04006FA9 RID: 28585
		[global::Cpp2ILInjected.Token(Token = "0x40088D1")]
		private const int _iconSize = 64;

		// Token: 0x04006FAA RID: 28586
		[global::Cpp2ILInjected.Token(Token = "0x40088D2")]
		private const int _iconSizeWithSpace = 66;

		// Token: 0x04006FAB RID: 28587
		[global::Cpp2ILInjected.Token(Token = "0x40088D3")]
		private const int _iconsPerRow = 8;

		// Token: 0x04006FAC RID: 28588
		[global::Cpp2ILInjected.Token(Token = "0x40088D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private int _iconIndex;

		// Token: 0x04006FAD RID: 28589
		[global::Cpp2ILInjected.Token(Token = "0x40088D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x184")]
		private Rectangle _iconFrame;

		// Token: 0x04006FAE RID: 28590
		[global::Cpp2ILInjected.Token(Token = "0x40088D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x194")]
		private Rectangle _iconFrameUnlocked;

		// Token: 0x04006FAF RID: 28591
		[global::Cpp2ILInjected.Token(Token = "0x40088D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
		private Rectangle _iconFrameLocked;

		// Token: 0x04006FB0 RID: 28592
		[global::Cpp2ILInjected.Token(Token = "0x40088D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private Asset<Texture2D> _innerPanelTopTexture;

		// Token: 0x04006FB1 RID: 28593
		[global::Cpp2ILInjected.Token(Token = "0x40088D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		private Asset<Texture2D> _innerPanelBottomTexture;

		// Token: 0x04006FB2 RID: 28594
		[global::Cpp2ILInjected.Token(Token = "0x40088DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		private Asset<Texture2D> _categoryTexture;

		// Token: 0x04006FB3 RID: 28595
		[global::Cpp2ILInjected.Token(Token = "0x40088DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		private bool _locked;

		// Token: 0x04006FB4 RID: 28596
		[global::Cpp2ILInjected.Token(Token = "0x40088DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D1")]
		private bool _large;
	}
}
