using System;
using Cpp2ILInjected;

namespace MonoGame.OpenGL
{
	// Token: 0x0200025B RID: 603
	[global::Cpp2ILInjected.Token(Token = "0x200031C")]
	internal interface IGraphicsContext
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600112A RID: 4394
		// (set) Token: 0x0600112B RID: 4395
		[global::Cpp2ILInjected.Token(Token = "0x170001D1")]
		int SwapInterval
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001287")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001288")]
			set;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600112C RID: 4396
		[global::Cpp2ILInjected.Token(Token = "0x170001D2")]
		bool IsDisposed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001289")]
			get;
		}

		// Token: 0x0600112D RID: 4397
		[global::Cpp2ILInjected.Token(Token = "0x600128A")]
		void MakeCurrent(IWindowInfo info);

		// Token: 0x0600112E RID: 4398
		[global::Cpp2ILInjected.Token(Token = "0x600128B")]
		void SwapBuffers();

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600112F RID: 4399
		[global::Cpp2ILInjected.Token(Token = "0x170001D3")]
		bool IsCurrent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600128C")]
			get;
		}
	}
}
