using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	// Token: 0x020001D0 RID: 464
	[global::System.Runtime.CompilerServices.FriendAccessAllowed]
	[global::Cpp2ILInjected.Token(Token = "0x2000254")]
	internal enum AsyncCausalityStatus
	{
		// Token: 0x04000860 RID: 2144
		[global::Cpp2ILInjected.Token(Token = "0x4000ACC")]
		Started,
		// Token: 0x04000861 RID: 2145
		[global::Cpp2ILInjected.Token(Token = "0x4000ACD")]
		Completed,
		// Token: 0x04000862 RID: 2146
		[global::Cpp2ILInjected.Token(Token = "0x4000ACE")]
		Canceled,
		// Token: 0x04000863 RID: 2147
		[global::Cpp2ILInjected.Token(Token = "0x4000ACF")]
		Error
	}
}
