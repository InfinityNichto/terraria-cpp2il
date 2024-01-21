using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000425")]
public struct ContainerTransferContext
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062BA")]
	private Vector2 _position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062BB")]
	public bool CanVisualizeTransfers;

	[Cpp2IlInjected.Token(Token = "0x60030EA")]
	[Cpp2IlInjected.Address(RVA = "0x1012A34", Offset = "0x1012A34", VA = "0x1012A34")]
	public static ContainerTransferContext FromProjectile(Projectile projectile)
	{
		return default(ContainerTransferContext);
	}

	[Cpp2IlInjected.Token(Token = "0x60030EB")]
	[Cpp2IlInjected.Address(RVA = "0x1012A88", Offset = "0x1012A88", VA = "0x1012A88")]
	public static ContainerTransferContext FromBlockPosition(int x, int y)
	{
		return default(ContainerTransferContext);
	}

	[Cpp2IlInjected.Token(Token = "0x60030EC")]
	[Cpp2IlInjected.Address(RVA = "0x1012AF8", Offset = "0x1012AF8", VA = "0x1012AF8")]
	public static ContainerTransferContext FromUnknown(Player player)
	{
		return default(ContainerTransferContext);
	}

	[Cpp2IlInjected.Token(Token = "0x60030ED")]
	[Cpp2IlInjected.Address(RVA = "0x39ABD8", Offset = "0x39ABD8", VA = "0x39ABD8")]
	public ContainerTransferContext(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030EE")]
	[Cpp2IlInjected.Address(RVA = "0x39ABEC", Offset = "0x39ABEC", VA = "0x39ABEC")]
	public Vector2 GetContainerWorldPosition()
	{
		return default(Vector2);
	}
}
