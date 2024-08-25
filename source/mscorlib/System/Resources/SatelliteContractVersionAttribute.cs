using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004AD")]
	public sealed class SatelliteContractVersionAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60022E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B778E8", Offset = "0x1B778E8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public SatelliteContractVersionAttribute(string version)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000483")]
		public string Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60022E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7795C", Offset = "0x1B7795C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400131C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Version>k__BackingField;
	}
}
