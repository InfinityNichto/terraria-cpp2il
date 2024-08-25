using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x20003AB")]
	public sealed class PasswordPropertyTextAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60018CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56D20", Offset = "0x1E56D20", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public PasswordPropertyTextAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56D3C", Offset = "0x1E56D3C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public PasswordPropertyTextAttribute(bool password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005AA")]
		public bool Password
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60018CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E56D64", Offset = "0x1E56D64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56D6C", Offset = "0x1E56D6C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56DE8", Offset = "0x1E56DE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56DF0", Offset = "0x1E56DF0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60018D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56E58", Offset = "0x1E56E58", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static PasswordPropertyTextAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400129D")]
		public static readonly PasswordPropertyTextAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x400129E")]
		public static readonly PasswordPropertyTextAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x400129F")]
		public static readonly PasswordPropertyTextAttribute Default;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Password>k__BackingField;
	}
}
