using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method | global::System.AttributeTargets.Property, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20005CB")]
	[global::System.Serializable]
	public sealed class DebuggerNonUserCodeAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04828", Offset = "0x1C04828", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DebuggerNonUserCodeAttribute()
		{
			throw null;
		}
	}
}
