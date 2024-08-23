using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002B4 RID: 692
	[global::Cpp2ILInjected.Token(Token = "0x20003B1")]
	public class ReferenceConverter : TypeConverter
	{
		// Token: 0x060016D8 RID: 5848 RVA: 0x00006E9C File Offset: 0x0000509C
		[global::Cpp2ILInjected.Token(Token = "0x6001937")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A4D4", Offset = "0x1E5A4D4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComponentConverter), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public ReferenceConverter(Type type)
		{
			throw null;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00006E9F File Offset: 0x0000509F
		[global::Cpp2ILInjected.Token(Token = "0x6001938")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A4FC", Offset = "0x1E5A4FC", Length = "0xCC")]
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

		// Token: 0x060016DA RID: 5850 RVA: 0x00006EA2 File Offset: 0x000050A2
		[global::Cpp2ILInjected.Token(Token = "0x6001939")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A5C8", Offset = "0x1E5A5C8", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00006EA5 File Offset: 0x000050A5
		[global::Cpp2ILInjected.Token(Token = "0x600193A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A90C", Offset = "0x1E5A90C", Length = "0x450")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "IsComObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00006EA8 File Offset: 0x000050A8
		[global::Cpp2ILInjected.Token(Token = "0x600193B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5AD5C", Offset = "0x1E5AD5C", Length = "0x78C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00006EAB File Offset: 0x000050AB
		[global::Cpp2ILInjected.Token(Token = "0x600193C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5B510", Offset = "0x1E5B510", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00006EAE File Offset: 0x000050AE
		[global::Cpp2ILInjected.Token(Token = "0x600193D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5B518", Offset = "0x1E5B518", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00006EB1 File Offset: 0x000050B1
		[global::Cpp2ILInjected.Token(Token = "0x600193E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5B520", Offset = "0x1E5B520", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value)
		{
			throw null;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00006EB4 File Offset: 0x000050B4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600193F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5B528", Offset = "0x1E5B528", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ReferenceConverter()
		{
			throw null;
		}

		// Token: 0x04000E9C RID: 3740
		[global::Cpp2ILInjected.Token(Token = "0x40012B9")]
		private static readonly string s_none;

		// Token: 0x04000E9D RID: 3741
		[global::Cpp2ILInjected.Token(Token = "0x40012BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Type _type;

		// Token: 0x0200045F RID: 1119
		[global::Cpp2ILInjected.Token(Token = "0x20003B2")]
		private class ReferenceComparer : IComparer
		{
			// Token: 0x06001EF5 RID: 7925 RVA: 0x0000855E File Offset: 0x0000675E
			[global::Cpp2ILInjected.Token(Token = "0x6001940")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5B4E8", Offset = "0x1E5B4E8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReferenceComparer(ReferenceConverter converter)
			{
				throw null;
			}

			// Token: 0x06001EF6 RID: 7926 RVA: 0x00008561 File Offset: 0x00006761
			[global::Cpp2ILInjected.Token(Token = "0x6001941")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5B588", Offset = "0x1E5B588", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(bool),
				typeof(CultureInfo)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public int Compare(object item1, object item2)
			{
				throw null;
			}

			// Token: 0x040013A1 RID: 5025
			[global::Cpp2ILInjected.Token(Token = "0x40012BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ReferenceConverter _converter;
		}
	}
}
