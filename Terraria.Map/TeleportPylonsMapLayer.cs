using Cpp2IlInjected;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004AF")]
public class TeleportPylonsMapLayer : IMapLayer
{
	[Cpp2IlInjected.Token(Token = "0x600340A")]
	[Cpp2IlInjected.Address(RVA = "0xE9CA48", Offset = "0xE9CA48", VA = "0xE9CA48", Slot = "4")]
	public void Draw(ref MapOverlayDrawContext context, ref string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600340B")]
	[Cpp2IlInjected.Address(RVA = "0xE9CF94", Offset = "0xE9CF94", VA = "0xE9CF94")]
	public TeleportPylonsMapLayer()
	{
	}
}
