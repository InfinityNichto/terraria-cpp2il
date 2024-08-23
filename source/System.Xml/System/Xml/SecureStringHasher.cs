using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200002A RID: 42
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	internal class SecureStringHasher : IEqualityComparer<string>
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x000031D6 File Offset: 0x000013D6
		[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62A7C", Offset = "0x1D62A7C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		public SecureStringHasher()
		{
			throw null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000031D9 File Offset: 0x000013D9
		[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62AA0", Offset = "0x1D62AA0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		public bool Equals(string x, string y)
		{
			throw null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000031DC File Offset: 0x000013DC
		[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62AB8", Offset = "0x1D62AB8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureStringHasher), Member = "GetHashCodeDelegate", ReturnType = typeof(SecureStringHasher.HashCodeOfStringDelegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int GetHashCode(string key)
		{
			throw null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000031DF File Offset: 0x000013DF
		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62C94", Offset = "0x1D62C94", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy)
		{
			throw null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000031E2 File Offset: 0x000013E2
		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62B48", Offset = "0x1D62B48", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecureStringHasher), Member = "GetHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodInfo)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureStringHasher.HashCodeOfStringDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			throw null;
		}

		// Token: 0x04000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate;

		// Token: 0x04000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int hashCodeRandomizer;

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x06000C3B RID: 3131
		[global::Cpp2ILInjected.Token(Token = "0x200002B")]
		private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);
	}
}
