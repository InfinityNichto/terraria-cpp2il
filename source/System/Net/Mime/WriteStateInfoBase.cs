using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Mime
{
	// Token: 0x02000236 RID: 566
	[global::Cpp2ILInjected.Token(Token = "0x2000327")]
	internal class WriteStateInfoBase
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x00006398 File Offset: 0x00004598
		[global::Cpp2ILInjected.Token(Token = "0x60014EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38FC4", Offset = "0x1E38FC4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal WriteStateInfoBase()
		{
			throw null;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0000639B File Offset: 0x0000459B
		[global::Cpp2ILInjected.Token(Token = "0x170004C6")]
		internal int FooterLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390E4", Offset = "0x1E390E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0000639E File Offset: 0x0000459E
		[global::Cpp2ILInjected.Token(Token = "0x170004C7")]
		internal byte[] Footer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390F0", Offset = "0x1E390F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x000063A1 File Offset: 0x000045A1
		[global::Cpp2ILInjected.Token(Token = "0x170004C8")]
		internal byte[] Header
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390F8", Offset = "0x1E390F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x000063A4 File Offset: 0x000045A4
		[global::Cpp2ILInjected.Token(Token = "0x170004C9")]
		internal byte[] Buffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E39100", Offset = "0x1E39100", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000063A7 File Offset: 0x000045A7
		[global::Cpp2ILInjected.Token(Token = "0x170004CA")]
		internal int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E39108", Offset = "0x1E39108", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x000063AA File Offset: 0x000045AA
		[global::Cpp2ILInjected.Token(Token = "0x170004CB")]
		internal int CurrentLineLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E39110", Offset = "0x1E39110", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000063AD File Offset: 0x000045AD
		[global::Cpp2ILInjected.Token(Token = "0x60014F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39118", Offset = "0x1E39118", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "AppendCRLF", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureSpaceInBuffer(int moreBytes)
		{
			throw null;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000063B0 File Offset: 0x000045B0
		[global::Cpp2ILInjected.Token(Token = "0x60014F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E391B0", Offset = "0x1E391B0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "EnsureSpaceInBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		internal void Append(byte aByte)
		{
			throw null;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000063B3 File Offset: 0x000045B3
		[global::Cpp2ILInjected.Token(Token = "0x60014F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E391F8", Offset = "0x1E391F8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "AppendCRLF", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "AppendHeader", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "AppendFooter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "EnsureSpaceInBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void Append(params byte[] bytes)
		{
			throw null;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000063B6 File Offset: 0x000045B6
		[global::Cpp2ILInjected.Token(Token = "0x60014F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39244", Offset = "0x1E39244", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "EnsureSpaceInBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AppendCRLF(bool includeSpace)
		{
			throw null;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000063B9 File Offset: 0x000045B9
		[global::Cpp2ILInjected.Token(Token = "0x60014F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39334", Offset = "0x1E39334", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		internal void AppendHeader()
		{
			throw null;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000063BC File Offset: 0x000045BC
		[global::Cpp2ILInjected.Token(Token = "0x60014F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3931C", Offset = "0x1E3931C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		internal void AppendFooter()
		{
			throw null;
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000063BF File Offset: 0x000045BF
		[global::Cpp2ILInjected.Token(Token = "0x170004CC")]
		internal int MaxLineLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3934C", Offset = "0x1E3934C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000063C2 File Offset: 0x000045C2
		[global::Cpp2ILInjected.Token(Token = "0x60014F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39354", Offset = "0x1E39354", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "Write", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "CompleteWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "OnWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "FlushInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		internal void Reset()
		{
			throw null;
		}

		// Token: 0x04000D61 RID: 3425
		[global::Cpp2ILInjected.Token(Token = "0x400115E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected readonly byte[] _header;

		// Token: 0x04000D62 RID: 3426
		[global::Cpp2ILInjected.Token(Token = "0x400115F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected readonly byte[] _footer;

		// Token: 0x04000D63 RID: 3427
		[global::Cpp2ILInjected.Token(Token = "0x4001160")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected readonly int _maxLineLength;

		// Token: 0x04000D64 RID: 3428
		[global::Cpp2ILInjected.Token(Token = "0x4001161")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected byte[] _buffer;

		// Token: 0x04000D65 RID: 3429
		[global::Cpp2ILInjected.Token(Token = "0x4001162")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected int _currentLineLength;

		// Token: 0x04000D66 RID: 3430
		[global::Cpp2ILInjected.Token(Token = "0x4001163")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		protected int _currentBufferUsed;
	}
}
