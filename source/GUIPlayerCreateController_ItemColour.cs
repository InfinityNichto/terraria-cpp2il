using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class GUIPlayerCreateController_ItemColour : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly GUIPlayerCreateController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public int selectionIndex;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x1141410", Offset = "0x1141410", VA = "0x1141410")]
	public GUIPlayerCreateController_ItemColour(GUIPlayerCreateController controller)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x11429DC", Offset = "0x11429DC", VA = "0x11429DC", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x11429E8", Offset = "0x11429E8", VA = "0x11429E8", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x11429F0", Offset = "0x11429F0", VA = "0x11429F0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x1142A7C", Offset = "0x1142A7C", VA = "0x1142A7C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
