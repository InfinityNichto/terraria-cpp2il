using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class GUIDisplayDoll
{
	[Cpp2IlInjected.Token(Token = "0x20007B8")]
	private enum EquipmentItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40079F6")]
		Armour,
		[Cpp2IlInjected.Token(Token = "0x40079F7")]
		ArmourDye,
		[Cpp2IlInjected.Token(Token = "0x40079F8")]
		Accessory,
		[Cpp2IlInjected.Token(Token = "0x40079F9")]
		AccessoryDye
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private int itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private int itemDragStartArmour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private int itemDragStartArmourDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private int itemDragStartAccessory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private int itemDragStartAccessoryDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private EquipmentItemType itemType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private int itemPieceSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private float UnequipButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private float HideShowButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private TEDisplayDoll DisplayDoll;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x12CA368", Offset = "0x12CA368", VA = "0x12CA368")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x12C96D4", Offset = "0x12C96D4", VA = "0x12C96D4")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(RVA = "0x12C9888", Offset = "0x12C9888", VA = "0x12C9888")]
	public float ArmourScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000760")]
	[Cpp2IlInjected.Address(RVA = "0x12C98E0", Offset = "0x12C98E0", VA = "0x12C98E0")]
	public float ArmourDyeScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(RVA = "0x12C9938", Offset = "0x12C9938", VA = "0x12C9938")]
	private void ItemOver(Item[] inv, int index, EquipmentItemType equipmentType, int itemContext, ref int itemDragStart)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(RVA = "0x12C9E3C", Offset = "0x12C9E3C", VA = "0x12C9E3C")]
	public void ArmourOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(RVA = "0x12C9E74", Offset = "0x12C9E74", VA = "0x12C9E74")]
	public void ArmourDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(RVA = "0x12CA574", Offset = "0x12CA574", VA = "0x12CA574")]
	public void ArmourDyeOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0x12CA5AC", Offset = "0x12CA5AC", VA = "0x12CA5AC")]
	public void ArmourDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x12CAA94", Offset = "0x12CAA94", VA = "0x12CAA94")]
	public int CanBeEquipedAccessory(Item checkItem)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x12CACAC", Offset = "0x12CACAC", VA = "0x12CACAC")]
	public bool CanBeEquiped(Item checkItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x12CACE4", Offset = "0x12CACE4", VA = "0x12CACE4")]
	public bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x12CA440", Offset = "0x12CA440", VA = "0x12CA440")]
	private bool CanBeStored(int context, Item checkItem, int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x12CAD28", Offset = "0x12CAD28", VA = "0x12CAD28")]
	private void DrawArmour()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x12CB230", Offset = "0x12CB230", VA = "0x12CB230")]
	public float AccessoryScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x12CB288", Offset = "0x12CB288", VA = "0x12CB288")]
	public float AccessoryDyeScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x12CB2E0", Offset = "0x12CB2E0", VA = "0x12CB2E0")]
	public void AccessoryOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x12CB31C", Offset = "0x12CB31C", VA = "0x12CB31C")]
	public void AccessoryDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x12CB814", Offset = "0x12CB814", VA = "0x12CB814")]
	public void AccessoryDyeOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000770")]
	[Cpp2IlInjected.Address(RVA = "0x12CB850", Offset = "0x12CB850", VA = "0x12CB850")]
	public void AccessoryDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x12CBD4C", Offset = "0x12CBD4C", VA = "0x12CBD4C")]
	private void DrawAccesories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x12CC248", Offset = "0x12CC248", VA = "0x12CC248")]
	public Item GetSelectedItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x12CC28C", Offset = "0x12CC28C", VA = "0x12CC28C")]
	public void DrawUnequipButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x12CCC88", Offset = "0x12CCC88", VA = "0x12CCC88")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x12CD060", Offset = "0x12CD060", VA = "0x12CD060")]
	public GUIDisplayDoll()
	{
	}
}
