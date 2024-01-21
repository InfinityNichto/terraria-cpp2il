using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20004DA")]
public class ChatLine
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40066F9")]
	public Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40066FA")]
	public int showTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40066FB")]
	public string originalText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40066FC")]
	public TextSnippet[] parsedText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40066FD")]
	public TextSnippet[] parsedMiniText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40066FE")]
	public TextSnippet[] parsedMiniTouchText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40066FF")]
	public Vector2 calculatedSizeMiniTouch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006700")]
	public Vector2 calculatedSizeMini;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006701")]
	public Vector2 calculatedSizePage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006702")]
	private int? parsingPixelLimit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006703")]
	private bool needsParsing;

	[Cpp2IlInjected.Token(Token = "0x6003696")]
	[Cpp2IlInjected.Address(RVA = "0x14B38CC", Offset = "0x14B38CC", VA = "0x14B38CC")]
	public void UpdateTimeLeft()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003697")]
	[Cpp2IlInjected.Address(RVA = "0x14B38F0", Offset = "0x14B38F0", VA = "0x14B38F0")]
	public void Copy(ChatLine other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003698")]
	[Cpp2IlInjected.Address(RVA = "0x14B396C", Offset = "0x14B396C", VA = "0x14B396C")]
	public void FlagAsNeedsReprocessing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003699")]
	[Cpp2IlInjected.Address(RVA = "0x14B3978", Offset = "0x14B3978", VA = "0x14B3978")]
	public ChatLine()
	{
	}
}
