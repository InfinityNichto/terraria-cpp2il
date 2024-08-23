using System;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace Mono.Security
{
	// Token: 0x0200002A RID: 42
	[global::System.Reflection.DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x2000040")]
	internal class ASN1
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00014816 File Offset: 0x00012A16
		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5C34", Offset = "0x1AB5C34", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Encode_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ASN1(byte tag)
		{
			throw null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00014819 File Offset: 0x00012A19
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5C60", Offset = "0x1AB5C60", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Encode_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ASN1(byte tag, byte[] data)
		{
			throw null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001481C File Offset: 0x00012A1C
		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5C90", Offset = "0x1AB5C90", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Encode_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public ASN1(byte[] data)
		{
			throw null;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0001481F File Offset: 0x00012A1F
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600010A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB5EF4", Offset = "0x1AB5EF4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00014822 File Offset: 0x00012A22
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public byte[] Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600010B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB5F10", Offset = "0x1AB5F10", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASN1), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00014825 File Offset: 0x00012A25
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5F98", Offset = "0x1AB5F98", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASN1), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Encode_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ASN1 Add(ASN1 asn1)
		{
			throw null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00014828 File Offset: 0x00012A28
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB601C", Offset = "0x1AB601C", Length = "0x5C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public virtual byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001482B File Offset: 0x00012A2B
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5DD8", Offset = "0x1AB5DD8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASN1), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "DecodeTLV", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(ref byte),
			typeof(ref int),
			typeof(ref byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void Decode(byte[] asn1, ref int anPos, int anLength)
		{
			throw null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0001482E File Offset: 0x00012A2E
		[global::Cpp2ILInjected.Token(Token = "0x600010F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB65E4", Offset = "0x1AB65E4", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASN1), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content)
		{
			throw null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00014831 File Offset: 0x00012A31
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB66D8", Offset = "0x1AB66D8", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400008E RID: 142
		[global::Cpp2ILInjected.Token(Token = "0x400013B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte m_nTag;

		// Token: 0x0400008F RID: 143
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] m_aValue;

		// Token: 0x04000090 RID: 144
		[global::Cpp2ILInjected.Token(Token = "0x400013D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.ArrayList elist;
	}
}
