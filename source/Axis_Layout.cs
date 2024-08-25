using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20001A9")]
[Serializable]
public class Axis_Layout
{
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

	[global::Cpp2ILInjected.Token(Token = "0x4000DD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Microsoft.Xna.Framework.Vector2 CentreLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Microsoft.Xna.Framework.Graphics.Color Color;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Microsoft.Xna.Framework.Graphics.Color AlternativeColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Microsoft.Xna.Framework.Graphics.Color BackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Microsoft.Xna.Framework.Graphics.Color IconColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool UseCirclePickingRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Microsoft.Xna.Framework.Vector2 PickSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Microsoft.Xna.Framework.Vector2 DeadZone;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public AnimationCurve AxisFalloff;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public bool RecentreOnTouch;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
	public bool RecentreInputOnly;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public Microsoft.Xna.Framework.Vector2 NubbinPickSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public bool Draggable;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6D")]
	public bool UseCircleDeadZone;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public int IconMaxSizeInset;

	[global::Cpp2ILInjected.Token(Token = "0x4000DE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public bool ClampInside;

	[global::Cpp2ILInjected.Token(Token = "0x4000DEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000DEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Texture_Layout Inner;

	[global::Cpp2ILInjected.Token(Token = "0x4000DEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout AlternativeInner;
}
