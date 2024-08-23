using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200021D RID: 541
	[global::Cpp2ILInjected.Token(Token = "0x20002B5")]
	public class CryptoStream : global::System.IO.Stream, global::System.IDisposable
	{
		// Token: 0x06001573 RID: 5491 RVA: 0x0001814C File Offset: 0x0001634C
		[global::Cpp2ILInjected.Token(Token = "0x6001782")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2B50", Offset = "0x1AF2B50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Player_OldConsole", Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			"Terraria.IO.PlayerFileData"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Player_OldSwitch", Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			"Terraria.IO.PlayerFileData"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "InternalSavePlayerFile", MemberParameters = new object[] { "Terraria.IO.PlayerFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "LoadTutorialPlayer", ReturnType = "Terraria.IO.PlayerFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "Terraria.IO.PlayerFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Save", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = "ComputeBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public CryptoStream(global::System.IO.Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
		{
			throw null;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0001814F File Offset: 0x0001634F
		[global::Cpp2ILInjected.Token(Token = "0x6001783")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2B58", Offset = "0x1AF2B58", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public CryptoStream(global::System.IO.Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x00018152 File Offset: 0x00016352
		[global::Cpp2ILInjected.Token(Token = "0x17000266")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001784")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2E4C", Offset = "0x1AF2E4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00018155 File Offset: 0x00016355
		[global::Cpp2ILInjected.Token(Token = "0x17000267")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001785")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2E54", Offset = "0x1AF2E54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x00018158 File Offset: 0x00016358
		[global::Cpp2ILInjected.Token(Token = "0x17000268")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001786")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2E5C", Offset = "0x1AF2E5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0001815B File Offset: 0x0001635B
		[global::Cpp2ILInjected.Token(Token = "0x17000269")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001787")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2E64", Offset = "0x1AF2E64", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x0001815E File Offset: 0x0001635E
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00018161 File Offset: 0x00016361
		[global::Cpp2ILInjected.Token(Token = "0x1700026A")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001788")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2EB0", Offset = "0x1AF2EB0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001789")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2EFC", Offset = "0x1AF2EFC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00018164 File Offset: 0x00016364
		[global::Cpp2ILInjected.Token(Token = "0x1700026B")]
		public bool HasFlushedFinalBlock
		{
			[global::Cpp2ILInjected.Token(Token = "0x600178A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2F48", Offset = "0x1AF2F48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00018167 File Offset: 0x00016367
		[global::Cpp2ILInjected.Token(Token = "0x600178B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2F50", Offset = "0x1AF2F50", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "InternalSavePlayerFile", MemberParameters = new object[] { "Terraria.IO.PlayerFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Save", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "FlushFinalBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "FlushFinalBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void FlushFinalBlock()
		{
			throw null;
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0001816A File Offset: 0x0001636A
		[global::Cpp2ILInjected.Token(Token = "0x600178C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3164", Offset = "0x1AF3164", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0001816D File Offset: 0x0001636D
		[global::Cpp2ILInjected.Token(Token = "0x600178D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3168", Offset = "0x1AF3168", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Stream), Member = "FlushAsync", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override global::System.Threading.Tasks.Task FlushAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00018170 File Offset: 0x00016370
		[global::Cpp2ILInjected.Token(Token = "0x600178E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF32D0", Offset = "0x1AF32D0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00018173 File Offset: 0x00016373
		[global::Cpp2ILInjected.Token(Token = "0x600178F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF331C", Offset = "0x1AF331C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00018176 File Offset: 0x00016376
		[global::Cpp2ILInjected.Token(Token = "0x6001790")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3368", Offset = "0x1AF3368", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "CheckReadArguments", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "ReadAsyncInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
		public override global::System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00018179 File Offset: 0x00016379
		[global::Cpp2ILInjected.Token(Token = "0x6001791")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3604", Offset = "0x1AF3604", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_None", ReturnType = typeof(global::System.Threading.CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "Begin", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override global::System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0001817C File Offset: 0x0001637C
		[global::Cpp2ILInjected.Token(Token = "0x6001792")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF36B8", Offset = "0x1AF36B8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "End", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int EndRead(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0001817F File Offset: 0x0001637F
		[global::Cpp2ILInjected.Token(Token = "0x6001793")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF34E0", Offset = "0x1AF34E0", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(CryptoStream.<ReadAsyncInternal>d__37) }, MemberParameters = new object[] { typeof(ref CryptoStream.<ReadAsyncInternal>d__37) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.Threading.Tasks.Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00018182 File Offset: 0x00016382
		[global::Cpp2ILInjected.Token(Token = "0x6001794")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3700", Offset = "0x1AF3700", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Stream), Member = "ReadByte", ReturnType = typeof(int))]
		public override int ReadByte()
		{
			throw null;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00018185 File Offset: 0x00016385
		[global::Cpp2ILInjected.Token(Token = "0x6001795")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3768", Offset = "0x1AF3768", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Stream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public override void WriteByte(byte value)
		{
			throw null;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00018188 File Offset: 0x00016388
		[global::Cpp2ILInjected.Token(Token = "0x6001796")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3798", Offset = "0x1AF3798", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "CheckReadArguments", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "ReadAsyncCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken),
			typeof(bool)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<int>), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter<int>), Member = "GetResult", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0001818B File Offset: 0x0001638B
		[global::Cpp2ILInjected.Token(Token = "0x6001797")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF33B0", Offset = "0x1AF33B0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void CheckReadArguments(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0001818E File Offset: 0x0001638E
		[global::Cpp2ILInjected.Token(Token = "0x6001798")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3858", Offset = "0x1AF3858", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream.<ReadAsyncInternal>d__37), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(CryptoStream.<ReadAsyncCore>d__42) }, MemberParameters = new object[] { typeof(ref CryptoStream.<ReadAsyncCore>d__42) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.Threading.Tasks.Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken, bool useAsync)
		{
			throw null;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00018191 File Offset: 0x00016391
		[global::Cpp2ILInjected.Token(Token = "0x6001799")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF399C", Offset = "0x1AF399C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "CheckWriteArguments", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "WriteAsyncInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		public override global::System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00018194 File Offset: 0x00016394
		[global::Cpp2ILInjected.Token(Token = "0x600179A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3C10", Offset = "0x1AF3C10", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_None", ReturnType = typeof(global::System.Threading.CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "Begin", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override global::System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00018197 File Offset: 0x00016397
		[global::Cpp2ILInjected.Token(Token = "0x600179B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3CC4", Offset = "0x1AF3CC4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "End", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		public override void EndWrite(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0001819A File Offset: 0x0001639A
		[global::Cpp2ILInjected.Token(Token = "0x600179C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3B14", Offset = "0x1AF3B14", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(CryptoStream.<WriteAsyncInternal>d__46) }, MemberParameters = new object[] { typeof(ref CryptoStream.<WriteAsyncInternal>d__46) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private global::System.Threading.Tasks.Task WriteAsyncInternal(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0001819D File Offset: 0x0001639D
		[global::Cpp2ILInjected.Token(Token = "0x600179D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3CD0", Offset = "0x1AF3CD0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "CheckWriteArguments", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "WriteAsyncCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken),
			typeof(bool)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "GetAwaiter", ReturnType = typeof(global::System.Runtime.CompilerServices.TaskAwaiter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x000181A0 File Offset: 0x000163A0
		[global::Cpp2ILInjected.Token(Token = "0x600179E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF39E4", Offset = "0x1AF39E4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void CheckWriteArguments(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000181A3 File Offset: 0x000163A3
		[global::Cpp2ILInjected.Token(Token = "0x600179F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3D34", Offset = "0x1AF3D34", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream.<WriteAsyncInternal>d__46), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(CryptoStream.<WriteAsyncCore>d__49) }, MemberParameters = new object[] { typeof(ref CryptoStream.<WriteAsyncCore>d__49) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private global::System.Threading.Tasks.Task WriteAsyncCore(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken, bool useAsync)
		{
			throw null;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x000181A6 File Offset: 0x000163A6
		[global::Cpp2ILInjected.Token(Token = "0x60017A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3E50", Offset = "0x1AF3E50", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x000181A9 File Offset: 0x000163A9
		[global::Cpp2ILInjected.Token(Token = "0x60017A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF3E60", Offset = "0x1AF3E60", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "FlushFinalBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x000181AC File Offset: 0x000163AC
		[global::Cpp2ILInjected.Token(Token = "0x60017A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2D08", Offset = "0x1AF2D08", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void InitializeBuffer()
		{
			throw null;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x000181AF File Offset: 0x000163AF
		[global::Cpp2ILInjected.Token(Token = "0x1700026C")]
		private global::System.Threading.SemaphoreSlim AsyncActiveSemaphore
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF3F08", Offset = "0x1AF3F08", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream.<ReadAsyncInternal>d__37), Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoStream.<WriteAsyncInternal>d__46), Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000975 RID: 2421
		[global::Cpp2ILInjected.Token(Token = "0x4000C1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly global::System.IO.Stream _stream;

		// Token: 0x04000976 RID: 2422
		[global::Cpp2ILInjected.Token(Token = "0x4000C1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly ICryptoTransform _transform;

		// Token: 0x04000977 RID: 2423
		[global::Cpp2ILInjected.Token(Token = "0x4000C1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly CryptoStreamMode _transformMode;

		// Token: 0x04000978 RID: 2424
		[global::Cpp2ILInjected.Token(Token = "0x4000C20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private byte[] _inputBuffer;

		// Token: 0x04000979 RID: 2425
		[global::Cpp2ILInjected.Token(Token = "0x4000C21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _inputBufferIndex;

		// Token: 0x0400097A RID: 2426
		[global::Cpp2ILInjected.Token(Token = "0x4000C22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int _inputBlockSize;

		// Token: 0x0400097B RID: 2427
		[global::Cpp2ILInjected.Token(Token = "0x4000C23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte[] _outputBuffer;

		// Token: 0x0400097C RID: 2428
		[global::Cpp2ILInjected.Token(Token = "0x4000C24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int _outputBufferIndex;

		// Token: 0x0400097D RID: 2429
		[global::Cpp2ILInjected.Token(Token = "0x4000C25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private int _outputBlockSize;

		// Token: 0x0400097E RID: 2430
		[global::Cpp2ILInjected.Token(Token = "0x4000C26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool _canRead;

		// Token: 0x0400097F RID: 2431
		[global::Cpp2ILInjected.Token(Token = "0x4000C27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool _canWrite;

		// Token: 0x04000980 RID: 2432
		[global::Cpp2ILInjected.Token(Token = "0x4000C28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x62")]
		private bool _finalBlockTransformed;

		// Token: 0x04000981 RID: 2433
		[global::Cpp2ILInjected.Token(Token = "0x4000C29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.Threading.SemaphoreSlim _lazyAsyncActiveSemaphore;

		// Token: 0x04000982 RID: 2434
		[global::Cpp2ILInjected.Token(Token = "0x4000C2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private readonly bool _leaveOpen;

		// Token: 0x020005E3 RID: 1507
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002B6")]
		[StructLayout(3)]
		private struct <ReadAsyncInternal>d__37 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			// Token: 0x060040E6 RID: 16614 RVA: 0x0001FD60 File Offset: 0x0001DF60
			[global::Cpp2ILInjected.Token(Token = "0x60017A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF4004", Offset = "0x1AF4004", Length = "0x388")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "get_AsyncActiveSemaphore", ReturnType = typeof(global::System.Threading.SemaphoreSlim))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskAwaiters), Member = "ForceAsync", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "GetAwaiter", ReturnType = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "ReadAsyncCore", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.Threading.CancellationToken),
				typeof(bool)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<int>), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter<int>), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter<int>), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.TaskAwaiter<int>),
				typeof(CryptoStream.<ReadAsyncInternal>d__37)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Runtime.CompilerServices.TaskAwaiter<int>),
				typeof(ref CryptoStream.<ReadAsyncInternal>d__37)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.ForceAsyncAwaiter),
				typeof(CryptoStream.<ReadAsyncInternal>d__37)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Threading.Tasks.ForceAsyncAwaiter),
				typeof(ref CryptoStream.<ReadAsyncInternal>d__37)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x060040E7 RID: 16615 RVA: 0x0001FD63 File Offset: 0x0001DF63
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60017A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF438C", Offset = "0x1AF438C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001930 RID: 6448
			[global::Cpp2ILInjected.Token(Token = "0x4000C2B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001931 RID: 6449
			[global::Cpp2ILInjected.Token(Token = "0x4000C2C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04001932 RID: 6450
			[global::Cpp2ILInjected.Token(Token = "0x4000C2D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CryptoStream <>4__this;

			// Token: 0x04001933 RID: 6451
			[global::Cpp2ILInjected.Token(Token = "0x4000C2E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			// Token: 0x04001934 RID: 6452
			[global::Cpp2ILInjected.Token(Token = "0x4000C2F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int offset;

			// Token: 0x04001935 RID: 6453
			[global::Cpp2ILInjected.Token(Token = "0x4000C30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public int count;

			// Token: 0x04001936 RID: 6454
			[global::Cpp2ILInjected.Token(Token = "0x4000C31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public global::System.Threading.CancellationToken cancellationToken;

			// Token: 0x04001937 RID: 6455
			[global::Cpp2ILInjected.Token(Token = "0x4000C32")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private global::System.Threading.SemaphoreSlim <semaphore>5__2;

			// Token: 0x04001938 RID: 6456
			[global::Cpp2ILInjected.Token(Token = "0x4000C33")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private global::System.Threading.Tasks.ForceAsyncAwaiter <>u__1;

			// Token: 0x04001939 RID: 6457
			[global::Cpp2ILInjected.Token(Token = "0x4000C34")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private global::System.Runtime.CompilerServices.TaskAwaiter<int> <>u__2;
		}

		// Token: 0x020005E4 RID: 1508
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002B7")]
		[StructLayout(3)]
		private struct <ReadAsyncCore>d__42 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			// Token: 0x060040E8 RID: 16616 RVA: 0x0001FD66 File Offset: 0x0001DF66
			[global::Cpp2ILInjected.Token(Token = "0x60017A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF43E4", Offset = "0x1AF43E4", Length = "0x1044")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicOperations), Member = "ZeroMemory", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.ValueTaskAwaiter<int>),
				typeof(CryptoStream.<ReadAsyncCore>d__42)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Runtime.CompilerServices.ValueTaskAwaiter<int>),
				typeof(ref CryptoStream.<ReadAsyncCore>d__42)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x060040E9 RID: 16617 RVA: 0x0001FD69 File Offset: 0x0001DF69
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60017A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF5428", Offset = "0x1AF5428", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400193A RID: 6458
			[global::Cpp2ILInjected.Token(Token = "0x4000C35")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400193B RID: 6459
			[global::Cpp2ILInjected.Token(Token = "0x4000C36")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400193C RID: 6460
			[global::Cpp2ILInjected.Token(Token = "0x4000C37")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int count;

			// Token: 0x0400193D RID: 6461
			[global::Cpp2ILInjected.Token(Token = "0x4000C38")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public int offset;

			// Token: 0x0400193E RID: 6462
			[global::Cpp2ILInjected.Token(Token = "0x4000C39")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CryptoStream <>4__this;

			// Token: 0x0400193F RID: 6463
			[global::Cpp2ILInjected.Token(Token = "0x4000C3A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public byte[] buffer;

			// Token: 0x04001940 RID: 6464
			[global::Cpp2ILInjected.Token(Token = "0x4000C3B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public bool useAsync;

			// Token: 0x04001941 RID: 6465
			[global::Cpp2ILInjected.Token(Token = "0x4000C3C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public global::System.Threading.CancellationToken cancellationToken;

			// Token: 0x04001942 RID: 6466
			[global::Cpp2ILInjected.Token(Token = "0x4000C3D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int <bytesToDeliver>5__2;

			// Token: 0x04001943 RID: 6467
			[global::Cpp2ILInjected.Token(Token = "0x4000C3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private int <currentOutputIndex>5__3;

			// Token: 0x04001944 RID: 6468
			[global::Cpp2ILInjected.Token(Token = "0x4000C3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private int <numWholeBlocksInBytes>5__4;

			// Token: 0x04001945 RID: 6469
			[global::Cpp2ILInjected.Token(Token = "0x4000C40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private byte[] <tempInputBuffer>5__5;

			// Token: 0x04001946 RID: 6470
			[global::Cpp2ILInjected.Token(Token = "0x4000C41")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private byte[] <tempOutputBuffer>5__6;

			// Token: 0x04001947 RID: 6471
			[global::Cpp2ILInjected.Token(Token = "0x4000C42")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private global::System.Runtime.CompilerServices.ValueTaskAwaiter<int> <>u__1;
		}

		// Token: 0x020005E5 RID: 1509
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002B8")]
		[StructLayout(3)]
		private struct <WriteAsyncInternal>d__46 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			// Token: 0x060040EA RID: 16618 RVA: 0x0001FD6C File Offset: 0x0001DF6C
			[global::Cpp2ILInjected.Token(Token = "0x60017A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF5480", Offset = "0x1AF5480", Length = "0x2E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "get_AsyncActiveSemaphore", ReturnType = typeof(global::System.Threading.SemaphoreSlim))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskAwaiters), Member = "ForceAsync", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "GetAwaiter", ReturnType = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "WriteAsyncCore", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.Threading.CancellationToken),
				typeof(bool)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "GetAwaiter", ReturnType = typeof(global::System.Runtime.CompilerServices.TaskAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.TaskAwaiter),
				typeof(CryptoStream.<WriteAsyncInternal>d__46)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Runtime.CompilerServices.TaskAwaiter),
				typeof(ref CryptoStream.<WriteAsyncInternal>d__46)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.ForceAsyncAwaiter),
				typeof(CryptoStream.<WriteAsyncInternal>d__46)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Threading.Tasks.ForceAsyncAwaiter),
				typeof(ref CryptoStream.<WriteAsyncInternal>d__46)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x060040EB RID: 16619 RVA: 0x0001FD6F File Offset: 0x0001DF6F
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60017A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF5764", Offset = "0x1AF5764", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001948 RID: 6472
			[global::Cpp2ILInjected.Token(Token = "0x4000C43")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001949 RID: 6473
			[global::Cpp2ILInjected.Token(Token = "0x4000C44")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400194A RID: 6474
			[global::Cpp2ILInjected.Token(Token = "0x4000C45")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CryptoStream <>4__this;

			// Token: 0x0400194B RID: 6475
			[global::Cpp2ILInjected.Token(Token = "0x4000C46")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			// Token: 0x0400194C RID: 6476
			[global::Cpp2ILInjected.Token(Token = "0x4000C47")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int offset;

			// Token: 0x0400194D RID: 6477
			[global::Cpp2ILInjected.Token(Token = "0x4000C48")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public int count;

			// Token: 0x0400194E RID: 6478
			[global::Cpp2ILInjected.Token(Token = "0x4000C49")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public global::System.Threading.CancellationToken cancellationToken;

			// Token: 0x0400194F RID: 6479
			[global::Cpp2ILInjected.Token(Token = "0x4000C4A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private global::System.Threading.SemaphoreSlim <semaphore>5__2;

			// Token: 0x04001950 RID: 6480
			[global::Cpp2ILInjected.Token(Token = "0x4000C4B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private global::System.Threading.Tasks.ForceAsyncAwaiter <>u__1;

			// Token: 0x04001951 RID: 6481
			[global::Cpp2ILInjected.Token(Token = "0x4000C4C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private global::System.Runtime.CompilerServices.TaskAwaiter <>u__2;
		}

		// Token: 0x020005E6 RID: 1510
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002B9")]
		[StructLayout(3)]
		private struct <WriteAsyncCore>d__49 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			// Token: 0x060040EC RID: 16620 RVA: 0x0001FD72 File Offset: 0x0001DF72
			[global::Cpp2ILInjected.Token(Token = "0x60017AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF5770", Offset = "0x1AF5770", Length = "0x10F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ValueTask), Member = "GetAwaiter", ReturnType = typeof(global::System.Runtime.CompilerServices.ValueTaskAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.ValueTaskAwaiter),
				typeof(CryptoStream.<WriteAsyncCore>d__49)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Runtime.CompilerServices.ValueTaskAwaiter),
				typeof(ref CryptoStream.<WriteAsyncCore>d__49)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x060040ED RID: 16621 RVA: 0x0001FD75 File Offset: 0x0001DF75
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60017AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF6864", Offset = "0x1AF6864", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001952 RID: 6482
			[global::Cpp2ILInjected.Token(Token = "0x4000C4D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001953 RID: 6483
			[global::Cpp2ILInjected.Token(Token = "0x4000C4E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001954 RID: 6484
			[global::Cpp2ILInjected.Token(Token = "0x4000C4F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int count;

			// Token: 0x04001955 RID: 6485
			[global::Cpp2ILInjected.Token(Token = "0x4000C50")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public int offset;

			// Token: 0x04001956 RID: 6486
			[global::Cpp2ILInjected.Token(Token = "0x4000C51")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CryptoStream <>4__this;

			// Token: 0x04001957 RID: 6487
			[global::Cpp2ILInjected.Token(Token = "0x4000C52")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public byte[] buffer;

			// Token: 0x04001958 RID: 6488
			[global::Cpp2ILInjected.Token(Token = "0x4000C53")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public bool useAsync;

			// Token: 0x04001959 RID: 6489
			[global::Cpp2ILInjected.Token(Token = "0x4000C54")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public global::System.Threading.CancellationToken cancellationToken;

			// Token: 0x0400195A RID: 6490
			[global::Cpp2ILInjected.Token(Token = "0x4000C55")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int <bytesToWrite>5__2;

			// Token: 0x0400195B RID: 6491
			[global::Cpp2ILInjected.Token(Token = "0x4000C56")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private int <currentInputIndex>5__3;

			// Token: 0x0400195C RID: 6492
			[global::Cpp2ILInjected.Token(Token = "0x4000C57")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private int <numOutputBytes>5__4;

			// Token: 0x0400195D RID: 6493
			[global::Cpp2ILInjected.Token(Token = "0x4000C58")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private global::System.Runtime.CompilerServices.ValueTaskAwaiter <>u__1;

			// Token: 0x0400195E RID: 6494
			[global::Cpp2ILInjected.Token(Token = "0x4000C59")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private int <numWholeBlocksInBytes>5__5;

			// Token: 0x0400195F RID: 6495
			[global::Cpp2ILInjected.Token(Token = "0x4000C5A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private byte[] <tempOutputBuffer>5__6;
		}

		// Token: 0x020005E7 RID: 1511
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002BA")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x060040EE RID: 16622 RVA: 0x0001FD78 File Offset: 0x0001DF78
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60017AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF6870", Offset = "0x1AF6870", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x060040EF RID: 16623 RVA: 0x0001FD7B File Offset: 0x0001DF7B
			[global::Cpp2ILInjected.Token(Token = "0x60017AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF68CC", Offset = "0x1AF68CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060040F0 RID: 16624 RVA: 0x0001FD7E File Offset: 0x0001DF7E
			[global::Cpp2ILInjected.Token(Token = "0x60017AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF68D4", Offset = "0x1AF68D4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal global::System.Threading.SemaphoreSlim <get_AsyncActiveSemaphore>b__54_0()
			{
				throw null;
			}

			// Token: 0x04001960 RID: 6496
			[global::Cpp2ILInjected.Token(Token = "0x4000C5B")]
			public static readonly CryptoStream.<>c <>9;

			// Token: 0x04001961 RID: 6497
			[global::Cpp2ILInjected.Token(Token = "0x4000C5C")]
			public static global::System.Func<global::System.Threading.SemaphoreSlim> <>9__54_0;
		}
	}
}
