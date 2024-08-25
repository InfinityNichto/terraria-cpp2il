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
	[global::Cpp2ILInjected.Token(Token = "0x200015A")]
	public class WebClient : Component
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60008E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA84C", Offset = "0x1EFA84C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA874", Offset = "0x1EFA874", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA89C", Offset = "0x1EFA89C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA8C4", Offset = "0x1EFA8C4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA8EC", Offset = "0x1EFA8EC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA914", Offset = "0x1EFA914", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA93C", Offset = "0x1EFA93C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA964", Offset = "0x1EFA964", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA98C", Offset = "0x1EFA98C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA9B4", Offset = "0x1EFA9B4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFA9DC", Offset = "0x1EFA9DC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60008ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFAAA0", Offset = "0x1EFAAA0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "StartOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		private void EndOperation()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000901")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB7CC", Offset = "0x1EFB7CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual WebResponse GetWebResponse(WebRequest request)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000902")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB7F8", Offset = "0x1EFB7F8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000904")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB920", Offset = "0x1EFB920", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "DownloadData", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(byte[]))]
		public byte[] DownloadData(string address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000907")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFC6A0", Offset = "0x1EFC6A0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public void DownloadFile(string address, string fileName)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000909")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFCAA8", Offset = "0x1EFCAA8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Stream OpenRead(string address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600090B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFCE04", Offset = "0x1EFCE04", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Stream OpenWrite(string address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600090F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFD310", Offset = "0x1EFD310", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public byte[] UploadData(string address, byte[] data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000916")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFE3F0", Offset = "0x1EFE3F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte[] UploadFile(Uri address, string fileName)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600091A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEB60", Offset = "0x1EFEB60", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public byte[] UploadValues(string address, NameValueCollection data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600091E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFEF5C", Offset = "0x1EFEF5C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public string UploadString(string address, string data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFF534", Offset = "0x1EFF534", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public string DownloadString(string address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000926")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFB93C", Offset = "0x1EFB93C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringTaskAsync", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Task<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadTaskAsync", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<Stream>))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataTaskAsync", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(Task<byte[]>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesTaskAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(Task<byte[]>))]
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

		[global::Cpp2ILInjected.Token(Token = "0x6000931")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFB74", Offset = "0x1EFFB74", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static char IntToHex(int n)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000932")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFB00", Offset = "0x1EFFB00", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsSafe(char ch)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000934")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFBFC", Offset = "0x1EFFBFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OpenReadAsync(Uri address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000936")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFFBC", Offset = "0x1EFFFBC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OpenWriteAsync(Uri address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600093A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F004B8", Offset = "0x1F004B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DownloadStringAsync(Uri address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600093D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00800", Offset = "0x1F00800", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DownloadDataAsync(Uri address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000940")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00B08", Offset = "0x1F00B08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DownloadFileAsync(Uri address, string fileName)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000942")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00DAC", Offset = "0x1F00DAC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UploadStringAsync(Uri address, string data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000945")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F010DC", Offset = "0x1F010DC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UploadDataAsync(Uri address, byte[] data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000948")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01480", Offset = "0x1F01480", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UploadFileAsync(Uri address, string fileName)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600094B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01864", Offset = "0x1F01864", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UploadValuesAsync(Uri address, NameValueCollection data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600094F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01C14", Offset = "0x1F01C14", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "AbortRequest", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CancelAsync()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000950")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01C74", Offset = "0x1F01C74", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<string> DownloadStringTaskAsync(string address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000952")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01F78", Offset = "0x1F01F78", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<Stream> OpenReadTaskAsync(string address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000954")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0227C", Offset = "0x1F0227C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<Stream> OpenWriteTaskAsync(string address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000959")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02624", Offset = "0x1F02624", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Task<string> UploadStringTaskAsync(Uri address, string data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600095C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02930", Offset = "0x1F02930", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<byte[]> DownloadDataTaskAsync(string address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600095E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02C34", Offset = "0x1F02C34", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task DownloadFileTaskAsync(string address, string fileName)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000960")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F02E24", Offset = "0x1F02E24", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<byte[]> UploadDataTaskAsync(string address, byte[] data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000964")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03194", Offset = "0x1F03194", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<byte[]> UploadFileTaskAsync(string address, string fileName)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000968")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03504", Offset = "0x1F03504", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		public Task<byte[]> UploadValuesTaskAsync(string address, NameValueCollection data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600096E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFAE64", Offset = "0x1EFAE64", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "set_Encoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void ThrowIfNull(object argument, string parameterName)
		{
			throw null;
		}

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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000975")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03AD0", Offset = "0x1F03AD0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnWriteStreamClosed(WriteStreamClosedEventArgs e)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000702")]
		private const int DefaultCopyBufferLength = 8192;

		[global::Cpp2ILInjected.Token(Token = "0x4000703")]
		private const int DefaultDownloadBufferLength = 65536;

		[global::Cpp2ILInjected.Token(Token = "0x4000704")]
		private const string DefaultUploadFileContentType = "application/octet-stream";

		[global::Cpp2ILInjected.Token(Token = "0x4000705")]
		private const string UploadFileContentType = "multipart/form-data";

		[global::Cpp2ILInjected.Token(Token = "0x4000706")]
		private const string UploadValuesContentType = "application/x-www-form-urlencoded";

		[global::Cpp2ILInjected.Token(Token = "0x4000707")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Uri _baseAddress;

		[global::Cpp2ILInjected.Token(Token = "0x4000708")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ICredentials _credentials;

		[global::Cpp2ILInjected.Token(Token = "0x4000709")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private WebHeaderCollection _headers;

		[global::Cpp2ILInjected.Token(Token = "0x400070A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private NameValueCollection _requestParameters;

		[global::Cpp2ILInjected.Token(Token = "0x400070B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private WebResponse _webResponse;

		[global::Cpp2ILInjected.Token(Token = "0x400070C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private WebRequest _webRequest;

		[global::Cpp2ILInjected.Token(Token = "0x400070D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Encoding _encoding;

		[global::Cpp2ILInjected.Token(Token = "0x400070E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string _method;

		[global::Cpp2ILInjected.Token(Token = "0x400070F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private long _contentLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000710")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool _initWebClientAsync;

		[global::Cpp2ILInjected.Token(Token = "0x4000711")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool _canceled;

		[global::Cpp2ILInjected.Token(Token = "0x4000712")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private WebClient.ProgressData _progress;

		[global::Cpp2ILInjected.Token(Token = "0x4000713")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private IWebProxy _proxy;

		[global::Cpp2ILInjected.Token(Token = "0x4000714")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool _proxySet;

		[global::Cpp2ILInjected.Token(Token = "0x4000715")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int _callNesting;

		[global::Cpp2ILInjected.Token(Token = "0x4000716")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private AsyncOperation _asyncOp;

		[global::Cpp2ILInjected.Token(Token = "0x4000717")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private SendOrPostCallback _downloadDataOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x4000718")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private SendOrPostCallback _openReadOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x4000719")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private SendOrPostCallback _openWriteOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400071A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private SendOrPostCallback _downloadStringOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400071B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private SendOrPostCallback _downloadFileOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400071C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private SendOrPostCallback _uploadStringOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400071D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private SendOrPostCallback _uploadDataOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400071E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private SendOrPostCallback _uploadFileOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400071F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private SendOrPostCallback _uploadValuesOperationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x4000720")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private SendOrPostCallback _reportDownloadProgressChanged;

		[global::Cpp2ILInjected.Token(Token = "0x4000721")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private SendOrPostCallback _reportUploadProgressChanged;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000722")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private DownloadStringCompletedEventHandler DownloadStringCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000723")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private DownloadDataCompletedEventHandler DownloadDataCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000724")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private AsyncCompletedEventHandler DownloadFileCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000725")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private UploadStringCompletedEventHandler UploadStringCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000726")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private UploadDataCompletedEventHandler UploadDataCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000727")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private UploadFileCompletedEventHandler UploadFileCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000728")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private UploadValuesCompletedEventHandler UploadValuesCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000729")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private OpenReadCompletedEventHandler OpenReadCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400072A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private OpenWriteCompletedEventHandler OpenWriteCompleted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400072B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private DownloadProgressChangedEventHandler DownloadProgressChanged;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400072C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private UploadProgressChangedEventHandler UploadProgressChanged;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400072D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private RequestCachePolicy <CachePolicy>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x400072E")]
		private static readonly char[] s_parseContentTypeSeparators;

		[global::Cpp2ILInjected.Token(Token = "0x400072F")]
		private static readonly Encoding[] s_knownEncodings;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000730")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private bool <AllowReadStreamBuffering>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000731")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x151")]
		private bool <AllowWriteStreamBuffering>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x200015B")]
		private sealed class ProgressData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000983")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFAAAC", Offset = "0x1EFAAAC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000984")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFADC8", Offset = "0x1EFADC8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ProgressData()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000732")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal long BytesSent;

			[global::Cpp2ILInjected.Token(Token = "0x4000733")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal long TotalBytesToSend;

			[global::Cpp2ILInjected.Token(Token = "0x4000734")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal long BytesReceived;

			[global::Cpp2ILInjected.Token(Token = "0x4000735")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal long TotalBytesToReceive;

			[global::Cpp2ILInjected.Token(Token = "0x4000736")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal bool HasUploadPhase;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200015C")]
		private sealed class WebClientWriteStream : DelegatingStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000985")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFD2E4", Offset = "0x1EFD2E4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			public WebClientWriteStream(Stream stream, WebRequest request, WebClient webClient)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000737")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private readonly WebRequest _request;

			[global::Cpp2ILInjected.Token(Token = "0x4000738")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private readonly WebClient _webClient;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200015D")]
		[StructLayout(3)]
		private struct <GetWebResponseTaskAsync>d__112 : IAsyncStateMachine
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x4000739")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x400073A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebResponse> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x400073B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequest request;

			[global::Cpp2ILInjected.Token(Token = "0x400073C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x400073D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private WebRequest <>7__wrap1;

			[global::Cpp2ILInjected.Token(Token = "0x400073E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private object <>u__1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200015E")]
		[StructLayout(3)]
		private struct <DownloadBitsAsync>d__150 : IAsyncStateMachine
		{
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

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600098A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F054E0", Offset = "0x1F054E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400073F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000740")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000741")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000742")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public WebRequest request;

			[global::Cpp2ILInjected.Token(Token = "0x4000743")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public Stream writeStream;

			[global::Cpp2ILInjected.Token(Token = "0x4000744")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public AsyncOperation asyncOp;

			[global::Cpp2ILInjected.Token(Token = "0x4000745")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public Action<byte[], Exception, AsyncOperation> completionDelegate;

			[global::Cpp2ILInjected.Token(Token = "0x4000746")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private Exception <exception>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000747")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private byte[] <copyBuffer>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x4000748")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000749")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Stream <>7__wrap3;

			[global::Cpp2ILInjected.Token(Token = "0x400074A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Stream <readStream>5__5;

			[global::Cpp2ILInjected.Token(Token = "0x400074B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter <>u__2;

			[global::Cpp2ILInjected.Token(Token = "0x400074C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__3;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200015F")]
		[StructLayout(3)]
		private struct <UploadBitsAsync>d__152 : IAsyncStateMachine
		{
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

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600098C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F06920", Offset = "0x1F06920", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400074D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x400074E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x400074F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000750")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public WebRequest request;

			[global::Cpp2ILInjected.Token(Token = "0x4000751")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public byte[] header;

			[global::Cpp2ILInjected.Token(Token = "0x4000752")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public byte[] footer;

			[global::Cpp2ILInjected.Token(Token = "0x4000753")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public AsyncOperation asyncOp;

			[global::Cpp2ILInjected.Token(Token = "0x4000754")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public Stream readStream;

			[global::Cpp2ILInjected.Token(Token = "0x4000755")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public byte[] buffer;

			[global::Cpp2ILInjected.Token(Token = "0x4000756")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public int chunkSize;

			[global::Cpp2ILInjected.Token(Token = "0x4000757")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public Action<byte[], Exception, AsyncOperation> completionDelegate;

			[global::Cpp2ILInjected.Token(Token = "0x4000758")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Exception <exception>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000759")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Stream <writeStream>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x400075A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x400075B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2;

			[global::Cpp2ILInjected.Token(Token = "0x400075C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			private Stream <>7__wrap3;

			[global::Cpp2ILInjected.Token(Token = "0x400075D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			private int <bytesRead>5__5;

			[global::Cpp2ILInjected.Token(Token = "0x400075E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter <>u__3;

			[global::Cpp2ILInjected.Token(Token = "0x400075F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			private int <toWrite>5__6;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000160")]
		private sealed class <>c__DisplayClass164_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x600098D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EFFEA0", Offset = "0x1EFFEA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass164_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000760")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000761")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;

			[global::Cpp2ILInjected.Token(Token = "0x4000762")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequest request;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000161")]
		private sealed class <>c__DisplayClass167_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x600098F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F00280", Offset = "0x1F00280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass167_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000763")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000764")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;

			[global::Cpp2ILInjected.Token(Token = "0x4000765")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequest request;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000162")]
		private sealed class <>c__DisplayClass182_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000991")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F01440", Offset = "0x1F01440", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass182_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000766")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000767")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000163")]
		private sealed class <>c__DisplayClass185_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000993")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F01824", Offset = "0x1F01824", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass185_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000768")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000769")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000164")]
		private sealed class <>c__DisplayClass188_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000995")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F01BD4", Offset = "0x1F01BD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass188_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400076A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x400076B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AsyncOperation asyncOp;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000165")]
		private sealed class <>c__DisplayClass192_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000997")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F01E40", Offset = "0x1F01E40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass192_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400076C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x400076D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<string> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x400076E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public DownloadStringCompletedEventHandler handler;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000166")]
		[Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600099A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F070C4", Offset = "0x1F070C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600099B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F070CC", Offset = "0x1F070CC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal string <DownloadStringTaskAsync>b__192_1(DownloadStringCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600099C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07108", Offset = "0x1F07108", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadStringCompleted", MemberParameters = new object[] { typeof(DownloadStringCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <DownloadStringTaskAsync>b__192_2(WebClient webClient, DownloadStringCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600099D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07114", Offset = "0x1F07114", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal Stream <OpenReadTaskAsync>b__194_1(OpenReadCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600099E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07150", Offset = "0x1F07150", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_OpenReadCompleted", MemberParameters = new object[] { typeof(OpenReadCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <OpenReadTaskAsync>b__194_2(WebClient webClient, OpenReadCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600099F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0715C", Offset = "0x1F0715C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal Stream <OpenWriteTaskAsync>b__198_1(OpenWriteCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07198", Offset = "0x1F07198", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_OpenWriteCompleted", MemberParameters = new object[] { typeof(OpenWriteCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <OpenWriteTaskAsync>b__198_2(WebClient webClient, OpenWriteCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F071A4", Offset = "0x1F071A4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal string <UploadStringTaskAsync>b__202_1(UploadStringCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F071E0", Offset = "0x1F071E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadStringCompleted", MemberParameters = new object[] { typeof(UploadStringCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <UploadStringTaskAsync>b__202_2(WebClient webClient, UploadStringCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F071EC", Offset = "0x1F071EC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal byte[] <DownloadDataTaskAsync>b__204_1(DownloadDataCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07228", Offset = "0x1F07228", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadDataCompleted", MemberParameters = new object[] { typeof(DownloadDataCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <DownloadDataTaskAsync>b__204_2(WebClient webClient, DownloadDataCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07234", Offset = "0x1F07234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal object <DownloadFileTaskAsync>b__206_1(AsyncCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0723C", Offset = "0x1F0723C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_DownloadFileCompleted", MemberParameters = new object[] { typeof(AsyncCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <DownloadFileTaskAsync>b__206_2(WebClient webClient, AsyncCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07248", Offset = "0x1F07248", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal byte[] <UploadDataTaskAsync>b__210_1(UploadDataCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07284", Offset = "0x1F07284", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadDataCompleted", MemberParameters = new object[] { typeof(UploadDataCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <UploadDataTaskAsync>b__210_2(WebClient webClient, UploadDataCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07290", Offset = "0x1F07290", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal byte[] <UploadFileTaskAsync>b__214_1(UploadFileCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F072CC", Offset = "0x1F072CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadFileCompleted", MemberParameters = new object[] { typeof(UploadFileCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <UploadFileTaskAsync>b__214_2(WebClient webClient, UploadFileCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F072D8", Offset = "0x1F072D8", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			internal byte[] <UploadValuesTaskAsync>b__218_1(UploadValuesCompletedEventArgs args)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60009AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07314", Offset = "0x1F07314", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebClient), Member = "remove_UploadValuesCompleted", MemberParameters = new object[] { typeof(UploadValuesCompletedEventHandler) }, ReturnType = typeof(void))]
			internal void <UploadValuesTaskAsync>b__218_2(WebClient webClient, UploadValuesCompletedEventHandler completion)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400076F")]
			public static readonly WebClient.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4000770")]
			public static Func<DownloadStringCompletedEventArgs, string> <>9__192_1;

			[global::Cpp2ILInjected.Token(Token = "0x4000771")]
			public static Action<WebClient, DownloadStringCompletedEventHandler> <>9__192_2;

			[global::Cpp2ILInjected.Token(Token = "0x4000772")]
			public static Func<OpenReadCompletedEventArgs, Stream> <>9__194_1;

			[global::Cpp2ILInjected.Token(Token = "0x4000773")]
			public static Action<WebClient, OpenReadCompletedEventHandler> <>9__194_2;

			[global::Cpp2ILInjected.Token(Token = "0x4000774")]
			public static Func<OpenWriteCompletedEventArgs, Stream> <>9__198_1;

			[global::Cpp2ILInjected.Token(Token = "0x4000775")]
			public static Action<WebClient, OpenWriteCompletedEventHandler> <>9__198_2;

			[global::Cpp2ILInjected.Token(Token = "0x4000776")]
			public static Func<UploadStringCompletedEventArgs, string> <>9__202_1;

			[global::Cpp2ILInjected.Token(Token = "0x4000777")]
			public static Action<WebClient, UploadStringCompletedEventHandler> <>9__202_2;

			[global::Cpp2ILInjected.Token(Token = "0x4000778")]
			public static Func<DownloadDataCompletedEventArgs, byte[]> <>9__204_1;

			[global::Cpp2ILInjected.Token(Token = "0x4000779")]
			public static Action<WebClient, DownloadDataCompletedEventHandler> <>9__204_2;

			[global::Cpp2ILInjected.Token(Token = "0x400077A")]
			public static Func<AsyncCompletedEventArgs, object> <>9__206_1;

			[global::Cpp2ILInjected.Token(Token = "0x400077B")]
			public static Action<WebClient, AsyncCompletedEventHandler> <>9__206_2;

			[global::Cpp2ILInjected.Token(Token = "0x400077C")]
			public static Func<UploadDataCompletedEventArgs, byte[]> <>9__210_1;

			[global::Cpp2ILInjected.Token(Token = "0x400077D")]
			public static Action<WebClient, UploadDataCompletedEventHandler> <>9__210_2;

			[global::Cpp2ILInjected.Token(Token = "0x400077E")]
			public static Func<UploadFileCompletedEventArgs, byte[]> <>9__214_1;

			[global::Cpp2ILInjected.Token(Token = "0x400077F")]
			public static Action<WebClient, UploadFileCompletedEventHandler> <>9__214_2;

			[global::Cpp2ILInjected.Token(Token = "0x4000780")]
			public static Func<UploadValuesCompletedEventArgs, byte[]> <>9__218_1;

			[global::Cpp2ILInjected.Token(Token = "0x4000781")]
			public static Action<WebClient, UploadValuesCompletedEventHandler> <>9__218_2;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000167")]
		private sealed class <>c__DisplayClass194_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F02144", Offset = "0x1F02144", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass194_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000782")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000783")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<Stream> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x4000784")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public OpenReadCompletedEventHandler handler;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000168")]
		private sealed class <>c__DisplayClass198_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F02488", Offset = "0x1F02488", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass198_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000785")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000786")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<Stream> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x4000787")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public OpenWriteCompletedEventHandler handler;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000169")]
		private sealed class <>c__DisplayClass202_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F027F8", Offset = "0x1F027F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass202_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000788")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000789")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<string> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x400078A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UploadStringCompletedEventHandler handler;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016A")]
		private sealed class <>c__DisplayClass204_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F02AFC", Offset = "0x1F02AFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass204_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400078B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x400078C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<byte[]> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x400078D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public DownloadDataCompletedEventHandler handler;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016B")]
		private sealed class <>c__DisplayClass206_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F02E1C", Offset = "0x1F02E1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass206_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400078E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x400078F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<object> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x4000790")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public AsyncCompletedEventHandler handler;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016C")]
		private sealed class <>c__DisplayClass210_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0305C", Offset = "0x1F0305C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass210_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000791")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000792")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<byte[]> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x4000793")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UploadDataCompletedEventHandler handler;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016D")]
		private sealed class <>c__DisplayClass214_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F033CC", Offset = "0x1F033CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass214_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000794")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000795")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<byte[]> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x4000796")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UploadFileCompletedEventHandler handler;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200016E")]
		private sealed class <>c__DisplayClass218_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0373C", Offset = "0x1F0373C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass218_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000797")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebClient <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000798")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TaskCompletionSource<byte[]> tcs;

			[global::Cpp2ILInjected.Token(Token = "0x4000799")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public UploadValuesCompletedEventHandler handler;
		}
	}
}
