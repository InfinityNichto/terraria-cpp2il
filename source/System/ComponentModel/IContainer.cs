using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x02000249 RID: 585
	[global::Cpp2ILInjected.Token(Token = "0x200033B")]
	public interface IContainer : IDisposable
	{
		// Token: 0x06001357 RID: 4951
		[global::Cpp2ILInjected.Token(Token = "0x6001596")]
		void Add(IComponent component);

		// Token: 0x06001358 RID: 4952
		[global::Cpp2ILInjected.Token(Token = "0x6001597")]
		void Add(IComponent component, string name);

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001359 RID: 4953
		[global::Cpp2ILInjected.Token(Token = "0x170004EA")]
		ComponentCollection Components
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001598")]
			get;
		}

		// Token: 0x0600135A RID: 4954
		[global::Cpp2ILInjected.Token(Token = "0x6001599")]
		void Remove(IComponent component);
	}
}
