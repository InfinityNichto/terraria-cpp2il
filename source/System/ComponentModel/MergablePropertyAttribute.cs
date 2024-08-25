using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000343")]
	public sealed class MergablePropertyAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60015B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CDDC", Offset = "0x1E3CDDC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MergablePropertyAttribute(bool allowMerge)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004F3")]
		public bool AllowMerge
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3CE04", Offset = "0x1E3CE04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CE0C", Offset = "0x1E3CE0C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CEF0", Offset = "0x1E3CEF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CEF8", Offset = "0x1E3CEF8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CF60", Offset = "0x1E3CF60", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static MergablePropertyAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011A8")]
		public static readonly MergablePropertyAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x40011A9")]
		public static readonly MergablePropertyAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x40011AA")]
		public static readonly MergablePropertyAttribute Default;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <AllowMerge>k__BackingField;
	}
}
