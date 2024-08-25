using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000093")]
public interface GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x600038B")]
	void Activate();

	[global::Cpp2ILInjected.Token(Token = "0x600038C")]
	GUIControllerItem Navigate(Vector2 navigationVector);

	[global::Cpp2ILInjected.Token(Token = "0x600038D")]
	Rectangle GetSelectedItemRegion();

	[global::Cpp2ILInjected.Token(Token = "0x600038E")]
	int GetNavigationOutDirs();
}
