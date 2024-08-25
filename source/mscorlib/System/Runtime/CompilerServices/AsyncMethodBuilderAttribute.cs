using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000462")]
	public sealed class AsyncMethodBuilderAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60021F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72EAC", Offset = "0x1B72EAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AsyncMethodBuilderAttribute(global::System.Type builderType)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Type <BuilderType>k__BackingField;
	}
}
