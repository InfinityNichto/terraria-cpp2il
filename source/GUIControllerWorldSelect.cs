using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000077")]
public class GUIControllerWorldSelect : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x200078D")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x400791D")]
		Back,
		[Cpp2IlInjected.Token(Token = "0x400791E")]
		Delete,
		[Cpp2IlInjected.Token(Token = "0x400791F")]
		Favourite,
		[Cpp2IlInjected.Token(Token = "0x4007920")]
		Rename,
		[Cpp2IlInjected.Token(Token = "0x4007921")]
		SeedDisplay,
		[Cpp2IlInjected.Token(Token = "0x4007922")]
		Play,
		[Cpp2IlInjected.Token(Token = "0x4007923")]
		New
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public int selectedControl;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x121EE78", Offset = "0x121EE78", VA = "0x121EE78", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x121F148", Offset = "0x121F148", VA = "0x121F148", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x121EF04", Offset = "0x121EF04", VA = "0x121EF04")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x121F150", Offset = "0x121F150", VA = "0x121F150", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x121F2A0", Offset = "0x121F2A0", VA = "0x121F2A0", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x121F4BC", Offset = "0x121F4BC", VA = "0x121F4BC")]
	public GUIControllerWorldSelect()
	{
	}
}
