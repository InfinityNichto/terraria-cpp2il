using System;
using Cpp2ILInjected;

namespace Mono
{
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	internal static class RuntimeStructs
	{
		[global::Cpp2ILInjected.Token(Token = "0x200001B")]
		internal struct RemoteClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000091")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal global::System.IntPtr default_vtable;

			[global::Cpp2ILInjected.Token(Token = "0x4000092")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal global::System.IntPtr xdomain_vtable;

			[global::Cpp2ILInjected.Token(Token = "0x4000093")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal unsafe RuntimeStructs.MonoClass* proxy_class;

			[global::Cpp2ILInjected.Token(Token = "0x4000094")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal global::System.IntPtr proxy_class_name;

			[global::Cpp2ILInjected.Token(Token = "0x4000095")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal uint interface_count;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200001C")]
		internal struct MonoClass
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x200001D")]
		internal struct GenericParamInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000096")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal unsafe RuntimeStructs.MonoClass* pklass;

			[global::Cpp2ILInjected.Token(Token = "0x4000097")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal global::System.IntPtr name;

			[global::Cpp2ILInjected.Token(Token = "0x4000098")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal ushort flags;

			[global::Cpp2ILInjected.Token(Token = "0x4000099")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			internal uint token;

			[global::Cpp2ILInjected.Token(Token = "0x400009A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal unsafe RuntimeStructs.MonoClass** constraints;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200001E")]
		internal struct GPtrArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x400009B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal unsafe global::System.IntPtr* data;

			[global::Cpp2ILInjected.Token(Token = "0x400009C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int len;
		}
	}
}
