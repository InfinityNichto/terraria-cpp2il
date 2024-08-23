using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.CodeDom.Compiler
{
	// Token: 0x0200006E RID: 110
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000C6")]
	public sealed class GeneratedCodeAttribute : Attribute
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x0000397A File Offset: 0x00001B7A
		[global::Cpp2ILInjected.Token(Token = "0x6000492")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC48E4", Offset = "0x1EC48E4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public GeneratedCodeAttribute(string tool, string version)
		{
			throw null;
		}

		// Token: 0x0400024A RID: 586
		[global::Cpp2ILInjected.Token(Token = "0x400038B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string tool;

		// Token: 0x0400024B RID: 587
		[global::Cpp2ILInjected.Token(Token = "0x400038C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string version;
	}
}
