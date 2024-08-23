using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Mono
{
	// Token: 0x02000013 RID: 19
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	internal struct MonoAssemblyName
	{
		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal global::System.IntPtr name;

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal global::System.IntPtr culture;

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr hash_value;

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.IntPtr public_key;

		// Token: 0x04000012 RID: 18
		[global::System.Runtime.CompilerServices.FixedBuffer(typeof(byte), 17)]
		[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token;

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal uint hash_alg;

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal uint hash_len;

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal uint flags;

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal ushort major;

		// Token: 0x04000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		internal ushort minor;

		// Token: 0x04000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		internal ushort build;

		// Token: 0x04000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x46")]
		internal ushort revision;

		// Token: 0x0400001A RID: 26
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal ushort arch;

		// Token: 0x02000561 RID: 1377
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::System.Runtime.CompilerServices.UnsafeValueType]
		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		[StructLayout(0, Size = 17)]
		public struct <public_key_token>e__FixedBuffer
		{
			// Token: 0x04001736 RID: 5942
			[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
