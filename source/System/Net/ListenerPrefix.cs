using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001A4 RID: 420
	[global::Cpp2ILInjected.Token(Token = "0x2000262")]
	internal sealed class ListenerPrefix
	{
		// Token: 0x06000ED1 RID: 3793 RVA: 0x000058A6 File Offset: 0x00003AA6
		[global::Cpp2ILInjected.Token(Token = "0x600106D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0180C", Offset = "0x1E0180C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListenerPrefix(string prefix)
		{
			throw null;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000058A9 File Offset: 0x00003AA9
		[global::Cpp2ILInjected.Token(Token = "0x600106E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01ADC", Offset = "0x1E01ADC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x000058AC File Offset: 0x00003AAC
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x000058AF File Offset: 0x00003AAF
		[global::Cpp2ILInjected.Token(Token = "0x170003AC")]
		public IPAddress[] Addresses
		{
			[global::Cpp2ILInjected.Token(Token = "0x600106F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01AE4", Offset = "0x1E01AE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001070")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01AEC", Offset = "0x1E01AEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000058B2 File Offset: 0x00003AB2
		[global::Cpp2ILInjected.Token(Token = "0x170003AD")]
		public bool Secure
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001071")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01AF4", Offset = "0x1E01AF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000058B5 File Offset: 0x00003AB5
		[global::Cpp2ILInjected.Token(Token = "0x170003AE")]
		public string Host
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001072")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01AFC", Offset = "0x1E01AFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x000058B8 File Offset: 0x00003AB8
		[global::Cpp2ILInjected.Token(Token = "0x170003AF")]
		public int Port
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001073")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01B04", Offset = "0x1E01B04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x000058BB File Offset: 0x00003ABB
		[global::Cpp2ILInjected.Token(Token = "0x170003B0")]
		public string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001074")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E01B0C", Offset = "0x1E01B0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x000058BE File Offset: 0x00003ABE
		[global::Cpp2ILInjected.Token(Token = "0x6001075")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01B14", Offset = "0x1E01B14", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000058C1 File Offset: 0x00003AC1
		[global::Cpp2ILInjected.Token(Token = "0x6001076")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01B88", Offset = "0x1E01B88", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000058C4 File Offset: 0x00003AC4
		[global::Cpp2ILInjected.Token(Token = "0x6001077")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0183C", Offset = "0x1E0183C", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void Parse(string uri)
		{
			throw null;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x000058C7 File Offset: 0x00003AC7
		[global::Cpp2ILInjected.Token(Token = "0x6001078")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01B98", Offset = "0x1E01B98", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public static void CheckUri(string uri)
		{
			throw null;
		}

		// Token: 0x04000A04 RID: 2564
		[global::Cpp2ILInjected.Token(Token = "0x4000CEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string original;

		// Token: 0x04000A05 RID: 2565
		[global::Cpp2ILInjected.Token(Token = "0x4000CEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string host;

		// Token: 0x04000A06 RID: 2566
		[global::Cpp2ILInjected.Token(Token = "0x4000CF0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ushort port;

		// Token: 0x04000A07 RID: 2567
		[global::Cpp2ILInjected.Token(Token = "0x4000CF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string path;

		// Token: 0x04000A08 RID: 2568
		[global::Cpp2ILInjected.Token(Token = "0x4000CF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool secure;

		// Token: 0x04000A09 RID: 2569
		[global::Cpp2ILInjected.Token(Token = "0x4000CF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private IPAddress[] addresses;

		// Token: 0x04000A0A RID: 2570
		[global::Cpp2ILInjected.Token(Token = "0x4000CF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public HttpListener Listener;
	}
}
