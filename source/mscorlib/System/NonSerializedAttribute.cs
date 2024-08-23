using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000AF RID: 175
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000DF")]
	public sealed class NonSerializedAttribute : global::System.Attribute
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x00015B4E File Offset: 0x00013D4E
		[global::Cpp2ILInjected.Token(Token = "0x6000842")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3762C", Offset = "0x1C3762C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NonSerializedAttribute()
		{
			throw null;
		}
	}
}
