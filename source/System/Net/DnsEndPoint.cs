using System;
using System.Net.Sockets;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000108 RID: 264
	[global::Cpp2ILInjected.Token(Token = "0x200018D")]
	public class DnsEndPoint : EndPoint
	{
		// Token: 0x0600092A RID: 2346 RVA: 0x00004841 File Offset: 0x00002A41
		[global::Cpp2ILInjected.Token(Token = "0x6000A39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0BCE4", Offset = "0x1F0BCE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public DnsEndPoint(string host, int port)
		{
			throw null;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00004844 File Offset: 0x00002A44
		[global::Cpp2ILInjected.Token(Token = "0x6000A3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0BCEC", Offset = "0x1F0BCEC", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public DnsEndPoint(string host, int port, AddressFamily addressFamily)
		{
			throw null;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00004847 File Offset: 0x00002A47
		[global::Cpp2ILInjected.Token(Token = "0x6000A3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0BECC", Offset = "0x1F0BECC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0000484A File Offset: 0x00002A4A
		[global::Cpp2ILInjected.Token(Token = "0x6000A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0BF80", Offset = "0x1F0BF80", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0000484D File Offset: 0x00002A4D
		[global::Cpp2ILInjected.Token(Token = "0x6000A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C02C", Offset = "0x1F0C02C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00004850 File Offset: 0x00002A50
		[global::Cpp2ILInjected.Token(Token = "0x17000210")]
		public string Host
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C1AC", Offset = "0x1F0C1AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00004853 File Offset: 0x00002A53
		[global::Cpp2ILInjected.Token(Token = "0x17000211")]
		public override AddressFamily AddressFamily
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C1B4", Offset = "0x1F0C1B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00004856 File Offset: 0x00002A56
		[global::Cpp2ILInjected.Token(Token = "0x17000212")]
		public int Port
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C1BC", Offset = "0x1F0C1BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040005B7 RID: 1463
		[global::Cpp2ILInjected.Token(Token = "0x40007C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_Host;

		// Token: 0x040005B8 RID: 1464
		[global::Cpp2ILInjected.Token(Token = "0x40007CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_Port;

		// Token: 0x040005B9 RID: 1465
		[global::Cpp2ILInjected.Token(Token = "0x40007CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private AddressFamily m_Family;
	}
}
