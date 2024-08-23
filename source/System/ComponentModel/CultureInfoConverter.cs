using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000269 RID: 617
	[global::Cpp2ILInjected.Token(Token = "0x200035D")]
	public class CultureInfoConverter : TypeConverter
	{
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000067CA File Offset: 0x000049CA
		[global::Cpp2ILInjected.Token(Token = "0x17000520")]
		private string DefaultCultureString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001675")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E41A2C", Offset = "0x1E41A2C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000067CD File Offset: 0x000049CD
		[global::Cpp2ILInjected.Token(Token = "0x6001676")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E41A6C", Offset = "0x1E41A6C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual string GetCultureName(CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x000067D0 File Offset: 0x000049D0
		[global::Cpp2ILInjected.Token(Token = "0x6001677")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E41A7C", Offset = "0x1E41A7C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			throw null;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000067D3 File Offset: 0x000049D3
		[global::Cpp2ILInjected.Token(Token = "0x6001678")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E41B44", Offset = "0x1E41B44", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000067D6 File Offset: 0x000049D6
		[global::Cpp2ILInjected.Token(Token = "0x6001679")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E41C0C", Offset = "0x1E41C0C", Length = "0x8CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfoConverter.CultureInfoMapper), Member = "GetCultureInfoName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x000067D9 File Offset: 0x000049D9
		[global::Cpp2ILInjected.Token(Token = "0x600167A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E42570", Offset = "0x1E42570", Length = "0x438")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InstanceDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(ICollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x000067DC File Offset: 0x000049DC
		[global::Cpp2ILInjected.Token(Token = "0x600167B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E429A8", Offset = "0x1E429A8", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultures", MemberParameters = new object[] { typeof(CultureTypes) }, ReturnType = typeof(CultureInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x000067DF File Offset: 0x000049DF
		[global::Cpp2ILInjected.Token(Token = "0x600167C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E42B88", Offset = "0x1E42B88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000067E2 File Offset: 0x000049E2
		[global::Cpp2ILInjected.Token(Token = "0x600167D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E42B90", Offset = "0x1E42B90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000067E5 File Offset: 0x000049E5
		[global::Cpp2ILInjected.Token(Token = "0x600167E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E42B98", Offset = "0x1E42B98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public CultureInfoConverter()
		{
			throw null;
		}

		// Token: 0x04000DE0 RID: 3552
		[global::Cpp2ILInjected.Token(Token = "0x40011E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TypeConverter.StandardValuesCollection _values;

		// Token: 0x04000DE1 RID: 3553
		[global::Cpp2ILInjected.Token(Token = "0x40011E4")]
		private const string DefaultInvariantCultureString = "(Default)";

		// Token: 0x02000456 RID: 1110
		[global::Cpp2ILInjected.Token(Token = "0x200035E")]
		private class CultureComparer : IComparer
		{
			// Token: 0x06001ED8 RID: 7896 RVA: 0x00008507 File Offset: 0x00006707
			[global::Cpp2ILInjected.Token(Token = "0x600167F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E42B60", Offset = "0x1E42B60", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CultureComparer(CultureInfoConverter cultureConverter)
			{
				throw null;
			}

			// Token: 0x06001ED9 RID: 7897 RVA: 0x0000850A File Offset: 0x0000670A
			[global::Cpp2ILInjected.Token(Token = "0x6001680")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E42BA0", Offset = "0x1E42BA0", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public int Compare(object item1, object item2)
			{
				throw null;
			}

			// Token: 0x04001387 RID: 4999
			[global::Cpp2ILInjected.Token(Token = "0x40011E5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private CultureInfoConverter _converter;
		}

		// Token: 0x02000457 RID: 1111
		[global::Cpp2ILInjected.Token(Token = "0x200035F")]
		private static class CultureInfoMapper
		{
			// Token: 0x06001EDA RID: 7898 RVA: 0x0000850D File Offset: 0x0000670D
			[global::Cpp2ILInjected.Token(Token = "0x6001681")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E42CF4", Offset = "0x1E42CF4", Length = "0x40D8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter.CultureInfoMapper), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 552)]
			private static Dictionary<string, string> CreateMap()
			{
				throw null;
			}

			// Token: 0x06001EDB RID: 7899 RVA: 0x00008510 File Offset: 0x00006710
			[global::Cpp2ILInjected.Token(Token = "0x6001682")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E424D8", Offset = "0x1E424D8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertFrom", MemberParameters = new object[]
			{
				typeof(ITypeDescriptorContext),
				typeof(CultureInfo),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static string GetCultureInfoName(string cultureInfoDisplayName)
			{
				throw null;
			}

			// Token: 0x06001EDC RID: 7900 RVA: 0x00008513 File Offset: 0x00006713
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001683")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E46DCC", Offset = "0x1E46DCC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfoConverter.CultureInfoMapper), Member = "CreateMap", ReturnType = typeof(Dictionary<string, string>))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			static CultureInfoMapper()
			{
				throw null;
			}

			// Token: 0x04001388 RID: 5000
			[global::Cpp2ILInjected.Token(Token = "0x40011E6")]
			private static readonly Dictionary<string, string> s_cultureInfoNameMap;
		}
	}
}
