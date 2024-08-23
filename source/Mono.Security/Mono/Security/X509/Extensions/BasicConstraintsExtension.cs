using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x0200001A RID: 26
	[global::Cpp2ILInjected.Token(Token = "0x2000035")]
	public class BasicConstraintsExtension : X509Extension
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00003318 File Offset: 0x00001518
		[global::Cpp2ILInjected.Token(Token = "0x600019E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91F58", Offset = "0x1A91F58", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		public BasicConstraintsExtension(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000331B File Offset: 0x0000151B
		[global::Cpp2ILInjected.Token(Token = "0x600019F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96B5C", Offset = "0x1A96B5C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Decode()
		{
			throw null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000331E File Offset: 0x0000151E
		[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96C8C", Offset = "0x1A96C8C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Encode()
		{
			throw null;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00003321 File Offset: 0x00001521
		[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
		public bool CertificateAuthority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96D9C", Offset = "0x1A96D9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00003324 File Offset: 0x00001524
		[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A96DA4", Offset = "0x1A96DA4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003327 File Offset: 0x00001527
		[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A96DE4", Offset = "0x1A96DE4", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000091 RID: 145
		[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool cA;

		// Token: 0x04000092 RID: 146
		[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int pathLenConstraint;
	}
}
