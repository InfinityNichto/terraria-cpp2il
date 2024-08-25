using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001D5")]
public class HairWindow_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C0D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6758", Offset = "0x9B6758", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C0E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B67A4", Offset = "0x9B67A4", Length = "0x298")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider_Layout), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public HairWindow_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40010BE")]
	public static HairWindow_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40010BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40010C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40010C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout HairGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40010C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout CharacterBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout CharacterPosition;

	[global::Cpp2ILInjected.Token(Token = "0x40010C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool SlidersExclusive;

	[global::Cpp2ILInjected.Token(Token = "0x40010C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40010C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x40010C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Texture_Layout SlidersIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40010C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ColourButton;

	[global::Cpp2ILInjected.Token(Token = "0x40010C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout HairStyleButton;

	[global::Cpp2ILInjected.Token(Token = "0x40010CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout SlidersBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout LightnessBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Slider_Layout Lightness;

	[global::Cpp2ILInjected.Token(Token = "0x40010CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout SaturationBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Slider_Layout Saturation;

	[global::Cpp2ILInjected.Token(Token = "0x40010CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout HueBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Slider_Layout Hue;

	[global::Cpp2ILInjected.Token(Token = "0x40010D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout ColourValue;

	[global::Cpp2ILInjected.Token(Token = "0x40010D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public float HairScale;

	[global::Cpp2ILInjected.Token(Token = "0x40010D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public float HairHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x40010D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout SavingsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout Savings;

	[global::Cpp2ILInjected.Token(Token = "0x40010D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public String_Layout Cost;

	[global::Cpp2ILInjected.Token(Token = "0x40010D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public String_Layout ControllerCost;

	[global::Cpp2ILInjected.Token(Token = "0x40010D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public String_Layout SavingsTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40010D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Vector2 Savings1IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40010DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Vector2 Savings2IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40010DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Vector2 Savings3IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40010DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Vector2 Savings4IconOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40010DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x40010DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout ActionButton;

	[global::Cpp2ILInjected.Token(Token = "0x40010DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public bool DrawEmptySlots;

	[global::Cpp2ILInjected.Token(Token = "0x40010E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Texture_Layout DisabledBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Color DisabledBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40010E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Texture_Layout DisabledBackingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40010E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Color DisabledBackingIconColor;
}
