using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000437")]
	public sealed class UnmanagedFunctionPointerAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70050", Offset = "0x1B70050", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CallingConvention m_callingConvention;
	}
}
