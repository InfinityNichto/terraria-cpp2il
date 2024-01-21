using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200010A")]
public class GUIZoom
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000847")]
	private bool draggingSlider;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000848")]
	private float ZoomValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000849")]
	private CursorInputLayer _inputLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400084A")]
	private CursorInputLayer _inputlayerZoomPinch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400084B")]
	private float MaxZoomValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400084C")]
	public float DefaultWorldZoomScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400084D")]
	private bool _pinchZoomActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400084E")]
	private Cursor _zoomCursor0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400084F")]
	private Cursor _zoomCursor1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000850")]
	private UnityEngine.Vector2 _initialPosition0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000851")]
	private UnityEngine.Vector2 _initialPosition1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000852")]
	private bool _lastFrameFullScreenMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000853")]
	private Microsoft.Xna.Framework.Vector2 _lastFrameGrabCentre;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000854")]
	private float _initialZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000855")]
	public bool PinchZoomWorldEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
	[Cpp2IlInjected.Token(Token = "0x4000856")]
	public bool PinchZoomMapEnabled;

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x116CF34", Offset = "0x116CF34", VA = "0x116CF34")]
	public float GetDefaultWorldZoomScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x116D02C", Offset = "0x116D02C", VA = "0x116D02C")]
	public void LoadDefaultZoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x116D138", Offset = "0x116D138", VA = "0x116D138")]
	public GUIZoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x116D260", Offset = "0x116D260", VA = "0x116D260")]
	private bool IsCursorOver(Microsoft.Xna.Framework.Vector2 position, out float sliderPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x116D520", Offset = "0x116D520", VA = "0x116D520")]
	private void ApplyPixelZoom(float pixelScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x116DB00", Offset = "0x116DB00", VA = "0x116DB00")]
	private void UpdatePixelZoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x116DB78", Offset = "0x116DB78", VA = "0x116DB78")]
	public void UpdateCursorDummy(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x116DB7C", Offset = "0x116DB7C", VA = "0x116DB7C")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x116DCFC", Offset = "0x116DCFC", VA = "0x116DCFC")]
	public void UpdatePinchZoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x116E60C", Offset = "0x116E60C", VA = "0x116E60C")]
	public void Draw()
	{
	}
}
