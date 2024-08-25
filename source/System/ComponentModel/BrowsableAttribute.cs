using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000331")]
	public sealed class BrowsableAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600155C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B1C0", Offset = "0x1E3B1C0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public BrowsableAttribute(bool browsable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DE")]
		public bool Browsable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600155D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3B1E8", Offset = "0x1E3B1E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600155E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B1F0", Offset = "0x1E3B1F0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600155F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B2D4", Offset = "0x1E3B2D4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001560")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B2F4", Offset = "0x1E3B2F4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001561")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B35C", Offset = "0x1E3B35C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static BrowsableAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001180")]
		public static readonly BrowsableAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x4001181")]
		public static readonly BrowsableAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x4001182")]
		public static readonly BrowsableAttribute Default;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001183")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Browsable>k__BackingField;
	}
}
