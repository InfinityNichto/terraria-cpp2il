using System;
using Cpp2ILInjected;
using Terraria.GameContent.UI.Elements;

namespace Terraria.GameContent.Creative
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A34")]
	public interface IPowerSubcategoryElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004CA7")]
		GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex);
	}
}
