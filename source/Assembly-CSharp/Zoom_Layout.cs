using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x020001C0 RID: 448
[global::Cpp2ILInjected.Token(Token = "0x2000255")]
public class Zoom_Layout : LayoutDefinition
{
	// Token: 0x06000C3D RID: 3133 RVA: 0x00023FFC File Offset: 0x000221FC
	[global::Cpp2ILInjected.Token(Token = "0x6000D58")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7564", Offset = "0x9D7564", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x00023FFF File Offset: 0x000221FF
	[global::Cpp2ILInjected.Token(Token = "0x6000D59")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D75B0", Offset = "0x9D75B0", Length = "0x124")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public Zoom_Layout()
	{
		throw null;
	}

	// Token: 0x040013BB RID: 5051
	[global::Cpp2ILInjected.Token(Token = "0x40018A8")]
	public static Zoom_Layout Instance;

	// Token: 0x040013BC RID: 5052
	[global::Cpp2ILInjected.Token(Token = "0x40018A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ControlAnchor.ControlId SliderAnchorControl;

	// Token: 0x040013BD RID: 5053
	[global::Cpp2ILInjected.Token(Token = "0x40018AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public LayoutCalculator.AnchorType SliderAnchor;

	// Token: 0x040013BE RID: 5054
	[global::Cpp2ILInjected.Token(Token = "0x40018AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	// Token: 0x040013BF RID: 5055
	[global::Cpp2ILInjected.Token(Token = "0x40018AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float SliderBackScale;

	// Token: 0x040013C0 RID: 5056
	[global::Cpp2ILInjected.Token(Token = "0x40018AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	// Token: 0x040013C1 RID: 5057
	[global::Cpp2ILInjected.Token(Token = "0x40018AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float SliderIndicatorScale;

	// Token: 0x040013C2 RID: 5058
	[global::Cpp2ILInjected.Token(Token = "0x40018AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float SliderEndCap;

	// Token: 0x040013C3 RID: 5059
	[global::Cpp2ILInjected.Token(Token = "0x40018B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float SliderDefaultPosition;

	// Token: 0x040013C4 RID: 5060
	[global::Cpp2ILInjected.Token(Token = "0x40018B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public AnimationCurve SliderToPixelScale;

	// Token: 0x040013C5 RID: 5061
	[global::Cpp2ILInjected.Token(Token = "0x40018B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float PixelWorldScaleThreshold;

	// Token: 0x040013C6 RID: 5062
	[global::Cpp2ILInjected.Token(Token = "0x40018B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float DefaultCursorScale;

	// Token: 0x040013C7 RID: 5063
	[global::Cpp2ILInjected.Token(Token = "0x40018B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public bool ScaleCursorWithZoom;

	// Token: 0x040013C8 RID: 5064
	[global::Cpp2ILInjected.Token(Token = "0x40018B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float DefaultMagnifyCursorScale;

	// Token: 0x040013C9 RID: 5065
	[global::Cpp2ILInjected.Token(Token = "0x40018B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public bool MagnifyScaleCursorWithZoom;

	// Token: 0x040013CA RID: 5066
	[global::Cpp2ILInjected.Token(Token = "0x40018B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float ScopeXEdgeTrigger;

	// Token: 0x040013CB RID: 5067
	[global::Cpp2ILInjected.Token(Token = "0x40018B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float ScopeYEdgeTrigger;
}
