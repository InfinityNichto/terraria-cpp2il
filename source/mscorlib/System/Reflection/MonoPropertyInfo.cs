using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x02000450 RID: 1104
	[global::Cpp2ILInjected.Token(Token = "0x2000512")]
	internal struct MonoPropertyInfo
	{
		// Token: 0x040011E2 RID: 4578
		[global::Cpp2ILInjected.Token(Token = "0x4001500")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.Type parent;

		// Token: 0x040011E3 RID: 4579
		[global::Cpp2ILInjected.Token(Token = "0x4001501")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public global::System.Type declaring_type;

		// Token: 0x040011E4 RID: 4580
		[global::Cpp2ILInjected.Token(Token = "0x4001502")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040011E5 RID: 4581
		[global::Cpp2ILInjected.Token(Token = "0x4001503")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public MethodInfo get_method;

		// Token: 0x040011E6 RID: 4582
		[global::Cpp2ILInjected.Token(Token = "0x4001504")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public MethodInfo set_method;

		// Token: 0x040011E7 RID: 4583
		[global::Cpp2ILInjected.Token(Token = "0x4001505")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public PropertyAttributes attrs;
	}
}
