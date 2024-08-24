using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using ReLogic.Text;
using Terraria;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Elements;
using Terraria.UI.Chat;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002C6 RID: 710
	[global::Cpp2ILInjected.Token(Token = "0x2000392")]
	public sealed class SpriteFont
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00025F2B File Offset: 0x0002412B
		[global::Cpp2ILInjected.Token(Token = "0x1700030F")]
		public SpriteFont.Glyph[] Glyphs
		{
			[global::Cpp2ILInjected.Token(Token = "0x600185B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC2B5C", Offset = "0xAC2B5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00025F2E File Offset: 0x0002412E
		[global::Cpp2ILInjected.Token(Token = "0x600185C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC2B64", Offset = "0xAC2B64", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SpriteFont()
		{
			throw null;
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00025F31 File Offset: 0x00024131
		[global::Cpp2ILInjected.Token(Token = "0x600185D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC2BE8", Offset = "0xAC2BE8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadSpriteFont", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SpriteFont))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SpriteFont(Texture2D[] textures, SpriteFont.Glyph[] glyphs, int lineSpacing, float spacing, char? defaultCharacter)
		{
			throw null;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00025F34 File Offset: 0x00024134
		[global::Cpp2ILInjected.Token(Token = "0x17000310")]
		public Texture2D[] Textures
		{
			[global::Cpp2ILInjected.Token(Token = "0x600185E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC2DE4", Offset = "0xAC2DE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00025F37 File Offset: 0x00024137
		[global::Cpp2ILInjected.Token(Token = "0x600185F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC2DEC", Offset = "0xAC2DEC", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, SpriteFont.Glyph>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer<char>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, SpriteFont.Glyph>), Member = "Add", MemberParameters = new object[]
		{
			typeof(char),
			typeof(SpriteFont.Glyph)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Dictionary<char, SpriteFont.Glyph> GetGlyphs()
		{
			throw null;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00025F3A File Offset: 0x0002413A
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x00025F3D File Offset: 0x0002413D
		[global::Cpp2ILInjected.Token(Token = "0x17000311")]
		public char? DefaultCharacter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001860")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC2F58", Offset = "0xAC2F58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001861")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC2D04", Offset = "0xAC2D04", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char?), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "TryGetGlyphIndex", MemberParameters = new object[]
			{
				typeof(char),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00025F40 File Offset: 0x00024140
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x00025F43 File Offset: 0x00024143
		[global::Cpp2ILInjected.Token(Token = "0x17000312")]
		public int LineSpacing
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001862")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC2FC8", Offset = "0xAC2FC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001863")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC2FD0", Offset = "0xAC2FD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00025F46 File Offset: 0x00024146
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x00025F49 File Offset: 0x00024149
		[global::Cpp2ILInjected.Token(Token = "0x17000313")]
		public float Spacing
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001864")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC2FD8", Offset = "0xAC2FD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001865")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC2FE0", Offset = "0xAC2FE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00025F4C File Offset: 0x0002414C
		[global::Cpp2ILInjected.Token(Token = "0x6001866")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC2FE8", Offset = "0xAC2FE8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 215)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		public Vector2 MeasureString(string text)
		{
			throw null;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00025F4F File Offset: 0x0002414F
		[global::Cpp2ILInjected.Token(Token = "0x6001867")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC33EC", Offset = "0xAC33EC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureMaxString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public int GetMaxCharacterIndex(string text, int startIndex, int endIndex, float scale, float maxWidth)
		{
			throw null;
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00025F52 File Offset: 0x00024152
		[global::Cpp2ILInjected.Token(Token = "0x6001868")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC37CC", Offset = "0xAC37CC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "ApplyMultiLineAlignment", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
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
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		public Vector2 MeasureString(string text, int startIndex, int endIndex)
		{
			throw null;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00025F55 File Offset: 0x00024155
		[global::Cpp2ILInjected.Token(Token = "0x6001869")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3810", Offset = "0xAC3810", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		public Vector2 MeasureString(StringBuilder text, int startIndex, int endIndex)
		{
			throw null;
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00025F58 File Offset: 0x00024158
		[global::Cpp2ILInjected.Token(Token = "0x600186A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3870", Offset = "0xAC3870", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
		{
			typeof(GUIControlsBanner.Action),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddMore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAlignmentOffset", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(float),
			typeof(LayoutCalculator.AnchorType)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAlignmentOffset", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(float),
			typeof(LayoutCalculator.AnchorType),
			typeof(ref Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawFPS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		public Vector2 MeasureString(StringBuilder text)
		{
			throw null;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00025F5B File Offset: 0x0002415B
		[global::Cpp2ILInjected.Token(Token = "0x600186B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3464", Offset = "0xAC3464", Length = "0x368")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "GetMaxCharacterIndex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "MeasureInlineMapping", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "MeasureInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void MeasureMaxString(ref SpriteFont.CharacterSource text, out int lastCharacter, float maxWidth, float scale)
		{
			throw null;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00025F5E File Offset: 0x0002415E
		[global::Cpp2ILInjected.Token(Token = "0x600186C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3040", Offset = "0xAC3040", Length = "0x3AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineRight", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineCentre", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "MeasureInlineMapping", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "MeasureInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "MeasureInline", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void MeasureString(ref SpriteFont.CharacterSource text, out Vector2 size)
		{
			throw null;
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00025F61 File Offset: 0x00024161
		[global::Cpp2ILInjected.Token(Token = "0x600186D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC2F60", Offset = "0xAC2F60", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "set_DefaultCharacter", MemberParameters = new object[] { typeof(char?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "HasCharacter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Rectangle),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<char, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool TryGetGlyphIndex(char c, out int index)
		{
			throw null;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00025F64 File Offset: 0x00024164
		[global::Cpp2ILInjected.Token(Token = "0x600186E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC39B4", Offset = "0xAC39B4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "TryGetGlyphIndex", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		public bool HasCharacter(char c)
		{
			throw null;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00025F67 File Offset: 0x00024167
		[global::Cpp2ILInjected.Token(Token = "0x600186F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC391C", Offset = "0xAC391C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineRight", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineCentre", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "MeasureMaxString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "GetCharacterMetrics", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(SpriteFont.Glyph))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "TryGetGlyphIndex", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal int GetGlyphIndexOrDefault(char c)
		{
			throw null;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00025F6A File Offset: 0x0002416A
		[global::Cpp2ILInjected.Token(Token = "0x6001870")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC39D0", Offset = "0xAC39D0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIText), Member = "InternalSetText", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		public string CreateWrappedText(string text, float maxWidth)
		{
			throw null;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00025F6D File Offset: 0x0002416D
		[global::Cpp2ILInjected.Token(Token = "0x6001871")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3A18", Offset = "0xAC3A18", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WrappedTextBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(float),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string CreateWrappedText(string text, float maxWidth, CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00025F70 File Offset: 0x00024170
		[global::Cpp2ILInjected.Token(Token = "0x6001872")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3AB0", Offset = "0xAC3AB0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.WrappedTextBuilder.NonBreakingText", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.WrappedTextBuilder.NonBreakingText", Member = "GetAsWrappedText", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		public SpriteFont.Glyph GetCharacterMetrics(char character)
		{
			throw null;
		}

		// Token: 0x04002064 RID: 8292
		[global::Cpp2ILInjected.Token(Token = "0x40026AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly SpriteFont.Glyph[] _glyphs;

		// Token: 0x04002065 RID: 8293
		[global::Cpp2ILInjected.Token(Token = "0x40026AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<char, int> _glyphIndex;

		// Token: 0x04002066 RID: 8294
		[global::Cpp2ILInjected.Token(Token = "0x40026AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private char? _defaultCharacter;

		// Token: 0x04002067 RID: 8295
		[global::Cpp2ILInjected.Token(Token = "0x40026B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _defaultGlyphIndex;

		// Token: 0x04002068 RID: 8296
		[global::Cpp2ILInjected.Token(Token = "0x40026B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Texture2D[] _textures;

		// Token: 0x04002069 RID: 8297
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40026B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int <LineSpacing>k__BackingField;

		// Token: 0x0400206A RID: 8298
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40026B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private float <Spacing>k__BackingField;

		// Token: 0x0200082B RID: 2091
		[global::Cpp2ILInjected.Token(Token = "0x2000393")]
		internal static class Errors
		{
			// Token: 0x04007E07 RID: 32263
			[global::Cpp2ILInjected.Token(Token = "0x40026B4")]
			public const string TextContainsUnresolvableCharacters = "Text contains characters that cannot be resolved by this SpriteFont.";

			// Token: 0x04007E08 RID: 32264
			[global::Cpp2ILInjected.Token(Token = "0x40026B5")]
			public const string UnresolvableCharacter = "Character cannot be resolved by this SpriteFont.";
		}

		// Token: 0x0200082C RID: 2092
		[global::Cpp2ILInjected.Token(Token = "0x2000394")]
		private class CharComparer : IEqualityComparer<char>
		{
			// Token: 0x06004943 RID: 18755 RVA: 0x0002EFE2 File Offset: 0x0002D1E2
			[global::Cpp2ILInjected.Token(Token = "0x6001873")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3AF8", Offset = "0xAC3AF8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Equals(char x, char y)
			{
				throw null;
			}

			// Token: 0x06004944 RID: 18756 RVA: 0x0002EFE5 File Offset: 0x0002D1E5
			[global::Cpp2ILInjected.Token(Token = "0x6001874")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3B08", Offset = "0xAC3B08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public int GetHashCode(char b)
			{
				throw null;
			}

			// Token: 0x06004945 RID: 18757 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
			[global::Cpp2ILInjected.Token(Token = "0x6001875")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3B10", Offset = "0xAC3B10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CharComparer()
			{
				throw null;
			}

			// Token: 0x06004946 RID: 18758 RVA: 0x0002EFEB File Offset: 0x0002D1EB
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001876")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3B18", Offset = "0xAC3B18", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static CharComparer()
			{
				throw null;
			}

			// Token: 0x04007E09 RID: 32265
			[global::Cpp2ILInjected.Token(Token = "0x40026B6")]
			public static readonly SpriteFont.CharComparer Default;
		}

		// Token: 0x0200082D RID: 2093
		[global::Cpp2ILInjected.Token(Token = "0x2000395")]
		public struct CharacterSource
		{
			// Token: 0x06004947 RID: 18759 RVA: 0x0002EFEE File Offset: 0x0002D1EE
			[global::Cpp2ILInjected.Token(Token = "0x6001877")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3028", Offset = "0xAC3028", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "ApplyMultiLineAlignment", MemberParameters = new object[]
			{
				typeof(String_Layout),
				typeof(string),
				typeof(ref int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "UpdateText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineRight", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineCentre", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			public CharacterSource(string s)
			{
				throw null;
			}

			// Token: 0x06004948 RID: 18760 RVA: 0x0002EFF1 File Offset: 0x0002D1F1
			[global::Cpp2ILInjected.Token(Token = "0x6001878")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3448", Offset = "0xAC3448", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(Vector2[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			public CharacterSource(string s, int startIndex, int endIndex)
			{
				throw null;
			}

			// Token: 0x06004949 RID: 18761 RVA: 0x0002EFF4 File Offset: 0x0002D1F4
			[global::Cpp2ILInjected.Token(Token = "0x6001879")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC38C0", Offset = "0xAC38C0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(StringBuilder),
				typeof(Vector2),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(StringBuilder),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
			public CharacterSource(StringBuilder builder)
			{
				throw null;
			}

			// Token: 0x0600494A RID: 18762 RVA: 0x0002EFF7 File Offset: 0x0002D1F7
			[global::Cpp2ILInjected.Token(Token = "0x600187A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3854", Offset = "0xAC3854", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(StringBuilder),
				typeof(int),
				typeof(int),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(Vector2[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(StringBuilder),
				typeof(int),
				typeof(int),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			public CharacterSource(StringBuilder builder, int startIndex, int endIndex)
			{
				throw null;
			}

			// Token: 0x1700084A RID: 2122
			[global::Cpp2ILInjected.Token(Token = "0x17000314")]
			public char this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x600187B")]
				[global::Cpp2ILInjected.Address(RVA = "0xAC38EC", Offset = "0xAC38EC", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 156)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
				get
				{
					throw null;
				}
			}

			// Token: 0x04007E0A RID: 32266
			[global::Cpp2ILInjected.Token(Token = "0x40026B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly string _string;

			// Token: 0x04007E0B RID: 32267
			[global::Cpp2ILInjected.Token(Token = "0x40026B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly int _stringOffset;

			// Token: 0x04007E0C RID: 32268
			[global::Cpp2ILInjected.Token(Token = "0x40026B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly StringBuilder _builder;

			// Token: 0x04007E0D RID: 32269
			[global::Cpp2ILInjected.Token(Token = "0x40026BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly int Length;
		}

		// Token: 0x0200082E RID: 2094
		[global::Cpp2ILInjected.Token(Token = "0x2000396")]
		public struct Glyph
		{
			// Token: 0x0600494C RID: 18764 RVA: 0x0002EFFD File Offset: 0x0002D1FD
			[global::Cpp2ILInjected.Token(Token = "0x600187C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3B74", Offset = "0xAC3B74", Length = "0x2BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600494D RID: 18765 RVA: 0x0002F000 File Offset: 0x0002D200
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600187D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3E30", Offset = "0xAC3E30", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			static Glyph()
			{
				throw null;
			}

			// Token: 0x04007E0E RID: 32270
			[global::Cpp2ILInjected.Token(Token = "0x40026BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public char Character;

			// Token: 0x04007E0F RID: 32271
			[global::Cpp2ILInjected.Token(Token = "0x40026BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public Rectangle BoundsInTexture;

			// Token: 0x04007E10 RID: 32272
			[global::Cpp2ILInjected.Token(Token = "0x40026BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public Rectangle Cropping;

			// Token: 0x04007E11 RID: 32273
			[global::Cpp2ILInjected.Token(Token = "0x40026BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public float LeftSideBearing;

			// Token: 0x04007E12 RID: 32274
			[global::Cpp2ILInjected.Token(Token = "0x40026BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float RightSideBearing;

			// Token: 0x04007E13 RID: 32275
			[global::Cpp2ILInjected.Token(Token = "0x40026C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public float Width;

			// Token: 0x04007E14 RID: 32276
			[global::Cpp2ILInjected.Token(Token = "0x40026C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public float WidthIncludingBearings;

			// Token: 0x04007E15 RID: 32277
			[global::Cpp2ILInjected.Token(Token = "0x40026C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public byte TexureIndex;

			// Token: 0x04007E16 RID: 32278
			[global::Cpp2ILInjected.Token(Token = "0x40026C3")]
			public static readonly SpriteFont.Glyph Empty;
		}

		// Token: 0x0200082F RID: 2095
		[global::Cpp2ILInjected.Token(Token = "0x2000397")]
		private struct CharacterRegion
		{
			// Token: 0x0600494E RID: 18766 RVA: 0x0002F003 File Offset: 0x0002D203
			[global::Cpp2ILInjected.Token(Token = "0x600187E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3E34", Offset = "0xAC3E34", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public CharacterRegion(char start, int startIndex)
			{
				throw null;
			}

			// Token: 0x04007E17 RID: 32279
			[global::Cpp2ILInjected.Token(Token = "0x40026C4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public char Start;

			// Token: 0x04007E18 RID: 32280
			[global::Cpp2ILInjected.Token(Token = "0x40026C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			public char End;

			// Token: 0x04007E19 RID: 32281
			[global::Cpp2ILInjected.Token(Token = "0x40026C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int StartIndex;
		}
	}
}
