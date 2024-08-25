using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	[global::Cpp2ILInjected.Token(Token = "0x2000337")]
	public sealed class DesignerSerializationVisibilityAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600157D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C180", Offset = "0x1E3C180", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E6")]
		public DesignerSerializationVisibility Visibility
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600157E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C1A8", Offset = "0x1E3C1A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600157F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C1B0", Offset = "0x1E3C1B0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C288", Offset = "0x1E3C288", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C290", Offset = "0x1E3C290", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001582")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C2F8", Offset = "0x1E3C2F8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static DesignerSerializationVisibilityAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001193")]
		public static readonly DesignerSerializationVisibilityAttribute Content;

		[global::Cpp2ILInjected.Token(Token = "0x4001194")]
		public static readonly DesignerSerializationVisibilityAttribute Hidden;

		[global::Cpp2ILInjected.Token(Token = "0x4001195")]
		public static readonly DesignerSerializationVisibilityAttribute Visible;

		[global::Cpp2ILInjected.Token(Token = "0x4001196")]
		public static readonly DesignerSerializationVisibilityAttribute Default;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly DesignerSerializationVisibility <Visibility>k__BackingField;
	}
}
