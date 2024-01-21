using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20004DB")]
public class ChatMessageContainer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006704")]
	public string OriginalText;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006705")]
	private bool _prepared;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006706")]
	private List<TextSnippet[]> _parsedText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006707")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006708")]
	private int _widthLimitInPixels;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006709")]
	private int _timeLeft;

	[Cpp2IlInjected.Token(Token = "0x170006D0")]
	public int LineCount
	{
		[Cpp2IlInjected.Token(Token = "0x600369E")]
		[Cpp2IlInjected.Address(RVA = "0x14B9DD8", Offset = "0x14B9DD8", VA = "0x14B9DD8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006D1")]
	public bool CanBeShownWhenChatIsClosed
	{
		[Cpp2IlInjected.Token(Token = "0x600369F")]
		[Cpp2IlInjected.Address(RVA = "0x14B9E24", Offset = "0x14B9E24", VA = "0x14B9E24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006D2")]
	public bool Prepared
	{
		[Cpp2IlInjected.Token(Token = "0x60036A0")]
		[Cpp2IlInjected.Address(RVA = "0x14B9E38", Offset = "0x14B9E38", VA = "0x14B9E38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600369A")]
	[Cpp2IlInjected.Address(RVA = "0x14B9AE4", Offset = "0x14B9AE4", VA = "0x14B9AE4")]
	public void SetContents(string text, Color color, int widthLimitInPixels)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600369B")]
	[Cpp2IlInjected.Address(RVA = "0x14B9B8C", Offset = "0x14B9B8C", VA = "0x14B9B8C")]
	public void MarkToNeedRefresh()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600369C")]
	[Cpp2IlInjected.Address(RVA = "0x14B9D54", Offset = "0x14B9D54", VA = "0x14B9D54")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600369D")]
	[Cpp2IlInjected.Address(RVA = "0x14B9D68", Offset = "0x14B9D68", VA = "0x14B9D68")]
	public TextSnippet[] GetSnippetWithInversedIndex(int snippetIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60036A1")]
	[Cpp2IlInjected.Address(RVA = "0x14B9B98", Offset = "0x14B9B98", VA = "0x14B9B98")]
	public void Refresh()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036A2")]
	[Cpp2IlInjected.Address(RVA = "0x14B9E40", Offset = "0x14B9E40", VA = "0x14B9E40")]
	public ChatMessageContainer()
	{
	}
}
