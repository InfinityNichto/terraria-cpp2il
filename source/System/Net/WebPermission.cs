﻿using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001D4")]
	[Serializable]
	public sealed class WebPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000252")]
		internal static Regex MatchAllRegex
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F18B98", Offset = "0x1F18B98", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "get_ConnectList", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "get_AcceptList", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000253")]
		public IEnumerator ConnectList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F18C4C", Offset = "0x1F18C4C", Length = "0x2D8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "get_MatchAllRegex", ReturnType = typeof(Regex))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = "get_AsRegex", ReturnType = typeof(Regex))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000254")]
		public IEnumerator AcceptList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F18F24", Offset = "0x1F18F24", Length = "0x2D8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "get_MatchAllRegex", ReturnType = typeof(Regex))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = "get_AsRegex", ReturnType = typeof(Regex))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17CCC", Offset = "0x1F17CCC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermissionAttribute), Member = "CreatePermission", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WebPermission(PermissionState state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F191FC", Offset = "0x1F191FC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Copy", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal WebPermission(bool unrestricted)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F19288", Offset = "0x1F19288", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WebPermission()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17D60", Offset = "0x1F17D60", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermissionAttribute), Member = "CreatePermission", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Copy", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal WebPermission(NetworkAccess access)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F19300", Offset = "0x1F19300", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WebPermission(NetworkAccess access, Regex uriRegex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F194FC", Offset = "0x1F194FC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WebPermission(NetworkAccess access, string uriString)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F19594", Offset = "0x1F19594", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal WebPermission(NetworkAccess access, Uri uri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F183F8", Offset = "0x1F183F8", Length = "0x668")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermissionAttribute), Member = "CreatePermission", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(Uri)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public void AddPermission(NetworkAccess access, string uriString)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1962C", Offset = "0x1F1962C", Length = "0x64C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		internal void AddPermission(NetworkAccess access, Uri uri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F19398", Offset = "0x1F19398", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = ".ctor", MemberParameters = new object[] { typeof(Regex) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddAsPattern", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(DelayedRegex)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void AddPermission(NetworkAccess access, Regex uriRegex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17DFC", Offset = "0x1F17DFC", Length = "0x5FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermissionAttribute), Member = "CreatePermission", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(Regex)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		internal void AddAsPattern(NetworkAccess access, DelayedRegex uriRegexPattern)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F19C78", Offset = "0x1F19C78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsUnrestricted()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F19C80", Offset = "0x1F19C80", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = ".ctor", MemberParameters = new object[] { typeof(NetworkAccess) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override IPermission Copy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F19E00", Offset = "0x1F19E00", Length = "0x7B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "isMatchedURI", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "isSpecialSubsetCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public override bool IsSubsetOf(IPermission target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1A5B4", Offset = "0x1F1A5B4", Length = "0x43C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "IsSubsetOf", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private static bool isSpecialSubsetCase(string regexToCheck, ArrayList permList)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1AF1C", Offset = "0x1F1AF1C", Length = "0x540")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(Uri)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddAsPattern", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(DelayedRegex)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override IPermission Union(IPermission target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1B45C", Offset = "0x1F1B45C", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "intersectList", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ArrayList),
			typeof(ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override IPermission Intersect(IPermission target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1C604", Offset = "0x1F1C604", Length = "0xAC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Attribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "SearchForChildByTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddAsPattern", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(DelayedRegex)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 81)]
		public override void FromXml(SecurityElement securityElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1D0C4", Offset = "0x1F1D0C4", Length = "0xB2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddChild", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
		public override SecurityElement ToXml()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1A9F0", Offset = "0x1F1A9F0", Length = "0x52C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "IsSubsetOf", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = "get_AsRegex", ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static bool isMatchedURI(object uriToCheck, ArrayList uriPatternList)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1B718", Offset = "0x1F1B718", Length = "0xEEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "intersectPair", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 61)]
		private static void intersectList(ArrayList A, ArrayList B, ArrayList result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1DBF0", Offset = "0x1F1DBF0", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "intersectList", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ArrayList),
			typeof(ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = "get_AsRegex", ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static object intersectPair(object L, object R, out bool isUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40009EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_noRestriction;

		[OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x40009F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool m_UnrestrictedConnect;

		[OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x40009F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private bool m_UnrestrictedAccept;

		[global::Cpp2ILInjected.Token(Token = "0x40009F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ArrayList m_connectList;

		[global::Cpp2ILInjected.Token(Token = "0x40009F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ArrayList m_acceptList;

		[global::Cpp2ILInjected.Token(Token = "0x40009F4")]
		internal const string MatchAll = ".*";

		[global::Cpp2ILInjected.Token(Token = "0x40009F5")]
		private static Regex s_MatchAllRegex;
	}
}
