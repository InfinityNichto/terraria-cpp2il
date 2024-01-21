using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000470")]
public class EntitySource_TileEntity : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006422")]
	public TileEntity TileEntity;

	[Cpp2IlInjected.Token(Token = "0x6003226")]
	[Cpp2IlInjected.Address(RVA = "0x1013A54", Offset = "0x1013A54", VA = "0x1013A54")]
	public EntitySource_TileEntity(TileEntity tileEntity)
	{
	}
}
