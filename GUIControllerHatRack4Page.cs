using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000090")]
public class GUIControllerHatRack4Page : GUIControllerHatRack
{
	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x129EBF4", Offset = "0x129EBF4", VA = "0x129EBF4", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x129EC04", Offset = "0x129EC04", VA = "0x129EC04", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x129ECC0", Offset = "0x129ECC0", VA = "0x129ECC0", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x129ECE4", Offset = "0x129ECE4", VA = "0x129ECE4", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x129EE78", Offset = "0x129EE78", VA = "0x129EE78", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x129F0AC", Offset = "0x129F0AC", VA = "0x129F0AC")]
	public GUIControllerHatRack4Page()
	{
	}
}
