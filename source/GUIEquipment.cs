using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000DD")]
public class GUIEquipment
{
	[Cpp2IlInjected.Token(Token = "0x20007BA")]
	private enum EquipmentItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4007A03")]
		Armour,
		[Cpp2IlInjected.Token(Token = "0x4007A04")]
		ArmourDye,
		[Cpp2IlInjected.Token(Token = "0x4007A05")]
		ArmourVanity,
		[Cpp2IlInjected.Token(Token = "0x4007A06")]
		Accessory,
		[Cpp2IlInjected.Token(Token = "0x4007A07")]
		AccessoryDye,
		[Cpp2IlInjected.Token(Token = "0x4007A08")]
		AccessoryVanity,
		[Cpp2IlInjected.Token(Token = "0x4007A09")]
		QuickSlot,
		[Cpp2IlInjected.Token(Token = "0x4007A0A")]
		QuickSlotDye
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private int itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private int itemDragStartArmour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private int itemDragStartArmourDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private int itemDragStartArmourVanity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private int itemDragStartAccessory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private int itemDragStartAccessoryDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private int itemDragStartAccessoryVanity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private int itemDragStartQuickSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private int itemDragStartQuickSlotDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private float collapseAnimationTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private EquipmentItemType lastItemTypeClicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private int lastItemClicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private float doubleClickTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private bool rightClickHeld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private EquipmentItemType itemType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private int itemPieceSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private float UnequipButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private float HideShowButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private float globalAnimationOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private float row1AnimationOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private float row2AnimationOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private float row1AnimationScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private float row2AnimationScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private int accOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private float ExpandButtonScale;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x1377908", Offset = "0x1377908", VA = "0x1377908")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x137924C", Offset = "0x137924C", VA = "0x137924C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x1377988", Offset = "0x1377988", VA = "0x1377988")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x1377DB0", Offset = "0x1377DB0", VA = "0x1377DB0")]
	public float ArmourScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x1377E08", Offset = "0x1377E08", VA = "0x1377E08")]
	public float ArmourDyeScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x1377E60", Offset = "0x1377E60", VA = "0x1377E60")]
	public float ArmourVanityScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x1377EB8", Offset = "0x1377EB8", VA = "0x1377EB8")]
	private bool ShouldShowMenu(EquipmentItemType type, int i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x1377FF0", Offset = "0x1377FF0", VA = "0x1377FF0")]
	private void ItemOver(Item[] inv, int index, EquipmentItemType equipmentType, int itemContext, ref int itemDragStart)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x1378BD0", Offset = "0x1378BD0", VA = "0x1378BD0")]
	public void ArmourOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x1378C8C", Offset = "0x1378C8C", VA = "0x1378C8C")]
	public void ArmourDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x13796FC", Offset = "0x13796FC", VA = "0x13796FC")]
	public void ArmourDyeOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x13797B8", Offset = "0x13797B8", VA = "0x13797B8")]
	public void ArmourDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x1379D88", Offset = "0x1379D88", VA = "0x1379D88")]
	public void ArmourVanityOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x1379E44", Offset = "0x1379E44", VA = "0x1379E44")]
	public void ArmourVanityDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x137A408", Offset = "0x137A408", VA = "0x137A408")]
	public int CanBeEquipedAccessory(Item checkItem)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x137A600", Offset = "0x137A600", VA = "0x137A600")]
	public bool CanBeEquiped(Item checkItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x137A7A4", Offset = "0x137A7A4", VA = "0x137A7A4")]
	public bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x1379324", Offset = "0x1379324", VA = "0x1379324")]
	private bool CanBeStored(int context, Item checkItem, int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x137A950", Offset = "0x137A950", VA = "0x137A950")]
	private void DrawArmour()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x137B1EC", Offset = "0x137B1EC", VA = "0x137B1EC")]
	public float AccessoryScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x137B244", Offset = "0x137B244", VA = "0x137B244")]
	public float AccessoryDyeScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x137B29C", Offset = "0x137B29C", VA = "0x137B29C")]
	public float AccessoryVanityScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x137B2F4", Offset = "0x137B2F4", VA = "0x137B2F4")]
	public void AccessoryOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x137B490", Offset = "0x137B490", VA = "0x137B490")]
	public void AccessoryDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x137C474", Offset = "0x137C474", VA = "0x137C474")]
	public void AccessoryDyeOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x137C610", Offset = "0x137C610", VA = "0x137C610")]
	public void AccessoryDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x137D33C", Offset = "0x137D33C", VA = "0x137D33C")]
	public void AccessoryVanityOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x137D4D8", Offset = "0x137D4D8", VA = "0x137D4D8")]
	public void AccessoryVanityDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x137E21C", Offset = "0x137E21C", VA = "0x137E21C")]
	private void DrawAccesories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x137EE44", Offset = "0x137EE44", VA = "0x137EE44")]
	public float QuickSlotScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x137EE9C", Offset = "0x137EE9C", VA = "0x137EE9C")]
	public float QuickSlotScaleDye(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x137EEF4", Offset = "0x137EEF4", VA = "0x137EEF4")]
	public void QuickSlotOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x137EFC8", Offset = "0x137EFC8", VA = "0x137EFC8")]
	public void QuickSlotDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x137FB24", Offset = "0x137FB24", VA = "0x137FB24")]
	public void QuickSlotDyeOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x137FBE0", Offset = "0x137FBE0", VA = "0x137FBE0")]
	public void QuickSlotDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x1380094", Offset = "0x1380094", VA = "0x1380094")]
	private void DrawQuickSlots()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x13806A4", Offset = "0x13806A4", VA = "0x13806A4")]
	private void DrawHeaders()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x13807A8", Offset = "0x13807A8", VA = "0x13807A8")]
	private void DrawArmourBonus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x1380C00", Offset = "0x1380C00", VA = "0x1380C00")]
	public Item GetSelectedItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x1380CF0", Offset = "0x1380CF0", VA = "0x1380CF0")]
	public void DrawUnequipButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x13815A0", Offset = "0x13815A0", VA = "0x13815A0")]
	public bool CanBeHiddenOrShow()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x13815A8", Offset = "0x13815A8", VA = "0x13815A8")]
	public void DrawExpandButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x13815AC", Offset = "0x13815AC", VA = "0x13815AC")]
	public void DrawHideShowButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x1382198", Offset = "0x1382198", VA = "0x1382198")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x1382354", Offset = "0x1382354", VA = "0x1382354")]
	public GUIEquipment()
	{
	}
}
