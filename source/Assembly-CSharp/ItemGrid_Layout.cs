using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000135 RID: 309
[global::Cpp2ILInjected.Token(Token = "0x20001B1")]
[Serializable]
public class ItemGrid_Layout
{
	// Token: 0x06000AAE RID: 2734 RVA: 0x00023B4F File Offset: 0x00021D4F
	[global::Cpp2ILInjected.Token(Token = "0x6000BBD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B25B0", Offset = "0x9B25B0", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DraggableItemGrid_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ItemGrid_Layout()
	{
		throw null;
	}

	// Token: 0x04000A79 RID: 2681
	[global::Cpp2ILInjected.Token(Token = "0x4000E39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool Horizontal;

	// Token: 0x04000A7A RID: 2682
	[global::Cpp2ILInjected.Token(Token = "0x4000E3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public ItemGrid_Layout.ReorderStyle Reorder;

	// Token: 0x04000A7B RID: 2683
	[global::Cpp2ILInjected.Token(Token = "0x4000E3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int ItemCount;

	// Token: 0x04000A7C RID: 2684
	[global::Cpp2ILInjected.Token(Token = "0x4000E3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int ItemLineCount;

	// Token: 0x04000A7D RID: 2685
	[global::Cpp2ILInjected.Token(Token = "0x4000E3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 PickingBorder;

	// Token: 0x04000A7E RID: 2686
	[global::Cpp2ILInjected.Token(Token = "0x4000E3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 PickingOffset;

	// Token: 0x04000A7F RID: 2687
	[global::Cpp2ILInjected.Token(Token = "0x4000E3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 ExtraElementSpacing;

	// Token: 0x04000A80 RID: 2688
	[global::Cpp2ILInjected.Token(Token = "0x4000E40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ControlAnchor.ControlId FirstAnchorControl;

	// Token: 0x04000A81 RID: 2689
	[global::Cpp2ILInjected.Token(Token = "0x4000E41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public LayoutCalculator.AnchorType FirstItemAnchor;

	// Token: 0x04000A82 RID: 2690
	[global::Cpp2ILInjected.Token(Token = "0x4000E42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 FirstItemLocation;

	// Token: 0x04000A83 RID: 2691
	[global::Cpp2ILInjected.Token(Token = "0x4000E43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 StackCountOffset;

	// Token: 0x04000A84 RID: 2692
	[global::Cpp2ILInjected.Token(Token = "0x4000E44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 AmmoCountOffset;

	// Token: 0x04000A85 RID: 2693
	[global::Cpp2ILInjected.Token(Token = "0x4000E45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public bool CentreAlign;

	// Token: 0x04000A86 RID: 2694
	[global::Cpp2ILInjected.Token(Token = "0x4000E46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
	public bool RightAlign;

	// Token: 0x020007DD RID: 2013
	[global::Cpp2ILInjected.Token(Token = "0x20001B2")]
	public enum ReorderStyle
	{
		// Token: 0x04007B8B RID: 31627
		[global::Cpp2ILInjected.Token(Token = "0x4000E48")]
		None,
		// Token: 0x04007B8C RID: 31628
		[global::Cpp2ILInjected.Token(Token = "0x4000E49")]
		ReverseAllItems,
		// Token: 0x04007B8D RID: 31629
		[global::Cpp2ILInjected.Token(Token = "0x4000E4A")]
		ReverseLine,
		// Token: 0x04007B8E RID: 31630
		[global::Cpp2ILInjected.Token(Token = "0x4000E4B")]
		ReverseColumns,
		// Token: 0x04007B8F RID: 31631
		[global::Cpp2ILInjected.Token(Token = "0x4000E4C")]
		SwapColumns
	}
}
