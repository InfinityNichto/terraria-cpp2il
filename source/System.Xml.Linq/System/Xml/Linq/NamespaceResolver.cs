using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	internal struct NamespaceResolver
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000086")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DAD0", Offset = "0x1D6DAD0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void PushScope()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000087")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DB74", Offset = "0x1D6DB74", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteFullEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void PopScope()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000088")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DAE0", Offset = "0x1D6DAE0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(string prefix, XNamespace ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000089")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D984", Offset = "0x1D6D984", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddFirst(string prefix, XNamespace ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600008A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D860", Offset = "0x1D6D860", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "GetPrefixOfNamespace", MemberParameters = new object[]
		{
			typeof(XNamespace),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _scope;

		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private NamespaceResolver.NamespaceDeclaration _declaration;

		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NamespaceResolver.NamespaceDeclaration _rover;

		[global::Cpp2ILInjected.Token(Token = "0x2000013")]
		private class NamespaceDeclaration
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6DBD4", Offset = "0x1D6DBD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NamespaceDeclaration()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000029")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string prefix;

			[global::Cpp2ILInjected.Token(Token = "0x400002A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public XNamespace ns;

			[global::Cpp2ILInjected.Token(Token = "0x400002B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int scope;

			[global::Cpp2ILInjected.Token(Token = "0x400002C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public NamespaceResolver.NamespaceDeclaration prev;
		}
	}
}
