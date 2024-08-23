using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x0200012E RID: 302
[global::Cpp2ILInjected.Token(Token = "0x20001A9")]
[Serializable]
public class Axis_Layout
{
	// Token: 0x06000A68 RID: 2664 RVA: 0x00023A7D File Offset: 0x00021C7D
	[global::Cpp2ILInjected.Token(Token = "0x6000B77")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AEA90", Offset = "0x9AEA90", Length = "0x228")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public Axis_Layout()
	{
		throw null;
	}

	// Token: 0x04000A3A RID: 2618
	[global::Cpp2ILInjected.Token(Token = "0x4000DD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000A3B RID: 2619
	[global::Cpp2ILInjected.Token(Token = "0x4000DD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000A3C RID: 2620
	[global::Cpp2ILInjected.Token(Token = "0x4000DD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Microsoft.Xna.Framework.Vector2 CentreLocation;

	// Token: 0x04000A3D RID: 2621
	[global::Cpp2ILInjected.Token(Token = "0x4000DD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float Scale;

	// Token: 0x04000A3E RID: 2622
	[global::Cpp2ILInjected.Token(Token = "0x4000DD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Microsoft.Xna.Framework.Graphics.Color Color;

	// Token: 0x04000A3F RID: 2623
	[global::Cpp2ILInjected.Token(Token = "0x4000DD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledColor;

	// Token: 0x04000A40 RID: 2624
	[global::Cpp2ILInjected.Token(Token = "0x4000DDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Microsoft.Xna.Framework.Graphics.Color AlternativeColor;

	// Token: 0x04000A41 RID: 2625
	[global::Cpp2ILInjected.Token(Token = "0x4000DDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Microsoft.Xna.Framework.Graphics.Color BackingColor;

	// Token: 0x04000A42 RID: 2626
	[global::Cpp2ILInjected.Token(Token = "0x4000DDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledBackingColor;

	// Token: 0x04000A43 RID: 2627
	[global::Cpp2ILInjected.Token(Token = "0x4000DDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Microsoft.Xna.Framework.Graphics.Color IconColor;

	// Token: 0x04000A44 RID: 2628
	[global::Cpp2ILInjected.Token(Token = "0x4000DDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledIconColor;

	// Token: 0x04000A45 RID: 2629
	[global::Cpp2ILInjected.Token(Token = "0x4000DDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool UseCirclePickingRegion;

	// Token: 0x04000A46 RID: 2630
	[global::Cpp2ILInjected.Token(Token = "0x4000DE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Microsoft.Xna.Framework.Vector2 PickSize;

	// Token: 0x04000A47 RID: 2631
	[global::Cpp2ILInjected.Token(Token = "0x4000DE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Microsoft.Xna.Framework.Vector2 DeadZone;

	// Token: 0x04000A48 RID: 2632
	[global::Cpp2ILInjected.Token(Token = "0x4000DE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public AnimationCurve AxisFalloff;

	// Token: 0x04000A49 RID: 2633
	[global::Cpp2ILInjected.Token(Token = "0x4000DE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public bool RecentreOnTouch;

	// Token: 0x04000A4A RID: 2634
	[global::Cpp2ILInjected.Token(Token = "0x4000DE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
	public bool RecentreInputOnly;

	// Token: 0x04000A4B RID: 2635
	[global::Cpp2ILInjected.Token(Token = "0x4000DE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public Microsoft.Xna.Framework.Vector2 NubbinPickSize;

	// Token: 0x04000A4C RID: 2636
	[global::Cpp2ILInjected.Token(Token = "0x4000DE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public bool Draggable;

	// Token: 0x04000A4D RID: 2637
	[global::Cpp2ILInjected.Token(Token = "0x4000DE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6D")]
	public bool UseCircleDeadZone;

	// Token: 0x04000A4E RID: 2638
	[global::Cpp2ILInjected.Token(Token = "0x4000DE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public int IconMaxSizeInset;

	// Token: 0x04000A4F RID: 2639
	[global::Cpp2ILInjected.Token(Token = "0x4000DE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public bool ClampInside;

	// Token: 0x04000A50 RID: 2640
	[global::Cpp2ILInjected.Token(Token = "0x4000DEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout Backing;

	// Token: 0x04000A51 RID: 2641
	[global::Cpp2ILInjected.Token(Token = "0x4000DEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Texture_Layout Inner;

	// Token: 0x04000A52 RID: 2642
	[global::Cpp2ILInjected.Token(Token = "0x4000DEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout AlternativeInner;
}
