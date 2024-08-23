using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[NativeType(CodegenOptions.Custom, "ScriptingJvalue")]
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	[StructLayout(2)]
	public struct jvalue
	{
		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public bool z;

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public sbyte b;

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public char c;

		// Token: 0x04000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public short s;

		// Token: 0x04000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public int i;

		// Token: 0x04000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public long j;

		// Token: 0x0400001A RID: 26
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public float f;

		// Token: 0x0400001B RID: 27
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public double d;

		// Token: 0x0400001C RID: 28
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public IntPtr l;
	}
}
