using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000406 RID: 1030
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004C4")]
	public sealed class AssemblyKeyFileAttribute : global::System.Attribute
	{
		// Token: 0x060020CE RID: 8398 RVA: 0x0001A0F6 File Offset: 0x000182F6
		[global::Cpp2ILInjected.Token(Token = "0x6002366")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80774", Offset = "0x1B80774", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyKeyFileAttribute(string keyFile)
		{
			throw null;
		}

		// Token: 0x04001045 RID: 4165
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400135F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <KeyFile>k__BackingField;
	}
}
