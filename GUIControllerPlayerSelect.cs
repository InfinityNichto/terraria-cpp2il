using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000070")]
public class GUIControllerPlayerSelect : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x200078B")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x400790A")]
		Back,
		[Cpp2IlInjected.Token(Token = "0x400790B")]
		Delete,
		[Cpp2IlInjected.Token(Token = "0x400790C")]
		Favourite,
		[Cpp2IlInjected.Token(Token = "0x400790D")]
		EditName,
		[Cpp2IlInjected.Token(Token = "0x400790E")]
		Play,
		[Cpp2IlInjected.Token(Token = "0x400790F")]
		New
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public int selectedControl;

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1218120", Offset = "0x1218120", VA = "0x1218120", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x12183F0", Offset = "0x12183F0", VA = "0x12183F0", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x12181AC", Offset = "0x12181AC", VA = "0x12181AC")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x12183F8", Offset = "0x12183F8", VA = "0x12183F8", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x1218548", Offset = "0x1218548", VA = "0x1218548", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1218730", Offset = "0x1218730", VA = "0x1218730")]
	public GUIControllerPlayerSelect()
	{
	}
}
