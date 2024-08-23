using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000500 RID: 1280
	[global::Cpp2ILInjected.Token(Token = "0x200075C")]
	public interface IPlayerRenderer
	{
		// Token: 0x06003780 RID: 14208
		[global::Cpp2ILInjected.Token(Token = "0x6003DF7")]
		void DrawPlayers(Camera camera, IEnumerable<Player> players);

		// Token: 0x06003781 RID: 14209
		[global::Cpp2ILInjected.Token(Token = "0x6003DF8")]
		void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, Color borderColor = default(Color));

		// Token: 0x06003782 RID: 14210
		[global::Cpp2ILInjected.Token(Token = "0x6003DF9")]
		void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, Vector2[] positionalOffsets = null);
	}
}
