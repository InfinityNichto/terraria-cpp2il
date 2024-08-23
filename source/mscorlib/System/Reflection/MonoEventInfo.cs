using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x02000447 RID: 1095
	[global::Cpp2ILInjected.Token(Token = "0x2000509")]
	internal struct MonoEventInfo
	{
		// Token: 0x040011C0 RID: 4544
		[global::Cpp2ILInjected.Token(Token = "0x40014DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.Type declaring_type;

		// Token: 0x040011C1 RID: 4545
		[global::Cpp2ILInjected.Token(Token = "0x40014DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public global::System.Type reflected_type;

		// Token: 0x040011C2 RID: 4546
		[global::Cpp2ILInjected.Token(Token = "0x40014E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040011C3 RID: 4547
		[global::Cpp2ILInjected.Token(Token = "0x40014E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public MethodInfo add_method;

		// Token: 0x040011C4 RID: 4548
		[global::Cpp2ILInjected.Token(Token = "0x40014E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public MethodInfo remove_method;

		// Token: 0x040011C5 RID: 4549
		[global::Cpp2ILInjected.Token(Token = "0x40014E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public MethodInfo raise_method;

		// Token: 0x040011C6 RID: 4550
		[global::Cpp2ILInjected.Token(Token = "0x40014E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public EventAttributes attrs;

		// Token: 0x040011C7 RID: 4551
		[global::Cpp2ILInjected.Token(Token = "0x40014E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public MethodInfo[] other_methods;
	}
}
