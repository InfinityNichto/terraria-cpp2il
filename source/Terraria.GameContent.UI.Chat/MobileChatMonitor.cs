using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F4")]
public class MobileChatMonitor : IChatMonitor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40070EC")]
	public int numChatLines;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40070ED")]
	public ChatLine[] chatLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40070EE")]
	private int chatLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40070EF")]
	private int showCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40070F0")]
	private int startChatLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40070F1")]
	public int numChatItems;

	[Cpp2IlInjected.Token(Token = "0x170007DF")]
	public int TextMaxLengthForScreen
	{
		[Cpp2IlInjected.Token(Token = "0x6004596")]
		[Cpp2IlInjected.Address(RVA = "0x1186110", Offset = "0x1186110", VA = "0x1186110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004597")]
	[Cpp2IlInjected.Address(RVA = "0x1186188", Offset = "0x1186188", VA = "0x1186188", Slot = "11")]
	public void OnResolutionChange()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004598")]
	[Cpp2IlInjected.Address(RVA = "0x118618C", Offset = "0x118618C", VA = "0x118618C")]
	public MobileChatMonitor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004599")]
	[Cpp2IlInjected.Address(RVA = "0x1186290", Offset = "0x1186290", VA = "0x1186290", Slot = "7")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600459A")]
	[Cpp2IlInjected.Address(RVA = "0x1186374", Offset = "0x1186374", VA = "0x1186374", Slot = "10")]
	public void ResetOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600459B")]
	[Cpp2IlInjected.Address(RVA = "0x1186380", Offset = "0x1186380", VA = "0x1186380", Slot = "8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600459C")]
	[Cpp2IlInjected.Address(RVA = "0x11863C4", Offset = "0x11863C4", VA = "0x11863C4", Slot = "9")]
	public void Offset(int linesOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600459D")]
	[Cpp2IlInjected.Address(RVA = "0x1186558", Offset = "0x1186558", VA = "0x1186558", Slot = "4")]
	public void NewText(string newText, byte R = byte.MaxValue, byte G = byte.MaxValue, byte B = byte.MaxValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600459E")]
	[Cpp2IlInjected.Address(RVA = "0x118657C", Offset = "0x118657C", VA = "0x118657C")]
	public void NewTextInternal(string newText, byte R = byte.MaxValue, byte G = byte.MaxValue, byte B = byte.MaxValue, bool force = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600459F")]
	[Cpp2IlInjected.Address(RVA = "0x11868C8", Offset = "0x11868C8", VA = "0x11868C8")]
	private string TrimIntoMultipleLines(byte R, byte G, byte B, int maxTextSize, string oldText)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60045A0")]
	[Cpp2IlInjected.Address(RVA = "0x1186AAC", Offset = "0x1186AAC", VA = "0x1186AAC", Slot = "5")]
	public void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045A1")]
	[Cpp2IlInjected.Address(RVA = "0x1186B94", Offset = "0x1186B94", VA = "0x1186B94")]
	public void NewText(List<TextSnippet> snippets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045A2")]
	[Cpp2IlInjected.Address(RVA = "0x1186C94", Offset = "0x1186C94", VA = "0x1186C94", Slot = "6")]
	public void DrawChat(bool drawingPlayerChat)
	{
	}
}
