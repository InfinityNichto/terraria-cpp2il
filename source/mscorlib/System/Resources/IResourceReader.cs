using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.Resources
{
	// Token: 0x020003EB RID: 1003
	[global::Cpp2ILInjected.Token(Token = "0x20004A5")]
	public interface IResourceReader : global::System.Collections.IEnumerable, global::System.IDisposable
	{
		// Token: 0x06002048 RID: 8264
		[global::Cpp2ILInjected.Token(Token = "0x60022C1")]
		void Close();

		// Token: 0x06002049 RID: 8265
		[global::Cpp2ILInjected.Token(Token = "0x60022C2")]
		global::System.Collections.IDictionaryEnumerator GetEnumerator();
	}
}
