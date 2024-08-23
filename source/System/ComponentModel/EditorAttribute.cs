using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200027C RID: 636
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000372")]
	public sealed class EditorAttribute : Attribute
	{
		// Token: 0x060014B8 RID: 5304 RVA: 0x00006959 File Offset: 0x00004B59
		[global::Cpp2ILInjected.Token(Token = "0x60016FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A904", Offset = "0x1E4A904", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public EditorAttribute()
		{
			throw null;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0000695C File Offset: 0x00004B5C
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

		// Token: 0x060014BA RID: 5306 RVA: 0x0000695F File Offset: 0x00004B5F
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

		// Token: 0x060014BB RID: 5307 RVA: 0x00006962 File Offset: 0x00004B62
		[global::Cpp2ILInjected.Token(Token = "0x6001702")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AA88", Offset = "0x1E4AA88", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EditorAttribute(Type type, Type baseType)
		{
			throw null;
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x00006965 File Offset: 0x00004B65
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

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x00006968 File Offset: 0x00004B68
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x0000696B File Offset: 0x00004B6B
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

		// Token: 0x060014BF RID: 5311 RVA: 0x0000696E File Offset: 0x00004B6E
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

		// Token: 0x060014C0 RID: 5312 RVA: 0x00006971 File Offset: 0x00004B71
		[global::Cpp2ILInjected.Token(Token = "0x6001707")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC0C", Offset = "0x1E4AC0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000E13 RID: 3603
		[global::Cpp2ILInjected.Token(Token = "0x4001218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _typeId;

		// Token: 0x04000E14 RID: 3604
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001219")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <EditorBaseTypeName>k__BackingField;

		// Token: 0x04000E15 RID: 3605
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400121A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string <EditorTypeName>k__BackingField;
	}
}
