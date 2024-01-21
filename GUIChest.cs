using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class GUIChest
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public float scrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private float scrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private int scrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private Vector2 dragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public int itemSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private int itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private int itemDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private int lastLang;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public string[] options;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private int lastItemClicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private float doubleClickTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private bool rightClickHeld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private float LootButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private bool canLoot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private bool canLootAll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	private bool canDepositAll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public bool menuOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private float menuButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private float[] buttonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private Rectangle menuRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private Item[] dummySlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private GUIItemGrid.GetItemScaleHandler itemScaleHandler;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private GUIItemGrid.CursorOver itemOverHandler;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private GUIItemGrid.DrawItemHandler itemDrawHandler;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xF81918", Offset = "0xF81918", VA = "0xF81918")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xF81B90", Offset = "0xF81B90", VA = "0xF81B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0xF812B4", Offset = "0xF812B4", VA = "0xF812B4")]
	public GUIChest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0xF813F8", Offset = "0xF813F8", VA = "0xF813F8")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0xF814C4", Offset = "0xF814C4", VA = "0xF814C4")]
	public Item GetSelectedItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0xF815E4", Offset = "0xF815E4", VA = "0xF815E4")]
	public void EquipChestItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0xF817F8", Offset = "0xF817F8", VA = "0xF817F8")]
	public void UpdateSelectedItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0xF81920", Offset = "0xF81920", VA = "0xF81920")]
	public void RefreshLangStrings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0xF81C5C", Offset = "0xF81C5C", VA = "0xF81C5C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0xF824CC", Offset = "0xF824CC", VA = "0xF824CC")]
	public string GetName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0xF82B50", Offset = "0xF82B50", VA = "0xF82B50")]
	public string GetTitle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0xF81F14", Offset = "0xF81F14", VA = "0xF81F14")]
	private void DrawName(SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0xF824C8", Offset = "0xF824C8", VA = "0xF824C8")]
	private void DrawButtons(SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0xF83014", Offset = "0xF83014", VA = "0xF83014")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0xF8306C", Offset = "0xF8306C", VA = "0xF8306C")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0xF83E3C", Offset = "0xF83E3C", VA = "0xF83E3C")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0xF8201C", Offset = "0xF8201C", VA = "0xF8201C")]
	private void DrawSlots(SpriteBatch spriteBatch)
	{
	}
}
