using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200027E")]
public interface IDrawable
{
	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	int DrawOrder
	{
		[Cpp2IlInjected.Token(Token = "0x60013C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	bool Visible
	{
		[Cpp2IlInjected.Token(Token = "0x60013C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EventHandler<EventArgs> DrawOrderChanged;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EventHandler<EventArgs> VisibleChanged;

	[Cpp2IlInjected.Token(Token = "0x60013C8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void Draw(GameTime gameTime);
}
