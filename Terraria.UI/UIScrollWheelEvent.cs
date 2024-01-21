using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004D7")]
public class UIScrollWheelEvent : UIMouseEvent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40066EA")]
	public readonly int ScrollWheelValue;

	[Cpp2IlInjected.Token(Token = "0x600367F")]
	[Cpp2IlInjected.Address(RVA = "0x10D7480", Offset = "0x10D7480", VA = "0x10D7480")]
	public UIScrollWheelEvent(UIElement target, Vector2 mousePosition, int scrollWheelValue)
	{
	}
}
