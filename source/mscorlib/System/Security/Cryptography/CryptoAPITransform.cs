using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000271 RID: 625
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200030E")]
	public sealed class CryptoAPITransform : ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x00018977 File Offset: 0x00016B77
		[global::Cpp2ILInjected.Token(Token = "0x6001A6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12EEC", Offset = "0x1B12EEC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CryptoAPITransform()
		{
			throw null;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0001897A File Offset: 0x00016B7A
		[global::Cpp2ILInjected.Token(Token = "0x170002DD")]
		public bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F08", Offset = "0x1B12F08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x0001897D File Offset: 0x00016B7D
		[global::Cpp2ILInjected.Token(Token = "0x170002DE")]
		public bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F10", Offset = "0x1B12F10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00018980 File Offset: 0x00016B80
		[global::Cpp2ILInjected.Token(Token = "0x170002DF")]
		public int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F18", Offset = "0x1B12F18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00018983 File Offset: 0x00016B83
		[global::Cpp2ILInjected.Token(Token = "0x170002E0")]
		public global::System.IntPtr KeyHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F20", Offset = "0x1B12F20", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00018986 File Offset: 0x00016B86
		[global::Cpp2ILInjected.Token(Token = "0x170002E1")]
		public int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F68", Offset = "0x1B12F68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00018989 File Offset: 0x00016B89
		[global::Cpp2ILInjected.Token(Token = "0x6001A71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12F70", Offset = "0x1B12F70", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0001898C File Offset: 0x00016B8C
		[global::Cpp2ILInjected.Token(Token = "0x6001A72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12FF0", Offset = "0x1B12FF0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0001898F File Offset: 0x00016B8F
		[global::Cpp2ILInjected.Token(Token = "0x6001A73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12FD8", Offset = "0x1B12FD8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00018992 File Offset: 0x00016B92
		[global::Cpp2ILInjected.Token(Token = "0x6001A74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B13008", Offset = "0x1B13008", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00018995 File Offset: 0x00016B95
		[global::Cpp2ILInjected.Token(Token = "0x6001A75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B13010", Offset = "0x1B13010", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00018998 File Offset: 0x00016B98
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001A76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B13018", Offset = "0x1B13018", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x04000AA6 RID: 2726
		[global::Cpp2ILInjected.Token(Token = "0x4000D80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_disposed;
	}
}
