using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000A0 RID: 160
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000AF")]
	public sealed class RequireComponent : Attribute
	{
		// Token: 0x0600030F RID: 783 RVA: 0x00002665 File Offset: 0x00000865
		[global::Cpp2ILInjected.Token(Token = "0x600031E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CC44", Offset = "0x1F7CC44", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RequireComponent(Type requiredComponent)
		{
			throw null;
		}

		// Token: 0x04000338 RID: 824
		[global::Cpp2ILInjected.Token(Token = "0x400036A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Type m_Type0;

		// Token: 0x04000339 RID: 825
		[global::Cpp2ILInjected.Token(Token = "0x400036B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Type m_Type1;

		// Token: 0x0400033A RID: 826
		[global::Cpp2ILInjected.Token(Token = "0x400036C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Type m_Type2;
	}
}
