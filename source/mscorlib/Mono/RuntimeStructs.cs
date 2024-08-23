using System;
using Cpp2ILInjected;

namespace Mono
{
	// Token: 0x02000012 RID: 18
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	internal static class RuntimeStructs
	{
		// Token: 0x0200055D RID: 1373
		[global::Cpp2ILInjected.Token(Token = "0x200001B")]
		internal struct RemoteClass
		{
			// Token: 0x0400172A RID: 5930
			[global::Cpp2ILInjected.Token(Token = "0x4000091")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal global::System.IntPtr default_vtable;

			// Token: 0x0400172B RID: 5931
			[global::Cpp2ILInjected.Token(Token = "0x4000092")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal global::System.IntPtr xdomain_vtable;

			// Token: 0x0400172C RID: 5932
			[global::Cpp2ILInjected.Token(Token = "0x4000093")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal unsafe RuntimeStructs.MonoClass* proxy_class;

			// Token: 0x0400172D RID: 5933
			[global::Cpp2ILInjected.Token(Token = "0x4000094")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal global::System.IntPtr proxy_class_name;

			// Token: 0x0400172E RID: 5934
			[global::Cpp2ILInjected.Token(Token = "0x4000095")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal uint interface_count;
		}

		// Token: 0x0200055E RID: 1374
		[global::Cpp2ILInjected.Token(Token = "0x200001C")]
		internal struct MonoClass
		{
		}

		// Token: 0x0200055F RID: 1375
		[global::Cpp2ILInjected.Token(Token = "0x200001D")]
		internal struct GenericParamInfo
		{
			// Token: 0x0400172F RID: 5935
			[global::Cpp2ILInjected.Token(Token = "0x4000096")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal unsafe RuntimeStructs.MonoClass* pklass;

			// Token: 0x04001730 RID: 5936
			[global::Cpp2ILInjected.Token(Token = "0x4000097")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal global::System.IntPtr name;

			// Token: 0x04001731 RID: 5937
			[global::Cpp2ILInjected.Token(Token = "0x4000098")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal ushort flags;

			// Token: 0x04001732 RID: 5938
			[global::Cpp2ILInjected.Token(Token = "0x4000099")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			internal uint token;

			// Token: 0x04001733 RID: 5939
			[global::Cpp2ILInjected.Token(Token = "0x400009A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal unsafe RuntimeStructs.MonoClass** constraints;
		}

		// Token: 0x02000560 RID: 1376
		[global::Cpp2ILInjected.Token(Token = "0x200001E")]
		internal struct GPtrArray
		{
			// Token: 0x04001734 RID: 5940
			[global::Cpp2ILInjected.Token(Token = "0x400009B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal unsafe global::System.IntPtr* data;

			// Token: 0x04001735 RID: 5941
			[global::Cpp2ILInjected.Token(Token = "0x400009C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int len;
		}
	}
}
