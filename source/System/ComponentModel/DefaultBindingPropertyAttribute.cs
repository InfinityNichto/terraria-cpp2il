using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x2000367")]
	public sealed class DefaultBindingPropertyAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48BE4", Offset = "0x1E48BE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultBindingPropertyAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48BEC", Offset = "0x1E48BEC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultBindingPropertyAttribute(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700052A")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E48C14", Offset = "0x1E48C14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48C1C", Offset = "0x1E48C1C", Length = "0x74")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60016BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48C90", Offset = "0x1E48C90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48C98", Offset = "0x1E48C98", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static DefaultBindingPropertyAttribute()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Name>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x40011F9")]
		public static readonly DefaultBindingPropertyAttribute Default;
	}
}
