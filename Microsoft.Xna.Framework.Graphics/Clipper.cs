using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200029B")]
public class Clipper
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001E3A")]
	private SpriteBatch clippingBatch;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001E3B")]
	private SpriteBatcher.VertexData[] cache1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001E3C")]
	private SpriteBatcher.VertexData[] cache2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001E3D")]
	private int inputCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001E3E")]
	private int outputCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001E3F")]
	private SpriteBatcher.VertexData[] input;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001E40")]
	private SpriteBatcher.VertexData[] output;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001E41")]
	private int Left;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001E42")]
	private int Right;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001E43")]
	private int Top;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001E44")]
	private int Bottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001E45")]
	private int OuterLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001E46")]
	private int OuterRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001E47")]
	private int OuterTop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001E48")]
	private int OuterBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001E49")]
	private int FadeOuterLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001E4A")]
	private int FadeOuterRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001E4B")]
	private int FadeOuterTop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001E4C")]
	private int FadeOuterBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001E4D")]
	private bool clipVertical;

	[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
	[Cpp2IlInjected.Token(Token = "0x4001E4E")]
	private bool clipHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
	[Cpp2IlInjected.Token(Token = "0x4001E4F")]
	private bool geometryScaleEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001E50")]
	private Vector2 geometryScaleCentre;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001E51")]
	private float geometryScale;

	[Cpp2IlInjected.Token(Token = "0x600152D")]
	[Cpp2IlInjected.Address(RVA = "0x1395138", Offset = "0x1395138", VA = "0x1395138")]
	public Clipper(SpriteBatch owner)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600152E")]
	[Cpp2IlInjected.Address(RVA = "0x13951BC", Offset = "0x13951BC", VA = "0x13951BC")]
	public void SetClipState(bool horizonal, bool vertical)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600152F")]
	[Cpp2IlInjected.Address(RVA = "0x13951C8", Offset = "0x13951C8", VA = "0x13951C8")]
	public void SetClipRegionInner(int left, int right, int top, int bottom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001530")]
	[Cpp2IlInjected.Address(RVA = "0x13951D8", Offset = "0x13951D8", VA = "0x13951D8")]
	public void PushExpandedClippingRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001531")]
	[Cpp2IlInjected.Address(RVA = "0x1395228", Offset = "0x1395228", VA = "0x1395228")]
	public void PopExpandedClippingRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001532")]
	[Cpp2IlInjected.Address(RVA = "0x1395278", Offset = "0x1395278", VA = "0x1395278")]
	public void SetClipRegionOuter(int left, int right, int top, int bottom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001533")]
	[Cpp2IlInjected.Address(RVA = "0x1395298", Offset = "0x1395298", VA = "0x1395298")]
	public void SetClipRegionOuter(int left, int right, int top, int bottom, int fadeLeft, int fadeRight, int fadeTop, int fadeBottom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001534")]
	[Cpp2IlInjected.Address(RVA = "0x13952CC", Offset = "0x13952CC", VA = "0x13952CC")]
	public void SetGeometryScale(bool enable, Vector2 centre, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001535")]
	[Cpp2IlInjected.Address(RVA = "0x13952E4", Offset = "0x13952E4", VA = "0x13952E4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38E738", Offset = "0x38E738")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38E738", Offset = "0x38E738")]
	public void Clip(SpriteBatchItem item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001536")]
	[Cpp2IlInjected.Address(RVA = "0x1397404", Offset = "0x1397404", VA = "0x1397404")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38E7EC", Offset = "0x38E7EC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38E7EC", Offset = "0x38E7EC")]
	private void InjectBatches(SpriteBatchItem item, bool resuseItem, int outNumPoints, SpriteBatcher.VertexData[] output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001537")]
	[Cpp2IlInjected.Address(RVA = "0x1396034", Offset = "0x1396034", VA = "0x1396034")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38E8A0", Offset = "0x38E8A0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38E8A0", Offset = "0x38E8A0")]
	private bool Clip(SpriteBatcher.VertexData p0, SpriteBatcher.VertexData p1, SpriteBatcher.VertexData p2, SpriteBatcher.VertexData p3, int clipLeft, int clipRight, int clipTop, int clipBottom, out int numResultPoints, out SpriteBatcher.VertexData[] result)
	{
		return default(bool);
	}
}
