using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000104 RID: 260
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200013C")]
	internal class MonoTODOAttribute : global::System.Attribute
	{
		// Token: 0x06000BDC RID: 3036 RVA: 0x00016769 File Offset: 0x00014969
		[global::Cpp2ILInjected.Token(Token = "0x6000CAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C2AC", Offset = "0x1C5C2AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MonoTODOAttribute()
		{
			throw null;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0001676C File Offset: 0x0001496C
		[global::Cpp2ILInjected.Token(Token = "0x6000CAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C2BC", Offset = "0x1C5C2BC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MonoTODOAttribute(string comment)
		{
			throw null;
		}

		// Token: 0x04000380 RID: 896
		[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string comment;
	}
}
