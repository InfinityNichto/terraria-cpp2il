using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x020006F0 RID: 1776
	[global::Cpp2ILInjected.Token(Token = "0x2000ADC")]
	public class LegacyChatMonitor : IChatMonitor
	{
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x0002E661 File Offset: 0x0002C861
		[global::Cpp2ILInjected.Token(Token = "0x170008DD")]
		public int TextMaxLengthForScreen
		{
			[global::Cpp2ILInjected.Token(Token = "0x60051B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x9329B8", Offset = "0x9329B8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewTextMultiline", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(Color),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x0002E664 File Offset: 0x0002C864
		[global::Cpp2ILInjected.Token(Token = "0x60051B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x932A10", Offset = "0x932A10", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnResolutionChange()
		{
			throw null;
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x0002E667 File Offset: 0x0002C867
		[global::Cpp2ILInjected.Token(Token = "0x60051B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x932A14", Offset = "0x932A14", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public LegacyChatMonitor()
		{
			throw null;
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x0002E66A File Offset: 0x0002C86A
		[global::Cpp2ILInjected.Token(Token = "0x60051B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x932B0C", Offset = "0x932B0C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x0002E66D File Offset: 0x0002C86D
		[global::Cpp2ILInjected.Token(Token = "0x60051BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x932BB8", Offset = "0x932BB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ResetOffset()
		{
			throw null;
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x0002E670 File Offset: 0x0002C870
		[global::Cpp2ILInjected.Token(Token = "0x60051BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x932BC0", Offset = "0x932BC0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = "UpdateTimeLeft", ReturnType = typeof(void))]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x0002E673 File Offset: 0x0002C873
		[global::Cpp2ILInjected.Token(Token = "0x60051BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x932C0C", Offset = "0x932C0C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Offset(int linesOffset)
		{
			throw null;
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x0002E676 File Offset: 0x0002C876
		[global::Cpp2ILInjected.Token(Token = "0x60051BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x932DA8", Offset = "0x932DA8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyChatMonitor), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
			throw null;
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x0002E679 File Offset: 0x0002C879
		[global::Cpp2ILInjected.Token(Token = "0x60051BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x932F98", Offset = "0x932F98", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "TrimIntoMultipleLines", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = "Copy", MemberParameters = new object[] { typeof(ChatLine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(TextSnippet[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyChatMonitor), Member = "TrimIntoMultipleLines", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void NewTextInternal(string newText, byte R = 255, byte G = 255, byte B = 255, bool force = false)
		{
			throw null;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x0002E67C File Offset: 0x0002C87C
		[global::Cpp2ILInjected.Token(Token = "0x60051BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x93317C", Offset = "0x93317C", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewTextInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyChatMonitor), Member = "NewTextInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string TrimIntoMultipleLines(byte R, byte G, byte B, int maxTextSize, string oldText)
		{
			throw null;
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x0002E67F File Offset: 0x0002C87F
		[global::Cpp2ILInjected.Token(Token = "0x60051C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x932DF8", Offset = "0x932DF8", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyChatMonitor), Member = "get_TextMaxLengthForScreen", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "WordwrapStringSmart", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(SpriteFont),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(List<List<TextSnippet>>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyChatMonitor), Member = "NewText", MemberParameters = new object[] { typeof(List<TextSnippet>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void NewTextMultiline(string text, bool force = false, Color c = default(Color), int WidthLimit = -1)
		{
			throw null;
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x0002E682 File Offset: 0x0002C882
		[global::Cpp2ILInjected.Token(Token = "0x60051C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x933334", Offset = "0x933334", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = "Copy", MemberParameters = new object[] { typeof(ChatLine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void NewText(List<TextSnippet> snippets)
		{
			throw null;
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x0002E685 File Offset: 0x0002C885
		[global::Cpp2ILInjected.Token(Token = "0x60051C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x933438", Offset = "0x933438", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void DrawChat(bool drawingPlayerChat)
		{
			throw null;
		}

		// Token: 0x040070E6 RID: 28902
		[global::Cpp2ILInjected.Token(Token = "0x4008A37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int numChatLines;

		// Token: 0x040070E7 RID: 28903
		[global::Cpp2ILInjected.Token(Token = "0x4008A38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ChatLine[] chatLine;

		// Token: 0x040070E8 RID: 28904
		[global::Cpp2ILInjected.Token(Token = "0x4008A39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int chatLength;

		// Token: 0x040070E9 RID: 28905
		[global::Cpp2ILInjected.Token(Token = "0x4008A3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int showCount;

		// Token: 0x040070EA RID: 28906
		[global::Cpp2ILInjected.Token(Token = "0x4008A3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int startChatLine;
	}
}
