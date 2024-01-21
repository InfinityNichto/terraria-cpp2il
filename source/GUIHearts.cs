using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class GUIHearts
{
	[Cpp2IlInjected.Token(Token = "0x20007BC")]
	public enum ResourceSet
	{
		[Cpp2IlInjected.Token(Token = "0x4007A0F")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4007A10")]
		New,
		[Cpp2IlInjected.Token(Token = "0x4007A11")]
		HorizontalBars
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public ResourceSet ActiveSet;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private float heartLife;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private int heartCountOriginal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private int heartCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private int fruitHearts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private int lastHeartCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private CachedGridLayoutSettings LayoutCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private Vector2 lastAnchorPoint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private Rectangle HeartsRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private Vector2 heartBackingSingleOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private Vector2 heartBackingLeftOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private Vector2 heartBackingRightOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private Vector2 heartBackingRightFancyOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	private Vector2 heartBackingMidOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private Vector2 heartBackingLeftBarOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private Vector2 heartBackingMidBarOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private Vector2 heartBackingRightBarOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	private float TimeSinceChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	private int LastValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	private GUIItemGrid.GetItemScaleHandler heartScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private GUIItemGrid.CursorOver heartOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private GUIItemGrid.DrawItemHandler heartDraw;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public ItemGrid_Layout HeartsGrid
	{
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x138DA54", Offset = "0x138DA54", VA = "0x138DA54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x138D7F8", Offset = "0x138D7F8", VA = "0x138D7F8")]
	public GUIHearts()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x138DB34", Offset = "0x138DB34", VA = "0x138DB34")]
	public Rectangle GetHeartsRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x138DEC8", Offset = "0x138DEC8", VA = "0x138DEC8")]
	private void DrawLifeString()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x138E324", Offset = "0x138E324", VA = "0x138E324")]
	private float HeartScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x138E380", Offset = "0x138E380", VA = "0x138E380")]
	private void HeartOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x138E5F0", Offset = "0x138E5F0", VA = "0x138E5F0")]
	private void HeartDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x138DD90", Offset = "0x138DD90", VA = "0x138DD90")]
	private void AdjustForTouchReturn(ItemGrid_Layout grid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x138DE2C", Offset = "0x138DE2C", VA = "0x138DE2C")]
	private void RestoreForTouchButton(ItemGrid_Layout grid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x138F9EC", Offset = "0x138F9EC", VA = "0x138F9EC")]
	public void Draw()
	{
	}
}
