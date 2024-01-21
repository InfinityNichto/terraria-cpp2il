using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200014B")]
public class Crafting_Layout : PageControllerLayoutDefinition<Crafting_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000C21")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000C22")]
	public float CraftItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000C23")]
	public float CraftItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000C24")]
	public DraggableItemGrid_Layout CraftItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000C25")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000C26")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000C27")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000C28")]
	public float MaterialItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000C29")]
	public Vector2 MaterialTooltipOriginOffsetLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000C2A")]
	public Vector2 MaterialTooltipOriginOffsetRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000C2B")]
	public ItemGrid_Layout MaterialsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000C2C")]
	public ItemGrid_Layout MaterialsGridController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000C2D")]
	public String_Layout MaterialsTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000C2E")]
	public String_Layout NoRecipes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000C2F")]
	public String_Layout NoRecipesController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000C30")]
	public bool ReverseScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
	[Cpp2IlInjected.Token(Token = "0x4000C31")]
	public bool DrawEmptySlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000C32")]
	public Texture_Layout DisabledBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000C33")]
	public Color DisabledBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000C34")]
	public Texture_Layout DisabledBackingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000C35")]
	public Color DisabledBackingIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000C36")]
	public TransactionButton_Layout CraftButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000C37")]
	public TransactionButton_Layout DuplicationButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000C38")]
	public bool DisableMaterialBackings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000C39")]
	public Texture_Layout MaterialBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000C3A")]
	public Texture_Layout MaterialBackingHighlght;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000C3B")]
	public Color MaterialBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000C3C")]
	public Color MaterialBackingHighlightColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000C3D")]
	public bool OverrideMaterialItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000C3E")]
	public float OverridenMaterialItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000C3F")]
	public bool OverrideMaterialTextScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000C40")]
	public float OverridenMaterialTextScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000C41")]
	public Vector2 MaterialItemTextOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000C42")]
	public Color DisabledDuplicationBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000C43")]
	public Texture_Layout DisabledDuplicationBackingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000C44")]
	public Color DisabledDuplicationBackingIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000C45")]
	public Color DuplicationBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000C46")]
	public Color DuplicationBackingHighlightColor;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public DraggableItemGrid_Layout CraftGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x20C57E4", Offset = "0x20C57E4", VA = "0x20C57E4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public DraggableItemGrid_Layout DuplicateGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(RVA = "0x20C587C", Offset = "0x20C587C", VA = "0x20C587C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x20C5914", Offset = "0x20C5914", VA = "0x20C5914")]
	public Crafting_Layout()
	{
	}
}
