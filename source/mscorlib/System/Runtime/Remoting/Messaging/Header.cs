using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000303 RID: 771
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003A8")]
	[global::System.Serializable]
	public class Header
	{
		// Token: 0x04000C37 RID: 3127
		[global::Cpp2ILInjected.Token(Token = "0x4000F23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string HeaderNamespace;

		// Token: 0x04000C38 RID: 3128
		[global::Cpp2ILInjected.Token(Token = "0x4000F24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool MustUnderstand;

		// Token: 0x04000C39 RID: 3129
		[global::Cpp2ILInjected.Token(Token = "0x4000F25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string Name;

		// Token: 0x04000C3A RID: 3130
		[global::Cpp2ILInjected.Token(Token = "0x4000F26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public object Value;
	}
}
