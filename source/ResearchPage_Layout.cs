using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001A7")]
public class ResearchPage_Layout : PageControllerLayoutDefinition<ResearchPage_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400126C")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400126D")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400126E")]
	public float ItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400126F")]
	public bool DrawEmptySlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001270")]
	public Texture_Layout DisabledBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001271")]
	public Color DisabledBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001272")]
	public Texture_Layout DisabledBackingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001273")]
	public Color DisabledBackingIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001274")]
	public DraggableItemGrid_Layout ResearchItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001275")]
	public DraggableItemGrid_Layout ResearchItemGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001276")]
	public DraggableItemGrid_Layout ResearchItemGrid_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001277")]
	public DraggableItemGrid_Layout ResearchItemGridCollapsed_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001278")]
	public TransactionButton_Layout ResearchButton;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0xF994EC", Offset = "0xF994EC", VA = "0xF994EC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFF")]
	[Cpp2IlInjected.Address(RVA = "0xF99584", Offset = "0xF99584", VA = "0xF99584")]
	public ResearchPage_Layout()
	{
	}
}
