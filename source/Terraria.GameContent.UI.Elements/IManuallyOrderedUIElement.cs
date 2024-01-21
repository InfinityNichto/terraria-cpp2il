using Cpp2IlInjected;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C6")]
public interface IManuallyOrderedUIElement
{
	[Cpp2IlInjected.Token(Token = "0x170007BE")]
	int OrderInUIList
	{
		[Cpp2IlInjected.Token(Token = "0x6004442")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6004443")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
