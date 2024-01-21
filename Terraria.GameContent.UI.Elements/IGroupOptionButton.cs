using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006B9")]
public interface IGroupOptionButton
{
	[Cpp2IlInjected.Token(Token = "0x60043E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked);

	[Cpp2IlInjected.Token(Token = "0x60043E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetBorderColor(Color color);
}
