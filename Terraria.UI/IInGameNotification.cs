using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004C5")]
public interface IInGameNotification
{
	[Cpp2IlInjected.Token(Token = "0x170006C6")]
	object CreationObject
	{
		[Cpp2IlInjected.Token(Token = "0x60035D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170006C7")]
	bool ShouldBeRemoved
	{
		[Cpp2IlInjected.Token(Token = "0x60035D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60035DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void Update();

	[Cpp2IlInjected.Token(Token = "0x60035DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition);

	[Cpp2IlInjected.Token(Token = "0x60035DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PushAnchor(ref Vector2 positionAnchorBottom);

	[Cpp2IlInjected.Token(Token = "0x60035DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse);
}
