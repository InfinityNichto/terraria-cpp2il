using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200043A")]
	public sealed class InterfaceTypeAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B700A0", Offset = "0x1B700A0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InterfaceTypeAttribute(ComInterfaceType interfaceType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001201")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ComInterfaceType _val;
	}
}
