using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004A8")]
	public sealed class NeutralResourcesLanguageAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60022C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75C60", Offset = "0x1B75C60", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public NeutralResourcesLanguageAttribute(string cultureName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700047F")]
		public string CultureName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60022CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75CD8", Offset = "0x1B75CD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000480")]
		public UltimateResourceFallbackLocation Location
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60022CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75CE0", Offset = "0x1B75CE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <CultureName>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly UltimateResourceFallbackLocation <Location>k__BackingField;
	}
}
