using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.Chat;

namespace Terraria.UI.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x200072B")]
	public class ChatLine
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003CBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493584", Offset = "0x1493584", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void UpdateTimeLeft()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14935A4", Offset = "0x14935A4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewTextInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewText", MemberParameters = new object[] { typeof(List<TextSnippet>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "NewTextInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "NewText", MemberParameters = new object[] { typeof(List<TextSnippet>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void Copy(ChatLine other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14935F0", Offset = "0x14935F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void FlagAsNeedsReprocessing()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003CBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x14935FC", Offset = "0x14935FC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public ChatLine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007BD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Color color;

		[global::Cpp2ILInjected.Token(Token = "0x4007BD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int showTime;

		[global::Cpp2ILInjected.Token(Token = "0x4007BD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string originalText;

		[global::Cpp2ILInjected.Token(Token = "0x4007BD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TextSnippet[] parsedText;

		[global::Cpp2ILInjected.Token(Token = "0x4007BD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TextSnippet[] parsedMiniText;

		[global::Cpp2ILInjected.Token(Token = "0x4007BDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public TextSnippet[] parsedMiniTouchText;

		[global::Cpp2ILInjected.Token(Token = "0x4007BDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Vector2 calculatedSizeMiniTouch;

		[global::Cpp2ILInjected.Token(Token = "0x4007BDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Vector2 calculatedSizeMini;

		[global::Cpp2ILInjected.Token(Token = "0x4007BDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Vector2 calculatedSizePage;

		[global::Cpp2ILInjected.Token(Token = "0x4007BDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int? parsingPixelLimit;

		[global::Cpp2ILInjected.Token(Token = "0x4007BDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool needsParsing;
	}
}
