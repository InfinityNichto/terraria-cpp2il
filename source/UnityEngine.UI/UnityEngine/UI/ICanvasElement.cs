using System;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public interface ICanvasElement
	{
		// Token: 0x06000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		void Rebuild(CanvasUpdate executing);

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		Transform transform
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			get;
		}

		// Token: 0x06000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		void LayoutComplete();

		// Token: 0x06000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		void GraphicUpdateComplete();

		// Token: 0x06000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		bool IsDestroyed();
	}
}
