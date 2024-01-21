using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20001C1")]
public class Zoom_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40013C4")]
	public static Zoom_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40013C5")]
	public ControlAnchor.ControlId SliderAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40013C6")]
	public LayoutCalculator.AnchorType SliderAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40013C7")]
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40013C8")]
	public float SliderBackScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40013C9")]
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40013CA")]
	public float SliderIndicatorScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40013CB")]
	public float SliderEndCap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40013CC")]
	public float SliderDefaultPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40013CD")]
	public AnimationCurve SliderToPixelScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40013CE")]
	public float PixelWorldScaleThreshold;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40013CF")]
	public float DefaultCursorScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40013D0")]
	public bool ScaleCursorWithZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40013D1")]
	public float DefaultMagnifyCursorScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40013D2")]
	public bool MagnifyScaleCursorWithZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40013D3")]
	public float ScopeXEdgeTrigger;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40013D4")]
	public float ScopeYEdgeTrigger;

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x1504A2C", Offset = "0x1504A2C", VA = "0x1504A2C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x1504A88", Offset = "0x1504A88", VA = "0x1504A88")]
	public Zoom_Layout()
	{
	}
}
