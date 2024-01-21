using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200012F")]
public class Axis_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000A43")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A44")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A45")]
	public Microsoft.Xna.Framework.Vector2 CentreLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A46")]
	public float Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000A47")]
	public Microsoft.Xna.Framework.Graphics.Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000A48")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000A49")]
	public Microsoft.Xna.Framework.Graphics.Color AlternativeColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000A4A")]
	public Microsoft.Xna.Framework.Graphics.Color BackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000A4B")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000A4C")]
	public Microsoft.Xna.Framework.Graphics.Color IconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000A4D")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000A4E")]
	public bool UseCirclePickingRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000A4F")]
	public Microsoft.Xna.Framework.Vector2 PickSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000A50")]
	public Microsoft.Xna.Framework.Vector2 DeadZone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000A51")]
	public AnimationCurve AxisFalloff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000A52")]
	public bool RecentreOnTouch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000A53")]
	public bool RecentreInputOnly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000A54")]
	public Microsoft.Xna.Framework.Vector2 NubbinPickSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000A55")]
	public bool Draggable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
	[Cpp2IlInjected.Token(Token = "0x4000A56")]
	public bool UseCircleDeadZone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000A57")]
	public int IconMaxSizeInset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000A58")]
	public bool ClampInside;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000A59")]
	public Texture_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000A5A")]
	public Texture_Layout Inner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000A5B")]
	public Texture_Layout AlternativeInner;

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x11FF9D4", Offset = "0x11FF9D4", VA = "0x11FF9D4")]
	public Axis_Layout()
	{
	}
}
