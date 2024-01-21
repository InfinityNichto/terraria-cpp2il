using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class RubbleMakerUI_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40012A5")]
	public static RubbleMakerUI_Layout InstanceNormal;

	[Cpp2IlInjected.Token(Token = "0x40012A6")]
	public static RubbleMakerUI_Layout Instance4Page;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40012A7")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40012A8")]
	public ItemGrid_Layout MaterialOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40012A9")]
	public ItemGrid_Layout RubbleOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40012AA")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40012AB")]
	public bool DrawEmptySlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40012AC")]
	public Texture_Layout DisabledBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40012AD")]
	public Color DisabledBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40012AE")]
	public Texture_Layout DisabledBackingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40012AF")]
	public Color DisabledBackingIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40012B0")]
	public Vector2 TouchPanelOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40012B1")]
	public TransactionButton_Layout SizeToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40012B2")]
	public TransactionButton_Layout MaterialToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40012B3")]
	public float MaterialScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40012B4")]
	public float HighlightedMaterialScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40012B5")]
	public float RubbleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40012B6")]
	public float HighlightedRubbleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40012B7")]
	public Vector2 SmallRubblePreviewScaleOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40012B8")]
	public float SmallRubblePreviewScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40012B9")]
	public Vector2 MediumRubblePreviewScaleOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40012BA")]
	public float MediumRubblePreviewScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40012BB")]
	public Vector2 LargeRubblePreviewScaleOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40012BC")]
	public float LargeRubblePreviewScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40012BD")]
	public Panel_Layout MaterialBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40012BE")]
	public Vector2 MaterialBackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40012BF")]
	public Vector2 MaterialBackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40012C0")]
	public FadeString_Layout TooltipDisplay;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public static RubbleMakerUI_Layout Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0xF9BC48", Offset = "0xF9BC48", VA = "0xF9BC48")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0xF9BCC8", Offset = "0xF9BCC8", VA = "0xF9BCC8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C09")]
	[Cpp2IlInjected.Address(RVA = "0xF9BD48", Offset = "0xF9BD48", VA = "0xF9BD48")]
	public RubbleMakerUI_Layout()
	{
	}
}
