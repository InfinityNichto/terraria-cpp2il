using System;
using Cpp2ILInjected;
using Terraria.GameContent.UI.Elements;

namespace Terraria.GameContent.Creative
{
	// Token: 0x0200068A RID: 1674
	[global::Cpp2ILInjected.Token(Token = "0x2000A34")]
	public interface IPowerSubcategoryElement
	{
		// Token: 0x060041B5 RID: 16821
		[global::Cpp2ILInjected.Token(Token = "0x6004CA7")]
		GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex);
	}
}
