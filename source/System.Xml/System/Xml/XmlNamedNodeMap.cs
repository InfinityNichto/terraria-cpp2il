using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000059 RID: 89
	[global::Cpp2ILInjected.Token(Token = "0x2000076")]
	public class XmlNamedNodeMap : IEnumerable
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x00003E69 File Offset: 0x00002069
		[global::Cpp2ILInjected.Token(Token = "0x60005AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91550", Offset = "0x1D91550", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "get_Entities", ReturnType = typeof(XmlNamedNodeMap))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal XmlNamedNodeMap(XmlNode parent)
		{
			throw null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00003E6C File Offset: 0x0000206C
		[global::Cpp2ILInjected.Token(Token = "0x60005AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D97B04", Offset = "0x1D97B04", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlNode GetNamedItem(string name)
		{
			throw null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00003E6F File Offset: 0x0000206F
		[global::Cpp2ILInjected.Token(Token = "0x60005AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D97D54", Offset = "0x1D97D54", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		public virtual XmlNode SetNamedItem(XmlNode node)
		{
			throw null;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00003E72 File Offset: 0x00002072
		[global::Cpp2ILInjected.Token(Token = "0x17000171")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D97F7C", Offset = "0x1D97F7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00003E75 File Offset: 0x00002075
		[global::Cpp2ILInjected.Token(Token = "0x60005B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D98020", Offset = "0x1D98020", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00003E78 File Offset: 0x00002078
		[global::Cpp2ILInjected.Token(Token = "0x60005B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D97B9C", Offset = "0x1D97B9C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "GetNamedItem", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int FindNodeOffset(string name)
		{
			throw null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00003E7B File Offset: 0x0000207B
		[global::Cpp2ILInjected.Token(Token = "0x60005B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D97E10", Offset = "0x1D97E10", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "SetNamedItem", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "SetNamedItem", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int FindNodeOffset(string localName, string namespaceURI)
		{
			throw null;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00003E7E File Offset: 0x0000207E
		[global::Cpp2ILInjected.Token(Token = "0x60005B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D98120", Offset = "0x1D98120", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual XmlNode AddNode(XmlNode node)
		{
			throw null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00003E81 File Offset: 0x00002081
		[global::Cpp2ILInjected.Token(Token = "0x60005B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D98394", Offset = "0x1D98394", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNodeChangedEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00003E84 File Offset: 0x00002084
		[global::Cpp2ILInjected.Token(Token = "0x60005B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D98430", Offset = "0x1D98430", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "SetNamedItem", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveNodeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual XmlNode RemoveNodeAt(int i)
		{
			throw null;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00003E87 File Offset: 0x00002087
		[global::Cpp2ILInjected.Token(Token = "0x60005B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D97F28", Offset = "0x1D97F28", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			throw null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00003E8A File Offset: 0x0000208A
		[global::Cpp2ILInjected.Token(Token = "0x60005B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D98660", Offset = "0x1D98660", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertNodeAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			throw null;
		}

		// Token: 0x040001F3 RID: 499
		[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal XmlNode parent;

		// Token: 0x040001F4 RID: 500
		[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal XmlNamedNodeMap.SmallXmlNodeList nodes;

		// Token: 0x02000164 RID: 356
		[global::Cpp2ILInjected.Token(Token = "0x2000077")]
		internal struct SmallXmlNodeList
		{
			// Token: 0x17000367 RID: 871
			// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0000536F File Offset: 0x0000356F
			[global::Cpp2ILInjected.Token(Token = "0x17000172")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x60005B8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D97F84", Offset = "0x1D97F84", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000368 RID: 872
			[global::Cpp2ILInjected.Token(Token = "0x17000173")]
			public object this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x60005B9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D97C78", Offset = "0x1D97C78", Length = "0xDC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlAttribute))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
				{
					typeof(Array),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "GetNamedItem", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlNode))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new object[]
				{
					typeof(string),
					typeof(string)
				}, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlNode))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00005375 File Offset: 0x00003575
			[global::Cpp2ILInjected.Token(Token = "0x60005BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98284", Offset = "0x1D98284", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "Insert", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNodeForLoad", MemberParameters = new object[]
			{
				typeof(XmlNode),
				typeof(XmlDocument)
			}, ReturnType = typeof(XmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void Add(object value)
			{
				throw null;
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00005378 File Offset: 0x00003578
			[global::Cpp2ILInjected.Token(Token = "0x60005BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98580", Offset = "0x1D98580", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x0000537B File Offset: 0x0000357B
			[global::Cpp2ILInjected.Token(Token = "0x60005BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D987CC", Offset = "0x1D987CC", Length = "0x194")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "InsertNodeAt", MemberParameters = new object[]
			{
				typeof(int),
				typeof(XmlNode)
			}, ReturnType = typeof(XmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap.SmallXmlNodeList), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void Insert(int index, object value)
			{
				throw null;
			}

			// Token: 0x06000CB4 RID: 3252 RVA: 0x0000537E File Offset: 0x0000357E
			[global::Cpp2ILInjected.Token(Token = "0x60005BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98028", Offset = "0x1D98028", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040005EA RID: 1514
			[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private object field;

			// Token: 0x0200018C RID: 396
			[global::Cpp2ILInjected.Token(Token = "0x2000078")]
			private class SingleObjectEnumerator : IEnumerator
			{
				// Token: 0x06000CDC RID: 3292 RVA: 0x000053F0 File Offset: 0x000035F0
				[global::Cpp2ILInjected.Token(Token = "0x60005BE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D98960", Offset = "0x1D98960", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public SingleObjectEnumerator(object value)
				{
					throw null;
				}

				// Token: 0x1700036B RID: 875
				// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000053F3 File Offset: 0x000035F3
				[global::Cpp2ILInjected.Token(Token = "0x17000174")]
				public object Current
				{
					[global::Cpp2ILInjected.Token(Token = "0x60005BF")]
					[global::Cpp2ILInjected.Address(RVA = "0x1D98990", Offset = "0x1D98990", Length = "0x4C")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06000CDE RID: 3294 RVA: 0x000053F6 File Offset: 0x000035F6
				[global::Cpp2ILInjected.Token(Token = "0x60005C0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D989DC", Offset = "0x1D989DC", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public bool MoveNext()
				{
					throw null;
				}

				// Token: 0x06000CDF RID: 3295 RVA: 0x000053F9 File Offset: 0x000035F9
				[global::Cpp2ILInjected.Token(Token = "0x60005C1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D989F8", Offset = "0x1D989F8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void Reset()
				{
					throw null;
				}

				// Token: 0x040006B9 RID: 1721
				[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private object loneValue;

				// Token: 0x040006BA RID: 1722
				[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private int position;
			}
		}
	}
}
