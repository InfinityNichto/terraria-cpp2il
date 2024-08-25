using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel.Design.Serialization
{
	[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000415")]
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8C724", Offset = "0x1E8C724", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700063E")]
		public string SerializerBaseTypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001C1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8C760", Offset = "0x1E8C760", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700063F")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8C768", Offset = "0x1E8C768", Length = "0x80")]
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

		[global::Cpp2ILInjected.Token(Token = "0x4001391")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _typeId;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001392")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool <Reloadable>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001393")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string <SerializerTypeName>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001394")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string <SerializerBaseTypeName>k__BackingField;
	}
}
