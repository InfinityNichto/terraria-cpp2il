using Cpp2IlInjected;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004CB")]
public class LegacyGameInterfaceLayer : GameInterfaceLayer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400669D")]
	private GameInterfaceDrawMethod _drawMethod;

	[Cpp2IlInjected.Token(Token = "0x60035FF")]
	[Cpp2IlInjected.Address(RVA = "0x1342F5C", Offset = "0x1342F5C", VA = "0x1342F5C")]
	public LegacyGameInterfaceLayer(string name, GameInterfaceDrawMethod drawMethod, InterfaceScaleType scaleType = InterfaceScaleType.Game)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003600")]
	[Cpp2IlInjected.Address(RVA = "0x1342F80", Offset = "0x1342F80", VA = "0x1342F80", Slot = "4")]
	protected override bool DrawSelf()
	{
		return default(bool);
	}
}
