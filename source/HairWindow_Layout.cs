using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000150 RID: 336
[global::Cpp2ILInjected.Token(Token = "0x20001D5")]
public class HairWindow_Layout : LayoutDefinition
{
	// Token: 0x06000AFA RID: 2810 RVA: 0x00023C33 File Offset: 0x00021E33
	[global::Cpp2ILInjected.Token(Token = "0x6000C0D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6758", Offset = "0x9B6758", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00023C36 File Offset: 0x00021E36
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

	// Token: 0x04000CBB RID: 3259
	[global::Cpp2ILInjected.Token(Token = "0x40010BE")]
	public static HairWindow_Layout Instance;

	// Token: 0x04000CBC RID: 3260
	[global::Cpp2ILInjected.Token(Token = "0x40010BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000CBD RID: 3261
	[global::Cpp2ILInjected.Token(Token = "0x40010C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Title;

	// Token: 0x04000CBE RID: 3262
	[global::Cpp2ILInjected.Token(Token = "0x40010C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout HairGrid;

	// Token: 0x04000CBF RID: 3263
	[global::Cpp2ILInjected.Token(Token = "0x40010C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout CharacterBacking;

	// Token: 0x04000CC0 RID: 3264
	[global::Cpp2ILInjected.Token(Token = "0x40010C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout CharacterPosition;

	// Token: 0x04000CC1 RID: 3265
	[global::Cpp2ILInjected.Token(Token = "0x40010C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool SlidersExclusive;

	// Token: 0x04000CC2 RID: 3266
	[global::Cpp2ILInjected.Token(Token = "0x40010C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000CC3 RID: 3267
	[global::Cpp2ILInjected.Token(Token = "0x40010C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04000CC4 RID: 3268
	[global::Cpp2ILInjected.Token(Token = "0x40010C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Texture_Layout SlidersIcon;

	// Token: 0x04000CC5 RID: 3269
	[global::Cpp2ILInjected.Token(Token = "0x40010C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ColourButton;

	// Token: 0x04000CC6 RID: 3270
	[global::Cpp2ILInjected.Token(Token = "0x40010C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout HairStyleButton;

	// Token: 0x04000CC7 RID: 3271
	[global::Cpp2ILInjected.Token(Token = "0x40010CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout SlidersBacking;

	// Token: 0x04000CC8 RID: 3272
	[global::Cpp2ILInjected.Token(Token = "0x40010CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout LightnessBacking;

	// Token: 0x04000CC9 RID: 3273
	[global::Cpp2ILInjected.Token(Token = "0x40010CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Slider_Layout Lightness;

	// Token: 0x04000CCA RID: 3274
	[global::Cpp2ILInjected.Token(Token = "0x40010CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout SaturationBacking;

	// Token: 0x04000CCB RID: 3275
	[global::Cpp2ILInjected.Token(Token = "0x40010CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Slider_Layout Saturation;

	// Token: 0x04000CCC RID: 3276
	[global::Cpp2ILInjected.Token(Token = "0x40010CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout HueBacking;

	// Token: 0x04000CCD RID: 3277
	[global::Cpp2ILInjected.Token(Token = "0x40010D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Slider_Layout Hue;

	// Token: 0x04000CCE RID: 3278
	[global::Cpp2ILInjected.Token(Token = "0x40010D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout ColourValue;

	// Token: 0x04000CCF RID: 3279
	[global::Cpp2ILInjected.Token(Token = "0x40010D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public float HairScale;

	// Token: 0x04000CD0 RID: 3280
	[global::Cpp2ILInjected.Token(Token = "0x40010D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public float HairHighlightScale;

	// Token: 0x04000CD1 RID: 3281
	[global::Cpp2ILInjected.Token(Token = "0x40010D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout SavingsBacking;

	// Token: 0x04000CD2 RID: 3282
	[global::Cpp2ILInjected.Token(Token = "0x40010D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout Savings;

	// Token: 0x04000CD3 RID: 3283
	[global::Cpp2ILInjected.Token(Token = "0x40010D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public String_Layout Cost;

	// Token: 0x04000CD4 RID: 3284
	[global::Cpp2ILInjected.Token(Token = "0x40010D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public String_Layout ControllerCost;

	// Token: 0x04000CD5 RID: 3285
	[global::Cpp2ILInjected.Token(Token = "0x40010D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public String_Layout SavingsTitle;

	// Token: 0x04000CD6 RID: 3286
	[global::Cpp2ILInjected.Token(Token = "0x40010D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Vector2 Savings1IconOffset;

	// Token: 0x04000CD7 RID: 3287
	[global::Cpp2ILInjected.Token(Token = "0x40010DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Vector2 Savings2IconOffset;

	// Token: 0x04000CD8 RID: 3288
	[global::Cpp2ILInjected.Token(Token = "0x40010DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Vector2 Savings3IconOffset;

	// Token: 0x04000CD9 RID: 3289
	[global::Cpp2ILInjected.Token(Token = "0x40010DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Vector2 Savings4IconOffset;

	// Token: 0x04000CDA RID: 3290
	[global::Cpp2ILInjected.Token(Token = "0x40010DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout Close;

	// Token: 0x04000CDB RID: 3291
	[global::Cpp2ILInjected.Token(Token = "0x40010DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout ActionButton;

	// Token: 0x04000CDC RID: 3292
	[global::Cpp2ILInjected.Token(Token = "0x40010DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public bool DrawEmptySlots;

	// Token: 0x04000CDD RID: 3293
	[global::Cpp2ILInjected.Token(Token = "0x40010E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04000CDE RID: 3294
	[global::Cpp2ILInjected.Token(Token = "0x40010E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Color DisabledBackingColor;

	// Token: 0x04000CDF RID: 3295
	[global::Cpp2ILInjected.Token(Token = "0x40010E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04000CE0 RID: 3296
	[global::Cpp2ILInjected.Token(Token = "0x40010E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Color DisabledBackingIconColor;
}
