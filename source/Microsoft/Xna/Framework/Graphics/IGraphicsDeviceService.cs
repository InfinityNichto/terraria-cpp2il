using System;
using Cpp2ILInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000380")]
	public interface IGraphicsDeviceService
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002F4")]
		GraphicsDevice GraphicsDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017BE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400001A")]
		event EventHandler<EventArgs> DeviceCreated;

		[global::Cpp2ILInjected.Token(Token = "0x1400001B")]
		event EventHandler<EventArgs> DeviceDisposing;

		[global::Cpp2ILInjected.Token(Token = "0x1400001C")]
		event EventHandler<EventArgs> DeviceReset;

		[global::Cpp2ILInjected.Token(Token = "0x1400001D")]
		event EventHandler<EventArgs> DeviceResetting;
	}
}
