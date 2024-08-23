using System;
using Cpp2ILInjected;

namespace System.Collections
{
	// Token: 0x020004F4 RID: 1268
	[global::Cpp2ILInjected.Token(Token = "0x20005E8")]
	public interface IEnumerator
	{
		// Token: 0x06002A53 RID: 10835
		[global::Cpp2ILInjected.Token(Token = "0x6002DB7")]
		bool MoveNext();

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002A54 RID: 10836
		[global::Cpp2ILInjected.Token(Token = "0x17000701")]
		object Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DB8")]
			get;
		}

		// Token: 0x06002A55 RID: 10837
		[global::Cpp2ILInjected.Token(Token = "0x6002DB9")]
		void Reset();
	}
}
