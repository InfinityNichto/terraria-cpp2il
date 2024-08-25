using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001D7")]
public class Hearts_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C10")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6A90", Offset = "0x9B6A90", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C11")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6ADC", Offset = "0x9B6ADC", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Hearts_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40010EA")]
	public static Hearts_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40010EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool HideWhenInventoryOpen;

	[global::Cpp2ILInjected.Token(Token = "0x40010EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout HealthTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40010ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout HealthValue;

	[global::Cpp2ILInjected.Token(Token = "0x40010EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float HeartsScale;

	[global::Cpp2ILInjected.Token(Token = "0x40010EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout HeartsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40010F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout HeartsGridController;

	[global::Cpp2ILInjected.Token(Token = "0x40010F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout HealthTitleController;

	[global::Cpp2ILInjected.Token(Token = "0x40010F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout HealthValueController;

	[global::Cpp2ILInjected.Token(Token = "0x40010F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ItemGrid_Layout HorizontalHeartsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40010F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ItemGrid_Layout HorizontalHeartsGridController;
}
