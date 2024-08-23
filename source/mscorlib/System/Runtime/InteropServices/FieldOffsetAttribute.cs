using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x020003A0 RID: 928
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200044A")]
	public sealed class FieldOffsetAttribute : global::System.Attribute
	{
		// Token: 0x06001F37 RID: 7991 RVA: 0x00019C9D File Offset: 0x00017E9D
		[global::Cpp2ILInjected.Token(Token = "0x6002178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7043C", Offset = "0x1B7043C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public FieldOffsetAttribute(int offset)
		{
			throw null;
		}

		// Token: 0x04000F7B RID: 3963
		[global::Cpp2ILInjected.Token(Token = "0x4001270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int _val;
	}
}
