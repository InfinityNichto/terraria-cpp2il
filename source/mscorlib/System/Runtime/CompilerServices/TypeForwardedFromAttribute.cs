using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000481")]
	public sealed class TypeForwardedFromAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600222B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73914", Offset = "0x1B73914", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TypeForwardedFromAttribute(string assemblyFullName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000470")]
		public string AssemblyFullName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600222C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73994", Offset = "0x1B73994", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <AssemblyFullName>k__BackingField;
	}
}
