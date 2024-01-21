using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class GUIPopoutMenu
{
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static Texture2D _menuClosed;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static Texture2D _menuOpen;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0xE2BB3C", Offset = "0xE2BB3C", VA = "0xE2BB3C")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0xE2BBE8", Offset = "0xE2BBE8", VA = "0xE2BBE8")]
	private static int DrawMenu(PopoutMenu_Layout layout, string[] options, ref Rectangle menuRegion)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0xE2C690", Offset = "0xE2C690", VA = "0xE2C690")]
	public static int Draw(PopoutMenu_Layout layout, string[] options, ref bool menuOpen, ref float scale, ref Rectangle menuRegion)
	{
		return default(int);
	}
}
