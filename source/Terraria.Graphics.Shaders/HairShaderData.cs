using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders;

[Cpp2IlInjected.Token(Token = "0x20004F0")]
public class HairShaderData : ShaderData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400675F")]
	protected Vector3 _uColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006760")]
	protected Vector3 _uSecondaryColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006761")]
	protected float _uSaturation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006762")]
	protected float _uOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006763")]
	protected Asset<Texture2D> _uImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006764")]
	protected bool _shaderDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4006765")]
	private Vector2 _uTargetPosition;

	[Cpp2IlInjected.Token(Token = "0x170006E6")]
	public bool ShaderDisabled
	{
		[Cpp2IlInjected.Token(Token = "0x600372C")]
		[Cpp2IlInjected.Address(RVA = "0x1247FC8", Offset = "0x1247FC8", VA = "0x1247FC8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600372D")]
	[Cpp2IlInjected.Address(RVA = "0x1247FD0", Offset = "0x1247FD0", VA = "0x1247FD0")]
	public HairShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600372E")]
	[Cpp2IlInjected.Address(RVA = "0x12481E8", Offset = "0x12481E8", VA = "0x12481E8", Slot = "6")]
	public virtual void Apply(Player player, [Optional] DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600372F")]
	[Cpp2IlInjected.Address(RVA = "0x12487AC", Offset = "0x12487AC", VA = "0x12487AC", Slot = "7")]
	public virtual Color GetColor(Player player, Color lightColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6003730")]
	[Cpp2IlInjected.Address(RVA = "0x1248890", Offset = "0x1248890", VA = "0x1248890")]
	public HairShaderData UseColor(float r, float g, float b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003731")]
	[Cpp2IlInjected.Address(RVA = "0x12488E4", Offset = "0x12488E4", VA = "0x12488E4")]
	public HairShaderData UseColor(Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003732")]
	[Cpp2IlInjected.Address(RVA = "0x12488D8", Offset = "0x12488D8", VA = "0x12488D8")]
	public HairShaderData UseColor(Vector3 color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003733")]
	[Cpp2IlInjected.Address(RVA = "0x1248920", Offset = "0x1248920", VA = "0x1248920")]
	public HairShaderData UseImage(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003734")]
	[Cpp2IlInjected.Address(RVA = "0x1248A44", Offset = "0x1248A44", VA = "0x1248A44")]
	public HairShaderData UseOpacity(float alpha)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003735")]
	[Cpp2IlInjected.Address(RVA = "0x1248A4C", Offset = "0x1248A4C", VA = "0x1248A4C")]
	public HairShaderData UseSecondaryColor(float r, float g, float b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003736")]
	[Cpp2IlInjected.Address(RVA = "0x1248AA0", Offset = "0x1248AA0", VA = "0x1248AA0")]
	public HairShaderData UseSecondaryColor(Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003737")]
	[Cpp2IlInjected.Address(RVA = "0x1248A94", Offset = "0x1248A94", VA = "0x1248A94")]
	public HairShaderData UseSecondaryColor(Vector3 color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003738")]
	[Cpp2IlInjected.Address(RVA = "0x1248ADC", Offset = "0x1248ADC", VA = "0x1248ADC")]
	public HairShaderData UseSaturation(float saturation)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003739")]
	[Cpp2IlInjected.Address(RVA = "0x1248AE4", Offset = "0x1248AE4", VA = "0x1248AE4")]
	public HairShaderData UseTargetPosition(Vector2 position)
	{
		return null;
	}
}
