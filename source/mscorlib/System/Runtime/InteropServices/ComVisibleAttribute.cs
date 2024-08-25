using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Method | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200043E")]
	public sealed class ComVisibleAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600216B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70118", Offset = "0x1B70118", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ComVisibleAttribute(bool visibility)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001208")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool _val;
	}
}
