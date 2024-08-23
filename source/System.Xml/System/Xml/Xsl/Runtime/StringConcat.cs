using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Xsl.Runtime
{
	// Token: 0x02000097 RID: 151
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::Cpp2ILInjected.Token(Token = "0x20000C1")]
	public struct StringConcat
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x000044B1 File Offset: 0x000026B1
		[global::Cpp2ILInjected.Token(Token = "0x60007FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3AD4", Offset = "0x1DB3AD4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x000044B4 File Offset: 0x000026B4
		[global::Cpp2ILInjected.Token(Token = "0x170001F0")]
		internal int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB3AE0", Offset = "0x1DB3AE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000044B7 File Offset: 0x000026B7
		[global::Cpp2ILInjected.Token(Token = "0x60007FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3AE8", Offset = "0x1DB3AE8", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "EventsToWriter", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string GetResult()
		{
			throw null;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000044BA File Offset: 0x000026BA
		[global::Cpp2ILInjected.Token(Token = "0x6000800")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3BD4", Offset = "0x1DB3BD4", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void ConcatNoDelimiter(string s)
		{
			throw null;
		}

		// Token: 0x0400029D RID: 669
		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string s1;

		// Token: 0x0400029E RID: 670
		[global::Cpp2ILInjected.Token(Token = "0x4000410")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private string s2;

		// Token: 0x0400029F RID: 671
		[global::Cpp2ILInjected.Token(Token = "0x4000411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string s3;

		// Token: 0x040002A0 RID: 672
		[global::Cpp2ILInjected.Token(Token = "0x4000412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string s4;

		// Token: 0x040002A1 RID: 673
		[global::Cpp2ILInjected.Token(Token = "0x4000413")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string delimiter;

		// Token: 0x040002A2 RID: 674
		[global::Cpp2ILInjected.Token(Token = "0x4000414")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<string> strList;

		// Token: 0x040002A3 RID: 675
		[global::Cpp2ILInjected.Token(Token = "0x4000415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int idxStr;
	}
}
