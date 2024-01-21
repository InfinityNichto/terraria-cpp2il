using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GUIControllerFullScreenMap : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1299D64", Offset = "0x1299D64", VA = "0x1299D64", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1299D68", Offset = "0x1299D68", VA = "0x1299D68", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1299D70", Offset = "0x1299D70", VA = "0x1299D70", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1299D74", Offset = "0x1299D74", VA = "0x1299D74", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1299E24", Offset = "0x1299E24", VA = "0x1299E24")]
	public GUIControllerFullScreenMap()
	{
	}
}
