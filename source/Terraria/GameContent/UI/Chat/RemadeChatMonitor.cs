using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x020006F2 RID: 1778
	[global::Cpp2ILInjected.Token(Token = "0x2000ADE")]
	public class RemadeChatMonitor : IChatMonitor
	{
		// Token: 0x06004564 RID: 17764 RVA: 0x0002E6AF File Offset: 0x0002C8AF
		[global::Cpp2ILInjected.Token(Token = "0x60051D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x9345A4", Offset = "0x9345A4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public RemadeChatMonitor()
		{
			throw null;
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x0002E6B2 File Offset: 0x0002C8B2
		[global::Cpp2ILInjected.Token(Token = "0x60051D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x934630", Offset = "0x934630", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemadeChatMonitor), Member = "AddNewMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
			throw null;
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x0002E6B5 File Offset: 0x0002C8B5
		[global::Cpp2ILInjected.Token(Token = "0x60051D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x934778", Offset = "0x934778", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemadeChatMonitor), Member = "AddNewMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void NewTextMultiline(string text, bool force = false, Color c = default(Color), int WidthLimit = -1)
		{
			throw null;
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x0002E6B8 File Offset: 0x0002C8B8
		[global::Cpp2ILInjected.Token(Token = "0x60051D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x93467C", Offset = "0x93467C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemadeChatMonitor), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddNewMessage(string text, Color color, int widthLimitInPixels = -1)
		{
			throw null;
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x0002E6BB File Offset: 0x0002C8BB
		[global::Cpp2ILInjected.Token(Token = "0x60051D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x934784", Offset = "0x934784", Length = "0x4D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "get_LineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "get_CanBeShownWhenChatIsClosed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "GetSnippetWithInversedIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TextSnippet[]))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public void DrawChat(bool drawingPlayerChat)
		{
			throw null;
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x0002E6BE File Offset: 0x0002C8BE
		[global::Cpp2ILInjected.Token(Token = "0x60051D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x934C5C", Offset = "0x934C5C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x0002E6C1 File Offset: 0x0002C8C1
		[global::Cpp2ILInjected.Token(Token = "0x60051D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x934CC4", Offset = "0x934CC4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "MarkToNeedRefresh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x0002E6C4 File Offset: 0x0002C8C4
		[global::Cpp2ILInjected.Token(Token = "0x60051D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x934D98", Offset = "0x934D98", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Offset(int linesOffset)
		{
			throw null;
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x0002E6C7 File Offset: 0x0002C8C7
		[global::Cpp2ILInjected.Token(Token = "0x60051D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x934DA8", Offset = "0x934DA8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessageContainer), Member = "get_LineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ClampMessageIndex()
		{
			throw null;
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x0002E6CA File Offset: 0x0002C8CA
		[global::Cpp2ILInjected.Token(Token = "0x60051D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x934EF8", Offset = "0x934EF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ResetOffset()
		{
			throw null;
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x0002E6CD File Offset: 0x0002C8CD
		[global::Cpp2ILInjected.Token(Token = "0x60051DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x934F00", Offset = "0x934F00", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnResolutionChange()
		{
			throw null;
		}

		// Token: 0x040070F1 RID: 28913
		[global::Cpp2ILInjected.Token(Token = "0x4008A42")]
		private const int MaxMessages = 500;

		// Token: 0x040070F2 RID: 28914
		[global::Cpp2ILInjected.Token(Token = "0x4008A43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _showCount;

		// Token: 0x040070F3 RID: 28915
		[global::Cpp2ILInjected.Token(Token = "0x4008A44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _startChatLine;

		// Token: 0x040070F4 RID: 28916
		[global::Cpp2ILInjected.Token(Token = "0x4008A45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<ChatMessageContainer> _messages;

		// Token: 0x040070F5 RID: 28917
		[global::Cpp2ILInjected.Token(Token = "0x4008A46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _recalculateOnNextUpdate;
	}
}
