using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Parameter)]
	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	internal class NotNullAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public string Exception
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA40EC", Offset = "0x1FA40EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA40F4", Offset = "0x1FA40F4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NotNullAttribute(string exception = "ArgumentNullException")
		{
			throw null;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Exception>k__BackingField;
	}
}
