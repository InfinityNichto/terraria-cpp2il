using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class GUIMana
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private int starMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private int starCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private int lastStarCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private CachedGridLayoutSettings LayoutCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private Rectangle StarsRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private Vector2 lastAnchorPoint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private Vector2 manaBackingSingleOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private Vector2 manaBackingTopOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private Vector2 manaBackingBottomOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private Vector2 manaBackingMidOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private Vector2 manaBackingLeftBarOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private Vector2 manaBackingMidBarOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private Vector2 manaBackingRightBarOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private GUIItemGrid.CursorOver starOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private GUIItemGrid.GetItemScaleHandler starScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private GUIItemGrid.DrawItemHandler starDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private float TimeSinceChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private int LastValue;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public ItemGrid_Layout ManaGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0xDF5E74", Offset = "0xDF5E74", VA = "0xDF5E74")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public String_Layout ManaTitle
	{
		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xDF5F58", Offset = "0xDF5F58", VA = "0xDF5F58")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public String_Layout ManaValue
	{
		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xDF603C", Offset = "0xDF603C", VA = "0xDF603C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xDF5C18", Offset = "0xDF5C18", VA = "0xDF5C18")]
	public GUIMana()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0xDF6120", Offset = "0xDF6120", VA = "0xDF6120")]
	public Rectangle GetManaRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0xDF6344", Offset = "0xDF6344", VA = "0xDF6344")]
	private void AdjustForTouchReturn(ItemGrid_Layout grid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0xDF63F8", Offset = "0xDF63F8", VA = "0xDF63F8")]
	private void RestoreForTouchButton(ItemGrid_Layout grid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0xDF64AC", Offset = "0xDF64AC", VA = "0xDF64AC")]
	private float StarScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0xDF6508", Offset = "0xDF6508", VA = "0xDF6508")]
	private void StarOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0xDF6778", Offset = "0xDF6778", VA = "0xDF6778")]
	private void StarDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xDF7AE4", Offset = "0xDF7AE4", VA = "0xDF7AE4")]
	public void Draw()
	{
	}
}
