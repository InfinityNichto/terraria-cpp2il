using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000134")]
public class DraggableItemGrid_Layout : ItemGrid_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000A71")]
	public float MomentumScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000A72")]
	public float MomentumDampen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000A73")]
	public float MomentumExtraDampenOutOfBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000A74")]
	public float OutOfBoundsOffsetLerpScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000A75")]
	public int AlphaFalloff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000A76")]
	public bool DragHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000A77")]
	public float DragThreshold;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000A78")]
	public bool EnableDragUnderLimit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000A79")]
	public Vector2 MaxDragRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000A7A")]
	public bool ExplicitDragRegionSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000A7B")]
	public ControlAnchor.ControlId DragRegionEndAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000A7C")]
	public LayoutCalculator.AnchorType DragRegionEndItemAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000A7D")]
	public Vector2 DragRegionEndItemLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000A7E")]
	public int DragRegionTopOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000A7F")]
	public int DragRegionBottomOffset;

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x20D1C10", Offset = "0x20D1C10", VA = "0x20D1C10")]
	public DraggableItemGrid_Layout()
	{
	}
}
