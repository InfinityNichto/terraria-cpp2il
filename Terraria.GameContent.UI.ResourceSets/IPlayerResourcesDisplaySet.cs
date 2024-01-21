using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets;

[Cpp2IlInjected.Token(Token = "0x20006AF")]
public interface IPlayerResourcesDisplaySet : IConfigKeyHolder
{
	[Cpp2IlInjected.Token(Token = "0x600439E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Draw();

	[Cpp2IlInjected.Token(Token = "0x600439F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void TryToHover();
}
