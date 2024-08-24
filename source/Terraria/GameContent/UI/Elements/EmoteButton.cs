using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Reflection;
using Terraria.Audio;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006B4 RID: 1716
	[global::Cpp2ILInjected.Token(Token = "0x2000A8E")]
	public class EmoteButton : UIElement
	{
		// Token: 0x06004398 RID: 17304 RVA: 0x0002E175 File Offset: 0x0002C375
		[global::Cpp2ILInjected.Token(Token = "0x6004FD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x901F10", Offset = "0x901F10", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmotesGroupListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteButton), Member = "GetFrame", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public EmoteButton(int emoteIndex)
		{
			throw null;
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x0002E178 File Offset: 0x0002C378
		[global::Cpp2ILInjected.Token(Token = "0x6004FD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x90216C", Offset = "0x90216C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Rectangle GetFrame()
		{
			throw null;
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x0002E17B File Offset: 0x0002C37B
		[global::Cpp2ILInjected.Token(Token = "0x6004FD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x902244", Offset = "0x902244", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void UpdateFrame()
		{
			throw null;
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x0002E17E File Offset: 0x0002C37E
		[global::Cpp2ILInjected.Token(Token = "0x6004FD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x90225C", Offset = "0x90225C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x0002E181 File Offset: 0x0002C381
		[global::Cpp2ILInjected.Token(Token = "0x6004FD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x902278", Offset = "0x902278", Length = "0x470")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteButton), Member = "GetFrame", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x0002E184 File Offset: 0x0002C384
		[global::Cpp2ILInjected.Token(Token = "0x6004FD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9026E8", Offset = "0x9026E8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x0002E187 File Offset: 0x0002C387
		[global::Cpp2ILInjected.Token(Token = "0x6004FD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x902730", Offset = "0x902730", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x0002E18A File Offset: 0x0002C38A
		[global::Cpp2ILInjected.Token(Token = "0x6004FD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x90274C", Offset = "0x90274C", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUIAnchor), Member = ".ctor", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteBubble), Member = "NewBubble", MemberParameters = new object[]
		{
			typeof(int),
			typeof(WorldUIAnchor),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteBubble), Member = "CheckForNPCsToReactToEmoteBubble", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void LeftClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x04006F84 RID: 28548
		[global::Cpp2ILInjected.Token(Token = "0x40088AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _texture;

		// Token: 0x04006F85 RID: 28549
		[global::Cpp2ILInjected.Token(Token = "0x40088AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Asset<Texture2D> _textureBorder;

		// Token: 0x04006F86 RID: 28550
		[global::Cpp2ILInjected.Token(Token = "0x40088AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private int _emoteIndex;

		// Token: 0x04006F87 RID: 28551
		[global::Cpp2ILInjected.Token(Token = "0x40088AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		private bool _hovered;

		// Token: 0x04006F88 RID: 28552
		[global::Cpp2ILInjected.Token(Token = "0x40088B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private int _frameCounter;
	}
}
