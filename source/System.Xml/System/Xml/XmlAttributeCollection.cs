using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000046 RID: 70
	[global::Cpp2ILInjected.Token(Token = "0x2000063")]
	public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00003AE5 File Offset: 0x00001CE5
		[global::Cpp2ILInjected.Token(Token = "0x6000480")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8BE98", Offset = "0x1D8BE98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "get_Attributes", ReturnType = typeof(XmlAttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(void))]
		internal XmlAttributeCollection(XmlNode parent)
		{
			throw null;
		}

		// Token: 0x170000D1 RID: 209
		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		[IndexerName("ItemOf")]
		public XmlAttribute this[int i]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000481")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8BEA0", Offset = "0x1D8BEA0", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "ImportAttributes", MemberParameters = new object[]
			{
				typeof(XmlNode),
				typeof(XmlNode)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new object[]
			{
				typeof(XmlElement),
				typeof(XmlNamespaceManager),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "GetPrefixOfNamespaceStrict", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00003AEB File Offset: 0x00001CEB
		[global::Cpp2ILInjected.Token(Token = "0x6000482")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8BFE4", Offset = "0x1D8BFE4", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override XmlNode SetNamedItem(XmlNode node)
		{
			throw null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00003AEE File Offset: 0x00001CEE
		[global::Cpp2ILInjected.Token(Token = "0x6000483")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C210", Offset = "0x1D8C210", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "AddNodeForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XmlAttribute Append(XmlAttribute node)
		{
			throw null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00003AF1 File Offset: 0x00001CF1
		[global::Cpp2ILInjected.Token(Token = "0x6000484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C4A8", Offset = "0x1D8C4A8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		public XmlAttribute Remove(XmlAttribute node)
		{
			throw null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[global::Cpp2ILInjected.Token(Token = "0x6000485")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C530", Offset = "0x1D8C530", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlAttribute RemoveAt(int i)
		{
			throw null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00003AF7 File Offset: 0x00001CF7
		[global::Cpp2ILInjected.Token(Token = "0x6000486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C5DC", Offset = "0x1D8C5DC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "RemoveAllAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlAttribute))]
		public void RemoveAll()
		{
			throw null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003AFA File Offset: 0x00001CFA
		[global::Cpp2ILInjected.Token(Token = "0x6000487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C624", Offset = "0x1D8C624", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00003AFD File Offset: 0x00001CFD
		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000488")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8C6AC", Offset = "0x1D8C6AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00003B00 File Offset: 0x00001D00
		[global::Cpp2ILInjected.Token(Token = "0x170000F4")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000489")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8C6B4", Offset = "0x1D8C6B4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00003B03 File Offset: 0x00001D03
		[global::Cpp2ILInjected.Token(Token = "0x170000F5")]
		private int System.Collections.ICollection.Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600048A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8C6B8", Offset = "0x1D8C6B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "get_Count", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00003B06 File Offset: 0x00001D06
		[global::Cpp2ILInjected.Token(Token = "0x600048B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C6C0", Offset = "0x1D8C6C0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "AddNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XmlNode AddNode(XmlNode node)
		{
			throw null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00003B09 File Offset: 0x00001D09
		[global::Cpp2ILInjected.Token(Token = "0x600048C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C8A0", Offset = "0x1D8C8A0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "InsertNodeAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XmlNode InsertNodeAt(int i, XmlNode node)
		{
			throw null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00003B0C File Offset: 0x00001D0C
		[global::Cpp2ILInjected.Token(Token = "0x600048D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C950", Offset = "0x1D8C950", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetDefaultAttribute", MemberParameters = new object[]
		{
			typeof(XmlElement),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override XmlNode RemoveNodeAt(int i)
		{
			throw null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00003B0F File Offset: 0x00001D0F
		[global::Cpp2ILInjected.Token(Token = "0x600048E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C33C", Offset = "0x1D8C33C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		internal void Detach(XmlAttribute attr)
		{
			throw null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00003B12 File Offset: 0x00001D12
		[global::Cpp2ILInjected.Token(Token = "0x600048F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C374", Offset = "0x1D8C374", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertNodeAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new object[] { typeof(XmlName) }, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr)
		{
			throw null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00003B15 File Offset: 0x00001D15
		[global::Cpp2ILInjected.Token(Token = "0x6000490")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8CAE0", Offset = "0x1D8CAE0", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveNodeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new object[] { typeof(XmlName) }, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr)
		{
			throw null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00003B18 File Offset: 0x00001D18
		[global::Cpp2ILInjected.Token(Token = "0x6000491")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C7A4", Offset = "0x1D8C7A4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int RemoveDuplicateAttribute(XmlAttribute attr)
		{
			throw null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00003B1B File Offset: 0x00001D1B
		[global::Cpp2ILInjected.Token(Token = "0x6000492")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B838", Offset = "0x1D8B838", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new object[] { typeof(XmlName) }, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName)
		{
			throw null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00003B1E File Offset: 0x00001D1E
		[global::Cpp2ILInjected.Token(Token = "0x6000493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B91C", Offset = "0x1D8B91C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void ResetParentInElementIdAttrMap(string oldVal, string newVal)
		{
			throw null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00003B21 File Offset: 0x00001D21
		[global::Cpp2ILInjected.Token(Token = "0x6000494")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8C170", Offset = "0x1D8C170", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "CloneNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "AddNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal XmlAttribute InternalAppendAttribute(XmlAttribute node)
		{
			throw null;
		}
	}
}
