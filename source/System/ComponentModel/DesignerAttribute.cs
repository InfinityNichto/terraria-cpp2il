using System;
using System.Diagnostics;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002DF RID: 735
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[Conditional("FALSE")]
	[global::Cpp2ILInjected.Token(Token = "0x20003DF")]
	public sealed class DesignerAttribute : Attribute
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x0000710C File Offset: 0x0000530C
		[global::Cpp2ILInjected.Token(Token = "0x6001A2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E64FE0", Offset = "0x1E64FE0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public DesignerAttribute(string designerTypeName)
		{
			throw null;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0000710F File Offset: 0x0000530F
		[global::Cpp2ILInjected.Token(Token = "0x6001A30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E650C0", Offset = "0x1E650C0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DesignerAttribute(Type designerType)
		{
			throw null;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00007112 File Offset: 0x00005312
		[global::Cpp2ILInjected.Token(Token = "0x6001A31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E65178", Offset = "0x1E65178", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DesignerAttribute(string designerTypeName, string designerBaseTypeName)
		{
			throw null;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00007115 File Offset: 0x00005315
		[global::Cpp2ILInjected.Token(Token = "0x6001A32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E65200", Offset = "0x1E65200", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DesignerAttribute(string designerTypeName, Type designerBaseType)
		{
			throw null;
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00007118 File Offset: 0x00005318
		[global::Cpp2ILInjected.Token(Token = "0x6001A33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E652A0", Offset = "0x1E652A0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignerAttribute(Type designerType, Type designerBaseType)
		{
			throw null;
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0000711B File Offset: 0x0000531B
		[global::Cpp2ILInjected.Token(Token = "0x17000602")]
		public string DesignerBaseTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E652F8", Offset = "0x1E652F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0000711E File Offset: 0x0000531E
		[global::Cpp2ILInjected.Token(Token = "0x17000603")]
		public string DesignerTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A35")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E65300", Offset = "0x1E65300", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00007121 File Offset: 0x00005321
		[global::Cpp2ILInjected.Token(Token = "0x17000604")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A36")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E65308", Offset = "0x1E65308", Length = "0x80")]
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

		// Token: 0x060017CE RID: 6094 RVA: 0x00007124 File Offset: 0x00005324
		[global::Cpp2ILInjected.Token(Token = "0x6001A37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E65388", Offset = "0x1E65388", Length = "0x9C")]
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

		// Token: 0x060017CF RID: 6095 RVA: 0x00007127 File Offset: 0x00005327
		[global::Cpp2ILInjected.Token(Token = "0x6001A38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E65424", Offset = "0x1E65424", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000EE3 RID: 3811
		[global::Cpp2ILInjected.Token(Token = "0x4001304")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string designerTypeName;

		// Token: 0x04000EE4 RID: 3812
		[global::Cpp2ILInjected.Token(Token = "0x4001305")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string designerBaseTypeName;

		// Token: 0x04000EE5 RID: 3813
		[global::Cpp2ILInjected.Token(Token = "0x4001306")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string typeId;
	}
}
