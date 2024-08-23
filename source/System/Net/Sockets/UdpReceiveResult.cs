using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x02000219 RID: 537
	[global::Cpp2ILInjected.Token(Token = "0x2000308")]
	public struct UdpReceiveResult : IEquatable<UdpReceiveResult>
	{
		// Token: 0x06001202 RID: 4610 RVA: 0x000061B2 File Offset: 0x000043B2
		[global::Cpp2ILInjected.Token(Token = "0x600143B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34C88", Offset = "0x1E34C88", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "<ReceiveAsync>b__65_1", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(UdpReceiveResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public UdpReceiveResult(byte[] buffer, IPEndPoint remoteEndPoint)
		{
			throw null;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000061B5 File Offset: 0x000043B5
		[global::Cpp2ILInjected.Token(Token = "0x17000492")]
		public byte[] Buffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600143C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E34D08", Offset = "0x1E34D08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000061B8 File Offset: 0x000043B8
		[global::Cpp2ILInjected.Token(Token = "0x17000493")]
		public IPEndPoint RemoteEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x600143D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E34D10", Offset = "0x1E34D10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000061BB File Offset: 0x000043BB
		[global::Cpp2ILInjected.Token(Token = "0x600143E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34D18", Offset = "0x1E34D18", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000061BE File Offset: 0x000043BE
		[global::Cpp2ILInjected.Token(Token = "0x600143F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34D58", Offset = "0x1E34D58", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000061C1 File Offset: 0x000043C1
		[global::Cpp2ILInjected.Token(Token = "0x6001440")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34DD0", Offset = "0x1E34DD0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		public bool Equals(UdpReceiveResult other)
		{
			throw null;
		}

		// Token: 0x04000CE6 RID: 3302
		[global::Cpp2ILInjected.Token(Token = "0x40010DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private byte[] m_buffer;

		// Token: 0x04000CE7 RID: 3303
		[global::Cpp2ILInjected.Token(Token = "0x40010E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private IPEndPoint m_remoteEndPoint;
	}
}
