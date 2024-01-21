using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006CD")]
public class UIColoredSliderSimple : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007007")]
	public float FillPercent;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007008")]
	public Color FilledColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007009")]
	public Color EmptyColor;

	[Cpp2IlInjected.Token(Token = "0x600446D")]
	[Cpp2IlInjected.Address(RVA = "0x1486D60", Offset = "0x1486D60", VA = "0x1486D60", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600446E")]
	[Cpp2IlInjected.Address(RVA = "0x1486D64", Offset = "0x1486D64", VA = "0x1486D64")]
	private void DrawValueBarDynamicWidth(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600446F")]
	[Cpp2IlInjected.Address(RVA = "0x14870FC", Offset = "0x14870FC", VA = "0x14870FC")]
	public UIColoredSliderSimple()
	{
	}
}
