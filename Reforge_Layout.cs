using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001A6")]
public class Reforge_Layout : PageControllerLayoutDefinition<Reforge_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001255")]
	public String_Layout Guide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001256")]
	public String_Layout Cost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001257")]
	public String_Layout ControllerCost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001258")]
	public Panel_Layout SavingsBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001259")]
	public String_Layout Savings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400125A")]
	public String_Layout SavingsTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400125B")]
	public Vector2 Savings1IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400125C")]
	public Vector2 Savings2IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400125D")]
	public Vector2 Savings3IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400125E")]
	public Vector2 Savings4IconOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400125F")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001260")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001261")]
	public float ItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001262")]
	public bool DrawEmptySlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001263")]
	public Texture_Layout DisabledBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001264")]
	public Color DisabledBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001265")]
	public Texture_Layout DisabledBackingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001266")]
	public Color DisabledBackingIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001267")]
	public DraggableItemGrid_Layout HorizontalReforgeItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001268")]
	public DraggableItemGrid_Layout HorizontalReforgeItemGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001269")]
	public DraggableItemGrid_Layout ReforgeItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400126A")]
	public DraggableItemGrid_Layout ReforgeItemGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400126B")]
	public TransactionButton_Layout ReforgeButton;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0xF99268", Offset = "0xF99268", VA = "0xF99268")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFD")]
	[Cpp2IlInjected.Address(RVA = "0xF99300", Offset = "0xF99300", VA = "0xF99300")]
	public Reforge_Layout()
	{
	}
}
