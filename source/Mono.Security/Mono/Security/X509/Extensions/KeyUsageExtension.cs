using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x0200001C RID: 28
	[global::Cpp2ILInjected.Token(Token = "0x2000037")]
	public class KeyUsageExtension : X509Extension
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0000332A File Offset: 0x0000152A
		[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96F84", Offset = "0x1A96F84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		public KeyUsageExtension(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000332D File Offset: 0x0000152D
		[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96F88", Offset = "0x1A96F88", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Decode()
		{
			throw null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003330 File Offset: 0x00001530
		[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A970A8", Offset = "0x1A970A8", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Encode()
		{
			throw null;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00003333 File Offset: 0x00001533
		[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A971E8", Offset = "0x1A971E8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003336 File Offset: 0x00001536
		[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A97228", Offset = "0x1A97228", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyUsageExtension), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool Support(KeyUsages usage)
		{
			throw null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00003339 File Offset: 0x00001539
		[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A97308", Offset = "0x1A97308", Length = "0x440")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyUsageExtension), Member = "Support", MemberParameters = new object[] { typeof(KeyUsages) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int kubits;
	}
}
