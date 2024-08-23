using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	// Token: 0x02000016 RID: 22
	[Obsolete("Not supported anymore.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	public interface IMask
	{
		// Token: 0x06000157 RID: 343
		[global::Cpp2ILInjected.Token(Token = "0x6000184")]
		bool Enabled();

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000158 RID: 344
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000185")]
			get;
		}
	}
}
