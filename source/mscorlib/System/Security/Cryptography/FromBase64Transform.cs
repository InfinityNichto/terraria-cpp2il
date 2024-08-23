using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200022E RID: 558
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002CB")]
	public class FromBase64Transform : ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x06001617 RID: 5655 RVA: 0x00018305 File Offset: 0x00016505
		[global::Cpp2ILInjected.Token(Token = "0x6001831")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9860", Offset = "0x1AF9860", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public FromBase64Transform()
		{
			throw null;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00018308 File Offset: 0x00016508
		[global::Cpp2ILInjected.Token(Token = "0x6001832")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9868", Offset = "0x1AF9868", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public FromBase64Transform(FromBase64TransformMode whitespaces)
		{
			throw null;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x0001830B File Offset: 0x0001650B
		[global::Cpp2ILInjected.Token(Token = "0x1700028D")]
		public int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001833")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF98D4", Offset = "0x1AF98D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x0001830E File Offset: 0x0001650E
		[global::Cpp2ILInjected.Token(Token = "0x1700028E")]
		public int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001834")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF98DC", Offset = "0x1AF98DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00018311 File Offset: 0x00016511
		[global::Cpp2ILInjected.Token(Token = "0x1700028F")]
		public bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001835")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF98E4", Offset = "0x1AF98E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00018314 File Offset: 0x00016514
		[global::Cpp2ILInjected.Token(Token = "0x17000290")]
		public virtual bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001836")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF98EC", Offset = "0x1AF98EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00018317 File Offset: 0x00016517
		[global::Cpp2ILInjected.Token(Token = "0x6001837")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF98F4", Offset = "0x1AF98F4", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FromBase64Transform), Member = "DiscardWhiteSpaces", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_ASCII", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64CharArray", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0001831A File Offset: 0x0001651A
		[global::Cpp2ILInjected.Token(Token = "0x6001838")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9DA4", Offset = "0x1AF9DA4", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FromBase64Transform), Member = "DiscardWhiteSpaces", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_ASCII", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64CharArray", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0001831D File Offset: 0x0001651D
		[global::Cpp2ILInjected.Token(Token = "0x6001839")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9C50", Offset = "0x1AF9C50", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FromBase64Transform), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FromBase64Transform), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private byte[] DiscardWhiteSpaces(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00018320 File Offset: 0x00016520
		[global::Cpp2ILInjected.Token(Token = "0x600183A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA0E8", Offset = "0x1AFA0E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FromBase64Transform), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00018323 File Offset: 0x00016523
		[global::Cpp2ILInjected.Token(Token = "0x600183B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA0E0", Offset = "0x1AFA0E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Reset()
		{
			throw null;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00018326 File Offset: 0x00016526
		[global::Cpp2ILInjected.Token(Token = "0x600183C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA154", Offset = "0x1AFA154", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FromBase64Transform), Member = "Dispose", ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00018329 File Offset: 0x00016529
		[global::Cpp2ILInjected.Token(Token = "0x600183D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA158", Offset = "0x1AFA158", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0001832C File Offset: 0x0001652C
		[global::Cpp2ILInjected.Token(Token = "0x600183E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA18C", Offset = "0x1AFA18C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x040009A2 RID: 2466
		[global::Cpp2ILInjected.Token(Token = "0x4000C7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] _inputBuffer;

		// Token: 0x040009A3 RID: 2467
		[global::Cpp2ILInjected.Token(Token = "0x4000C7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _inputIndex;

		// Token: 0x040009A4 RID: 2468
		[global::Cpp2ILInjected.Token(Token = "0x4000C7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private FromBase64TransformMode _whitespaces;
	}
}
