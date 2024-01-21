using Cpp2IlInjected;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004A9")]
public interface IMapLayer
{
	[Cpp2IlInjected.Token(Token = "0x60033F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Draw(ref MapOverlayDrawContext context, ref string text);
}
