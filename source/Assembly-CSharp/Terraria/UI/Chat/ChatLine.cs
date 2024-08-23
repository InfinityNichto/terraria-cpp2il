using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.Chat;

namespace Terraria.UI.Chat
{
	// Token: 0x020004D7 RID: 1239
	[global::Cpp2ILInjected.Token(Token = "0x200072B")]
	public class ChatLine
	{
		// Token: 0x0600365A RID: 13914 RVA: 0x0002BB56 File Offset: 0x00029D56
		[global::Cpp2ILInjected.Token(Token = "0x6003CBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493584", Offset = "0x1493584", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void UpdateTimeLeft()
		{
			throw null;
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x0002BB59 File Offset: 0x00029D59
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

		// Token: 0x0600365C RID: 13916 RVA: 0x0002BB5C File Offset: 0x00029D5C
		[global::Cpp2ILInjected.Token(Token = "0x6003CBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14935F0", Offset = "0x14935F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void FlagAsNeedsReprocessing()
		{
			throw null;
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x0002BB5F File Offset: 0x00029D5F
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

		// Token: 0x040066F8 RID: 26360
		[global::Cpp2ILInjected.Token(Token = "0x4007BD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Color color;

		// Token: 0x040066F9 RID: 26361
		[global::Cpp2ILInjected.Token(Token = "0x4007BD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int showTime;

		// Token: 0x040066FA RID: 26362
		[global::Cpp2ILInjected.Token(Token = "0x4007BD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string originalText;

		// Token: 0x040066FB RID: 26363
		[global::Cpp2ILInjected.Token(Token = "0x4007BD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TextSnippet[] parsedText;

		// Token: 0x040066FC RID: 26364
		[global::Cpp2ILInjected.Token(Token = "0x4007BD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TextSnippet[] parsedMiniText;

		// Token: 0x040066FD RID: 26365
		[global::Cpp2ILInjected.Token(Token = "0x4007BDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public TextSnippet[] parsedMiniTouchText;

		// Token: 0x040066FE RID: 26366
		[global::Cpp2ILInjected.Token(Token = "0x4007BDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Vector2 calculatedSizeMiniTouch;

		// Token: 0x040066FF RID: 26367
		[global::Cpp2ILInjected.Token(Token = "0x4007BDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Vector2 calculatedSizeMini;

		// Token: 0x04006700 RID: 26368
		[global::Cpp2ILInjected.Token(Token = "0x4007BDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Vector2 calculatedSizePage;

		// Token: 0x04006701 RID: 26369
		[global::Cpp2ILInjected.Token(Token = "0x4007BDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int? parsingPixelLimit;

		// Token: 0x04006702 RID: 26370
		[global::Cpp2ILInjected.Token(Token = "0x4007BDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool needsParsing;
	}
}
