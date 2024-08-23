using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000260 RID: 608
	[global::Cpp2ILInjected.Token(Token = "0x2000354")]
	public class ByteConverter : BaseNumberConverter
	{
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x00006776 File Offset: 0x00004976
		[global::Cpp2ILInjected.Token(Token = "0x1700051A")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001651")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3FF88", Offset = "0x1E3FF88", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00006779 File Offset: 0x00004979
		[global::Cpp2ILInjected.Token(Token = "0x6001652")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3FFF4", Offset = "0x1E3FFF4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0000677C File Offset: 0x0000497C
		[global::Cpp2ILInjected.Token(Token = "0x6001653")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40088", Offset = "0x1E40088", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0000677F File Offset: 0x0000497F
		[global::Cpp2ILInjected.Token(Token = "0x6001654")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E400FC", Offset = "0x1E400FC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00006782 File Offset: 0x00004982
		[global::Cpp2ILInjected.Token(Token = "0x6001655")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E401A4", Offset = "0x1E401A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public ByteConverter()
		{
			throw null;
		}
	}
}
