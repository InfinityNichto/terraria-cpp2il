using Cpp2IlInjected;
using Terraria.Graphics.Shaders;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A4")]
public class EffectPass
{
	[Cpp2IlInjected.Token(Token = "0x4001EFF")]
	public static EffectPass BoundEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001F00")]
	public readonly int PassIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001F01")]
	public readonly string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001F02")]
	private readonly Effect _effect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001F03")]
	public readonly Material _material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001F04")]
	public readonly int BatchIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001F05")]
	public readonly ShaderData _armour;

	[Cpp2IlInjected.Token(Token = "0x4001F06")]
	private static int NextBatchIndex;

	[Cpp2IlInjected.Token(Token = "0x6001585")]
	[Cpp2IlInjected.Address(RVA = "0x139B56C", Offset = "0x139B56C", VA = "0x139B56C")]
	private static int GetNextBatchIndex()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001586")]
	[Cpp2IlInjected.Address(RVA = "0x139B5EC", Offset = "0x139B5EC", VA = "0x139B5EC")]
	public EffectPass(Effect effect, int passindex, string name, Material material)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001587")]
	[Cpp2IlInjected.Address(RVA = "0x139B68C", Offset = "0x139B68C", VA = "0x139B68C")]
	public EffectPass(Effect effect, EffectPass existing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001588")]
	[Cpp2IlInjected.Address(RVA = "0x139B728", Offset = "0x139B728", VA = "0x139B728")]
	public EffectPass(EffectPass existing, ShaderData armourData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001589")]
	[Cpp2IlInjected.Address(RVA = "0x139B7CC", Offset = "0x139B7CC", VA = "0x139B7CC")]
	public void ApplyValuesToMaterial(Material material)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600158A")]
	[Cpp2IlInjected.Address(RVA = "0x139B8C4", Offset = "0x139B8C4", VA = "0x139B8C4")]
	public void SetRegion(Vector4 sourceRect, Texture2D texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600158B")]
	[Cpp2IlInjected.Address(RVA = "0x139B9C4", Offset = "0x139B9C4", VA = "0x139B9C4")]
	public void Apply()
	{
	}
}
