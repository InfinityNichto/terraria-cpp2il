using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000005 RID: 5
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public interface INotifyPropertyChanging
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000B RID: 11
		// (remove) Token: 0x0600000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		event PropertyChangingEventHandler PropertyChanging;
	}
}
