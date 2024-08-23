using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public enum FocusType
	{
		// Token: 0x0400001D RID: 29
		[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", false)]
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		Native,
		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		Keyboard,
		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		Passive
	}
}
