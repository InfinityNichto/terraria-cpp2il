using System;
using Cpp2ILInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x020006AC RID: 1708
	[global::Cpp2ILInjected.Token(Token = "0x2000A82")]
	public interface IPlayerResourcesDisplaySet : IConfigKeyHolder
	{
		// Token: 0x06004360 RID: 17248
		[global::Cpp2ILInjected.Token(Token = "0x6004F8D")]
		void Draw();

		// Token: 0x06004361 RID: 17249
		[global::Cpp2ILInjected.Token(Token = "0x6004F8E")]
		void TryToHover();
	}
}
