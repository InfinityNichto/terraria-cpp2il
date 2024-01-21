using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002B8")]
public interface IGraphicsDeviceService
{
	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	GraphicsDevice GraphicsDevice
	{
		[Cpp2IlInjected.Token(Token = "0x6001686")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event EventHandler<EventArgs> DeviceCreated;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event EventHandler<EventArgs> DeviceDisposing;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event EventHandler<EventArgs> DeviceReset;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event EventHandler<EventArgs> DeviceResetting;
}
