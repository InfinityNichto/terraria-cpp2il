using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Metadata;

[Cpp2IlInjected.Token(Token = "0x20005B6")]
public static class TileMaterials
{
	[Cpp2IlInjected.Token(Token = "0x4006B59")]
	private static Dictionary<string, TileMaterial> _materialsByName;

	[Cpp2IlInjected.Token(Token = "0x4006B5A")]
	private static readonly TileMaterial[] MaterialsByTileId;

	[Cpp2IlInjected.Token(Token = "0x6003C5C")]
	[Cpp2IlInjected.Address(RVA = "0x105949C", Offset = "0x105949C", VA = "0x105949C")]
	static TileMaterials()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C5D")]
	[Cpp2IlInjected.Address(RVA = "0x15F0174", Offset = "0x15F0174", VA = "0x15F0174")]
	private static T DeserializeEmbeddedResource<T>(string path)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C5E")]
	[Cpp2IlInjected.Address(RVA = "0x1059748", Offset = "0x1059748", VA = "0x1059748")]
	public static void SetForTileId(ushort tileId, TileMaterial material)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C5F")]
	[Cpp2IlInjected.Address(RVA = "0x10597FC", Offset = "0x10597FC", VA = "0x10597FC")]
	public static TileMaterial GetByTileId(ushort tileId)
	{
		return null;
	}
}
