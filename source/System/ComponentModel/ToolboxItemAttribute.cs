using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x200036F")]
	public class ToolboxItemAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49F20", Offset = "0x1E49F20", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49F88", Offset = "0x1E49F88", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ToolboxItemAttribute(bool defaultType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49FE4", Offset = "0x1E49FE4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToolboxItemAttribute), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ToolboxItemAttribute(string toolboxItemTypeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A068", Offset = "0x1E4A068", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ToolboxItemAttribute(Type toolboxItemType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000532")]
		public Type ToolboxItemType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4A0A8", Offset = "0x1E4A0A8", Length = "0x194")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000533")]
		public string ToolboxItemTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4A23C", Offset = "0x1E4A23C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A290", Offset = "0x1E4A290", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A37C", Offset = "0x1E4A37C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A3A0", Offset = "0x1E4A3A0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToolboxItemAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static ToolboxItemAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001210")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Type _toolboxItemType;

		[global::Cpp2ILInjected.Token(Token = "0x4001211")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _toolboxItemTypeName;

		[global::Cpp2ILInjected.Token(Token = "0x4001212")]
		public static readonly ToolboxItemAttribute Default;

		[global::Cpp2ILInjected.Token(Token = "0x4001213")]
		public static readonly ToolboxItemAttribute None;
	}
}
