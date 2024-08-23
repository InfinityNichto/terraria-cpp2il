using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000277 RID: 631
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x200036D")]
	public class PropertyTabAttribute : Attribute
	{
		// Token: 0x06001493 RID: 5267 RVA: 0x000068EA File Offset: 0x00004AEA
		[global::Cpp2ILInjected.Token(Token = "0x60016DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49430", Offset = "0x1E49430", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public PropertyTabAttribute()
		{
			throw null;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x000068ED File Offset: 0x00004AED
		[global::Cpp2ILInjected.Token(Token = "0x60016DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49518", Offset = "0x1E49518", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PropertyTabAttribute(Type tabClass)
		{
			throw null;
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x000068F0 File Offset: 0x00004AF0
		[global::Cpp2ILInjected.Token(Token = "0x60016DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49664", Offset = "0x1E49664", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PropertyTabAttribute(string tabClassName)
		{
			throw null;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x000068F3 File Offset: 0x00004AF3
		[global::Cpp2ILInjected.Token(Token = "0x60016DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49520", Offset = "0x1E49520", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
		{
			throw null;
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000068F6 File Offset: 0x00004AF6
		[global::Cpp2ILInjected.Token(Token = "0x60016DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4966C", Offset = "0x1E4966C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
		{
			throw null;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x000068F9 File Offset: 0x00004AF9
		[global::Cpp2ILInjected.Token(Token = "0x1700052F")]
		public Type[] TabClasses
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E497B0", Offset = "0x1E497B0", Length = "0x280")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyTabAttribute), Member = "Equals", MemberParameters = new object[] { typeof(PropertyTabAttribute) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Assembly))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Assembly),
				typeof(Assembly)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x000068FC File Offset: 0x00004AFC
		[global::Cpp2ILInjected.Token(Token = "0x17000530")]
		protected string[] TabClassNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E49A30", Offset = "0x1E49A30", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x000068FF File Offset: 0x00004AFF
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x00006902 File Offset: 0x00004B02
		[global::Cpp2ILInjected.Token(Token = "0x17000531")]
		public PropertyTabScope[] TabScopes
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E49AA4", Offset = "0x1E49AA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E49AAC", Offset = "0x1E49AAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00006905 File Offset: 0x00004B05
		[global::Cpp2ILInjected.Token(Token = "0x60016E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49AB4", Offset = "0x1E49AB4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00006908 File Offset: 0x00004B08
		[global::Cpp2ILInjected.Token(Token = "0x60016E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49B40", Offset = "0x1E49B40", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyTabAttribute), Member = "get_TabClasses", ReturnType = typeof(Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(PropertyTabAttribute other)
		{
			throw null;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0000690B File Offset: 0x00004B0B
		[global::Cpp2ILInjected.Token(Token = "0x60016E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49C7C", Offset = "0x1E49C7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0000690E File Offset: 0x00004B0E
		[global::Cpp2ILInjected.Token(Token = "0x60016E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49C84", Offset = "0x1E49C84", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
		{
			throw null;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00006911 File Offset: 0x00004B11
		[global::Cpp2ILInjected.Token(Token = "0x60016E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49F10", Offset = "0x1E49F10", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyTabAttribute), Member = "InitializeArrays", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(Type[]),
			typeof(PropertyTabScope[])
		}, ReturnType = typeof(void))]
		protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
			throw null;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00006914 File Offset: 0x00004B14
		[global::Cpp2ILInjected.Token(Token = "0x60016E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49C90", Offset = "0x1E49C90", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyTabAttribute), Member = "InitializeArrays", MemberParameters = new object[]
		{
			typeof(Type[]),
			typeof(PropertyTabScope[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
			throw null;
		}

		// Token: 0x04000E03 RID: 3587
		[global::Cpp2ILInjected.Token(Token = "0x4001208")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Type[] _tabClasses;

		// Token: 0x04000E04 RID: 3588
		[global::Cpp2ILInjected.Token(Token = "0x4001209")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string[] _tabClassNames;

		// Token: 0x04000E05 RID: 3589
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400120A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private PropertyTabScope[] <TabScopes>k__BackingField;
	}
}
