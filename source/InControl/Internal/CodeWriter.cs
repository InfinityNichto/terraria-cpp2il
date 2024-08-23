using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.Internal
{
	// Token: 0x02000067 RID: 103
	[global::Cpp2ILInjected.Token(Token = "0x2000074")]
	public class CodeWriter
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x00003008 File Offset: 0x00001208
		[global::Cpp2ILInjected.Token(Token = "0x6000566")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BBFCC", Offset = "0x19BBFCC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CodeWriter()
		{
			throw null;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000300B File Offset: 0x0000120B
		[global::Cpp2ILInjected.Token(Token = "0x6000567")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC038", Offset = "0x19BC038", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void IncreaseIndent()
		{
			throw null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000300E File Offset: 0x0000120E
		[global::Cpp2ILInjected.Token(Token = "0x6000568")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC048", Offset = "0x19BC048", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DecreaseIndent()
		{
			throw null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00003011 File Offset: 0x00001211
		[global::Cpp2ILInjected.Token(Token = "0x6000569")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC058", Offset = "0x19BC058", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Append(string code)
		{
			throw null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00003014 File Offset: 0x00001214
		[global::Cpp2ILInjected.Token(Token = "0x600056A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC064", Offset = "0x19BC064", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CodeWriter), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CodeWriter), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CodeWriter), Member = "AppendLineFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Split", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<char, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Append(bool trim, string code)
		{
			throw null;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00003017 File Offset: 0x00001217
		[global::Cpp2ILInjected.Token(Token = "0x600056B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC1F0", Offset = "0x19BC1F0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeWriter), Member = "Append", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		public void AppendLine(string code)
		{
			throw null;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000301A File Offset: 0x0000121A
		[global::Cpp2ILInjected.Token(Token = "0x600056C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC218", Offset = "0x19BC218", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		public void AppendLine(int count)
		{
			throw null;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000301D File Offset: 0x0000121D
		[global::Cpp2ILInjected.Token(Token = "0x600056D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC22C", Offset = "0x19BC22C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeWriter), Member = "Append", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void AppendFormat(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00003020 File Offset: 0x00001220
		[global::Cpp2ILInjected.Token(Token = "0x600056E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC258", Offset = "0x19BC258", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeWriter), Member = "Append", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		public void AppendLineFormat(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00003023 File Offset: 0x00001223
		[global::Cpp2ILInjected.Token(Token = "0x600056F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BC294", Offset = "0x19BC294", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040003B5 RID: 949
		[global::Cpp2ILInjected.Token(Token = "0x4000409")]
		private const char newLine = '\n';

		// Token: 0x040003B6 RID: 950
		[global::Cpp2ILInjected.Token(Token = "0x400040A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int indent;

		// Token: 0x040003B7 RID: 951
		[global::Cpp2ILInjected.Token(Token = "0x400040B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly StringBuilder stringBuilder;
	}
}
