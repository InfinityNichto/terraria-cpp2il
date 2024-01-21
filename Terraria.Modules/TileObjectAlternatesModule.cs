using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.ObjectData;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003AE")]
public class TileObjectAlternatesModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003246")]
	public List<TileObjectData> data;

	[Cpp2IlInjected.Token(Token = "0x6002EC6")]
	[Cpp2IlInjected.Address(RVA = "0xFDCA84", Offset = "0xFDCA84", VA = "0xFDCA84")]
	public TileObjectAlternatesModule([Optional] TileObjectAlternatesModule copyFrom)
	{
	}
}
