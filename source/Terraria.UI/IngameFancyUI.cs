using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004BE")]
public class IngameFancyUI
{
	[Cpp2IlInjected.Token(Token = "0x4006678")]
	private static bool CoverForOneUIFrame;

	[Cpp2IlInjected.Token(Token = "0x600359E")]
	[Cpp2IlInjected.Address(RVA = "0x13A88D8", Offset = "0x13A88D8", VA = "0x13A88D8")]
	public static void CoverNextFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600359F")]
	[Cpp2IlInjected.Address(RVA = "0x13A8934", Offset = "0x13A8934", VA = "0x13A8934")]
	public static bool CanCover()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60035A0")]
	[Cpp2IlInjected.Address(RVA = "0x13A89A0", Offset = "0x13A89A0", VA = "0x13A89A0")]
	public static void OpenAchievements()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035A1")]
	[Cpp2IlInjected.Address(RVA = "0x13A6944", Offset = "0x13A6944", VA = "0x13A6944")]
	public static void OpenAchievementsAndGoto(Achievement achievement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035A2")]
	[Cpp2IlInjected.Address(RVA = "0x13A8AFC", Offset = "0x13A8AFC", VA = "0x13A8AFC")]
	private static void ClearChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035A3")]
	[Cpp2IlInjected.Address(RVA = "0x13A8B8C", Offset = "0x13A8B8C", VA = "0x13A8B8C")]
	public static void OpenKeybinds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035A4")]
	[Cpp2IlInjected.Address(RVA = "0x13A8B90", Offset = "0x13A8B90", VA = "0x13A8B90")]
	public static void OpenUIState(UIState uiState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035A5")]
	[Cpp2IlInjected.Address(RVA = "0x13A8CA8", Offset = "0x13A8CA8", VA = "0x13A8CA8")]
	public static bool CanShowVirtualKeyboard(int context)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60035A6")]
	[Cpp2IlInjected.Address(RVA = "0x13A8D24", Offset = "0x13A8D24", VA = "0x13A8D24")]
	public static void OpenVirtualKeyboard(int keyboardContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035A7")]
	[Cpp2IlInjected.Address(RVA = "0x13A958C", Offset = "0x13A958C", VA = "0x13A958C")]
	public static void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035A8")]
	[Cpp2IlInjected.Address(RVA = "0x13A9818", Offset = "0x13A9818", VA = "0x13A9818")]
	public static bool Draw(SpriteBatch spriteBatch, GameTime gameTime)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60035A9")]
	[Cpp2IlInjected.Address(RVA = "0x13A9C80", Offset = "0x13A9C80", VA = "0x13A9C80")]
	public static void MouseOver()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035AA")]
	[Cpp2IlInjected.Address(RVA = "0x13A9D68", Offset = "0x13A9D68", VA = "0x13A9D68")]
	public IngameFancyUI()
	{
	}
}
