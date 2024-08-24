using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020001A4 RID: 420
[global::Cpp2ILInjected.Token(Token = "0x2000233")]
public class ReforgePopup_Layout : LayoutDefinition
{
	// Token: 0x06000BE7 RID: 3047 RVA: 0x00023EFA File Offset: 0x000220FA
	[global::Cpp2ILInjected.Token(Token = "0x6000D01")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D191C", Offset = "0x9D191C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x00023EFD File Offset: 0x000220FD
	[global::Cpp2ILInjected.Token(Token = "0x6000D02")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1968", Offset = "0x9D1968", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ReforgePopup_Layout()
	{
		throw null;
	}

	// Token: 0x04001233 RID: 4659
	[global::Cpp2ILInjected.Token(Token = "0x40016E8")]
	public static ReforgePopup_Layout Instance;

	// Token: 0x04001234 RID: 4660
	[global::Cpp2ILInjected.Token(Token = "0x40016E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int BackingTextPadding;

	// Token: 0x04001235 RID: 4661
	[global::Cpp2ILInjected.Token(Token = "0x40016EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int BackingTextPaddingController;

	// Token: 0x04001236 RID: 4662
	[global::Cpp2ILInjected.Token(Token = "0x40016EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int MinTextHeight;

	// Token: 0x04001237 RID: 4663
	[global::Cpp2ILInjected.Token(Token = "0x40016EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int TextBackingOffset;

	// Token: 0x04001238 RID: 4664
	[global::Cpp2ILInjected.Token(Token = "0x40016ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int MaxWidthLastLineAddition;

	// Token: 0x04001239 RID: 4665
	[global::Cpp2ILInjected.Token(Token = "0x40016EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	// Token: 0x0400123A RID: 4666
	[global::Cpp2ILInjected.Token(Token = "0x40016EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout Text;

	// Token: 0x0400123B RID: 4667
	[global::Cpp2ILInjected.Token(Token = "0x40016F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout TextBacking;

	// Token: 0x0400123C RID: 4668
	[global::Cpp2ILInjected.Token(Token = "0x40016F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout MenuDivider;

	// Token: 0x0400123D RID: 4669
	[global::Cpp2ILInjected.Token(Token = "0x40016F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	// Token: 0x0400123E RID: 4670
	[global::Cpp2ILInjected.Token(Token = "0x40016F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Reforge;

	// Token: 0x0400123F RID: 4671
	[global::Cpp2ILInjected.Token(Token = "0x40016F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout SavingsBacking;

	// Token: 0x04001240 RID: 4672
	[global::Cpp2ILInjected.Token(Token = "0x40016F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public String_Layout Savings;

	// Token: 0x04001241 RID: 4673
	[global::Cpp2ILInjected.Token(Token = "0x40016F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout SavingsTitle;

	// Token: 0x04001242 RID: 4674
	[global::Cpp2ILInjected.Token(Token = "0x40016F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Vector2 Savings1IconOffset;

	// Token: 0x04001243 RID: 4675
	[global::Cpp2ILInjected.Token(Token = "0x40016F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Vector2 Savings2IconOffset;

	// Token: 0x04001244 RID: 4676
	[global::Cpp2ILInjected.Token(Token = "0x40016F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Vector2 Savings3IconOffset;

	// Token: 0x04001245 RID: 4677
	[global::Cpp2ILInjected.Token(Token = "0x40016FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Vector2 Savings4IconOffset;

	// Token: 0x04001246 RID: 4678
	[global::Cpp2ILInjected.Token(Token = "0x40016FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout ReforgeCost;

	// Token: 0x04001247 RID: 4679
	[global::Cpp2ILInjected.Token(Token = "0x40016FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout ReforgeCostController;

	// Token: 0x04001248 RID: 4680
	[global::Cpp2ILInjected.Token(Token = "0x40016FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout ReforgeItemName;

	// Token: 0x04001249 RID: 4681
	[global::Cpp2ILInjected.Token(Token = "0x40016FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout ReforgeItemNameDivider;

	// Token: 0x0400124A RID: 4682
	[global::Cpp2ILInjected.Token(Token = "0x40016FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout ReforgeItem;

	// Token: 0x0400124B RID: 4683
	[global::Cpp2ILInjected.Token(Token = "0x4001700")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout ReforgeItemBacking;
}
