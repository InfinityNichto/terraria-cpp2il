using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders;

[Cpp2IlInjected.Token(Token = "0x20004F1")]
public class HairShaderDataSet
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006766")]
	protected List<HairShaderData> _shaderData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006767")]
	protected Dictionary<int, short> _shaderLookupDictionary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006768")]
	protected byte _shaderDataCount;

	[Cpp2IlInjected.Token(Token = "0x600373A")]
	[Cpp2IlInjected.Address(RVA = "0x15F02B4", Offset = "0x15F02B4", VA = "0x15F02B4")]
	public T BindShader<T>(int itemId, T shaderData) where T : HairShaderData
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600373B")]
	[Cpp2IlInjected.Address(RVA = "0x1248AF0", Offset = "0x1248AF0", VA = "0x1248AF0")]
	public void Apply(short shaderId, Player player, [Optional] DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600373C")]
	[Cpp2IlInjected.Address(RVA = "0x1248CEC", Offset = "0x1248CEC", VA = "0x1248CEC")]
	public Color GetColor(short shaderId, Player player, Color lightColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600373D")]
	[Cpp2IlInjected.Address(RVA = "0x1248E4C", Offset = "0x1248E4C", VA = "0x1248E4C")]
	public HairShaderData GetShaderFromItemId(int type)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600373E")]
	[Cpp2IlInjected.Address(RVA = "0x1248F04", Offset = "0x1248F04", VA = "0x1248F04")]
	public short GetShaderIdFromItemId(int type)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600373F")]
	[Cpp2IlInjected.Address(RVA = "0x1247F10", Offset = "0x1247F10", VA = "0x1247F10")]
	public HairShaderDataSet()
	{
	}
}
