using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200014C RID: 332
[global::Cpp2ILInjected.Token(Token = "0x20001D1")]
public class DisplayDoll_Layout : PageControllerLayoutDefinition<DisplayDoll_Layout>
{
	// Token: 0x06000AED RID: 2797 RVA: 0x00023C0C File Offset: 0x00021E0C
	[global::Cpp2ILInjected.Token(Token = "0x6000C00")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5E94", Offset = "0x9B5E94", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public DisplayDoll_Layout()
	{
		throw null;
	}

	// Token: 0x04000C48 RID: 3144
	[global::Cpp2ILInjected.Token(Token = "0x400104B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x04000C49 RID: 3145
	[global::Cpp2ILInjected.Token(Token = "0x400104C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float AmourScale;

	// Token: 0x04000C4A RID: 3146
	[global::Cpp2ILInjected.Token(Token = "0x400104D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ArmourHighlightScale;

	// Token: 0x04000C4B RID: 3147
	[global::Cpp2ILInjected.Token(Token = "0x400104E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout ArmourDye;

	// Token: 0x04000C4C RID: 3148
	[global::Cpp2ILInjected.Token(Token = "0x400104F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout Armor;

	// Token: 0x04000C4D RID: 3149
	[global::Cpp2ILInjected.Token(Token = "0x4001050")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float AccessoryScale;

	// Token: 0x04000C4E RID: 3150
	[global::Cpp2ILInjected.Token(Token = "0x4001051")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float AccessoryHighlightScale;

	// Token: 0x04000C4F RID: 3151
	[global::Cpp2ILInjected.Token(Token = "0x4001052")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout AccessoryDye;

	// Token: 0x04000C50 RID: 3152
	[global::Cpp2ILInjected.Token(Token = "0x4001053")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout Accessory;

	// Token: 0x04000C51 RID: 3153
	[global::Cpp2ILInjected.Token(Token = "0x4001054")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout RemoveButton;
}
