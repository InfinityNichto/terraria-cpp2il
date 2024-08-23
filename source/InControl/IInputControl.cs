using System;
using Cpp2ILInjected;

namespace InControl
{
	// Token: 0x0200001C RID: 28
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public interface IInputControl
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012B RID: 299
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		bool HasChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012B")]
			get;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600012C RID: 300
		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		bool IsPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012C")]
			get;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012D RID: 301
		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		bool WasPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012D")]
			get;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012E RID: 302
		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		bool WasReleased
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012E")]
			get;
		}

		// Token: 0x0600012F RID: 303
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		void ClearInputState();
	}
}
