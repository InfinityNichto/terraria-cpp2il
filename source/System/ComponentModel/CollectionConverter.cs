using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002D9 RID: 729
	[global::Cpp2ILInjected.Token(Token = "0x20003D8")]
	public class CollectionConverter : TypeConverter
	{
		// Token: 0x0600179B RID: 6043 RVA: 0x0000708B File Offset: 0x0000528B
		[global::Cpp2ILInjected.Token(Token = "0x60019FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E61AFC", Offset = "0x1E61AFC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0000708E File Offset: 0x0000528E
		[global::Cpp2ILInjected.Token(Token = "0x60019FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E61EA4", Offset = "0x1E61EA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00007091 File Offset: 0x00005291
		[global::Cpp2ILInjected.Token(Token = "0x60019FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E61EAC", Offset = "0x1E61EAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00007094 File Offset: 0x00005294
		[global::Cpp2ILInjected.Token(Token = "0x6001A00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E61EB4", Offset = "0x1E61EB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CollectionConverter()
		{
			throw null;
		}
	}
}
