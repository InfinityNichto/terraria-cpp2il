using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002E6 RID: 742
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003E6")]
	public abstract class MemberDescriptor
	{
		// Token: 0x060017F1 RID: 6129 RVA: 0x00007175 File Offset: 0x00005375
		[global::Cpp2ILInjected.Token(Token = "0x6001A5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E675D0", Offset = "0x1E675D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected MemberDescriptor(string name)
		{
			throw null;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00007178 File Offset: 0x00005378
		[global::Cpp2ILInjected.Token(Token = "0x6001A5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E675D8", Offset = "0x1E675D8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(EventInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		protected MemberDescriptor(string name, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0000717B File Offset: 0x0000537B
		[global::Cpp2ILInjected.Token(Token = "0x6001A5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E67768", Offset = "0x1E67768", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(MemberDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(MemberDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected MemberDescriptor(MemberDescriptor descr)
		{
			throw null;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0000717E File Offset: 0x0000537E
		[global::Cpp2ILInjected.Token(Token = "0x6001A5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6786C", Offset = "0x1E6786C", Length = "0x3F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ReflectPropertyDescriptor),
			typeof(Type),
			typeof(IExtenderProvider),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(EventDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
		{
			throw null;
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x00007181 File Offset: 0x00005381
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x00007184 File Offset: 0x00005384
		[global::Cpp2ILInjected.Token(Token = "0x1700060C")]
		protected virtual Attribute[] AttributeArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E67C60", Offset = "0x1E67C60", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E68454", Offset = "0x1E68454", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00007187 File Offset: 0x00005387
		[global::Cpp2ILInjected.Token(Token = "0x1700060D")]
		public virtual AttributeCollection Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E68518", Offset = "0x1E68518", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0000718A File Offset: 0x0000538A
		[global::Cpp2ILInjected.Token(Token = "0x1700060E")]
		public virtual string Category
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E68604", Offset = "0x1E68604", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CategoryAttribute), Member = "get_Category", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0000718D File Offset: 0x0000538D
		[global::Cpp2ILInjected.Token(Token = "0x1700060F")]
		public virtual string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E68700", Offset = "0x1E68700", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00007190 File Offset: 0x00005390
		[global::Cpp2ILInjected.Token(Token = "0x17000610")]
		public virtual bool IsBrowsable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E68800", Offset = "0x1E68800", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00007193 File Offset: 0x00005393
		[global::Cpp2ILInjected.Token(Token = "0x17000611")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E688D8", Offset = "0x1E688D8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x00007196 File Offset: 0x00005396
		[global::Cpp2ILInjected.Token(Token = "0x17000612")]
		protected virtual int NameHashCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E68928", Offset = "0x1E68928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00007199 File Offset: 0x00005399
		[global::Cpp2ILInjected.Token(Token = "0x17000613")]
		public virtual bool DesignTimeOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E68930", Offset = "0x1E68930", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x0000719C File Offset: 0x0000539C
		[global::Cpp2ILInjected.Token(Token = "0x17000614")]
		public virtual string DisplayName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E68A18", Offset = "0x1E68A18", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "get_DisplayName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0000719F File Offset: 0x0000539F
		[global::Cpp2ILInjected.Token(Token = "0x6001A68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E67C80", Offset = "0x1E67C80", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = "get_AttributeArray", ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CheckAttributesValid()
		{
			throw null;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000071A2 File Offset: 0x000053A2
		[global::Cpp2ILInjected.Token(Token = "0x6001A69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E68B38", Offset = "0x1E68B38", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual AttributeCollection CreateAttributeCollection()
		{
			throw null;
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000071A5 File Offset: 0x000053A5
		[global::Cpp2ILInjected.Token(Token = "0x6001A6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E68BAC", Offset = "0x1E68BAC", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000071A8 File Offset: 0x000053A8
		[global::Cpp2ILInjected.Token(Token = "0x6001A6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E68DEC", Offset = "0x1E68DEC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void FillAttributes(IList attributeList)
		{
			throw null;
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000071AB File Offset: 0x000053AB
		[global::Cpp2ILInjected.Token(Token = "0x6001A6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E67D30", Offset = "0x1E67D30", Length = "0x724")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = "get_AttributeArray", ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		private void FilterAttributesIfNeeded()
		{
			throw null;
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000071AE File Offset: 0x000053AE
		[global::Cpp2ILInjected.Token(Token = "0x6001A6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E68EC8", Offset = "0x1E68EC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillMethods", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType)
		{
			throw null;
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000071B1 File Offset: 0x000053B1
		[global::Cpp2ILInjected.Token(Token = "0x6001A6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E68ED0", Offset = "0x1E68ED0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly)
		{
			throw null;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000071B4 File Offset: 0x000053B4
		[global::Cpp2ILInjected.Token(Token = "0x6001A6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E68F64", Offset = "0x1E68F64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000071B7 File Offset: 0x000053B7
		[global::Cpp2ILInjected.Token(Token = "0x6001A70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E68F6C", Offset = "0x1E68F6C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "GetInvocationTarget", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected virtual object GetInvocationTarget(Type type, object instance)
		{
			throw null;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000071BA File Offset: 0x000053BA
		[global::Cpp2ILInjected.Token(Token = "0x6001A71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E69700", Offset = "0x1E69700", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "get_DisplayName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "AddEventHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Delegate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "RemoveEventHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Delegate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object),
			typeof(object),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected static ISite GetSite(object component)
		{
			throw null;
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000071BD File Offset: 0x000053BD
		[Obsolete("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x6001A72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E697F4", Offset = "0x1E697F4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAssociation", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected static object GetInvokee(Type componentClass, object component)
		{
			throw null;
		}

		// Token: 0x04000EEC RID: 3820
		[global::Cpp2ILInjected.Token(Token = "0x400130D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04000EED RID: 3821
		[global::Cpp2ILInjected.Token(Token = "0x400130E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string displayName;

		// Token: 0x04000EEE RID: 3822
		[global::Cpp2ILInjected.Token(Token = "0x400130F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int nameHash;

		// Token: 0x04000EEF RID: 3823
		[global::Cpp2ILInjected.Token(Token = "0x4001310")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AttributeCollection attributeCollection;

		// Token: 0x04000EF0 RID: 3824
		[global::Cpp2ILInjected.Token(Token = "0x4001311")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Attribute[] attributes;

		// Token: 0x04000EF1 RID: 3825
		[global::Cpp2ILInjected.Token(Token = "0x4001312")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Attribute[] originalAttributes;

		// Token: 0x04000EF2 RID: 3826
		[global::Cpp2ILInjected.Token(Token = "0x4001313")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool attributesFiltered;

		// Token: 0x04000EF3 RID: 3827
		[global::Cpp2ILInjected.Token(Token = "0x4001314")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool attributesFilled;

		// Token: 0x04000EF4 RID: 3828
		[global::Cpp2ILInjected.Token(Token = "0x4001315")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int metadataVersion;

		// Token: 0x04000EF5 RID: 3829
		[global::Cpp2ILInjected.Token(Token = "0x4001316")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string category;

		// Token: 0x04000EF6 RID: 3830
		[global::Cpp2ILInjected.Token(Token = "0x4001317")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string description;

		// Token: 0x04000EF7 RID: 3831
		[global::Cpp2ILInjected.Token(Token = "0x4001318")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private object lockCookie;
	}
}
