using System;
using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000270 RID: 624
	[global::Cpp2ILInjected.Token(Token = "0x2000366")]
	public class DecimalConverter : BaseNumberConverter
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00006869 File Offset: 0x00004A69
		[global::Cpp2ILInjected.Token(Token = "0x17000528")]
		internal override bool AllowHex
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E48538", Offset = "0x1E48538", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0000686C File Offset: 0x00004A6C
		[global::Cpp2ILInjected.Token(Token = "0x17000529")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E48540", Offset = "0x1E48540", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0000686F File Offset: 0x00004A6F
		[global::Cpp2ILInjected.Token(Token = "0x60016B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E485AC", Offset = "0x1E485AC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			throw null;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00006872 File Offset: 0x00004A72
		[global::Cpp2ILInjected.Token(Token = "0x60016B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48674", Offset = "0x1E48674", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "GetBits", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InstanceDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(ICollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00006875 File Offset: 0x00004A75
		[global::Cpp2ILInjected.Token(Token = "0x60016B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48974", Offset = "0x1E48974", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00006878 File Offset: 0x00004A78
		[global::Cpp2ILInjected.Token(Token = "0x60016B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48A60", Offset = "0x1E48A60", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0000687B File Offset: 0x00004A7B
		[global::Cpp2ILInjected.Token(Token = "0x60016B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48B0C", Offset = "0x1E48B0C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0000687E File Offset: 0x00004A7E
		[global::Cpp2ILInjected.Token(Token = "0x60016B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48BDC", Offset = "0x1E48BDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public DecimalConverter()
		{
			throw null;
		}
	}
}
