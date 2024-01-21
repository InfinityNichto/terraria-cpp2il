using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x2000503")]
public interface IPlayerRenderer
{
	[Cpp2IlInjected.Token(Token = "0x60037BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DrawPlayers(Camera camera, IEnumerable<Player> players);

	[Cpp2IlInjected.Token(Token = "0x60037BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor);

	[Cpp2IlInjected.Token(Token = "0x60037BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets);
}
