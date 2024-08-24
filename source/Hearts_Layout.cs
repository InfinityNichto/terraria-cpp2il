using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000152 RID: 338
[global::Cpp2ILInjected.Token(Token = "0x20001D7")]
public class Hearts_Layout : LayoutDefinition
{
	// Token: 0x06000AFD RID: 2813 RVA: 0x00023C3C File Offset: 0x00021E3C
	[global::Cpp2ILInjected.Token(Token = "0x6000C10")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6A90", Offset = "0x9B6A90", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00023C3F File Offset: 0x00021E3F
	[global::Cpp2ILInjected.Token(Token = "0x6000C11")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6ADC", Offset = "0x9B6ADC", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Hearts_Layout()
	{
		throw null;
	}

	// Token: 0x04000CE7 RID: 3303
	[global::Cpp2ILInjected.Token(Token = "0x40010EA")]
	public static Hearts_Layout Instance;

	// Token: 0x04000CE8 RID: 3304
	[global::Cpp2ILInjected.Token(Token = "0x40010EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool HideWhenInventoryOpen;

	// Token: 0x04000CE9 RID: 3305
	[global::Cpp2ILInjected.Token(Token = "0x40010EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout HealthTitle;

	// Token: 0x04000CEA RID: 3306
	[global::Cpp2ILInjected.Token(Token = "0x40010ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout HealthValue;

	// Token: 0x04000CEB RID: 3307
	[global::Cpp2ILInjected.Token(Token = "0x40010EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float HeartsScale;

	// Token: 0x04000CEC RID: 3308
	[global::Cpp2ILInjected.Token(Token = "0x40010EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout HeartsGrid;

	// Token: 0x04000CED RID: 3309
	[global::Cpp2ILInjected.Token(Token = "0x40010F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout HeartsGridController;

	// Token: 0x04000CEE RID: 3310
	[global::Cpp2ILInjected.Token(Token = "0x40010F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout HealthTitleController;

	// Token: 0x04000CEF RID: 3311
	[global::Cpp2ILInjected.Token(Token = "0x40010F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout HealthValueController;

	// Token: 0x04000CF0 RID: 3312
	[global::Cpp2ILInjected.Token(Token = "0x40010F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ItemGrid_Layout HorizontalHeartsGrid;

	// Token: 0x04000CF1 RID: 3313
	[global::Cpp2ILInjected.Token(Token = "0x40010F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ItemGrid_Layout HorizontalHeartsGridController;
}
