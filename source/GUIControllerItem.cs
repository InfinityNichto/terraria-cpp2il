using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Activate();

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GUIControllerItem Navigate(Vector2 navigationVector);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Rectangle GetSelectedItemRegion();

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GetNavigationOutDirs();
}
