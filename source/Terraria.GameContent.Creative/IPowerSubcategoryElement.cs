using Cpp2IlInjected;
using Terraria.GameContent.UI.Elements;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x200068D")]
public interface IPowerSubcategoryElement
{
	[Cpp2IlInjected.Token(Token = "0x60041F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex);
}
