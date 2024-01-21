using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders;

[Cpp2IlInjected.Token(Token = "0x20004EE")]
public class ArmorShaderDataSet
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006759")]
	protected List<ArmorShaderData> _shaderData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400675A")]
	protected Dictionary<int, int> _shaderLookupDictionary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400675B")]
	protected int _shaderDataCount;

	[Cpp2IlInjected.Token(Token = "0x6003723")]
	[Cpp2IlInjected.Address(RVA = "0x15F0220", Offset = "0x15F0220", VA = "0x15F0220")]
	public T BindShader<T>(int itemId, T shaderData) where T : ArmorShaderData
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003724")]
	[Cpp2IlInjected.Address(RVA = "0x124775C", Offset = "0x124775C", VA = "0x124775C")]
	public void Apply(int shaderId, Entity entity, [Optional] DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003725")]
	[Cpp2IlInjected.Address(RVA = "0x1247954", Offset = "0x1247954", VA = "0x1247954")]
	public void ApplySecondary(int shaderId, Entity entity, [Optional] DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003726")]
	[Cpp2IlInjected.Address(RVA = "0x1247B60", Offset = "0x1247B60", VA = "0x1247B60")]
	public ArmorShaderData GetShaderFromItemId(int type)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003727")]
	[Cpp2IlInjected.Address(RVA = "0x1247C18", Offset = "0x1247C18", VA = "0x1247C18")]
	public int GetShaderIdFromItemId(int type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003728")]
	[Cpp2IlInjected.Address(RVA = "0x1247CA8", Offset = "0x1247CA8", VA = "0x1247CA8")]
	public ArmorShaderData GetSecondaryShader(int id, Player player)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003729")]
	[Cpp2IlInjected.Address(RVA = "0x1247D78", Offset = "0x1247D78", VA = "0x1247D78")]
	public ArmorShaderDataSet()
	{
	}
}
