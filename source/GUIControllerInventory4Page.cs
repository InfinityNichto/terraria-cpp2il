using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000094")]
public class GUIControllerInventory4Page : GUIControllerInventory
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private GUIControllerPageMenuPopupGridNavigator BuilderToolNav
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xF682CC", Offset = "0xF682CC", VA = "0xF682CC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0xF68208", Offset = "0xF68208", VA = "0xF68208")]
	private ItemGrid_Layout GetInfoGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xF68224", Offset = "0xF68224", VA = "0xF68224")]
	private int GetInfoCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xF68288", Offset = "0xF68288", VA = "0xF68288")]
	private float GetInfoItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0xF68290", Offset = "0xF68290", VA = "0xF68290", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xF68404", Offset = "0xF68404", VA = "0xF68404", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0xF684C8", Offset = "0xF684C8", VA = "0xF684C8", Slot = "13")]
	public override void NavigateToItem(int item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0xF685B0", Offset = "0xF685B0", VA = "0xF685B0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0xF687C0", Offset = "0xF687C0", VA = "0xF687C0", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0xF68B98", Offset = "0xF68B98", VA = "0xF68B98")]
	public GUIControllerInventory4Page()
	{
	}
}
