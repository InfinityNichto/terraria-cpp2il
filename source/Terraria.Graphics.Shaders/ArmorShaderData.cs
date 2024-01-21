using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders;

[Cpp2IlInjected.Token(Token = "0x20004ED")]
public class ArmorShaderData : ShaderData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006742")]
	private Vector3 _uColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006743")]
	private Vector3 _uSecondaryColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006744")]
	private float _uSaturation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006745")]
	private float _uOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006746")]
	private Asset<Texture2D> _uImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006747")]
	private Vector2 _uTargetPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006748")]
	private int dustFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4006749")]
	private EffectPass dustEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400674A")]
	private EffectParameter _uColorParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400674B")]
	private EffectParameter _uSaturationParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400674C")]
	private EffectParameter _uSecondaryColorParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400674D")]
	private EffectParameter _uTimeParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400674E")]
	private EffectParameter _uOpacityParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400674F")]
	private EffectParameter _uTargetPositionParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4006750")]
	private EffectParameter _uSourceRectParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4006751")]
	private EffectParameter _uLegacyArmorSourceRectParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4006752")]
	private EffectParameter _uWorldPositionParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4006753")]
	private EffectParameter _uImageSize0Param;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4006754")]
	private EffectParameter _uLegacyArmorSheetSizeParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4006755")]
	private EffectParameter _uRotationParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4006756")]
	private EffectParameter _uImageSize1Param;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4006757")]
	private EffectParameter _uDirectionParam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4006758")]
	private bool applyingDust;

	[Cpp2IlInjected.Token(Token = "0x6003714")]
	[Cpp2IlInjected.Address(RVA = "0x1246A94", Offset = "0x1246A94", VA = "0x1246A94")]
	public ArmorShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003715")]
	[Cpp2IlInjected.Address(RVA = "0x1246F14", Offset = "0x1246F14", VA = "0x1246F14")]
	public EffectPass GetDustEffect()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003716")]
	[Cpp2IlInjected.Address(RVA = "0x1246FC4", Offset = "0x1246FC4", VA = "0x1246FC4")]
	public void ApplyDust()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003717")]
	[Cpp2IlInjected.Address(RVA = "0x12470A0", Offset = "0x12470A0", VA = "0x12470A0", Slot = "4")]
	public override void Apply(Entity entity, [Optional] DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003718")]
	[Cpp2IlInjected.Address(RVA = "0x12474F8", Offset = "0x12474F8", VA = "0x12474F8")]
	public ArmorShaderData UseColor(float r, float g, float b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003719")]
	[Cpp2IlInjected.Address(RVA = "0x124754C", Offset = "0x124754C", VA = "0x124754C")]
	public ArmorShaderData UseColor(Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600371A")]
	[Cpp2IlInjected.Address(RVA = "0x1247540", Offset = "0x1247540", VA = "0x1247540")]
	public ArmorShaderData UseColor(Vector3 color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600371B")]
	[Cpp2IlInjected.Address(RVA = "0x1247588", Offset = "0x1247588", VA = "0x1247588")]
	public ArmorShaderData UseImage(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600371C")]
	[Cpp2IlInjected.Address(RVA = "0x12476AC", Offset = "0x12476AC", VA = "0x12476AC")]
	public ArmorShaderData UseOpacity(float alpha)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600371D")]
	[Cpp2IlInjected.Address(RVA = "0x12476B4", Offset = "0x12476B4", VA = "0x12476B4")]
	public ArmorShaderData UseTargetPosition(Vector2 position)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600371E")]
	[Cpp2IlInjected.Address(RVA = "0x12476C0", Offset = "0x12476C0", VA = "0x12476C0")]
	public ArmorShaderData UseSecondaryColor(float r, float g, float b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600371F")]
	[Cpp2IlInjected.Address(RVA = "0x1247714", Offset = "0x1247714", VA = "0x1247714")]
	public ArmorShaderData UseSecondaryColor(Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003720")]
	[Cpp2IlInjected.Address(RVA = "0x1247708", Offset = "0x1247708", VA = "0x1247708")]
	public ArmorShaderData UseSecondaryColor(Vector3 color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003721")]
	[Cpp2IlInjected.Address(RVA = "0x1247750", Offset = "0x1247750", VA = "0x1247750")]
	public ArmorShaderData UseSaturation(float saturation)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003722")]
	[Cpp2IlInjected.Address(RVA = "0x1247758", Offset = "0x1247758", VA = "0x1247758", Slot = "6")]
	public virtual ArmorShaderData GetSecondaryShader(Entity entity)
	{
		return null;
	}
}
