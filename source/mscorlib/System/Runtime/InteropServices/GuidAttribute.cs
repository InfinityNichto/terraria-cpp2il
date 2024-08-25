using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000442")]
	public sealed class GuidAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600216D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70148", Offset = "0x1B70148", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public GuidAttribute(string guid)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400125D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string _val;
	}
}
