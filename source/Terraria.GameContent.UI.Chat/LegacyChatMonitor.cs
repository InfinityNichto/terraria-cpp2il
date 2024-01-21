using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F3")]
public class LegacyChatMonitor : IChatMonitor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40070E7")]
	private int numChatLines;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40070E8")]
	private ChatLine[] chatLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40070E9")]
	private int chatLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40070EA")]
	private int showCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40070EB")]
	private int startChatLine;

	[Cpp2IlInjected.Token(Token = "0x170007DE")]
	public int TextMaxLengthForScreen
	{
		[Cpp2IlInjected.Token(Token = "0x6004589")]
		[Cpp2IlInjected.Address(RVA = "0x1185118", Offset = "0x1185118", VA = "0x1185118")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600458A")]
	[Cpp2IlInjected.Address(RVA = "0x1185190", Offset = "0x1185190", VA = "0x1185190", Slot = "11")]
	public void OnResolutionChange()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600458B")]
	[Cpp2IlInjected.Address(RVA = "0x1185194", Offset = "0x1185194", VA = "0x1185194")]
	public LegacyChatMonitor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600458C")]
	[Cpp2IlInjected.Address(RVA = "0x1185298", Offset = "0x1185298", VA = "0x1185298", Slot = "7")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600458D")]
	[Cpp2IlInjected.Address(RVA = "0x1185354", Offset = "0x1185354", VA = "0x1185354", Slot = "10")]
	public void ResetOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600458E")]
	[Cpp2IlInjected.Address(RVA = "0x1185360", Offset = "0x1185360", VA = "0x1185360", Slot = "8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600458F")]
	[Cpp2IlInjected.Address(RVA = "0x11853A4", Offset = "0x11853A4", VA = "0x11853A4", Slot = "9")]
	public void Offset(int linesOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004590")]
	[Cpp2IlInjected.Address(RVA = "0x1185538", Offset = "0x1185538", VA = "0x1185538", Slot = "4")]
	public void NewText(string newText, byte R = byte.MaxValue, byte G = byte.MaxValue, byte B = byte.MaxValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004591")]
	[Cpp2IlInjected.Address(RVA = "0x11857BC", Offset = "0x11857BC", VA = "0x11857BC")]
	public void NewTextInternal(string newText, byte R = byte.MaxValue, byte G = byte.MaxValue, byte B = byte.MaxValue, bool force = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004592")]
	[Cpp2IlInjected.Address(RVA = "0x118598C", Offset = "0x118598C", VA = "0x118598C")]
	private string TrimIntoMultipleLines(byte R, byte G, byte B, int maxTextSize, string oldText)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004593")]
	[Cpp2IlInjected.Address(RVA = "0x1185594", Offset = "0x1185594", VA = "0x1185594", Slot = "5")]
	public void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004594")]
	[Cpp2IlInjected.Address(RVA = "0x1185B70", Offset = "0x1185B70", VA = "0x1185B70")]
	public void NewText(List<TextSnippet> snippets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004595")]
	[Cpp2IlInjected.Address(RVA = "0x1185C70", Offset = "0x1185C70", VA = "0x1185C70", Slot = "6")]
	public void DrawChat(bool drawingPlayerChat)
	{
	}
}
