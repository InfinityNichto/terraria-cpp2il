﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x2000ADD")]
	public class MobileChatMonitor : IChatMonitor
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008DE")]
		public int TextMaxLengthForScreen
		{
			[global::Cpp2ILInjected.Token(Token = "0x60051C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x9337B4", Offset = "0x9337B4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x93380C", Offset = "0x93380C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnResolutionChange()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x933810", Offset = "0x933810", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public MobileChatMonitor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x933908", Offset = "0x933908", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9339CC", Offset = "0x9339CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ResetOffset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x9339D4", Offset = "0x9339D4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = "UpdateTimeLeft", ReturnType = typeof(void))]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x933A20", Offset = "0x933A20", Length = "0x19C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60051CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x933BBC", Offset = "0x933BBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "EmoteOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x933BC4", Offset = "0x933BC4", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "TrimIntoMultipleLines", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatLine), Member = "Copy", MemberParameters = new object[] { typeof(ChatLine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = "get_MaxChatLineWidth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(TextSnippet[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = "get_MaxMiniChatLineWidth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = "get_MaxMiniTouchChatLineWidth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = "CalulateMiniTouchSnippetSize", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = "CalulateMiniSnippetSize", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = "CalulatePageSnippetSize", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void NewTextInternal(string newText, byte R = 255, byte G = 255, byte B = 255, bool force = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x933EB4", Offset = "0x933EB4", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileChatMonitor), Member = "NewTextInternal", MemberParameters = new object[]
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

		[global::Cpp2ILInjected.Token(Token = "0x60051CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x93406C", Offset = "0x93406C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileChatMonitor), Member = "NewTextInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void NewTextMultiline(string text, bool force = false, Color c = default(Color), int WidthLimit = -1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x934124", Offset = "0x934124", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		[global::Cpp2ILInjected.Token(Token = "0x60051CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x934228", Offset = "0x934228", Length = "0x37C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x4008A3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int numChatLines;

		[global::Cpp2ILInjected.Token(Token = "0x4008A3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ChatLine[] chatLine;

		[global::Cpp2ILInjected.Token(Token = "0x4008A3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int chatLength;

		[global::Cpp2ILInjected.Token(Token = "0x4008A3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int showCount;

		[global::Cpp2ILInjected.Token(Token = "0x4008A40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int startChatLine;

		[global::Cpp2ILInjected.Token(Token = "0x4008A41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int numChatItems;
	}
}
