using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class GUIHatRack
{
	[Cpp2IlInjected.Token(Token = "0x20007BB")]
	private enum EquipmentItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4007A0C")]
		Hat,
		[Cpp2IlInjected.Token(Token = "0x4007A0D")]
		HatDye
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private int itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private int itemDragStartHat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private int itemDragStartHatDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private EquipmentItemType itemType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private int itemPieceSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private float UnequipButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private TEHatRack HatRack;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x138BD00", Offset = "0x138BD00", VA = "0x138BD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x138B0A0", Offset = "0x138B0A0", VA = "0x138B0A0")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x138B254", Offset = "0x138B254", VA = "0x138B254")]
	public float HatScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x138B2AC", Offset = "0x138B2AC", VA = "0x138B2AC")]
	public float HatDyeScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x138B304", Offset = "0x138B304", VA = "0x138B304")]
	private void ItemOver(Item[] inv, int index, EquipmentItemType equipmentType, int itemContext, ref int itemDragStart)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x138B7E0", Offset = "0x138B7E0", VA = "0x138B7E0")]
	public void HatOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x138B818", Offset = "0x138B818", VA = "0x138B818")]
	public void HatDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x138BE1C", Offset = "0x138BE1C", VA = "0x138BE1C")]
	public void HatDyeOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x138BE54", Offset = "0x138BE54", VA = "0x138BE54")]
	public void HatDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x138C308", Offset = "0x138C308", VA = "0x138C308")]
	public int CanBeEquipedAccessory(Item checkItem)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x138C500", Offset = "0x138C500", VA = "0x138C500")]
	public bool CanBeEquiped(Item checkItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x138C510", Offset = "0x138C510", VA = "0x138C510")]
	public bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x138BDD8", Offset = "0x138BDD8", VA = "0x138BDD8")]
	private bool CanBeStored(int context, Item checkItem, int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x138C530", Offset = "0x138C530", VA = "0x138C530")]
	private void DrawHats()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x138CA38", Offset = "0x138CA38", VA = "0x138CA38")]
	public Item GetSelectedItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x138CA60", Offset = "0x138CA60", VA = "0x138CA60")]
	public void DrawUnequipButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x138D47C", Offset = "0x138D47C", VA = "0x138D47C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x138D7D4", Offset = "0x138D7D4", VA = "0x138D7D4")]
	public GUIHatRack()
	{
	}
}
