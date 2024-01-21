using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200011E")]
public class BuilderAccToggles_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000978")]
	public static BuilderAccToggles_Layout InstanceNormal;

	[Cpp2IlInjected.Token(Token = "0x4000979")]
	public static BuilderAccToggles_Layout Instance4Page;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400097A")]
	public TransactionButton_Layout ControllerToggleBuilderAccessories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400097B")]
	public TransactionButton_Layout ToggleBuilderAccessories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400097C")]
	public TransactionButton_Layout ToggleBuilderAccessories_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400097D")]
	public Vector2 BackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400097E")]
	public Vector2 BackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400097F")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000980")]
	public float ToggleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000981")]
	public float ToggleIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000982")]
	public ItemGrid_Layout ToggleOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000983")]
	public ItemGrid_Layout ToggleOptions_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000984")]
	public TransactionButton_Layout ToggleEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000985")]
	public Texture_Layout AccBackingTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000986")]
	public Color AccBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000987")]
	public Texture_Layout AccHighlightTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000988")]
	public Color AccHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000989")]
	public FadeString_Layout TooltipDisplay;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public static BuilderAccToggles_Layout Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x1201C34", Offset = "0x1201C34", VA = "0x1201C34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public ItemGrid_Layout ToggleOptionsGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x1201CB4", Offset = "0x1201CB4", VA = "0x1201CB4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x1201D2C", Offset = "0x1201D2C", VA = "0x1201D2C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x1201DAC", Offset = "0x1201DAC", VA = "0x1201DAC")]
	public BuilderAccToggles_Layout()
	{
	}
}
