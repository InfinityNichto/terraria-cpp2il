using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000081")]
public class GUIControllerChest4Page : GUIControllerChest
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private GUIControllerStaticGridNavigator _gridNav;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public GUIControllerStaticGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1290414", Offset = "0x1290414", VA = "0x1290414")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1290348", Offset = "0x1290348", VA = "0x1290348")]
	private ItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x12903A4", Offset = "0x12903A4", VA = "0x12903A4")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x12903FC", Offset = "0x12903FC", VA = "0x12903FC", Slot = "13")]
	public override bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x129057C", Offset = "0x129057C", VA = "0x129057C")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x1290584", Offset = "0x1290584", VA = "0x1290584")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x129058C", Offset = "0x129058C", VA = "0x129058C", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x12905B4", Offset = "0x12905B4", VA = "0x12905B4", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x12905E0", Offset = "0x12905E0", VA = "0x12905E0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x1290680", Offset = "0x1290680", VA = "0x1290680", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x1290784", Offset = "0x1290784", VA = "0x1290784", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x12907BC", Offset = "0x12907BC", VA = "0x12907BC")]
	public GUIControllerChest4Page()
	{
	}
}
