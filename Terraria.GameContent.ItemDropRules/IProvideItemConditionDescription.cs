using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005CD")]
public interface IProvideItemConditionDescription
{
	[Cpp2IlInjected.Token(Token = "0x6003CB2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GetConditionDescription();
}
