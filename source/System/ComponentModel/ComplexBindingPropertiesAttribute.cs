using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x200035A")]
	public sealed class ComplexBindingPropertiesAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001665")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40898", Offset = "0x1E40898", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ComplexBindingPropertiesAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001666")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E408A0", Offset = "0x1E408A0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ComplexBindingPropertiesAttribute(string dataSource)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001667")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E408C8", Offset = "0x1E408C8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ComplexBindingPropertiesAttribute(string dataSource, string dataMember)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700051D")]
		public string DataSource
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001668")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E408F4", Offset = "0x1E408F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700051E")]
		public string DataMember
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001669")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E408FC", Offset = "0x1E408FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600166A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40904", Offset = "0x1E40904", Length = "0x8C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x600166B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40990", Offset = "0x1E40990", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600166C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40998", Offset = "0x1E40998", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ComplexBindingPropertiesAttribute()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <DataSource>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <DataMember>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x40011E0")]
		public static readonly ComplexBindingPropertiesAttribute Default;
	}
}
