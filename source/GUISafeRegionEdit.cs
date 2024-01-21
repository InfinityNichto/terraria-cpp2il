using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20001E2")]
public class GUISafeRegionEdit
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001543")]
	private CursorInputLayer _inputLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001544")]
	private float leftInitialOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001545")]
	private float rightInitialOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001546")]
	private float topInitialOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001547")]
	private float bottomInitialOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001548")]
	private float leftScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001549")]
	private float rightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400154A")]
	private float topScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400154B")]
	private float bottomScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400154C")]
	private float finishScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400154D")]
	private float resetScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400154E")]
	private bool LeftPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400154F")]
	private bool RightPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x4001550")]
	private bool TopPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x4001551")]
	private bool BottomPressed;

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x115DCB8", Offset = "0x115DCB8", VA = "0x115DCB8")]
	public GUISafeRegionEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x115DD84", Offset = "0x115DD84", VA = "0x115DD84")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D62")]
	[Cpp2IlInjected.Address(RVA = "0x115E12C", Offset = "0x115E12C", VA = "0x115E12C")]
	public void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D63")]
	[Cpp2IlInjected.Address(RVA = "0x115E88C", Offset = "0x115E88C", VA = "0x115E88C")]
	public void UpdateEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D64")]
	[Cpp2IlInjected.Address(RVA = "0x115F314", Offset = "0x115F314", VA = "0x115F314")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x115E9A0", Offset = "0x115E9A0", VA = "0x115E9A0")]
	private bool UpdateCursorDragging(ref Rect safeArea)
	{
		return default(bool);
	}
}
