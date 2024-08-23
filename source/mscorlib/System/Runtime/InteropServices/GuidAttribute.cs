using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000398 RID: 920
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000442")]
	public sealed class GuidAttribute : global::System.Attribute
	{
		// Token: 0x06001F2C RID: 7980 RVA: 0x00019C7C File Offset: 0x00017E7C
		[global::Cpp2ILInjected.Token(Token = "0x600216D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70148", Offset = "0x1B70148", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public GuidAttribute(string guid)
		{
			throw null;
		}

		// Token: 0x04000F68 RID: 3944
		[global::Cpp2ILInjected.Token(Token = "0x400125D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string _val;
	}
}
