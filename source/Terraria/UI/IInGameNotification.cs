using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x20006E1")]
	public interface IInGameNotification
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000757")]
		object CreationObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003B1F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000758")]
		bool ShouldBeRemoved
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003B20")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003B21")]
		void Update();

		[global::Cpp2ILInjected.Token(Token = "0x6003B22")]
		void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition);

		[global::Cpp2ILInjected.Token(Token = "0x6003B23")]
		void PushAnchor(ref Vector2 positionAnchorBottom);

		[global::Cpp2ILInjected.Token(Token = "0x6003B24")]
		void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse);
	}
}
