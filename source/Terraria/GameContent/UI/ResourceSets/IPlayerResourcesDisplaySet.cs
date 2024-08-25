using System;
using Cpp2ILInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A82")]
	public interface IPlayerResourcesDisplaySet : IConfigKeyHolder
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004F8D")]
		void Draw();

		[global::Cpp2ILInjected.Token(Token = "0x6004F8E")]
		void TryToHover();
	}
}
