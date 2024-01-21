using Cpp2IlInjected;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004D5")]
public class UIEvent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40066E8")]
	public readonly UIElement Target;

	[Cpp2IlInjected.Token(Token = "0x600367D")]
	[Cpp2IlInjected.Address(RVA = "0x10D7430", Offset = "0x10D7430", VA = "0x10D7430")]
	public UIEvent(UIElement target)
	{
	}
}
