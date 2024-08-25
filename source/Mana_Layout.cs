using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001F1")]
public class Mana_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C79")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE5C0", Offset = "0x9CE5C0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C7A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE60C", Offset = "0x9CE60C", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Mana_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001206")]
	public static Mana_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001207")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool HideWhenInventoryOpen;

	[global::Cpp2ILInjected.Token(Token = "0x4001208")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Mana;

	[global::Cpp2ILInjected.Token(Token = "0x4001209")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout ManaHorizontal;

	[global::Cpp2ILInjected.Token(Token = "0x400120A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout ManaValue;

	[global::Cpp2ILInjected.Token(Token = "0x400120B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout ManaValueHorizontal;

	[global::Cpp2ILInjected.Token(Token = "0x400120C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float StarScale;

	[global::Cpp2ILInjected.Token(Token = "0x400120D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout ManaGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400120E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout ManaController;

	[global::Cpp2ILInjected.Token(Token = "0x400120F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public String_Layout ManaControllerHorizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001210")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout ManaValueController;

	[global::Cpp2ILInjected.Token(Token = "0x4001211")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public String_Layout ManaValueControllerHorizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001212")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout ManaGridController;

	[global::Cpp2ILInjected.Token(Token = "0x4001213")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ItemGrid_Layout ManaGridHorizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001214")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public ItemGrid_Layout ManaGridControllerHorizontal;
}
