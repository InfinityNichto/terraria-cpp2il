using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000255")]
public class Zoom_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D58")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7564", Offset = "0x9D7564", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x40018A8")]
	public static Zoom_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40018A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ControlAnchor.ControlId SliderAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x40018AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public LayoutCalculator.AnchorType SliderAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x40018AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	[global::Cpp2ILInjected.Token(Token = "0x40018AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float SliderBackScale;

	[global::Cpp2ILInjected.Token(Token = "0x40018AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	[global::Cpp2ILInjected.Token(Token = "0x40018AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float SliderIndicatorScale;

	[global::Cpp2ILInjected.Token(Token = "0x40018AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float SliderEndCap;

	[global::Cpp2ILInjected.Token(Token = "0x40018B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float SliderDefaultPosition;

	[global::Cpp2ILInjected.Token(Token = "0x40018B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public AnimationCurve SliderToPixelScale;

	[global::Cpp2ILInjected.Token(Token = "0x40018B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float PixelWorldScaleThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x40018B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float DefaultCursorScale;

	[global::Cpp2ILInjected.Token(Token = "0x40018B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public bool ScaleCursorWithZoom;

	[global::Cpp2ILInjected.Token(Token = "0x40018B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float DefaultMagnifyCursorScale;

	[global::Cpp2ILInjected.Token(Token = "0x40018B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public bool MagnifyScaleCursorWithZoom;

	[global::Cpp2ILInjected.Token(Token = "0x40018B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float ScopeXEdgeTrigger;

	[global::Cpp2ILInjected.Token(Token = "0x40018B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float ScopeYEdgeTrigger;
}
