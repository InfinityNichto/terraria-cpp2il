using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001B6")]
[Serializable]
public class ProgressBar_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BC1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2AB4", Offset = "0x9B2AB4", Length = "0x178")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public ProgressBar_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BC2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2C2C", Offset = "0x9B2C2C", Length = "0x1B8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public ProgressBar_Layout(string backingTexture)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000E67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000E68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float BackingScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000E69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private bool Vertical;

	[global::Cpp2ILInjected.Token(Token = "0x4000E6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000E6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 Location;

	[global::Cpp2ILInjected.Token(Token = "0x4000E6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 FillingSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000E6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 FillingLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000E6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color FillingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color FillingColorEmpty;
}
