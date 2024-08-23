using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000124 RID: 292
	[global::Cpp2ILInjected.Token(Token = "0x2000167")]
	[StructLayout(0)]
	internal class MonoTypeInfo
	{
		// Token: 0x06000DB1 RID: 3505 RVA: 0x00016C19 File Offset: 0x00014E19
		[global::Cpp2ILInjected.Token(Token = "0x6000E8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79CE8", Offset = "0x1C79CE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetDefaultConstructor", ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public MonoTypeInfo()
		{
			throw null;
		}

		// Token: 0x04000468 RID: 1128
		[global::Cpp2ILInjected.Token(Token = "0x400062E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string full_name;

		// Token: 0x04000469 RID: 1129
		[global::Cpp2ILInjected.Token(Token = "0x400062F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public global::System.Reflection.RuntimeConstructorInfo default_ctor;
	}
}
