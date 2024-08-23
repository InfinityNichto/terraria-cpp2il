using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.X509.Extensions;

namespace Mono.Security.X509
{
	// Token: 0x02000013 RID: 19
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	public class X509Extension
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00003216 File Offset: 0x00001416
		[global::Cpp2ILInjected.Token(Token = "0x600012C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91F5C", Offset = "0x1A91F5C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected X509Extension()
		{
			throw null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003219 File Offset: 0x00001419
		[global::Cpp2ILInjected.Token(Token = "0x600012D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91F78", Offset = "0x1A91F78", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ExtensionCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "set_Value", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public X509Extension(ASN1 asn1)
		{
			throw null;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000321C File Offset: 0x0000141C
		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A921D4", Offset = "0x1A921D4", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(X509Certificate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(X509ExtensionCollection),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthorityKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicConstraintsExtension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyUsageExtension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public X509Extension(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000321F File Offset: 0x0000141F
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92338", Offset = "0x1A92338", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Decode()
		{
			throw null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003222 File Offset: 0x00001422
		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9233C", Offset = "0x1A9233C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Encode()
		{
			throw null;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00003225 File Offset: 0x00001425
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public ASN1 ASN1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000131")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A92340", Offset = "0x1A92340", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Extension), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ExtensionCollection), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00003228 File Offset: 0x00001428
		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public string Oid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000132")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A92440", Offset = "0x1A92440", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000322B File Offset: 0x0000142B
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000322E File Offset: 0x0000142E
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public bool Critical
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000133")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A92448", Offset = "0x1A92448", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000134")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A92450", Offset = "0x1A92450", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00003231 File Offset: 0x00001431
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000135")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9245C", Offset = "0x1A9245C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00003234 File Offset: 0x00001434
		[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
		public ASN1 Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000136")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9230C", Offset = "0x1A9230C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003237 File Offset: 0x00001437
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92464", Offset = "0x1A92464", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000323A File Offset: 0x0000143A
		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A925A4", Offset = "0x1A925A4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = "get_ASN1", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000323D File Offset: 0x0000143D
		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A925BC", Offset = "0x1A925BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003240 File Offset: 0x00001440
		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A925CC", Offset = "0x1A925CC", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Extension), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void WriteLine(StringBuilder sb, int n, int pos)
		{
			throw null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003243 File Offset: 0x00001443
		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A927C8", Offset = "0x1A927C8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = "WriteLine", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000077 RID: 119
		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected string extnOid;

		// Token: 0x04000078 RID: 120
		[global::Cpp2ILInjected.Token(Token = "0x400009C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected bool extnCritical;

		// Token: 0x04000079 RID: 121
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected ASN1 extnValue;
	}
}
