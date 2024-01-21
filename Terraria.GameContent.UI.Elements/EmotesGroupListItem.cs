using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006B8")]
public class EmotesGroupListItem : UIElement
{
	[Cpp2IlInjected.Token(Token = "0x4006F8A")]
	private const int TITLE_HEIGHT = 20;

	[Cpp2IlInjected.Token(Token = "0x4006F8B")]
	private const int SEPARATOR_HEIGHT = 10;

	[Cpp2IlInjected.Token(Token = "0x4006F8C")]
	private const int SIZE_PER_EMOTE = 36;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006F8D")]
	private Asset<Texture2D> _tempTex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006F8E")]
	private int _groupIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006F8F")]
	private int _maxEmotesPerRow;

	[Cpp2IlInjected.Token(Token = "0x60043DE")]
	[Cpp2IlInjected.Address(RVA = "0x118D4E4", Offset = "0x118D4E4", VA = "0x118D4E4")]
	public EmotesGroupListItem(LocalizedText groupTitle, int groupIndex, int maxEmotesPerRow, params int[] emotes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043DF")]
	[Cpp2IlInjected.Address(RVA = "0x118DB10", Offset = "0x118DB10", VA = "0x118DB10", Slot = "29")]
	public override int CompareTo(object obj)
	{
		return default(int);
	}
}
