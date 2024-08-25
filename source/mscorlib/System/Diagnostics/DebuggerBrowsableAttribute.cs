using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Property | global::System.AttributeTargets.Field, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20005CF")]
	public sealed class DebuggerBrowsableAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04858", Offset = "0x1C04858", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400195A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DebuggerBrowsableState state;
	}
}
