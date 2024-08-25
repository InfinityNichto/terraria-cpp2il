using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003AF")]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600192A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A1D0", Offset = "0x1E5A1D0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ProvidePropertyAttribute(string propertyName, Type receiverType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600192B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A214", Offset = "0x1E5A214", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005C4")]
		public string PropertyName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600192C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A240", Offset = "0x1E5A240", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005C5")]
		public string ReceiverTypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600192D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A248", Offset = "0x1E5A248", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600192E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A250", Offset = "0x1E5A250", Length = "0x9C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x600192F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A2EC", Offset = "0x1E5A2EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005C6")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001930")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A328", Offset = "0x1E5A328", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <PropertyName>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <ReceiverTypeName>k__BackingField;
	}
}
