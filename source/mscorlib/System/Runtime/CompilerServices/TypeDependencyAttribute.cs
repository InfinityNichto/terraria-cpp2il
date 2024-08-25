using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200049D")]
	internal sealed class TypeDependencyAttribute : global::System.Attribute
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40012E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string typeName;
	}
}
