using System;
using Cpp2ILInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200027D RID: 637
	[global::Cpp2ILInjected.Token(Token = "0x200033E")]
	public interface IUpdateable
	{
		// Token: 0x06001392 RID: 5010
		[global::Cpp2ILInjected.Token(Token = "0x60014EF")]
		void Update(GameTime gameTime);

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001393 RID: 5011
		// (remove) Token: 0x06001394 RID: 5012
		[global::Cpp2ILInjected.Token(Token = "0x14000010")]
		event EventHandler<EventArgs> EnabledChanged;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001395 RID: 5013
		// (remove) Token: 0x06001396 RID: 5014
		[global::Cpp2ILInjected.Token(Token = "0x14000011")]
		event EventHandler<EventArgs> UpdateOrderChanged;

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06001397 RID: 5015
		[global::Cpp2ILInjected.Token(Token = "0x1700021C")]
		bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F4")]
			get;
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06001398 RID: 5016
		[global::Cpp2ILInjected.Token(Token = "0x1700021D")]
		int UpdateOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F5")]
			get;
		}
	}
}
