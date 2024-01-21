using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GUIControllerRubbleMaker : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private bool wasInFilterGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private int filterGridRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private int filterGridCol;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private bool inGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private int gridRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private int gridCol;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private bool filterButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private bool sizeButton;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x121A164", Offset = "0x121A164", VA = "0x121A164", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x121A200", Offset = "0x121A200", VA = "0x121A200", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x121A208", Offset = "0x121A208", VA = "0x121A208", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x121A558", Offset = "0x121A558", VA = "0x121A558")]
	private void ClampMaterialGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x121A658", Offset = "0x121A658", VA = "0x121A658")]
	private void ClampRubbleGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x121A75C", Offset = "0x121A75C", VA = "0x121A75C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x121ABF8", Offset = "0x121ABF8", VA = "0x121ABF8")]
	public GUIControllerRubbleMaker()
	{
	}
}
