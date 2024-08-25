using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Module, AllowMultiple = false)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005CC")]
	public sealed class DebuggableAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04830", Offset = "0x1C04830", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400194F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DebuggableAttribute.DebuggingModes m_debuggingModes;

		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x20005CD")]
		public enum DebuggingModes
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001951")]
			None = 0,
			[global::Cpp2ILInjected.Token(Token = "0x4001952")]
			Default = 1,
			[global::Cpp2ILInjected.Token(Token = "0x4001953")]
			DisableOptimizations = 256,
			[global::Cpp2ILInjected.Token(Token = "0x4001954")]
			IgnoreSymbolStoreSequencePoints = 2,
			[global::Cpp2ILInjected.Token(Token = "0x4001955")]
			EnableEditAndContinue = 4
		}
	}
}
