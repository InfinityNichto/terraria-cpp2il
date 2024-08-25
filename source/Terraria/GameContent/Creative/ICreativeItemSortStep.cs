using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Creative
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A28")]
	public interface ICreativeItemSortStep : IEntrySortStep<int>, IComparer<int>
	{
	}
}
