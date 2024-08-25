using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x200034C")]
	public class AttributeProviderAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60015F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3EF54", Offset = "0x1E3EF54", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public AttributeProviderAttribute(string typeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3EFC8", Offset = "0x1E3EFC8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public AttributeProviderAttribute(string typeName, string propertyName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F064", Offset = "0x1E3F064", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public AttributeProviderAttribute(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004FE")]
		public string TypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3F140", Offset = "0x1E3F140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004FF")]
		public string PropertyName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3F148", Offset = "0x1E3F148", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <TypeName>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <PropertyName>k__BackingField;
	}
}
