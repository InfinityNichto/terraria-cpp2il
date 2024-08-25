using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000022")]
	public class RequiredAttribute : ValidatorAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public string Message
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000063")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5A60", Offset = "0x1CB5A60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000064")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5A68", Offset = "0x1CB5A68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5A70", Offset = "0x1CB5A70", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RequiredAttribute(string message = null)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Message>k__BackingField;
	}
}
