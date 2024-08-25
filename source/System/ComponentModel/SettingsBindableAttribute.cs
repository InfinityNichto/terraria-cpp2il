using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20003B8")]
	public sealed class SettingsBindableAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001961")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D8B0", Offset = "0x1E5D8B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SettingsBindableAttribute(bool bindable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005CF")]
		public bool Bindable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001962")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5D8D8", Offset = "0x1E5D8D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001963")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D8E0", Offset = "0x1E5D8E0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001964")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D96C", Offset = "0x1E5D96C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001965")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D98C", Offset = "0x1E5D98C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SettingsBindableAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012C8")]
		public static readonly SettingsBindableAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x40012C9")]
		public static readonly SettingsBindableAttribute No;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Bindable>k__BackingField;
	}
}
