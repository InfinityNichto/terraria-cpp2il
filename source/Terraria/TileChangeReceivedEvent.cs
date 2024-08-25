using System;
using Cpp2ILInjected;
using Terraria.ID;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x200043E")]
	public delegate void TileChangeReceivedEvent(int x, int y, int count, TileChangeType type);
}
