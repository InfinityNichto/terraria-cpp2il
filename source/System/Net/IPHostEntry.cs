using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000114 RID: 276
	[global::Cpp2ILInjected.Token(Token = "0x200019B")]
	public class IPHostEntry
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x000048B3 File Offset: 0x00002AB3
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x000048B6 File Offset: 0x00002AB6
		[global::Cpp2ILInjected.Token(Token = "0x17000218")]
		public string HostName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E25C", Offset = "0x1F0E25C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E264", Offset = "0x1F0E264", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x000048B9 File Offset: 0x00002AB9
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x000048BC File Offset: 0x00002ABC
		[global::Cpp2ILInjected.Token(Token = "0x17000219")]
		public string[] Aliases
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E26C", Offset = "0x1F0E26C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E274", Offset = "0x1F0E274", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x000048BF File Offset: 0x00002ABF
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x000048C2 File Offset: 0x00002AC2
		[global::Cpp2ILInjected.Token(Token = "0x1700021A")]
		public IPAddress[] AddressList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E27C", Offset = "0x1F0E27C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E284", Offset = "0x1F0E284", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000048C5 File Offset: 0x00002AC5
		[global::Cpp2ILInjected.Token(Token = "0x6000A6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E28C", Offset = "0x1F0E28C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public IPHostEntry()
		{
			throw null;
		}

		// Token: 0x04000635 RID: 1589
		[global::Cpp2ILInjected.Token(Token = "0x400084E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string hostName;

		// Token: 0x04000636 RID: 1590
		[global::Cpp2ILInjected.Token(Token = "0x400084F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string[] aliases;

		// Token: 0x04000637 RID: 1591
		[global::Cpp2ILInjected.Token(Token = "0x4000850")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IPAddress[] addressList;

		// Token: 0x04000638 RID: 1592
		[global::Cpp2ILInjected.Token(Token = "0x4000851")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal bool isTrustedHost;
	}
}
