using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class GUIReforge
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	private int refCost;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	public List<Item> _reforgeItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private Item _defaultItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private int _selectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	public float reforgeScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400074E")]
	private float reforgeScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400074F")]
	private int reforgeScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000750")]
	private Vector2 reforgeDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private float reforgeActionScale;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool Collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x114C14C", Offset = "0x114C14C", VA = "0x114C14C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x114C710", Offset = "0x114C710", VA = "0x114C710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public Item ReforgeItem
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x114C354", Offset = "0x114C354", VA = "0x114C354")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000922")]
	[Cpp2IlInjected.Address(RVA = "0x114C04C", Offset = "0x114C04C", VA = "0x114C04C")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000924")]
	[Cpp2IlInjected.Address(RVA = "0x114C1D0", Offset = "0x114C1D0", VA = "0x114C1D0")]
	public int ReforgeCost()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x114C3D4", Offset = "0x114C3D4", VA = "0x114C3D4")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x114C4BC", Offset = "0x114C4BC", VA = "0x114C4BC")]
	private void RefreshItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x114C7E8", Offset = "0x114C7E8", VA = "0x114C7E8")]
	public void DrawReforge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000929")]
	[Cpp2IlInjected.Address(RVA = "0x114CD74", Offset = "0x114CD74", VA = "0x114CD74")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092B")]
	[Cpp2IlInjected.Address(RVA = "0x114D750", Offset = "0x114D750", VA = "0x114D750")]
	public float ReforgeItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600092C")]
	[Cpp2IlInjected.Address(RVA = "0x114D7A8", Offset = "0x114D7A8", VA = "0x114D7A8")]
	public void ReforgeItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092D")]
	[Cpp2IlInjected.Address(RVA = "0x114D950", Offset = "0x114D950", VA = "0x114D950")]
	public void ReforgeItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092E")]
	[Cpp2IlInjected.Address(RVA = "0x114DF5C", Offset = "0x114DF5C", VA = "0x114DF5C")]
	public GUIReforge()
	{
	}
}
