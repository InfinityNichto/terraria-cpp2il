using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.Chat;

namespace Terraria.UI.Chat
{
	// Token: 0x020004D8 RID: 1240
	[global::Cpp2ILInjected.Token(Token = "0x200072C")]
	public class ChatMessageContainer
	{
		// Token: 0x0600365E RID: 13918 RVA: 0x0002BB62 File Offset: 0x00029D62
		[global::Cpp2ILInjected.Token(Token = "0x6003CBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14936CC", Offset = "0x14936CC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "AddNewMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "Refresh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetContents(string text, Color color, int widthLimitInPixels)
		{
			throw null;
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0002BB65 File Offset: 0x00029D65
		[global::Cpp2ILInjected.Token(Token = "0x6003CBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x149376C", Offset = "0x149376C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void MarkToNeedRefresh()
		{
			throw null;
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x0002BB68 File Offset: 0x00029D68
		[global::Cpp2ILInjected.Token(Token = "0x6003CC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493994", Offset = "0x1493994", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "Refresh", ReturnType = typeof(void))]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x0002BB6B File Offset: 0x00029D6B
		[global::Cpp2ILInjected.Token(Token = "0x6003CC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14939A8", Offset = "0x14939A8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "DrawChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TextSnippet[] GetSnippetWithInversedIndex(int snippetIndex)
		{
			throw null;
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x0002BB6E File Offset: 0x00029D6E
		[global::Cpp2ILInjected.Token(Token = "0x17000769")]
		public int LineCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493A14", Offset = "0x1493A14", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "DrawChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "ClampMessageIndex", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06003663 RID: 13923 RVA: 0x0002BB71 File Offset: 0x00029D71
		[global::Cpp2ILInjected.Token(Token = "0x1700076A")]
		public bool CanBeShownWhenChatIsClosed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493A54", Offset = "0x1493A54", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "DrawChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x0002BB74 File Offset: 0x00029D74
		[global::Cpp2ILInjected.Token(Token = "0x1700076B")]
		public bool Prepared
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1493A64", Offset = "0x1493A64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0002BB77 File Offset: 0x00029D77
		[global::Cpp2ILInjected.Token(Token = "0x6003CC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493774", Offset = "0x1493774", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatMessageContainer), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatMessageContainer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "WordwrapStringSmart", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(SpriteFont),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(List<List<TextSnippet>>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void Refresh()
		{
			throw null;
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x0002BB7A File Offset: 0x00029D7A
		[global::Cpp2ILInjected.Token(Token = "0x6003CC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1493A6C", Offset = "0x1493A6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "AddNewMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ChatMessageContainer()
		{
			throw null;
		}

		// Token: 0x04006703 RID: 26371
		[global::Cpp2ILInjected.Token(Token = "0x4007BE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string OriginalText;

		// Token: 0x04006704 RID: 26372
		[global::Cpp2ILInjected.Token(Token = "0x4007BE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _prepared;

		// Token: 0x04006705 RID: 26373
		[global::Cpp2ILInjected.Token(Token = "0x4007BE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<TextSnippet[]> _parsedText;

		// Token: 0x04006706 RID: 26374
		[global::Cpp2ILInjected.Token(Token = "0x4007BE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Color _color;

		// Token: 0x04006707 RID: 26375
		[global::Cpp2ILInjected.Token(Token = "0x4007BE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int _widthLimitInPixels;

		// Token: 0x04006708 RID: 26376
		[global::Cpp2ILInjected.Token(Token = "0x4007BE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _timeLeft;
	}
}
