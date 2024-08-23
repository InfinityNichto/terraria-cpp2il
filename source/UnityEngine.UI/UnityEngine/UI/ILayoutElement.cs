using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	// Token: 0x0200001F RID: 31
	[global::Cpp2ILInjected.Token(Token = "0x2000046")]
	public interface ILayoutElement
	{
		// Token: 0x0600026A RID: 618
		[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
		void CalculateLayoutInputHorizontal();

		// Token: 0x0600026B RID: 619
		[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
		void CalculateLayoutInputVertical();

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600026C RID: 620
		[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
		float minWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AC")]
			get;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600026D RID: 621
		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		float preferredWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AD")]
			get;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600026E RID: 622
		[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
		float flexibleWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
			get;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600026F RID: 623
		[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
		float minHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
			get;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000270 RID: 624
		[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
		float preferredHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
			get;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000271 RID: 625
		[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
		float flexibleHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
			get;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000272 RID: 626
		[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
		int layoutPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
			get;
		}
	}
}
