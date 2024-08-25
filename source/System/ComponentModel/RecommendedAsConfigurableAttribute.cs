using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property)]
	[Obsolete("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
	[global::Cpp2ILInjected.Token(Token = "0x20003B0")]
	public class RecommendedAsConfigurableAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001931")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A358", Offset = "0x1E5A358", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005C7")]
		public bool RecommendedAsConfigurable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001932")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A380", Offset = "0x1E5A380", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001933")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A388", Offset = "0x1E5A388", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001934")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A430", Offset = "0x1E5A430", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001935")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A438", Offset = "0x1E5A438", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001936")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A448", Offset = "0x1E5A448", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static RecommendedAsConfigurableAttribute()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <RecommendedAsConfigurable>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x40012B6")]
		public static readonly RecommendedAsConfigurableAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x40012B7")]
		public static readonly RecommendedAsConfigurableAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x40012B8")]
		public static readonly RecommendedAsConfigurableAttribute Default;
	}
}
