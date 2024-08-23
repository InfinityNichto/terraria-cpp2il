using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000068 RID: 104
	[global::Cpp2ILInjected.Token(Token = "0x2000088")]
	internal static class Ref
	{
		// Token: 0x060005C0 RID: 1472 RVA: 0x00003FEF File Offset: 0x000021EF
		[global::Cpp2ILInjected.Token(Token = "0x6000643")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D96FC0", Offset = "0x1D96FC0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl.NodeData", Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "System.Xml.XmlTextReaderImpl.NodeData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"System.Xml.XmlTextReaderImpl.NodeData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithoutPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamespaceManager), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		public static bool Equal(string strA, string strB)
		{
			throw null;
		}
	}
}
