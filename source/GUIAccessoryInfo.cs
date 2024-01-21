using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class GUIAccessoryInfo
{
	[Cpp2IlInjected.Token(Token = "0x20007B2")]
	private enum StringState
	{
		[Cpp2IlInjected.Token(Token = "0x40079C7")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x40079C8")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x40079C9")]
		Critter
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public int numInfoAccessories;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public int[] DisplayIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public string[] IconText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public string[] InfoText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private StringState[] InfoState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private Rectangle lastDrawRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private GUIItemGrid.CursorOver itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private int itemOffset;

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x20D42FC", Offset = "0x20D42FC", VA = "0x20D42FC")]
	public GUIAccessoryInfo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x20D4464", Offset = "0x20D4464", VA = "0x20D4464")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x20D8D34", Offset = "0x20D8D34", VA = "0x20D8D34")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x20D8D90", Offset = "0x20D8D90", VA = "0x20D8D90")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x20D8D94", Offset = "0x20D8D94", VA = "0x20D8D94")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x20D5378", Offset = "0x20D5378", VA = "0x20D5378")]
	public void BuildInfoAccs()
	{
	}
}
