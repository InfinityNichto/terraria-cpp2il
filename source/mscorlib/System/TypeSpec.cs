using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000153 RID: 339
	[global::Cpp2ILInjected.Token(Token = "0x200019E")]
	internal class TypeSpec
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00016F0A File Offset: 0x0001510A
		[global::Cpp2ILInjected.Token(Token = "0x1700016D")]
		internal bool HasModifiers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89A8C", Offset = "0x1C89A8C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00016F0D File Offset: 0x0001510D
		[global::Cpp2ILInjected.Token(Token = "0x6000FD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89A9C", Offset = "0x1C89A9C", Length = "0x408")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "GetDisplayFullName", MemberParameters = new object[] { typeof(global::System.TypeSpec.DisplayNameFormat) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "get_DisplayFullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Resolve", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "GetDisplayFullName", MemberParameters = new object[] { typeof(global::System.TypeSpec.DisplayNameFormat) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "GetModifierString", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private string GetDisplayFullName(global::System.TypeSpec.DisplayNameFormat flags)
		{
			throw null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00016F10 File Offset: 0x00015110
		[global::Cpp2ILInjected.Token(Token = "0x6000FD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89ECC", Offset = "0x1C89ECC", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "GetDisplayFullName", MemberParameters = new object[] { typeof(global::System.TypeSpec.DisplayNameFormat) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private global::System.Text.StringBuilder GetModifierString(global::System.Text.StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00016F13 File Offset: 0x00015113
		[global::Cpp2ILInjected.Token(Token = "0x1700016E")]
		internal string DisplayFullName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89EA4", Offset = "0x1C89EA4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "GetDisplayFullName", MemberParameters = new object[] { typeof(global::System.TypeSpec.DisplayNameFormat) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00016F16 File Offset: 0x00015116
		[global::Cpp2ILInjected.Token(Token = "0x6000FDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8A094", Offset = "0x1C8A094", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeNameParser), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static global::System.TypeSpec Parse(string typeName)
		{
			throw null;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00016F19 File Offset: 0x00015119
		[global::Cpp2ILInjected.Token(Token = "0x6000FDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8AC70", Offset = "0x1C8AC70", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.TypeIdentifiers.Display", Member = "get_InternalName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.TypeIdentifiers.Display", Member = "GetInternalName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static string UnescapeInternalName(string displayName)
		{
			throw null;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00016F1C File Offset: 0x0001511C
		[global::Cpp2ILInjected.Token(Token = "0x6000FDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8AD4C", Offset = "0x1C8AD4C", Length = "0x890")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeNameParser), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Resolve", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "GetDisplayFullName", MemberParameters = new object[] { typeof(global::System.TypeSpec.DisplayNameFormat) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "Resolve", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
		internal global::System.Type Resolve(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly> assemblyResolver, global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type> typeResolver, bool throwOnError, bool ignoreCase, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00016F1F File Offset: 0x0001511F
		[global::Cpp2ILInjected.Token(Token = "0x6000FDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B5DC", Offset = "0x1C8B5DC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeIdentifiers), Member = "FromDisplay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TypeIdentifier))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddName(string type_name)
		{
			throw null;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00016F22 File Offset: 0x00015122
		[global::Cpp2ILInjected.Token(Token = "0x6000FDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B6FC", Offset = "0x1C8B6FC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddModifier(global::System.ModifierSpec md)
		{
			throw null;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00016F25 File Offset: 0x00015125
		[global::Cpp2ILInjected.Token(Token = "0x6000FDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B7EC", Offset = "0x1C8B7EC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void SkipSpace(string name, ref int pos)
		{
			throw null;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00016F28 File Offset: 0x00015128
		[global::Cpp2ILInjected.Token(Token = "0x6000FE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B894", Offset = "0x1C8B894", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void BoundCheck(int idx, string s)
		{
			throw null;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00016F2B File Offset: 0x0001512B
		[global::Cpp2ILInjected.Token(Token = "0x6000FE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B6F4", Offset = "0x1C8B6F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeIdentifiers), Member = "FromDisplay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TypeIdentifier))]
		private static global::System.TypeIdentifier ParsedTypeIdentifier(string displayName)
		{
			throw null;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00016F2E File Offset: 0x0001512E
		[global::Cpp2ILInjected.Token(Token = "0x6000FE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8A164", Offset = "0x1C8A164", Length = "0xB0C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "SkipSpace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "AddName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "AddModifier", MemberParameters = new object[] { typeof(global::System.ModifierSpec) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "BoundCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		private static global::System.TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn)
		{
			throw null;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00016F31 File Offset: 0x00015131
		[global::Cpp2ILInjected.Token(Token = "0x6000FE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8B910", Offset = "0x1C8B910", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TypeSpec()
		{
			throw null;
		}

		// Token: 0x040006AE RID: 1710
		[global::Cpp2ILInjected.Token(Token = "0x4000885")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.TypeIdentifier name;

		// Token: 0x040006AF RID: 1711
		[global::Cpp2ILInjected.Token(Token = "0x4000886")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string assembly_name;

		// Token: 0x040006B0 RID: 1712
		[global::Cpp2ILInjected.Token(Token = "0x4000887")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.Generic.List<global::System.TypeIdentifier> nested;

		// Token: 0x040006B1 RID: 1713
		[global::Cpp2ILInjected.Token(Token = "0x4000888")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Collections.Generic.List<global::System.TypeSpec> generic_params;

		// Token: 0x040006B2 RID: 1714
		[global::Cpp2ILInjected.Token(Token = "0x4000889")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Collections.Generic.List<global::System.ModifierSpec> modifier_spec;

		// Token: 0x040006B3 RID: 1715
		[global::Cpp2ILInjected.Token(Token = "0x400088A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool is_byref;

		// Token: 0x040006B4 RID: 1716
		[global::Cpp2ILInjected.Token(Token = "0x400088B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string display_fullname;

		// Token: 0x0200059E RID: 1438
		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200019F")]
		internal enum DisplayNameFormat
		{
			// Token: 0x0400187F RID: 6271
			[global::Cpp2ILInjected.Token(Token = "0x400088D")]
			Default = 0,
			// Token: 0x04001880 RID: 6272
			[global::Cpp2ILInjected.Token(Token = "0x400088E")]
			WANT_ASSEMBLY = 1,
			// Token: 0x04001881 RID: 6273
			[global::Cpp2ILInjected.Token(Token = "0x400088F")]
			NO_MODIFIERS = 2
		}
	}
}
