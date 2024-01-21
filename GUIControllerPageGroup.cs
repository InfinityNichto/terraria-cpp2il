using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200009B")]
public class GUIControllerPageGroup : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private readonly GUIPageIconGrouping Grouping;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public int MenuRow;

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1215C04", Offset = "0x1215C04", VA = "0x1215C04")]
	public GUIControllerPageGroup(GUIPageIconGrouping grouping)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1215C24", Offset = "0x1215C24", VA = "0x1215C24", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1215C28", Offset = "0x1215C28", VA = "0x1215C28", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1215CA0", Offset = "0x1215CA0", VA = "0x1215CA0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1215E44", Offset = "0x1215E44", VA = "0x1215E44")]
	public void ClampMenuItem(bool preferUp = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1215F08", Offset = "0x1215F08", VA = "0x1215F08", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
