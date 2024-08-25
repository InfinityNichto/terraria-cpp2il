using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000220")]
	[Serializable]
	public class WebProxy : IAutoWebProxy, IWebProxy, ISerializable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39884", Offset = "0x1F39884", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public WebProxy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39944", Offset = "0x1F39944", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		public WebProxy(Uri Address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39954", Offset = "0x1F39954", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		public WebProxy(Uri Address, bool BypassOnLocal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39964", Offset = "0x1F39964", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39898", Offset = "0x1F39898", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "UpdateRegExList", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39B8C", Offset = "0x1F39B8C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public WebProxy(string Host, int Port)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39C9C", Offset = "0x1F39C9C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		public WebProxy(string Address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39D84", Offset = "0x1F39D84", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		public WebProxy(string Address, bool BypassOnLocal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39DBC", Offset = "0x1F39DBC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		public WebProxy(string Address, bool BypassOnLocal, string[] BypassList)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39DF8", Offset = "0x1F39DF8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		public WebProxy(string Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DB")]
		public Uri Address
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39E40", Offset = "0x1F39E40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000DA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39E48", Offset = "0x1F39E48", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "Close", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DC")]
		internal bool AutoDetect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39EA8", Offset = "0x1F39EA8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(WebProxy),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DD")]
		internal Uri ScriptLocation
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39F1C", Offset = "0x1F39F1C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(WebProxy),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DE")]
		public bool BypassProxyOnLocal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39F8C", Offset = "0x1F39F8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000DAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39F94", Offset = "0x1F39F94", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "Close", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DF")]
		public string[] BypassList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39FCC", Offset = "0x1F39FCC", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000DAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3A0CC", Offset = "0x1F3A0CC", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "Close", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "UpdateRegExList", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E0")]
		public ICredentials Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3A14C", Offset = "0x1F3A14C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000DB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3A154", Offset = "0x1F3A154", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E1")]
		public bool UseDefaultCredentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3A15C", Offset = "0x1F3A15C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000DB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3A1D8", Offset = "0x1F3A1D8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E2")]
		public ArrayList BypassArrayList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3A244", Offset = "0x1F3A244", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3A2A8", Offset = "0x1F3A2A8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "CheckForChanges", ReturnType = typeof(void))]
		internal void CheckForChanges()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3A2BC", Offset = "0x1F3A2BC", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest.WebProxyWrapperOpaque), Member = "GetProxy", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "GetProxyAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public Uri GetProxy(Uri destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39CC8", Offset = "0x1F39CC8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Uri CreateProxyUri(string address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39970", Offset = "0x1F39970", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(string[]),
			typeof(ICredentials)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "set_BypassList", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void UpdateRegExList(bool canThrow)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3A67C", Offset = "0x1F3A67C", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "UpdateRegExList", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool IsMatchInBypassList(Uri input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3A804", Offset = "0x1F3A804", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "IsLoopback", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NclUtilities), Member = "IsAddressLocal", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPGlobalProperties), Member = "InternalGetIPGlobalProperties", ReturnType = typeof(IPGlobalProperties))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool IsLocal(Uri host)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3A958", Offset = "0x1F3A958", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool IsLocalInProxyHash(Uri host)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3AA40", Offset = "0x1F3AA40", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest.WebProxyWrapperOpaque), Member = "IsBypassed", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "IsBypassedAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool IsBypassed(Uri host)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3A5BC", Offset = "0x1F3A5BC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxy", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsBypassed", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxyAutoFailover", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsLoopback", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "IsLocalInProxyHash", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsBypassedManual(Uri host)
		{
			throw null;
		}

		[Obsolete("This method has been deprecated. Please use the proxy selected for you by default. http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3AC30", Offset = "0x1F3AC30", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static WebProxy GetDefaultProxy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3ACC0", Offset = "0x1F3ACC0", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "set_UseDefaultCredentials", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B018", Offset = "0x1F3B018", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B024", Offset = "0x1F3B024", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E3")]
		internal AutoWebProxyScriptEngine ScriptEngine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3B14C", Offset = "0x1F3B14C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000DC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3B154", Offset = "0x1F3B154", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B15C", Offset = "0x1F3B15C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "GetSystemWebProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "InternalGetSystemWebProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultProxySectionInternal), Member = "GetDefaultProxy_UsingOldMonoCode", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultProxySectionInternal), Member = "GetSystemWebProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultProxySectionInternal), Member = "GetSection", ReturnType = typeof(DefaultProxySectionInternal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IWebProxy CreateDefaultProxy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3AC90", Offset = "0x1F3AC90", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal WebProxy(bool enableAutoproxy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39E84", Offset = "0x1F39E84", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "Close", ReturnType = typeof(void))]
		internal void DeleteScriptEngine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B00C", Offset = "0x1F3B00C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void UnsafeUpdateFromRegistry()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B1BC", Offset = "0x1F3B1BC", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void Update(WebProxyData webProxyData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B2B4", Offset = "0x1F3B2B4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private ProxyChain System.Net.IAutoWebProxy.GetProxies(Uri destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3A440", Offset = "0x1F3A440", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxy", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "GetProxies", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref IList<string>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "AreAllBypassed", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "ProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool GetProxyAuto(Uri destination, out Uri proxyUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3AB30", Offset = "0x1F3AB30", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsBypassed", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "GetProxies", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref IList<string>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "AreAllBypassed", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsBypassedAuto(Uri destination, out bool isBypassed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27AE0", Offset = "0x1F27AE0", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyScriptChain), Member = "GetNextProxy", MemberParameters = new object[] { typeof(ref Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "GetProxies", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref IList<string>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "AreAllBypassed", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "ProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal Uri[] GetProxiesAuto(Uri destination, ref int syncStatus)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27E7C", Offset = "0x1F27E7C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "Abort", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(void))]
		internal void AbortGetProxiesAuto(ref int syncStatus)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27D9C", Offset = "0x1F27D9C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyScriptChain), Member = "GetNextProxy", MemberParameters = new object[] { typeof(ref Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Uri GetProxyAutoFailover(Uri destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B39C", Offset = "0x1F3B39C", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxyAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsBypassedAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxiesAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref int)
		}, ReturnType = typeof(Uri[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B688", Offset = "0x1F3B688", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxyAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxiesAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref int)
		}, ReturnType = typeof(Uri[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static Uri ProxyUri(string proxyName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _UseRegistry;

		[global::Cpp2ILInjected.Token(Token = "0x4000B76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool _BypassOnLocal;

		[global::Cpp2ILInjected.Token(Token = "0x4000B77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private bool m_EnableAutoproxy;

		[global::Cpp2ILInjected.Token(Token = "0x4000B78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Uri _ProxyAddress;

		[global::Cpp2ILInjected.Token(Token = "0x4000B79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ArrayList _BypassList;

		[global::Cpp2ILInjected.Token(Token = "0x4000B7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ICredentials _Credentials;

		[global::Cpp2ILInjected.Token(Token = "0x4000B7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Regex[] _RegExBypassList;

		[global::Cpp2ILInjected.Token(Token = "0x4000B7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Hashtable _ProxyHostAddresses;

		[global::Cpp2ILInjected.Token(Token = "0x4000B7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private AutoWebProxyScriptEngine m_ScriptEngine;
	}
}
