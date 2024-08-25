using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Mono
{
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	internal struct MonoAssemblyName
	{
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal global::System.IntPtr name;

		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal global::System.IntPtr culture;

		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr hash_value;

		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.IntPtr public_key;

		[global::System.Runtime.CompilerServices.FixedBuffer(typeof(byte), 17)]
		[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token;

		[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal uint hash_alg;

		[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal uint hash_len;

		[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal uint flags;

		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal ushort major;

		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		internal ushort minor;

		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		internal ushort build;

		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x46")]
		internal ushort revision;

		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal ushort arch;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::System.Runtime.CompilerServices.UnsafeValueType]
		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		[StructLayout(0, Size = 17)]
		public struct <public_key_token>e__FixedBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
