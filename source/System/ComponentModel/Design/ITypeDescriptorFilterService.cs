using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	// Token: 0x020002FF RID: 767
	[global::Cpp2ILInjected.Token(Token = "0x2000412")]
	public interface ITypeDescriptorFilterService
	{
		// Token: 0x06001934 RID: 6452
		[global::Cpp2ILInjected.Token(Token = "0x6001C12")]
		bool FilterAttributes(IComponent component, IDictionary attributes);

		// Token: 0x06001935 RID: 6453
		[global::Cpp2ILInjected.Token(Token = "0x6001C13")]
		bool FilterEvents(IComponent component, IDictionary events);

		// Token: 0x06001936 RID: 6454
		[global::Cpp2ILInjected.Token(Token = "0x6001C14")]
		bool FilterProperties(IComponent component, IDictionary properties);
	}
}
