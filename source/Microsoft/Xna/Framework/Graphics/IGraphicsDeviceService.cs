using System;
using Cpp2ILInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002B5 RID: 693
	[global::Cpp2ILInjected.Token(Token = "0x2000380")]
	public interface IGraphicsDeviceService
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600164E RID: 5710
		[global::Cpp2ILInjected.Token(Token = "0x170002F4")]
		GraphicsDevice GraphicsDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017BE")]
			get;
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600164F RID: 5711
		// (remove) Token: 0x06001650 RID: 5712
		[global::Cpp2ILInjected.Token(Token = "0x1400001A")]
		event EventHandler<EventArgs> DeviceCreated;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06001651 RID: 5713
		// (remove) Token: 0x06001652 RID: 5714
		[global::Cpp2ILInjected.Token(Token = "0x1400001B")]
		event EventHandler<EventArgs> DeviceDisposing;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06001653 RID: 5715
		// (remove) Token: 0x06001654 RID: 5716
		[global::Cpp2ILInjected.Token(Token = "0x1400001C")]
		event EventHandler<EventArgs> DeviceReset;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06001655 RID: 5717
		// (remove) Token: 0x06001656 RID: 5718
		[global::Cpp2ILInjected.Token(Token = "0x1400001D")]
		event EventHandler<EventArgs> DeviceResetting;
	}
}
