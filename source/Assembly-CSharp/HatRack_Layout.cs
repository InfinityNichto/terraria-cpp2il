using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000151 RID: 337
[global::Cpp2ILInjected.Token(Token = "0x20001D6")]
public class HatRack_Layout : PageControllerLayoutDefinition<HatRack_Layout>
{
	// Token: 0x06000AFC RID: 2812 RVA: 0x00023C39 File Offset: 0x00021E39
	[global::Cpp2ILInjected.Token(Token = "0x6000C0F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6A3C", Offset = "0x9B6A3C", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public HatRack_Layout()
	{
		throw null;
	}

	// Token: 0x04000CE1 RID: 3297
	[global::Cpp2ILInjected.Token(Token = "0x40010E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x04000CE2 RID: 3298
	[global::Cpp2ILInjected.Token(Token = "0x40010E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float HatScale;

	// Token: 0x04000CE3 RID: 3299
	[global::Cpp2ILInjected.Token(Token = "0x40010E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float HatHighlightScale;

	// Token: 0x04000CE4 RID: 3300
	[global::Cpp2ILInjected.Token(Token = "0x40010E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout HatDye;

	// Token: 0x04000CE5 RID: 3301
	[global::Cpp2ILInjected.Token(Token = "0x40010E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout Hat;

	// Token: 0x04000CE6 RID: 3302
	[global::Cpp2ILInjected.Token(Token = "0x40010E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout RemoveButton;
}
