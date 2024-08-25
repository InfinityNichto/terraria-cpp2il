using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000342")]
	public sealed class LocalizableAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60015B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CBC0", Offset = "0x1E3CBC0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LocalizableAttribute(bool isLocalizable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004F2")]
		public bool IsLocalizable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3CBE8", Offset = "0x1E3CBE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CBF0", Offset = "0x1E3CBF0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CCD4", Offset = "0x1E3CCD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CCDC", Offset = "0x1E3CCDC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CD54", Offset = "0x1E3CD54", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static LocalizableAttribute()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsLocalizable>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x40011A5")]
		public static readonly LocalizableAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x40011A6")]
		public static readonly LocalizableAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x40011A7")]
		public static readonly LocalizableAttribute Default;
	}
}
