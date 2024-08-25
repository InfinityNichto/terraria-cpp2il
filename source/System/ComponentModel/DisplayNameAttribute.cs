using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	[global::Cpp2ILInjected.Token(Token = "0x2000338")]
	public class DisplayNameAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001583")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C3A4", Offset = "0x1E3C3A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DisplayNameAttribute), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DisplayNameAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C400", Offset = "0x1E3C400", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DisplayNameAttribute(string displayName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E7")]
		public virtual string DisplayName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001585")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C428", Offset = "0x1E3C428", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E8")]
		protected string DisplayNameValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001586")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C430", Offset = "0x1E3C430", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001587")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C438", Offset = "0x1E3C438", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001588")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C440", Offset = "0x1E3C440", Length = "0xC4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x6001589")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C504", Offset = "0x1E3C504", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600158A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C524", Offset = "0x1E3C524", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600158B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C58C", Offset = "0x1E3C58C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DisplayNameAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static DisplayNameAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001198")]
		public static readonly DisplayNameAttribute Default;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <DisplayNameValue>k__BackingField;
	}
}
