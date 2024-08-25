using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Event, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000438")]
	public sealed class DispIdAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70078", Offset = "0x1B70078", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DispIdAttribute(int dispId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int _val;
	}
}
