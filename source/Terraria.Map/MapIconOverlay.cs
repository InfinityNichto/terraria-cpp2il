using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004AA")]
public class MapIconOverlay
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400659B")]
	private readonly List<IMapLayer> _layers;

	[Cpp2IlInjected.Token(Token = "0x60033F4")]
	[Cpp2IlInjected.Address(RVA = "0xE9B18C", Offset = "0xE9B18C", VA = "0xE9B18C")]
	public MapIconOverlay AddLayer(IMapLayer layer)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60033F5")]
	[Cpp2IlInjected.Address(RVA = "0xE9B1F4", Offset = "0xE9B1F4", VA = "0xE9B1F4")]
	public void Draw(Vector2 mapPosition, Vector2 mapOffset, Rectangle? clippingRect, float mapScale, float drawScale, ref string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033F6")]
	[Cpp2IlInjected.Address(RVA = "0xE9B440", Offset = "0xE9B440", VA = "0xE9B440")]
	public MapIconOverlay()
	{
	}
}
