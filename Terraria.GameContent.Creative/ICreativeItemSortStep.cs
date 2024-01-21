using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x2000688")]
public interface ICreativeItemSortStep : IEntrySortStep<int>, IComparer<int>
{
}
