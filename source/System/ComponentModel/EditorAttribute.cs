using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000372")]
	public sealed class EditorAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A904", Offset = "0x1E4A904", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public EditorAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001700")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A960", Offset = "0x1E4A960", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EditorAttribute(string typeName, string baseTypeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001701")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A9E8", Offset = "0x1E4A9E8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EditorAttribute(string typeName, Type baseType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001702")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AA88", Offset = "0x1E4AA88", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EditorAttribute(Type type, Type baseType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000537")]
		public string EditorBaseTypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001703")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4AAE0", Offset = "0x1E4AAE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000538")]
		public string EditorTypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001704")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4AAE8", Offset = "0x1E4AAE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000539")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001705")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4AAF0", Offset = "0x1E4AAF0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001706")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AB70", Offset = "0x1E4AB70", Length = "0x9C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x6001707")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC0C", Offset = "0x1E4AC0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _typeId;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001219")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <EditorBaseTypeName>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400121A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string <EditorTypeName>k__BackingField;
	}
}
