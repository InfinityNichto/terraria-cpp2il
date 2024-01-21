using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.ObjectData;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003B3")]
public class TileObjectSubTilesModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003262")]
	public List<TileObjectData> data;

	[Cpp2IlInjected.Token(Token = "0x6002ECB")]
	[Cpp2IlInjected.Address(RVA = "0xFDCF4C", Offset = "0xFDCF4C", VA = "0xFDCF4C")]
	public TileObjectSubTilesModule([Optional] TileObjectSubTilesModule copyFrom, [Optional] List<TileObjectData> newData)
	{
	}
}
