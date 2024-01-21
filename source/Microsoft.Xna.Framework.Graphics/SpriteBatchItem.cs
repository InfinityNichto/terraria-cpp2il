using Cpp2IlInjected;
using Terraria.Graphics;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002C5")]
public class SpriteBatchItem
{
	[Cpp2IlInjected.Token(Token = "0x400202D")]
	private const float uvFixupOffset = 0.031f;

	[Cpp2IlInjected.Token(Token = "0x400202E")]
	private static bool clippingPushedEnabledBackup;

	[Cpp2IlInjected.Token(Token = "0x400202F")]
	private static bool clippingVerticalBackup;

	[Cpp2IlInjected.Token(Token = "0x4002030")]
	private static bool clippingHorzontalBackup;

	[Cpp2IlInjected.Token(Token = "0x4002031")]
	private static Rectangle clippingPushedInnerBackup;

	[Cpp2IlInjected.Token(Token = "0x4002032")]
	private static Rectangle clippingPushedOuterBackup;

	[Cpp2IlInjected.Token(Token = "0x4002033")]
	public static bool clippingEnabled;

	[Cpp2IlInjected.Token(Token = "0x4002034")]
	private static bool clippingVertical;

	[Cpp2IlInjected.Token(Token = "0x4002035")]
	private static bool clippingHorzontal;

	[Cpp2IlInjected.Token(Token = "0x4002036")]
	private static Rectangle clippingInner;

	[Cpp2IlInjected.Token(Token = "0x4002037")]
	public static Rectangle clippingOuter;

	[Cpp2IlInjected.Token(Token = "0x4002038")]
	private static SpriteBatch clippingBatch;

	[Cpp2IlInjected.Token(Token = "0x4002039")]
	private static Clipper clipperObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400203A")]
	public int BatchKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400203B")]
	public Texture2D Texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400203C")]
	public EffectPass OverloadedEffectPass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400203D")]
	public SpriteBatchItem NextBatchItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400203E")]
	public SpriteBatcher.VertexData vertexTL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400203F")]
	public SpriteBatcher.VertexData vertexTR;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002040")]
	public SpriteBatcher.VertexData vertexBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4002041")]
	public SpriteBatcher.VertexData vertexBR;

	[Cpp2IlInjected.Token(Token = "0x4002042")]
	public static float ColourScale;

	[Cpp2IlInjected.Token(Token = "0x4002043")]
	public static bool EnableMaterialTrimming;

	[Cpp2IlInjected.Token(Token = "0x4002044")]
	public static UnityEngine.Vector2 MaterialTrimmingMin;

	[Cpp2IlInjected.Token(Token = "0x4002045")]
	public static UnityEngine.Vector2 MaterialTrimmingMax;

	[Cpp2IlInjected.Token(Token = "0x6001707")]
	[Cpp2IlInjected.Address(RVA = "0x1543D64", Offset = "0x1543D64", VA = "0x1543D64")]
	public static void PushExpandedClippingRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001708")]
	[Cpp2IlInjected.Address(RVA = "0x1543E18", Offset = "0x1543E18", VA = "0x1543E18")]
	public static void PopExpandedClippingRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001709")]
	[Cpp2IlInjected.Address(RVA = "0x1543ECC", Offset = "0x1543ECC", VA = "0x1543ECC")]
	public static void EnableClipping(Rectangle inner, Rectangle outer, SpriteBatch batcher, bool vertical)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600170A")]
	[Cpp2IlInjected.Address(RVA = "0x1544114", Offset = "0x1544114", VA = "0x1544114")]
	public static void PushClippedImageRegion(Rectangle region, SpriteBatch batcher, bool enableGeometryScale, Vector2 geometryScaleCentre, float geometryScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600170B")]
	[Cpp2IlInjected.Address(RVA = "0x1544620", Offset = "0x1544620", VA = "0x1544620")]
	public static void PopClippedImageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600170C")]
	[Cpp2IlInjected.Address(RVA = "0x1544844", Offset = "0x1544844", VA = "0x1544844")]
	public static void DisabledClipping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600170D")]
	[Cpp2IlInjected.Address(RVA = "0x15448C0", Offset = "0x15448C0", VA = "0x15448C0")]
	public SpriteBatchItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600170E")]
	[Cpp2IlInjected.Address(RVA = "0x15448E4", Offset = "0x15448E4", VA = "0x15448E4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F5CC", Offset = "0x38F5CC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F5CC", Offset = "0x38F5CC")]
	public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600170F")]
	[Cpp2IlInjected.Address(RVA = "0x1545554", Offset = "0x1545554", VA = "0x1545554")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F680", Offset = "0x38F680")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F680", Offset = "0x38F680")]
	public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref VertexColors colors, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001710")]
	[Cpp2IlInjected.Address(RVA = "0x1546074", Offset = "0x1546074", VA = "0x1546074")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F734", Offset = "0x38F734")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F734", Offset = "0x38F734")]
	public void Set(float x, float y, float w, float h, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001711")]
	[Cpp2IlInjected.Address(RVA = "0x1546C44", Offset = "0x1546C44", VA = "0x1546C44")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F7E8", Offset = "0x38F7E8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F7E8", Offset = "0x38F7E8")]
	public void Set(float x, float y, float w, float h, ref VertexColors color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
	{
	}
}
