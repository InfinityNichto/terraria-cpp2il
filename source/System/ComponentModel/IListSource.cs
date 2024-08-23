using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x0200028D RID: 653
	[MergableProperty(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000384")]
	public interface IListSource
	{
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600154F RID: 5455
		[global::Cpp2ILInjected.Token(Token = "0x1700055F")]
		bool ContainsListCollection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600179A")]
			get;
		}

		// Token: 0x06001550 RID: 5456
		[global::Cpp2ILInjected.Token(Token = "0x600179B")]
		IList GetList();
	}
}
