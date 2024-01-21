using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200008D")]
public class GUIControllerEquipment4Page : GUIControllerEquipment
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private GUIControllerPageMenuPopupGridNavigator _loadoutNav;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private GUIControllerPageMenuPopupGridNavigator AccessoryNav
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x129902C", Offset = "0x129902C", VA = "0x129902C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private GUIControllerPageMenuPopupGridNavigator LoadoutNav
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1299164", Offset = "0x1299164", VA = "0x1299164")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1298E5C", Offset = "0x1298E5C", VA = "0x1298E5C")]
	private ItemGrid_Layout GetInfoGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1298EB8", Offset = "0x1298EB8", VA = "0x1298EB8")]
	private int GetInfoCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1298F18", Offset = "0x1298F18", VA = "0x1298F18")]
	private float GetInfoItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1298F70", Offset = "0x1298F70", VA = "0x1298F70")]
	private ItemGrid_Layout GetLoadoutGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1298FCC", Offset = "0x1298FCC", VA = "0x1298FCC")]
	private int GetLoadoutCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1298FD4", Offset = "0x1298FD4", VA = "0x1298FD4")]
	private float GetLoadoutItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x129929C", Offset = "0x129929C", VA = "0x129929C", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x12992FC", Offset = "0x12992FC", VA = "0x12992FC", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1299434", Offset = "0x1299434", VA = "0x1299434", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x12997E8", Offset = "0x12997E8", VA = "0x12997E8")]
	private void ClampMenu(bool preferUp = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1299880", Offset = "0x1299880", VA = "0x1299880", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1299B88", Offset = "0x1299B88", VA = "0x1299B88")]
	private void ClampExtraAccessories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1299C7C", Offset = "0x1299C7C", VA = "0x1299C7C", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1299D58", Offset = "0x1299D58", VA = "0x1299D58")]
	public GUIControllerEquipment4Page()
	{
	}
}
