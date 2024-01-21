using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000280")]
public interface IUpdateable
{
	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	bool Enabled
	{
		[Cpp2IlInjected.Token(Token = "0x60013CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	int UpdateOrder
	{
		[Cpp2IlInjected.Token(Token = "0x60013D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event EventHandler<EventArgs> EnabledChanged;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event EventHandler<EventArgs> UpdateOrderChanged;

	[Cpp2IlInjected.Token(Token = "0x60013CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Update(GameTime gameTime);
}
