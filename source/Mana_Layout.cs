using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000167 RID: 359
[global::Cpp2ILInjected.Token(Token = "0x20001F1")]
public class Mana_Layout : LayoutDefinition
{
	// Token: 0x06000B64 RID: 2916 RVA: 0x00023D71 File Offset: 0x00021F71
	[global::Cpp2ILInjected.Token(Token = "0x6000C79")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE5C0", Offset = "0x9CE5C0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00023D74 File Offset: 0x00021F74
	[global::Cpp2ILInjected.Token(Token = "0x6000C7A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE60C", Offset = "0x9CE60C", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Mana_Layout()
	{
		throw null;
	}

	// Token: 0x04000DB9 RID: 3513
	[global::Cpp2ILInjected.Token(Token = "0x4001206")]
	public static Mana_Layout Instance;

	// Token: 0x04000DBA RID: 3514
	[global::Cpp2ILInjected.Token(Token = "0x4001207")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool HideWhenInventoryOpen;

	// Token: 0x04000DBB RID: 3515
	[global::Cpp2ILInjected.Token(Token = "0x4001208")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Mana;

	// Token: 0x04000DBC RID: 3516
	[global::Cpp2ILInjected.Token(Token = "0x4001209")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout ManaHorizontal;

	// Token: 0x04000DBD RID: 3517
	[global::Cpp2ILInjected.Token(Token = "0x400120A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout ManaValue;

	// Token: 0x04000DBE RID: 3518
	[global::Cpp2ILInjected.Token(Token = "0x400120B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout ManaValueHorizontal;

	// Token: 0x04000DBF RID: 3519
	[global::Cpp2ILInjected.Token(Token = "0x400120C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float StarScale;

	// Token: 0x04000DC0 RID: 3520
	[global::Cpp2ILInjected.Token(Token = "0x400120D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout ManaGrid;

	// Token: 0x04000DC1 RID: 3521
	[global::Cpp2ILInjected.Token(Token = "0x400120E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout ManaController;

	// Token: 0x04000DC2 RID: 3522
	[global::Cpp2ILInjected.Token(Token = "0x400120F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public String_Layout ManaControllerHorizontal;

	// Token: 0x04000DC3 RID: 3523
	[global::Cpp2ILInjected.Token(Token = "0x4001210")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout ManaValueController;

	// Token: 0x04000DC4 RID: 3524
	[global::Cpp2ILInjected.Token(Token = "0x4001211")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public String_Layout ManaValueControllerHorizontal;

	// Token: 0x04000DC5 RID: 3525
	[global::Cpp2ILInjected.Token(Token = "0x4001212")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout ManaGridController;

	// Token: 0x04000DC6 RID: 3526
	[global::Cpp2ILInjected.Token(Token = "0x4001213")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ItemGrid_Layout ManaGridHorizontal;

	// Token: 0x04000DC7 RID: 3527
	[global::Cpp2ILInjected.Token(Token = "0x4001214")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public ItemGrid_Layout ManaGridControllerHorizontal;
}
