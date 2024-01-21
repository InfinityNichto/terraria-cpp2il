using Cpp2IlInjected;
using Terraria.ID;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000336")]
public delegate void TileChangeReceivedEvent(int x, int y, int count, TileChangeType type);
