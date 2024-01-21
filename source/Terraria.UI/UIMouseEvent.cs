using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004D6")]
public class UIMouseEvent : UIEvent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40066E9")]
	public readonly Vector2 MousePosition;

	[Cpp2IlInjected.Token(Token = "0x600367E")]
	[Cpp2IlInjected.Address(RVA = "0x10D7450", Offset = "0x10D7450", VA = "0x10D7450")]
	public UIMouseEvent(UIElement target, Vector2 mousePosition)
	{
	}
}
