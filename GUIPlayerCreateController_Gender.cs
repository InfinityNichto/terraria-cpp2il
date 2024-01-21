using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class GUIPlayerCreateController_Gender : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static int[] actualStyleOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly GUIPlayerCreateController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public int selectionIndex;

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x11413C4", Offset = "0x11413C4", VA = "0x11413C4")]
	public GUIPlayerCreateController_Gender(GUIPlayerCreateController controller)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x114181C", Offset = "0x114181C", VA = "0x114181C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x1141824", Offset = "0x1141824", VA = "0x1141824", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x11418F8", Offset = "0x11418F8", VA = "0x11418F8", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x1141A54", Offset = "0x1141A54", VA = "0x1141A54", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
