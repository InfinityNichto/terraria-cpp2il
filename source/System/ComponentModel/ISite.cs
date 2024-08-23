using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x0200024A RID: 586
	[global::Cpp2ILInjected.Token(Token = "0x200033C")]
	public interface ISite : IServiceProvider
	{
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600135B RID: 4955
		[global::Cpp2ILInjected.Token(Token = "0x170004EB")]
		IComponent Component
		{
			[global::Cpp2ILInjected.Token(Token = "0x600159A")]
			get;
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600135C RID: 4956
		[global::Cpp2ILInjected.Token(Token = "0x170004EC")]
		IContainer Container
		{
			[global::Cpp2ILInjected.Token(Token = "0x600159B")]
			get;
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600135D RID: 4957
		[global::Cpp2ILInjected.Token(Token = "0x170004ED")]
		bool DesignMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600159C")]
			get;
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600135E RID: 4958
		// (set) Token: 0x0600135F RID: 4959
		[global::Cpp2ILInjected.Token(Token = "0x170004EE")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600159D")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600159E")]
			set;
		}
	}
}
