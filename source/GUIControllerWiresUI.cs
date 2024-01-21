using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000076")]
public class GUIControllerWiresUI : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private int _selectedRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private int _selectedColumn;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x121EBC0", Offset = "0x121EBC0", VA = "0x121EBC0", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x121EBC4", Offset = "0x121EBC4", VA = "0x121EBC4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x121EBCC", Offset = "0x121EBCC", VA = "0x121EBCC", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x121EC78", Offset = "0x121EC78", VA = "0x121EC78", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x121EE70", Offset = "0x121EE70", VA = "0x121EE70")]
	public GUIControllerWiresUI()
	{
	}
}
