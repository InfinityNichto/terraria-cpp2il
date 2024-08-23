using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003E5 RID: 997
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200049D")]
	internal sealed class TypeDependencyAttribute : global::System.Attribute
	{
		// Token: 0x0600201D RID: 8221 RVA: 0x00019EF8 File Offset: 0x000180F8
		[global::Cpp2ILInjected.Token(Token = "0x600228D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75948", Offset = "0x1B75948", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TypeDependencyAttribute(string typeName)
		{
			throw null;
		}

		// Token: 0x04000FDC RID: 4060
		[global::Cpp2ILInjected.Token(Token = "0x40012E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string typeName;
	}
}
