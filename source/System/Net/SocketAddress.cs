using System;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200013D RID: 317
	[global::Cpp2ILInjected.Token(Token = "0x20001C4")]
	public class SocketAddress
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000049C4 File Offset: 0x00002BC4
		[global::Cpp2ILInjected.Token(Token = "0x1700022F")]
		public AddressFamily Family
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10B98", Offset = "0x1F10B98", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPEndPoint), Member = "Create", MemberParameters = new object[] { typeof(SocketAddress) }, ReturnType = typeof(EndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x000049C7 File Offset: 0x00002BC7
		[global::Cpp2ILInjected.Token(Token = "0x17000230")]
		public int Size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10BAC", Offset = "0x1F10BAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000226 RID: 550
		[global::Cpp2ILInjected.Token(Token = "0x17000231")]
		public byte this[int offset]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10BB4", Offset = "0x1F10BB4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10C10", Offset = "0x1F10C10", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000049D0 File Offset: 0x00002BD0
		[global::Cpp2ILInjected.Token(Token = "0x6000AD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10C80", Offset = "0x1F10C80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SocketAddress(AddressFamily family)
		{
			throw null;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000049D3 File Offset: 0x00002BD3
		[global::Cpp2ILInjected.Token(Token = "0x6000AD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10C88", Offset = "0x1F10C88", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "get_Size", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public SocketAddress(AddressFamily family, int size)
		{
			throw null;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000049D6 File Offset: 0x00002BD6
		[global::Cpp2ILInjected.Token(Token = "0x6000AD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10D80", Offset = "0x1F10D80", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_ScopeId", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "GetAddressBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "TryWriteBytes", MemberParameters = new object[]
		{
			typeof(Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal SocketAddress(IPAddress ipAddress)
		{
			throw null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000049D9 File Offset: 0x00002BD9
		[global::Cpp2ILInjected.Token(Token = "0x6000AD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10F38", Offset = "0x1F10F38", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPEndPoint), Member = "Serialize", ReturnType = typeof(SocketAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
		internal SocketAddress(IPAddress ipaddress, int port)
		{
			throw null;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000049DC File Offset: 0x00002BDC
		[global::Cpp2ILInjected.Token(Token = "0x6000ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10F6C", Offset = "0x1F10F6C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = "GetIPEndPoint", ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal IPAddress GetIPAddress()
		{
			throw null;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000049DF File Offset: 0x00002BDF
		[global::Cpp2ILInjected.Token(Token = "0x6000ADB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F110FC", Offset = "0x1F110FC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPEndPoint), Member = "Create", MemberParameters = new object[] { typeof(SocketAddress) }, ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal IPEndPoint GetIPEndPoint()
		{
			throw null;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000049E2 File Offset: 0x00002BE2
		[global::Cpp2ILInjected.Token(Token = "0x6000ADC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11178", Offset = "0x1F11178", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "get_Size", ReturnType = typeof(int))]
		internal void CopyAddressSizeIntoBuffer()
		{
			throw null;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000049E5 File Offset: 0x00002BE5
		[global::Cpp2ILInjected.Token(Token = "0x6000ADD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11220", Offset = "0x1F11220", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "get_Size", ReturnType = typeof(int))]
		internal int GetAddressSizeOffset()
		{
			throw null;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000049E8 File Offset: 0x00002BE8
		[global::Cpp2ILInjected.Token(Token = "0x6000ADE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11240", Offset = "0x1F11240", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		internal unsafe void SetSize(IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000049EB File Offset: 0x00002BEB
		[global::Cpp2ILInjected.Token(Token = "0x6000ADF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11264", Offset = "0x1F11264", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAddress), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000049EE File Offset: 0x00002BEE
		[global::Cpp2ILInjected.Token(Token = "0x6000AE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11348", Offset = "0x1F11348", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000049F1 File Offset: 0x00002BF1
		[global::Cpp2ILInjected.Token(Token = "0x6000AE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11400", Offset = "0x1F11400", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAddress), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400076D RID: 1901
		[global::Cpp2ILInjected.Token(Token = "0x4000986")]
		internal const int IPv6AddressSize = 28;

		// Token: 0x0400076E RID: 1902
		[global::Cpp2ILInjected.Token(Token = "0x4000987")]
		internal const int IPv4AddressSize = 16;

		// Token: 0x0400076F RID: 1903
		[global::Cpp2ILInjected.Token(Token = "0x4000988")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_Size;

		// Token: 0x04000770 RID: 1904
		[global::Cpp2ILInjected.Token(Token = "0x4000989")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal byte[] m_Buffer;

		// Token: 0x04000771 RID: 1905
		[global::Cpp2ILInjected.Token(Token = "0x400098A")]
		private const int WriteableOffset = 2;

		// Token: 0x04000772 RID: 1906
		[global::Cpp2ILInjected.Token(Token = "0x400098B")]
		private const int MaxSize = 32;

		// Token: 0x04000773 RID: 1907
		[global::Cpp2ILInjected.Token(Token = "0x400098C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_changed;

		// Token: 0x04000774 RID: 1908
		[global::Cpp2ILInjected.Token(Token = "0x400098D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_hash;
	}
}
