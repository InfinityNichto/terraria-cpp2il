using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000066 RID: 102
	[global::Cpp2ILInjected.Token(Token = "0x2000085")]
	internal struct LineInfo
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x00003FD4 File Offset: 0x000021D4
		[global::Cpp2ILInjected.Token(Token = "0x6000639")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AFAC", Offset = "0x1D9AFAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			"System.Xml.XmlTextReaderImpl.NodeData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public LineInfo(int lineNo, int linePos)
		{
			throw null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00003FD7 File Offset: 0x000021D7
		[global::Cpp2ILInjected.Token(Token = "0x600063A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AFB4", Offset = "0x1D9AFB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl.NodeData", Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl.NodeData", Member = "SetLineInfo2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			"System.Xml.XmlTextReaderImpl.NodeData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = "System.Xml.XmlTextReaderImpl.NodeData")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public void Set(int lineNo, int linePos)
		{
			throw null;
		}

		// Token: 0x04000202 RID: 514
		[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal int lineNo;

		// Token: 0x04000203 RID: 515
		[global::Cpp2ILInjected.Token(Token = "0x4000300")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		internal int linePos;
	}
}
