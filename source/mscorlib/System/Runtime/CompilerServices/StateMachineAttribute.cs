using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200047E")]
	[global::System.Serializable]
	public class StateMachineAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72EFC", Offset = "0x1B72EFC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public StateMachineAttribute(global::System.Type stateMachineType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700046F")]
		public global::System.Type StateMachineType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002228")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73890", Offset = "0x1B73890", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Type <StateMachineType>k__BackingField;
	}
}
