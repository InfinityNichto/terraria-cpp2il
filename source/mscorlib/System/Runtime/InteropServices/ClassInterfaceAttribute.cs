using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000393 RID: 915
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200043D")]
	public sealed class ClassInterfaceAttribute : global::System.Attribute
	{
		// Token: 0x06001F29 RID: 7977 RVA: 0x00019C73 File Offset: 0x00017E73
		[global::Cpp2ILInjected.Token(Token = "0x600216A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B700F0", Offset = "0x1B700F0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
		{
			throw null;
		}

		// Token: 0x04000F12 RID: 3858
		[global::Cpp2ILInjected.Token(Token = "0x4001207")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ClassInterfaceType _val;
	}
}
