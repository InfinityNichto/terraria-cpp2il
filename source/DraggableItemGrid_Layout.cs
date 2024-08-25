using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20001AF")]
[Serializable]
public class DraggableItemGrid_Layout : ItemGrid_Layout
{
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

	[global::Cpp2ILInjected.Token(Token = "0x4000E28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float MomentumScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000E29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float MomentumDampen;

	[global::Cpp2ILInjected.Token(Token = "0x4000E2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public float MomentumExtraDampenOutOfBounds;

	[global::Cpp2ILInjected.Token(Token = "0x4000E2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public float OutOfBoundsOffsetLerpScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000E2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public int AlphaFalloff;

	[global::Cpp2ILInjected.Token(Token = "0x4000E2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public bool DragHorizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4000E2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public float DragThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x4000E2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public bool EnableDragUnderLimit;

	[global::Cpp2ILInjected.Token(Token = "0x4000E30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public Vector2 MaxDragRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4000E31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public bool ExplicitDragRegionSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000E32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public ControlAnchor.ControlId DragRegionEndAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000E33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public LayoutCalculator.AnchorType DragRegionEndItemAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Vector2 DragRegionEndItemLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000E35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public int DragRegionTopOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public int DragRegionBottomOffset;
}
