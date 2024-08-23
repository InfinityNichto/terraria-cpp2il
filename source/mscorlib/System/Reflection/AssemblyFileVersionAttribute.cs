using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000404 RID: 1028
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004C2")]
	public sealed class AssemblyFileVersionAttribute : global::System.Attribute
	{
		// Token: 0x060020CC RID: 8396 RVA: 0x0001A0F0 File Offset: 0x000182F0
		[global::Cpp2ILInjected.Token(Token = "0x6002364")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B806D8", Offset = "0x1B806D8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public AssemblyFileVersionAttribute(string version)
		{
			throw null;
		}

		// Token: 0x04001043 RID: 4163
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400135D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Version>k__BackingField;
	}
}
