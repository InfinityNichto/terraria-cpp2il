using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F5")]
public class RemadeChatMonitor : IChatMonitor
{
	[Cpp2IlInjected.Token(Token = "0x40070F2")]
	private const int MaxMessages = 500;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40070F3")]
	private int _showCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40070F4")]
	private int _startChatLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40070F5")]
	private List<ChatMessageContainer> _messages;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40070F6")]
	private bool _recalculateOnNextUpdate;

	[Cpp2IlInjected.Token(Token = "0x60045A3")]
	[Cpp2IlInjected.Address(RVA = "0x11873A0", Offset = "0x11873A0", VA = "0x11873A0")]
	public RemadeChatMonitor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045A4")]
	[Cpp2IlInjected.Address(RVA = "0x1187434", Offset = "0x1187434", VA = "0x1187434", Slot = "4")]
	public void NewText(string newText, byte R = byte.MaxValue, byte G = byte.MaxValue, byte B = byte.MaxValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045A5")]
	[Cpp2IlInjected.Address(RVA = "0x1187574", Offset = "0x1187574", VA = "0x1187574", Slot = "5")]
	public void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045A6")]
	[Cpp2IlInjected.Address(RVA = "0x1187488", Offset = "0x1187488", VA = "0x1187488")]
	public void AddNewMessage(string text, Color color, int widthLimitInPixels = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045A7")]
	[Cpp2IlInjected.Address(RVA = "0x1187594", Offset = "0x1187594", VA = "0x1187594", Slot = "6")]
	public void DrawChat(bool drawingPlayerChat)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045A8")]
	[Cpp2IlInjected.Address(RVA = "0x1187BBC", Offset = "0x1187BBC", VA = "0x1187BBC", Slot = "7")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045A9")]
	[Cpp2IlInjected.Address(RVA = "0x1187C18", Offset = "0x1187C18", VA = "0x1187C18", Slot = "8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045AA")]
	[Cpp2IlInjected.Address(RVA = "0x1187D08", Offset = "0x1187D08", VA = "0x1187D08", Slot = "9")]
	public void Offset(int linesOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045AB")]
	[Cpp2IlInjected.Address(RVA = "0x1187D18", Offset = "0x1187D18", VA = "0x1187D18")]
	private void ClampMessageIndex()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045AC")]
	[Cpp2IlInjected.Address(RVA = "0x1187E8C", Offset = "0x1187E8C", VA = "0x1187E8C", Slot = "10")]
	public void ResetOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045AD")]
	[Cpp2IlInjected.Address(RVA = "0x1187E98", Offset = "0x1187E98", VA = "0x1187E98", Slot = "11")]
	public void OnResolutionChange()
	{
	}
}
