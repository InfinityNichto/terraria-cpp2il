using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20003A0")]
	public sealed class LookupBindingPropertiesAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600181D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50104", Offset = "0x1E50104", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LookupBindingPropertiesAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600181E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50124", Offset = "0x1E50124", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000581")]
		public string DataSource
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600181F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E50164", Offset = "0x1E50164", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000582")]
		public string DisplayMember
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001820")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5016C", Offset = "0x1E5016C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000583")]
		public string ValueMember
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001821")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E50174", Offset = "0x1E50174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000584")]
		public string LookupMember
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001822")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5017C", Offset = "0x1E5017C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001823")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50184", Offset = "0x1E50184", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001824")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50238", Offset = "0x1E50238", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001825")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50240", Offset = "0x1E50240", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static LookupBindingPropertiesAttribute()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001253")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <DataSource>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001254")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <DisplayMember>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001255")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string <ValueMember>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001256")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string <LookupMember>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4001257")]
		public static readonly LookupBindingPropertiesAttribute Default;
	}
}
