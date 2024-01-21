using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GUIControllerCoins4Page : GUIControllerCoins
{
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x1290C9C", Offset = "0x1290C9C", VA = "0x1290C9C", Slot = "13")]
	public override void NavigateFromInventoryRow(int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x1290CC8", Offset = "0x1290CC8", VA = "0x1290CC8", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x1290CE4", Offset = "0x1290CE4", VA = "0x1290CE4", Slot = "14")]
	public override int GetInventoryRow()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x1290CF0", Offset = "0x1290CF0", VA = "0x1290CF0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x1290F54", Offset = "0x1290F54", VA = "0x1290F54", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x1291234", Offset = "0x1291234", VA = "0x1291234")]
	public GUIControllerCoins4Page()
	{
	}
}
