using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002BC RID: 700
	[global::Cpp2ILInjected.Token(Token = "0x20003BA")]
	public class StringConverter : TypeConverter
	{
		// Token: 0x0600170B RID: 5899 RVA: 0x00006F29 File Offset: 0x00005129
		[global::Cpp2ILInjected.Token(Token = "0x600196C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DC68", Offset = "0x1E5DC68", Length = "0xC8")]
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

		// Token: 0x0600170C RID: 5900 RVA: 0x00006F2C File Offset: 0x0000512C
		[global::Cpp2ILInjected.Token(Token = "0x600196D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DD30", Offset = "0x1E5DD30", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00006F2F File Offset: 0x0000512F
		[global::Cpp2ILInjected.Token(Token = "0x600196E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DDD4", Offset = "0x1E5DDD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public StringConverter()
		{
			throw null;
		}
	}
}
