using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200043D")]
	public sealed class ClassInterfaceAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600216A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B700F0", Offset = "0x1B700F0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001207")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ClassInterfaceType _val;
	}
}
