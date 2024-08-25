using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001BA")]
[Serializable]
public class Slider_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BCF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B361C", Offset = "0x9B361C", Length = "0x138")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public Slider_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BD0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC71C", Offset = "0x9AC71C", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClothesWindow_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairWindow_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerCreateMenu_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public Slider_Layout(string backingTexture, string notchTexture)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000EA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000EA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Color BackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000EA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Texture_Layout Notch;

	[global::Cpp2ILInjected.Token(Token = "0x4000EA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Color NotchColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000EA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout BackingHighlight;

	[global::Cpp2ILInjected.Token(Token = "0x4000EAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Color BackingHighlightColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000EAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Texture_Layout NotchHighlight;

	[global::Cpp2ILInjected.Token(Token = "0x4000EAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color NotchHighlightColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000EAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float SliderEndCap;

	[global::Cpp2ILInjected.Token(Token = "0x4000EAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float BackingScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000EAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float NotchScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000EB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 PickBorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000EB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public bool Vertical;

	[global::Cpp2ILInjected.Token(Token = "0x4000EB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000EB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000EB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public Vector2 Location;
}
