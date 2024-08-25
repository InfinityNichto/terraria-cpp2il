using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.GameContent.UI.Chat;

namespace Terraria.UI.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x2000730")]
	public class TextSnippet
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003CE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498784", Offset = "0x1498784", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsAxisTagHandler.ControlsAxisSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(GUIControllerInputButton.AxisControl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsAxisTagHandler), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ControlsButtonTagHandler.ControlsButtonSnippet", Member = ".ctor", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsKeyboardTagHandler.ControlsKeyboardSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsKeyboardTagHandler), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ControlsTouchTagHandler.ControlsTouchSnippet", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsTouchTagHandler), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "UpdateText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ColorTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Chat.GlyphTagHandler.GlyphSnippet", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlyphTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Chat.ItemTagHandler.ItemSnippet", Member = ".ctor", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlainTagHandler.PlainSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlainTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TextSnippet(string text = "")
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x149457C", Offset = "0x149457C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(TextSnippet[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Chat.AchievementTagHandler.AchievementSnippet", Member = ".ctor", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlainTagHandler.PlainSnippet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TextSnippet(string text, Color color, float scale = 1f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498804", Offset = "0x1498804", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498808", Offset = "0x1498808", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnHover()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x149880C", Offset = "0x149880C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnClick()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498810", Offset = "0x1498810", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "WaveColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Color GetVisibleColor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498870", Offset = "0x1498870", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, Vector2 position = default(Vector2), Color color = default(Color), float scale = 1f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498904", Offset = "0x1498904", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual TextSnippet CopyMorph(string newText)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x149898C", Offset = "0x149898C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		public virtual float GetStringLength(SpriteFont font)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x14989B8", Offset = "0x14989B8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007BED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Text;

		[global::Cpp2ILInjected.Token(Token = "0x4007BEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string TextOriginal;

		[global::Cpp2ILInjected.Token(Token = "0x4007BEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Color Color;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float Scale;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool CheckForHover;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		public bool DeleteWhole;
	}
}
