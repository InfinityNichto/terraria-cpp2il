using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000401 RID: 1025
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004BF")]
	public sealed class AssemblyDefaultAliasAttribute : global::System.Attribute
	{
		// Token: 0x060020C9 RID: 8393 RVA: 0x0001A0E7 File Offset: 0x000182E7
		[global::Cpp2ILInjected.Token(Token = "0x6002361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80660", Offset = "0x1B80660", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyDefaultAliasAttribute(string defaultAlias)
		{
			throw null;
		}

		// Token: 0x04001040 RID: 4160
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400135A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <DefaultAlias>k__BackingField;
	}
}
