using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000133 RID: 307
[global::Cpp2ILInjected.Token(Token = "0x20001AF")]
[Serializable]
public class DraggableItemGrid_Layout : ItemGrid_Layout
{
	// Token: 0x06000AAC RID: 2732 RVA: 0x00023B49 File Offset: 0x00021D49
	[global::Cpp2ILInjected.Token(Token = "0x6000BBB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2524", Offset = "0x9B2524", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemGrid_Layout), Member = ".ctor", ReturnType = typeof(void))]
	public DraggableItemGrid_Layout()
	{
		throw null;
	}

	// Token: 0x04000A68 RID: 2664
	[global::Cpp2ILInjected.Token(Token = "0x4000E28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float MomentumScale;

	// Token: 0x04000A69 RID: 2665
	[global::Cpp2ILInjected.Token(Token = "0x4000E29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float MomentumDampen;

	// Token: 0x04000A6A RID: 2666
	[global::Cpp2ILInjected.Token(Token = "0x4000E2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public float MomentumExtraDampenOutOfBounds;

	// Token: 0x04000A6B RID: 2667
	[global::Cpp2ILInjected.Token(Token = "0x4000E2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public float OutOfBoundsOffsetLerpScale;

	// Token: 0x04000A6C RID: 2668
	[global::Cpp2ILInjected.Token(Token = "0x4000E2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public int AlphaFalloff;

	// Token: 0x04000A6D RID: 2669
	[global::Cpp2ILInjected.Token(Token = "0x4000E2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public bool DragHorizontal;

	// Token: 0x04000A6E RID: 2670
	[global::Cpp2ILInjected.Token(Token = "0x4000E2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public float DragThreshold;

	// Token: 0x04000A6F RID: 2671
	[global::Cpp2ILInjected.Token(Token = "0x4000E2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public bool EnableDragUnderLimit;

	// Token: 0x04000A70 RID: 2672
	[global::Cpp2ILInjected.Token(Token = "0x4000E30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public Vector2 MaxDragRegion;

	// Token: 0x04000A71 RID: 2673
	[global::Cpp2ILInjected.Token(Token = "0x4000E31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public bool ExplicitDragRegionSize;

	// Token: 0x04000A72 RID: 2674
	[global::Cpp2ILInjected.Token(Token = "0x4000E32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public ControlAnchor.ControlId DragRegionEndAnchorControl;

	// Token: 0x04000A73 RID: 2675
	[global::Cpp2ILInjected.Token(Token = "0x4000E33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public LayoutCalculator.AnchorType DragRegionEndItemAnchor;

	// Token: 0x04000A74 RID: 2676
	[global::Cpp2ILInjected.Token(Token = "0x4000E34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Vector2 DragRegionEndItemLocation;

	// Token: 0x04000A75 RID: 2677
	[global::Cpp2ILInjected.Token(Token = "0x4000E35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public int DragRegionTopOffset;

	// Token: 0x04000A76 RID: 2678
	[global::Cpp2ILInjected.Token(Token = "0x4000E36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public int DragRegionBottomOffset;
}
