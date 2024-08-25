using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200046C")]
	[global::System.Serializable]
	public abstract class CustomConstantAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000465")]
		public abstract object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002208")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002209")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73310", Offset = "0x1B73310", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomConstantAttribute()
		{
			throw null;
		}
	}
}
