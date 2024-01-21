using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace ReLogic.OS;

[Cpp2IlInjected.Token(Token = "0x2000726")]
public interface IWindowService
{
	[Cpp2IlInjected.Token(Token = "0x60046D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void SetUnicodeTitle(GameWindow window, string title);

	[Cpp2IlInjected.Token(Token = "0x60046D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void StartFlashingIcon(GameWindow window);

	[Cpp2IlInjected.Token(Token = "0x60046D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void StopFlashingIcon(GameWindow window);

	[Cpp2IlInjected.Token(Token = "0x60046D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float GetScaling();

	[Cpp2IlInjected.Token(Token = "0x60046D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SetQuickEditEnabled(bool enabled);
}
