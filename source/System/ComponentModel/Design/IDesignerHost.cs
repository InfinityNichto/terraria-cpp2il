using System;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	// Token: 0x020002FB RID: 763
	[global::Cpp2ILInjected.Token(Token = "0x200040E")]
	public interface IDesignerHost : IServiceProvider
	{
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600192C RID: 6444
		[global::Cpp2ILInjected.Token(Token = "0x1700063B")]
		IComponent RootComponent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C0A")]
			get;
		}

		// Token: 0x0600192D RID: 6445
		[global::Cpp2ILInjected.Token(Token = "0x6001C0B")]
		IDesigner GetDesigner(IComponent component);
	}
}
