using System;
using System.Collections;
using System.Security;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200014A RID: 330
	[global::Cpp2ILInjected.Token(Token = "0x20001D3")]
	[Serializable]
	internal class DelayedRegex
	{
		// Token: 0x06000A4A RID: 2634 RVA: 0x00004B56 File Offset: 0x00002D56
		[global::Cpp2ILInjected.Token(Token = "0x6000B5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17828", Offset = "0x1F17828", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermissionAttribute), Member = "set_ConnectPattern", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermissionAttribute), Member = "set_AcceptPattern", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "intersectPair", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal DelayedRegex(string regexString)
		{
			throw null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00004B59 File Offset: 0x00002D59
		[global::Cpp2ILInjected.Token(Token = "0x6000B60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F18A60", Offset = "0x1F18A60", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(Regex)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal DelayedRegex(Regex regex)
		{
			throw null;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00004B5C File Offset: 0x00002D5C
		[global::Cpp2ILInjected.Token(Token = "0x17000251")]
		internal Regex AsRegex
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F18AD4", Offset = "0x1F18AD4", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "get_ConnectList", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "get_AcceptList", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "isMatchedURI", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ArrayList)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "intersectPair", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(RegexOptions)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00004B5F File Offset: 0x00002D5F
		[global::Cpp2ILInjected.Token(Token = "0x6000B62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F18B6C", Offset = "0x1F18B6C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040007CB RID: 1995
		[global::Cpp2ILInjected.Token(Token = "0x40009ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Regex _AsRegex;

		// Token: 0x040007CC RID: 1996
		[global::Cpp2ILInjected.Token(Token = "0x40009EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _AsString;
	}
}
