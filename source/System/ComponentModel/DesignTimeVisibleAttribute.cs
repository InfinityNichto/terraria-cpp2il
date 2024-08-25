using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	[global::Cpp2ILInjected.Token(Token = "0x2000370")]
	public sealed class DesignTimeVisibleAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A454", Offset = "0x1E4A454", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignTimeVisibleAttribute(bool visible)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A47C", Offset = "0x1E4A47C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignTimeVisibleAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000534")]
		public bool Visible
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4A484", Offset = "0x1E4A484", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A48C", Offset = "0x1E4A48C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A518", Offset = "0x1E4A518", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A5AC", Offset = "0x1E4A5AC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A624", Offset = "0x1E4A624", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static DesignTimeVisibleAttribute()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Visible>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4001215")]
		public static readonly DesignTimeVisibleAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x4001216")]
		public static readonly DesignTimeVisibleAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x4001217")]
		public static readonly DesignTimeVisibleAttribute Default;
	}
}
