using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x020004C2 RID: 1218
	[global::Cpp2ILInjected.Token(Token = "0x20006E1")]
	public interface IInGameNotification
	{
		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600359C RID: 13724
		[global::Cpp2ILInjected.Token(Token = "0x17000757")]
		object CreationObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003B1F")]
			get;
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600359D RID: 13725
		[global::Cpp2ILInjected.Token(Token = "0x17000758")]
		bool ShouldBeRemoved
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003B20")]
			get;
		}

		// Token: 0x0600359E RID: 13726
		[global::Cpp2ILInjected.Token(Token = "0x6003B21")]
		void Update();

		// Token: 0x0600359F RID: 13727
		[global::Cpp2ILInjected.Token(Token = "0x6003B22")]
		void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition);

		// Token: 0x060035A0 RID: 13728
		[global::Cpp2ILInjected.Token(Token = "0x6003B23")]
		void PushAnchor(ref Vector2 positionAnchorBottom);

		// Token: 0x060035A1 RID: 13729
		[global::Cpp2ILInjected.Token(Token = "0x6003B24")]
		void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse);
	}
}
