using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000366")]
public abstract class GenStructure : GenBase
{
	[Cpp2IlInjected.Token(Token = "0x6002C7D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool Place(Point origin, StructureMap structures);

	[Cpp2IlInjected.Token(Token = "0x6002C7E")]
	[Cpp2IlInjected.Address(RVA = "0x1300A34", Offset = "0x1300A34", VA = "0x1300A34")]
	protected GenStructure()
	{
	}
}
