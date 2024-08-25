using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001A8")]
[Serializable]
public class AnimatedTexture_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B76")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE910", Offset = "0x9AE910", Length = "0x158")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public AnimatedTexture_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000DC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000DC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	[global::Cpp2ILInjected.Token(Token = "0x4000DC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 Size;

	[global::Cpp2ILInjected.Token(Token = "0x4000DCA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool AnchorForSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000DCB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public ControlAnchor.ControlId SizeAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000DCC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public LayoutCalculator.AnchorType SizeAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DCD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 SizeLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000DCE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Vector2 PickBorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000DCF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Vector2 PickOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Color Color;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Texture_Layout Texture;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int NumXFrames;

	[global::Cpp2ILInjected.Token(Token = "0x4000DD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public int NumYFrames;
}
