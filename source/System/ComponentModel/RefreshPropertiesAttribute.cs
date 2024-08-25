using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000404")]
	public sealed class RefreshPropertiesAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001BEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A8FC", Offset = "0x1E8A8FC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RefreshPropertiesAttribute(RefreshProperties refresh)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700063A")]
		public RefreshProperties RefreshProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8A924", Offset = "0x1E8A924", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A92C", Offset = "0x1E8A92C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A99C", Offset = "0x1E8A99C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A9A4", Offset = "0x1E8A9A4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8AA0C", Offset = "0x1E8AA0C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static RefreshPropertiesAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001383")]
		public static readonly RefreshPropertiesAttribute All;

		[global::Cpp2ILInjected.Token(Token = "0x4001384")]
		public static readonly RefreshPropertiesAttribute Repaint;

		[global::Cpp2ILInjected.Token(Token = "0x4001385")]
		public static readonly RefreshPropertiesAttribute Default;

		[global::Cpp2ILInjected.Token(Token = "0x4001386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RefreshProperties refresh;
	}
}
