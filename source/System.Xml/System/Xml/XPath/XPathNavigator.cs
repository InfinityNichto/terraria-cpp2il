using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath
{
	// Token: 0x0200008D RID: 141
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[global::Cpp2ILInjected.Token(Token = "0x20000B7")]
	public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x00004451 File Offset: 0x00002651
		[global::Cpp2ILInjected.Token(Token = "0x60007D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1A38", Offset = "0x1DB1A38", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00004454 File Offset: 0x00002654
		[global::Cpp2ILInjected.Token(Token = "0x170001DD")]
		public override XmlSchemaType XmlType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1A44", Offset = "0x1DB1A44", Length = "0x188")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00004457 File Offset: 0x00002657
		[global::Cpp2ILInjected.Token(Token = "0x170001DE")]
		public override object TypedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1BCC", Offset = "0x1DB1BCC", Length = "0x2CC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0000445A File Offset: 0x0000265A
		[global::Cpp2ILInjected.Token(Token = "0x170001DF")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1E98", Offset = "0x1DB1E98", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0000445D File Offset: 0x0000265D
		[global::Cpp2ILInjected.Token(Token = "0x170001E0")]
		public override bool ValueAsBoolean
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB20A4", Offset = "0x1DB20A4", Length = "0x2BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00004460 File Offset: 0x00002660
		[global::Cpp2ILInjected.Token(Token = "0x170001E1")]
		public override DateTime ValueAsDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB2360", Offset = "0x1DB2360", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00004463 File Offset: 0x00002663
		[global::Cpp2ILInjected.Token(Token = "0x170001E2")]
		public override double ValueAsDouble
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB2624", Offset = "0x1DB2624", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00004466 File Offset: 0x00002666
		[global::Cpp2ILInjected.Token(Token = "0x170001E3")]
		public override int ValueAsInt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB28E8", Offset = "0x1DB28E8", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00004469 File Offset: 0x00002669
		[global::Cpp2ILInjected.Token(Token = "0x170001E4")]
		public override long ValueAsLong
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB2BAC", Offset = "0x1DB2BAC", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0000446C File Offset: 0x0000266C
		[global::Cpp2ILInjected.Token(Token = "0x60007DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB2E70", Offset = "0x1DB2E70", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0000446F File Offset: 0x0000266F
		[global::Cpp2ILInjected.Token(Token = "0x60007DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3154", Offset = "0x1DB3154", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private object System.ICloneable.Clone()
		{
			throw null;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000750 RID: 1872
		[global::Cpp2ILInjected.Token(Token = "0x170001E5")]
		public abstract XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007DE")]
			get;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00004472 File Offset: 0x00002672
		[global::Cpp2ILInjected.Token(Token = "0x60007DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3164", Offset = "0x1DB3164", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual string LookupNamespace(string prefix)
		{
			throw null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00004475 File Offset: 0x00002675
		[global::Cpp2ILInjected.Token(Token = "0x60007E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3300", Offset = "0x1DB3300", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual string LookupPrefix(string namespaceURI)
		{
			throw null;
		}

		// Token: 0x06000753 RID: 1875
		[global::Cpp2ILInjected.Token(Token = "0x60007E1")]
		public abstract XPathNavigator Clone();

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000754 RID: 1876
		[global::Cpp2ILInjected.Token(Token = "0x170001E6")]
		public abstract XPathNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E2")]
			get;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000755 RID: 1877
		[global::Cpp2ILInjected.Token(Token = "0x170001E7")]
		public abstract string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E3")]
			get;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000756 RID: 1878
		[global::Cpp2ILInjected.Token(Token = "0x170001E8")]
		public abstract string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E4")]
			get;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000757 RID: 1879
		[global::Cpp2ILInjected.Token(Token = "0x170001E9")]
		public abstract string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E5")]
			get;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00004478 File Offset: 0x00002678
		[global::Cpp2ILInjected.Token(Token = "0x170001EA")]
		public virtual object UnderlyingObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB34E8", Offset = "0x1DB34E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000447B File Offset: 0x0000267B
		[global::Cpp2ILInjected.Token(Token = "0x60007E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB34F0", Offset = "0x1DB34F0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public virtual bool MoveToNamespace(string name)
		{
			throw null;
		}

		// Token: 0x0600075A RID: 1882
		[global::Cpp2ILInjected.Token(Token = "0x60007E8")]
		public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

		// Token: 0x0600075B RID: 1883
		[global::Cpp2ILInjected.Token(Token = "0x60007E9")]
		public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

		// Token: 0x0600075C RID: 1884
		[global::Cpp2ILInjected.Token(Token = "0x60007EA")]
		public abstract bool MoveToParent();

		// Token: 0x0600075D RID: 1885
		[global::Cpp2ILInjected.Token(Token = "0x60007EB")]
		public abstract bool IsSamePosition(XPathNavigator other);

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0000447E File Offset: 0x0000267E
		[global::Cpp2ILInjected.Token(Token = "0x170001EB")]
		public virtual IXmlSchemaInfo SchemaInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB3590", Offset = "0x1DB3590", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00004481 File Offset: 0x00002681
		[global::Cpp2ILInjected.Token(Token = "0x60007ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB35D8", Offset = "0x1DB35D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNode), Member = "get_IsText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static bool IsText(XPathNodeType type)
		{
			throw null;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00004484 File Offset: 0x00002684
		[global::Cpp2ILInjected.Token(Token = "0x60007EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB35E8", Offset = "0x1DB35E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(XPathNode[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XPathNavigator()
		{
			throw null;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00004487 File Offset: 0x00002687
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60007EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB35F0", Offset = "0x1DB35F0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static XPathNavigator()
		{
			throw null;
		}

		// Token: 0x04000286 RID: 646
		[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
		internal static readonly XPathNavigatorKeyComparer comparer;

		// Token: 0x04000287 RID: 647
		[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
		internal static readonly char[] NodeTypeLetter;

		// Token: 0x04000288 RID: 648
		[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
		internal static readonly char[] UniqueIdTbl;

		// Token: 0x04000289 RID: 649
		[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
		internal static readonly int[] ContentKindMasks;
	}
}
