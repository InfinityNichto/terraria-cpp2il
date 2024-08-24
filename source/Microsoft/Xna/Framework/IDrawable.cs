using System;
using Cpp2ILInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200027B RID: 635
	[global::Cpp2ILInjected.Token(Token = "0x200033C")]
	public interface IDrawable
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600138A RID: 5002
		[global::Cpp2ILInjected.Token(Token = "0x1700021A")]
		int DrawOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014E7")]
			get;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600138B RID: 5003
		[global::Cpp2ILInjected.Token(Token = "0x1700021B")]
		bool Visible
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014E8")]
			get;
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600138C RID: 5004
		// (remove) Token: 0x0600138D RID: 5005
		[global::Cpp2ILInjected.Token(Token = "0x1400000E")]
		event EventHandler<EventArgs> DrawOrderChanged;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600138E RID: 5006
		// (remove) Token: 0x0600138F RID: 5007
		[global::Cpp2ILInjected.Token(Token = "0x1400000F")]
		event EventHandler<EventArgs> VisibleChanged;

		// Token: 0x06001390 RID: 5008
		[global::Cpp2ILInjected.Token(Token = "0x60014ED")]
		void Draw(GameTime gameTime);
	}
}
