using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x0200001D RID: 29
	[global::Cpp2ILInjected.Token(Token = "0x2000038")]
	public class SubjectKeyIdentifierExtension : X509Extension
	{
		// Token: 0x06000154 RID: 340 RVA: 0x0000333C File Offset: 0x0000153C
		[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94C04", Offset = "0x1A94C04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		public SubjectKeyIdentifierExtension(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000333F File Offset: 0x0000153F
		[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A97748", Offset = "0x1A97748", Length = "0xD0")]
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

		// Token: 0x06000156 RID: 342 RVA: 0x00003342 File Offset: 0x00001542
		[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A97818", Offset = "0x1A97818", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void Encode()
		{
			throw null;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00003345 File Offset: 0x00001545
		[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A978F4", Offset = "0x1A978F4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00003348 File Offset: 0x00001548
		[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
		public byte[] Identifier
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A94C08", Offset = "0x1A94C08", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
			{
				typeof(X509ExtensionCollection),
				typeof(byte[])
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000334B File Offset: 0x0000154B
		[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A97934", Offset = "0x1A97934", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] ski;
	}
}
