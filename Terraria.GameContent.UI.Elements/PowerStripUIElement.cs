using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006BB")]
public class PowerStripUIElement : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006FA5")]
	private List<UIElement> _buttonsBySorting;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006FA6")]
	private string _gamepadPointGroupname;

	[Cpp2IlInjected.Token(Token = "0x60043EE")]
	[Cpp2IlInjected.Address(RVA = "0x118DBBC", Offset = "0x118DBBC", VA = "0x118DBBC")]
	public PowerStripUIElement(string gamepadGroupName, List<UIElement> buttons)
	{
	}
}
