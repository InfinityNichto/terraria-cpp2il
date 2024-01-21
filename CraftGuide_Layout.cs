using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200014A")]
public class CraftGuide_Layout : PageControllerLayoutDefinition<CraftGuide_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000C04")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000C05")]
	public float CraftItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000C06")]
	public float CraftItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000C07")]
	public DraggableItemGrid_Layout CraftItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000C08")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000C09")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000C0A")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000C0B")]
	public Button_Layout SelectedCraftItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000C0C")]
	public float MaterialItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000C0D")]
	public ItemGrid_Layout MaterialsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000C0E")]
	public ItemGrid_Layout MaterialsGridController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000C0F")]
	public String_Layout CraftItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000C10")]
	public String_Layout CraftItemName2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000C11")]
	public String_Layout CraftItemNameController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000C12")]
	public String_Layout CraftItemName2Controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000C13")]
	public String_Layout MaterialsTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000C14")]
	public String_Layout RequiredObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000C15")]
	public String_Layout Required1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000C16")]
	public String_Layout Required2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000C17")]
	public String_Layout RequiredObjectsController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000C18")]
	public String_Layout Required1Controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000C19")]
	public String_Layout Required2Controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000C1A")]
	public bool ReverseScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
	[Cpp2IlInjected.Token(Token = "0x4000C1B")]
	public bool DrawEmptySlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000C1C")]
	public Texture_Layout DisabledBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000C1D")]
	public Color DisabledBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000C1E")]
	public Texture_Layout DisabledBackingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000C1F")]
	public Color DisabledBackingIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000C20")]
	public TransactionButton_Layout GuideButton;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public DraggableItemGrid_Layout DisplayGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x20C5620", Offset = "0x20C5620", VA = "0x20C5620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x20C56B8", Offset = "0x20C56B8", VA = "0x20C56B8")]
	public CraftGuide_Layout()
	{
	}
}
