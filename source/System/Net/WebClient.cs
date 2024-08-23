using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000EA RID: 234
	[global::Cpp2ILInjected.Token(Token = "0x200015A")]
	public class WebClient : Component
	{
		// Token: 0x060007F8 RID: 2040 RVA: 0x0000453B File Offset: 0x0000273B
		[global::Cpp2ILInjected.Token(Token = "0x60008C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9978", Offset = "0x1EF9978", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public WebClient()
		{
			throw null;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060007F9 RID: 2041 RVA: 0x0000453E File Offset: 0x0000273E
		// (remove) Token: 0x060007FA RID: 2042 RVA: 0x00004541 File Offset: 0x00002741
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		public event DownloadStringCompletedEventHandler DownloadStringCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9A9C", Offset = "0x1EF9A9C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<string>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9B38", Offset = "0x1EF9B38", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<DownloadStringTaskAsync>b__192_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(DownloadStringCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<string>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060007FB RID: 2043 RVA: 0x00004544 File Offset: 0x00002744
		// (remove) Token: 0x060007FC RID: 2044 RVA: 0x00004547 File Offset: 0x00002747
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		public event DownloadDataCompletedEventHandler DownloadDataCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9BD4", Offset = "0x1EF9BD4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9C70", Offset = "0x1EF9C70", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<DownloadDataTaskAsync>b__204_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(DownloadDataCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060007FD RID: 2045 RVA: 0x0000454A File Offset: 0x0000274A
		// (remove) Token: 0x060007FE RID: 2046 RVA: 0x0000454D File Offset: 0x0000274D
		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		public event AsyncCompletedEventHandler DownloadFileCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9D0C", Offset = "0x1EF9D0C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9DAC", Offset = "0x1EF9DAC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<DownloadFileTaskAsync>b__206_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(AsyncCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060007FF RID: 2047 RVA: 0x00004550 File Offset: 0x00002750
		// (remove) Token: 0x06000800 RID: 2048 RVA: 0x00004553 File Offset: 0x00002753
		[global::Cpp2ILInjected.Token(Token = "0x14000004")]
		public event UploadStringCompletedEventHandler UploadStringCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9E4C", Offset = "0x1EF9E4C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(Task<string>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9EEC", Offset = "0x1EF9EEC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<UploadStringTaskAsync>b__202_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(UploadStringCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(Task<string>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000801 RID: 2049 RVA: 0x00004556 File Offset: 0x00002756
		// (remove) Token: 0x06000802 RID: 2050 RVA: 0x00004559 File Offset: 0x00002759
		[global::Cpp2ILInjected.Token(Token = "0x14000005")]
		public event UploadDataCompletedEventHandler UploadDataCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9F8C", Offset = "0x1EF9F8C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(byte[])
			}, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA02C", Offset = "0x1EFA02C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<UploadDataTaskAsync>b__210_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(UploadDataCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(byte[])
			}, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000803 RID: 2051 RVA: 0x0000455C File Offset: 0x0000275C
		// (remove) Token: 0x06000804 RID: 2052 RVA: 0x0000455F File Offset: 0x0000275F
		[global::Cpp2ILInjected.Token(Token = "0x14000006")]
		public event UploadFileCompletedEventHandler UploadFileCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA0CC", Offset = "0x1EFA0CC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA16C", Offset = "0x1EFA16C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<UploadFileTaskAsync>b__214_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(UploadFileCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000805 RID: 2053 RVA: 0x00004562 File Offset: 0x00002762
		// (remove) Token: 0x06000806 RID: 2054 RVA: 0x00004565 File Offset: 0x00002765
		[global::Cpp2ILInjected.Token(Token = "0x14000007")]
		public event UploadValuesCompletedEventHandler UploadValuesCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA20C", Offset = "0x1EFA20C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(NameValueCollection)
			}, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA2AC", Offset = "0x1EFA2AC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<UploadValuesTaskAsync>b__218_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(UploadValuesCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(NameValueCollection)
			}, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000807 RID: 2055 RVA: 0x00004568 File Offset: 0x00002768
		// (remove) Token: 0x06000808 RID: 2056 RVA: 0x0000456B File Offset: 0x0000276B
		[global::Cpp2ILInjected.Token(Token = "0x14000008")]
		public event OpenReadCompletedEventHandler OpenReadCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA34C", Offset = "0x1EFA34C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<Stream>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA3EC", Offset = "0x1EFA3EC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<OpenReadTaskAsync>b__194_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(OpenReadCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<Stream>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000809 RID: 2057 RVA: 0x0000456E File Offset: 0x0000276E
		// (remove) Token: 0x0600080A RID: 2058 RVA: 0x00004571 File Offset: 0x00002771
		[global::Cpp2ILInjected.Token(Token = "0x14000009")]
		public event OpenWriteCompletedEventHandler OpenWriteCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA48C", Offset = "0x1EFA48C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string)
			}, ReturnType = typeof(Task<Stream>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA52C", Offset = "0x1EFA52C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c), Member = "<OpenWriteTaskAsync>b__198_2", MemberParameters = new object[]
			{
				typeof(WebClient),
				typeof(OpenWriteCompletedEventHandler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string)
			}, ReturnType = typeof(Task<Stream>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600080B RID: 2059 RVA: 0x00004574 File Offset: 0x00002774
		// (remove) Token: 0x0600080C RID: 2060 RVA: 0x00004577 File Offset: 0x00002777
		[global::Cpp2ILInjected.Token(Token = "0x1400000A")]
		public event DownloadProgressChangedEventHandler DownloadProgressChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA5CC", Offset = "0x1EFA5CC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA66C", Offset = "0x1EFA66C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600080D RID: 2061 RVA: 0x0000457A File Offset: 0x0000277A
		// (remove) Token: 0x0600080E RID: 2062 RVA: 0x0000457D File Offset: 0x0000277D
		[global::Cpp2ILInjected.Token(Token = "0x1400000B")]
		public event UploadProgressChangedEventHandler UploadProgressChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA70C", Offset = "0x1EFA70C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFA7AC", Offset = "0x1EFA7AC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00004580 File Offset: 0x00002780
		[global::Cpp2ILInjected.Token(Token = "0x60008E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA84C", Offset = "0x1EFA84C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00004583 File Offset: 0x00002783
		[global::Cpp2ILInjected.Token(Token = "0x60008E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA874", Offset = "0x1EFA874", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00004586 File Offset: 0x00002786
		[global::Cpp2ILInjected.Token(Token = "0x60008E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA89C", Offset = "0x1EFA89C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00004589 File Offset: 0x00002789
		[global::Cpp2ILInjected.Token(Token = "0x60008E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA8C4", Offset = "0x1EFA8C4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0000458C File Offset: 0x0000278C
		[global::Cpp2ILInjected.Token(Token = "0x60008E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA8EC", Offset = "0x1EFA8EC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0000458F File Offset: 0x0000278F
		[global::Cpp2ILInjected.Token(Token = "0x60008E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA914", Offset = "0x1EFA914", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00004592 File Offset: 0x00002792
		[global::Cpp2ILInjected.Token(Token = "0x60008E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA93C", Offset = "0x1EFA93C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00004595 File Offset: 0x00002795
		[global::Cpp2ILInjected.Token(Token = "0x60008E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA964", Offset = "0x1EFA964", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00004598 File Offset: 0x00002798
		[global::Cpp2ILInjected.Token(Token = "0x60008E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA98C", Offset = "0x1EFA98C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0000459B File Offset: 0x0000279B
		[global::Cpp2ILInjected.Token(Token = "0x60008E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA9B4", Offset = "0x1EFA9B4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0000459E File Offset: 0x0000279E
		[global::Cpp2ILInjected.Token(Token = "0x60008EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA9DC", Offset = "0x1EFA9DC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000045A1 File Offset: 0x000027A1
		[global::Cpp2ILInjected.Token(Token = "0x60008EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFAA04", Offset = "0x1EFAA04", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadData", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenRead", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "EndOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void StartOperation()
		{
			throw null;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000045A4 File Offset: 0x000027A4
		[global::Cpp2ILInjected.Token(Token = "0x60008EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFAAC0", Offset = "0x1EFAAC0", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendOrPostCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperationManager), Member = "CreateOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private AsyncOperation StartAsyncOperation(object userToken)
		{
			throw null;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000045A7 File Offset: 0x000027A7
		[global::Cpp2ILInjected.Token(Token = "0x60008ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFAAA0", Offset = "0x1EFAAA0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		private void EndOperation()
		{
			throw null;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x000045AA File Offset: 0x000027AA
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x000045AD File Offset: 0x000027AD
		[global::Cpp2ILInjected.Token(Token = "0x170001EC")]
		public Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFADDC", Offset = "0x1EFADDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFADE4", Offset = "0x1EFADE4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x000045B0 File Offset: 0x000027B0
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x000045B3 File Offset: 0x000027B3
		[global::Cpp2ILInjected.Token(Token = "0x170001ED")]
		public string BaseAddress
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFAEB0", Offset = "0x1EFAEB0", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFAF50", Offset = "0x1EFAF50", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000045B6 File Offset: 0x000027B6
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x000045B9 File Offset: 0x000027B9
		[global::Cpp2ILInjected.Token(Token = "0x170001EE")]
		public ICredentials Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB098", Offset = "0x1EFB098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB0A0", Offset = "0x1EFB0A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000045BC File Offset: 0x000027BC
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x000045BF File Offset: 0x000027BF
		[global::Cpp2ILInjected.Token(Token = "0x170001EF")]
		public bool UseDefaultCredentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB0A8", Offset = "0x1EFB0A8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB10C", Offset = "0x1EFB10C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000045C2 File Offset: 0x000027C2
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x000045C5 File Offset: 0x000027C5
		[global::Cpp2ILInjected.Token(Token = "0x170001F0")]
		public WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB178", Offset = "0x1EFB178", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenFileInternal", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(string),
				typeof(ref FileStream),
				typeof(ref byte[]),
				typeof(ref byte[]),
				typeof(ref byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetValuesToUpload", MemberParameters = new object[] { typeof(NameValueCollection) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB1DC", Offset = "0x1EFB1DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000045C8 File Offset: 0x000027C8
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x000045CB File Offset: 0x000027CB
		[global::Cpp2ILInjected.Token(Token = "0x170001F1")]
		public NameValueCollection QueryString
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB1E4", Offset = "0x1EFB1E4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB248", Offset = "0x1EFB248", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000045CE File Offset: 0x000027CE
		[global::Cpp2ILInjected.Token(Token = "0x170001F2")]
		public WebHeaderCollection ResponseHeaders
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB250", Offset = "0x1EFB250", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x000045D1 File Offset: 0x000027D1
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x000045D4 File Offset: 0x000027D4
		[global::Cpp2ILInjected.Token(Token = "0x170001F3")]
		public IWebProxy Proxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB26C", Offset = "0x1EFB26C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_DefaultWebProxy", ReturnType = typeof(IWebProxy))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB2D8", Offset = "0x1EFB2D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000045D7 File Offset: 0x000027D7
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x000045DA File Offset: 0x000027DA
		[global::Cpp2ILInjected.Token(Token = "0x170001F4")]
		public RequestCachePolicy CachePolicy
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB2E8", Offset = "0x1EFB2E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60008FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB2F0", Offset = "0x1EFB2F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x000045DD File Offset: 0x000027DD
		[global::Cpp2ILInjected.Token(Token = "0x170001F5")]
		public bool IsBusy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFB2F8", Offset = "0x1EFB2F8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000045E0 File Offset: 0x000027E0
		[global::Cpp2ILInjected.Token(Token = "0x6000900")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB308", Offset = "0x1EFB308", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "CopyHeadersTo", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual WebRequest GetWebRequest(Uri address)
		{
			throw null;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000045E3 File Offset: 0x000027E3
		[global::Cpp2ILInjected.Token(Token = "0x6000901")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB7CC", Offset = "0x1EFB7CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual WebResponse GetWebResponse(WebRequest request)
		{
			throw null;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000045E6 File Offset: 0x000027E6
		[global::Cpp2ILInjected.Token(Token = "0x6000902")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB7F8", Offset = "0x1EFB7F8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
		{
			throw null;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000045E9 File Offset: 0x000027E9
		[global::Cpp2ILInjected.Token(Token = "0x6000903")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB828", Offset = "0x1EFB828", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<DownloadBitsAsync>d__150), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebClient.<GetWebResponseTaskAsync>d__112) }, MemberParameters = new object[] { typeof(ref WebClient.<GetWebResponseTaskAsync>d__112) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<WebResponse> GetWebResponseTaskAsync(WebRequest request)
		{
			throw null;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000045EC File Offset: 0x000027EC
		[global::Cpp2ILInjected.Token(Token = "0x6000904")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB920", Offset = "0x1EFB920", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadData", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(byte[]))]
		public byte[] DownloadData(string address)
		{
			throw null;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000045EF File Offset: 0x000027EF
		[global::Cpp2ILInjected.Token(Token = "0x6000905")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFBABC", Offset = "0x1EFBABC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public byte[] DownloadData(Uri address)
		{
			throw null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000045F2 File Offset: 0x000027F2
		[global::Cpp2ILInjected.Token(Token = "0x6000906")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFBBD0", Offset = "0x1EFBBD0", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadData", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private byte[] DownloadDataInternal(Uri address, out WebRequest request)
		{
			throw null;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000045F5 File Offset: 0x000027F5
		[global::Cpp2ILInjected.Token(Token = "0x6000907")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFC6A0", Offset = "0x1EFC6A0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public void DownloadFile(string address, string fileName)
		{
			throw null;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000045F8 File Offset: 0x000027F8
		[global::Cpp2ILInjected.Token(Token = "0x6000908")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFC6CC", Offset = "0x1EFC6CC", Length = "0x3DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public void DownloadFile(Uri address, string fileName)
		{
			throw null;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000045FB File Offset: 0x000027FB
		[global::Cpp2ILInjected.Token(Token = "0x6000909")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFCAA8", Offset = "0x1EFCAA8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Stream OpenRead(string address)
		{
			throw null;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000045FE File Offset: 0x000027FE
		[global::Cpp2ILInjected.Token(Token = "0x600090A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFCAC4", Offset = "0x1EFCAC4", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public Stream OpenRead(Uri address)
		{
			throw null;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00004601 File Offset: 0x00002801
		[global::Cpp2ILInjected.Token(Token = "0x600090B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFCE04", Offset = "0x1EFCE04", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Stream OpenWrite(string address)
		{
			throw null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00004604 File Offset: 0x00002804
		[global::Cpp2ILInjected.Token(Token = "0x600090C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD194", Offset = "0x1EFD194", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		public Stream OpenWrite(Uri address)
		{
			throw null;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00004607 File Offset: 0x00002807
		[global::Cpp2ILInjected.Token(Token = "0x600090D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD19C", Offset = "0x1EFD19C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		public Stream OpenWrite(string address, string method)
		{
			throw null;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0000460A File Offset: 0x0000280A
		[global::Cpp2ILInjected.Token(Token = "0x600090E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFCE24", Offset = "0x1EFCE24", Length = "0x370")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public Stream OpenWrite(Uri address, string method)
		{
			throw null;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0000460D File Offset: 0x0000280D
		[global::Cpp2ILInjected.Token(Token = "0x600090F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD310", Offset = "0x1EFD310", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public byte[] UploadData(string address, byte[] data)
		{
			throw null;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00004610 File Offset: 0x00002810
		[global::Cpp2ILInjected.Token(Token = "0x6000910")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD4A0", Offset = "0x1EFD4A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		public byte[] UploadData(Uri address, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00004613 File Offset: 0x00002813
		[global::Cpp2ILInjected.Token(Token = "0x6000911")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD4AC", Offset = "0x1EFD4AC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		public byte[] UploadData(string address, string method, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00004616 File Offset: 0x00002816
		[global::Cpp2ILInjected.Token(Token = "0x6000912")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD340", Offset = "0x1EFD340", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public byte[] UploadData(Uri address, string method, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00004619 File Offset: 0x00002819
		[global::Cpp2ILInjected.Token(Token = "0x6000913")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD4E0", Offset = "0x1EFD4E0", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private byte[] UploadDataInternal(Uri address, string method, byte[] data, out WebRequest request)
		{
			throw null;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0000461C File Offset: 0x0000281C
		[global::Cpp2ILInjected.Token(Token = "0x6000914")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFDD2C", Offset = "0x1EFDD2C", Length = "0x694")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		private void OpenFileInternal(bool needsHeaderAndBoundary, string fileName, ref FileStream fs, ref byte[] buffer, ref byte[] formHeaderBytes, ref byte[] boundaryBytes)
		{
			throw null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0000461F File Offset: 0x0000281F
		[global::Cpp2ILInjected.Token(Token = "0x6000915")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFE3C0", Offset = "0x1EFE3C0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		public byte[] UploadFile(string address, string fileName)
		{
			throw null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00004622 File Offset: 0x00002822
		[global::Cpp2ILInjected.Token(Token = "0x6000916")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFE3F0", Offset = "0x1EFE3F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte[] UploadFile(Uri address, string fileName)
		{
			throw null;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00004625 File Offset: 0x00002825
		[global::Cpp2ILInjected.Token(Token = "0x6000917")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFE810", Offset = "0x1EFE810", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		public byte[] UploadFile(string address, string method, string fileName)
		{
			throw null;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00004628 File Offset: 0x00002828
		[global::Cpp2ILInjected.Token(Token = "0x6000918")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFE3FC", Offset = "0x1EFE3FC", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenFileInternal", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(ref FileStream),
			typeof(ref byte[]),
			typeof(ref byte[]),
			typeof(ref byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public byte[] UploadFile(Uri address, string method, string fileName)
		{
			throw null;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0000462B File Offset: 0x0000282B
		[global::Cpp2ILInjected.Token(Token = "0x6000919")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFE844", Offset = "0x1EFE844", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UrlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private byte[] GetValuesToUpload(NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0000462E File Offset: 0x0000282E
		[global::Cpp2ILInjected.Token(Token = "0x600091A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEB60", Offset = "0x1EFEB60", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public byte[] UploadValues(string address, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00004631 File Offset: 0x00002831
		[global::Cpp2ILInjected.Token(Token = "0x600091B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEF1C", Offset = "0x1EFEF1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		public byte[] UploadValues(Uri address, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00004634 File Offset: 0x00002834
		[global::Cpp2ILInjected.Token(Token = "0x600091C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEF28", Offset = "0x1EFEF28", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		public byte[] UploadValues(string address, string method, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00004637 File Offset: 0x00002837
		[global::Cpp2ILInjected.Token(Token = "0x600091D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEB90", Offset = "0x1EFEB90", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetValuesToUpload", MemberParameters = new object[] { typeof(NameValueCollection) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public byte[] UploadValues(Uri address, string method, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0000463A File Offset: 0x0000283A
		[global::Cpp2ILInjected.Token(Token = "0x600091E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEF5C", Offset = "0x1EFEF5C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public string UploadString(string address, string data)
		{
			throw null;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0000463D File Offset: 0x0000283D
		[global::Cpp2ILInjected.Token(Token = "0x600091F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF11C", Offset = "0x1EFF11C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public string UploadString(Uri address, string data)
		{
			throw null;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00004640 File Offset: 0x00002840
		[global::Cpp2ILInjected.Token(Token = "0x6000920")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF128", Offset = "0x1EFF128", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public string UploadString(string address, string method, string data)
		{
			throw null;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00004643 File Offset: 0x00002843
		[global::Cpp2ILInjected.Token(Token = "0x6000921")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEF8C", Offset = "0x1EFEF8C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetStringUsingEncoding", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public string UploadString(Uri address, string method, string data)
		{
			throw null;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00004646 File Offset: 0x00002846
		[global::Cpp2ILInjected.Token(Token = "0x6000922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF534", Offset = "0x1EFF534", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public string DownloadString(string address)
		{
			throw null;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00004649 File Offset: 0x00002849
		[global::Cpp2ILInjected.Token(Token = "0x6000923")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF550", Offset = "0x1EFF550", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetStringUsingEncoding", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public string DownloadString(Uri address)
		{
			throw null;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0000464C File Offset: 0x0000284C
		[global::Cpp2ILInjected.Token(Token = "0x6000924")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFC5C0", Offset = "0x1EFC5C0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<DownloadBitsAsync>d__150), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<UploadBitsAsync>d__152), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenRead", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "CancelAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void AbortRequest(WebRequest request)
		{
			throw null;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0000464F File Offset: 0x0000284F
		[global::Cpp2ILInjected.Token(Token = "0x6000925")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB410", Offset = "0x1EFB410", Length = "0x3BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetWebRequest", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "set_Accept", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "set_Connection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "set_Expect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "set_Referer", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "set_UserAgent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void CopyHeadersTo(WebRequest request)
		{
			throw null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00004652 File Offset: 0x00002852
		[global::Cpp2ILInjected.Token(Token = "0x6000926")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB93C", Offset = "0x1EFB93C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private Uri GetUri(string address)
		{
			throw null;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00004655 File Offset: 0x00002855
		[global::Cpp2ILInjected.Token(Token = "0x6000927")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFBE20", Offset = "0x1EFBE20", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenRead", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsAbsoluteUri", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Query", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = "set_Query", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private Uri GetUri(Uri address)
		{
			throw null;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00004658 File Offset: 0x00002858
		[global::Cpp2ILInjected.Token(Token = "0x6000928")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFC0C4", Offset = "0x1EFC0C4", Length = "0x4FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = "ToArray", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private byte[] DownloadBits(WebRequest request, Stream writeStream)
		{
			throw null;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0000465B File Offset: 0x0000285B
		[global::Cpp2ILInjected.Token(Token = "0x6000929")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF678", Offset = "0x1EFF678", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<UploadBitsAsync>d__152), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebClient.<DownloadBitsAsync>d__150) }, MemberParameters = new object[] { typeof(ref WebClient.<DownloadBitsAsync>d__150) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void DownloadBitsAsync(WebRequest request, Stream writeStream, AsyncOperation asyncOp, Action<byte[], Exception, AsyncOperation> completionDelegate)
		{
			throw null;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0000465E File Offset: 0x0000285E
		[global::Cpp2ILInjected.Token(Token = "0x600092A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD6F8", Offset = "0x1EFD6F8", Length = "0x634")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private byte[] UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer)
		{
			throw null;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00004661 File Offset: 0x00002861
		[global::Cpp2ILInjected.Token(Token = "0x600092B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF73C", Offset = "0x1EFF73C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebClient.<UploadBitsAsync>d__152) }, MemberParameters = new object[] { typeof(ref WebClient.<UploadBitsAsync>d__152) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UploadBitsAsync(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, AsyncOperation asyncOp, Action<byte[], Exception, AsyncOperation> completionDelegate)
		{
			throw null;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00004664 File Offset: 0x00002864
		[global::Cpp2ILInjected.Token(Token = "0x600092C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF820", Offset = "0x1EFF820", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetStringUsingEncoding", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private static bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray)
		{
			throw null;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00004667 File Offset: 0x00002867
		[global::Cpp2ILInjected.Token(Token = "0x600092D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF15C", Offset = "0x1EFF15C", Length = "0x3D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "<UploadStringAsync>b__179_0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ByteArrayHasPrefix", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private string GetStringUsingEncoding(WebRequest request, byte[] data)
		{
			throw null;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0000466A File Offset: 0x0000286A
		[global::Cpp2ILInjected.Token(Token = "0x600092E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD1C8", Offset = "0x1EFD1C8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsAbsoluteUri", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private string MapToDefaultMethod(Uri address)
		{
			throw null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0000466D File Offset: 0x0000286D
		[global::Cpp2ILInjected.Token(Token = "0x600092F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEAA4", Offset = "0x1EFEAA4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetValuesToUpload", MemberParameters = new object[] { typeof(NameValueCollection) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UrlEncodeBytesToBytesInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static string UrlEncode(string str)
		{
			throw null;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00004670 File Offset: 0x00002870
		[global::Cpp2ILInjected.Token(Token = "0x6000930")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF880", Offset = "0x1EFF880", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UrlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue)
		{
			throw null;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00004673 File Offset: 0x00002873
		[global::Cpp2ILInjected.Token(Token = "0x6000931")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFB74", Offset = "0x1EFFB74", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static char IntToHex(int n)
		{
			throw null;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00004676 File Offset: 0x00002876
		[global::Cpp2ILInjected.Token(Token = "0x6000932")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFB00", Offset = "0x1EFFB00", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsSafe(char ch)
		{
			throw null;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00004679 File Offset: 0x00002879
		[global::Cpp2ILInjected.Token(Token = "0x6000933")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFB8C", Offset = "0x1EFFB8C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass164_0), Member = "<OpenReadAsync>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass167_0), Member = "<OpenWriteAsync>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass182_0), Member = "<UploadDataAsync>b__0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass185_0), Member = "<UploadFileAsync>b__0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass188_0), Member = "<UploadValuesAsync>b__0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "<UploadStringAsync>b__179_0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "PostOperationCompleted", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void InvokeOperationCompleted(AsyncOperation asyncOp, SendOrPostCallback callback, AsyncCompletedEventArgs eventArgs)
		{
			throw null;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0000467C File Offset: 0x0000287C
		[global::Cpp2ILInjected.Token(Token = "0x6000934")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFBFC", Offset = "0x1EFFBFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OpenReadAsync(Uri address)
		{
			throw null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0000467F File Offset: 0x0000287F
		[global::Cpp2ILInjected.Token(Token = "0x6000935")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFC04", Offset = "0x1EFFC04", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void OpenReadAsync(Uri address, object userToken)
		{
			throw null;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00004682 File Offset: 0x00002882
		[global::Cpp2ILInjected.Token(Token = "0x6000936")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFFBC", Offset = "0x1EFFFBC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OpenWriteAsync(Uri address)
		{
			throw null;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00004685 File Offset: 0x00002885
		[global::Cpp2ILInjected.Token(Token = "0x6000937")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00278", Offset = "0x1F00278", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void OpenWriteAsync(Uri address, string method)
		{
			throw null;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00004688 File Offset: 0x00002888
		[global::Cpp2ILInjected.Token(Token = "0x6000938")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFFC8", Offset = "0x1EFFFC8", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void OpenWriteAsync(Uri address, string method, object userToken)
		{
			throw null;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0000468B File Offset: 0x0000288B
		[global::Cpp2ILInjected.Token(Token = "0x6000939")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F002C0", Offset = "0x1F002C0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetStringUsingEncoding", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void DownloadStringAsyncCallback(byte[] returnBytes, Exception exception, object state)
		{
			throw null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0000468E File Offset: 0x0000288E
		[global::Cpp2ILInjected.Token(Token = "0x600093A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F004B8", Offset = "0x1F004B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DownloadStringAsync(Uri address)
		{
			throw null;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00004691 File Offset: 0x00002891
		[global::Cpp2ILInjected.Token(Token = "0x600093B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F004C0", Offset = "0x1F004C0", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadBitsAsync", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(AsyncOperation),
			typeof(Action<byte[], Exception, AsyncOperation>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadStringAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void DownloadStringAsync(Uri address, object userToken)
		{
			throw null;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00004694 File Offset: 0x00002894
		[global::Cpp2ILInjected.Token(Token = "0x600093C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00700", Offset = "0x1F00700", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void DownloadDataAsyncCallback(byte[] returnBytes, Exception exception, object state)
		{
			throw null;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00004697 File Offset: 0x00002897
		[global::Cpp2ILInjected.Token(Token = "0x600093D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00800", Offset = "0x1F00800", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DownloadDataAsync(Uri address)
		{
			throw null;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0000469A File Offset: 0x0000289A
		[global::Cpp2ILInjected.Token(Token = "0x600093E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00808", Offset = "0x1F00808", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadBitsAsync", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(AsyncOperation),
			typeof(Action<byte[], Exception, AsyncOperation>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadDataAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void DownloadDataAsync(Uri address, object userToken)
		{
			throw null;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0000469D File Offset: 0x0000289D
		[global::Cpp2ILInjected.Token(Token = "0x600093F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00A48", Offset = "0x1F00A48", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void DownloadFileAsyncCallback(byte[] returnBytes, Exception exception, object state)
		{
			throw null;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000046A0 File Offset: 0x000028A0
		[global::Cpp2ILInjected.Token(Token = "0x6000940")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00B08", Offset = "0x1F00B08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DownloadFileAsync(Uri address, string fileName)
		{
			throw null;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000046A3 File Offset: 0x000028A3
		[global::Cpp2ILInjected.Token(Token = "0x6000941")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00B10", Offset = "0x1F00B10", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadBitsAsync", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(AsyncOperation),
			typeof(Action<byte[], Exception, AsyncOperation>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadFileAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void DownloadFileAsync(Uri address, string fileName, object userToken)
		{
			throw null;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000046A6 File Offset: 0x000028A6
		[global::Cpp2ILInjected.Token(Token = "0x6000942")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00DAC", Offset = "0x1F00DAC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UploadStringAsync(Uri address, string data)
		{
			throw null;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000046A9 File Offset: 0x000028A9
		[global::Cpp2ILInjected.Token(Token = "0x6000943")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0109C", Offset = "0x1F0109C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void UploadStringAsync(Uri address, string method, string data)
		{
			throw null;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000046AC File Offset: 0x000028AC
		[global::Cpp2ILInjected.Token(Token = "0x6000944")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00DBC", Offset = "0x1F00DBC", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadBitsAsync", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[]),
			typeof(AsyncOperation),
			typeof(Action<byte[], Exception, AsyncOperation>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void UploadStringAsync(Uri address, string method, string data, object userToken)
		{
			throw null;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000046AF File Offset: 0x000028AF
		[global::Cpp2ILInjected.Token(Token = "0x6000945")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F010DC", Offset = "0x1F010DC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UploadDataAsync(Uri address, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000046B2 File Offset: 0x000028B2
		[global::Cpp2ILInjected.Token(Token = "0x6000946")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01438", Offset = "0x1F01438", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void UploadDataAsync(Uri address, string method, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000046B5 File Offset: 0x000028B5
		[global::Cpp2ILInjected.Token(Token = "0x6000947")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F010EC", Offset = "0x1F010EC", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadBitsAsync", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[]),
			typeof(AsyncOperation),
			typeof(Action<byte[], Exception, AsyncOperation>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void UploadDataAsync(Uri address, string method, byte[] data, object userToken)
		{
			throw null;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000046B8 File Offset: 0x000028B8
		[global::Cpp2ILInjected.Token(Token = "0x6000948")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01480", Offset = "0x1F01480", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UploadFileAsync(Uri address, string fileName)
		{
			throw null;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000046BB File Offset: 0x000028BB
		[global::Cpp2ILInjected.Token(Token = "0x6000949")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0181C", Offset = "0x1F0181C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void UploadFileAsync(Uri address, string method, string fileName)
		{
			throw null;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000046BE File Offset: 0x000028BE
		[global::Cpp2ILInjected.Token(Token = "0x600094A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01490", Offset = "0x1F01490", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenFileInternal", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(ref FileStream),
			typeof(ref byte[]),
			typeof(ref byte[]),
			typeof(ref byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadBitsAsync", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[]),
			typeof(AsyncOperation),
			typeof(Action<byte[], Exception, AsyncOperation>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void UploadFileAsync(Uri address, string method, string fileName, object userToken)
		{
			throw null;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000046C1 File Offset: 0x000028C1
		[global::Cpp2ILInjected.Token(Token = "0x600094B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01864", Offset = "0x1F01864", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UploadValuesAsync(Uri address, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000046C4 File Offset: 0x000028C4
		[global::Cpp2ILInjected.Token(Token = "0x600094C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01BCC", Offset = "0x1F01BCC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void UploadValuesAsync(Uri address, string method, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000046C7 File Offset: 0x000028C7
		[global::Cpp2ILInjected.Token(Token = "0x600094D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01874", Offset = "0x1F01874", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "ThrowIfNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetValuesToUpload", MemberParameters = new object[] { typeof(NameValueCollection) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadBitsAsync", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[]),
			typeof(AsyncOperation),
			typeof(Action<byte[], Exception, AsyncOperation>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken)
		{
			throw null;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000046CA File Offset: 0x000028CA
		[global::Cpp2ILInjected.Token(Token = "0x600094E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFEA8", Offset = "0x1EFFEA8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<DownloadBitsAsync>d__150), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<UploadBitsAsync>d__152), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass164_0), Member = "<OpenReadAsync>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass167_0), Member = "<OpenWriteAsync>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "<UploadStringAsync>b__179_0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Exception GetExceptionToPropagate(Exception e)
		{
			throw null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000046CD File Offset: 0x000028CD
		[global::Cpp2ILInjected.Token(Token = "0x600094F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01C14", Offset = "0x1F01C14", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CancelAsync()
		{
			throw null;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000046D0 File Offset: 0x000028D0
		[global::Cpp2ILInjected.Token(Token = "0x6000950")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01C74", Offset = "0x1F01C74", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<string> DownloadStringTaskAsync(string address)
		{
			throw null;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000046D3 File Offset: 0x000028D3
		[global::Cpp2ILInjected.Token(Token = "0x6000951")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01C90", Offset = "0x1F01C90", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DownloadStringCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_DownloadStringCompleted", MemberParameters = new object[] { typeof(DownloadStringCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadStringCompleted", MemberParameters = new object[] { typeof(DownloadStringCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task<string> DownloadStringTaskAsync(Uri address)
		{
			throw null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000046D6 File Offset: 0x000028D6
		[global::Cpp2ILInjected.Token(Token = "0x6000952")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01F78", Offset = "0x1F01F78", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<Stream> OpenReadTaskAsync(string address)
		{
			throw null;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000046D9 File Offset: 0x000028D9
		[global::Cpp2ILInjected.Token(Token = "0x6000953")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01F94", Offset = "0x1F01F94", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OpenReadCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_OpenReadCompleted", MemberParameters = new object[] { typeof(OpenReadCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenReadAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_OpenReadCompleted", MemberParameters = new object[] { typeof(OpenReadCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task<Stream> OpenReadTaskAsync(Uri address)
		{
			throw null;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000046DC File Offset: 0x000028DC
		[global::Cpp2ILInjected.Token(Token = "0x6000954")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0227C", Offset = "0x1F0227C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<Stream> OpenWriteTaskAsync(string address)
		{
			throw null;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000046DF File Offset: 0x000028DF
		[global::Cpp2ILInjected.Token(Token = "0x6000955")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02454", Offset = "0x1F02454", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Task<Stream>))]
		public Task<Stream> OpenWriteTaskAsync(Uri address)
		{
			throw null;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000046E2 File Offset: 0x000028E2
		[global::Cpp2ILInjected.Token(Token = "0x6000956")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0245C", Offset = "0x1F0245C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Task<Stream>))]
		public Task<Stream> OpenWriteTaskAsync(string address, string method)
		{
			throw null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000046E5 File Offset: 0x000028E5
		[global::Cpp2ILInjected.Token(Token = "0x6000957")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0229C", Offset = "0x1F0229C", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OpenWriteCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_OpenWriteCompleted", MemberParameters = new object[] { typeof(OpenWriteCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_OpenWriteCompleted", MemberParameters = new object[] { typeof(OpenWriteCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task<Stream> OpenWriteTaskAsync(Uri address, string method)
		{
			throw null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000046E8 File Offset: 0x000028E8
		[global::Cpp2ILInjected.Token(Token = "0x6000958")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F025C0", Offset = "0x1F025C0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadStringTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<string>))]
		public Task<string> UploadStringTaskAsync(string address, string data)
		{
			throw null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000046EB File Offset: 0x000028EB
		[global::Cpp2ILInjected.Token(Token = "0x6000959")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02624", Offset = "0x1F02624", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Task<string> UploadStringTaskAsync(Uri address, string data)
		{
			throw null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000046EE File Offset: 0x000028EE
		[global::Cpp2ILInjected.Token(Token = "0x600095A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F025F0", Offset = "0x1F025F0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadStringTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<string>))]
		public Task<string> UploadStringTaskAsync(string address, string method, string data)
		{
			throw null;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000046F1 File Offset: 0x000028F1
		[global::Cpp2ILInjected.Token(Token = "0x600095B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02630", Offset = "0x1F02630", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UploadStringCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_UploadStringCompleted", MemberParameters = new object[] { typeof(UploadStringCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadStringCompleted", MemberParameters = new object[] { typeof(UploadStringCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task<string> UploadStringTaskAsync(Uri address, string method, string data)
		{
			throw null;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000046F4 File Offset: 0x000028F4
		[global::Cpp2ILInjected.Token(Token = "0x600095C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02930", Offset = "0x1F02930", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<byte[]> DownloadDataTaskAsync(string address)
		{
			throw null;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000046F7 File Offset: 0x000028F7
		[global::Cpp2ILInjected.Token(Token = "0x600095D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0294C", Offset = "0x1F0294C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DownloadDataCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_DownloadDataCompleted", MemberParameters = new object[] { typeof(DownloadDataCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadDataCompleted", MemberParameters = new object[] { typeof(DownloadDataCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task<byte[]> DownloadDataTaskAsync(Uri address)
		{
			throw null;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000046FA File Offset: 0x000028FA
		[global::Cpp2ILInjected.Token(Token = "0x600095E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02C34", Offset = "0x1F02C34", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task DownloadFileTaskAsync(string address, string fileName)
		{
			throw null;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000046FD File Offset: 0x000028FD
		[global::Cpp2ILInjected.Token(Token = "0x600095F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02C60", Offset = "0x1F02C60", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_DownloadFileCompleted", MemberParameters = new object[] { typeof(AsyncCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadFileCompleted", MemberParameters = new object[] { typeof(AsyncCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task DownloadFileTaskAsync(Uri address, string fileName)
		{
			throw null;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00004700 File Offset: 0x00002900
		[global::Cpp2ILInjected.Token(Token = "0x6000960")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02E24", Offset = "0x1F02E24", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<byte[]> UploadDataTaskAsync(string address, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00004703 File Offset: 0x00002903
		[global::Cpp2ILInjected.Token(Token = "0x6000961")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0301C", Offset = "0x1F0301C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(Task<byte[]>))]
		public Task<byte[]> UploadDataTaskAsync(Uri address, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00004706 File Offset: 0x00002906
		[global::Cpp2ILInjected.Token(Token = "0x6000962")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03028", Offset = "0x1F03028", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(Task<byte[]>))]
		public Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00004709 File Offset: 0x00002909
		[global::Cpp2ILInjected.Token(Token = "0x6000963")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02E54", Offset = "0x1F02E54", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(byte[])
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UploadDataCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_UploadDataCompleted", MemberParameters = new object[] { typeof(UploadDataCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadDataCompleted", MemberParameters = new object[] { typeof(UploadDataCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task<byte[]> UploadDataTaskAsync(Uri address, string method, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0000470C File Offset: 0x0000290C
		[global::Cpp2ILInjected.Token(Token = "0x6000964")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03194", Offset = "0x1F03194", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<byte[]> UploadFileTaskAsync(string address, string fileName)
		{
			throw null;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0000470F File Offset: 0x0000290F
		[global::Cpp2ILInjected.Token(Token = "0x6000965")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0338C", Offset = "0x1F0338C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<byte[]>))]
		public Task<byte[]> UploadFileTaskAsync(Uri address, string fileName)
		{
			throw null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00004712 File Offset: 0x00002912
		[global::Cpp2ILInjected.Token(Token = "0x6000966")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03398", Offset = "0x1F03398", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<byte[]>))]
		public Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName)
		{
			throw null;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00004715 File Offset: 0x00002915
		[global::Cpp2ILInjected.Token(Token = "0x6000967")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F031C4", Offset = "0x1F031C4", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UploadFileCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_UploadFileCompleted", MemberParameters = new object[] { typeof(UploadFileCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadFileCompleted", MemberParameters = new object[] { typeof(UploadFileCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task<byte[]> UploadFileTaskAsync(Uri address, string method, string fileName)
		{
			throw null;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00004718 File Offset: 0x00002918
		[global::Cpp2ILInjected.Token(Token = "0x6000968")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03504", Offset = "0x1F03504", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<byte[]> UploadValuesTaskAsync(string address, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0000471B File Offset: 0x0000291B
		[global::Cpp2ILInjected.Token(Token = "0x6000969")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F036FC", Offset = "0x1F036FC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(Task<byte[]>))]
		public Task<byte[]> UploadValuesTaskAsync(string address, string method, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0000471E File Offset: 0x0000291E
		[global::Cpp2ILInjected.Token(Token = "0x600096A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03730", Offset = "0x1F03730", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(Task<byte[]>))]
		public Task<byte[]> UploadValuesTaskAsync(Uri address, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00004721 File Offset: 0x00002921
		[global::Cpp2ILInjected.Token(Token = "0x600096B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03534", Offset = "0x1F03534", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(NameValueCollection)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<object>), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UploadValuesCompletedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "add_UploadValuesCompleted", MemberParameters = new object[] { typeof(UploadValuesCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadValuesCompleted", MemberParameters = new object[] { typeof(UploadValuesCompletedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public Task<byte[]> UploadValuesTaskAsync(Uri address, string method, NameValueCollection data)
		{
			throw null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00004724 File Offset: 0x00002924
		[global::Cpp2ILInjected.Token(Token = "0x600096C")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4538", Offset = "0x15A4538", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass192_0), Member = "<DownloadStringTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(DownloadStringCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass194_0), Member = "<OpenReadTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(OpenReadCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass198_0), Member = "<OpenWriteTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(OpenWriteCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass202_0), Member = "<UploadStringTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(UploadStringCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass204_0), Member = "<DownloadDataTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(DownloadDataCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass206_0), Member = "<DownloadFileTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass210_0), Member = "<UploadDataTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(UploadDataCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass214_0), Member = "<UploadFileTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(UploadFileCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<>c__DisplayClass218_0), Member = "<UploadValuesTaskAsync>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(UploadValuesCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void HandleCompletion<TAsyncCompletedEventArgs, TCompletionDelegate, T>(TaskCompletionSource<T> tcs, TAsyncCompletedEventArgs e, Func<TAsyncCompletedEventArgs, T> getResult, TCompletionDelegate handler, Action<WebClient, TCompletionDelegate> unregisterHandler) where TAsyncCompletedEventArgs : AsyncCompletedEventArgs
		{
			throw null;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00004727 File Offset: 0x00002927
		[global::Cpp2ILInjected.Token(Token = "0x600096D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03874", Offset = "0x1F03874", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<DownloadBitsAsync>d__150), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient.<UploadBitsAsync>d__152), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "Post", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void PostProgressChanged(AsyncOperation asyncOp, WebClient.ProgressData progress)
		{
			throw null;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0000472A File Offset: 0x0000292A
		[global::Cpp2ILInjected.Token(Token = "0x600096E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFAE64", Offset = "0x1EFAE64", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void ThrowIfNull(object argument, string parameterName)
		{
			throw null;
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0000472D File Offset: 0x0000292D
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00004730 File Offset: 0x00002930
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x170001F6")]
		public bool AllowReadStreamBuffering
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600096F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F03AA0", Offset = "0x1F03AA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000970")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F03AA8", Offset = "0x1F03AA8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00004733 File Offset: 0x00002933
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00004736 File Offset: 0x00002936
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x170001F7")]
		public bool AllowWriteStreamBuffering
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000971")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F03AB4", Offset = "0x1F03AB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000972")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F03ABC", Offset = "0x1F03ABC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060008A2 RID: 2210 RVA: 0x00004739 File Offset: 0x00002939
		// (remove) Token: 0x060008A3 RID: 2211 RVA: 0x0000473C File Offset: 0x0000293C
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x1400000C")]
		public event WriteStreamClosedEventHandler WriteStreamClosed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000973")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F03AC8", Offset = "0x1F03AC8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000974")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F03ACC", Offset = "0x1F03ACC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0000473F File Offset: 0x0000293F
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000975")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03AD0", Offset = "0x1F03AD0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnWriteStreamClosed(WriteStreamClosedEventArgs e)
		{
			throw null;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00004742 File Offset: 0x00002942
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000976")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03AD4", Offset = "0x1F03AD4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF32", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static WebClient()
		{
			throw null;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00004745 File Offset: 0x00002945
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000977")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03C44", Offset = "0x1F03C44", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_0(object arg)
		{
			throw null;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00004748 File Offset: 0x00002948
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000978")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03CD4", Offset = "0x1F03CD4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_1(object arg)
		{
			throw null;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0000474B File Offset: 0x0000294B
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000979")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03D64", Offset = "0x1F03D64", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_2(object arg)
		{
			throw null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0000474E File Offset: 0x0000294E
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600097A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03DF4", Offset = "0x1F03DF4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_3(object arg)
		{
			throw null;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00004751 File Offset: 0x00002951
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600097B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03E84", Offset = "0x1F03E84", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_4(object arg)
		{
			throw null;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00004754 File Offset: 0x00002954
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600097C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03F14", Offset = "0x1F03F14", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_5(object arg)
		{
			throw null;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00004757 File Offset: 0x00002957
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600097D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03FA4", Offset = "0x1F03FA4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_6(object arg)
		{
			throw null;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0000475A File Offset: 0x0000295A
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600097E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F04034", Offset = "0x1F04034", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_7(object arg)
		{
			throw null;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0000475D File Offset: 0x0000295D
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600097F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F040C4", Offset = "0x1F040C4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_8(object arg)
		{
			throw null;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00004760 File Offset: 0x00002960
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000980")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F04154", Offset = "0x1F04154", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_9(object arg)
		{
			throw null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00004763 File Offset: 0x00002963
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000981")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F041E4", Offset = "0x1F041E4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <StartAsyncOperation>b__78_10(object arg)
		{
			throw null;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00004766 File Offset: 0x00002966
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000982")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F04274", Offset = "0x1F04274", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetStringUsingEncoding", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void <UploadStringAsync>b__179_0(byte[] bytesResult, Exception error, AsyncOperation uploadAsyncOp)
		{
			throw null;
		}

		// Token: 0x0400055C RID: 1372
		[global::Cpp2ILInjected.Token(Token = "0x4000702")]
		private const int DefaultCopyBufferLength = 8192;

		// Token: 0x0400055D RID: 1373
		[global::Cpp2ILInjected.Token(Token = "0x4000703")]
		private const int DefaultDownloadBufferLength = 65536;

		// Token: 0x0400055E RID: 1374
		[global::Cpp2ILInjected.Token(Token = "0x4000704")]
		private const string DefaultUploadFileContentType = "application/octet-stream";

		// Token: 0x0400055F RID: 1375
		[global::Cpp2ILInjected.Token(Token = "0x4000705")]
		private const string UploadFileContentType = "multipart/form-data";

		// Token: 0x04000560 RID: 1376
		[global::Cpp2ILInjected.Token(Token = "0x4000706")]
		private const string UploadValuesContentType = "application/x-www-form-urlencoded";

		// Token: 0x04000561 RID: 1377
		[global::Cpp2ILInjected.Token(Token = "0x4000707")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Uri _baseAddress;

		// Token: 0x04000562 RID: 1378
		[global::Cpp2ILInjected.Token(Token = "0x4000708")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ICredentials _credentials;

		// Token: 0x04000563 RID: 1379
		[global::Cpp2ILInjected.Token(Token = "0x4000709")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private WebHeaderCollection _headers;

		// Token: 0x04000564 RID: 1380
		[global::Cpp2ILInjected.Token(Token = "0x400070A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private NameValueCollection _requestParameters;

		// Token: 0x04000565 RID: 1381
		[global::Cpp2ILInjected.Token(Token = "0x400070B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private WebResponse _webResponse;

		// Token: 0x04000566 RID: 1382
		[global::Cpp2ILInjected.Token(Token = "0x400070C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private WebRequest _webRequest;

		// Token: 0x04000567 RID: 1383
		[global::Cpp2ILInjected.Token(Token = "0x400070D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Encoding _encoding;

		// Token: 0x04000568 RID: 1384
		[global::Cpp2ILInjected.Token(Token = "0x400070E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string _method;

		// Token: 0x04000569 RID: 1385
		[global::Cpp2ILInjected.Token(Token = "0x400070F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private long _contentLength;

		// Token: 0x0400056A RID: 1386
		[global::Cpp2ILInjected.Token(Token = "0x4000710")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool _initWebClientAsync;

		// Token: 0x0400056B RID: 1387
		[global::Cpp2ILInjected.Token(Token = "0x4000711")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool _canceled;

		// Token: 0x0400056C RID: 1388
		[global::Cpp2ILInjected.Token(Token = "0x4000712")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private WebClient.ProgressData _progress;

		// Token: 0x0400056D RID: 1389
		[global::Cpp2ILInjected.Token(Token = "0x4000713")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private IWebProxy _proxy;

		// Token: 0x0400056E RID: 1390
		[global::Cpp2ILInjected.Token(Token = "0x4000714")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool _proxySet;

		// Token: 0x0400056F RID: 1391
		[global::Cpp2ILInjected.Token(Token = "0x4000715")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int _callNesting;

		// Token: 0x04000570 RID: 1392
		[global::Cpp2ILInjected.Token(Token = "0x4000716")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private AsyncOperation _asyncOp;

		// Token: 0x04000571 RID: 1393
		[global::Cpp2ILInjected.Token(Token = "0x4000717")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private SendOrPostCallback _downloadDataOperationCompleted;

		// Token: 0x04000572 RID: 1394
		[global::Cpp2ILInjected.Token(Token = "0x4000718")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private SendOrPostCallback _openReadOperationCompleted;

		// Token: 0x04000573 RID: 1395
		[global::Cpp2ILInjected.Token(Token = "0x4000719")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private SendOrPostCallback _openWriteOperationCompleted;

		// Token: 0x04000574 RID: 1396
		[global::Cpp2ILInjected.Token(Token = "0x400071A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private SendOrPostCallback _downloadStringOperationCompleted;

		// Token: 0x04000575 RID: 1397
		[global::Cpp2ILInjected.Token(Token = "0x400071B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private SendOrPostCallback _downloadFileOperationCompleted;

		// Token: 0x04000576 RID: 1398
		[global::Cpp2ILInjected.Token(Token = "0x400071C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private SendOrPostCallback _uploadStringOperationCompleted;

		// Token: 0x04000577 RID: 1399
		[global::Cpp2ILInjected.Token(Token = "0x400071D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private SendOrPostCallback _uploadDataOperationCompleted;

		// Token: 0x04000578 RID: 1400
		[global::Cpp2ILInjected.Token(Token = "0x400071E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private SendOrPostCallback _uploadFileOperationCompleted;

		// Token: 0x04000579 RID: 1401
		[global::Cpp2ILInjected.Token(Token = "0x400071F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private SendOrPostCallback _uploadValuesOperationCompleted;

		// Token: 0x0400057A RID: 1402
		[global::Cpp2ILInjected.Token(Token = "0x4000720")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private SendOrPostCallback _reportDownloadProgressChanged;

		// Token: 0x0400057B RID: 1403
		[global::Cpp2ILInjected.Token(Token = "0x4000721")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private SendOrPostCallback _reportUploadProgressChanged;

		// Token: 0x0400057C RID: 1404
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000722")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private DownloadStringCompletedEventHandler DownloadStringCompleted;

		// Token: 0x0400057D RID: 1405
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000723")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private DownloadDataCompletedEventHandler DownloadDataCompleted;

		// Token: 0x0400057E RID: 1406
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000724")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private AsyncCompletedEventHandler DownloadFileCompleted;

		// Token: 0x0400057F RID: 1407
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000725")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private UploadStringCompletedEventHandler UploadStringCompleted;

		// Token: 0x04000580 RID: 1408
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000726")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private UploadDataCompletedEventHandler UploadDataCompleted;

		// Token: 0x04000581 RID: 1409
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000727")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private UploadFileCompletedEventHandler UploadFileCompleted;

		// Token: 0x04000582 RID: 1410
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000728")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private UploadValuesCompletedEventHandler UploadValuesCompleted;

		// Token: 0x04000583 RID: 1411
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000729")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private OpenReadCompletedEventHandler OpenReadCompleted;

		// Token: 0x04000584 RID: 1412
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400072A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private OpenWriteCompletedEventHandler OpenWriteCompleted;

		// Token: 0x04000585 RID: 1413
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400072B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private DownloadProgressChangedEventHandler DownloadProgressChanged;

		// Token: 0x04000586 RID: 1414
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400072C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private UploadProgressChangedEventHandler UploadProgressChanged;

		// Token: 0x04000587 RID: 1415
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400072D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private RequestCachePolicy <CachePolicy>k__BackingField;

		// Token: 0x04000588 RID: 1416
		[global::Cpp2ILInjected.Token(Token = "0x400072E")]
		private static readonly char[] s_parseContentTypeSeparators;

		// Token: 0x04000589 RID: 1417
		[global::Cpp2ILInjected.Token(Token = "0x400072F")]
		private static readonly Encoding[] s_knownEncodings;

		// Token: 0x0400058A RID: 1418
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000730")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private bool <AllowReadStreamBuffering>k__BackingField;

		// Token: 0x0400058B RID: 1419
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000731")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x151")]
		private bool <AllowWriteStreamBuffering>k__BackingField;

		// Token: 0x020003D8 RID: 984
		[global::Cpp2ILInjected.Token(Token = "0x200015B")]
		private sealed class ProgressData
		{
			// Token: 0x06001D75 RID: 7541 RVA: 0x00008147 File Offset: 0x00006347
			[global::Cpp2ILInjected.Token(Token = "0x6000983")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFAAAC", Offset = "0x1EFAAAC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void Reset()
			{
				throw null;
			}

			// Token: 0x06001D76 RID: 7542 RVA: 0x0000814A File Offset: 0x0000634A
			[global::Cpp2ILInjected.Token(Token = "0x6000984")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFADC8", Offset = "0x1EFADC8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ProgressData()
			{
				throw null;
			}

			// Token: 0x04001157 RID: 4439
			[global::Cpp2ILInjected.Token(Token = "0x4000732")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal long BytesSent;

			// Token: 0x04001158 RID: 4440
			[global::Cpp2ILInjected.Token(Token = "0x4000733")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal long TotalBytesToSend;

			// Token: 0x04001159 RID: 4441
			[global::Cpp2ILInjected.Token(Token = "0x4000734")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal long BytesReceived;

			// Token: 0x0400115A RID: 4442
			[global::Cpp2ILInjected.Token(Token = "0x4000735")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal long TotalBytesToReceive;

			// Token: 0x0400115B RID: 4443
			[global::Cpp2ILInjected.Token(Token = "0x4000736")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal bool HasUploadPhase;
		}

		// Token: 0x020003D9 RID: 985
		[global::Cpp2ILInjected.Token(Token = "0x200015C")]
		private sealed class WebClientWriteStream : DelegatingStream
		{
			// Token: 0x06001D77 RID: 7543 RVA: 0x0000814D File Offset: 0x0000634D
			[global::Cpp2ILInjected.Token(Token = "0x6000985")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFD2E4", Offset = "0x1EFD2E4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			public WebClientWriteStream(Stream stream, WebRequest request, WebClient webClient)
			{
				throw null;
			}

			// Token: 0x06001D78 RID: 7544 RVA: 0x00008150 File Offset: 0x00006350
			[global::Cpp2ILInjected.Token(Token = "0x6000986")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0441C", Offset = "0x1F0441C", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			// Token: 0x0400115C RID: 4444
			[global::Cpp2ILInjected.Token(Token = "0x4000737")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private readonly WebRequest _request;

			// Token: 0x0400115D RID: 4445
			[global::Cpp2ILInjected.Token(Token = "0x4000738")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private readonly WebClient _webClient;
		}

		// Token: 0x020003DA RID: 986
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200015D")]
		[StructLayout(3)]
		private struct <GetWebResponseTaskAsync>d__112 : IAsyncStateMachine
		{
			// Token: 0x06001D79 RID: 7545 RVA: 0x00008153 File Offset: 0x00006353
			[global::Cpp2ILInjected.Token(Token = "0x6000987")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F044DC", Offset = "0x1F044DC", Length = "0x2B0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.BeginEndAwaitableAdapter", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.RendezvousAwaitable`1", Member = "GetAwaiter", ReturnType = "System.Threading.Tasks.RendezvousAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.RendezvousAwaitable`1", Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(object),
				typeof(WebClient.<GetWebResponseTaskAsync>d__112)
			}, MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(ref WebClient.<GetWebResponseTaskAsync>d__112)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.RendezvousAwaitable`1", Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D7A RID: 7546 RVA: 0x00008156 File Offset: 0x00006356
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000988")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0478C", Offset = "0x1F0478C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400115E RID: 4446
			[global::Cpp2ILInjected.Token(Token = "0x4000739")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400115F RID: 4447
			[global::Cpp2ILInjected.Token(Token = "0x400073A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebResponse> <>t__builder;

			// Token: 0x04001160 RID: 4448
			[global::Cpp2ILInjected.Token(Token = "0x400073B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequest request;

			// Token: 0x04001161 RID: 4449
			[global::Cpp2ILInjected.Token(Token = "0x400073C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebClient <>4__this;

			// Token: 0x04001162 RID: 4450
			[global::Cpp2ILInjected.Token(Token = "0x400073D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private WebRequest <>7__wrap1;

			// Token: 0x04001163 RID: 4451
			[global::Cpp2ILInjected.Token(Token = "0x400073E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private object <>u__1;
		}

		// Token: 0x020003DB RID: 987
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200015E")]
		[StructLayout(3)]
		private struct <DownloadBitsAsync>d__150 : IAsyncStateMachine
		{
			// Token: 0x06001D7B RID: 7547 RVA: 0x00008159 File Offset: 0x00006359
			[global::Cpp2ILInjected.Token(Token = "0x6000989")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F047E4", Offset = "0x1F047E4", Length = "0xCFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetWebResponseTaskAsync", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(Task<WebResponse>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "PostProgressChanged", MemberParameters = new object[]
			{
				typeof(AsyncOperation),
				"System.Net.WebClient.ProgressData"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter),
				typeof(WebClient.<DownloadBitsAsync>d__150)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter),
				typeof(ref WebClient.<DownloadBitsAsync>d__150)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter),
				typeof(WebClient.<DownloadBitsAsync>d__150)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter),
				typeof(ref WebClient.<DownloadBitsAsync>d__150)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = "ToArray", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 72)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D7C RID: 7548 RVA: 0x0000815C File Offset: 0x0000635C
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600098A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F054E0", Offset = "0x1F054E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001164 RID: 4452
			[global::Cpp2ILInjected.Token(Token = "0x400073F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001165 RID: 4453
			[global::Cpp2ILInjected.Token(Token = "0x4000740")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001166 RID: 4454
			[global::Cpp2ILInjected.Token(Token = "0x4000741")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebClient <>4__this;

			// Token: 0x04001167 RID: 4455
			[global::Cpp2ILInjected.Token(Token = "0x4000742")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public WebRequest request;

			// Token: 0x04001168 RID: 4456
			[global::Cpp2ILInjected.Token(Token = "0x4000743")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public Stream writeStream;

			// Token: 0x04001169 RID: 4457
			[global::Cpp2ILInjected.Token(Token = "0x4000744")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public AsyncOperation asyncOp;

			// Token: 0x0400116A RID: 4458
			[global::Cpp2ILInjected.Token(Token = "0x4000745")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public Action<byte[], Exception, AsyncOperation> completionDelegate;

			// Token: 0x0400116B RID: 4459
			[global::Cpp2ILInjected.Token(Token = "0x4000746")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private Exception <exception>5__2;

			// Token: 0x0400116C RID: 4460
			[global::Cpp2ILInjected.Token(Token = "0x4000747")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private byte[] <copyBuffer>5__3;

			// Token: 0x0400116D RID: 4461
			[global::Cpp2ILInjected.Token(Token = "0x4000748")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x0400116E RID: 4462
			[global::Cpp2ILInjected.Token(Token = "0x4000749")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Stream <>7__wrap3;

			// Token: 0x0400116F RID: 4463
			[global::Cpp2ILInjected.Token(Token = "0x400074A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Stream <readStream>5__5;

			// Token: 0x04001170 RID: 4464
			[global::Cpp2ILInjected.Token(Token = "0x400074B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter <>u__2;

			// Token: 0x04001171 RID: 4465
			[global::Cpp2ILInjected.Token(Token = "0x400074C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__3;
		}

		// Token: 0x020003DC RID: 988
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200015F")]
		[StructLayout(3)]
		private struct <UploadBitsAsync>d__152 : IAsyncStateMachine
		{
			// Token: 0x06001D7D RID: 7549 RVA: 0x0000815F File Offset: 0x0000635F
			[global::Cpp2ILInjected.Token(Token = "0x600098B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F054EC", Offset = "0x1F054EC", Length = "0x1434")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(WebClient.<UploadBitsAsync>d__152)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref WebClient.<UploadBitsAsync>d__152)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "PostProgressChanged", MemberParameters = new object[]
			{
				typeof(AsyncOperation),
				"System.Net.WebClient.ProgressData"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter),
				typeof(WebClient.<UploadBitsAsync>d__152)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter),
				typeof(ref WebClient.<UploadBitsAsync>d__152)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter),
				typeof(WebClient.<UploadBitsAsync>d__152)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter),
				typeof(ref WebClient.<UploadBitsAsync>d__152)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadBitsAsync", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(Stream),
				typeof(AsyncOperation),
				typeof(Action<byte[], Exception, AsyncOperation>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 87)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D7E RID: 7550 RVA: 0x00008162 File Offset: 0x00006362
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600098C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F06920", Offset = "0x1F06920", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001172 RID: 4466
			[global::Cpp2ILInjected.Token(Token = "0x400074D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001173 RID: 4467
			[global::Cpp2ILInjected.Token(Token = "0x400074E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001174 RID: 4468
			[global::Cpp2ILInjected.Token(Token = "0x400074F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebClient <>4__this;

			// Token: 0x04001175 RID: 4469
			[global::Cpp2ILInjected.Token(Token = "0x4000750")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public WebRequest request;

			// Token: 0x04001176 RID: 4470
			[global::Cpp2ILInjected.Token(Token = "0x4000751")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public byte[] header;

			// Token: 0x04001177 RID: 4471
			[global::Cpp2ILInjected.Token(Token = "0x4000752")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public byte[] footer;

			// Token: 0x04001178 RID: 4472
			[global::Cpp2ILInjected.Token(Token = "0x4000753")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public AsyncOperation asyncOp;

			// Token: 0x04001179 RID: 4473
			[global::Cpp2ILInjected.Token(Token = "0x4000754")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public Stream readStream;

			// Token: 0x0400117A RID: 4474
			[global::Cpp2ILInjected.Token(Token = "0x4000755")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public byte[] buffer;

			// Token: 0x0400117B RID: 4475
			[global::Cpp2ILInjected.Token(Token = "0x4000756")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public int chunkSize;

			// Token: 0x0400117C RID: 4476
			[global::Cpp2ILInjected.Token(Token = "0x4000757")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public Action<byte[], Exception, AsyncOperation> completionDelegate;

			// Token: 0x0400117D RID: 4477
			[global::Cpp2ILInjected.Token(Token = "0x4000758")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Exception <exception>5__2;

			// Token: 0x0400117E RID: 4478
			[global::Cpp2ILInjected.Token(Token = "0x4000759")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Stream <writeStream>5__3;

			// Token: 0x0400117F RID: 4479
			[global::Cpp2ILInjected.Token(Token = "0x400075A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04001180 RID: 4480
			[global::Cpp2ILInjected.Token(Token = "0x400075B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2;

			// Token: 0x04001181 RID: 4481
			[global::Cpp2ILInjected.Token(Token = "0x400075C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			private Stream <>7__wrap3;

			// Token: 0x04001182 RID: 4482
			[global::Cpp2ILInjected.Token(Token = "0x400075D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			private int <bytesRead>5__5;

			// Token: 0x04001183 RID: 4483
			[global::Cpp2ILInjected.Token(Token = "0x400075E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter <>u__3;

			// Token: 0x04001184 RID: 4484
			[global::Cpp2ILInjected.Token(Token = "0x400075F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			private int <toWrite>5__6;
		}

		// Token: 0x020003DD RID: 989
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000160")]
		private sealed class <>c__DisplayClass164_0
		{
			// Token: 0x06001D7F RID: 7551 RVA: 0x00008165 File Offset: 0x00006365
			[global::Cpp2ILInjected.Token(Token = "0x600098D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFFEA0", Offset = "0x1EFFEA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass164_0()
			{
				throw null;
			}

			// Token: 0x06001D80 RID: 7552 RVA: 0x00008168 File Offset: 0x00006368
			[global::Cpp2ILInjected.Token(Token = "0x600098E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0692C", Offset = "0x1F0692C", Length = "0x1C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Exception),
				typeof(bool),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
			{
				typeof(AsyncOperation),
				typeof(SendOrPostCallback),
				typeof(AsyncCompletedEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			internal void <OpenReadAsync>b__0(IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x04001185 RID: 4485
			[global::Cpp2ILInjected.Token(Token = "0x4000760")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x04001186 RID: 4486
			[global::Cpp2ILInjected.Token(Token = "0x4000761")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;

			// Token: 0x04001187 RID: 4487
			[global::Cpp2ILInjected.Token(Token = "0x4000762")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequest request;
		}

		// Token: 0x020003DE RID: 990
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000161")]
		private sealed class <>c__DisplayClass167_0
		{
			// Token: 0x06001D81 RID: 7553 RVA: 0x0000816B File Offset: 0x0000636B
			[global::Cpp2ILInjected.Token(Token = "0x600098F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F00280", Offset = "0x1F00280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass167_0()
			{
				throw null;
			}

			// Token: 0x06001D82 RID: 7554 RVA: 0x0000816E File Offset: 0x0000636E
			[global::Cpp2ILInjected.Token(Token = "0x6000990")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F06AEC", Offset = "0x1F06AEC", Length = "0x1DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Exception),
				typeof(bool),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
			{
				typeof(AsyncOperation),
				typeof(SendOrPostCallback),
				typeof(AsyncCompletedEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal void <OpenWriteAsync>b__0(IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x04001188 RID: 4488
			[global::Cpp2ILInjected.Token(Token = "0x4000763")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x04001189 RID: 4489
			[global::Cpp2ILInjected.Token(Token = "0x4000764")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;

			// Token: 0x0400118A RID: 4490
			[global::Cpp2ILInjected.Token(Token = "0x4000765")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequest request;
		}

		// Token: 0x020003DF RID: 991
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000162")]
		private sealed class <>c__DisplayClass182_0
		{
			// Token: 0x06001D83 RID: 7555 RVA: 0x00008171 File Offset: 0x00006371
			[global::Cpp2ILInjected.Token(Token = "0x6000991")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F01440", Offset = "0x1F01440", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass182_0()
			{
				throw null;
			}

			// Token: 0x06001D84 RID: 7556 RVA: 0x00008174 File Offset: 0x00006374
			[global::Cpp2ILInjected.Token(Token = "0x6000992")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F06CC8", Offset = "0x1F06CC8", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Exception),
				typeof(bool),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
			{
				typeof(AsyncOperation),
				typeof(SendOrPostCallback),
				typeof(AsyncCompletedEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <UploadDataAsync>b__0(byte[] result, Exception error, AsyncOperation uploadAsyncOp)
			{
				throw null;
			}

			// Token: 0x0400118B RID: 4491
			[global::Cpp2ILInjected.Token(Token = "0x4000766")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x0400118C RID: 4492
			[global::Cpp2ILInjected.Token(Token = "0x4000767")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;
		}

		// Token: 0x020003E0 RID: 992
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000163")]
		private sealed class <>c__DisplayClass185_0
		{
			// Token: 0x06001D85 RID: 7557 RVA: 0x00008177 File Offset: 0x00006377
			[global::Cpp2ILInjected.Token(Token = "0x6000993")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F01824", Offset = "0x1F01824", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass185_0()
			{
				throw null;
			}

			// Token: 0x06001D86 RID: 7558 RVA: 0x0000817A File Offset: 0x0000637A
			[global::Cpp2ILInjected.Token(Token = "0x6000994")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F06D70", Offset = "0x1F06D70", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Exception),
				typeof(bool),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
			{
				typeof(AsyncOperation),
				typeof(SendOrPostCallback),
				typeof(AsyncCompletedEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <UploadFileAsync>b__0(byte[] result, Exception error, AsyncOperation uploadAsyncOp)
			{
				throw null;
			}

			// Token: 0x0400118D RID: 4493
			[global::Cpp2ILInjected.Token(Token = "0x4000768")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x0400118E RID: 4494
			[global::Cpp2ILInjected.Token(Token = "0x4000769")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;
		}

		// Token: 0x020003E1 RID: 993
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000164")]
		private sealed class <>c__DisplayClass188_0
		{
			// Token: 0x06001D87 RID: 7559 RVA: 0x0000817D File Offset: 0x0000637D
			[global::Cpp2ILInjected.Token(Token = "0x6000995")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F01BD4", Offset = "0x1F01BD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass188_0()
			{
				throw null;
			}

			// Token: 0x06001D88 RID: 7560 RVA: 0x00008180 File Offset: 0x00006380
			[global::Cpp2ILInjected.Token(Token = "0x6000996")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F06E18", Offset = "0x1F06E18", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Exception),
				typeof(bool),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
			{
				typeof(AsyncOperation),
				typeof(SendOrPostCallback),
				typeof(AsyncCompletedEventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <UploadValuesAsync>b__0(byte[] result, Exception error, AsyncOperation uploadAsyncOp)
			{
				throw null;
			}

			// Token: 0x0400118F RID: 4495
			[global::Cpp2ILInjected.Token(Token = "0x400076A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x04001190 RID: 4496
			[global::Cpp2ILInjected.Token(Token = "0x400076B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;
		}

		// Token: 0x020003E2 RID: 994
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000165")]
		private sealed class <>c__DisplayClass192_0
		{
			// Token: 0x06001D89 RID: 7561 RVA: 0x00008183 File Offset: 0x00006383
			[global::Cpp2ILInjected.Token(Token = "0x6000997")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F01E40", Offset = "0x1F01E40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass192_0()
			{
				throw null;
			}

			// Token: 0x06001D8A RID: 7562 RVA: 0x00008186 File Offset: 0x00006386
			[global::Cpp2ILInjected.Token(Token = "0x6000998")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F06EC0", Offset = "0x1F06EC0", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <DownloadStringTaskAsync>b__0(object sender, DownloadStringCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x04001191 RID: 4497
			[global::Cpp2ILInjected.Token(Token = "0x400076C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x04001192 RID: 4498
			[global::Cpp2ILInjected.Token(Token = "0x400076D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<string> tcs;

			// Token: 0x04001193 RID: 4499
			[global::Cpp2ILInjected.Token(Token = "0x400076E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public DownloadStringCompletedEventHandler handler;
		}

		// Token: 0x020003E3 RID: 995
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000166")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001D8B RID: 7563 RVA: 0x00008189 File Offset: 0x00006389
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000999")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07068", Offset = "0x1F07068", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06001D8C RID: 7564 RVA: 0x0000818C File Offset: 0x0000638C
			[global::Cpp2ILInjected.Token(Token = "0x600099A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F070C4", Offset = "0x1F070C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06001D8D RID: 7565 RVA: 0x0000818F File Offset: 0x0000638F
			[global::Cpp2ILInjected.Token(Token = "0x600099B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F070CC", Offset = "0x1F070CC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal string <DownloadStringTaskAsync>b__192_1(DownloadStringCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D8E RID: 7566 RVA: 0x00008192 File Offset: 0x00006392
			[global::Cpp2ILInjected.Token(Token = "0x600099C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07108", Offset = "0x1F07108", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadStringCompleted", MemberParameters = new object[] { typeof(DownloadStringCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <DownloadStringTaskAsync>b__192_2(WebClient webClient, DownloadStringCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x06001D8F RID: 7567 RVA: 0x00008195 File Offset: 0x00006395
			[global::Cpp2ILInjected.Token(Token = "0x600099D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07114", Offset = "0x1F07114", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal Stream <OpenReadTaskAsync>b__194_1(OpenReadCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D90 RID: 7568 RVA: 0x00008198 File Offset: 0x00006398
			[global::Cpp2ILInjected.Token(Token = "0x600099E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07150", Offset = "0x1F07150", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_OpenReadCompleted", MemberParameters = new object[] { typeof(OpenReadCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <OpenReadTaskAsync>b__194_2(WebClient webClient, OpenReadCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x06001D91 RID: 7569 RVA: 0x0000819B File Offset: 0x0000639B
			[global::Cpp2ILInjected.Token(Token = "0x600099F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0715C", Offset = "0x1F0715C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal Stream <OpenWriteTaskAsync>b__198_1(OpenWriteCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D92 RID: 7570 RVA: 0x0000819E File Offset: 0x0000639E
			[global::Cpp2ILInjected.Token(Token = "0x60009A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07198", Offset = "0x1F07198", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_OpenWriteCompleted", MemberParameters = new object[] { typeof(OpenWriteCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <OpenWriteTaskAsync>b__198_2(WebClient webClient, OpenWriteCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x06001D93 RID: 7571 RVA: 0x000081A1 File Offset: 0x000063A1
			[global::Cpp2ILInjected.Token(Token = "0x60009A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F071A4", Offset = "0x1F071A4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal string <UploadStringTaskAsync>b__202_1(UploadStringCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D94 RID: 7572 RVA: 0x000081A4 File Offset: 0x000063A4
			[global::Cpp2ILInjected.Token(Token = "0x60009A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F071E0", Offset = "0x1F071E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadStringCompleted", MemberParameters = new object[] { typeof(UploadStringCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <UploadStringTaskAsync>b__202_2(WebClient webClient, UploadStringCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x06001D95 RID: 7573 RVA: 0x000081A7 File Offset: 0x000063A7
			[global::Cpp2ILInjected.Token(Token = "0x60009A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F071EC", Offset = "0x1F071EC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal byte[] <DownloadDataTaskAsync>b__204_1(DownloadDataCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D96 RID: 7574 RVA: 0x000081AA File Offset: 0x000063AA
			[global::Cpp2ILInjected.Token(Token = "0x60009A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07228", Offset = "0x1F07228", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadDataCompleted", MemberParameters = new object[] { typeof(DownloadDataCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <DownloadDataTaskAsync>b__204_2(WebClient webClient, DownloadDataCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x06001D97 RID: 7575 RVA: 0x000081AD File Offset: 0x000063AD
			[global::Cpp2ILInjected.Token(Token = "0x60009A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07234", Offset = "0x1F07234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal object <DownloadFileTaskAsync>b__206_1(AsyncCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D98 RID: 7576 RVA: 0x000081B0 File Offset: 0x000063B0
			[global::Cpp2ILInjected.Token(Token = "0x60009A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0723C", Offset = "0x1F0723C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadFileCompleted", MemberParameters = new object[] { typeof(AsyncCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <DownloadFileTaskAsync>b__206_2(WebClient webClient, AsyncCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x06001D99 RID: 7577 RVA: 0x000081B3 File Offset: 0x000063B3
			[global::Cpp2ILInjected.Token(Token = "0x60009A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07248", Offset = "0x1F07248", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal byte[] <UploadDataTaskAsync>b__210_1(UploadDataCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D9A RID: 7578 RVA: 0x000081B6 File Offset: 0x000063B6
			[global::Cpp2ILInjected.Token(Token = "0x60009A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07284", Offset = "0x1F07284", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadDataCompleted", MemberParameters = new object[] { typeof(UploadDataCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <UploadDataTaskAsync>b__210_2(WebClient webClient, UploadDataCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x06001D9B RID: 7579 RVA: 0x000081B9 File Offset: 0x000063B9
			[global::Cpp2ILInjected.Token(Token = "0x60009A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07290", Offset = "0x1F07290", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal byte[] <UploadFileTaskAsync>b__214_1(UploadFileCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D9C RID: 7580 RVA: 0x000081BC File Offset: 0x000063BC
			[global::Cpp2ILInjected.Token(Token = "0x60009AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F072CC", Offset = "0x1F072CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadFileCompleted", MemberParameters = new object[] { typeof(UploadFileCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <UploadFileTaskAsync>b__214_2(WebClient webClient, UploadFileCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x06001D9D RID: 7581 RVA: 0x000081BF File Offset: 0x000063BF
			[global::Cpp2ILInjected.Token(Token = "0x60009AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F072D8", Offset = "0x1F072D8", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal byte[] <UploadValuesTaskAsync>b__218_1(UploadValuesCompletedEventArgs args)
			{
				throw null;
			}

			// Token: 0x06001D9E RID: 7582 RVA: 0x000081C2 File Offset: 0x000063C2
			[global::Cpp2ILInjected.Token(Token = "0x60009AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07314", Offset = "0x1F07314", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadValuesCompleted", MemberParameters = new object[] { typeof(UploadValuesCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <UploadValuesTaskAsync>b__218_2(WebClient webClient, UploadValuesCompletedEventHandler completion)
			{
				throw null;
			}

			// Token: 0x04001194 RID: 4500
			[global::Cpp2ILInjected.Token(Token = "0x400076F")]
			public static readonly WebClient.<>c <>9;

			// Token: 0x04001195 RID: 4501
			[global::Cpp2ILInjected.Token(Token = "0x4000770")]
			public static Func<DownloadStringCompletedEventArgs, string> <>9__192_1;

			// Token: 0x04001196 RID: 4502
			[global::Cpp2ILInjected.Token(Token = "0x4000771")]
			public static Action<WebClient, DownloadStringCompletedEventHandler> <>9__192_2;

			// Token: 0x04001197 RID: 4503
			[global::Cpp2ILInjected.Token(Token = "0x4000772")]
			public static Func<OpenReadCompletedEventArgs, Stream> <>9__194_1;

			// Token: 0x04001198 RID: 4504
			[global::Cpp2ILInjected.Token(Token = "0x4000773")]
			public static Action<WebClient, OpenReadCompletedEventHandler> <>9__194_2;

			// Token: 0x04001199 RID: 4505
			[global::Cpp2ILInjected.Token(Token = "0x4000774")]
			public static Func<OpenWriteCompletedEventArgs, Stream> <>9__198_1;

			// Token: 0x0400119A RID: 4506
			[global::Cpp2ILInjected.Token(Token = "0x4000775")]
			public static Action<WebClient, OpenWriteCompletedEventHandler> <>9__198_2;

			// Token: 0x0400119B RID: 4507
			[global::Cpp2ILInjected.Token(Token = "0x4000776")]
			public static Func<UploadStringCompletedEventArgs, string> <>9__202_1;

			// Token: 0x0400119C RID: 4508
			[global::Cpp2ILInjected.Token(Token = "0x4000777")]
			public static Action<WebClient, UploadStringCompletedEventHandler> <>9__202_2;

			// Token: 0x0400119D RID: 4509
			[global::Cpp2ILInjected.Token(Token = "0x4000778")]
			public static Func<DownloadDataCompletedEventArgs, byte[]> <>9__204_1;

			// Token: 0x0400119E RID: 4510
			[global::Cpp2ILInjected.Token(Token = "0x4000779")]
			public static Action<WebClient, DownloadDataCompletedEventHandler> <>9__204_2;

			// Token: 0x0400119F RID: 4511
			[global::Cpp2ILInjected.Token(Token = "0x400077A")]
			public static Func<AsyncCompletedEventArgs, object> <>9__206_1;

			// Token: 0x040011A0 RID: 4512
			[global::Cpp2ILInjected.Token(Token = "0x400077B")]
			public static Action<WebClient, AsyncCompletedEventHandler> <>9__206_2;

			// Token: 0x040011A1 RID: 4513
			[global::Cpp2ILInjected.Token(Token = "0x400077C")]
			public static Func<UploadDataCompletedEventArgs, byte[]> <>9__210_1;

			// Token: 0x040011A2 RID: 4514
			[global::Cpp2ILInjected.Token(Token = "0x400077D")]
			public static Action<WebClient, UploadDataCompletedEventHandler> <>9__210_2;

			// Token: 0x040011A3 RID: 4515
			[global::Cpp2ILInjected.Token(Token = "0x400077E")]
			public static Func<UploadFileCompletedEventArgs, byte[]> <>9__214_1;

			// Token: 0x040011A4 RID: 4516
			[global::Cpp2ILInjected.Token(Token = "0x400077F")]
			public static Action<WebClient, UploadFileCompletedEventHandler> <>9__214_2;

			// Token: 0x040011A5 RID: 4517
			[global::Cpp2ILInjected.Token(Token = "0x4000780")]
			public static Func<UploadValuesCompletedEventArgs, byte[]> <>9__218_1;

			// Token: 0x040011A6 RID: 4518
			[global::Cpp2ILInjected.Token(Token = "0x4000781")]
			public static Action<WebClient, UploadValuesCompletedEventHandler> <>9__218_2;
		}

		// Token: 0x020003E4 RID: 996
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000167")]
		private sealed class <>c__DisplayClass194_0
		{
			// Token: 0x06001D9F RID: 7583 RVA: 0x000081C5 File Offset: 0x000063C5
			[global::Cpp2ILInjected.Token(Token = "0x60009AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F02144", Offset = "0x1F02144", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass194_0()
			{
				throw null;
			}

			// Token: 0x06001DA0 RID: 7584 RVA: 0x000081C8 File Offset: 0x000063C8
			[global::Cpp2ILInjected.Token(Token = "0x60009AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07320", Offset = "0x1F07320", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <OpenReadTaskAsync>b__0(object sender, OpenReadCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x040011A7 RID: 4519
			[global::Cpp2ILInjected.Token(Token = "0x4000782")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x040011A8 RID: 4520
			[global::Cpp2ILInjected.Token(Token = "0x4000783")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<Stream> tcs;

			// Token: 0x040011A9 RID: 4521
			[global::Cpp2ILInjected.Token(Token = "0x4000784")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public OpenReadCompletedEventHandler handler;
		}

		// Token: 0x020003E5 RID: 997
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000168")]
		private sealed class <>c__DisplayClass198_0
		{
			// Token: 0x06001DA1 RID: 7585 RVA: 0x000081CB File Offset: 0x000063CB
			[global::Cpp2ILInjected.Token(Token = "0x60009AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F02488", Offset = "0x1F02488", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass198_0()
			{
				throw null;
			}

			// Token: 0x06001DA2 RID: 7586 RVA: 0x000081CE File Offset: 0x000063CE
			[global::Cpp2ILInjected.Token(Token = "0x60009B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F074C8", Offset = "0x1F074C8", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <OpenWriteTaskAsync>b__0(object sender, OpenWriteCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x040011AA RID: 4522
			[global::Cpp2ILInjected.Token(Token = "0x4000785")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x040011AB RID: 4523
			[global::Cpp2ILInjected.Token(Token = "0x4000786")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<Stream> tcs;

			// Token: 0x040011AC RID: 4524
			[global::Cpp2ILInjected.Token(Token = "0x4000787")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public OpenWriteCompletedEventHandler handler;
		}

		// Token: 0x020003E6 RID: 998
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000169")]
		private sealed class <>c__DisplayClass202_0
		{
			// Token: 0x06001DA3 RID: 7587 RVA: 0x000081D1 File Offset: 0x000063D1
			[global::Cpp2ILInjected.Token(Token = "0x60009B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F027F8", Offset = "0x1F027F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass202_0()
			{
				throw null;
			}

			// Token: 0x06001DA4 RID: 7588 RVA: 0x000081D4 File Offset: 0x000063D4
			[global::Cpp2ILInjected.Token(Token = "0x60009B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07670", Offset = "0x1F07670", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <UploadStringTaskAsync>b__0(object sender, UploadStringCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x040011AD RID: 4525
			[global::Cpp2ILInjected.Token(Token = "0x4000788")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x040011AE RID: 4526
			[global::Cpp2ILInjected.Token(Token = "0x4000789")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<string> tcs;

			// Token: 0x040011AF RID: 4527
			[global::Cpp2ILInjected.Token(Token = "0x400078A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UploadStringCompletedEventHandler handler;
		}

		// Token: 0x020003E7 RID: 999
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016A")]
		private sealed class <>c__DisplayClass204_0
		{
			// Token: 0x06001DA5 RID: 7589 RVA: 0x000081D7 File Offset: 0x000063D7
			[global::Cpp2ILInjected.Token(Token = "0x60009B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F02AFC", Offset = "0x1F02AFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass204_0()
			{
				throw null;
			}

			// Token: 0x06001DA6 RID: 7590 RVA: 0x000081DA File Offset: 0x000063DA
			[global::Cpp2ILInjected.Token(Token = "0x60009B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07818", Offset = "0x1F07818", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <DownloadDataTaskAsync>b__0(object sender, DownloadDataCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x040011B0 RID: 4528
			[global::Cpp2ILInjected.Token(Token = "0x400078B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x040011B1 RID: 4529
			[global::Cpp2ILInjected.Token(Token = "0x400078C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<byte[]> tcs;

			// Token: 0x040011B2 RID: 4530
			[global::Cpp2ILInjected.Token(Token = "0x400078D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public DownloadDataCompletedEventHandler handler;
		}

		// Token: 0x020003E8 RID: 1000
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016B")]
		private sealed class <>c__DisplayClass206_0
		{
			// Token: 0x06001DA7 RID: 7591 RVA: 0x000081DD File Offset: 0x000063DD
			[global::Cpp2ILInjected.Token(Token = "0x60009B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F02E1C", Offset = "0x1F02E1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass206_0()
			{
				throw null;
			}

			// Token: 0x06001DA8 RID: 7592 RVA: 0x000081E0 File Offset: 0x000063E0
			[global::Cpp2ILInjected.Token(Token = "0x60009B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F079C0", Offset = "0x1F079C0", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <DownloadFileTaskAsync>b__0(object sender, AsyncCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x040011B3 RID: 4531
			[global::Cpp2ILInjected.Token(Token = "0x400078E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x040011B4 RID: 4532
			[global::Cpp2ILInjected.Token(Token = "0x400078F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<object> tcs;

			// Token: 0x040011B5 RID: 4533
			[global::Cpp2ILInjected.Token(Token = "0x4000790")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public AsyncCompletedEventHandler handler;
		}

		// Token: 0x020003E9 RID: 1001
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016C")]
		private sealed class <>c__DisplayClass210_0
		{
			// Token: 0x06001DA9 RID: 7593 RVA: 0x000081E3 File Offset: 0x000063E3
			[global::Cpp2ILInjected.Token(Token = "0x60009B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0305C", Offset = "0x1F0305C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass210_0()
			{
				throw null;
			}

			// Token: 0x06001DAA RID: 7594 RVA: 0x000081E6 File Offset: 0x000063E6
			[global::Cpp2ILInjected.Token(Token = "0x60009B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07B68", Offset = "0x1F07B68", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <UploadDataTaskAsync>b__0(object sender, UploadDataCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x040011B6 RID: 4534
			[global::Cpp2ILInjected.Token(Token = "0x4000791")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x040011B7 RID: 4535
			[global::Cpp2ILInjected.Token(Token = "0x4000792")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<byte[]> tcs;

			// Token: 0x040011B8 RID: 4536
			[global::Cpp2ILInjected.Token(Token = "0x4000793")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UploadDataCompletedEventHandler handler;
		}

		// Token: 0x020003EA RID: 1002
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016D")]
		private sealed class <>c__DisplayClass214_0
		{
			// Token: 0x06001DAB RID: 7595 RVA: 0x000081E9 File Offset: 0x000063E9
			[global::Cpp2ILInjected.Token(Token = "0x60009B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F033CC", Offset = "0x1F033CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass214_0()
			{
				throw null;
			}

			// Token: 0x06001DAC RID: 7596 RVA: 0x000081EC File Offset: 0x000063EC
			[global::Cpp2ILInjected.Token(Token = "0x60009BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07D10", Offset = "0x1F07D10", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <UploadFileTaskAsync>b__0(object sender, UploadFileCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x040011B9 RID: 4537
			[global::Cpp2ILInjected.Token(Token = "0x4000794")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x040011BA RID: 4538
			[global::Cpp2ILInjected.Token(Token = "0x4000795")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<byte[]> tcs;

			// Token: 0x040011BB RID: 4539
			[global::Cpp2ILInjected.Token(Token = "0x4000796")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UploadFileCompletedEventHandler handler;
		}

		// Token: 0x020003EB RID: 1003
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016E")]
		private sealed class <>c__DisplayClass218_0
		{
			// Token: 0x06001DAD RID: 7597 RVA: 0x000081EF File Offset: 0x000063EF
			[global::Cpp2ILInjected.Token(Token = "0x60009BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0373C", Offset = "0x1F0373C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass218_0()
			{
				throw null;
			}

			// Token: 0x06001DAE RID: 7598 RVA: 0x000081F2 File Offset: 0x000063F2
			[global::Cpp2ILInjected.Token(Token = "0x60009BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07EB8", Offset = "0x1F07EB8", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "HandleCompletion", MemberTypeParameters = new object[] { "TAsyncCompletedEventArgs", "TCompletionDelegate", "T" }, MemberParameters = new object[] { "System.Threading.Tasks.TaskCompletionSource`1<T>", "TAsyncCompletedEventArgs", "System.Func`2<TAsyncCompletedEventArgs, T>", "TCompletionDelegate", "System.Action`2<WebClient, TCompletionDelegate>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <UploadValuesTaskAsync>b__0(object sender, UploadValuesCompletedEventArgs e)
			{
				throw null;
			}

			// Token: 0x040011BC RID: 4540
			[global::Cpp2ILInjected.Token(Token = "0x4000797")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			// Token: 0x040011BD RID: 4541
			[global::Cpp2ILInjected.Token(Token = "0x4000798")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<byte[]> tcs;

			// Token: 0x040011BE RID: 4542
			[global::Cpp2ILInjected.Token(Token = "0x4000799")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UploadValuesCompletedEventHandler handler;
		}
	}
}
