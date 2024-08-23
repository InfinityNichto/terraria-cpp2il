using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200038F RID: 911
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000439")]
	[global::System.Serializable]
	public enum ComInterfaceType
	{
		// Token: 0x04000F08 RID: 3848
		[global::Cpp2ILInjected.Token(Token = "0x40011FD")]
		InterfaceIsDual,
		// Token: 0x04000F09 RID: 3849
		[global::Cpp2ILInjected.Token(Token = "0x40011FE")]
		InterfaceIsIUnknown,
		// Token: 0x04000F0A RID: 3850
		[global::Cpp2ILInjected.Token(Token = "0x40011FF")]
		InterfaceIsIDispatch,
		// Token: 0x04000F0B RID: 3851
		[ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x4001200")]
		InterfaceIsIInspectable
	}
}
