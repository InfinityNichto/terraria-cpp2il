using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200019F RID: 415
[global::Cpp2ILInjected.Token(Token = "0x200022E")]
public class PickupContextMenu_Layout : LayoutDefinition
{
	// Token: 0x06000BDA RID: 3034 RVA: 0x00023ED3 File Offset: 0x000220D3
	[global::Cpp2ILInjected.Token(Token = "0x6000CF4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D13CC", Offset = "0x9D13CC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x00023ED6 File Offset: 0x000220D6
	[global::Cpp2ILInjected.Token(Token = "0x6000CF5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1418", Offset = "0x9D1418", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PickupContextMenu_Layout()
	{
		throw null;
	}

	// Token: 0x040011C4 RID: 4548
	[global::Cpp2ILInjected.Token(Token = "0x4001679")]
	public static PickupContextMenu_Layout Instance;

	// Token: 0x040011C5 RID: 4549
	[global::Cpp2ILInjected.Token(Token = "0x400167A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout LeftThrow;

	// Token: 0x040011C6 RID: 4550
	[global::Cpp2ILInjected.Token(Token = "0x400167B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout LeftTrash;

	// Token: 0x040011C7 RID: 4551
	[global::Cpp2ILInjected.Token(Token = "0x400167C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout LeftDeposit;

	// Token: 0x040011C8 RID: 4552
	[global::Cpp2ILInjected.Token(Token = "0x400167D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout RightThrow;

	// Token: 0x040011C9 RID: 4553
	[global::Cpp2ILInjected.Token(Token = "0x400167E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout RightTrash;

	// Token: 0x040011CA RID: 4554
	[global::Cpp2ILInjected.Token(Token = "0x400167F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout RightDeposit;
}
