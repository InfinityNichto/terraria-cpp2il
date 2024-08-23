using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000390 RID: 912
	[global::System.AttributeUsage(global::System.AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200043A")]
	public sealed class InterfaceTypeAttribute : global::System.Attribute
	{
		// Token: 0x06001F27 RID: 7975 RVA: 0x00019C6D File Offset: 0x00017E6D
		[global::Cpp2ILInjected.Token(Token = "0x6002168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B700A0", Offset = "0x1B700A0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InterfaceTypeAttribute(ComInterfaceType interfaceType)
		{
			throw null;
		}

		// Token: 0x04000F0C RID: 3852
		[global::Cpp2ILInjected.Token(Token = "0x4001201")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ComInterfaceType _val;
	}
}
