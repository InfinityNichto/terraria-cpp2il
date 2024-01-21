using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders;

[Cpp2IlInjected.Token(Token = "0x20004F2")]
public class MiscShaderData : ShaderData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006769")]
	private Vector3 _uColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400676A")]
	private Vector3 _uSecondaryColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400676B")]
	private float _uSaturation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400676C")]
	private float _uOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400676D")]
	private Asset<Texture2D> _uImage0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400676E")]
	private Asset<Texture2D> _uImage1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400676F")]
	private Asset<Texture2D> _uImage2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006770")]
	private bool _useProjectionMatrix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4006771")]
	private Vector4 _shaderSpecificData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4006772")]
	private SamplerState _customSamplerState;

	[Cpp2IlInjected.Token(Token = "0x6003740")]
	[Cpp2IlInjected.Address(RVA = "0x1248F94", Offset = "0x1248F94", VA = "0x1248F94")]
	public MiscShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003741")]
	[Cpp2IlInjected.Address(RVA = "0x12491A8", Offset = "0x12491A8", VA = "0x12491A8", Slot = "4")]
	public override void Apply(Entity entity, [Optional] DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003742")]
	[Cpp2IlInjected.Address(RVA = "0x1249268", Offset = "0x1249268", VA = "0x1249268", Slot = "6")]
	public virtual void Apply([Optional] DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003743")]
	[Cpp2IlInjected.Address(RVA = "0x1249ACC", Offset = "0x1249ACC", VA = "0x1249ACC")]
	public MiscShaderData UseColor(float r, float g, float b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003744")]
	[Cpp2IlInjected.Address(RVA = "0x1249B20", Offset = "0x1249B20", VA = "0x1249B20")]
	public MiscShaderData UseColor(Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003745")]
	[Cpp2IlInjected.Address(RVA = "0x1249B14", Offset = "0x1249B14", VA = "0x1249B14")]
	public MiscShaderData UseColor(Vector3 color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003746")]
	[Cpp2IlInjected.Address(RVA = "0x1249B5C", Offset = "0x1249B5C", VA = "0x1249B5C")]
	public MiscShaderData UseSamplerState(SamplerState state)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003747")]
	[Cpp2IlInjected.Address(RVA = "0x1249B64", Offset = "0x1249B64", VA = "0x1249B64")]
	public MiscShaderData UseImage0(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003748")]
	[Cpp2IlInjected.Address(RVA = "0x1249C88", Offset = "0x1249C88", VA = "0x1249C88")]
	public MiscShaderData UseImage0(Asset<Texture2D> texture)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003749")]
	[Cpp2IlInjected.Address(RVA = "0x1249C90", Offset = "0x1249C90", VA = "0x1249C90")]
	public MiscShaderData UseImage1(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600374A")]
	[Cpp2IlInjected.Address(RVA = "0x1249DB4", Offset = "0x1249DB4", VA = "0x1249DB4")]
	public MiscShaderData UseImage1(Asset<Texture2D> texture)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600374B")]
	[Cpp2IlInjected.Address(RVA = "0x1249DBC", Offset = "0x1249DBC", VA = "0x1249DBC")]
	public MiscShaderData UseImage2(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600374C")]
	[Cpp2IlInjected.Address(RVA = "0x1249EE0", Offset = "0x1249EE0", VA = "0x1249EE0")]
	public MiscShaderData UseImage2(Asset<Texture2D> texture)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600374D")]
	[Cpp2IlInjected.Address(RVA = "0x1249EE8", Offset = "0x1249EE8", VA = "0x1249EE8")]
	private static bool IsPowerOfTwo(int n)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600374E")]
	[Cpp2IlInjected.Address(RVA = "0x123A654", Offset = "0x123A654", VA = "0x123A654")]
	public MiscShaderData UseOpacity(float alpha)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600374F")]
	[Cpp2IlInjected.Address(RVA = "0x1249FDC", Offset = "0x1249FDC", VA = "0x1249FDC")]
	public MiscShaderData UseSecondaryColor(float r, float g, float b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003750")]
	[Cpp2IlInjected.Address(RVA = "0x124A030", Offset = "0x124A030", VA = "0x124A030")]
	public MiscShaderData UseSecondaryColor(Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003751")]
	[Cpp2IlInjected.Address(RVA = "0x124A024", Offset = "0x124A024", VA = "0x124A024")]
	public MiscShaderData UseSecondaryColor(Vector3 color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003752")]
	[Cpp2IlInjected.Address(RVA = "0x124A06C", Offset = "0x124A06C", VA = "0x124A06C")]
	public MiscShaderData UseProjectionMatrix(bool doUse)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003753")]
	[Cpp2IlInjected.Address(RVA = "0x123A64C", Offset = "0x123A64C", VA = "0x123A64C")]
	public MiscShaderData UseSaturation(float saturation)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003754")]
	[Cpp2IlInjected.Address(RVA = "0x124A074", Offset = "0x124A074", VA = "0x124A074", Slot = "7")]
	public virtual MiscShaderData GetSecondaryShader(Entity entity)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003755")]
	[Cpp2IlInjected.Address(RVA = "0x124A078", Offset = "0x124A078", VA = "0x124A078")]
	public MiscShaderData UseShaderSpecificData(Vector4 specificData)
	{
		return null;
	}
}
